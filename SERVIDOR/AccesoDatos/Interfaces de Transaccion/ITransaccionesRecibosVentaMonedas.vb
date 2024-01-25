Public Interface ITransaccionesRecibosVentaMonedas
    Inherits ITransaccionesGenericas(Of TablaRecibosVentaMonedas)
    Function verRegistroPorIdRecibosVenta(id As Integer) As List(Of TablaRecibosVentaMonedas)
    Function elimRegistroPorIdRecibosVenta(id As Integer) As Integer
End Interface
