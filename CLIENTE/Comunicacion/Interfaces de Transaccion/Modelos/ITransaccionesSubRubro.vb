Public Interface ITransaccionesSubRubro
    Inherits ITransaccionesGenericas(Of ModeloSubRubro)
    Function verExisteSubRubroPorIdRubro(id As Integer) As Task(Of Boolean)
    Function verExisteSubRubroPorNombre(nombre As String) As Task(Of Boolean)
    Function verExisteSubRubroPorAbrebiatura(abrebiatura As String) As Task(Of Boolean)
    Function Servicio_insRegistro(param As ModeloSubRubro) As Task
    Function Servicio_modRegistro(param As ModeloSubRubro) As Task

End Interface
