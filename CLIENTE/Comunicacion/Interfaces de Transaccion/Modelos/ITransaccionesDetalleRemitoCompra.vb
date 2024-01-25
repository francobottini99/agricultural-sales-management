Public Interface ITransaccionesDetalleRemitoCompra
    Inherits ITransaccionesGenericas(Of ModeloDetalleRemitoCompra)
    Function modEstadoDeFacturacion(id As Integer, fac As String) As Task
    Function elimDetalleRemCompraPorIDremyPorIDart(idRC As Integer, idArt As Integer) As Task
    Function elimRegistroPorIdRemitosCompra(id As Integer) As Task
    Function verUltimoID() As Task(Of Integer)
    Function verRegistrosPorIdRemtiosCompra(id As Integer) As Task(Of List(Of ModeloDetalleRemitoCompra))
    Function verCantidad(id As Integer) As Task(Of Double)
    Function verRegistrosSinFacturar_idProveedor(id As Integer) As Task(Of List(Of ModeloDetalleRemitoCompra))
End Interface
