Public Interface ITransaccionesFacturaComMonedas
    Inherits ITransaccionesGenericas(Of TablaFacturaComMonedas)
    Function elimRegistroPorIdFacturaCompra(id As Integer) As Integer
    Function verRegistrosPorIdFacturaCompra(id As Integer) As TablaFacturaComMonedas
End Interface
