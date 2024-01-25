Public Interface ITransaccionesFacturaCompra
    Inherits ITransaccionesGenericas(Of ModeloFacturaCompra)
    Function verUltimoId() As Task(Of Integer)
    Function Servicio_insRegistro(param As ServicioFacturaCompra) As Task
    Function Servicio_modRegistro(param As ServicioFacturaCompra) As Task
    Function Servicio_elimRegistro(param As ServicioFacturaCompra) As Task
End Interface
