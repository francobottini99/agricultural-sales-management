Public Interface ITransaccionesDetalleRemitoCompra
    Inherits ITransaccionesGenericas(Of TablaDetalleRemitoCompra)
    Function modEstadoDeFacturacion(id As Integer, fac As String) As Integer
    Function modCantidadFacturada(id As Integer, cant As Double) As Integer
    Function elimDetalleRemCompraPorIDremyPorIDart(idRC As Integer, idArt As Integer) As Integer
    Function elimRegistroPorIdRemitosCompra(id As Integer) As Integer
    Function verUltimoID() As TablaDetalleRemitoCompra
    Function verRegistrosPorIdRemtiosCompra(id As Integer) As List(Of TablaDetalleRemitoCompra)
    Function verCantidad(id As Integer) As Double
    Function verRegistroPorIdProveedor_Facturado(id As Integer, facturado As String) As List(Of TablaDetalleRemitoCompra)
End Interface
