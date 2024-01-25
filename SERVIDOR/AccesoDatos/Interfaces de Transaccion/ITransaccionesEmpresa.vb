Public Interface ITransaccionesEmpresa
    Inherits ITransaccionesGenericas(Of TablaEmpresa)
    Function verRegistro() As TablaEmpresa
End Interface
