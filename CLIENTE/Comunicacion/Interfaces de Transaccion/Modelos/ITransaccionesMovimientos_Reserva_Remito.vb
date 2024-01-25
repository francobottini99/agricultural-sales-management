Public Interface ITransaccionesMovimientos_Reserva_Remito
    Inherits ITransaccionesGenericas(Of ModeloMovimientos_Reserva_Remito)
    Function verRegistrosPorIdRemitosVenta(id As Integer) As Task(Of List(Of ModeloMovimientos_Reserva_Remito))
End Interface
