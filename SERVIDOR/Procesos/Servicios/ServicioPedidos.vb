Imports AccesoDatos

Public Class ServicioPedidos
    Inherits EnlaceTransacciones(Of Transacciones)

    Private _Pedido As ModeloPedidos
    Private _DetallePedido As ModeloPedidoDetalle
    Private _Stock As ModeloStock
    Private _listaStock As List(Of ModeloStock)
    Private _listaDetallePedido As List(Of ModeloPedidoDetalle)
    Private _listaPedidosMovimientos As List(Of ModeloPedidoMovimientos)
    Private _Numeracion As ModeloNumeracion

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New Transacciones(), "SERVICIO")

        Pedido = New ModeloPedidos()
        DetallePedido = New ModeloPedidoDetalle()
        Stock = New ModeloStock()
        ListaStock = New List(Of ModeloStock)()
        ListaDetallePedido = New List(Of ModeloPedidoDetalle)()
        Numeracion = New ModeloNumeracion()
        ListaPedidosMovimientos = New List(Of ModeloPedidoMovimientos)()
    End Sub

    Public Sub New(pedido As ModeloPedidos, detallePedido As ModeloPedidoDetalle, stock As ModeloStock,
                   listaStock As List(Of ModeloStock), listaDetallePedido As List(Of ModeloPedidoDetalle),
                   numeracion As ModeloNumeracion, listaPedidosMovimientos As List(Of ModeloPedidoMovimientos))
        MyBase.New(New Transacciones(), "SERVICIO")

        Me.Pedido = pedido
        Me.DetallePedido = detallePedido
        Me.Stock = stock
        Me.ListaStock = listaStock
        Me.ListaDetallePedido = listaDetallePedido
        Me.Numeracion = numeracion
        Me.ListaPedidosMovimientos = listaPedidosMovimientos
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property Pedido As ModeloPedidos
        Get
            Return _Pedido
        End Get
        Set(value As ModeloPedidos)
            _Pedido = value
        End Set
    End Property

    Public Property DetallePedido As ModeloPedidoDetalle
        Get
            Return _DetallePedido
        End Get
        Set(value As ModeloPedidoDetalle)
            _DetallePedido = value
        End Set
    End Property

    Public Property Stock As ModeloStock
        Get
            Return _Stock
        End Get
        Set(value As ModeloStock)
            _Stock = value
        End Set
    End Property

    Public Property ListaStock As List(Of ModeloStock)
        Get
            Return _listaStock
        End Get
        Set(value As List(Of ModeloStock))
            _listaStock = value
        End Set
    End Property

    Public Property ListaDetallePedido As List(Of ModeloPedidoDetalle)
        Get
            Return _listaDetallePedido
        End Get
        Set(value As List(Of ModeloPedidoDetalle))
            _listaDetallePedido = value
        End Set
    End Property

    Public Property Numeracion As ModeloNumeracion
        Get
            Return _Numeracion
        End Get
        Set(value As ModeloNumeracion)
            _Numeracion = value
        End Set
    End Property

    Public Property ListaPedidosMovimientos As List(Of ModeloPedidoMovimientos)
        Get
            Return _listaPedidosMovimientos
        End Get
        Set(value As List(Of ModeloPedidoMovimientos))
            _listaPedidosMovimientos = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS"
    Public Function Insertar() As RespuestaHTTP(Of Boolean)
        Try
            BeginTransaction()

            If Not IsNothing(Pedido) Then
                If Pedido.Insertar() Then
                    Dim UltimoID As Integer = Pedido.UltimoId()

                    If Not IsNothing(UltimoID) Then
                        For i As Integer = 0 To ListaDetallePedido.Count - 1
                            If ListaStock.Item(i).Insertar() Then
                                Dim ultIdStk As Integer = ListaStock.Item(i).UltimoId()

                                If Not IsNothing(ultIdStk) Then
                                    ListaDetallePedido.Item(i).AscPedidos.IdPedidos = UltimoID

                                    If ListaDetallePedido.Item(i).Insertar() Then
                                        Dim ultIdDetPed As Integer = ListaDetallePedido.Item(i).UltimoId()

                                        If Not IsNothing(ultIdDetPed) Then
                                            ListaPedidosMovimientos.Item(i).AscStock.IdStock = ultIdStk
                                            ListaPedidosMovimientos.Item(i).AscPedidosDetalle.IdPedidosDetalle = ultIdDetPed

                                            If Not ListaPedidosMovimientos.Item(i).Insertar() Then
                                                Rollback()
                                                Return New RespuestaHTTP(Of Boolean)(Nothing, ListaPedidosMovimientos.Item(i).Err)
                                            End If
                                        Else
                                            Rollback()
                                            Return New RespuestaHTTP(Of Boolean)(Nothing, ListaDetallePedido.Item(i).Err)
                                        End If
                                    Else
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(Nothing, ListaDetallePedido.Item(i).Err)
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(Nothing, ListaStock.Item(i).Err)
                                End If
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of Boolean)(Nothing, ListaStock.Item(i).Err)
                            End If
                        Next

                        If Numeracion.ModificarNroReserva() Then
                            Commit()
                            Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                        Else
                            Rollback()
                            Return New RespuestaHTTP(Of Boolean)(False, Numeracion.Err)
                        End If
                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(Nothing, Pedido.Err)
                    End If
                Else
                    Rollback()
                    Return New RespuestaHTTP(Of Boolean)(Nothing, Pedido.Err)
                End If
            Else
                Rollback()
                Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = "Error en el servidor al recibir la informacion enviada por el cliente"})
            End If
        Catch ex As Exception
            If Transacciones.enTransaccion Then
                Rollback()
            End If

            Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message})
        End Try
    End Function

    Public Function Eliminar() As RespuestaHTTP(Of Boolean)
        Try
            Dim verificarNoEliminado As ModeloPedidos = Pedido.ConsultarPorId()

            If verificarNoEliminado.Err.Identificador = EnumErrores.OK Then
                BeginTransaction()

                Dim listaDetPedido As List(Of ModeloPedidoDetalle) = DetallePedido.ListadoPorIdPedidos()

                If Not IsNothing(listaDetPedido) Then
                    For Each item In listaDetPedido
                        Dim pedMov As New ModeloPedidoMovimientos With {.AscPedidosDetalle = New ModeloPedidoDetalle With {.IdPedidosDetalle = item.IdPedidosDetalle}, .Tipo = "RESERVA"}
                        Dim listaPedMov As List(Of ModeloPedidoMovimientos) = pedMov.ListadoPorIdPedidosDetalleTipo()

                        If Not IsNothing(listaPedMov) Then
                            For Each itemMov In listaPedMov
                                If itemMov.AscStock.Eliminar() Then
                                    If Not itemMov.Eliminar() Then
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(Nothing, itemMov.Err)
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(Nothing, itemMov.AscStock.Err)
                                End If
                            Next
                        Else
                            Rollback()
                            Return New RespuestaHTTP(Of Boolean)(Nothing, pedMov.Err)
                        End If
                    Next

                    If DetallePedido.EliminarPorIdPedido() Then
                        If Pedido.Eliminar() Then
                            Commit()
                            Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                        Else
                            Rollback()
                            Return New RespuestaHTTP(Of Boolean)(Nothing, Pedido.Err)
                        End If
                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(Nothing, DetallePedido.Err)
                    End If
                Else
                    Rollback()
                    Return New RespuestaHTTP(Of Boolean)(Nothing, DetallePedido.Err)
                End If

            ElseIf verificarNoEliminado.Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO Then
                Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.OPERACION_SIMULTANEA_TERMINANTE, .Descripcion = "El Pedido que intentas eliminar ya fue eliminada por otro usuario."})
            Else
                Return New RespuestaHTTP(Of Boolean)(Nothing, verificarNoEliminado.Err)
            End If
        Catch ex As Exception
            If Transacciones.enTransaccion Then
                Rollback()
            End If

            Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message})
        End Try
    End Function

    Public Function Modificar() As RespuestaHTTP(Of Boolean)
        Try
            Dim verificarNoEliminado As ModeloPedidos = Pedido.ConsultarPorId()

            If verificarNoEliminado.Err.Identificador = EnumErrores.OK Then
                BeginTransaction()

                Dim listaDetPedido As List(Of ModeloPedidoDetalle) = ListaDetallePedido.First.ListadoPorIdPedidos()

                If Not IsNothing(listaDetPedido) Then
                    For Each item In listaDetPedido
                        Dim pedMov As New ModeloPedidoMovimientos With {.AscPedidosDetalle = New ModeloPedidoDetalle With {.IdPedidosDetalle = item.IdPedidosDetalle}, .Tipo = "RESERVA"}
                        Dim listaPedMov As List(Of ModeloPedidoMovimientos) = pedMov.ListadoPorIdPedidosDetalleTipo()

                        If Not IsNothing(listaPedMov) Then
                            For Each itemMov In listaPedMov
                                If itemMov.AscStock.Eliminar() Then
                                    If Not itemMov.Eliminar() Then
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(Nothing, itemMov.Err)
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(Nothing, itemMov.AscStock.Err)
                                End If
                            Next
                        Else
                            Rollback()
                            Return New RespuestaHTTP(Of Boolean)(Nothing, pedMov.Err)
                        End If
                    Next

                    If ListaDetallePedido.First.EliminarPorIdPedido() Then
                        If Pedido.Modificar() Then
                            For i As Integer = 0 To ListaDetallePedido.Count - 1
                                If ListaStock.Item(i).Insertar() Then
                                    Dim ultIdStk As Integer = ListaStock.Item(i).UltimoId()

                                    If Not IsNothing(ultIdStk) Then
                                        If ListaDetallePedido.Item(i).Insertar() Then
                                            Dim ultIdDetPed As Integer = ListaDetallePedido.Item(i).UltimoId()

                                            If Not IsNothing(ultIdDetPed) Then
                                                ListaPedidosMovimientos.Item(i).AscStock.IdStock = ultIdStk
                                                ListaPedidosMovimientos.Item(i).AscPedidosDetalle.IdPedidosDetalle = ultIdDetPed

                                                If Not ListaPedidosMovimientos.Item(i).Insertar() Then
                                                    Rollback()
                                                    Return New RespuestaHTTP(Of Boolean)(Nothing, ListaPedidosMovimientos.Item(i).Err)
                                                End If
                                            Else
                                                Rollback()
                                                Return New RespuestaHTTP(Of Boolean)(Nothing, ListaDetallePedido.Item(i).Err)
                                            End If
                                        Else
                                            Rollback()
                                            Return New RespuestaHTTP(Of Boolean)(Nothing, ListaDetallePedido.Item(i).Err)
                                        End If
                                    Else
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(Nothing, ListaStock.Item(i).Err)
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(Nothing, ListaStock.Item(i).Err)
                                End If
                            Next

                            Commit()
                            Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                        Else
                            Rollback()
                            Return New RespuestaHTTP(Of Boolean)(Nothing, Pedido.Err)
                        End If
                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(Nothing, ListaDetallePedido.First.Err)
                    End If
                Else
                    Rollback()
                    Return New RespuestaHTTP(Of Boolean)(Nothing, ListaDetallePedido.First.Err)
                End If

            ElseIf verificarNoEliminado.Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO Then
                Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.OPERACION_SIMULTANEA_TERMINANTE, .Descripcion = "El remito que intentas modificar ya fue eliminada por otro usuario."})
            Else
                Return New RespuestaHTTP(Of Boolean)(Nothing, verificarNoEliminado.Err)
            End If
        Catch ex As Exception
            If Transacciones.enTransaccion Then
                Rollback()
            End If

            Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message})
        End Try
    End Function

    Public Function ListadoModElim() As RespuestaHTTP(Of List(Of ModeloPedidos))
        Pedido.Remitado = "NO"
        Pedido.Facturado = "NO"

        Dim listaPedidos As List(Of ModeloPedidos) = Pedido.ListadoFiltradoPorFacturadoYRemitado()

        If Not IsNothing(listaPedidos) Then
            Dim items As Integer = listaPedidos.Count - 1

            If items + 1 > 0 Then
                For j As Integer = items To 0 Step -1
                    Dim quitar As Boolean = False

                    DetallePedido.AscPedidos.IdPedidos = listaPedidos.Item(j).IdPedidos

                    Dim listaDetallePedido As List(Of ModeloPedidoDetalle) = DetallePedido.ListadoPorIdPedidos()

                    If Not IsNothing(listaDetallePedido) Then
                        For Each Det In listaDetallePedido
                            Dim pedMov As New ModeloPedidoMovimientos With {.AscPedidosDetalle = New ModeloPedidoDetalle With {.IdPedidosDetalle = Det.IdPedidosDetalle}}

                            Dim cantidadRetirada As Double = pedMov.CantidadRetirada()

                            If Not IsNothing(cantidadRetirada) Then
                                If cantidadRetirada <> 0 Then
                                    quitar = True
                                End If
                            Else
                                Return New RespuestaHTTP(Of List(Of ModeloPedidos))(Nothing, pedMov.Err)
                            End If

                            Dim cantidadAnulada As Double = pedMov.CantidadAnulada()

                            If Not IsNothing(cantidadAnulada) Then
                                If cantidadAnulada <> 0 Then
                                    quitar = True
                                End If
                            Else
                                Return New RespuestaHTTP(Of List(Of ModeloPedidos))(Nothing, pedMov.Err)
                            End If

                            If Det.Remitado <> "NO" Then
                                quitar = True
                            End If

                            If Det.Facturado <> "NO" Then
                                quitar = True
                            End If
                        Next

                        If quitar Then
                            listaPedidos.Remove(listaPedidos(j))
                        End If
                    Else
                        Return New RespuestaHTTP(Of List(Of ModeloPedidos))(Nothing, DetallePedido.Err)
                    End If
                Next

                If listaPedidos.Count > 0 Then
                    Return New RespuestaHTTP(Of List(Of ModeloPedidos))(listaPedidos, Nothing)
                Else
                    Return New RespuestaHTTP(Of List(Of ModeloPedidos))(Nothing, New Errores With {.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO, .Descripcion = "No hay Pedidos habilitados para ser Modificados o Eliminados"})
                End If
            Else
                Return New RespuestaHTTP(Of List(Of ModeloPedidos))(Nothing, New Errores With {.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO, .Descripcion = "No hay Pedidos habilitados para ser Modificados o Eliminados"})
            End If
        Else
            If Pedido.Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO Then
                Pedido.Err.Descripcion = "No hay Pedidos habilitados para ser Modificados o Eliminados"
            End If

            Return New RespuestaHTTP(Of List(Of ModeloPedidos))(Nothing, Pedido.Err)
        End If
    End Function

    Public Function ListadoSinCompletar() As RespuestaHTTP(Of List(Of ModeloPedidos))
        Pedido.Remitado = "NO"

        Dim listaPedidos As List(Of ModeloPedidos) = Pedido.ListadoFiltradoPorRemitado()

        If Not IsNothing(listaPedidos) Then
            Dim items As Integer = listaPedidos.Count - 1

            If items + 1 > 0 Then
                For j As Integer = items To 0 Step -1
                    DetallePedido.AscPedidos.IdPedidos = listaPedidos.Item(j).IdPedidos
                    Dim listaDetallePedido As List(Of ModeloPedidoDetalle) = DetallePedido.ListadoPorIdPedidos()

                    If Not IsNothing(listaDetallePedido) Then
                        For Each Det In listaDetallePedido
                            Dim quitar As Boolean = False
                            Dim pedMov As New ModeloPedidoMovimientos With {.AscPedidosDetalle = New ModeloPedidoDetalle With {.IdPedidosDetalle = Det.IdPedidosDetalle}}

                            Dim cantidadRetirada As Integer = pedMov.CantidadRetirada()

                            If Not IsNothing(cantidadRetirada) Then
                                If cantidadRetirada = Det.Cantidad Then
                                    quitar = True
                                Else
                                    Dim cantidadAnulada As Integer = pedMov.CantidadAnulada()

                                    If Not IsNothing(cantidadAnulada) Then
                                        If cantidadAnulada = Det.Cantidad Then
                                            quitar = True
                                        End If

                                        If cantidadAnulada + cantidadRetirada = Det.Cantidad Then
                                            quitar = True
                                        End If
                                    Else
                                        Return New RespuestaHTTP(Of List(Of ModeloPedidos))(Nothing, pedMov.Err)
                                    End If
                                End If
                            Else
                                Return New RespuestaHTTP(Of List(Of ModeloPedidos))(Nothing, pedMov.Err)
                            End If

                            If quitar Then
                                listaPedidos.RemoveAt(j)
                            End If
                        Next
                    Else
                        Return New RespuestaHTTP(Of List(Of ModeloPedidos))(Nothing, DetallePedido.Err)
                    End If
                Next

                Return New RespuestaHTTP(Of List(Of ModeloPedidos))(listaPedidos, Nothing)
            Else
                Return New RespuestaHTTP(Of List(Of ModeloPedidos))(Nothing, New Errores With {.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO, .Descripcion = "No hay Pedidos pendientes de ser completados"})
            End If
        Else
            Return New RespuestaHTTP(Of List(Of ModeloPedidos))(Nothing, Pedido.Err)
        End If
    End Function
#End Region

End Class
