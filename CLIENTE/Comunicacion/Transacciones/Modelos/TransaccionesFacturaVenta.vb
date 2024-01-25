Public Class TransaccionesFacturaVenta
    Inherits Transacciones
    Implements ITransaccionesFacturaVenta

    Public Async Function insRegistro(param As ModeloFacturaVenta) As Task Implements ITransaccionesGenericas(Of ModeloFacturaVenta).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.FACTURA_DE_VENTA_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloFacturaVenta) As Task Implements ITransaccionesGenericas(Of ModeloFacturaVenta).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.FACTURA_DE_VENTA_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloFacturaVenta).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.FACTURA_DE_VENTA_DETALLE_ELIMINAR_POR_ID_FACTURA_DE_VENTA, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verUltimoID() As Task(Of Integer) Implements ITransaccionesFacturaVenta.verUltimoID
        Dim result As Integer = Await HttpGET(Of Integer)(Peticiones.FACTURA_DE_VENTA_ULTIMO_ID)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verFacturasVentaSinRemitar() As Task(Of List(Of ModeloFacturaVenta)) Implements ITransaccionesFacturaVenta.verFacturasVentaSinRemitar
        Dim result As List(Of ModeloFacturaVenta) = Await HttpGET(Of List(Of ModeloFacturaVenta))(Peticiones.FACTURA_DE_VENTA_FILTRAR_SIN_REMITRAR)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_insRegistro(param As ServicioFacturaVenta) As Task(Of FEResultCAE) Implements ITransaccionesFacturaVenta.Servicio_insRegistro
        Dim result As FEResultCAE = Await HttpPOST(Of FEResultCAE)(Peticiones.FACTURA_DE_VENTA_SERVICIO_INSERTAR, param)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistros() As Task(Of List(Of ModeloFacturaVenta)) Implements ITransaccionesGenericas(Of ModeloFacturaVenta).verRegistros
        Dim result As List(Of ModeloFacturaVenta) = Await HttpGET(Of List(Of ModeloFacturaVenta))(Peticiones.FACTURA_DE_VENTA_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
