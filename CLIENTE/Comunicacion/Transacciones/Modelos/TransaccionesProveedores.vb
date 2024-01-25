Public Class TransaccionesProveedores
    Inherits Transacciones
    Implements ITransaccionesProveedores

    Public Async Function Recuperar(id As Integer) As Task Implements ITransaccionesProveedores.Recuperar
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.PROVEEDORES_RECUPERAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function insRegistro(param As ModeloProveedores) As Task Implements ITransaccionesGenericas(Of ModeloProveedores).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.PROVEEDORES_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloProveedores) As Task Implements ITransaccionesGenericas(Of ModeloProveedores).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.PROVEEDORES_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloProveedores).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.PROVEEDORES_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verExisteProveedorNombre(nombre As String) As Task(Of String()) Implements ITransaccionesProveedores.verExisteProveedorNombre
        Dim result As String() = Await HttpGET(Of String())(Peticiones.PROVEEDORES_EXISTE, New ModeloProveedores With {
                                                                .RazonSocial = nombre
                                                            })

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verExisteProveedorCuit(cuit As String) As Task(Of String()) Implements ITransaccionesProveedores.verExisteProveedorCuit
        Dim result As String() = Await HttpGET(Of String())(Peticiones.PROVEEDORES_EXISTE, New ModeloProveedores With {
                                                                .CUIT = cuit
                                                            })

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verExisteProveedorNombreCuit(nombre As String, cuit As String) As Task(Of String()) Implements ITransaccionesProveedores.verExisteProveedorNombreCuit
        Dim result As String() = Await HttpGET(Of String())(Peticiones.PROVEEDORES_EXISTE, New ModeloProveedores With {
                                                                .RazonSocial = nombre,
                                                                .CUIT = cuit
                                                            })

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistros() As Task(Of List(Of ModeloProveedores)) Implements ITransaccionesGenericas(Of ModeloProveedores).verRegistros
        Dim result As List(Of ModeloProveedores) = Await HttpGET(Of List(Of ModeloProveedores))(Peticiones.PROVEEDORES_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function
    Public Async Function Servicio_insRegistro(param As ModeloProveedores) As Task Implements ITransaccionesProveedores.Servicio_insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.PROVEEDORES_SERVICIO_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_modRegistro(param As ModeloProveedores) As Task Implements ITransaccionesProveedores.Servicio_modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.PROVEEDORES_SERVICIO_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
