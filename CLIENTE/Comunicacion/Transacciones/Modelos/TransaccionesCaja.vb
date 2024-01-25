Public Class TransaccionesCaja
    Inherits Transacciones
    Implements ITransaccionesCaja

    Public Async Function verRegistros() As Task(Of List(Of ModeloCaja)) Implements ITransaccionesGenericas(Of ModeloCaja).verRegistros
        Dim result As List(Of ModeloCaja) = Await HttpGET(Of List(Of ModeloCaja))(Peticiones.CAJA_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function insRegistro(param As ModeloCaja) As Task Implements ITransaccionesGenericas(Of ModeloCaja).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.CAJA_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloCaja) As Task Implements ITransaccionesGenericas(Of ModeloCaja).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.CAJA_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloCaja).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.CAJA_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verCajaPorFechas(fecDesde As Date, fecHasta As Date) As Task(Of List(Of ModeloCaja)) Implements ITransaccionesCaja.verCajaPorFechas
        Dim result As List(Of ModeloCaja) = Await HttpGET(Of List(Of ModeloCaja))(Peticiones.CAJA_LISTADO_POR_FECHAS, New Date() {fecDesde, fecHasta})

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verMaxFecha() As Task(Of Date) Implements ITransaccionesCaja.verMaxFecha
        Dim result As Date = Await HttpGET(Of Date)(Peticiones.CAJA_MAX_FECHA)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verMinFecha() As Task(Of Date) Implements ITransaccionesCaja.verMinFecha
        Dim result As Date = Await HttpGET(Of Date)(Peticiones.CAJA_MIN_FECHA)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verSaldoPesos() As Task(Of Double) Implements ITransaccionesCaja.verSaldoPesos
        Dim result As Double = Await HttpGET(Of Double)(Peticiones.CAJA_SALDO_PESOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verSaldoDolares() As Task(Of Double) Implements ITransaccionesCaja.verSaldoDolares
        Dim result As Double = Await HttpGET(Of Double)(Peticiones.CAJA_SALDO_DOLARES)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
