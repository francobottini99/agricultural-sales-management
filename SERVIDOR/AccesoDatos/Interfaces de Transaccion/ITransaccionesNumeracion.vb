Public Interface ITransaccionesNumeracion
    Inherits ITransaccionesGenericas(Of TablaNumeracion)
    Function modNroReserva(id As Integer, Nro As Integer) As Integer
    Function modNroRemito(id As Integer, Nro As Integer) As Integer
    Function modNroFacturaA(id As Integer, Nro As Integer) As Integer
    Function modNroFacturaB(id As Integer, Nro As Integer) As Integer
    Function modNroOrdenDeCompra(id As Integer, Nro As Integer) As Integer
    Function modNroRecibo(id As Integer, Nro As Integer) As Integer
    Function modNroDevolucion(id As Integer, Nro As Integer) As Integer
End Interface
