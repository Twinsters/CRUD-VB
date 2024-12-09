<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cantidad
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
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardarCantidad = New System.Windows.Forms.Button()
        Me.btnCancelarCantidad = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(182, 36)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(63, 23)
        Me.txtCantidad.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese la cantidad:"
        '
        'btnGuardarCantidad
        '
        Me.btnGuardarCantidad.Location = New System.Drawing.Point(36, 80)
        Me.btnGuardarCantidad.Name = "btnGuardarCantidad"
        Me.btnGuardarCantidad.Size = New System.Drawing.Size(94, 34)
        Me.btnGuardarCantidad.TabIndex = 2
        Me.btnGuardarCantidad.Text = "Guardar"
        Me.btnGuardarCantidad.UseVisualStyleBackColor = True
        '
        'btnCancelarCantidad
        '
        Me.btnCancelarCantidad.Location = New System.Drawing.Point(195, 80)
        Me.btnCancelarCantidad.Name = "btnCancelarCantidad"
        Me.btnCancelarCantidad.Size = New System.Drawing.Size(93, 34)
        Me.btnCancelarCantidad.TabIndex = 3
        Me.btnCancelarCantidad.Text = "Cancelar"
        Me.btnCancelarCantidad.UseVisualStyleBackColor = True
        '
        'Cantidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 136)
        Me.Controls.Add(Me.btnCancelarCantidad)
        Me.Controls.Add(Me.btnGuardarCantidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCantidad)
        Me.Name = "Cantidad"
        Me.Text = "Cantidad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGuardarCantidad As Button
    Friend WithEvents btnCancelarCantidad As Button
End Class
