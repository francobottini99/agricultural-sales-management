Public Class TransaccionesClientes
    Inherits Transacciones
    Implements ITransaccionesClientes

    Public Async Function Recuperar(id As Integer) As Task Implements ITransaccionesClientes.Recuperar
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.CLIENTES_RECUPERAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function insRegistro(param As ModeloCliente) As Task Implements ITransaccionesGenericas(Of ModeloCliente).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.CLIENTES_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloCliente) As Task Implements ITransaccionesGenericas(Of ModeloCliente).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.CLIENTES_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloCliente).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.CLIENTES_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verExisteCliente(nombre As String, cuit As String, situacionIva As String) As Task(Of String()) Implements ITransaccionesClientes.verExisteCliente
        Dim result As String() = Await HttpGET(Of String())(Peticiones.CLIENTES_EXISTE, New ModeloCliente With {
                                                                .RazonSocial = nombre,
                                                                .CUIT = cuit,
                                                                .SituacionIVA = situacionIva
                                                            })

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistroPorID(id As Integer) As Task(Of ModeloCliente) Implements ITransaccionesClientes.verRegistroPorID
        Dim result As ModeloCliente = Await HttpGET(Of ModeloCliente)(Peticiones.CLIENTES_FILTRAR_POR_ID_DE_CLIENTE, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistros() As Task(Of List(Of ModeloCliente)) Implements ITransaccionesGenericas(Of ModeloCliente).verRegistros
        Dim result As List(Of ModeloCliente) = Await HttpGET(Of List(Of ModeloCliente))(Peticiones.CLIENTES_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_insRegistro(param As ModeloCliente) As Task Implements ITransaccionesClientes.Servicio_insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.CLIENTES_SERVICIO_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_modRegistro(param As ModeloCliente) As Task Implements ITransaccionesClientes.Servicio_modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.CLIENTES_SERVICIO_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
