Public Class TransaccionesNumeracion
    Inherits Transacciones
    Implements ITransaccionesNumeracion

    Public Async Function verRegistros() As Task(Of List(Of ModeloNumeracion)) Implements ITransaccionesGenericas(Of ModeloNumeracion).verRegistros
        Dim result As List(Of ModeloNumeracion) = Await HttpGET(Of List(Of ModeloNumeracion))(Peticiones.NUMERACION_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function insRegistro(param As ModeloNumeracion) As Task Implements ITransaccionesGenericas(Of ModeloNumeracion).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.NUMERACION_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloNumeracion) As Task Implements ITransaccionesGenericas(Of ModeloNumeracion).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.NUMERACION_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloNumeracion).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.NUMERACION_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
