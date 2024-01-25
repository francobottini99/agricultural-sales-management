Public Interface ITransaccionesCtaCteVenta
    Inherits ITransaccionesGenericas(Of ModeloCuentaCorrienteVenta)
    Function verUltimoID() As Task(Of Integer)
    Function verPorIdCliente(id As Integer) As Task(Of List(Of ModeloCuentaCorrienteVenta))
End Interface
