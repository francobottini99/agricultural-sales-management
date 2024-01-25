Public Class TransaccionesBancos
    Inherits Transacciones
    Implements ITransaccionesBancos

    Public Async Function insRegistro(param As ModeloBancos) As Task Implements ITransaccionesGenericas(Of ModeloBancos).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.BANCOS_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloBancos) As Task Implements ITransaccionesGenericas(Of ModeloBancos).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.BANCOS_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloBancos).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.BANCOS_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verExisteBancoPorNombre(nombre As String) As Task(Of Boolean) Implements ITransaccionesBancos.verExisteBancoPorNombre
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.BANCOS_EXISTE, nombre)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistros() As Task(Of List(Of ModeloBancos)) Implements ITransaccionesGenericas(Of ModeloBancos).verRegistros
        Dim result As List(Of ModeloBancos) = Await HttpGET(Of List(Of ModeloBancos))(Peticiones.BANCOS_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_insRegistro(param As ModeloBancos) As Task Implements ITransaccionesBancos.Servicio_insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.BANCOS_SERVICIO_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_modRegistro(param As ModeloBancos) As Task Implements ITransaccionesBancos.Servicio_modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.BANCOS_SERVICIO_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
