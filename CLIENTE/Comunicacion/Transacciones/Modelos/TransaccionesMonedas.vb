Public Class TransaccionesMonedas
    Inherits Transacciones
    Implements ITransaccionesMonedas

    Public Function insRegistro(param As ModeloMonedas) As Task Implements ITransaccionesGenericas(Of ModeloMonedas).insRegistro
        Throw New NotImplementedException()
    End Function

    Public Function modRegistro(param As ModeloMonedas) As Task Implements ITransaccionesGenericas(Of ModeloMonedas).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloMonedas).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Function verRegistroPorNombre(nombre As String) As Task(Of ModeloMonedas) Implements ITransaccionesMonedas.verRegistroPorNombre
        Throw New NotImplementedException()
    End Function

    Public Async Function verRegistros() As Task(Of List(Of ModeloMonedas)) Implements ITransaccionesGenericas(Of ModeloMonedas).verRegistros
        Dim result As List(Of ModeloMonedas) = Await HttpGET(Of List(Of ModeloMonedas))(Peticiones.MONEDAS_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
