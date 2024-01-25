Public Interface ITransaccionesRemitosVentaMovimientos
    Inherits ITransaccionesGenericas(Of ModeloRemitosVentaMovimientos)
    Function verRegistrosPorIdRemitosVenta(id As Integer) As Task(Of List(Of ModeloRemitosVentaMovimientos))
End Interface
