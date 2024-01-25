Public Interface ITransaccionesDetalleRemitoVenta
    Inherits ITransaccionesGenericas(Of TablaDetalleRemitoVenta)
    Function elimRegistroPorIdRemitosVenta(id As Integer) As Integer
    Function elimRegistroPorIdRemitosVentaYIdArticulo(idRem As Integer, idArt As Integer) As Integer
    Function verRegistrosPorIdRemitosVenta(id As Integer) As List(Of TablaDetalleRemitoVenta)
    Function verUltimoId() As TablaDetalleRemitoVenta
    Function modEstadoFacturacion(id As Integer, ByVal EstFac As String) As Integer
    Function verRegistroPorIdCliente_Facturado(id As Integer, facturado As String) As List(Of TablaDetalleRemitoVenta)
    Function verRegistroPorIdCliente(id As Integer) As List(Of TablaDetalleRemitoVenta)
    Function verRegistroPorId(id As Integer) As TablaDetalleRemitoVenta
End Interface
