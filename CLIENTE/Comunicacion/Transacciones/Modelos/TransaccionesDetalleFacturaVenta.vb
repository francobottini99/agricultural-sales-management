Public Class TransaccionesDetalleFacturaVenta
    Inherits Transacciones
    Implements ITransaccionesDetalleFacturaVenta

    Public Async Function insRegistro(param As ModeloFacturaVentaDetalle) As Task Implements ITransaccionesGenericas(Of ModeloFacturaVentaDetalle).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.FACTURA_DE_VENTA_DETALLE_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistrosSinRemitar_idCliente(id As Integer) As Task(Of List(Of ModeloFacturaVentaDetalle)) Implements ITransaccionesDetalleFacturaVenta.verRegistrosSinRemitar_idCliente
        Dim result As List(Of ModeloFacturaVentaDetalle) = Await HttpGET(Of List(Of ModeloFacturaVentaDetalle))(Peticiones.FACTURA_DE_VENTA_DETALLE_SIN_REMITAR_CLIENTE, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function
    Public Function modRegistro(param As ModeloFacturaVentaDetalle) As Task Implements ITransaccionesGenericas(Of ModeloFacturaVentaDetalle).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloFacturaVentaDetalle).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Async Function elimRegistroPorIdFacturaVenta(id As Integer) As Task(Of Integer) Implements ITransaccionesDetalleFacturaVenta.elimRegistroPorIdFacturaVenta
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.FACTURA_DE_VENTA_DETALLE_ELIMINAR_POR_ID_FACTURA_DE_VENTA, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verDetalleFacturaVentaPorIdFacturaVenta(id As Integer) As Task(Of List(Of ModeloFacturaVentaDetalle)) Implements ITransaccionesDetalleFacturaVenta.verDetalleFacturaVentaPorIdFacturaVenta
        Dim result As List(Of ModeloFacturaVentaDetalle) = Await HttpGET(Of List(Of ModeloFacturaVentaDetalle))(Peticiones.FACTURA_DE_VENTA_DETALLE_FILTRAR_POR_ID_FACTURA_DE_VENTA, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function verRegistros() As Task(Of List(Of ModeloFacturaVentaDetalle)) Implements ITransaccionesGenericas(Of ModeloFacturaVentaDetalle).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Async Function verRegistrosPorIdCliente(idCliente As Integer) As Task(Of List(Of ModeloFacturaVentaDetalle)) Implements ITransaccionesDetalleFacturaVenta.verRegistrosPorIdCliente
        Dim result As List(Of ModeloFacturaVentaDetalle) = Await HttpGET(Of List(Of ModeloFacturaVentaDetalle))(Peticiones.FACTURA_DE_VENTA_DETALLE_FILTRAR_POR_ID_CLIENTE, idCliente)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistrosRemitado_idCliente(id As Integer) As Task(Of List(Of ModeloFacturaVentaDetalle)) Implements ITransaccionesDetalleFacturaVenta.verRegistrosRemitado_idCliente
        Dim result As List(Of ModeloFacturaVentaDetalle) = Await HttpGET(Of List(Of ModeloFacturaVentaDetalle))(Peticiones.FACTURA_DE_VENTA_DETALLE_REMITADO_CLIENTE, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
