Public Class Inicio

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click

    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
    End Sub

    Private Sub ParametricasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParametricasToolStripMenuItem.Click
        Dim cliente As New Cliente()
        cliente.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem1.Click
        Dim producto As New Producto()
        producto.Show()
    End Sub

    Private Sub NuevasVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevasVentasToolStripMenuItem.Click
        Dim Venta As New Venta()
        Venta.Show()
    End Sub

    Private Sub HistorialDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialDeVentasToolStripMenuItem.Click
        Dim HistorialVentas As New HistorialVentas()
        HistorialVentas.Show()
    End Sub
End Class
