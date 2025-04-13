Imports MySql.Data.MySqlClient

Public Class Form1

    ' Cadena de conexión a la base de datos
    Private connectionString As String = "Server=localhost;Database=gastos_db;Uid=root;Pwd="

    ' Variables para almacenar las deudas
    Private deudaCasa As Decimal = 0.0D
    Private deudaGaraje As Decimal = 0.0D

#Region "Deudas"

    ' Configurar las columnas del DataGridView de Deudas
    Private Sub ConfigurarDataGridView()
        dgvDeudas.Columns.Clear()

        dgvDeudas.Columns.Add("Comunidad", "Comunidad")
        dgvDeudas.Columns.Add("Fecha", "Fecha")
        dgvDeudas.Columns.Add("Pagado", "Pagado")
        dgvDeudas.Columns.Add("Deuda", "Deuda")
        dgvDeudas.Columns.Add("Saldo", "Saldo")

        dgvDeudas.Columns("Comunidad").ReadOnly = True
        dgvDeudas.Columns("Fecha").ReadOnly = True
        dgvDeudas.Columns("Pagado").ReadOnly = False
        dgvDeudas.Columns("Deuda").ReadOnly = True
        dgvDeudas.Columns("Saldo").ReadOnly = True
    End Sub

    ' Cargar las deudas desde la base de datos
    Private Sub CargarDeudas()
        dgvDeudas.Rows.Clear()

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT comunidad, deuda, fecha, pagado, saldo FROM deudas"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            ' Comprobamos si los valores son DBNull antes de asignarlos
                            Dim comunidad As String = If(IsDBNull(reader("comunidad")), String.Empty, reader("comunidad").ToString())
                            Dim deuda As Decimal = If(IsDBNull(reader("deuda")), 0D, Convert.ToDecimal(reader("deuda")))
                            Dim fecha As String = If(IsDBNull(reader("fecha")), String.Empty, Convert.ToDateTime(reader("fecha")).ToShortDateString())
                            Dim pagado As Decimal = If(IsDBNull(reader("pagado")), 0D, Convert.ToDecimal(reader("pagado")))
                            Dim saldo As Decimal = If(IsDBNull(reader("saldo")), 0D, Convert.ToDecimal(reader("saldo")))

                            ' Añadir los datos al DataGridView
                            dgvDeudas.Rows.Add(comunidad, fecha, pagado, deuda, saldo)
                        End While
                    End Using
                End Using

                ' Actualizar mensaje
                lblMensaje.Text = "Deudas cargadas correctamente."
                IniciarParpadeo()

                ' Refrescar el DataGridView
                dgvDeudas.Refresh()

            Catch ex As Exception
                lblMensaje.Text = "No se pudieron cargar las deudas. Error: " & ex.Message
                IniciarParpadeo() ' Hacer parpadear el mensaje de error
                MessageBox.Show("Error al cargar las deudas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Mostrar el error en un MessageBox
            End Try
        End Using
    End Sub



    ' Guardar las deudas en la base de datos
    Private Sub GuardarDeudas()
        Dim deudaCasa As Decimal
        Dim deudaGaraje As Decimal
        Dim deudaValida As Boolean = False ' Variable para asegurarse que al menos una deuda sea válida

        ' Intentamos parsear las deudas de Casa y Garaje
        If Decimal.TryParse(txtDeudaCasa.Text, deudaCasa) Then
            deudaValida = True ' Si se parsea correctamente la deuda de Casa, marcamos como válida
        End If

        If Decimal.TryParse(txtDeudaGaraje.Text, deudaGaraje) Then
            deudaValida = True ' Si se parsea correctamente la deuda de Garaje, marcamos como válida
        End If

        ' Verificamos si al menos una deuda es válida
        If deudaValida Then
            Using conn As New MySqlConnection("server=localhost;user id=root;database=gastos_db")
                Try
                    conn.Open()
                    ' Consulta SQL para insertar o actualizar las deudas
                    Dim query As String = "INSERT INTO deudas (comunidad, deuda, fecha, saldo) VALUES (@comunidad, @deuda, @fecha, @saldo) " &
                                      "ON DUPLICATE KEY UPDATE deuda = deuda + @deuda, saldo = saldo + @saldo, fecha = @fecha"

                    Using cmd As New MySqlCommand(query, conn)
                        Dim fechaSeleccionada As String = dtpFecha.Value.ToString("yyyy-MM-dd")

                        ' Verificar si hay deuda para Casa y guardarla
                        If deudaCasa > 0 Then
                            cmd.Parameters.AddWithValue("@comunidad", "Casa")
                            cmd.Parameters.AddWithValue("@deuda", deudaCasa)
                            cmd.Parameters.AddWithValue("@fecha", fechaSeleccionada)
                            cmd.Parameters.AddWithValue("@saldo", deudaCasa)
                            cmd.ExecuteNonQuery()
                        End If

                        ' Verificar si hay deuda para Garaje y guardarla
                        If deudaGaraje > 0 Then
                            cmd.Parameters.Clear() ' Limpiar parámetros
                            cmd.Parameters.AddWithValue("@comunidad", "Garaje")
                            cmd.Parameters.AddWithValue("@deuda", deudaGaraje)
                            cmd.Parameters.AddWithValue("@fecha", fechaSeleccionada)
                            cmd.Parameters.AddWithValue("@saldo", deudaGaraje)
                            cmd.ExecuteNonQuery()
                        End If
                    End Using

                    ' Limpiar los campos de entrada
                    txtDeudaCasa.Clear()
                    txtDeudaGaraje.Clear()

                    ' Recargar las deudas
                    CargarDeudas()

                    MessageBox.Show("Deudas guardadas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    MessageBox.Show("Error al guardar las deudas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        Else
            MessageBox.Show("Por favor, ingresa valores válidos para las deudas de Casa y Garaje.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub



#End Region

#Region "Pagos y Historial"

    ' Botón para agregar pagos y actualizar deuda
    Private Sub btnAgregarPagos_Click(sender As Object, e As EventArgs) Handles btnAgregarPagos.Click
        ' Validar que se haya seleccionado una comunidad
        If cmbComunidad.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, seleccioná una comunidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim comunidadSeleccionada As String = cmbComunidad.SelectedItem.ToString()
        Dim pago As Decimal
        Dim deuda As Decimal = 0.0D
        Dim saldo As Decimal = 0.0D
        Dim fechaSeleccionada As String = dtpFecha.Value.ToString("yyyy-MM-dd")

        ' Validar que el campo pagos sea un número válido
        If Not Decimal.TryParse(txtPagos.Text, pago) OrElse pago <= 0 Then
            MessageBox.Show("Por favor, ingresá un valor válido para el pago.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Buscar en el DataGridView la fila correspondiente para obtener deuda y saldo
        For Each row As DataGridViewRow In dgvDeudas.Rows
            If row.Cells("Comunidad").Value.ToString() = comunidadSeleccionada Then
                deuda = Convert.ToDecimal(row.Cells("Deuda").Value)
                saldo = Convert.ToDecimal(row.Cells("Saldo").Value)
                Exit For
            End If
        Next

        ' Verificar que el pago no sea mayor que el saldo pendiente
        If pago > saldo Then
            MessageBox.Show("El pago no puede ser mayor que el saldo pendiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                saldo -= pago

                ' Actualizar la tabla de deudas en la base de datos
                Dim updateQuery As String = "UPDATE deudas SET pagado = pagado + @pago, saldo = @saldo WHERE comunidad = @comunidad"
                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@pago", pago)
                    cmd.Parameters.AddWithValue("@saldo", saldo)
                    cmd.Parameters.AddWithValue("@comunidad", comunidadSeleccionada)
                    cmd.ExecuteNonQuery()
                End Using

                ' Insertar el pago en la tabla histórica "pagos" en la base de datos
                Dim insertQuery As String = "INSERT INTO pagos (comunidad, pago, fecha) VALUES (@comunidad, @pago, @fecha)"
                Using cmdInsert As New MySqlCommand(insertQuery, conn)
                    cmdInsert.Parameters.AddWithValue("@comunidad", comunidadSeleccionada)
                    cmdInsert.Parameters.AddWithValue("@pago", pago)
                    cmdInsert.Parameters.AddWithValue("@fecha", fechaSeleccionada)
                    cmdInsert.ExecuteNonQuery()
                End Using

                ' Limpiar el campo de pago
                txtPagos.Clear()

                ' Actualizar el dgvDeudas
                For Each row As DataGridViewRow In dgvDeudas.Rows
                    If row.Cells("Comunidad").Value.ToString() = comunidadSeleccionada Then
                        row.Cells("Saldo").Value = saldo  ' Actualizamos el saldo de la deuda
                        Exit For
                    End If
                Next

                ' Actualizar el dgvPagos
                dgvPagos.Rows.Add(comunidadSeleccionada, pago, fechaSeleccionada) ' Insertamos el nuevo pago


                ' Recargar deudas y pagos
                CargarDeudas()          ' Recargar deudas
                CargarHistorialPagos()  ' Recargar historial de pagos

            Catch ex As Exception
                MessageBox.Show("Error al agregar el pago: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub



    ' Configurar el DataGridView para el historial de pagos
    Private Sub ConfigurarDataGridViewPagos()
        dgvPagos.Columns.Clear()
        dgvPagos.Columns.Add("Comunidad", "Comunidad")
        dgvPagos.Columns.Add("Pago", "Pagos")
        dgvPagos.Columns.Add("Fecha", "Fecha")
    End Sub

    ' Cargar los pagos desde la tabla 'pagos' en el historial
    Private Sub CargarHistorialPagos()
        dgvPagos.Rows.Clear()

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT comunidad, pago, fecha FROM pagos ORDER BY fecha DESC"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim comunidad As String = reader("comunidad").ToString()
                            Dim pago As Decimal = Convert.ToDecimal(reader("pago"))
                            Dim fecha As String = Convert.ToDateTime(reader("fecha")).ToShortDateString()
                            dgvPagos.Rows.Add(comunidad, pago, fecha)
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al cargar el historial de pagos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

#End Region

#Region "Eventos y Validaciones de Controles"

    ' Evento KeyPress para txtPagos (sólo admite números y un punto decimal)
    Private Sub txtPagos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPagos.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtPagos.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    ' Timer para parpadear el mensaje
    Private WithEvents Timer As New Timer()
    Private mensajeVisible As Boolean = False
    Private contadorParpadeos As Integer = 0

    Private Sub IniciarParpadeo()
        mensajeVisible = True
        lblMensaje.Visible = True
        contadorParpadeos = 0
        Timer.Interval = 500
        Timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If contadorParpadeos < 10 Then
            lblMensaje.Visible = Not lblMensaje.Visible
            contadorParpadeos += 1
        Else
            lblMensaje.Visible = False
            Timer.Stop()
        End If
    End Sub

#End Region

    ' Formulario Load: configurar y cargar controles
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarDataGridView()    ' Configurar DataGridView de deudas
        CargarDeudas()              ' Cargar deudas desde la base de datos

        ' Configurar ComboBox de comunidad

        cmbComunidad.Items.Add("Casa")
        cmbComunidad.Items.Add("Garaje")
        cmbComunidad.DropDownStyle = ComboBoxStyle.DropDownList

        ' Configurar el valor por defecto del ComboBox como nada seleccionado
        cmbComunidad.SelectedIndex = -1  ' Ninguna comunidad seleccionada al iniciar

        ' Configurar DateTimePicker para la fecha (mostrar fecha actual)
        dtpFecha.Value = DateTime.Today

        ' Configurar DataGridView para el historial de pagos
        ConfigurarDataGridViewPagos()
        CargarHistorialPagos()
    End Sub


    Private Sub btnGuardarDeudas_Click(sender As Object, e As EventArgs) Handles btnGuardarDeudas.Click
        ' Llamamos a la función GuardarDeudas que maneja la lógica de guardado
        GuardarDeudas()
    End Sub
End Class
