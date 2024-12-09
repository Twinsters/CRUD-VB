Imports Clases
Public Class DatosProductos

    Private ProductoModificar As BLLProducto
    Public Sub New(ProductoModificar As BLLProducto)
        InitializeComponent()
        Me.ProductoModificar = ProductoModificar
        cargarDatosProductos()
    End Sub

    Public Sub New()
        InitializeComponent()
        ProductoModificar = New BLLProducto()
    End Sub


    Private Sub btnGuardarProducto_Click(sender As Object, e As EventArgs) Handles btnGuardarProducto.Click
        Dim res As Boolean

        Try
            If VerificarDatos() = False Then
                ProductoModificar.Nombre = txtNombreProducto.Text
                ProductoModificar.Categoria = txtCategoriaProducto.Text
                ProductoModificar.Precio = Convert.ToSingle(txtPrecioProducto.Text)
                If ProductoModificar IsNot Nothing AndAlso ProductoModificar.Id <> 0 Then

                    res = ProductoModificar.ModificarProducto(ProductoModificar)
                    If res = True Then
                        MessageBox.Show($"Datos Actualizados")
                        Me.Close()
                    End If
                Else
                    res = ProductoModificar.ModificarProducto(ProductoModificar)
                    If res = True Then
                        MessageBox.Show($"Producto Cargado")
                        Me.Close()
                    End If
                End If
                Dim Producto As New Producto()
                Producto.Show()
            End If

        Catch ex As Exception
            MessageBox.Show($"Error en el los campos {ex}")
        End Try
    End Sub

    Private Function VerificarDatos()

        For Each control As Control In Me.Controls

            If TypeOf control Is TextBox Then

                Dim textBox As TextBox = DirectCast(control, TextBox)


                If textBox.Text.Trim() = "" Then
                    MessageBox.Show($"El {textBox.Name} se encuentra Vacio")
                    Return True

                Else
                    Return False
                End If
            End If
        Next

    End Function
    Private Sub txtPrecioProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioProducto.KeyPress
        SoloFlotantes(e)
    End Sub
    Public Sub SoloFlotantes(e)

        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "," OrElse Char.IsControl(e.KeyChar)) Then

            e.Handled = True
        End If
        If e.KeyChar = "," AndAlso txtPrecioProducto.Text.IndexOf(",") > -1 Then
            e.Handled = True
        End If
    End Sub

    Public Sub cargarDatosProductos()
        txtNombreProducto.Text = ProductoModificar.Nombre
        txtCategoriaProducto.Text = ProductoModificar.Categoria
        txtPrecioProducto.Text = ProductoModificar.Precio
    End Sub


End Class