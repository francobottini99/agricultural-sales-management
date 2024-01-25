Public Interface ITransaccionesMovimientos_RemitoCompra_FacturaCompra
    Inherits ITransaccionesGenericas(Of ModeloMovimientos_RemitoCompra_FacturaCompra)
    Function verRegistrosPorIdRemitosCompra(id As Integer) As Task(Of List(Of ModeloMovimientos_RemitoCompra_FacturaCompra))
    Function verRegistrosPorIdFacturaCompra(id As Integer) As Task(Of List(Of ModeloMovimientos_RemitoCompra_FacturaCompra))
End Interface
