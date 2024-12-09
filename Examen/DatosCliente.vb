Imports Clases

Public Class DatosCliente

    Private clienteModificar As BLLCliente

    Public Sub New(clienteModificar As BLLCliente)
        InitializeComponent()
        Me.clienteModificar = clienteModificar
        CargarDatos()
    End Sub

    Public Sub New()
        InitializeComponent()
        clienteModificar = New BLLCliente()
    End Sub

    Private Sub btGuardarCliente_Click(sender As Object, e As EventArgs) Handles btGuardarCliente.Click

        Dim res As Boolean

        Try
            If VerificarDatos() = False Then
                clienteModificar.Nombre = txtNombreCliente.Text
                clienteModificar.Telefono = txtCodAreaCliente.Text + " - " + txtTelefono.Text
                clienteModificar.Correo = txtCorreo.Text
                If clienteModificar IsNot Nothing AndAlso clienteModificar.Id <> 0 Then

                    res = clienteModificar.ModificarCliente(clienteModificar)
                    If res = True Then
                        MessageBox.Show($"Datos Actualizados")
                        Me.Close()
                    End If
                Else
                    res = clienteModificar.ModificarCliente(clienteModificar)
                    If res = True Then
                        MessageBox.Show($"Cliente Cargado")
                        Me.Close()
                    End If
                End If
                Dim Clientes As New Cliente()
                Clientes.Show()
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

    Private Sub txtCodAreaCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodAreaCliente.KeyPress, txtTelefono.KeyPress
        SoloNumeros(e)
    End Sub

    Public Sub CargarDatos()


        txtNombreCliente.Text = clienteModificar.Nombre
        Dim telefono As String() = clienteModificar.Telefono.Split("-"c)
        txtCodAreaCliente.Text = telefono(0)
        txtTelefono.Text = telefono(1)
        txtCorreo.Text = clienteModificar.Correo

    End Sub


    Public Sub SoloNumeros(e)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            ' Si no es un número ni BackSpace, cancelar la pulsación
            e.Handled = True
        End If
    End Sub

    Private Sub btnSalirCancelarCliente_Click(sender As Object, e As EventArgs) Handles btnSalirCancelarCliente.Click
        If MessageBox.Show("¿Está seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
            Dim Clientes As New Cliente()
            Clientes.Show()
        End If
    End Sub
End Class