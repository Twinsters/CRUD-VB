<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DatosCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbNombreCliente = New System.Windows.Forms.Label()
        Me.lbTelefonoCliente = New System.Windows.Forms.Label()
        Me.lbCorreoCliente = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.btGuardarCliente = New System.Windows.Forms.Button()
        Me.btnSalirCancelarCliente = New System.Windows.Forms.Button()
        Me.txtCodAreaCliente = New System.Windows.Forms.TextBox()
        Me.lb = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbNombreCliente
        '
        Me.lbNombreCliente.AutoSize = True
        Me.lbNombreCliente.Location = New System.Drawing.Point(114, 68)
        Me.lbNombreCliente.Name = "lbNombreCliente"
        Me.lbNombreCliente.Size = New System.Drawing.Size(59, 15)
        Me.lbNombreCliente.TabIndex = 0
        Me.lbNombreCliente.Text = "Nombres:"
        '
        'lbTelefonoCliente
        '
        Me.lbTelefonoCliente.AutoSize = True
        Me.lbTelefonoCliente.Location = New System.Drawing.Point(114, 114)
        Me.lbTelefonoCliente.Name = "lbTelefonoCliente"
        Me.lbTelefonoCliente.Size = New System.Drawing.Size(55, 15)
        Me.lbTelefonoCliente.TabIndex = 2
        Me.lbTelefonoCliente.Text = "Telefono:"
        '
        'lbCorreoCliente
        '
        Me.lbCorreoCliente.AutoSize = True
        Me.lbCorreoCliente.Location = New System.Drawing.Point(114, 159)
        Me.lbCorreoCliente.Name = "lbCorreoCliente"
        Me.lbCorreoCliente.Size = New System.Drawing.Size(46, 15)
        Me.lbCorreoCliente.TabIndex = 3
        Me.lbCorreoCliente.Text = "Correo:"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(175, 65)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(268, 23)
        Me.txtNombreCliente.TabIndex = 1
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(261, 111)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(179, 23)
        Me.txtTelefono.TabIndex = 3
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(175, 156)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(268, 23)
        Me.txtCorreo.TabIndex = 4
        '
        'btGuardarCliente
        '
        Me.btGuardarCliente.Location = New System.Drawing.Point(194, 238)
        Me.btGuardarCliente.Name = "btGuardarCliente"
        Me.btGuardarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btGuardarCliente.TabIndex = 5
        Me.btGuardarCliente.Text = "Guardar"
        Me.btGuardarCliente.UseVisualStyleBackColor = True
        '
        'btnSalirCancelarCliente
        '
        Me.btnSalirCancelarCliente.Location = New System.Drawing.Point(326, 238)
        Me.btnSalirCancelarCliente.Name = "btnSalirCancelarCliente"
        Me.btnSalirCancelarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnSalirCancelarCliente.TabIndex = 6
        Me.btnSalirCancelarCliente.Text = "Cancelar"
        Me.btnSalirCancelarCliente.UseVisualStyleBackColor = True
        '
        'txtCodAreaCliente
        '
        Me.txtCodAreaCliente.Location = New System.Drawing.Point(175, 111)
        Me.txtCodAreaCliente.Name = "txtCodAreaCliente"
        Me.txtCodAreaCliente.Size = New System.Drawing.Size(62, 23)
        Me.txtCodAreaCliente.TabIndex = 2
        '
        'lb
        '
        Me.lb.AutoSize = True
        Me.lb.Location = New System.Drawing.Point(243, 114)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(12, 15)
        Me.lb.TabIndex = 11
        Me.lb.Text = "-"
        '
        'CargarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 280)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.txtCodAreaCliente)
        Me.Controls.Add(Me.btnSalirCancelarCliente)
        Me.Controls.Add(Me.btGuardarCliente)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.lbCorreoCliente)
        Me.Controls.Add(Me.lbTelefonoCliente)
        Me.Controls.Add(Me.lbNombreCliente)
        Me.Name = "CargarCliente"
        Me.Text = "Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbNombreCliente As Label
    Friend WithEvents lbTelefonoCliente As Label
    Friend WithEvents lbCorreoCliente As Label
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents btGuardarCliente As Button
    Friend WithEvents btnSalirCancelarCliente As Button
    Friend WithEvents txtCodAreaCliente As TextBox
    Friend WithEvents lb As Label
End Class
