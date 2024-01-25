Public Interface ITransaccionesRubro
    Inherits ITransaccionesGenericas(Of ModeloRubro)
    Function verExisteRubroPorNombre(nombre As String) As Task(Of Boolean)
    Function verExisteRubroPorAbrebiatura(abrebiatura As String) As Task(Of Boolean)
    Function Servicio_insRegistro(param As ModeloRubro) As Task
    Function Servicio_eliRegistro(id As Integer) As Task
    Function Servicio_modRegistro(param As ModeloRubro) As Task
End Interface
