<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosProductos
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
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbCategoria = New System.Windows.Forms.Label()
        Me.lbPrecio = New System.Windows.Forms.Label()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.txtCategoriaProducto = New System.Windows.Forms.TextBox()
        Me.txtPrecioProducto = New System.Windows.Forms.TextBox()
        Me.btnGuardarProducto = New System.Windows.Forms.Button()
        Me.btnCancelarProducto = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(53, 93)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(54, 15)
        Me.lbNombre.TabIndex = 0
        Me.lbNombre.Text = "Nombre:"
        '
        'lbCategoria
        '
        Me.lbCategoria.AutoSize = True
        Me.lbCategoria.Location = New System.Drawing.Point(53, 138)
        Me.lbCategoria.Name = "lbCategoria"
        Me.lbCategoria.Size = New System.Drawing.Size(61, 15)
        Me.lbCategoria.TabIndex = 1
        Me.lbCategoria.Text = "Categoria:"
        '
        'lbPrecio
        '
        Me.lbPrecio.AutoSize = True
        Me.lbPrecio.Location = New System.Drawing.Point(53, 183)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.Size = New System.Drawing.Size(43, 15)
        Me.lbPrecio.TabIndex = 2
        Me.lbPrecio.Text = "Precio:"
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(131, 90)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(309, 23)
        Me.txtNombreProducto.TabIndex = 3
        '
        'txtCategoriaProducto
        '
        Me.txtCategoriaProducto.Location = New System.Drawing.Point(131, 138)
        Me.txtCategoriaProducto.Name = "txtCategoriaProducto"
        Me.txtCategoriaProducto.Size = New System.Drawing.Size(309, 23)
        Me.txtCategoriaProducto.TabIndex = 4
        '
        'txtPrecioProducto
        '
        Me.txtPrecioProducto.Location = New System.Drawing.Point(131, 180)
        Me.txtPrecioProducto.Name = "txtPrecioProducto"
        Me.txtPrecioProducto.Size = New System.Drawing.Size(128, 23)
        Me.txtPrecioProducto.TabIndex = 5
        '
        'btnGuardarProducto
        '
        Me.btnGuardarProducto.Location = New System.Drawing.Point(131, 248)
        Me.btnGuardarProducto.Name = "btnGuardarProducto"
        Me.btnGuardarProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarProducto.TabIndex = 6
        Me.btnGuardarProducto.Text = "Guardar"
        Me.btnGuardarProducto.UseVisualStyleBackColor = True
        '
        'btnCancelarProducto
        '
        Me.btnCancelarProducto.Location = New System.Drawing.Point(319, 248)
        Me.btnCancelarProducto.Name = "btnCancelarProducto"
        Me.btnCancelarProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarProducto.TabIndex = 7
        Me.btnCancelarProducto.Text = "Cancelar"
        Me.btnCancelarProducto.UseVisualStyleBackColor = True
        '
        'DatosProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 323)
        Me.Controls.Add(Me.btnCancelarProducto)
        Me.Controls.Add(Me.btnGuardarProducto)
        Me.Controls.Add(Me.txtPrecioProducto)
        Me.Controls.Add(Me.txtCategoriaProducto)
        Me.Controls.Add(Me.txtNombreProducto)
        Me.Controls.Add(Me.lbPrecio)
        Me.Controls.Add(Me.lbCategoria)
        Me.Controls.Add(Me.lbNombre)
        Me.Name = "DatosProductos"
        Me.Text = "DatosProductos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbNombre As Label
    Friend WithEvents lbCategoria As Label
    Friend WithEvents lbPrecio As Label
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents txtCategoriaProducto As TextBox
    Friend WithEvents txtPrecioProducto As TextBox
    Friend WithEvents btnGuardarProducto As Button
    Friend WithEvents btnCancelarProducto As Button
End Class
