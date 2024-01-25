Public Class TransaccionesRemitoCompraMovimientos
    Inherits Transacciones
    Implements ITransaccionesRemitoCompraMovimientos

    Public Function verRegistros() As Task(Of List(Of ModeloRemitosCompraMovimientos)) Implements ITransaccionesGenericas(Of ModeloRemitosCompraMovimientos).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As ModeloRemitosCompraMovimientos) As Task Implements ITransaccionesGenericas(Of ModeloRemitosCompraMovimientos).insRegistro
        Throw New NotImplementedException()
    End Function

    Public Function modRegistro(param As ModeloRemitosCompraMovimientos) As Task Implements ITransaccionesGenericas(Of ModeloRemitosCompraMovimientos).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloRemitosCompraMovimientos).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Async Function verRegistrosPorIdRemitosCompra(id As Integer) As Task(Of List(Of ModeloRemitosCompraMovimientos)) Implements ITransaccionesRemitoCompraMovimientos.verRegistrosPorIdRemitosCompra
        Dim result As List(Of ModeloRemitosCompraMovimientos) = Await HttpGET(Of List(Of ModeloRemitosCompraMovimientos))(Peticiones.REMITO_COMPRA_MOVIMIENTOS_FILTRAR_POR_ID_REMITO_DE_COMPRA, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
