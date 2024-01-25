Public Class TransaccionesOrdenDePago
    Inherits Transacciones
    Implements ITransaccionesOrdenDePago

    Public Async Function verRegistros() As Task(Of List(Of ModeloOrdenDePago)) Implements ITransaccionesGenericas(Of ModeloOrdenDePago).verRegistros
        Dim result As List(Of ModeloOrdenDePago) = Await HttpGET(Of List(Of ModeloOrdenDePago))(Peticiones.ORDEN_DE_PAGO_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function insRegistro(param As ModeloOrdenDePago) As Task Implements ITransaccionesGenericas(Of ModeloOrdenDePago).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.ORDEN_DE_PAGO_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloOrdenDePago) As Task Implements ITransaccionesGenericas(Of ModeloOrdenDePago).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.ORDEN_DE_PAGO_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloOrdenDePago).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.ORDEN_DE_PAGO_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_insRegistro(param As ServicioOrdenDePago) As Task Implements ITransaccionesOrdenDePago.Servicio_insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.ORDEN_DE_PAGO_SERVICIO_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
