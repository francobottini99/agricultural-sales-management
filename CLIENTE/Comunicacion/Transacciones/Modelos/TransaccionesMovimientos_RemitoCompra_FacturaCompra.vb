Public Class TransaccionesMovimientos_RemitoCompra_FacturaCompra
    Inherits Transacciones
    Implements ITransaccionesMovimientos_RemitoCompra_FacturaCompra

    Public Function verRegistros() As Task(Of List(Of ModeloMovimientos_RemitoCompra_FacturaCompra)) Implements ITransaccionesGenericas(Of ModeloMovimientos_RemitoCompra_FacturaCompra).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As ModeloMovimientos_RemitoCompra_FacturaCompra) As Task Implements ITransaccionesGenericas(Of ModeloMovimientos_RemitoCompra_FacturaCompra).insRegistro
        Throw New NotImplementedException()
    End Function

    Public Function modRegistro(param As ModeloMovimientos_RemitoCompra_FacturaCompra) As Task Implements ITransaccionesGenericas(Of ModeloMovimientos_RemitoCompra_FacturaCompra).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloMovimientos_RemitoCompra_FacturaCompra).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Async Function verRegistrosPorIdRemitosCompra(id As Integer) As Task(Of List(Of ModeloMovimientos_RemitoCompra_FacturaCompra)) Implements ITransaccionesMovimientos_RemitoCompra_FacturaCompra.verRegistrosPorIdRemitosCompra
        Dim result As List(Of ModeloMovimientos_RemitoCompra_FacturaCompra) = Await HttpGET(Of List(Of ModeloMovimientos_RemitoCompra_FacturaCompra))(Peticiones.MOVIMIENTOS_REMITO_COMPRA_FACTURA_COMPRA_FILTRAR_POR_ID_REMITO_DE_COMPRA, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistrosPorIdFacturaCompra(id As Integer) As Task(Of List(Of ModeloMovimientos_RemitoCompra_FacturaCompra)) Implements ITransaccionesMovimientos_RemitoCompra_FacturaCompra.verRegistrosPorIdFacturaCompra
        Dim result As List(Of ModeloMovimientos_RemitoCompra_FacturaCompra) = Await HttpGET(Of List(Of ModeloMovimientos_RemitoCompra_FacturaCompra))(Peticiones.MOVIMIENTOS_REMITO_COMPRA_FACTURA_COMPRA_FILTRAR_POR_ID_FACTURA_DE_COMPRA, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
