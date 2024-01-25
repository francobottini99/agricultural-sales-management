Public Class TransaccionesDetalleRemitoVenta
    Inherits Transacciones
    Implements ITransaccionesDetalleRemitoVenta

    Public Async Function modEstadoFacturacion(id As Integer, EstFac As String) As Task Implements ITransaccionesDetalleRemitoVenta.modEstadoFacturacion
        Dim result As String() = Await HttpPOST(Of String())(Peticiones.DETALLE_REMITOS_DE_VENTA_FACTURACION, New ModeloDetalleRemitoVenta With {
                                                                .IdDetalleRemitosVenta = id,
                                                                .Facturado = EstFac
                                                            })

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function insRegistro(param As ModeloDetalleRemitoVenta) As Task Implements ITransaccionesGenericas(Of ModeloDetalleRemitoVenta).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.DETALLE_REMITOS_DE_VENTA_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function modRegistro(param As ModeloDetalleRemitoVenta) As Task Implements ITransaccionesGenericas(Of ModeloDetalleRemitoVenta).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloDetalleRemitoVenta).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Async Function elimRegistroPorIdRemitosVenta(id As Integer) As Task(Of Integer) Implements ITransaccionesDetalleRemitoVenta.elimRegistroPorIdRemitosVenta
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.DETALLE_REMITOS_DE_VENTA_ELIMINAR_POR_ID_DE_REMITO_DE_VENTA, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistroPorIdRemitosVentaYIdArticulo(idRem As Integer, idArt As Integer) As Task(Of Integer) Implements ITransaccionesDetalleRemitoVenta.elimRegistroPorIdRemitosVentaYIdArticulo
        Dim result As Integer = Await HttpGET(Of Integer)(Peticiones.DETALLE_REMITOS_DE_VENTA_ELIMINAR_POR_ID_DE_ARTICULO_Y_POR_ID_DE_REMITO_DE_VENTA, New ModeloDetalleRemitoVenta With {
                                                                .IdDetalleRemitosVenta = idRem,
                                                                .AscArticulos = New ModeloArticulos With {.IdArticulo = idArt}
                                                            })

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistrosPorIdRemitosVenta(id As Integer) As Task(Of List(Of ModeloDetalleRemitoVenta)) Implements ITransaccionesDetalleRemitoVenta.verRegistrosPorIdRemitosVenta
        Dim result As List(Of ModeloDetalleRemitoVenta) = Await HttpGET(Of List(Of ModeloDetalleRemitoVenta))(Peticiones.DETALLE_REMITOS_DE_VENTA_FILTRAR_POR_ID_DE_REMITO_DE_VENTA, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistrosSinFacturar_idCliente(id As Integer) As Task(Of List(Of ModeloDetalleRemitoVenta)) Implements ITransaccionesDetalleRemitoVenta.verRegistrosSinFacturar_idCliente
        Dim result As List(Of ModeloDetalleRemitoVenta) = Await HttpGET(Of List(Of ModeloDetalleRemitoVenta))(Peticiones.DETALLE_REMITOS_SIN_FACTURAR_CLIENTE, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistrosPorIdClienteYFacturado(param As ModeloDetalleRemitoVenta) As Task(Of List(Of ModeloDetalleRemitoVenta)) Implements ITransaccionesDetalleRemitoVenta.verRegistrosPorIdClienteYFacturado
        Dim result As List(Of ModeloDetalleRemitoVenta) = Await HttpPOST(Of List(Of ModeloDetalleRemitoVenta))(Peticiones.DETALLE_REMITOS_DE_VENTA_FILTRAR_POR_ID_CLIENTE_FACTURADO, param)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verUltimoId() As Task(Of Integer) Implements ITransaccionesDetalleRemitoVenta.verUltimoId
        Dim result As Integer = Await HttpGET(Of Integer)(Peticiones.DETALLE_REMITOS_DE_VENTA_ULTIMO_ID)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function verRegistros() As Task(Of List(Of ModeloDetalleRemitoVenta)) Implements ITransaccionesGenericas(Of ModeloDetalleRemitoVenta).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Async Function verRegistroPorId(id As Integer) As Task(Of ModeloDetalleRemitoVenta) Implements ITransaccionesDetalleRemitoVenta.verRegistroPorId
        Dim result As ModeloDetalleRemitoVenta = Await HttpGET(Of ModeloDetalleRemitoVenta)(Peticiones.DETALLE_REMITOS_DE_VENTA_FILTRAR_POR_ID_DETALLE_REMITO_VENTA, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistrosPorIdCliente(idCliente As Integer) As Task(Of List(Of ModeloDetalleRemitoVenta)) Implements ITransaccionesDetalleRemitoVenta.verRegistrosPorIdCliente
        Dim result As List(Of ModeloDetalleRemitoVenta) = Await HttpGET(Of List(Of ModeloDetalleRemitoVenta))(Peticiones.DETALLE_REMITOS_DE_VENTA_FILTRAR_POR_ID_CLIENTE, idCliente)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
