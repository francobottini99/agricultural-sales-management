Public Class TransaccionesDetalleCheques
    Inherits Transacciones
    Implements ITransaccionesDetalleCheques

    Public Async Function insRegistro(param As ModeloDetalleCheque) As Task Implements ITransaccionesGenericas(Of ModeloDetalleCheque).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.DETALLE_CHEQUES_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloDetalleCheque) As Task Implements ITransaccionesGenericas(Of ModeloDetalleCheque).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.DETALLE_CHEQUES_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloDetalleCheque).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.DETALLE_CHEQUES_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verDetalleChequePorChequera(id As Integer) As Task(Of List(Of ModeloDetalleCheque)) Implements ITransaccionesDetalleCheques.verDetalleChequePorChequera
        Dim result As List(Of ModeloDetalleCheque) = Await HttpGET(Of List(Of ModeloDetalleCheque))(Peticiones.DETALLE_CHEQUES_CHEQUES_POR_CHEQUERA, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimChequePorIdChequera(id As Integer) As Task Implements ITransaccionesDetalleCheques.elimChequePorIdChequera
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.DETALLE_CHEQUES_ELIMINAR_POR_ID_CHEQUERA, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function verRegistros() As Task(Of List(Of ModeloDetalleCheque)) Implements ITransaccionesGenericas(Of ModeloDetalleCheque).verRegistros
        Throw New NotImplementedException()
    End Function
End Class
