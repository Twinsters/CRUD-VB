Imports System.IO
Imports Clases

Public Class Venta
    Dim cliente As New BLLCliente
    Dim productos As New BLLProducto()
    Dim carritoCompra As List(Of BLLVentas) = New List(Of BLLVentas)()
    Dim listaProductos As New List(Of BLLProducto)()
    Dim precioDesde As Single
    Dim precioHasta As Single
    Dim ventaModificar As New BLLVentas()
    Dim carritoComprasModificar As New List(Of BLLVentas)()

    Public Sub New(idVentaModificar As Integer)
        InitializeComponent()
        BuscarVentaAModificar(idVentaModificar)
        CargarDatosModificarCLiente()
        CargarDatosCliente()

    End Sub


    Public Sub New(clienteBuscado As BLLCliente)
        InitializeComponent()
        Me.cliente = clienteBuscado
        CargarDatosCliente()
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub btnBuscarClienteVenta_Click(sender As Object, e As EventArgs) Handles btnBuscarClienteVenta.Click
        Using buscarCliente As New BuscarCLienteVenta()
            If buscarCliente.ShowDialog() = DialogResult.OK Then
                cliente = buscarCliente.cliente
                CargarDatosCliente()
            End If
        End Using

    End Sub

    Public Sub CargarDatosModificarCLiente()
        For Each v In carritoCompra
            cliente.Id = v.IdCLiente.Id
            cliente.Correo = v.IdCLiente.Correo
            cliente.Telefono = v.IdCLiente.Telefono
            cliente.Nombre = v.IdCLiente.Nombre
        Next
    End Sub

    Public Sub CargarDatosCliente()
        txtNombreCLienteV.Text = cliente.Nombre
        txtCorreoClienteV.Text = cliente.Correo
        txtTelefonoClienteV.Text = cliente.Telefono
    End Sub

    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaProductos = productos.BuscarProductos()
        If listaProductos.Count > 0 Then
            dgvProductosV.DataSource = listaProductos

            dgvProductosV.Columns("AgregarCarrito").Visible = True
        Else
            dgvProductosV.Columns("AgregarCarrito").Visible = False
        End If
        If carritoCompra.Count <> 0 Then
            cargarCarritoCompra()
        End If
    End Sub

    Private Sub btnBusquedaProductoV_Click(sender As Object, e As EventArgs) Handles btnBusquedaProductoV.Click
        productos.Nombre = txtProductoBusquedaV.Text
        listaProductos = productos.BuscarProducto(productos)
        If listaProductos.Count <> 0 Then
            dgvProductosV.DataSource = listaProductos
            dgvProductosV.Columns("AgregarCarrito").Visible = True
        Else
            dgvProductosV.DataSource = Nothing
            dgvProductosV.Columns("AgregarCarrito").Visible = False
            MessageBox.Show("No hay productos con esos datos")
        End If

    End Sub


    Private Sub btnBuscarPorFiltro_Click(sender As Object, e As EventArgs) Handles btnBuscarPorFiltro.Click
        If Validar() Then
            listaProductos = productos.BuscarProducto(productos, precioHasta, precioDesde)
            If listaProductos.Count > 0 Then
                dgvProductosV.DataSource = Nothing
                dgvProductosV.DataSource = listaProductos
            Else
                MessageBox.Show("No hay productos en ese rango de precios")
            End If
        Else
            MessageBox.Show("Error en los precios")
        End If
    End Sub

    Public Function Validar() As Boolean

        If String.IsNullOrEmpty(txtPrecioDesdeV.Text) OrElse Not Single.TryParse(txtPrecioDesdeV.Text, precioDesde) Then
            precioDesde = 0
        End If
        If String.IsNullOrEmpty(txtPrecioHastaV.Text) OrElse Not Single.TryParse(txtPrecioHastaV.Text, precioHasta) Then
            precioHasta = 0
        End If

        If precioDesde < precioHasta Or precioHasta = 0 Then
            Return True
        Else
            Return False

        End If

    End Function
    Private Sub CargarTreeView()
        Dim listaCategorias As New List(Of String)()
        listaCategorias = cargarCategorias()
        TreeViewCategoriasV.Nodes.Clear()
        Dim nodoRaiz As TreeNode = TreeViewCategoriasV.Nodes.Add("Categorías")
        For Each categoria In listaCategorias
            Dim c As TreeNode = nodoRaiz.Nodes.Add(categoria)
        Next
        nodoRaiz.Expand()
    End Sub
    Public Function cargarCategorias() As List(Of String)
        Dim listaCategorias As New List(Of String)()
        If listaProductos.Count > 0 Then
            For Each p In listaProductos
                listaCategorias.Add(p.Categoria)
            Next
        End If
        listaCategorias = listaCategorias.Distinct().ToList()
        Return listaCategorias
    End Function

    Public Sub SoloFlotantes(sender, e)
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "," OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
        If e.KeyChar = "," AndAlso sender.Text.IndexOf(",") > -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecioDesdeV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioDesdeV.KeyPress, txtPrecioHastaV.KeyPress
        SoloFlotantes(sender, e)
    End Sub

    Private Sub dgvProductosV_DataSourceChanged(sender As Object, e As EventArgs) Handles dgvProductosV.DataSourceChanged
        CargarTreeView()
        productos.Categoria = ""
        productos.Nombre = ""
    End Sub

    Private Sub TreeViewCategoriasV_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeViewCategoriasV.NodeMouseClick
        Dim nodoSeleccionado As TreeNode = e.Node
        If nodoSeleccionado.Parent IsNot Nothing Then
            productos.Categoria = nodoSeleccionado.Text
            listaProductos = productos.BuscarProducto(productos)
            dgvProductosV.DataSource = Nothing
            dgvProductosV.DataSource = listaProductos
        End If

    End Sub

    Private Sub dgvProductosV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductosV.CellContentClick
        If e.ColumnIndex = Me.dgvProductosV.Columns.Item("AgregarCarrito").Index Then
            Dim re As DialogResult
            re = MessageBox.Show("¿Desea agregar este producto al carrito", "Agregar Articulo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If re = DialogResult.OK Then
                Try
                    Dim venta As New BLLVentas()
                    Dim producto As BLLProducto = DirectCast(dgvProductosV.CurrentRow.DataBoundItem, BLLProducto)
                    venta.IdProducto = producto
                    venta.Cantidad = 1
                    venta.PrecioTotalProducto = Convert.ToSingle(producto.Precio * venta.Cantidad)
                    If VerificarDobles(venta) Then
                        MessageBox.Show("Ya se encuentra el item en el carrito, si necesita mas cambie la cantidad")
                    Else
                        carritoCompra.Add(venta)
                        cargarCarritoCompra()
                    End If

                Catch ex As Exception
                    MessageBox.Show($"Error {ex}")
                End Try
            End If

        End If
    End Sub
    Public Sub cargarCarritoCompra()

        dgvCarritoCompra.DataSource = Nothing
        dgvCarritoCompra.DataSource = carritoCompra
        dgvCarritoCompra.AutoGenerateColumns = False
        dgvCarritoCompra.Columns.Clear()
        Dim imgColumn As New DataGridViewImageColumn()
        imgColumn.HeaderText = ""
        Dim rutaImagen As String = Path.Combine(Application.StartupPath, "Imagenes", "eliminarArticuloCarrito.png")
        imgColumn.Image = Image.FromFile(rutaImagen)
        imgColumn.Name = "EliminarArticuloCarrito"
        imgColumn.Width = 50
        imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
        dgvCarritoCompra.Columns.Insert(0, imgColumn)
        dgvCarritoCompra.Columns.Add("Nombre", "Articulo")
        dgvCarritoCompra.Columns.Add("Precio", "Precio Unitario")
        dgvCarritoCompra.Columns.Add("Cantidad", "Cantidad")
        dgvCarritoCompra.Columns.Add("PrecioTotal", "Precio Total")

        For Each row As DataGridViewRow In dgvCarritoCompra.Rows
            Dim venta As BLLVentas = TryCast(row.DataBoundItem, BLLVentas)
            If venta IsNot Nothing AndAlso venta.IdProducto IsNot Nothing Then
                row.Cells("Nombre").Value = venta.IdProducto.Nombre
                row.Cells("Precio").Value = venta.IdProducto.Precio
                row.Cells("Cantidad").Value = venta.Cantidad
                row.Cells("PrecioTotal").Value = venta.PrecioTotalProducto


            End If
        Next
    End Sub

    Public Sub BuscarVentaAModificar(idVentaModificar As Integer)

        carritoComprasModificar = ventaModificar.BuscarVenta(idVentaModificar)
        carritoCompra = ventaModificar.BuscarVenta(idVentaModificar)
    End Sub
    Public Function ActualizarTotal()
        Dim total As Single
        For Each v As BLLVentas In carritoCompra
            total += v.PrecioTotalProducto
        Next
        totalGeneral.Text = total.ToString()
    End Function
    Public Function VerificarDobles(venta As BLLVentas) As Boolean
        Dim idProductoVenta As Integer = venta.IdProducto.Id

        For Each v As BLLVentas In carritoCompra
            If v.IdProducto.Id = idProductoVenta Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Sub dgvCarritoCompra_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCarritoCompra.CellContentClick


        If e.ColumnIndex = Me.dgvCarritoCompra.Columns.Item("EliminarArticuloCarrito").Index Then
            Dim ventaSeleccionada As BLLVentas = DirectCast(dgvCarritoCompra.CurrentRow.DataBoundItem, BLLVentas)
            Dim idProductoVenta As Integer = ventaSeleccionada.IdProducto.Id
            For Each venta As BLLVentas In carritoCompra.ToList()
                If venta.IdProducto.Id = idProductoVenta Then
                    carritoCompra.Remove(venta)
                    Exit For
                End If
            Next
            cargarCarritoCompra()
        ElseIf e.ColumnIndex = dgvCarritoCompra.Columns("Cantidad").Index AndAlso e.RowIndex >= 0 Then
            Dim ventaSeleccionada As BLLVentas = DirectCast(dgvCarritoCompra.CurrentRow.DataBoundItem, BLLVentas)
            Dim idProductoVenta As Integer = ventaSeleccionada.IdProducto.Id
            For Each venta As BLLVentas In carritoCompra.ToList()
                If venta.IdProducto.Id = idProductoVenta Then
                    Using ModificarCantidad As New Cantidad()
                        If ModificarCantidad.ShowDialog() = DialogResult.OK Then
                            venta.Cantidad = ModificarCantidad.cant
                            venta.PrecioTotalProducto = Convert.ToSingle(venta.IdProducto.Precio * venta.Cantidad)
                        End If
                    End Using
                    Exit For
                End If
            Next
            cargarCarritoCompra()
        End If

    End Sub
    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click

        Dim v As New BLLVentas()
        Dim idVenta As Integer
        If cliente.Id > 0 Then
            If carritoCompra.Count > 0 Then
                For Each venta As BLLVentas In carritoCompra.ToList()
                    venta.IdCLiente = cliente
                Next
                For Each venta As BLLVentas In carritoComprasModificar.ToList()
                    idVenta = venta.Id
                Next

                If v.CargarVenta(carritoCompra, carritoComprasModificar,idVenta) Then
                    Dim res As DialogResult = MessageBox.Show("¿Desea realizar la operacion?", "Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    If res = DialogResult.OK Then
                        Me.DialogResult = DialogResult.OK
                        MessageBox.Show("Operacion Exitosa")
                        Me.Close()
                    End If
                End If
            Else
                MessageBox.Show("No hay articulos en el carrito")
            End If
        Else
            MessageBox.Show("No hay Cliente")
        End If
    End Sub

    Private Sub dgvCarritoCompra_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCarritoCompra.CellValueChanged
        ActualizarTotal()
    End Sub

    Private Sub txtProductoBusquedaV_TextChanged(sender As Object, e As EventArgs) Handles txtProductoBusquedaV.TextChanged

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class