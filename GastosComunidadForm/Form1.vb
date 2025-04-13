Imports MySql.Data.MySqlClient

Public Class Form1

    ' Cadena de conexión a la base de datos
    Private connectionString As String = "Server=localhost;Database=gastos_db;Uid=root;Pwd="

    ' Variables para almacenar las deudas
    Private deudaCasa As Decimal = 0.0D
    Private deudaGaraje As Decimal = 0.0D

    ' Configurar las columnas del DataGridView
    Private Sub ConfigurarDataGridView()
        ' Solo se configuran las columnas una vez al cargar el formulario
        dgvDeudas.Columns.Clear()

        dgvDeudas.Columns.Add("Comunidad", "Comunidad")
        dgvDeudas.Columns.Add("Fecha", "Fecha")
        dgvDeudas.Columns.Add("Pagado", "Pagado")
        dgvDeudas.Columns.Add("Deuda", "Deuda")
        dgvDeudas.Columns.Add("Saldo", "Saldo")

        ' Establecer las columnas como editables
        dgvDeudas.Columns("Comunidad").ReadOnly = False
        dgvDeudas.Columns("Fecha").ReadOnly = False
        dgvDeudas.Columns("Pagado").ReadOnly = False
        dgvDeudas.Columns("Deuda").ReadOnly = False
        dgvDeudas.Columns("Saldo").ReadOnly = False
    End Sub

    ' Cargar las deudas desde la base de datos
    Private Sub CargarDeudas()
        ' Limpiar cualquier dato previo
        dgvDeudas.Rows.Clear()

        ' Consultar las deudas de la base de datos
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT comunidad, deuda, fecha, pagado, saldo FROM deudas"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim comunidad As String = reader("comunidad").ToString()
                            Dim deuda As Decimal = Convert.ToDecimal(reader("deuda"))
                            Dim fecha As String = Convert.ToDateTime(reader("fecha")).ToShortDateString()
                            Dim pagado As Decimal = Convert.ToDecimal(reader("pagado"))
                            Dim saldo As Decimal = Convert.ToDecimal(reader("saldo"))
                            ' Agregar las deudas al DataGridView
                            dgvDeudas.Rows.Add(comunidad, fecha, pagado, deuda, saldo)
                        End While
                    End Using
                End Using

                ' Si todo fue correcto, actualizar el mensaje en el formulario
                lblMensaje.Text = "Deudas cargadas correctamente."
                IniciarParpadeo() ' Iniciar parpadeo del mensaje

            Catch ex As Exception
                ' Si hubo un error, mostrar el mensaje de error en el formulario
                lblMensaje.Text = "No se pudieron cargar las deudas. Error: " & ex.Message
                IniciarParpadeo() ' Iniciar parpadeo del mensaje
            End Try
        End Using
    End Sub

    ' Guardar las deudas en la base de datos
    Private Sub GuardarDeudas()
        ' Asignar los valores de deuda a las variables desde los TextBox
        If Decimal.TryParse(txtDeudaCasa.Text, deudaCasa) AndAlso Decimal.TryParse(txtDeudaGaraje.Text, deudaGaraje) Then
            Using conn As New MySqlConnection(connectionString)
                Try
                    conn.Open()

                    ' Guardar las deudas para Casa y Garaje
                    Dim query As String = "INSERT INTO deudas (comunidad, deuda, fecha, saldo) VALUES (@comunidad, @deuda, @fecha, @saldo) " &
                                          "ON DUPLICATE KEY UPDATE deuda = @deuda, saldo = @saldo, fecha = @fecha"
                    Using cmd As New MySqlCommand(query, conn)
                        ' Deuda para Casa
                        cmd.Parameters.AddWithValue("@comunidad", "Casa")
                        cmd.Parameters.AddWithValue("@deuda", deudaCasa)
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd"))
                        cmd.Parameters.AddWithValue("@saldo", deudaCasa) ' Inicialmente el saldo es igual a la deuda
                        cmd.ExecuteNonQuery()

                        ' Deuda para Garaje
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@comunidad", "Garaje")
                        cmd.Parameters.AddWithValue("@deuda", deudaGaraje)
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd"))
                        cmd.Parameters.AddWithValue("@saldo", deudaGaraje) ' Inicialmente el saldo es igual a la deuda
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Limpiar los campos después de guardar las deudas
                    txtDeudaCasa.Clear()
                    txtDeudaGaraje.Clear()

                    ' Actualizar la lista de deudas
                    CargarDeudas()

                Catch ex As Exception
                    MessageBox.Show("Error al guardar las deudas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        Else
            MessageBox.Show("Por favor, ingresa valores válidos para las deudas de Casa y Garaje.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Al cargar el formulario, configurar el DataGridView y cargar las deudas
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarDataGridView() ' Configurar las columnas solo una vez
        CargarDeudas() ' Cargar las deudas desde la base de datos
    End Sub

    ' Agregar evento para guardar las deudas
    Private Sub btnGuardarDeudas_Click(sender As Object, e As EventArgs) Handles btnGuardarDeudas.Click
        GuardarDeudas()
    End Sub

    ' Timer para parpadear el mensaje
    Private WithEvents Timer As New Timer()
    Private mensajeVisible As Boolean = False
    Private contadorParpadeos As Integer = 0 ' Contador para los parpadeos

    ' Iniciar parpadeo
    Private Sub IniciarParpadeo()
        mensajeVisible = True
        lblMensaje.Visible = True
        contadorParpadeos = 0
        Timer.Interval = 500 ' Intervalo de 500 ms (medio segundo)
        Timer.Start() ' Iniciar el timer
    End Sub

    ' Evento que maneja el parpadeo
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If contadorParpadeos < 10 Then ' Hacer parpadear 10 veces
            lblMensaje.Visible = Not lblMensaje.Visible ' Alternar visibilidad
            contadorParpadeos += 1
        Else
            lblMensaje.Visible = False ' Ocultar el mensaje
            Timer.Stop() ' Detener el Timer
        End If
    End Sub


End Class
