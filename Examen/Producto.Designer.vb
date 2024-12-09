<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Producto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Producto))
        Me.dgvProducto = New System.Windows.Forms.DataGridView()
        Me.EliminarProducto = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnNuevoProducto = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnBuscarPorFiltro = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrecioDesdeV = New System.Windows.Forms.TextBox()
        Me.txtPrecioHastaV = New System.Windows.Forms.TextBox()
        Me.TreeViewCategoriasV = New System.Windows.Forms.TreeView()
        Me.btnBusquedaProductoV = New System.Windows.Forms.Button()
        Me.txtProductoBusquedaV = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProducto
        '
        Me.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EliminarProducto})
        Me.dgvProducto.Location = New System.Drawing.Point(204, 92)
        Me.dgvProducto.Name = "dgvProducto"
        Me.dgvProducto.RowHeadersVisible = False
        Me.dgvProducto.RowTemplate.Height = 25
        Me.dgvProducto.Size = New System.Drawing.Size(596, 347)
        Me.dgvProducto.TabIndex = 0
        '
        'EliminarProducto
        '
        Me.EliminarProducto.HeaderText = ""
        Me.EliminarProducto.Image = CType(resources.GetObject("EliminarProducto.Image"), System.Drawing.Image)
        Me.EliminarProducto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.EliminarProducto.Name = "EliminarProducto"
        '
        'btnNuevoProducto
        '
        Me.btnNuevoProducto.Location = New System.Drawing.Point(826, 160)
        Me.btnNuevoProducto.Name = "btnNuevoProducto"
        Me.btnNuevoProducto.Size = New System.Drawing.Size(122, 72)
        Me.btnNuevoProducto.TabIndex = 1
        Me.btnNuevoProducto.Text = "Nuevo"
        Me.btnNuevoProducto.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.TreeViewCategoriasV)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 92)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(157, 363)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filtro"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnBuscarPorFiltro)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.txtPrecioDesdeV)
        Me.GroupBox5.Controls.Add(Me.txtPrecioHastaV)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 175)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(145, 182)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Precio"
        '
        'btnBuscarPorFiltro
        '
        Me.btnBuscarPorFiltro.Location = New System.Drawing.Point(28, 138)
        Me.btnBuscarPorFiltro.Name = "btnBuscarPorFiltro"
        Me.btnBuscarPorFiltro.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarPorFiltro.TabIndex = 4
        Me.btnBuscarPorFiltro.Text = "Buscar"
        Me.btnBuscarPorFiltro.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Desde:"
        '
        'txtPrecioDesdeV
        '
        Me.txtPrecioDesdeV.Location = New System.Drawing.Point(19, 46)
        Me.txtPrecioDesdeV.Name = "txtPrecioDesdeV"
        Me.txtPrecioDesdeV.Size = New System.Drawing.Size(100, 23)
        Me.txtPrecioDesdeV.TabIndex = 5
        '
        'txtPrecioHastaV
        '
        Me.txtPrecioHastaV.Location = New System.Drawing.Point(19, 99)
        Me.txtPrecioHastaV.Name = "txtPrecioHastaV"
        Me.txtPrecioHastaV.Size = New System.Drawing.Size(100, 23)
        Me.txtPrecioHastaV.TabIndex = 6
        '
        'TreeViewCategoriasV
        '
        Me.TreeViewCategoriasV.Location = New System.Drawing.Point(6, 22)
        Me.TreeViewCategoriasV.Name = "TreeViewCategoriasV"
        Me.TreeViewCategoriasV.Size = New System.Drawing.Size(145, 143)
        Me.TreeViewCategoriasV.TabIndex = 4
        '
        'btnBusquedaProductoV
        '
        Me.btnBusquedaProductoV.Location = New System.Drawing.Point(276, 34)
        Me.btnBusquedaProductoV.Name = "btnBusquedaProductoV"
        Me.btnBusquedaProductoV.Size = New System.Drawing.Size(75, 23)
        Me.btnBusquedaProductoV.TabIndex = 6
        Me.btnBusquedaProductoV.Text = "Buscar"
        Me.btnBusquedaProductoV.UseVisualStyleBackColor = True
        '
        'txtProductoBusquedaV
        '
        Me.txtProductoBusquedaV.Location = New System.Drawing.Point(364, 35)
        Me.txtProductoBusquedaV.Name = "txtProductoBusquedaV"
        Me.txtProductoBusquedaV.Size = New System.Drawing.Size(310, 23)
        Me.txtProductoBusquedaV.TabIndex = 5
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(826, 282)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(122, 72)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 485)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBusquedaProductoV)
        Me.Controls.Add(Me.txtProductoBusquedaV)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnNuevoProducto)
        Me.Controls.Add(Me.dgvProducto)
        Me.Name = "Producto"
        Me.Text = "Producto"
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProducto As DataGridView
    Friend WithEvents btnNuevoProducto As Button
    Friend WithEvents EliminarProducto As DataGridViewImageColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnBuscarPorFiltro As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPrecioDesdeV As TextBox
    Friend WithEvents txtPrecioHastaV As TextBox
    Friend WithEvents TreeViewCategoriasV As TreeView
    Friend WithEvents btnBusquedaProductoV As Button
    Friend WithEvents txtProductoBusquedaV As TextBox
    Friend WithEvents btnSalir As Button
End Class
