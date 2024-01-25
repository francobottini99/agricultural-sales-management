Public Interface ITransaccionesCaja
    Inherits ITransaccionesGenericas(Of ModeloCaja)
    Function verCajaPorFechas(fecDesde As Date, fecHasta As Date) As Task(Of List(Of ModeloCaja))
    Function verSaldoPesos() As Task(Of Double)
    Function verSaldoDolares() As Task(Of Double)
    Function verMaxFecha() As Task(Of Date)
    Function verMinFecha() As Task(Of Date)
End Interface
