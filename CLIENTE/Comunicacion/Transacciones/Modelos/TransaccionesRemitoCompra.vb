Public Class TransaccionesRemitoCompra
    Inherits Transacciones
    Implements ITransaccionesRemitosCompra

    Public Async Function modEstadoFacturacion(id As Integer, estFac As String) As Task Implements ITransaccionesRemitosCompra.modEstadoFacturacion
        Dim result As String() = Await HttpPOST(Of String())(Peticiones.REMITO_DE_COMPRA_FACTURACION, New ModeloRemitosCompra With {
                                                                .IdRemitosCompra = id,
                                                                .Facturado = estFac
                                                            })

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function insRegistro(param As ModeloRemitosCompra) As Task Implements ITransaccionesGenericas(Of ModeloRemitosCompra).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.REMITO_DE_COMPRA_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function modRegistro(param As ModeloRemitosCompra) As Task Implements ITransaccionesGenericas(Of ModeloRemitosCompra).modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.REMITO_DE_COMPRA_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloRemitosCompra).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.REMITO_DE_COMPRA_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verUltimoId() As Task(Of Integer) Implements ITransaccionesRemitosCompra.verUltimoId
        Dim result As Integer = Await HttpGET(Of Integer)(Peticiones.REMITO_DE_COMPRA_ULTIMO_ID)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verSinFacturar() As Task(Of List(Of ModeloRemitosCompra)) Implements ITransaccionesRemitosCompra.verSinFacturar
        Dim result As List(Of ModeloRemitosCompra) = Await HttpGET(Of List(Of ModeloRemitosCompra))(Peticiones.REMITO_DE_COMPRA_SIN_FACTURAR)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistroPorId(id As Integer) As Task(Of ModeloRemitosCompra) Implements ITransaccionesRemitosCompra.verRegistroPorId
        Dim result As ModeloRemitosCompra = Await HttpGET(Of ModeloRemitosCompra)(Peticiones.REMITO_DE_COMPRA_FILTRAR_POR_ID_REMITO_DE_COMPRA, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistros() As Task(Of List(Of ModeloRemitosCompra)) Implements ITransaccionesGenericas(Of ModeloRemitosCompra).verRegistros
        Dim result As List(Of ModeloRemitosCompra) = Await HttpGET(Of List(Of ModeloRemitosCompra))(Peticiones.REMITO_DE_COMPRA_TODOS)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_insRegistro(param As ServicioRemitoCompra) As Task Implements ITransaccionesRemitosCompra.Servicio_insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.REMITO_DE_COMPRA_SERVICIO_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_modRegistro(param As ServicioRemitoCompra) As Task Implements ITransaccionesRemitosCompra.Servicio_modRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.REMITO_DE_COMPRA_SERVICIO_MODIFICAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function Servicio_elimRegistro(param As ServicioRemitoCompra) As Task Implements ITransaccionesRemitosCompra.Servicio_elimRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.REMITO_DE_COMPRA_SERVICIO_ELIMINAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function
End Class
