Public Interface ITransaccionesRecibosVenta
    Inherits ITransaccionesGenericas(Of TablaRecibosVenta)
    Function verUltimoID() As TablaRecibosVenta
End Interface
