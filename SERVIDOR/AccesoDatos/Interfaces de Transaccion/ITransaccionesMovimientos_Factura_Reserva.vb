Public Interface ITransaccionesMovimientos_Factura_Reserva
    Inherits ITransaccionesGenericas(Of TablaMovimientos_Factura_Reserva)
    Function verCantidadFacturada(idDetPed As Integer) As TablaMovimientos_Factura_Reserva
    Function verRegistrosPorIdDetalleFacturaVenta(id As Integer) As List(Of TablaMovimientos_Factura_Reserva)
    Function elimRegistroPorIdFacturaVentaMovimientos(id As Integer) As Integer
End Interface
