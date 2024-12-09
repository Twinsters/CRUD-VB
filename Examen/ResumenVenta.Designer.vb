<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResumenVenta
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbTelefono = New System.Windows.Forms.Label()
        Me.lbCorreo = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvResumenItems = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbTotalResumen = New System.Windows.Forms.Label()
        Me.lbTextoTotal = New System.Windows.Forms.Label()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.lbTextoFecha = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvResumenItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbTelefono)
        Me.GroupBox1.Controls.Add(Me.lbCorreo)
        Me.GroupBox1.Controls.Add(Me.lbNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 168)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'LbTelefono
        '
        Me.LbTelefono.AutoSize = True
        Me.LbTelefono.Location = New System.Drawing.Point(99, 75)
        Me.LbTelefono.Name = "LbTelefono"
        Me.LbTelefono.Size = New System.Drawing.Size(41, 15)
        Me.LbTelefono.TabIndex = 2
        Me.LbTelefono.Text = "Label3"
        '
        'lbCorreo
        '
        Me.lbCorreo.AutoSize = True
        Me.lbCorreo.Location = New System.Drawing.Point(99, 126)
        Me.lbCorreo.Name = "lbCorreo"
        Me.lbCorreo.Size = New System.Drawing.Size(41, 15)
        Me.lbCorreo.TabIndex = 1
        Me.lbCorreo.Text = "Label2"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(99, 33)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(41, 15)
        Me.lbNombre.TabIndex = 0
        Me.lbNombre.Text = "Label1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvResumenItems)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(640, 501)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos"
        '
        'dgvResumenItems
        '
        Me.dgvResumenItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResumenItems.Location = New System.Drawing.Point(44, 42)
        Me.dgvResumenItems.Name = "dgvResumenItems"
        Me.dgvResumenItems.RowTemplate.Height = 25
        Me.dgvResumenItems.Size = New System.Drawing.Size(546, 436)
        Me.dgvResumenItems.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbTotalResumen)
        Me.GroupBox3.Controls.Add(Me.lbTextoTotal)
        Me.GroupBox3.Controls.Add(Me.lbFecha)
        Me.GroupBox3.Controls.Add(Me.lbTextoFecha)
        Me.GroupBox3.Location = New System.Drawing.Point(371, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(290, 168)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos"
        '
        'lbTotalResumen
        '
        Me.lbTotalResumen.AutoSize = True
        Me.lbTotalResumen.Location = New System.Drawing.Point(115, 126)
        Me.lbTotalResumen.Name = "lbTotalResumen"
        Me.lbTotalResumen.Size = New System.Drawing.Size(41, 15)
        Me.lbTotalResumen.TabIndex = 3
        Me.lbTotalResumen.Text = "Label4"
        '
        'lbTextoTotal
        '
        Me.lbTextoTotal.AutoSize = True
        Me.lbTextoTotal.Location = New System.Drawing.Point(81, 96)
        Me.lbTextoTotal.Name = "lbTextoTotal"
        Me.lbTextoTotal.Size = New System.Drawing.Size(102, 15)
        Me.lbTextoTotal.TabIndex = 2
        Me.lbTextoTotal.Text = "Total de la Factura"
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Location = New System.Drawing.Point(81, 65)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(41, 15)
        Me.lbFecha.TabIndex = 1
        Me.lbFecha.Text = "Label2"
        '
        'lbTextoFecha
        '
        Me.lbTextoFecha.AutoSize = True
        Me.lbTextoFecha.Location = New System.Drawing.Point(81, 33)
        Me.lbTextoFecha.Name = "lbTextoFecha"
        Me.lbTextoFecha.Size = New System.Drawing.Size(98, 15)
        Me.lbTextoFecha.TabIndex = 0
        Me.lbTextoFecha.Text = "Fecha de la Venta"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(546, 705)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(115, 34)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'ResumenVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 749)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ResumenVenta"
        Me.Text = "Resumen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvResumenItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LbTelefono As Label
    Friend WithEvents lbCorreo As Label
    Friend WithEvents lbNombre As Label
    Friend WithEvents dgvResumenItems As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbTotalResumen As Label
    Friend WithEvents lbTextoTotal As Label
    Friend WithEvents lbFecha As Label
    Friend WithEvents lbTextoFecha As Label
    Friend WithEvents btnSalir As Button
End Class
