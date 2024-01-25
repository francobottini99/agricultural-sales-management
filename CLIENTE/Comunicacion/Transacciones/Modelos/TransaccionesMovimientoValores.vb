Public Class TransaccionesMovimientoValores
    Inherits Transacciones
    Implements ITransaccionesMovimientoValores

    Public Async Function verRegistros() As Task(Of List(Of ModeloMovimientoValores)) Implements ITransaccionesGenericas(Of ModeloMovimientoValores).verRegistros
        Dim result As List(Of ModeloMovimientoValores) = Await HttpGET(Of List(Of ModeloMovimientoValores))(Peticiones.MOVIMIENTO_VALORES_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function insRegistro(param As ModeloMovimientoValores) As Task Implements ITransaccionesGenericas(Of ModeloMovimientoValores).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.MOVIMIENTO_VALORES_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloMovimientoValores) As Task Implements ITransaccionesGenericas(Of ModeloMovimientoValores).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.MOVIMIENTO_VALORES_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloMovimientoValores).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.MOVIMIENTO_VALORES_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_insRegistro(param As ModeloMovimientoValores) As Task Implements ITransaccionesMovimientoValores.Servicio_insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.MOVIMIENTO_VALORES_SERVICIO_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_elimRegistro(param As ModeloMovimientoValores) As Task Implements ITransaccionesMovimientoValores.Servicio_elimRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.MOVIMIENTO_VALORES_SERVICIO_ELIMINAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
