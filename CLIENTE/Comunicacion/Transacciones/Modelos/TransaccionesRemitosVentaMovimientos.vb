Public Class TransaccionesRemitosVentaMovimientos
    Inherits Transacciones
    Implements ITransaccionesRemitosVentaMovimientos

    Public Function verRegistros() As Task(Of List(Of ModeloRemitosVentaMovimientos)) Implements ITransaccionesGenericas(Of ModeloRemitosVentaMovimientos).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As ModeloRemitosVentaMovimientos) As Task Implements ITransaccionesGenericas(Of ModeloRemitosVentaMovimientos).insRegistro
        Throw New NotImplementedException()
    End Function

    Public Function modRegistro(param As ModeloRemitosVentaMovimientos) As Task Implements ITransaccionesGenericas(Of ModeloRemitosVentaMovimientos).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloRemitosVentaMovimientos).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Async Function verRegistrosPorIdRemitosVenta(id As Integer) As Task(Of List(Of ModeloRemitosVentaMovimientos)) Implements ITransaccionesRemitosVentaMovimientos.verRegistrosPorIdRemitosVenta
        Dim result As List(Of ModeloRemitosVentaMovimientos) = Await HttpGET(Of List(Of ModeloRemitosVentaMovimientos))(Peticiones.REMITO_VENTA_MOVIMIENTOS_FILTRAR_POR_ID_REMITO_DE_VENTA, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
