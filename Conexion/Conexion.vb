Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Configuration


Public Class Conexion

    Dim bd As String = ConfigurationManager.ConnectionStrings("Examen").ConnectionString
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public transac As SqlTransaction
    Public conexion As SqlConnection = New SqlConnection(bd)

    Public Function Leer(consulta As String, hdatos As Hashtable) As DataTable
        Dim tabla As New DataTable()
        Dim sda As SqlDataAdapter
        comando = New SqlCommand(consulta, conexion)

        Try
            conexion.Open()
            If hdatos IsNot Nothing Then
                For Each dato As String In hdatos.Keys
                    comando.Parameters.AddWithValue(dato, hdatos(dato))
                Next
            End If


            sda = New SqlDataAdapter(comando)
            conexion.Close()
        Catch ex As SqlException
            Throw ex
        Catch ex As Exception
            Throw ex
        End Try

        sda.Fill(tabla)
        Return tabla
    End Function
    Public Function Guardar(consulta As String, hdatos As Hashtable) As Boolean
        conexion.Open()
        Try
            transac = conexion.BeginTransaction()
            comando = New SqlCommand(consulta, conexion, transac)

            If hdatos IsNot Nothing Then
                For Each dato As String In hdatos.Keys
                    comando.Parameters.AddWithValue(dato, hdatos(dato))
                Next
            End If

            Dim res As Integer = comando.ExecuteNonQuery()
            transac.Commit()

            Return True
        Catch ex As SqlException
            transac.Rollback()
            Return False
            Throw ex
        Catch ex As Exception
            transac.Rollback()
            Return False
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function GuardarYTraer(consulta As String, hdatos As Hashtable) As Integer
        Dim nuevoID As Integer = 0

        Try
            conexion.Open()
            transac = conexion.BeginTransaction()
            comando = New SqlCommand(consulta, conexion, transac)

            ' Agregar parámetros si existen
            If hdatos IsNot Nothing Then
                For Each dato As String In hdatos.Keys
                    comando.Parameters.AddWithValue(dato, hdatos(dato))
                Next
            End If

            ' Obtener el ID generado usando OUTPUT Clause
            Dim result As Object = comando.ExecuteScalar()

            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                nuevoID = Integer.Parse(result.ToString())
            Else
                Throw New Exception("No se pudo obtener el ID generado.")
            End If

            transac.Commit()
        Catch ex As SqlException
            transac.Rollback()
            Throw ex
        Catch ex As Exception
            transac.Rollback()
            Throw ex
        Finally
            conexion.Close()
        End Try

        Return nuevoID
    End Function

End Class
