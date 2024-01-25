Public Class TransaccionesMovimientos_Reserva_Remito
    Inherits Transacciones
    Implements ITransaccionesMovimientos_Reserva_Remito

    Public Function verRegistros() As Task(Of List(Of ModeloMovimientos_Reserva_Remito)) Implements ITransaccionesGenericas(Of ModeloMovimientos_Reserva_Remito).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As ModeloMovimientos_Reserva_Remito) As Task Implements ITransaccionesGenericas(Of ModeloMovimientos_Reserva_Remito).insRegistro
        Throw New NotImplementedException()
    End Function

    Public Function modRegistro(param As ModeloMovimientos_Reserva_Remito) As Task Implements ITransaccionesGenericas(Of ModeloMovimientos_Reserva_Remito).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloMovimientos_Reserva_Remito).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Async Function verRegistrosPorIdRemitosVenta(id As Integer) As Task(Of List(Of ModeloMovimientos_Reserva_Remito)) Implements ITransaccionesMovimientos_Reserva_Remito.verRegistrosPorIdRemitosVenta
        Dim result As List(Of ModeloMovimientos_Reserva_Remito) = Await HttpGET(Of List(Of ModeloMovimientos_Reserva_Remito))(Peticiones.MOVIMIENTOS_RESERVA_REMITO_FILTRAR_POR_ID_REMITO_DE_VENTA, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
