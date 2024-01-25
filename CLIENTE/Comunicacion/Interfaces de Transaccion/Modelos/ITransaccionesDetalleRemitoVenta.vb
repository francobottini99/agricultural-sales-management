Public Interface ITransaccionesDetalleRemitoVenta
    Inherits ITransaccionesGenericas(Of ModeloDetalleRemitoVenta)
    Function elimRegistroPorIdRemitosVenta(id As Integer) As Task(Of Integer)
    Function elimRegistroPorIdRemitosVentaYIdArticulo(idRem As Integer, idArt As Integer) As Task(Of Integer)
    Function verRegistrosPorIdRemitosVenta(id As Integer) As Task(Of List(Of ModeloDetalleRemitoVenta))
    Function verUltimoId() As Task(Of Integer)
    Function modEstadoFacturacion(id As Integer, ByVal EstFac As String) As Task
    Function verRegistrosPorIdClienteYFacturado(param As ModeloDetalleRemitoVenta) As Task(Of List(Of ModeloDetalleRemitoVenta))
    Function verRegistrosPorIdCliente(idCliente As Integer) As Task(Of List(Of ModeloDetalleRemitoVenta))
    Function verRegistroPorId(id As Integer) As Task(Of ModeloDetalleRemitoVenta)
    Function verRegistrosSinFacturar_idCliente(id As Integer) As Task(Of List(Of ModeloDetalleRemitoVenta))
End Interface
