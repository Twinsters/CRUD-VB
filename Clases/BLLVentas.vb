Imports System.Windows.Forms

Public Class BLLVentas

    'Propiedades
    Private _id As Integer
    Private _idVtasItems As Integer
    Private _idCliente As BLLCliente
    Private _fecha As Date
    Private _idProducto As BLLProducto
    Private _cantidad As Integer
    Private _total As Single
    Private _precioTotalProducto As Single


    'Constructor
    Public Sub New(id As Integer, idCLiente As BLLCliente, fecha As Date, idProducto As BLLProducto, cantidad As Integer, precioTotalProducto As Single, idVtasItems As Integer, total As Single)
        _id = id
        _idCliente = idCLiente
        _fecha = fecha
        _idProducto = idProducto
        _cantidad = cantidad
        _precioTotalProducto = precioTotalProducto
        _idVtasItems = idVtasItems
        _total = total

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
    'Propiedad IdVtasItems
    Public Property IdVtasItems As Integer
        Get
            Return _idVtasItems
        End Get
        Set(value As Integer)
            _idVtasItems = value
        End Set
    End Property
    'Propiedad Id CLiente
    Public Property IdCLiente As BLLCliente
        Get
            Return _idCliente
        End Get
        Set(value As BLLCliente)
            _idCliente = value
        End Set
    End Property
    'Propiedad Fecha
    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
    'Propiedad Total


    'Propiedad Id Producto
    Public Property IdProducto As BLLProducto
        Get
            Return _idProducto
        End Get
        Set(value As BLLProducto)
            _idProducto = value
        End Set
    End Property
    'Propiedad Cantidad
    Public Property Cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
        End Set
    End Property
    'Propiedad Precio Total Producto
    Public Property PrecioTotalProducto As Single
        Get
            Return _precioTotalProducto
        End Get
        Set(value As Single)
            _precioTotalProducto = value
        End Set
    End Property
    Public Property Total As Single
        Get
            Return _total
        End Get
        Set(value As Single)
            _total = value
        End Set
    End Property


    Public Function BuscarVentas(Optional ByVal fechaDesde As Date = Nothing, Optional ByVal fechaHasta As Date = Nothing, Optional ByVal nombre As String = Nothing) As List(Of BLLVentas)
        Dim listaVentas As New List(Of BLLVentas)()
        Try
            Dim buscarQueryVentasClientes As String = "SELECT * FROM VENTAS v, CLIENTES c WHERE 1 = 1 AND v.IDCliente = c.ID"
            Dim hastableClienteVenta As New Hashtable()
            Dim dt As New DataTable()
            If Not fechaDesde.Equals(Nothing) Then
                buscarQueryVentasClientes &= " AND v.Fecha >= @FechaDesde"
                hastableClienteVenta.Add("@FechaDesde", fechaDesde)
            End If
            If Not fechaHasta.Equals(Nothing) Then
                buscarQueryVentasClientes &= " AND v.Fecha <= @FechaHasta"
                hastableClienteVenta.Add("@FechaHasta", fechaHasta)
            End If
            If Not String.IsNullOrEmpty(nombre) Then
                buscarQueryVentasClientes &= " AND c.cliente LIKE '%'@NombreCliente'%'"
                hastableClienteVenta.Add("@NombreCliente", nombre)
            End If
            Dim conexion As New Conexion.Conexion()
            dt = conexion.Leer(buscarQueryVentasClientes, hastableClienteVenta)
            For Each row As DataRow In dt.Rows
                Dim venta As New BLLVentas()
                Dim cliente As New BLLCliente()
                venta.Id = Convert.ToInt32(row("ID"))
                cliente.Id = Convert.ToInt32(row("IDCliente"))
                venta.Fecha = Convert.ToDateTime(row("Fecha"))
                venta.Total = Convert.ToSingle(row("Total"))
                cliente.Nombre = row("Cliente").ToString()
                cliente.Telefono = row("Telefono").ToString()
                cliente.Correo = row("Correo").ToString()
                venta.IdCLiente = cliente
                listaVentas.Add(venta)
            Next
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return listaVentas
    End Function
    Public Function BuscarVenta(ByVal idVenta As Integer) As List(Of BLLVentas)
        Dim buscarQuery As String = "SELECT v.ID as VtasID,v.Fecha as Fecha, v.Total as VtasTotal,vi.ID as VtasItemsId,vi.Cantidad as VtasItemsCantidad, vi.PrecioTotal as VtasItemsPreTotal,
        vi.PrecioUnitario as VtasItemsPreUni, v.IDCliente as IDCLiente, c.Cliente as Nombre, c.Correo as Correo, c.Telefono as Telefono,
        p.ID as IDProducto, p.Nombre as NombreProducto, p.Categoria as Categoria, p.Precio as precioProdcuto
        FROM VENTAS v,VENTASITEMS vi,CLIENTES c ,PRODUCTOS p 
        WHERE  c.ID = v.IDCliente AND v.ID = vi.IDVenta AND vi.IDProducto = p.ID AND v.ID = @IDVenta"
        Dim conexion As New Conexion.Conexion()
        Dim hashtableVenta As New Hashtable()
        Dim dt As New DataTable()
        Dim ListaVentas As New List(Of BLLVentas)
        Try
            If idVenta <> 0 Then
                hashtableVenta.Add("@IDVenta", idVenta)
                dt = conexion.Leer(buscarQuery, hashtableVenta)
                For Each row As DataRow In dt.Rows
                    Dim cliente As New BLLCliente()
                    Dim producto As New BLLProducto()
                    Dim venta As New BLLVentas()
                    cliente.Id = Convert.ToInt32(row("IDCliente"))
                    cliente.Nombre = row("Nombre").ToString()
                    cliente.Telefono = row("Telefono").ToString()
                    cliente.Correo = row("Correo").ToString()
                    producto.Id = Convert.ToInt32(row("IDProducto"))
                    producto.Nombre = row("NombreProducto").ToString()
                    producto.Precio = Convert.ToSingle(row("precioProdcuto"))
                    producto.Categoria = row("Categoria").ToString()
                    venta.IdCLiente = cliente
                    venta.IdProducto = producto
                    venta.Id = Convert.ToInt32(row("VtasID"))
                    venta.Fecha = Convert.ToDateTime(row("Fecha"))
                    venta.Cantidad = Convert.ToInt32(row("VtasItemsCantidad"))
                    venta.PrecioTotalProducto = Convert.ToSingle(row("VtasItemsPreTotal"))
                    venta.Total = Convert.ToSingle(row("VtasTotal"))
                    venta.IdVtasItems = Convert.ToInt32(row("VtasItemsId"))
                    ListaVentas.Add(venta)
                Next
            End If


            Return ListaVentas
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    Public Function CargarVenta(ByVal carrito As List(Of BLLVentas), Optional ByVal carritoOriginal As List(Of BLLVentas) = Nothing, Optional ByVal idVenta As Integer = 0) As Boolean
        Dim idCliente As Integer = 0
        Dim PrecioTotal As Single = 0
        Dim fechaHoraActual As Date = DateTime.Now
        Dim IdVentaBase As Integer = 0
        Dim insertarQueryCliente As String = "INSERT INTO VENTAS (IDCLIENTE, FECHA, TOTAL) OUTPUT INSERTED.ID VALUES (@IdCliente, @Fecha, @Total)"
        Dim insertarQueryVenta As String = "INSERT INTO VENTASITEMS (IDVENTA, IDPRODUCTO, PRECIOUNITARIO, CANTIDAD, PRECIOTOTAL) VALUES (@IdVenta, @IdProducto, @PrecioUnitario, @Cantidad, @PrecioTotal)"
        Dim ModificarQueryCliente As String = "UPDATE VENTAS SET IDCLIENTE = @IdCliente, FECHA = @Fecha, TOTAL = @Total WHERE ID = @IdVenta"
        Dim ModificarQueryVenta As String = "UPDATE VENTASITEMS SET PRECIOUNITARIO = @PrecioUnitario, CANTIDAD = @Cantidad, PRECIOTOTAL = @PrecioTotal WHERE ID = @IDVentaItem AND IDVenta = @IDVenta"
        Dim EliminarArticulo As String = "DELETE FROM VENTASITEMS WHERE ID = @ID"

        Dim listaIdNuevos As New List(Of Integer)
        Dim listaIdOriginales As New List(Of Integer)
        Dim conexion As New Conexion.Conexion()

        Dim hashtableCliente As New Hashtable()
        Dim hashtableVenta As New Hashtable()

        Try

            For Each c In carrito
                idCliente = c.IdCLiente.Id
                PrecioTotal += c.PrecioTotalProducto
            Next

            hashtableVenta.Clear()
            hashtableCliente.Add("@IdCliente", idCliente)
            hashtableCliente.Add("@Fecha", fechaHoraActual)
            hashtableCliente.Add("@Total", PrecioTotal)


            If idVenta <> 0 Then
                hashtableCliente.Add("@IdVenta", idVenta)
                Dim exito As Boolean = conexion.Guardar(ModificarQueryCliente, hashtableCliente)
                If Not exito Then
                    Throw New Exception("Error al insertar en VENTASITEMS.")
                End If
                For Each original As BLLVentas In carritoOriginal
                    listaIdOriginales.Add(original.IdVtasItems)
                    For Each modificado As BLLVentas In carrito
                        If modificado.IdVtasItems > 0 Then
                            If original.IdVtasItems = modificado.IdVtasItems Then
                                listaIdNuevos.Add(modificado.IdVtasItems)
                            End If
                        End If
                    Next
                Next
                Dim IDFaltantes As New List(Of Integer)(listaIdOriginales.Except(listaIdNuevos))
                For Each id As Integer In IDFaltantes
                    hashtableVenta.Clear()
                    hashtableVenta.Add("@Id", id)
                    exito = conexion.Guardar(EliminarArticulo, hashtableVenta)
                Next

                For Each modificado As BLLVentas In carrito
                    If modificado.IdVtasItems > 0 Then
                        hashtableVenta.Clear()
                        hashtableVenta.Add("@IdVenta", idVenta)
                        hashtableVenta.Add("@IDVentaItem", modificado.IdVtasItems)
                        hashtableVenta.Add("@PrecioUnitario", modificado.IdProducto.Precio)
                        hashtableVenta.Add("@Cantidad", modificado.Cantidad)
                        hashtableVenta.Add("@PrecioTotal", modificado.PrecioTotalProducto)
                        exito = conexion.Guardar(ModificarQueryVenta, hashtableVenta)

                    Else
                        hashtableVenta.Clear()
                        hashtableVenta.Add("@IdVenta", idVenta)
                        hashtableVenta.Add("@IdProducto", modificado.IdProducto.Id)
                        hashtableVenta.Add("@PrecioUnitario", modificado.IdProducto.Precio)
                        hashtableVenta.Add("@Cantidad", modificado.Cantidad)
                        hashtableVenta.Add("@PrecioTotal", modificado.PrecioTotalProducto)
                        exito = conexion.Guardar(insertarQueryVenta, hashtableVenta)
                        If Not exito Then
                            Throw New Exception("Error al insertar en VENTASITEMS.")
                        End If
                    End If
                Next
            Else

                IdVentaBase = conexion.GuardarYTraer(insertarQueryCliente, hashtableCliente)

                If IdVentaBase <> 0 Then
                    For Each c In carrito
                        hashtableVenta.Clear()

                        hashtableVenta.Add("@IdVenta", IdVentaBase)
                        hashtableVenta.Add("@IdProducto", c.IdProducto.Id)
                        hashtableVenta.Add("@PrecioUnitario", c.IdProducto.Precio)
                        hashtableVenta.Add("@Cantidad", c.Cantidad)
                        hashtableVenta.Add("@PrecioTotal", c.PrecioTotalProducto)

                        Dim exito As Boolean = conexion.Guardar(insertarQueryVenta, hashtableVenta)

                        If Not exito Then

                            Throw New Exception("Error al insertar en VENTASITEMS.")
                        End If
                    Next
                Else

                    Throw New Exception("Error al insertar en VENTAS.")
                End If
            End If


            Return True
        Catch ex As Exception

            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function EliminarVenta(idVenta) As Boolean
        Try
            Dim EliminarQuery As String = "DELETE FROM VENTAS WHERE ID = @idVenta;DELETE FROM VENTASITEMS WHERE IDVENTA = @idVenta;"
            Dim conexion As New Conexion.Conexion()
            Dim has As New Hashtable()
            has.Add("@idVenta", idVenta)
            Dim res As Boolean = conexion.Guardar(EliminarQuery, has)
            Return res
        Catch ex As Exception

            Throw New Exception("Error al Eliminar Ventas.", ex)
        End Try

    End Function
End Class
