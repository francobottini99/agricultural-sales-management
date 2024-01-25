Public Interface ITransaccionesCtaCteCompra
    Inherits ITransaccionesGenericas(Of ModeloCuentaCorrienteCompra)
    Function verUltimoID() As Task(Of Integer)
    Function verPorIdProveedores(id As Integer) As Task(Of List(Of ModeloCuentaCorrienteCompra))
End Interface
