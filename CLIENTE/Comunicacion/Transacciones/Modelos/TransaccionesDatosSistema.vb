Public Class TransaccionesDatosSistema
    Inherits Transacciones
    Implements ITransaccionesDatosSistema

    Public Function insRegistro(param As ModeloDatosSistema) As Task Implements ITransaccionesGenericas(Of ModeloDatosSistema).insRegistro
        Throw New NotImplementedException()
    End Function

    Public Function modRegistro(param As ModeloDatosSistema) As Task Implements ITransaccionesGenericas(Of ModeloDatosSistema).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloDatosSistema).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Async Function verRegistro() As Task(Of ModeloDatosSistema) Implements ITransaccionesDatosSistema.verRegistro
        Dim result As ModeloDatosSistema = Await HttpGET(Of ModeloDatosSistema)(Peticiones.DATOS_DEL_SISTEMA_CONSULTAR)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function verRegistros() As Task(Of List(Of ModeloDatosSistema)) Implements ITransaccionesGenericas(Of ModeloDatosSistema).verRegistros
        Throw New NotImplementedException()
    End Function
End Class
