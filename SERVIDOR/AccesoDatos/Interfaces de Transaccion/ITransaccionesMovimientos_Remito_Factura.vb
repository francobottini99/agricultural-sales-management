Public Interface ITransaccionesMovimientos_Remito_Factura
    Inherits ITransaccionesGenericas(Of TablaMovimientos_Remito_Factura)
    Function verCantidadRemitada(idDetFac As Integer) As TablaMovimientos_Remito_Factura
    Function verRegistrosPorIdRemitosVenta(id As Integer) As List(Of TablaMovimientos_Remito_Factura)
    Function verRegistrosPorIdRemitosVentaMovimientos(id As Integer) As List(Of TablaMovimientos_Remito_Factura)
    Function verCantidadFacturada(idDetRem As Integer) As TablaMovimientos_Remito_Factura
    Function verCantidadFacturadaIdDetFac(idDetFac As Integer) As TablaMovimientos_Remito_Factura
End Interface
