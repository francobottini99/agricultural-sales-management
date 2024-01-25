Public Interface ITransaccionesDetalleFacturaVenta
    Inherits ITransaccionesGenericas(Of ModeloFacturaVentaDetalle)
    Function elimRegistroPorIdFacturaVenta(id As Integer) As Task(Of Integer)
    Function verDetalleFacturaVentaPorIdFacturaVenta(id As Integer) As Task(Of List(Of ModeloFacturaVentaDetalle))
    Function verRegistrosSinRemitar_idCliente(id As Integer) As Task(Of List(Of ModeloFacturaVentaDetalle))
    Function verRegistrosRemitado_idCliente(id As Integer) As Task(Of List(Of ModeloFacturaVentaDetalle))
    Function verRegistrosPorIdCliente(idCliente As Integer) As Task(Of List(Of ModeloFacturaVentaDetalle))
End Interface
