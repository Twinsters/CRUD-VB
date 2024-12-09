Imports Clases
Public Class ResumenVenta

    Dim ventas As New BLLVentas()
    Dim listaVentas As New List(Of BLLVentas)()
    Public Sub New(idVentaModificar As Integer)
        InitializeComponent()
        listaVentas = ventas.BuscarVenta(idVentaModificar)
    End Sub
    Private Sub ResumenVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarPantalla()
    End Sub

    Private Sub cargarPantalla()
        dgvResumenItems.DataSource = Nothing
        dgvResumenItems.DataSource = listaVentas
        dgvResumenItems.AutoGenerateColumns = False
        dgvResumenItems.Columns.Clear()

        dgvResumenItems.Columns.Add("Nombre", "Articulo")
        dgvResumenItems.Columns.Add("Categoria", "Categoria")
        dgvResumenItems.Columns.Add("Precio", "Precio Unitario")
        dgvResumenItems.Columns.Add("Cantidad", "Cantidad")
        dgvResumenItems.Columns.Add("PrecioTotal", "Precio Total")


        For Each venta In listaVentas
            lbNombre.Text = venta.IdCLiente.Nombre
            lbCorreo.Text = venta.IdCLiente.Correo
            LbTelefono.Text = venta.IdCLiente.Telefono
            lbFecha.Text = venta.Fecha
            lbTotalResumen.Text = venta.Total
            Exit For
        Next
        For Each row As DataGridViewRow In dgvResumenItems.Rows
            Dim venta As BLLVentas = TryCast(row.DataBoundItem, BLLVentas)
            If venta IsNot Nothing AndAlso venta.IdProducto IsNot Nothing Then
                row.Cells("Nombre").Value = venta.IdProducto.Nombre
                row.Cells("Categoria").Value = venta.IdProducto.Categoria
                row.Cells("Precio").Value = venta.IdProducto.Precio
                row.Cells("Cantidad").Value = venta.Cantidad
                row.Cells("PrecioTotal").Value = venta.PrecioTotalProducto


            End If
        Next
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class