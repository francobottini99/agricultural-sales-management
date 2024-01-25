Public Class TransaccionesDeposito
    Inherits Transacciones
    Implements ITransaccionesDepositos

    Public Async Function insRegistro(param As ModeloDepositos) As Task Implements ITransaccionesGenericas(Of ModeloDepositos).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.DEPOSITOS_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloDepositos) As Task Implements ITransaccionesGenericas(Of ModeloDepositos).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.DEPOSITOS_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloDepositos).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.DEPOSITOS_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verExisteDepositoPorNombre(nombre As String) As Task(Of Boolean) Implements ITransaccionesDepositos.verExisteDepositoPorNombre
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.DEPOSITOS_EXISTE, nombre)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistros() As Task(Of List(Of ModeloDepositos)) Implements ITransaccionesGenericas(Of ModeloDepositos).verRegistros
        Dim result As List(Of ModeloDepositos) = Await HttpGET(Of List(Of ModeloDepositos))(Peticiones.DEPOSITOS_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_insRegistro(param As ModeloDepositos) As Task Implements ITransaccionesDepositos.Servicio_insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.DEPOSITOS_SERVICIO_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_modRegistro(param As ModeloDepositos) As Task Implements ITransaccionesDepositos.Servicio_modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.DEPOSITOS_SERVICIO_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
