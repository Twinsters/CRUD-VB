Public Class Cantidad

    Public Property cant As Integer

    Private Sub btnGuardarCantidad_Click(sender As Object, e As EventArgs) Handles btnGuardarCantidad.Click
        Try
            cant = Convert.ToInt32(txtCantidad.Text)
            If cant > 0 Then
                Dim res As DialogResult = MessageBox.Show("¿Desea Cambiar la cantidad?", "Cambiar la cantidad", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If res = DialogResult.OK Then
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If
            Else
                MessageBox.Show("La cantidad debe ser mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As FormatException
            MessageBox.Show("Formato de cantidad inválido. Por favor ingrese un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCancelarCantidad_Click(sender As Object, e As EventArgs) Handles btnCancelarCantidad.Click
        Me.Close()
    End Sub
End Class