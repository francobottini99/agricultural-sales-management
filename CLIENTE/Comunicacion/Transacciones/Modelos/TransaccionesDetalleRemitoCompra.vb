Public Class TransaccionesDetalleRemitoCompra
    Inherits Transacciones
    Implements ITransaccionesDetalleRemitoCompra

    Public Async Function modEstadoDeFacturacion(id As Integer, fac As String) As Task Implements ITransaccionesDetalleRemitoCompra.modEstadoDeFacturacion
        Dim result As String() = Await HttpPOST(Of String())(Peticiones.DETALLE_REMITOS_DE_COMPRA_FACTURACION, New ModeloDetalleRemitoCompra With {
                                                                .IdDetalleRemitosCompra = id,
                                                                .Facturado = fac
                                                            })

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistrosSinFacturar_idProveedor(id As Integer) As Task(Of List(Of ModeloDetalleRemitoCompra)) Implements ITransaccionesDetalleRemitoCompra.verRegistrosSinFacturar_idProveedor
        Dim result As List(Of ModeloDetalleRemitoCompra) = Await HttpGET(Of List(Of ModeloDetalleRemitoCompra))(Peticiones.DETALLE_REMITOS_DE_COMPRA_SIN_FACTURAR_PROVEEDOR, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimDetalleRemCompraPorIDremyPorIDart(idRC As Integer, idArt As Integer) As Task Implements ITransaccionesDetalleRemitoCompra.elimDetalleRemCompraPorIDremyPorIDart
        Dim result As String() = Await HttpGET(Of String())(Peticiones.DETALLE_REMITOS_DE_COMPRA_ELIMINAR_POR_ID_DE_ARTICULO_Y_POR_ID_DE_REMITO_DE_COMPRA, New ModeloDetalleRemitoCompra With {
                                                                .IdDetalleRemitosCompra = idRC,
                                                                .AscArticulos = New ModeloArticulos With {.IdArticulo = idArt}
                                                            })

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistroPorIdRemitosCompra(id As Integer) As Task Implements ITransaccionesDetalleRemitoCompra.elimRegistroPorIdRemitosCompra
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.DETALLE_REMITOS_DE_COMPRA_ELIMINAR_POR_ID_DE_REMITO_DE_COMPRA, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function insRegistro(param As ModeloDetalleRemitoCompra) As Task Implements ITransaccionesGenericas(Of ModeloDetalleRemitoCompra).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.DETALLE_REMITOS_DE_COMPRA_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function modRegistro(param As ModeloDetalleRemitoCompra) As Task Implements ITransaccionesGenericas(Of ModeloDetalleRemitoCompra).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloDetalleRemitoCompra).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Async Function verUltimoID() As Task(Of Integer) Implements ITransaccionesDetalleRemitoCompra.verUltimoID
        Dim result As Integer = Await HttpGET(Of Integer)(Peticiones.DETALLE_REMITOS_DE_COMPRA_ULTIMO_ID)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistrosPorIdRemtiosCompra(id As Integer) As Task(Of List(Of ModeloDetalleRemitoCompra)) Implements ITransaccionesDetalleRemitoCompra.verRegistrosPorIdRemtiosCompra
        Dim result As List(Of ModeloDetalleRemitoCompra) = Await HttpGET(Of List(Of ModeloDetalleRemitoCompra))(Peticiones.DETALLE_REMITOS_DE_COMPRA_FILTRAR_POR_ID_DE_REMITO_DE_COMPRA, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verCantidad(id As Integer) As Task(Of Double) Implements ITransaccionesDetalleRemitoCompra.verCantidad
        Dim result As Double = Await HttpGET(Of Double)(Peticiones.DETALLE_REMITOS_DE_COMPRA_CANTIDAD, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function verRegistros() As Task(Of List(Of ModeloDetalleRemitoCompra)) Implements ITransaccionesGenericas(Of ModeloDetalleRemitoCompra).verRegistros
        Throw New NotImplementedException()
    End Function
End Class
