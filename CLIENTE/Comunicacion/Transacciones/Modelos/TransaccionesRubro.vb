Public Class TransaccionesRubro
    Inherits Transacciones
    Implements ITransaccionesRubro

    Public Async Function insRegistro(param As ModeloRubro) As Task Implements ITransaccionesGenericas(Of ModeloRubro).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.RUBRO_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloRubro) As Task Implements ITransaccionesGenericas(Of ModeloRubro).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.RUBRO_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloRubro).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.RUBRO_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function verExisteRubroPorNombre(nombre As String) As Task(Of Boolean) Implements ITransaccionesRubro.verExisteRubroPorNombre
        Throw New NotImplementedException()
    End Function

    Public Function verExisteRubroPorAbrebiatura(abrebiatura As String) As Task(Of Boolean) Implements ITransaccionesRubro.verExisteRubroPorAbrebiatura
        Throw New NotImplementedException()
    End Function

    Public Async Function verRegistros() As Task(Of List(Of ModeloRubro)) Implements ITransaccionesGenericas(Of ModeloRubro).verRegistros
        Dim result As List(Of ModeloRubro) = Await HttpGET(Of List(Of ModeloRubro))(Peticiones.RUBRO_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_insRegistro(param As ModeloRubro) As Task Implements ITransaccionesRubro.Servicio_insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.RUBRO_SERVICIO_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_eliRegistro(id As Integer) As Task Implements ITransaccionesRubro.Servicio_eliRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.RUBRO_SERVICIO_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_modRegistro(param As ModeloRubro) As Task Implements ITransaccionesRubro.Servicio_modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.RUBRO_SERVICIO_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
