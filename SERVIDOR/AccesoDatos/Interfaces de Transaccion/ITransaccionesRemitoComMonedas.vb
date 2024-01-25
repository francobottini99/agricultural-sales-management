Public Interface ITransaccionesRemitoComMonedas
    Inherits ITransaccionesGenericas(Of TablaRemitoComMonedas)
    Function elimRegistroPorIdRemitosCompra(id As Integer) As Integer
    Function verRegistroPorIdRemitosCompra(id As Integer) As TablaRemitoComMonedas
End Interface
