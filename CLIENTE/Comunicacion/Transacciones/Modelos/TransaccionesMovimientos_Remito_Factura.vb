Public Class TransaccionesMovimientos_Remito_Factura
    Inherits Transacciones
    Implements ITransaccionesMovimientos_Remito_Factura

    Public Function verRegistros() As Task(Of List(Of ModeloMovimientos_Remito_Factura)) Implements ITransaccionesGenericas(Of ModeloMovimientos_Remito_Factura).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As ModeloMovimientos_Remito_Factura) As Task Implements ITransaccionesGenericas(Of ModeloMovimientos_Remito_Factura).insRegistro
        Throw New NotImplementedException()
    End Function

    Public Function modRegistro(param As ModeloMovimientos_Remito_Factura) As Task Implements ITransaccionesGenericas(Of ModeloMovimientos_Remito_Factura).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloMovimientos_Remito_Factura).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Async Function verRegistrosPorIdRemitosVenta(id As Integer) As Task(Of List(Of ModeloMovimientos_Remito_Factura)) Implements ITransaccionesMovimientos_Remito_Factura.verRegistrosPorIdRemitosVenta
        Dim result As List(Of ModeloMovimientos_Remito_Factura) = Await HttpGET(Of List(Of ModeloMovimientos_Remito_Factura))(Peticiones.MOVIMIENTOS_REMITO_FACTURA_FILTRAR_POR_ID_REMITO_DE_VENTA, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
