Public Interface ITransaccionesFacturaVentaMoneda
    Inherits ITransaccionesGenericas(Of TablaFacturaVentaMonedas)
    Function verRegistroPorIdFacturaVenta(id As Integer) As TablaFacturaVentaMonedas
    Function elimRegistroPorIdFacturaVenta(id As Integer) As Integer
End Interface
