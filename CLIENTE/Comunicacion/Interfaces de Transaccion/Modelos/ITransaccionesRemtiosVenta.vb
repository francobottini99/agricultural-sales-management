Public Interface ITransaccionesRemtiosVenta
    Inherits ITransaccionesGenericas(Of ModeloRemitosVenta)
    Function verUltimoId() As Task(Of Integer)
    Function verSinFacturar() As Task(Of List(Of ModeloRemitosVenta))
    Function modEstadoFacturacion(id As Integer, estFact As String) As Task
    Function Servicio_insRegistro(param As ServicioRemitoVenta) As Task
    Function Servicio_modRegistro(param As ServicioRemitoVenta) As Task
    Function Servicio_elimRegistro(param As ServicioRemitoVenta) As Task
End Interface
