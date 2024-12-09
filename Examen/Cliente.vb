
Imports Clases
Public Class Cliente

    Dim clientes As List(Of BLLCliente) = New List(Of BLLCliente)
    Dim clienteModificar As New BLLCliente()
    Private Sub btnNuevoCliente_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        CerrarAbrirFormulario()
    End Sub

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvClientes.DataSource = Nothing
        clientes = clienteModificar.buscarClientes()
        If clientes IsNot Nothing AndAlso clientes.Count > 0 Then
            dgvClientes.DataSource = clientes
            StyloDataGrid()
        End If
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click

        clienteModificar.Nombre = txtNombreBuscar.Text
        dgvClientes.DataSource = Nothing
        If txtNombreBuscar.Text = "" Then
            dgvClientes.DataSource = clienteModificar.buscarClientes()
            StyloDataGrid()
        Else
            clientes = clienteModificar.buscarCliente(clienteModificar)
            If clientes.Count <> 0 Then
                dgvClientes.DataSource = clientes
                StyloDataGrid()
            Else
                MessageBox.Show("No Existe un cliente con ese nombre")

            End If
        End If

    End Sub

    Private Sub dgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick

        If e.ColumnIndex = Me.dgvClientes.Columns.Item("Eliminar").Index Then
            Dim res As DialogResult
            Dim re As Boolean
            res = MessageBox.Show("¿Desea eliminar este cliente", "Eliminar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If res = DialogResult.OK Then
                Try
                    clienteModificar = dgvClientes.CurrentRow.DataBoundItem
                    re = clienteModificar.EliminarCliente(clienteModificar)
                Catch ex As Exception
                    MessageBox.Show($"Error {ex}")
                End Try
            End If
            If re = True Then
                MessageBox.Show("El cliente se borro con exito")
                dgvClientes.DataSource = Nothing
                dgvClientes.DataSource = clienteModificar.buscarClientes()
                StyloDataGrid()
            End If
        Else
            clienteModificar = dgvClientes.CurrentRow.DataBoundItem
            CerrarAbrirFormulario()
        End If

    End Sub

    Public Sub StyloDataGrid()
        dgvClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
        dgvClientes.Columns(0).Width = 50
        dgvClientes.Columns(1).Width = 40
        dgvClientes.Columns(2).Width = 200
        dgvClientes.Columns(3).Width = 103
        dgvClientes.Columns(4).Width = 200

    End Sub



    Public Sub CerrarAbrirFormulario()
        If clienteModificar.Id <> 0 Then
            Dim NuevoCLiente As New DatosCliente(clienteModificar)
            NuevoCLiente.ShowDialog()
            Me.Hide()
        Else
            Dim NuevoCLiente As New DatosCliente()
            NuevoCLiente.ShowDialog()
            Me.Hide()
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class