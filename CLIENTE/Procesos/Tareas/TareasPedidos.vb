Imports Comunicacion

Public Class TareasPedidos
    Inherits EnlaceTransacciones(Of TransaccionesPedidos)

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
    Public Async Function Servicio_Insertar(_Pedido As Pedidos, _Numeracion As Numeracion, _Stock As List(Of Stock), _DetallePedido As List(Of PedidosDetalle), _PedidosMovimientos As List(Of PedidosMovimientos)) As Task(Of Boolean)
        Try
            Dim listaStk As New List(Of ModeloStock)
            Dim listaDetallePed As New List(Of ModeloPedidoDetalle)
            Dim listaPedMov As New List(Of ModeloPedidoMovimientos)

            For Each item In _Stock
                listaStk.Add(Drivers.Stock(item))
            Next

            For Each item In _DetallePedido
                listaDetallePed.Add(Drivers.DetalleReservas(item))
            Next

            For Each item In _PedidosMovimientos
                listaPedMov.Add(Drivers.PedidosMovimientos(item))
            Next

            Await Transaccion.Servicio_insRegistro(New ServicioPedidos With {
                                                        .Pedido = Drivers.Reservas(_Pedido),
                                                        .listaStock = listaStk,
                                                        .listaDetallePedido = listaDetallePed,
                                                        .numeracion = Drivers.Numeracion(_Numeracion),
                                                        .listaPedidosMovimientos = listaPedMov
                                                   })

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

    Public Async Function Servicio_Modificar(_Pedido As Pedidos, _Stock As List(Of Stock), _DetallePedido As List(Of PedidosDetalle), _pedidoMovimiento As List(Of PedidosMovimientos)) As Task(Of Boolean)
        Try
            Dim listaStk As New List(Of ModeloStock)
            Dim listaDetallePed As New List(Of ModeloPedidoDetalle)
            Dim listaPedMov As New List(Of ModeloPedidoMovimientos)

            For Each item In _Stock
                listaStk.Add(Drivers.Stock(item))
            Next

            For Each item In _DetallePedido
                listaDetallePed.Add(Drivers.DetalleReservas(item))
            Next

            For Each item In _pedidoMovimiento
                listaPedMov.Add(Drivers.PedidosMovimientos(item))
            Next

            Await Transaccion.Servicio_modRegistro(New ServicioPedidos With {
                                                        .Pedido = Drivers.Reservas(_Pedido),
                                                        .listaStock = listaStk,
                                                        .listaDetallePedido = listaDetallePed,
                                                        .listaPedidosMovimientos = listaPedMov
                                                   })
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

    Public Async Function Servicio_Eliminar(_Pedido As Pedidos, _DetallePedido As PedidosDetalle) As Task(Of Boolean)
        Try
            Await Transaccion.Servicio_elimRegistro(New ServicioPedidos With {
                                                        .Pedido = Drivers.Reservas(_Pedido),
                                                        .DetallePedido = Drivers.DetalleReservas(_DetallePedido)
                                                   })

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

    Public Async Function Insertar(_Res As Pedidos) As Task(Of Boolean)
        Try
            Await Transaccion.insRegistro(Drivers.Reservas(_Res))

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

    Public Async Function Modificar(_Res As Pedidos) As Task(Of Boolean)
        Try
            Await Transaccion.modRegistro(Drivers.Reservas(_Res))

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

    Public Async Function ListadoCompleto() As Task(Of List(Of Pedidos))
        Try
            Dim list As New List(Of Pedidos)

            For Each item In Await Transaccion.verRegistros()
                list.Add(Drivers.Reservas(item))
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

    Public Async Function ListadoModElim() As Task(Of List(Of Pedidos))
        Try
            Dim list As New List(Of Pedidos)

            For Each item In Await Transaccion.verRegistrosModElim()
                list.Add(Drivers.Reservas(item))
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

    Public Async Function ListadoSinCompletar() As Task(Of List(Of Pedidos))
        Try
            Dim list As New List(Of Pedidos)

            For Each item In Await Transaccion.verRegistrosSinCompletar()
                list.Add(Drivers.Reservas(item))
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

    Public Async Function UltimoID() As Task(Of Integer)
        Try
            Return Await Transaccion.verUltimoId
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

#Region "METODOS PUBLICOS UTILIDADES"
    Public Shared Sub LlenarDGV(ByRef DGV As Windows.Forms.DataGridView, _listReservas As List(Of Pedidos))
        For Each Item In _listReservas
            DGV.Rows.Add(Item.IdPedidos, Item.AscClientes.IdCliente, Item.AscUsuarios.IdUsuario, Format(CDate(Item.Fecha), "dd/MM/yyyy"), Item.NroPedido, Item.AscClientes.RazonSocial, Item.Observaciones)
        Next
    End Sub
#End Region

End Class
