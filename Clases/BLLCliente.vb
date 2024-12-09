Imports Conexion

Public Class BLLCliente

    'Propiedades
    Private _id As Integer
    Private _nombre As String
    Private _telefono As String
    Private _correo As String


    'Constructor
    Public Sub New()

    End Sub
    Public Sub New(id As Integer, nombre As String, telefono As String, correo As String)
        _id = id
        _nombre = nombre
        _telefono = telefono
        _correo = correo

    End Sub
    'Propiedad Id
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    'Propiedad Nombre
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    'Propiedad Telefono
    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value

        End Set
    End Property
    'Propiedad Correo
    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property
    'Propiedad ListaProductos

    Public Function buscarClientes() As List(Of BLLCliente)
        Dim conexion As New Conexion.Conexion()
        Dim dtClientes As New DataTable()
        Dim ListaDeClientes As New List(Of BLLCliente)()
        Dim bQuery As String = "SELECT * FROM CLIENTES"
        Try
            dtClientes = conexion.Leer(bQuery, Nothing)

            If dtClientes.Rows.Count > 0 Then
                For Each row As DataRow In dtClientes.Rows
                    Dim cliente As New BLLCliente()
                    cliente.Id = Convert.ToInt32(row("ID"))
                    cliente.Nombre = row("CLIENTE").ToString()
                    cliente.Telefono = row("TELEFONO").ToString()
                    cliente.Correo = row("CORREO").ToString()
                    ListaDeClientes.Add(cliente)
                Next
            End If

            Return ListaDeClientes
        Catch ex As Exception
            Console.WriteLine("Error al buscar clientes: " & ex.Message)
        End Try
    End Function
    Public Function buscarCliente(clienteBuscar As BLLCliente) As List(Of BLLCliente)
        Dim conexion As New Conexion.Conexion()
        Dim dtClientes As New DataTable()
        Dim ListaDeClientes As New List(Of BLLCliente)()
        Dim buscarQuery As String = "SELECT * FROM CLIENTES WHERE 1=1"
        Dim hashtable As New Hashtable()

        Try

            If Not String.IsNullOrEmpty(clienteBuscar.Nombre) Then
                buscarQuery &= " AND CLIENTE LIKE '%'+@Cliente+'%'"
                hashtable.Add("@Cliente", clienteBuscar.Nombre)

            End If
            If Not String.IsNullOrEmpty(clienteBuscar.Telefono) Then
                buscarQuery &= " AND TELEFONO = @Telefono"
                hashtable.Add("@Telefono", clienteBuscar.Telefono)
            End If

            If Not String.IsNullOrEmpty(clienteBuscar.Correo) Then
                buscarQuery &= " AND CORREO = @Correo"
                hashtable.Add("@Correo", clienteBuscar.Correo)
            End If
            dtClientes = conexion.Leer(buscarQuery, hashtable)
            For Each row As DataRow In dtClientes.Rows
                Dim cliente As New BLLCliente()
                cliente.Id = Convert.ToInt32(row("ID"))
                cliente.Nombre = row("CLIENTE").ToString()
                cliente.Telefono = row("TELEFONO").ToString()
                cliente.Correo = row("CORREO").ToString()
                ListaDeClientes.Add(cliente)
            Next

        Catch ex As Exception
            Console.WriteLine("Error al buscar clientes: " & ex.Message)
            Throw
        End Try
        Return ListaDeClientes


    End Function
    Public Function ModificarCliente(ByVal cliente As BLLCliente) As Boolean

        Dim modificarQuery As String = $"UPDATE  CLIENTES SET CLIENTE = @Cliente, TELEFONO = @Telefono, CORREO =@Correo WHERE ID=@Id"
        Dim insertarQuery As String = "INSERT INTO CLIENTES (CLIENTE,TELEFONO,CORREO) VALUES(@Cliente,@Telefono,@Correo)"
        Dim conexion As New Conexion.Conexion()
        Dim hashtable As New Hashtable()

        Try
            hashtable.Add("@Cliente", cliente.Nombre)
            hashtable.Add("@Telefono", cliente.Telefono)
            hashtable.Add("@Correo", cliente.Correo)

            If cliente.Id <> 0 Then
                hashtable.Add("@Id", cliente.Id)
                Return conexion.Guardar(modificarQuery, hashtable)
            Else
                Return conexion.Guardar(insertarQuery, hashtable)
            End If
        Catch ex As Exception
            Return False
            Throw ex
        End Try


    End Function
    Public Function EliminarCliente(ByVal cliente As BLLCliente) As Boolean

        Dim EQuery As String = "DELETE FROM CLIENTES WHERE id=@id"
        Dim conexion As New Conexion.Conexion()
        Dim hashtable As New Hashtable()

        Try
            hashtable.Add("@Id", cliente.Id)
            Return conexion.Guardar(EQuery, hashtable)
        Catch ex As Exception
            Throw ex
        End Try

    End Function


End Class
