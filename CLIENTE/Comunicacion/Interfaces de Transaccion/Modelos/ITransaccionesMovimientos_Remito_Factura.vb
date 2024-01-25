Public Interface ITransaccionesMovimientos_Remito_Factura
    Inherits ITransaccionesGenericas(Of ModeloMovimientos_Remito_Factura)
    Function verRegistrosPorIdRemitosVenta(id As Integer) As Task(Of List(Of ModeloMovimientos_Remito_Factura))
End Interface
