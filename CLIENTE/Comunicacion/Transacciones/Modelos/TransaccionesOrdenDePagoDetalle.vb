Public Class TransaccionesOrdenDePagoDetalle
    Inherits Transacciones
    Implements ITransaccionesOrdenDePagoDetalle

    Public Async Function verRegistros() As Task(Of List(Of ModeloOrdenDePagoDetalle)) Implements ITransaccionesGenericas(Of ModeloOrdenDePagoDetalle).verRegistros
        Dim result As List(Of ModeloOrdenDePagoDetalle) = Await HttpGET(Of List(Of ModeloOrdenDePagoDetalle))(Peticiones.ORDEN_DE_PAGO_DETALLE_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function insRegistro(param As ModeloOrdenDePagoDetalle) As Task Implements ITransaccionesGenericas(Of ModeloOrdenDePagoDetalle).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.ORDEN_DE_PAGO_DETALLE_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloOrdenDePagoDetalle) As Task Implements ITransaccionesGenericas(Of ModeloOrdenDePagoDetalle).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.ORDEN_DE_PAGO_DETALLE_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloOrdenDePagoDetalle).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.ORDEN_DE_PAGO_DETALLE_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
