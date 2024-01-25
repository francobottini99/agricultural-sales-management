Public Interface ITransaccionesCaja
    Inherits ITransaccionesGenericas(Of TablaCaja)
    Function verRegistrosFechaDesdeHasta(fecDesde As Date, fecHasta As Date) As List(Of TablaCaja)
    Function verSaldoPesos() As Double
    Function verSaldoDolares() As Double
    Function verMinFecha() As TablaCaja
    Function verMaxFecha() As TablaCaja
    Function verUltimoId() As TablaCaja
End Interface
