Public Class TransaccionesRecibosVenta
    Inherits Transacciones
    Implements ITransaccionesRecibosVenta

    Public Async Function Servicio_insRegistro(param As ServicioRecibosVenta) As Task Implements ITransaccionesRecibosVenta.Servicio_insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.RECIBOS_VENTA_SERVICIO_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function verRegistros() As Task(Of List(Of ModeloRecibosVenta)) Implements ITransaccionesGenericas(Of ModeloRecibosVenta).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As ModeloRecibosVenta) As Task Implements ITransaccionesGenericas(Of ModeloRecibosVenta).insRegistro
        Throw New NotImplementedException()
    End Function

    Public Function modRegistro(param As ModeloRecibosVenta) As Task Implements ITransaccionesGenericas(Of ModeloRecibosVenta).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloRecibosVenta).elimRegistro
        Throw New NotImplementedException()
    End Function
End Class
