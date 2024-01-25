Public Class TransaccionesFacturaCompraDetalle
    Inherits Transacciones
    Implements ITransaccionesFacturaCompraDetalle

    Public Async Function insRegistro(param As ModeloFacturaCompraDetalle) As Task Implements ITransaccionesGenericas(Of ModeloFacturaCompraDetalle).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.FACTURA_DE_COMPRA_DETALLE_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function modRegistro(param As ModeloFacturaCompraDetalle) As Task Implements ITransaccionesGenericas(Of ModeloFacturaCompraDetalle).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloFacturaCompraDetalle).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Async Function elimRegistroPorIdFacturaCompra(id As Integer) As Task Implements ITransaccionesFacturaCompraDetalle.elimRegistroPorIdFacturaCompra
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.FACTURA_DE_COMPRA_DETALLE_ELIMINAR_POR_ID_FACTURA_DE_COMPRA, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistrosPorIdFacturaCompra(id As Integer) As Task(Of List(Of ModeloFacturaCompraDetalle)) Implements ITransaccionesFacturaCompraDetalle.verRegistrosPorIdFacturaCompra
        Dim result As List(Of ModeloFacturaCompraDetalle) = Await HttpGET(Of List(Of ModeloFacturaCompraDetalle))(Peticiones.FACTURA_DE_COMPRA_DETALLE_FILTRAR_POR_ID_FACTURA_DE_COMPRA, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verRegistrosSinRemitar_idProveedor(id As Integer) As Task(Of List(Of ModeloFacturaCompraDetalle)) Implements ITransaccionesFacturaCompraDetalle.verRegistrosSinRemitar_idProveedor
        Dim result As List(Of ModeloFacturaCompraDetalle) = Await HttpGET(Of List(Of ModeloFacturaCompraDetalle))(Peticiones.FACTURA_DE_COMPRA_DETALLE_SIN_REMITAR_PROVEEDOR, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function verRegistros() As Task(Of List(Of ModeloFacturaCompraDetalle)) Implements ITransaccionesGenericas(Of ModeloFacturaCompraDetalle).verRegistros
        Throw New NotImplementedException()
    End Function
End Class
