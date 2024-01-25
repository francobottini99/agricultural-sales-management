Public Interface ITransaccionesOrdenDePago
    Inherits ITransaccionesGenericas(Of TablaOrdenDePago)
    Function verUltimoID() As TablaOrdenDePago
    Function verOrdenDePagoPorId(id As Integer) As TablaOrdenDePago
End Interface
