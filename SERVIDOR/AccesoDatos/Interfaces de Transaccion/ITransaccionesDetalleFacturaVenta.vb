Public Interface ITransaccionesDetalleFacturaVenta
    Inherits ITransaccionesGenericas(Of TablaFacturaVentaDetalle)
    Function elimRegistroPorIdFacturaVenta(id As Integer) As Integer
    Function verDetalleFacturaVentaPorIdFacturaVenta(id As Integer) As List(Of TablaFacturaVentaDetalle)
    Function verRegistroPorIdCliente_Remitado(id As Integer, remitado As String) As List(Of TablaFacturaVentaDetalle)
    Function modEstadoRemitado(id As Integer, EstRem As String) As Integer
    Function verCantidadFacturada(idDetFac As Integer) As TablaFacturaVentaDetalle
    Function verUltimoId() As TablaFacturaVentaDetalle
    Function verRegistroPorIdCliente(id As Integer) As List(Of TablaFacturaVentaDetalle)
End Interface
