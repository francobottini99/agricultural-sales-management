Public Class TransaccionesStock
    Inherits Transacciones
    Implements ITransaccionesStock

    Public Async Function insRegistro(param As ModeloStock) As Task Implements ITransaccionesGenericas(Of ModeloStock).insRegistro
        Dim result As Boolean = Await HttpPOST(Of Boolean)(Peticiones.STOCK_INSERTAR, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function modRegistro(param As ModeloStock) As Task Implements ITransaccionesGenericas(Of ModeloStock).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Async Function elimRegistro(id As Integer) As Task Implements ITransaccionesGenericas(Of ModeloStock).elimRegistro
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.STOCK_ELIMINAR, id)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verUltimoId() As Task(Of Integer) Implements ITransaccionesStock.verUltimoId
        Dim result As Integer = Await HttpGET(Of Integer)(Peticiones.STOCK_ULTIMO_ID)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verStockFisico(idArt As Integer) As Task(Of Integer) Implements ITransaccionesStock.verStockFisico
        Dim result As Integer = Await HttpGET(Of Integer)(Peticiones.STOCK_FISICO, idArt)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verStockFisico(idArt As Integer, idDep As Integer) As Task(Of Integer) Implements ITransaccionesStock.verStockFisico
        Dim IDs() As Integer = {idArt, idDep}

        Dim result As Integer = Await HttpGET(Of Integer)(Peticiones.STOCK_FISICO_DEPOSITO, IDs)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verStockReservado(idArt As Integer) As Task(Of Integer) Implements ITransaccionesStock.verStockReservado
        Dim result As Integer = Await HttpGET(Of Integer)(Peticiones.STOCK_RESERVADO, idArt)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function verStockPorIdArticulo(id As Integer) As Task(Of List(Of ModeloStock)) Implements ITransaccionesStock.verStockPorIdArticulo
        Dim result As List(Of ModeloStock) = Await HttpGET(Of List(Of ModeloStock))(Peticiones.STOCK_FILTRAR_POR_ID_DE_ARTICULO, id)

        If Not IsNothing(result) Then
            Return result
        Else
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Async Function elimRegistroPorCampos(param As ModeloStock) As Task Implements ITransaccionesStock.elimRegistroPorCampos
        Dim result As Boolean = Await HttpGET(Of Boolean)(Peticiones.STOCK_ELIMINAR_POR_FECHA_MOVIMIENTO_CANTIDAD_ID_ARTICULO_ID_DEPOSITO, param)

        If result.Equals(Nothing) Then
            Throw New ExcepcionError(Err)
        End If
    End Function

    Public Function verRegistros() As Task(Of List(Of ModeloStock)) Implements ITransaccionesGenericas(Of ModeloStock).verRegistros
        Throw New NotImplementedException()
    End Function
End Class
