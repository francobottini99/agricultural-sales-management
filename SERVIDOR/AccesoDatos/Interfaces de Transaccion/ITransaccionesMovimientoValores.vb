Public Interface ITransaccionesMovimientoValores
    Inherits ITransaccionesGenericas(Of TablaMovimientoValores)
    Function verRegistroPorIdCaja(idCaja As Integer) As TablaMovimientoValores
    Function verListadoPorIdValoresEnCartera(idValoresEnCartera As Integer) As List(Of TablaMovimientoValores)
End Interface
