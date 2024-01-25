Public Interface ITransaccionesFacturaVentaMoneda
    Inherits ITransaccionesGenericas(Of ModeloFacturaVentaMonedas)
    Function verRegistroPorIdFacturaVenta(id As Integer) As Task(Of ModeloFacturaVentaMonedas)
    Function elimRegistroPorIdFacturaVenta(id As Integer) As Task(Of Integer)
End Interface
