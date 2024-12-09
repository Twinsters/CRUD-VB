Imports Clases

Public Class Producto

    Dim productos As List(Of BLLProducto) = New List(Of BLLProducto)
    Dim productosModificar As New BLLProducto()
    Dim precioDesde As Single
    Dim precioHasta As Single

    Private Sub btnNuevoProducto_Click(sender As Object, e As EventArgs) Handles btnNuevoProducto.Click
        CerrarAbrirFormulario()
    End Sub
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

    Private Sub btnBusquedaProductoV_Click(sender As Object, e As EventArgs) Handles btnBusquedaProductoV.Click
        productosModificar.Nombre = txtProductoBusquedaV.Text
        productos = productosModificar.BuscarProducto(productosModificar)
        If productos.Count <> 0 Then
            dgvProducto.DataSource = productos
        Else
            dgvProducto.DataSource = Nothing
            MessageBox.Show("No hay productos con esos datos")
        End If

    End Sub

    Public Function cargarCategorias() As List(Of String)
        Dim listaCategorias As New List(Of String)()
        If productos.Count > 0 Then
            For Each p In productos
                listaCategorias.Add(p.Categoria)
            Next
        End If
        listaCategorias = listaCategorias.Distinct().ToList()
        Return listaCategorias
    End Function

    Private Sub TreeViewCategoriasV_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeViewCategoriasV.NodeMouseClick
        Dim nodoSeleccionado As TreeNode = e.Node
        If nodoSeleccionado.Parent IsNot Nothing Then
            productosModificar.Categoria = nodoSeleccionado.Text
            productos = productosModificar.BuscarProducto(productosModificar)
            dgvProducto.DataSource = Nothing
            dgvProducto.DataSource = productos
        End If

    End Sub

    Private Sub btnBuscarPorFiltro_Click(sender As Object, e As EventArgs) Handles btnBuscarPorFiltro.Click
        If Validar() Then
            productos = productosModificar.BuscarProducto(productosModificar, precioHasta, precioDesde)
            If productos.Count > 0 Then
                dgvProducto.DataSource = Nothing
                dgvProducto.DataSource = productos
            Else
                MessageBox.Show("No hay productos en ese rango de precios")
            End If
        Else
            MessageBox.Show("Error en los precios")
        End If
    End Sub
    Private Sub txtPrecioDesdeV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioDesdeV.KeyPress, txtPrecioHastaV.KeyPress
        SoloFlotantes(sender, e)
    End Sub
    Public Sub SoloFlotantes(sender, e)
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "," OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
        If e.KeyChar = "," AndAlso sender.Text.IndexOf(",") > -1 Then
            e.Handled = True
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
    Private Sub dgvProducto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducto.CellContentClick


        If e.ColumnIndex = Me.dgvProducto.Columns.Item("EliminarProducto").Index Then
            Dim res As DialogResult
            Dim re As Boolean
            res = MessageBox.Show("¿Desea eliminar este Producto", "Eliminar Producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If res = DialogResult.OK Then
                Try
                    productosModificar = dgvProducto.CurrentRow.DataBoundItem
                    re = productosModificar.EliminarProducto(productosModificar)
                Catch ex As Exception
                    MessageBox.Show($"Error {ex}")
                End Try
            End If
            If re = True Then
                MessageBox.Show("El cliente se borro con exito")
            End If
        Else
            productosModificar = dgvProducto.CurrentRow.DataBoundItem
            CerrarAbrirFormulario()
        End If
    End Sub

    Public Sub StyloDataGrid()
        dgvProducto.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
        dgvProducto.Columns(0).Width = 50
        dgvProducto.Columns(1).Width = 40
        dgvProducto.Columns(2).Width = 200
        dgvProducto.Columns(3).Width = 103
        dgvProducto.Columns(4).Width = 200

    End Sub

    Public Sub CerrarAbrirFormulario()
        If productosModificar.Id <> 0 Then
            Dim NuevoProducto As New DatosProductos(productosModificar)
            NuevoProducto.ShowDialog()
            Me.Hide()
        Else
            Dim NuevoProducto As New DatosProductos()
            NuevoProducto.ShowDialog()
            Me.Hide()
        End If

    End Sub

    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvProducto.DataSource = Nothing
        productos = productosModificar.BuscarProductos()
        If productos IsNot Nothing AndAlso productos.Count > 0 Then
            dgvProducto.DataSource = productos
            StyloDataGrid()
        End If

    End Sub

    Private Sub dgvProducto_DataSourceChanged(sender As Object, e As EventArgs) Handles dgvProducto.DataSourceChanged
        CargarTreeView()
        productosModificar.Categoria = ""
        productosModificar.Nombre = ""
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class