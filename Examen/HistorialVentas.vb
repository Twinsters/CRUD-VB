Imports System.IO
Imports Clases

Public Class HistorialVentas
    Dim venta As New BLLVentas()
    Dim ListasVentas As New List(Of BLLVentas)()

    Private Sub HistorialVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListasVentas = venta.BuscarVentas()
        CargarDgv()

    End Sub

    'Carga El DataGrip
    Public Sub CargarDgv()


        dgvVentasRealizadas.DataSource = Nothing
        dgvVentasRealizadas.DataSource = ListasVentas
        dgvVentasRealizadas.AutoGenerateColumns = False
        dgvVentasRealizadas.Columns.Clear()
        Dim imgColumnModificar As New DataGridViewImageColumn()
        imgColumnModificar.HeaderText = "Modificar"
        Dim rutaImagenModificar As String = Path.Combine(Application.StartupPath, "Imagenes", "facturas-de-dinero.png")
        imgColumnModificar.Image = Image.FromFile(rutaImagenModificar)
        imgColumnModificar.Name = "ModificarVenta"
        imgColumnModificar.Width = 60
        imgColumnModificar.ImageLayout = DataGridViewImageCellLayout.Zoom

        Dim imgEliminarVenta As New DataGridViewImageColumn()
        imgEliminarVenta.HeaderText = "Eliminar"
        Dim rutaImagenEliminar As String = Path.Combine(Application.StartupPath, "Imagenes", "denegado.png")
        imgEliminarVenta.Image = Image.FromFile(rutaImagenEliminar)
        imgEliminarVenta.Name = "EliminarVenta"
        imgEliminarVenta.Width = 60
        imgEliminarVenta.ImageLayout = DataGridViewImageCellLayout.Zoom

        Dim imgVerVenta As New DataGridViewImageColumn()
        imgVerVenta.HeaderText = "Ver Venta"
        Dim rutaImagenVerVenta As String = Path.Combine(Application.StartupPath, "Imagenes", "dinero.png")
        imgVerVenta.Image = Image.FromFile(rutaImagenVerVenta)
        imgVerVenta.Name = "VerVenta"
        imgVerVenta.Width = 60
        imgVerVenta.ImageLayout = DataGridViewImageCellLayout.Zoom


        dgvVentasRealizadas.Columns.Insert(0, imgColumnModificar)
        dgvVentasRealizadas.Columns.Insert(1, imgEliminarVenta)
        dgvVentasRealizadas.Columns.Insert(2, imgVerVenta)
        dgvVentasRealizadas.Columns.Add("Id", "Codigo Venta")
        dgvVentasRealizadas.Columns.Add("Cliente", "Nombre")
        dgvVentasRealizadas.Columns.Add("Telefono", "Telefono")
        dgvVentasRealizadas.Columns.Add("Correo", "Correo")
        dgvVentasRealizadas.Columns.Add("Fecha", "Fecha")
        dgvVentasRealizadas.Columns.Add("Total", "Monto Total")

        For Each row As DataGridViewRow In dgvVentasRealizadas.Rows
            Dim venta As BLLVentas = TryCast(row.DataBoundItem, BLLVentas)
            If venta IsNot Nothing Then
                row.Cells("Id").Value = venta.Id
                row.Cells("Cliente").Value = venta.IdCLiente.Nombre
                row.Cells("Telefono").Value = venta.IdCLiente.Telefono
                row.Cells("Correo").Value = venta.IdCLiente.Correo
                row.Cells("Fecha").Value = venta.Fecha
                row.Cells("Total").Value = venta.Total
            End If
        Next


    End Sub

    Private Sub dgvVentasRealizadas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentasRealizadas.CellContentClick
        If e.ColumnIndex = dgvVentasRealizadas.Columns("ModificarVenta").Index AndAlso e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvVentasRealizadas.Rows(e.RowIndex)
            Dim idVenta As Integer = Convert.ToInt32(fila.Cells("Id").Value)
            Dim modificarVentaForm As New Venta(idVenta)
            If modificarVentaForm.ShowDialog() = DialogResult.OK Then
                CargarDgv()
            End If
        ElseIf e.ColumnIndex = dgvVentasRealizadas.Columns("EliminarVenta").Index AndAlso e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvVentasRealizadas.Rows(e.RowIndex)
            Dim idVenta As Integer = Convert.ToInt32(fila.Cells("Id").Value)
            Dim res As DialogResult = MessageBox.Show("¿Desea Eliminar la venta?", "Eliminar Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If res = DialogResult.OK Then
                venta.EliminarVenta(idVenta)
                CargarDgv()
            End If
        ElseIf e.ColumnIndex = dgvVentasRealizadas.Columns("VerVenta").Index AndAlso e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvVentasRealizadas.Rows(e.RowIndex)
            Dim idVenta As Integer = Convert.ToInt32(fila.Cells("Id").Value)
            Dim resumenVentaFrom As New ResumenVenta(idVenta)
            resumenVentaFrom.ShowDialog()
        End If
    End Sub

    Private Sub btnBuscarFiltro_Click(sender As Object, e As EventArgs) Handles btnBuscarFiltro.Click
        Try
            Dim nombreBuscar As String = txtNombreBuscar.Text.Trim()


            Dim fechaDesde As DateTime
            Dim fechaHasta As DateTime

            If Not DateTime.TryParse(dtpDesde.Text, fechaDesde) Then
                MessageBox.Show("Fecha Desde no válida. Por favor seleccione una fecha válida.", "Fecha Desde Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            If Not DateTime.TryParse(DtpHasta.Text, fechaHasta) Then
                MessageBox.Show("Fecha Hasta no válida. Por favor seleccione una fecha válida.", "Fecha Hasta Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If


            ListasVentas = venta.BuscarVentas(fechaDesde, fechaHasta, nombreBuscar)
            CargarDgv()
        Catch ex As Exception
            MessageBox.Show($"Error al buscar ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class