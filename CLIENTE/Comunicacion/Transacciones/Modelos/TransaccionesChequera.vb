Public Class TransaccionesChequera
    Inherits Transacciones
    Implements ITransaccionesChequera

    Public Async Function insRegistro(param As ModeloChequera) As Task Implements ITransaccionesGenericas(Of ModeloChequera).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.CHEQUERA_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloChequera) As Task Implements ITransaccionesGenericas(Of ModeloChequera).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.CHEQUERA_MODIFCAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloChequera).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.CHEQUERA_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verExisteChequeEnChequera(nro As Integer) As Task(Of Boolean) Implements ITransaccionesChequera.verExisteChequeEnChequera
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.CHEQUERA_EXISTE, nro)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verUltimoID() As Task(Of Integer) Implements ITransaccionesChequera.verUltimoID
        Dim result As Integer = Await HttpGET(Of Integer)(Peticiones.CHEQUERA_ULTIMO_ID)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistros() As Task(Of List(Of ModeloChequera)) Implements ITransaccionesGenericas(Of ModeloChequera).verRegistros
        Dim result As List(Of ModeloChequera) = Await HttpGET(Of List(Of ModeloChequera))(Peticiones.CHEQUERA_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_insRegistro(param As ModeloChequera) As Task Implements ITransaccionesChequera.Servicio_insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.CHEQUERA_SERVICIO_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_modRegistro(param As ModeloChequera) As Task Implements ITransaccionesChequera.Servicio_modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.CHEQUERA_SERVICIO_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_elimRegistro(Id As Integer) As Task Implements ITransaccionesChequera.Servicio_elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.CHEQUERA_SERVICIO_ELIMINAR, Id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistrosSinCompletar() As Task(Of List(Of ModeloChequera)) Implements ITransaccionesChequera.verRegistrosSinCompletar
        Dim result As List(Of ModeloChequera) = Await HttpGET(Of List(Of ModeloChequera))(Peticiones.CHEQUERA_LISTADO_SIN_COMPLETAR)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
