Public Class TransaccionesOrdenDePagoMonedas
    Inherits Transacciones
    Implements ITransaccionesOrdenDePagoMonedas

    Public Async Function verRegistroPorIdOrdenDePago(id As Integer) As Task(Of List(Of ModeloOrdenDePagoMonedas)) Implements ITransaccionesOrdenDePagoMonedas.verRegistroPorIdOrdenDePago
        Dim result As List(Of ModeloOrdenDePagoMonedas) = Await HttpGET(Of List(Of ModeloOrdenDePagoMonedas))(Peticiones.ORDEN_DE_PAGO_MONEDAS_FILTRAR_POR_ID_ORDEN_DE_PAGO, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistroPorIdOrdenDePago(id As Integer) As Task Implements ITransaccionesOrdenDePagoMonedas.elimRegistroPorIdOrdenDePago
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.ORDEN_DE_PAGO_MONEDAS_ELIMINAR_POR_ID_ORDEN_DE_PAGO, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistros() As Task(Of List(Of ModeloOrdenDePagoMonedas)) Implements ITransaccionesGenericas(Of ModeloOrdenDePagoMonedas).verRegistros
        Dim result As List(Of ModeloOrdenDePagoMonedas) = Await HttpGET(Of List(Of ModeloOrdenDePagoMonedas))(Peticiones.ORDEN_DE_PAGO_MONEDAS_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function insRegistro(param As ModeloOrdenDePagoMonedas) As Task Implements ITransaccionesGenericas(Of ModeloOrdenDePagoMonedas).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.ORDEN_DE_PAGO_MONEDAS_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloOrdenDePagoMonedas) As Task Implements ITransaccionesGenericas(Of ModeloOrdenDePagoMonedas).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.ORDEN_DE_PAGO_MONEDAS_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloOrdenDePagoMonedas).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.ORDEN_DE_PAGO_MONEDAS_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
