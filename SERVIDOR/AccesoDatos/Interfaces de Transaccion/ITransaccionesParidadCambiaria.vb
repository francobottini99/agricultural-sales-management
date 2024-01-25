Public Interface ITransaccionesParidadCambiaria
    Inherits ITransaccionesGenericas(Of TablaParidadCambiaria)
    Function verRegistrosPorIdMonedas(id As Integer) As List(Of TablaParidadCambiaria)
End Interface
