Public Interface ITransaccionesRecibosVenta
    Inherits ITransaccionesGenericas(Of ModeloRecibosVenta)
    Function Servicio_insRegistro(param As ServicioRecibosVenta) As Task
End Interface
