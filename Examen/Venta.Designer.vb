<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Venta))
        Me.btnBuscarClienteVenta = New System.Windows.Forms.Button()
        Me.txtNombreCLienteV = New System.Windows.Forms.TextBox()
        Me.txtCorreoClienteV = New System.Windows.Forms.TextBox()
        Me.txtTelefonoClienteV = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBusquedaProductoV = New System.Windows.Forms.Button()
        Me.txtProductoBusquedaV = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnBuscarPorFiltro = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrecioDesdeV = New System.Windows.Forms.TextBox()
        Me.txtPrecioHastaV = New System.Windows.Forms.TextBox()
        Me.TreeViewCategoriasV = New System.Windows.Forms.TreeView()
        Me.dgvProductosV = New System.Windows.Forms.DataGridView()
        Me.AgregarCarrito = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.totalGeneral = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.dgvCarritoCompra = New System.Windows.Forms.DataGridView()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvProductosV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvCarritoCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscarClienteVenta
        '
        Me.btnBuscarClienteVenta.Location = New System.Drawing.Point(40, 72)
        Me.btnBuscarClienteVenta.Name = "btnBuscarClienteVenta"
        Me.btnBuscarClienteVenta.Size = New System.Drawing.Size(155, 61)
        Me.btnBuscarClienteVenta.TabIndex = 0
        Me.btnBuscarClienteVenta.Text = "Buscar Cliente"
        Me.btnBuscarClienteVenta.UseVisualStyleBackColor = True
        '
        'txtNombreCLienteV
        '
        Me.txtNombreCLienteV.Location = New System.Drawing.Point(248, 59)
        Me.txtNombreCLienteV.Name = "txtNombreCLienteV"
        Me.txtNombreCLienteV.ReadOnly = True
        Me.txtNombreCLienteV.Size = New System.Drawing.Size(359, 23)
        Me.txtNombreCLienteV.TabIndex = 1
        '
        'txtCorreoClienteV
        '
        Me.txtCorreoClienteV.Location = New System.Drawing.Point(419, 123)
        Me.txtCorreoClienteV.Name = "txtCorreoClienteV"
        Me.txtCorreoClienteV.ReadOnly = True
        Me.txtCorreoClienteV.Size = New System.Drawing.Size(188, 23)
        Me.txtCorreoClienteV.TabIndex = 2
        '
        'txtTelefonoClienteV
        '
        Me.txtTelefonoClienteV.Location = New System.Drawing.Point(248, 123)
        Me.txtTelefonoClienteV.Name = "txtTelefonoClienteV"
        Me.txtTelefonoClienteV.ReadOnly = True
        Me.txtTelefonoClienteV.Size = New System.Drawing.Size(125, 23)
        Me.txtTelefonoClienteV.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscarClienteVenta)
        Me.GroupBox1.Controls.Add(Me.txtCorreoClienteV)
        Me.GroupBox1.Controls.Add(Me.txtTelefonoClienteV)
        Me.GroupBox1.Controls.Add(Me.txtNombreCLienteV)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(691, 204)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBusquedaProductoV)
        Me.GroupBox2.Controls.Add(Me.txtProductoBusquedaV)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.dgvProductosV)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 241)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(720, 445)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos"
        '
        'btnBusquedaProductoV
        '
        Me.btnBusquedaProductoV.Location = New System.Drawing.Point(248, 22)
        Me.btnBusquedaProductoV.Name = "btnBusquedaProductoV"
        Me.btnBusquedaProductoV.Size = New System.Drawing.Size(75, 23)
        Me.btnBusquedaProductoV.TabIndex = 3
        Me.btnBusquedaProductoV.Text = "Buscar"
        Me.btnBusquedaProductoV.UseVisualStyleBackColor = True
        '
        'txtProductoBusquedaV
        '
        Me.txtProductoBusquedaV.Location = New System.Drawing.Point(336, 23)
        Me.txtProductoBusquedaV.Name = "txtProductoBusquedaV"
        Me.txtProductoBusquedaV.Size = New System.Drawing.Size(310, 23)
        Me.txtProductoBusquedaV.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.TreeViewCategoriasV)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 51)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(157, 363)
        Me.GroupBox3.TabIndex = 1
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
        'dgvProductosV
        '
        Me.dgvProductosV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductosV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AgregarCarrito})
        Me.dgvProductosV.Location = New System.Drawing.Point(182, 65)
        Me.dgvProductosV.Name = "dgvProductosV"
        Me.dgvProductosV.ReadOnly = True
        Me.dgvProductosV.RowHeadersVisible = False
        Me.dgvProductosV.RowTemplate.Height = 25
        Me.dgvProductosV.Size = New System.Drawing.Size(509, 331)
        Me.dgvProductosV.TabIndex = 0
        '
        'AgregarCarrito
        '
        Me.AgregarCarrito.HeaderText = ""
        Me.AgregarCarrito.Image = CType(resources.GetObject("AgregarCarrito.Image"), System.Drawing.Image)
        Me.AgregarCarrito.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.AgregarCarrito.Name = "AgregarCarrito"
        Me.AgregarCarrito.ReadOnly = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.totalGeneral)
        Me.GroupBox4.Controls.Add(Me.lbTotal)
        Me.GroupBox4.Controls.Add(Me.dgvCarritoCompra)
        Me.GroupBox4.Location = New System.Drawing.Point(753, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(403, 336)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Carrito"
        '
        'totalGeneral
        '
        Me.totalGeneral.AutoSize = True
        Me.totalGeneral.Location = New System.Drawing.Point(86, 287)
        Me.totalGeneral.Name = "totalGeneral"
        Me.totalGeneral.Size = New System.Drawing.Size(0, 15)
        Me.totalGeneral.TabIndex = 5
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Location = New System.Drawing.Point(38, 287)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(42, 15)
        Me.lbTotal.TabIndex = 4
        Me.lbTotal.Text = "TOTAL:"
        '
        'dgvCarritoCompra
        '
        Me.dgvCarritoCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCarritoCompra.Location = New System.Drawing.Point(19, 39)
        Me.dgvCarritoCompra.Name = "dgvCarritoCompra"
        Me.dgvCarritoCompra.ReadOnly = True
        Me.dgvCarritoCompra.RowHeadersVisible = False
        Me.dgvCarritoCompra.RowTemplate.Height = 25
        Me.dgvCarritoCompra.Size = New System.Drawing.Size(364, 203)
        Me.dgvCarritoCompra.TabIndex = 3
        '
        'btnComprar
        '
        Me.btnComprar.Location = New System.Drawing.Point(882, 413)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(155, 61)
        Me.btnComprar.TabIndex = 4
        Me.btnComprar.Text = "Comprar"
        Me.btnComprar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(882, 546)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(155, 61)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 698)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnComprar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Venta"
        Me.Text = "Venta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgvProductosV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvCarritoCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBuscarClienteVenta As Button
    Friend WithEvents txtNombreCLienteV As TextBox
    Friend WithEvents txtCorreoClienteV As TextBox
    Friend WithEvents txtTelefonoClienteV As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtProductoBusquedaV As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvProductosV As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents totalGeneral As Label
    Friend WithEvents lbTotal As Label
    Friend WithEvents dgvCarritoCompra As DataGridView
    Friend WithEvents AgregarCarrito As DataGridViewImageColumn
    Friend WithEvents btnBusquedaProductoV As Button
    Friend WithEvents TreeViewCategoriasV As TreeView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPrecioDesdeV As TextBox
    Friend WithEvents txtPrecioHastaV As TextBox
    Friend WithEvents btnBuscarPorFiltro As Button
    Friend WithEvents btnComprar As Button
    Friend WithEvents btnSalir As Button
End Class
