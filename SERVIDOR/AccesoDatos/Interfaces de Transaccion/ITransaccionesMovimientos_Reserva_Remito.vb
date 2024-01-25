Public Interface ITransaccionesMovimientos_Reserva_Remito
    Inherits ITransaccionesGenericas(Of TablaMovimientos_Reserva_Remito)
    Function verCantidadRemitada(idDetPed As Integer) As TablaMovimientos_Reserva_Remito
    Function elimRegistroPorIdRemitosVenta(id As Integer) As Integer
    Function verRegistrosPorIdRemitosVenta(id As Integer) As List(Of TablaMovimientos_Reserva_Remito)
    Function verRegistrosPorIdDetalleRemitosVenta(id As Integer) As List(Of TablaMovimientos_Reserva_Remito)
End Interface
