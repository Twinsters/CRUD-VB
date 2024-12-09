Imports System.Windows.Forms

Public Class BLLProducto


    'Propiedades
    Private _id As Integer
    Private _nombre As String
    Private _precio As Single
    Private _categoria As String

    'Constructor
    Public Sub New(id As Integer, nombre As String, precio As Double, categoria As String)
        _id = id
        _nombre = nombre
        _precio = precio
        _categoria = categoria
    End Sub
    Public Sub New()

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
    'Propiedad Precio
    Public Property Precio As Single
        Get
            Return _precio
        End Get
        Set(value As Single)
            _precio = value
        End Set
    End Property
    'Propiedad Categoria
    Public Property Categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property

    Public Function BuscarProductos() As List(Of BLLProducto)
        Dim conexion As New Conexion.Conexion()
        Dim dt As New DataTable()
        Dim ListaDeProductos As New List(Of BLLProducto)()
        Dim bQuery As String = "SELECT * FROM PRODUCTOS"
        Try
            dt = conexion.Leer(bQuery, Nothing)

            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    Dim producto As New BLLProducto()
                    producto.Id = Convert.ToInt32(row("ID"))
                    producto.Nombre = row("NOMBRE").ToString()
                    producto.Precio = Convert.ToSingle(row("PRECIO"))
                    producto.Categoria = row("CATEGORIA").ToString()
                    ListaDeProductos.Add(producto)
                Next
            End If

            Return ListaDeProductos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarProducto(bProducto As BLLProducto, Optional ByVal precioHasta As Single = Nothing, Optional ByVal precioDesde As Single = Nothing) As List(Of BLLProducto)
        Dim conexion As New Conexion.Conexion()
        Dim dt As New DataTable()
        Dim ListaDeProductos As New List(Of BLLProducto)()
        Dim hashtable As New Hashtable()
        Dim bQuery As String = "SELECT * FROM PRODUCTOS WHERE 1=1"

        If Not String.IsNullOrEmpty(bProducto.Nombre) Then
            bQuery &= " AND NOMBRE LIKE @Nombre+'%'"
            hashtable.Add("@Nombre", bProducto.Nombre)

        End If
        If Not String.IsNullOrEmpty(bProducto.Categoria) Then
            bQuery &= " AND CATEGORIA = @Categoria"
            hashtable.Add("@Categoria", bProducto.Categoria)
        End If
        If precioHasta <> Nothing AndAlso precioDesde <> Nothing Then
            bQuery &= " AND Precio BETWEEN @PrecioDesde AND @PrecioHasta"
            hashtable.Add("@PrecioDesde", precioDesde)
            hashtable.Add("@PrecioHasta", precioHasta)
        ElseIf precioHasta <> Nothing Then
            bQuery &= " And Precio <= @PrecioHasta"
            hashtable.Add("@PrecioHasta", precioHasta)
        ElseIf precioDesde <> Nothing Then
            bQuery &= " AND Precio >= @PrecioDesde"
            hashtable.Add("@PrecioDesde", precioDesde)
        End If

        Try
            dt = conexion.Leer(bQuery, hashtable)
            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    Dim producto As New BLLProducto()
                    producto.Id = Convert.ToInt32(row("ID"))
                    producto.Nombre = row("NOMBRE").ToString()
                    producto.Precio = Convert.ToSingle(row("PRECIO"))
                    producto.Categoria = row("CATEGORIA").ToString()
                    ListaDeProductos.Add(producto)

                Next
            End If
            Return ListaDeProductos
        Catch ex As Exception
            Throw ex
        End Try


    End Function



    Public Function ModificarProducto(ByVal producto As BLLProducto) As Boolean

        Dim modificarQuery As String = $"UPDATE  PRODUCTOS SET NOMBRE = @Nombre, PRECIO = @Precio, CATEGORIA =@Categoria WHERE ID=@Id"
        Dim insertarQuery As String = "INSERT INTO PRODUCTOS (NOMBRE, PRECIO, CATEGORIA) VALUES (@Nombre,@Precio,@Categoria)"
        Dim conexion As New Conexion.Conexion()
        Dim hashtable As New Hashtable()

        Try
            hashtable.Add("@Nombre", producto.Nombre)
            hashtable.Add("@Categoria", producto.Categoria)
            hashtable.Add("@Precio", producto.Precio)

            If producto.Id <> 0 Then
                hashtable.Add("@Id", producto.Id)
                Return conexion.Guardar(modificarQuery, hashtable)
            Else
                Return conexion.Guardar(insertarQuery, hashtable)
            End If
        Catch ex As Exception
            Return False
            Throw ex
        End Try


    End Function
    Public Function EliminarProducto(ByVal producto As BLLProducto) As Boolean

        Dim EQuery As String = "DELETE FROM PRODUCTOS WHERE id=@id"
        Dim conexion As New Conexion.Conexion()
        Dim hashtable As New Hashtable()

        Try
            hashtable.Add("@Id", producto.Id)
            Return conexion.Guardar(EQuery, hashtable)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
