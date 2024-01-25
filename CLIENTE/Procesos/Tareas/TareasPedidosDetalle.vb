Imports Comunicacion

Public Class TareasPedidosDetalle
    Inherits EnlaceTransacciones(Of TransaccionesPedidosDetalle)

    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        Err = New Errores()
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property Err As Errores
        Get
            Return _Err
        End Get
        Set(value As Errores)
            _Err = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS ACCESO A COMUNICACIONES"
    Public Async Function Insertar(_ResDet As PedidosDetalle) As Task(Of Boolean)
        Try
            Await Transaccion.insRegistro(Drivers.DetalleReservas(_ResDet))

            Return True
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return False
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return False
        End Try
    End Function

    Public Async Function Modificar(_ResDet As PedidosDetalle) As Task(Of Boolean)
        Try
            Await Transaccion.modRegistro(Drivers.DetalleReservas(_ResDet))

            Return True
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return False
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return False
        End Try
    End Function

    Public Async Function Eliminar(id As Integer) As Task(Of Boolean)
        Try
            Await Transaccion.elimRegistro(id)

            Return True
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return False
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return False
        End Try
    End Function

    Public Async Function verDetalleReservaPorIdDetalleReserva(id As Integer) As Task(Of PedidosDetalle)
        Try
            Return Drivers.DetalleReservas(Await Transaccion.verRegistroPorId(id))
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return Nothing
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return Nothing
        End Try
    End Function

    Public Async Function ListadoCompleto() As Task(Of List(Of PedidosDetalle))
        Try
            Dim list As New List(Of PedidosDetalle)

            For Each item In Await Transaccion.verRegistros()
                list.Add(Drivers.DetalleReservas(item))
            Next

            Return list
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return Nothing
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return Nothing
        End Try
    End Function

    Public Async Function verDetalleReservaPorIDreserv(id As Integer) As Task(Of List(Of PedidosDetalle))
        Try
            Dim list As New List(Of PedidosDetalle)

            For Each item In Await Transaccion.verRegistrosPorIdPedido(id)
                list.Add(Drivers.DetalleReservas(item))
            Next

            Return list
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return Nothing
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return Nothing
        End Try
    End Function

    Public Async Function verDetalleReservaPorIdCliente(id As Integer) As Task(Of List(Of PedidosDetalle))
        Try
            Dim list As New List(Of PedidosDetalle)

            For Each item In Await Transaccion.verRegistrosPorIdCliente(id)
                list.Add(Drivers.DetalleReservas(item))
            Next

            Return list
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return Nothing
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return Nothing
        End Try
    End Function

    Public Async Function verDetalleReservaSinRemitarIdCliente(idCliente As Integer) As Task(Of List(Of PedidosDetalle))
        Try
            Dim list As New List(Of PedidosDetalle)

            For Each item In Await Transaccion.verRegistrosSinRemitar_idCliente(idCliente)
                list.Add(Drivers.DetalleReservas(item))
            Next

            Return list
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return Nothing
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return Nothing
        End Try
    End Function

    Public Async Function verDetalleReservaSinFacturarIdCliente(idCliente As Integer) As Task(Of List(Of PedidosDetalle))
        Try
            Dim list As New List(Of PedidosDetalle)

            For Each item In Await Transaccion.verRegistrosSinFacturar_idCliente(idCliente)
                list.Add(Drivers.DetalleReservas(item))
            Next

            Return list
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return Nothing
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return Nothing
        End Try
    End Function

    Public Async Function verDetalleReservaPorIdClienteYRemitado(id As Integer, remitado As String) As Task(Of List(Of PedidosDetalle))
        Try
            Dim list As New List(Of PedidosDetalle)

            For Each item In Await Transaccion.verRegistrosPorIdClienteYRemitado(New ModeloPedidoDetalle With {.AscPedidos = New ModeloPedidos With {.AscClientes = New ModeloCliente With {.IdCliente = id}}, .Remitado = remitado})
                list.Add(Drivers.DetalleReservas(item))
            Next

            Return list
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return Nothing
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return Nothing
        End Try
    End Function

    Public Async Function verDetalleReservaPorIdClienteYFacturado(id As Integer, facturado As String) As Task(Of List(Of PedidosDetalle))
        Try
            Dim list As New List(Of PedidosDetalle)

            For Each item In Await Transaccion.verRegistrosPorIdClienteYFacturado(New ModeloPedidoDetalle With {.AscPedidos = New ModeloPedidos With {.AscClientes = New ModeloCliente With {.IdCliente = id}}, .Facturado = facturado})
                list.Add(Drivers.DetalleReservas(item))
            Next

            Return list
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return Nothing
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return Nothing
        End Try
    End Function
#End Region

End Class
