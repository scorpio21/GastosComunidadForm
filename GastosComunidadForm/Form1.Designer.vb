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
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblDescripción = New System.Windows.Forms.Label()
        Me.btnAgregarGasto = New System.Windows.Forms.Button()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.lblSaldo = New System.Windows.Forms.Label()
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
        CType(Me.dgvDeudas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(110, 6)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(173, 26)
        Me.txtDescripcion.TabIndex = 0
        '
        'lblDescripción
        '
        Me.lblDescripción.AutoSize = True
        Me.lblDescripción.Location = New System.Drawing.Point(12, 9)
        Me.lblDescripción.Name = "lblDescripción"
        Me.lblDescripción.Size = New System.Drawing.Size(92, 20)
        Me.lblDescripción.TabIndex = 1
        Me.lblDescripción.Text = "Descripción"
        '
        'btnAgregarGasto
        '
        Me.btnAgregarGasto.Location = New System.Drawing.Point(125, 70)
        Me.btnAgregarGasto.Name = "btnAgregarGasto"
        Me.btnAgregarGasto.Size = New System.Drawing.Size(158, 35)
        Me.btnAgregarGasto.TabIndex = 2
        Me.btnAgregarGasto.Text = "Agregar Gasto"
        Me.btnAgregarGasto.UseVisualStyleBackColor = True
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(41, 33)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(54, 20)
        Me.lblMonto.TabIndex = 4
        Me.lblMonto.Text = "Monto"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(110, 38)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(173, 26)
        Me.txtMonto.TabIndex = 5
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(294, 192)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(129, 20)
        Me.lblSaldo.TabIndex = 6
        Me.lblSaldo.Text = "Saldo pendiente:"
        '
        'lblDeudaCasa
        '
        Me.lblDeudaCasa.AutoSize = True
        Me.lblDeudaCasa.Location = New System.Drawing.Point(6, 113)
        Me.lblDeudaCasa.Name = "lblDeudaCasa"
        Me.lblDeudaCasa.Size = New System.Drawing.Size(98, 20)
        Me.lblDeudaCasa.TabIndex = 7
        Me.lblDeudaCasa.Text = "Deuda Casa"
        '
        'txtDeudaCasa
        '
        Me.txtDeudaCasa.Location = New System.Drawing.Point(110, 113)
        Me.txtDeudaCasa.Name = "txtDeudaCasa"
        Me.txtDeudaCasa.Size = New System.Drawing.Size(173, 26)
        Me.txtDeudaCasa.TabIndex = 8
        '
        'lblDeudaGaraje
        '
        Me.lblDeudaGaraje.AutoSize = True
        Me.lblDeudaGaraje.Location = New System.Drawing.Point(-5, 148)
        Me.lblDeudaGaraje.Name = "lblDeudaGaraje"
        Me.lblDeudaGaraje.Size = New System.Drawing.Size(109, 20)
        Me.lblDeudaGaraje.TabIndex = 9
        Me.lblDeudaGaraje.Text = "Deuda Garaje"
        '
        'txtDeudaGaraje
        '
        Me.txtDeudaGaraje.Location = New System.Drawing.Point(110, 145)
        Me.txtDeudaGaraje.Name = "txtDeudaGaraje"
        Me.txtDeudaGaraje.Size = New System.Drawing.Size(173, 26)
        Me.txtDeudaGaraje.TabIndex = 10
        '
        'btnGuardarDeudas
        '
        Me.btnGuardarDeudas.Location = New System.Drawing.Point(110, 177)
        Me.btnGuardarDeudas.Name = "btnGuardarDeudas"
        Me.btnGuardarDeudas.Size = New System.Drawing.Size(158, 35)
        Me.btnGuardarDeudas.TabIndex = 11
        Me.btnGuardarDeudas.Text = "Guardar Deudas"
        Me.btnGuardarDeudas.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(304, 236)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(44, 20)
        Me.lblMensaje.TabIndex = 13
        Me.lblMensaje.Text = "Error"
        '
        'dgvDeudas
        '
        Me.dgvDeudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDeudas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Comunidad, Me.Fecha, Me.Pagado, Me.Deuda, Me.Saldo})
        Me.dgvDeudas.Location = New System.Drawing.Point(308, 9)
        Me.dgvDeudas.Name = "dgvDeudas"
        Me.dgvDeudas.RowHeadersWidth = 51
        Me.dgvDeudas.RowTemplate.Height = 24
        Me.dgvDeudas.Size = New System.Drawing.Size(682, 150)
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
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(1038, 450)
        Me.Controls.Add(Me.dgvDeudas)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.btnGuardarDeudas)
        Me.Controls.Add(Me.txtDeudaGaraje)
        Me.Controls.Add(Me.lblDeudaGaraje)
        Me.Controls.Add(Me.txtDeudaCasa)
        Me.Controls.Add(Me.lblDeudaCasa)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.btnAgregarGasto)
        Me.Controls.Add(Me.lblDescripción)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Name = "Form1"
        Me.Text = "Control de Gastos Comunidad"
        CType(Me.dgvDeudas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblDescripción As Label
    Friend WithEvents btnAgregarGasto As Button
    Friend WithEvents lblMonto As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents lblSaldo As Label
    Friend WithEvents lblDeudaCasa As Label
    Friend WithEvents txtDeudaCasa As TextBox
    Friend WithEvents lblDeudaGaraje As Label
    Friend WithEvents txtDeudaGaraje As TextBox
    Friend WithEvents btnGuardarDeudas As Button
    Friend WithEvents lblMensaje As Label
    Friend WithEvents dgvDeudas As DataGridView
    Friend WithEvents Comunidad As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Pagado As DataGridViewTextBoxColumn
    Friend WithEvents Deuda As DataGridViewTextBoxColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
End Class
