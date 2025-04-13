<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblComunidad = New System.Windows.Forms.Label()
        Me.btnAgregarPagos = New System.Windows.Forms.Button()
        Me.lblPagos = New System.Windows.Forms.Label()
        Me.txtPagos = New System.Windows.Forms.TextBox()
        Me.lblDeudaCasa = New System.Windows.Forms.Label()
        Me.txtDeudaCasa = New System.Windows.Forms.TextBox()
        Me.lblDeudaGaraje = New System.Windows.Forms.Label()
        Me.txtDeudaGaraje = New System.Windows.Forms.TextBox()
        Me.btnGuardarDeudas = New System.Windows.Forms.Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.dgvDeudas = New System.Windows.Forms.DataGridView()
        Me.Comunidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deuda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmbComunidad = New System.Windows.Forms.ComboBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblAccion = New System.Windows.Forms.Label()
        Me.dgvPagos = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDeudas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblComunidad
        '
        Me.lblComunidad.AutoSize = True
        Me.lblComunidad.Location = New System.Drawing.Point(26, 9)
        Me.lblComunidad.Name = "lblComunidad"
        Me.lblComunidad.Size = New System.Drawing.Size(94, 20)
        Me.lblComunidad.TabIndex = 1
        Me.lblComunidad.Text = "Comunidad:"
        '
        'btnAgregarPagos
        '
        Me.btnAgregarPagos.Location = New System.Drawing.Point(533, 32)
        Me.btnAgregarPagos.Name = "btnAgregarPagos"
        Me.btnAgregarPagos.Size = New System.Drawing.Size(158, 35)
        Me.btnAgregarPagos.TabIndex = 2
        Me.btnAgregarPagos.Text = "Agregar Pagos:"
        Me.btnAgregarPagos.UseVisualStyleBackColor = True
        '
        'lblPagos
        '
        Me.lblPagos.AutoSize = True
        Me.lblPagos.Location = New System.Drawing.Point(194, 9)
        Me.lblPagos.Name = "lblPagos"
        Me.lblPagos.Size = New System.Drawing.Size(58, 20)
        Me.lblPagos.TabIndex = 4
        Me.lblPagos.Text = "Pagos:"
        '
        'txtPagos
        '
        Me.txtPagos.Location = New System.Drawing.Point(148, 36)
        Me.txtPagos.Name = "txtPagos"
        Me.txtPagos.Size = New System.Drawing.Size(173, 26)
        Me.txtPagos.TabIndex = 5
        '
        'lblDeudaCasa
        '
        Me.lblDeudaCasa.AutoSize = True
        Me.lblDeudaCasa.Location = New System.Drawing.Point(26, 77)
        Me.lblDeudaCasa.Name = "lblDeudaCasa"
        Me.lblDeudaCasa.Size = New System.Drawing.Size(102, 20)
        Me.lblDeudaCasa.TabIndex = 7
        Me.lblDeudaCasa.Text = "Deuda Casa:"
        '
        'txtDeudaCasa
        '
        Me.txtDeudaCasa.Location = New System.Drawing.Point(12, 100)
        Me.txtDeudaCasa.Name = "txtDeudaCasa"
        Me.txtDeudaCasa.Size = New System.Drawing.Size(121, 26)
        Me.txtDeudaCasa.TabIndex = 8
        '
        'lblDeudaGaraje
        '
        Me.lblDeudaGaraje.AutoSize = True
        Me.lblDeudaGaraje.Location = New System.Drawing.Point(158, 77)
        Me.lblDeudaGaraje.Name = "lblDeudaGaraje"
        Me.lblDeudaGaraje.Size = New System.Drawing.Size(113, 20)
        Me.lblDeudaGaraje.TabIndex = 9
        Me.lblDeudaGaraje.Text = "Deuda Garaje:"
        '
        'txtDeudaGaraje
        '
        Me.txtDeudaGaraje.Location = New System.Drawing.Point(148, 100)
        Me.txtDeudaGaraje.Name = "txtDeudaGaraje"
        Me.txtDeudaGaraje.Size = New System.Drawing.Size(135, 26)
        Me.txtDeudaGaraje.TabIndex = 10
        '
        'btnGuardarDeudas
        '
        Me.btnGuardarDeudas.Location = New System.Drawing.Point(313, 96)
        Me.btnGuardarDeudas.Name = "btnGuardarDeudas"
        Me.btnGuardarDeudas.Size = New System.Drawing.Size(158, 35)
        Me.btnGuardarDeudas.TabIndex = 11
        Me.btnGuardarDeudas.Text = "Guardar Deudas"
        Me.btnGuardarDeudas.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(8, 504)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(44, 20)
        Me.lblMensaje.TabIndex = 13
        Me.lblMensaje.Text = "Error"
        '
        'dgvDeudas
        '
        Me.dgvDeudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDeudas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Comunidad, Me.Fecha, Me.Pagado, Me.Deuda, Me.Saldo})
        Me.dgvDeudas.Location = New System.Drawing.Point(6, 137)
        Me.dgvDeudas.Name = "dgvDeudas"
        Me.dgvDeudas.RowHeadersWidth = 51
        Me.dgvDeudas.RowTemplate.Height = 24
        Me.dgvDeudas.Size = New System.Drawing.Size(678, 220)
        Me.dgvDeudas.TabIndex = 14
        '
        'Comunidad
        '
        Me.Comunidad.HeaderText = "Comunidad"
        Me.Comunidad.MinimumWidth = 6
        Me.Comunidad.Name = "Comunidad"
        Me.Comunidad.Width = 125
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.MinimumWidth = 6
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 125
        '
        'Pagado
        '
        Me.Pagado.HeaderText = "Pagado"
        Me.Pagado.MinimumWidth = 6
        Me.Pagado.Name = "Pagado"
        Me.Pagado.Width = 125
        '
        'Deuda
        '
        Me.Deuda.HeaderText = "Deuda"
        Me.Deuda.MinimumWidth = 6
        Me.Deuda.Name = "Deuda"
        Me.Deuda.Width = 125
        '
        'Saldo
        '
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.MinimumWidth = 6
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Width = 125
        '
        'cmbComunidad
        '
        Me.cmbComunidad.FormattingEnabled = True
        Me.cmbComunidad.Location = New System.Drawing.Point(12, 36)
        Me.cmbComunidad.Name = "cmbComunidad"
        Me.cmbComunidad.Size = New System.Drawing.Size(121, 28)
        Me.cmbComunidad.TabIndex = 15
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(348, 34)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(139, 26)
        Me.dtpFecha.TabIndex = 16
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(386, 8)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(54, 20)
        Me.lblFecha.TabIndex = 17
        Me.lblFecha.Text = "Fecha"
        '
        'lblAccion
        '
        Me.lblAccion.AutoSize = True
        Me.lblAccion.Location = New System.Drawing.Point(566, 8)
        Me.lblAccion.Name = "lblAccion"
        Me.lblAccion.Size = New System.Drawing.Size(57, 20)
        Me.lblAccion.TabIndex = 18
        Me.lblAccion.Text = "Acción"
        '
        'dgvPagos
        '
        Me.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPagos.Location = New System.Drawing.Point(6, 383)
        Me.dgvPagos.Name = "dgvPagos"
        Me.dgvPagos.RowHeadersWidth = 62
        Me.dgvPagos.RowTemplate.Height = 28
        Me.dgvPagos.Size = New System.Drawing.Size(677, 92)
        Me.dgvPagos.TabIndex = 19
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(700, 558)
        Me.Controls.Add(Me.dgvPagos)
        Me.Controls.Add(Me.lblAccion)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.cmbComunidad)
        Me.Controls.Add(Me.dgvDeudas)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.btnGuardarDeudas)
        Me.Controls.Add(Me.txtDeudaGaraje)
        Me.Controls.Add(Me.lblDeudaGaraje)
        Me.Controls.Add(Me.txtDeudaCasa)
        Me.Controls.Add(Me.lblDeudaCasa)
        Me.Controls.Add(Me.txtPagos)
        Me.Controls.Add(Me.lblPagos)
        Me.Controls.Add(Me.btnAgregarPagos)
        Me.Controls.Add(Me.lblComunidad)
        Me.Name = "Form1"
        Me.Text = "Control de Gastos Comunidad"
        CType(Me.dgvDeudas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblComunidad As Label 'label para mostrar la comunidad
    Friend WithEvents btnAgregarPagos As Button 'botón para agregar pagos
    Friend WithEvents lblPagos As Label 'label para mostrar los pagos
    Friend WithEvents txtPagos As TextBox 'textbox para ingresar los pagos
    Friend WithEvents lblDeudaCasa As Label 'label para mostrar la deuda de casa
    Friend WithEvents txtDeudaCasa As TextBox 'textbox para ingresar la deuda de casa
    Friend WithEvents lblDeudaGaraje As Label   'label para mostrar la deuda de garaje
    Friend WithEvents txtDeudaGaraje As TextBox 'textbox para ingresar la deuda de garaje
    Friend WithEvents btnGuardarDeudas As Button 'botón para guardar las deudas
    Friend WithEvents lblMensaje As Label   'label para mostrar mensajes
    Friend WithEvents dgvDeudas As DataGridView 'DataGridView para mostrar las deudas
    Friend WithEvents Comunidad As DataGridViewTextBoxColumn    'DataGridViewTextBoxColumn para la comunidad
    Friend WithEvents Fecha As DataGridViewTextBoxColumn ' DataGridViewTextBoxColumn para la fecha
    Friend WithEvents Pagado As DataGridViewTextBoxColumn ' DataGridViewTextBoxColumn para el pagado
    Friend WithEvents Deuda As DataGridViewTextBoxColumn ' DataGridViewTextBoxColumn para la deuda
    Friend WithEvents Saldo As DataGridViewTextBoxColumn '   
    Friend WithEvents Timer1 As Timer ' Timer para el parpadeo del mensaje
    Friend WithEvents cmbComunidad As ComboBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblAccion As Label
    Friend WithEvents dgvPagos As DataGridView
End Class
