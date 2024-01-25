Public Class TransaccionesSubRubro
    Inherits Transacciones
    Implements ITransaccionesSubRubro

    Public Async Function insRegistro(param As ModeloSubRubro) As Task Implements ITransaccionesGenericas(Of ModeloSubRubro).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.SUB_RUBRO_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloSubRubro) As Task Implements ITransaccionesGenericas(Of ModeloSubRubro).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.SUB_RUBRO_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloSubRubro).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.SUB_RUBRO_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verExisteSubRubroPorIdRubro(id As Integer) As Task(Of Boolean) Implements ITransaccionesSubRubro.verExisteSubRubroPorIdRubro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.SUB_RUBRO_EXISTE_POR_ID_DE_RUBRO, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verExisteSubRubroPorNombre(nombre As String) As Task(Of Boolean) Implements ITransaccionesSubRubro.verExisteSubRubroPorNombre
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.SUB_RUBRO_EXISTE, nombre)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function verExisteSubRubroPorAbrebiatura(abrebiatura As String) As Task(Of Boolean) Implements ITransaccionesSubRubro.verExisteSubRubroPorAbrebiatura
        Throw New NotImplementedException()
    End Function

    Public Async Function verRegistros() As Task(Of List(Of ModeloSubRubro)) Implements ITransaccionesGenericas(Of ModeloSubRubro).verRegistros
        Dim result As List(Of ModeloSubRubro) = Await HttpGET(Of List(Of ModeloSubRubro))(Peticiones.SUB_RUBRO_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_insRegistro(param As ModeloSubRubro) As Task Implements ITransaccionesSubRubro.Servicio_insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.SUB_RUBRO_SERVICIO_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_modRegistro(param As ModeloSubRubro) As Task Implements ITransaccionesSubRubro.Servicio_modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.SUB_RUBRO_SERVICIO_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
