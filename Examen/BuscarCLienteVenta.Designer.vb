<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarCLienteVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscarCLienteVenta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCorreoClienteB = New System.Windows.Forms.TextBox()
        Me.txtTelefonoClienteB = New System.Windows.Forms.TextBox()
        Me.txtNombreClienteB = New System.Windows.Forms.TextBox()
        Me.dgvClientesBuscar = New System.Windows.Forms.DataGridView()
        Me.AgregarCliente = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbCorreo = New System.Windows.Forms.CheckBox()
        Me.cbTelefono = New System.Windows.Forms.CheckBox()
        Me.cbNombre = New System.Windows.Forms.CheckBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvClientesBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnBuscarCliente)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCorreoClienteB)
        Me.GroupBox1.Controls.Add(Me.txtTelefonoClienteB)
        Me.GroupBox1.Controls.Add(Me.txtNombreClienteB)
        Me.GroupBox1.Controls.Add(Me.dgvClientesBuscar)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(816, 452)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Location = New System.Drawing.Point(502, 342)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(131, 77)
        Me.btnBuscarCliente.TabIndex = 8
        Me.btnBuscarCliente.Text = "Buscar"
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 411)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Correo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 373)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Telefono:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 334)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombre:"
        '
        'txtCorreoClienteB
        '
        Me.txtCorreoClienteB.Enabled = False
        Me.txtCorreoClienteB.Location = New System.Drawing.Point(115, 408)
        Me.txtCorreoClienteB.Name = "txtCorreoClienteB"
        Me.txtCorreoClienteB.Size = New System.Drawing.Size(309, 23)
        Me.txtCorreoClienteB.TabIndex = 4
        '
        'txtTelefonoClienteB
        '
        Me.txtTelefonoClienteB.Enabled = False
        Me.txtTelefonoClienteB.Location = New System.Drawing.Point(115, 370)
        Me.txtTelefonoClienteB.Name = "txtTelefonoClienteB"
        Me.txtTelefonoClienteB.Size = New System.Drawing.Size(309, 23)
        Me.txtTelefonoClienteB.TabIndex = 3
        '
        'txtNombreClienteB
        '
        Me.txtNombreClienteB.Enabled = False
        Me.txtNombreClienteB.Location = New System.Drawing.Point(115, 331)
        Me.txtNombreClienteB.Name = "txtNombreClienteB"
        Me.txtNombreClienteB.Size = New System.Drawing.Size(309, 23)
        Me.txtNombreClienteB.TabIndex = 2
        '
        'dgvClientesBuscar
        '
        Me.dgvClientesBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientesBuscar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AgregarCliente})
        Me.dgvClientesBuscar.Location = New System.Drawing.Point(238, 40)
        Me.dgvClientesBuscar.Name = "dgvClientesBuscar"
        Me.dgvClientesBuscar.ReadOnly = True
        Me.dgvClientesBuscar.RowHeadersVisible = False
        Me.dgvClientesBuscar.RowTemplate.Height = 25
        Me.dgvClientesBuscar.Size = New System.Drawing.Size(553, 254)
        Me.dgvClientesBuscar.TabIndex = 1
        '
        'AgregarCliente
        '
        Me.AgregarCliente.Description = "Asignar Cliente"
        Me.AgregarCliente.HeaderText = ""
        Me.AgregarCliente.Image = CType(resources.GetObject("AgregarCliente.Image"), System.Drawing.Image)
        Me.AgregarCliente.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.AgregarCliente.Name = "AgregarCliente"
        Me.AgregarCliente.ReadOnly = True
        Me.AgregarCliente.ToolTipText = "Asignar Cliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbCorreo)
        Me.GroupBox2.Controls.Add(Me.cbTelefono)
        Me.GroupBox2.Controls.Add(Me.cbNombre)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 183)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtro"
        '
        'cbCorreo
        '
        Me.cbCorreo.AutoSize = True
        Me.cbCorreo.Location = New System.Drawing.Point(30, 133)
        Me.cbCorreo.Name = "cbCorreo"
        Me.cbCorreo.Size = New System.Drawing.Size(62, 19)
        Me.cbCorreo.TabIndex = 2
        Me.cbCorreo.Text = "Correo"
        Me.cbCorreo.UseVisualStyleBackColor = True
        '
        'cbTelefono
        '
        Me.cbTelefono.AutoSize = True
        Me.cbTelefono.Location = New System.Drawing.Point(30, 84)
        Me.cbTelefono.Name = "cbTelefono"
        Me.cbTelefono.Size = New System.Drawing.Size(71, 19)
        Me.cbTelefono.TabIndex = 1
        Me.cbTelefono.Text = "Telefono"
        Me.cbTelefono.UseVisualStyleBackColor = True
        '
        'cbNombre
        '
        Me.cbNombre.AutoSize = True
        Me.cbNombre.Location = New System.Drawing.Point(30, 39)
        Me.cbNombre.Name = "cbNombre"
        Me.cbNombre.Size = New System.Drawing.Size(70, 19)
        Me.cbNombre.TabIndex = 0
        Me.cbNombre.Text = "Nombre"
        Me.cbNombre.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(660, 342)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(131, 77)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'BuscarCLienteVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 511)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BuscarCLienteVenta"
        Me.Text = "Buscar CLiente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvClientesBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCorreoClienteB As TextBox
    Friend WithEvents txtTelefonoClienteB As TextBox
    Friend WithEvents txtNombreClienteB As TextBox
    Friend WithEvents dgvClientesBuscar As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbCorreo As CheckBox
    Friend WithEvents cbTelefono As CheckBox
    Friend WithEvents cbNombre As CheckBox
    Friend WithEvents AgregarCliente As DataGridViewImageColumn
    Friend WithEvents btnCancelar As Button
End Class
