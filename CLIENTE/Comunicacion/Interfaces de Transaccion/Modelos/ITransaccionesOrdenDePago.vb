Public Interface ITransaccionesOrdenDePago
    Inherits ITransaccionesGenericas(Of ModeloOrdenDePago)
    Function Servicio_insRegistro(param As ServicioOrdenDePago) As Task
End Interface
