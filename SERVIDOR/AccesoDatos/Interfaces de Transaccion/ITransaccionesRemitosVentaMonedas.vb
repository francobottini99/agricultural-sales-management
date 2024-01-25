Public Interface ITransaccionesRemitosVentaMonedas
    Inherits ITransaccionesGenericas(Of TablaRemitosVentaMonedas)
    Function verRegistroPorIdRemitosVenta(id As Integer) As TablaRemitosVentaMonedas
    Function elimRegistroPorIdRemitosVenta(id As Integer) As Integer
End Interface
