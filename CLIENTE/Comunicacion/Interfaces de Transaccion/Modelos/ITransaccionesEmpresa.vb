Public Interface ITransaccionesEmpresa
    Inherits ITransaccionesGenericas(Of ModeloEmpresa)
    Function verRegistro() As Task(Of ModeloEmpresa)
End Interface
