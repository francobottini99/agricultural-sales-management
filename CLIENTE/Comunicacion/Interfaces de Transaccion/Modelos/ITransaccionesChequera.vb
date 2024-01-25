Public Interface ITransaccionesChequera
    Inherits ITransaccionesGenericas(Of ModeloChequera)
    Function verExisteChequeEnChequera(nro As Integer) As Task(Of Boolean)
    Function verUltimoID() As Task(Of Integer)
    Function Servicio_insRegistro(param As ModeloChequera) As Task
    Function Servicio_modRegistro(param As ModeloChequera) As Task
    Function Servicio_elimRegistro(Id As Integer) As Task
    Function verRegistrosSinCompletar() As Task(Of List(Of ModeloChequera))
End Interface
