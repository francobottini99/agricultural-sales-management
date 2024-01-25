Public Interface ITransaccionesValoresEnCartera
    Inherits ITransaccionesGenericas(Of TablaValoresEnCartera)
    Function verListadoDisponible(disponible As String) As List(Of TablaValoresEnCartera)
    Function modDisponibilidad(id As Integer, disponible As String) As Integer
    Function verSaldoPesos() As Double
    Function verSaldoDolares() As Double
    Function verUltimoId() As TablaValoresEnCartera
End Interface
