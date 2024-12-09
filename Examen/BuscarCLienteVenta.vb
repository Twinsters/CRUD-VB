Imports Clases
Public Class BuscarCLienteVenta

    Public Property cliente As New BLLCliente
    Dim ListaClientes As List(Of BLLCliente) = New List(Of BLLCliente)()
    Private Sub BuscarCLienteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvClientesBuscar.Columns("AgregarCliente").Visible = False
    End Sub



    Private Sub cbNombre_CheckedChanged(sender As Object, e As EventArgs) Handles cbNombre.CheckedChanged
        txtNombreClienteB.Clear()
        If cbNombre.Checked Then
            txtNombreClienteB.Enabled = True
        Else
            txtNombreClienteB.Enabled = False
        End If
    End Sub

    Private Sub cbCorreo_CheckedChanged(sender As Object, e As EventArgs) Handles cbCorreo.CheckedChanged
        txtCorreoClienteB.Clear()
        If cbCorreo.Checked Then
            txtCorreoClienteB.Enabled = True
        Else
            txtCorreoClienteB.Enabled = False
        End If
    End Sub

    Private Sub cbTelefono_CheckedChanged(sender As Object, e As EventArgs) Handles cbTelefono.CheckedChanged
        txtTelefonoClienteB.Clear()
        If cbTelefono.Checked Then
            txtTelefonoClienteB.Enabled = True
        Else
            txtTelefonoClienteB.Enabled = False
        End If

    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        dgvClientesBuscar.DataSource = Nothing
        cliente.Nombre = txtNombreClienteB.Text
        cliente.Correo = txtCorreoClienteB.Text
        cliente.Telefono = txtTelefonoClienteB.Text
        ListaClientes = cliente.buscarCliente(cliente)

        If ListaClientes.Count <> 0 Then
            dgvClientesBuscar.DataSource = ListaClientes
            StyloDataGrid()
            dgvClientesBuscar.Columns("AgregarCliente").Visible = True

        Else
            MessageBox.Show("No Existe un cliente con esos parametros")
            dgvClientesBuscar.DataSource = Nothing
            dgvClientesBuscar.Columns("AgregarCliente").Visible = False
        End If


    End Sub

    Private Sub dgvClientesBuscar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientesBuscar.CellContentClick
        If e.ColumnIndex = Me.dgvClientesBuscar.Columns.Item("AgregarCliente").Index Then
            Dim res As DialogResult = MessageBox.Show("¿Desea asignar este cliente?", "Agregar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If res = DialogResult.OK Then
                Try
                    cliente = DirectCast(dgvClientesBuscar.CurrentRow.DataBoundItem, BLLCliente)
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Public Sub StyloDataGrid()
        dgvClientesBuscar.Columns(0).Width = 50
        dgvClientesBuscar.Columns(1).Width = 40
        dgvClientesBuscar.Columns(2).Width = 200
        dgvClientesBuscar.Columns(3).Width = 100
        dgvClientesBuscar.Columns(4).Width = 160
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim res As DialogResult = MessageBox.Show("¿Desea cancelar este cliente?", "Agregar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If res = DialogResult.OK Then
            Try
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub
End Class