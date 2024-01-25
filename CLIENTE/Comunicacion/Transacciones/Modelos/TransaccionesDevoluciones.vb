Public Class TransaccionesDevoluciones
    Inherits Transacciones
    Implements ITransaccioneDevoluciones

    Public Async Function Servicio_insRegistro(param As ServicioDevoluciones) As Task Implements ITransaccioneDevoluciones.Servicio_insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.DEVOLUCIONES_SERVICIO_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function verRegistros() As Task(Of List(Of ModeloDevoluciones)) Implements ITransaccionesGenericas(Of ModeloDevoluciones).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As ModeloDevoluciones) As Task Implements ITransaccionesGenericas(Of ModeloDevoluciones).insRegistro
        Throw New NotImplementedException()
    End Function

    Public Function modRegistro(param As ModeloDevoluciones) As Task Implements ITransaccionesGenericas(Of ModeloDevoluciones).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloDevoluciones).elimRegistro
        Throw New NotImplementedException()
    End Function
End Class
