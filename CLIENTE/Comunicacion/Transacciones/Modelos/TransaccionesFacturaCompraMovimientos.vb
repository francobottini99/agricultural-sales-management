Public Class TransaccionesFacturaCompraMovimientos
    Inherits Transacciones
    Implements ITransaccionesFacturaCompraMovimientos

    Public Function verRegistros() As Task(Of List(Of ModeloFacturaCompraMovimientos)) Implements ITransaccionesGenericas(Of ModeloFacturaCompraMovimientos).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As ModeloFacturaCompraMovimientos) As Task Implements ITransaccionesGenericas(Of ModeloFacturaCompraMovimientos).insRegistro
        Throw New NotImplementedException()
    End Function

    Public Function modRegistro(param As ModeloFacturaCompraMovimientos) As Task Implements ITransaccionesGenericas(Of ModeloFacturaCompraMovimientos).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloFacturaCompraMovimientos).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Async Function verRegistrosPorIdFacturaCompra(id As Integer) As Task(Of List(Of ModeloFacturaCompraMovimientos)) Implements ITransaccionesFacturaCompraMovimientos.verRegistrosPorIdFacturaCompra
        Dim result As List(Of ModeloFacturaCompraMovimientos) = Await HttpGET(Of List(Of ModeloFacturaCompraMovimientos))(Peticiones.FACTURA_COMPRA_MOVIMIENTOS_FILTRAR_POR_ID_FACTURA_DE_COMPRA, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
