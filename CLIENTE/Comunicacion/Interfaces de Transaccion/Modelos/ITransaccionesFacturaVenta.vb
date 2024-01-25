Public Interface ITransaccionesFacturaVenta
    Inherits ITransaccionesGenericas(Of ModeloFacturaVenta)
    Function verUltimoID() As Task(Of Integer)
    Function verFacturasVentaSinRemitar() As Task(Of List(Of ModeloFacturaVenta))
    Function Servicio_insRegistro(param As ServicioFacturaVenta) As Task(Of FEResultCAE)
End Interface
