Imports AccesoDatos

Public Class ServicioRemitoVenta
    Inherits EnlaceTransacciones(Of Transacciones)

    Private _RemitoVenta As ModeloRemitosVenta
    Private _RemitoVentaMonedas As ModeloRemitosVentaMonedas
    Private _Numeracion As ModeloNumeracion
    Private _DetallesRemitosVenta As List(Of ModeloDetalleRemitoVenta)
    Private _Movimientos_Remito_Factura As List(Of ModeloMovimientos_Remito_Factura)
    Private _Movimientos_Reserva_Remito As List(Of ModeloMovimientos_Reserva_Remito)
    Private _RemitosVentaMovimientos As List(Of ModeloRemitosVentaMovimientos)
    Private _PedidosMovimientos As List(Of ModeloPedidoMovimientos)
    Private _FacturaVentaMovimientos As List(Of ModeloFacturaVentaMovimientos)

#Region "CONSTRUCTORES"
    Public Sub New(remitoVenta As ModeloRemitosVenta, remtioVentaMonedas As ModeloRemitosVentaMonedas, numeracion As ModeloNumeracion,
                   detallesRemitosVenta As List(Of ModeloDetalleRemitoVenta), movimientos_Remito_Factura As List(Of ModeloMovimientos_Remito_Factura),
                   remitosVentaMovimientos As List(Of ModeloRemitosVentaMovimientos), pedidosMovimientos As List(Of ModeloPedidoMovimientos), movimientos_Reserva_Remito As List(Of ModeloMovimientos_Reserva_Remito), facturaVentaMovimientos As List(Of ModeloFacturaVentaMovimientos))
        MyBase.New(New Transacciones(), "-")

        Me.RemitoVenta = remitoVenta
        Me.RemitoVentaMonedas = remtioVentaMonedas
        Me.Numeracion = numeracion
        Me.DetallesRemitosVenta = detallesRemitosVenta
        Me.Movimientos_Remito_Factura = movimientos_Remito_Factura
        Me.RemitosVentaMovimientos = remitosVentaMovimientos
        Me.PedidosMovimientos = pedidosMovimientos
        Me.Movimientos_Reserva_Remito = movimientos_Reserva_Remito
        Me.FacturaVentaMovimientos = facturaVentaMovimientos
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property RemitoVenta As ModeloRemitosVenta
        Get
            Return _RemitoVenta
        End Get
        Set(value As ModeloRemitosVenta)
            _RemitoVenta = value
        End Set
    End Property

    Public Property RemitoVentaMonedas As ModeloRemitosVentaMonedas
        Get
            Return _RemitoVentaMonedas
        End Get
        Set(value As ModeloRemitosVentaMonedas)
            _RemitoVentaMonedas = value
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

    Public Property DetallesRemitosVenta As List(Of ModeloDetalleRemitoVenta)
        Get
            Return _DetallesRemitosVenta
        End Get
        Set(value As List(Of ModeloDetalleRemitoVenta))
            _DetallesRemitosVenta = value
        End Set
    End Property

    Public Property Movimientos_Remito_Factura As List(Of ModeloMovimientos_Remito_Factura)
        Get
            Return _Movimientos_Remito_Factura
        End Get
        Set(value As List(Of ModeloMovimientos_Remito_Factura))
            _Movimientos_Remito_Factura = value
        End Set
    End Property

    Public Property RemitosVentaMovimientos As List(Of ModeloRemitosVentaMovimientos)
        Get
            Return _RemitosVentaMovimientos
        End Get
        Set(value As List(Of ModeloRemitosVentaMovimientos))
            _RemitosVentaMovimientos = value
        End Set
    End Property

    Public Property PedidosMovimientos As List(Of ModeloPedidoMovimientos)
        Get
            Return _PedidosMovimientos
        End Get
        Set(value As List(Of ModeloPedidoMovimientos))
            _PedidosMovimientos = value
        End Set
    End Property

    Public Property Movimientos_Reserva_Remito As List(Of ModeloMovimientos_Reserva_Remito)
        Get
            Return _Movimientos_Reserva_Remito
        End Get
        Set(value As List(Of ModeloMovimientos_Reserva_Remito))
            _Movimientos_Reserva_Remito = value
        End Set
    End Property

    Public Property FacturaVentaMovimientos As List(Of ModeloFacturaVentaMovimientos)
        Get
            Return _FacturaVentaMovimientos
        End Get
        Set(value As List(Of ModeloFacturaVentaMovimientos))
            _FacturaVentaMovimientos = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS"
    Public Function Insertar() As RespuestaHTTP(Of Boolean)
        Try
            For Each item In RemitosVentaMovimientos
                Dim stk As Integer = item.AscStock.CantidadStockFisicoPorIdArticulo()

                If Not IsNothing(stk) Then
                    If stk < item.Cantidad Then
                        Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.OPERACION_SIMULTANEA_NO_TERMINANTE, .Descripcion = "No hay suficiente Stock del articulo " + item.AscStock.AscArticulos.Detalle + " la cantidad en disponible es de " + stk + "."})
                    End If
                Else
                    Return New RespuestaHTTP(Of Boolean)(False, item.AscStock.Err)
                End If
            Next

            BeginTransaction()

            If RemitoVenta.Insertar() Then
                Dim RemVtaUltId As Integer = RemitoVenta.UltimoId()

                If Not IsNothing(RemVtaUltId) Then
                    RemitoVentaMonedas.AscRemitosventa.IdRemitosVenta = RemVtaUltId

                    If RemitoVentaMonedas.Insertar() Then
                        For i As Integer = 0 To DetallesRemitosVenta.Count - 1
                            DetallesRemitosVenta(i).AscRemitosVenta.IdRemitosVenta = RemVtaUltId

                            If DetallesRemitosVenta(i).Insertar() Then
                                RemitosVentaMovimientos(i).AscStock.Movimiento = "EGRESO"

                                If RemitosVentaMovimientos(i).AscStock.Insertar() Then
                                    Dim DetRemVtaUltId As Integer = DetallesRemitosVenta(i).UltimoId()

                                    If Not IsNothing(DetRemVtaUltId) Then
                                        Dim StkUltId As Integer = RemitosVentaMovimientos(i).AscStock.UltimoId()

                                        If Not IsNothing(StkUltId) Then
                                            RemitosVentaMovimientos(i).AscDetalleRemitoVenta.IdDetalleRemitosVenta = DetRemVtaUltId
                                            RemitosVentaMovimientos(i).AscStock.IdStock = StkUltId

                                            If RemitosVentaMovimientos(i).Insertar() Then
                                                Dim RemVtaMovUltId As Integer = RemitosVentaMovimientos(i).UltimoId()

                                                If Not IsNothing(RemVtaMovUltId) Then
                                                    If PedidosMovimientos(i).AscPedidosDetalle.IdPedidosDetalle <> 0 Then
                                                        RemitosVentaMovimientos(i).AscStock.AscDepositos.IdDeposito = 1
                                                        RemitosVentaMovimientos(i).AscStock.Movimiento = "RESERVA"

                                                        If RemitosVentaMovimientos(i).AscStock.Insertar() Then
                                                            StkUltId = RemitosVentaMovimientos(i).AscStock.UltimoId()

                                                            If Not IsNothing(StkUltId) Then
                                                                PedidosMovimientos(i).AscStock.IdStock = StkUltId

                                                                If PedidosMovimientos(i).Insertar() Then
                                                                    Dim pedMovUltId As Integer = PedidosMovimientos(i).UltimoId()

                                                                    If Not IsNothing(pedMovUltId) Then
                                                                        Movimientos_Reserva_Remito(i).AscRemitosVentaMovimientos.IdRemitosVentasMovimientos = RemVtaMovUltId
                                                                        Movimientos_Reserva_Remito(i).AscPedidosMovimientos.IdPedidosMovimientos = pedMovUltId

                                                                        If Movimientos_Reserva_Remito(i).Insertar() Then
                                                                            Dim pedCantAnu As Double = PedidosMovimientos(i).CantidadAnulada()

                                                                            If Not IsNothing(pedCantAnu) Then
                                                                                Movimientos_Reserva_Remito(i).AscPedidosMovimientos = PedidosMovimientos(i)

                                                                                Dim pedCantRet As Double = PedidosMovimientos(i).CantidadRetirada()

                                                                                If Not IsNothing(pedCantRet) Then
                                                                                    Dim pedCantRes As Double = PedidosMovimientos(i).CantidadReservada()

                                                                                    If Not IsNothing(pedCantRes) Then
                                                                                        If pedCantRes = pedCantRet + pedCantAnu Then
                                                                                            PedidosMovimientos(i).AscPedidosDetalle.Remitado = "SI"

                                                                                            If PedidosMovimientos(i).AscPedidosDetalle.ModificarEstadoRemitado() Then
                                                                                                Dim detallePedido As List(Of ModeloPedidoDetalle) = PedidosMovimientos(i).AscPedidosDetalle.ListadoPorIdPedidos()

                                                                                                If Not IsNothing(detallePedido) Then
                                                                                                    Dim Remitado As Boolean = True

                                                                                                    For Each item In detallePedido
                                                                                                        If item.IdPedidosDetalle = Movimientos_Reserva_Remito(i).AscPedidosMovimientos.AscPedidosDetalle.IdPedidosDetalle Then
                                                                                                            If item.Facturado = "SI" Then
                                                                                                                Movimientos_Reserva_Remito(i).AscRemitosVentaMovimientos.AscDetalleRemitoVenta.IdDetalleRemitosVenta = DetRemVtaUltId
                                                                                                                Movimientos_Reserva_Remito(i).AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Facturado = "SI"

                                                                                                                If Not Movimientos_Reserva_Remito(i).AscRemitosVentaMovimientos.AscDetalleRemitoVenta.ModificarFacturacion() Then
                                                                                                                    Rollback()
                                                                                                                    Return New RespuestaHTTP(Of Boolean)(False, Movimientos_Reserva_Remito(i).AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Err)
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If

                                                                                                        If item.Remitado = "NO" Then
                                                                                                            Remitado = False
                                                                                                        End If
                                                                                                    Next

                                                                                                    If Remitado Then
                                                                                                        PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.FechaCierrePedido = Date.Now.Date

                                                                                                        If PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.ModificarFechaCierrePedido() Then
                                                                                                            PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.Remitado = "SI"

                                                                                                            If Not PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.ModificarEstadoRemitado() Then
                                                                                                                Rollback()
                                                                                                                Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.Err)
                                                                                                            End If
                                                                                                        Else
                                                                                                            Rollback()
                                                                                                            Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.Err)
                                                                                                        End If
                                                                                                    End If
                                                                                                Else
                                                                                                    Rollback()
                                                                                                    Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).AscPedidosDetalle.Err)
                                                                                                End If
                                                                                            Else
                                                                                                Rollback()
                                                                                                Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).AscPedidosDetalle.Err)
                                                                                            End If
                                                                                        End If
                                                                                    Else
                                                                                        Rollback()
                                                                                        Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).Err)
                                                                                    End If
                                                                                Else
                                                                                    Rollback()
                                                                                    Return New RespuestaHTTP(Of Boolean)(False, Movimientos_Reserva_Remito(i).Err)
                                                                                End If
                                                                            Else
                                                                                Rollback()
                                                                                Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).Err)
                                                                            End If
                                                                        Else
                                                                            Rollback()
                                                                            Return New RespuestaHTTP(Of Boolean)(False, Movimientos_Reserva_Remito(i).Err)
                                                                        End If
                                                                    Else
                                                                        Rollback()
                                                                        Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).Err)
                                                                    End If
                                                                Else
                                                                    Rollback()
                                                                    Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).Err)
                                                                End If
                                                            Else
                                                                Rollback()
                                                                Return New RespuestaHTTP(Of Boolean)(False, RemitosVentaMovimientos(i).AscStock.Err)
                                                            End If
                                                        Else
                                                            Rollback()
                                                            Return New RespuestaHTTP(Of Boolean)(False, RemitosVentaMovimientos(i).AscStock.Err)
                                                        End If
                                                    ElseIf FacturaVentaMovimientos(i).AscFacturaVentaDetalle.IdFacturaVentaDetalle <> 0 Then
                                                        If FacturaVentaMovimientos(i).Insertar() Then
                                                            Dim facVtaMov As Integer = FacturaVentaMovimientos(i).UltimoId()

                                                            If Not IsNothing(facVtaMov) Then
                                                                Movimientos_Remito_Factura(i).AscRemitosVentaMovimientos.IdRemitosVentasMovimientos = RemVtaMovUltId
                                                                Movimientos_Remito_Factura(i).AscFacturaVentaMovimientos.IdFacturaVentaMovimientos = facVtaMov

                                                                If Movimientos_Remito_Factura(i).Insertar() Then
                                                                    RemitosVentaMovimientos(i).AscDetalleRemitoVenta.Facturado = "SI"

                                                                    If RemitosVentaMovimientos(i).AscDetalleRemitoVenta.ModificarFacturacion() Then
                                                                        Dim movFacRes As New ModeloMovimientos_Factura_Reserva With {.AscFacturaVentaMovimientos = FacturaVentaMovimientos(i)}
                                                                        Dim listMovFacRes As List(Of ModeloMovimientos_Factura_Reserva) = movFacRes.ListasdoPorIdDetalleRemitosVenta()

                                                                        If Not IsNothing(listMovFacRes) Then
                                                                            For Each item In listMovFacRes
                                                                                RemitosVentaMovimientos(i).AscStock.AscDepositos.IdDeposito = 1
                                                                                RemitosVentaMovimientos(i).AscStock.Movimiento = "RESERVA"

                                                                                If RemitosVentaMovimientos(i).AscStock.Insertar() Then
                                                                                    StkUltId = RemitosVentaMovimientos(i).AscStock.UltimoId()

                                                                                    If Not IsNothing(StkUltId) Then
                                                                                        PedidosMovimientos(i).AscPedidosDetalle.IdPedidosDetalle = item.AscPedidoMovimientos.AscPedidosDetalle.IdPedidosDetalle
                                                                                        PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.IdPedidos = item.AscPedidoMovimientos.AscPedidosDetalle.AscPedidos.IdPedidos
                                                                                        PedidosMovimientos(i).AscStock.IdStock = StkUltId

                                                                                        If PedidosMovimientos(i).Insertar() Then
                                                                                            Dim pedMovUltId As Integer = PedidosMovimientos(i).UltimoId()

                                                                                            If Not IsNothing(pedMovUltId) Then
                                                                                                item.AscPedidoMovimientos.IdPedidosMovimientos = pedMovUltId
                                                                                                item.AscFacturaVentaMovimientos.IdFacturaVentaMovimientos = facVtaMov
                                                                                                item.Fecha = Date.Now.Date
                                                                                                item.Tipo = "REMITADO"
                                                                                                item.Cantidad = PedidosMovimientos(i).Cantidad
                                                                                                item.Eliminado = "NO"

                                                                                                If item.Insertar() Then
                                                                                                    Movimientos_Reserva_Remito(i).AscRemitosVentaMovimientos.IdRemitosVentasMovimientos = RemVtaMovUltId
                                                                                                    Movimientos_Reserva_Remito(i).AscPedidosMovimientos.IdPedidosMovimientos = pedMovUltId

                                                                                                    If Movimientos_Reserva_Remito(i).Insertar() Then
                                                                                                        Dim pedCantAnu As Double = PedidosMovimientos(i).CantidadAnulada()

                                                                                                        If Not IsNothing(pedCantAnu) Then
                                                                                                            Dim pedCantRet As Double = PedidosMovimientos(i).CantidadRetirada()

                                                                                                            If Not IsNothing(pedCantRet) Then
                                                                                                                Dim pedCanRes As Double = PedidosMovimientos(i).CantidadReservada()

                                                                                                                If Not IsNothing(pedCanRes) Then
                                                                                                                    If pedCanRes = pedCantRet + pedCantAnu Then
                                                                                                                        PedidosMovimientos(i).AscPedidosDetalle.Remitado = "SI"

                                                                                                                        If PedidosMovimientos(i).AscPedidosDetalle.ModificarEstadoRemitado() Then
                                                                                                                            Dim detallePedido As List(Of ModeloPedidoDetalle) = PedidosMovimientos(i).AscPedidosDetalle.ListadoPorIdPedidos()

                                                                                                                            If Not IsNothing(detallePedido) Then
                                                                                                                                Dim Remitado As Boolean = True

                                                                                                                                For Each detPed In detallePedido
                                                                                                                                    If detPed.IdPedidosDetalle = item.AscPedidoMovimientos.AscPedidosDetalle.IdPedidosDetalle Then
                                                                                                                                        If detPed.Facturado = "SI" Then
                                                                                                                                            Movimientos_Reserva_Remito(i).AscRemitosVentaMovimientos.AscDetalleRemitoVenta.IdDetalleRemitosVenta = DetRemVtaUltId
                                                                                                                                            Movimientos_Reserva_Remito(i).AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Facturado = "SI"

                                                                                                                                            If Not Movimientos_Reserva_Remito(i).AscRemitosVentaMovimientos.AscDetalleRemitoVenta.ModificarFacturacion() Then
                                                                                                                                                Rollback()
                                                                                                                                                Return New RespuestaHTTP(Of Boolean)(False, Movimientos_Reserva_Remito(i).AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Err)
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If

                                                                                                                                    If detPed.Remitado = "NO" Then
                                                                                                                                        Remitado = False
                                                                                                                                    End If
                                                                                                                                Next

                                                                                                                                If Remitado Then
                                                                                                                                    PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.FechaCierrePedido = Date.Now.Date

                                                                                                                                    If PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.ModificarFechaCierrePedido() Then
                                                                                                                                        PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.Remitado = "SI"

                                                                                                                                        If Not PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.ModificarEstadoRemitado() Then
                                                                                                                                            Rollback()
                                                                                                                                            Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.Err)
                                                                                                                                        End If
                                                                                                                                    Else
                                                                                                                                        Rollback()
                                                                                                                                        Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.Err)
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            Else
                                                                                                                                Rollback()
                                                                                                                                Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).AscPedidosDetalle.Err)
                                                                                                                            End If
                                                                                                                        Else
                                                                                                                            Rollback()
                                                                                                                            Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).AscPedidosDetalle.Err)
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                Else
                                                                                                                    Rollback()
                                                                                                                    Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).Err)
                                                                                                                End If
                                                                                                            Else
                                                                                                                Rollback()
                                                                                                                Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).Err)
                                                                                                            End If
                                                                                                        Else
                                                                                                            Rollback()
                                                                                                            Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).Err)
                                                                                                        End If
                                                                                                    Else
                                                                                                        Rollback()
                                                                                                        Return New RespuestaHTTP(Of Boolean)(False, Movimientos_Reserva_Remito(i).Err)
                                                                                                    End If
                                                                                                Else
                                                                                                    Rollback()
                                                                                                    Return New RespuestaHTTP(Of Boolean)(False, item.Err)
                                                                                                End If
                                                                                            Else
                                                                                                Rollback()
                                                                                                Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).Err)
                                                                                            End If
                                                                                        End If
                                                                                    Else
                                                                                        Rollback()
                                                                                        Return New RespuestaHTTP(Of Boolean)(False, RemitosVentaMovimientos(i).AscStock.Err)
                                                                                    End If
                                                                                Else
                                                                                    Rollback()
                                                                                    Return New RespuestaHTTP(Of Boolean)(False, RemitosVentaMovimientos(i).AscStock.Err)
                                                                                End If
                                                                            Next
                                                                        ElseIf movFacRes.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                                                                            Rollback()
                                                                            Return New RespuestaHTTP(Of Boolean)(False, movFacRes.Err)
                                                                        End If

                                                                        Dim facCanRem As Double = FacturaVentaMovimientos(i).CantidadRemitada()

                                                                        If Not IsNothing(facCanRem) Then
                                                                            Dim facCanFac As Double = FacturaVentaMovimientos(i).CantidadFacturada()

                                                                            If Not IsNothing(facCanFac) Then
                                                                                Dim facCanAnu As Double = FacturaVentaMovimientos(i).CantidadAnulada()

                                                                                If Not IsNothing(facCanAnu) Then
                                                                                    If facCanRem + facCanAnu = facCanFac Then
                                                                                        FacturaVentaMovimientos(i).AscFacturaVentaDetalle.Remitado = "SI"

                                                                                        If FacturaVentaMovimientos(i).AscFacturaVentaDetalle.ModificarRemitado() Then
                                                                                            Dim detalleFactura As List(Of ModeloFacturaVentaDetalle) = FacturaVentaMovimientos(i).AscFacturaVentaDetalle.ListadoPorIdFacturaVenta()

                                                                                            If Not IsNothing(detalleFactura) Then
                                                                                                Dim Remitado As Boolean = True

                                                                                                For Each item In detalleFactura
                                                                                                    'If item.IdFacturaVentaDetalle = Movimientos_Remito_Factura(i).AscFacturaVentaMovimientos.AscFacturaVentaDetalle.IdFacturaVentaDetalle Then
                                                                                                    '    If item.Remitado = "SI" Then
                                                                                                    '        Movimientos_Remito_Factura(i).AscRemitosVentaMovimientos.AscDetalleRemitoVenta.IdDetalleRemitosVenta = DetRemVtaUltId
                                                                                                    '        Movimientos_Remito_Factura(i).AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Facturado = "SI"

                                                                                                    '        If Not Movimientos_Remito_Factura(i).AscRemitosVentaMovimientos.AscDetalleRemitoVenta.ModificarFacturacion() Then
                                                                                                    '            Rollback()
                                                                                                    '            Return New RespuestaHTTP(Of Boolean)(False, Movimientos_Remito_Factura(i).AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Err)
                                                                                                    '        End If
                                                                                                    '    End If
                                                                                                    'End If

                                                                                                    If item.Remitado = "NO" Then
                                                                                                        Remitado = False
                                                                                                        Exit For
                                                                                                    End If
                                                                                                Next

                                                                                                If Remitado Then
                                                                                                    FacturaVentaMovimientos(i).AscFacturaVentaDetalle.AscFacturaVenta.Remitado = "SI"

                                                                                                    If Not FacturaVentaMovimientos(i).AscFacturaVentaDetalle.AscFacturaVenta.ModificarEstadoRemitado() Then
                                                                                                        Rollback()
                                                                                                        Return New RespuestaHTTP(Of Boolean)(False, FacturaVentaMovimientos(i).AscFacturaVentaDetalle.AscFacturaVenta.Err)
                                                                                                    End If
                                                                                                End If
                                                                                            Else
                                                                                                Rollback()
                                                                                                Return New RespuestaHTTP(Of Boolean)(False, FacturaVentaMovimientos(i).AscFacturaVentaDetalle.Err)
                                                                                            End If
                                                                                        Else
                                                                                            Rollback()
                                                                                            Return New RespuestaHTTP(Of Boolean)(False, FacturaVentaMovimientos(i).AscFacturaVentaDetalle.Err)
                                                                                        End If
                                                                                    End If
                                                                                Else
                                                                                    Rollback()
                                                                                    Return New RespuestaHTTP(Of Boolean)(False, FacturaVentaMovimientos(i).AscFacturaVentaDetalle.Err)
                                                                                End If
                                                                            Else
                                                                                Rollback()
                                                                                Return New RespuestaHTTP(Of Boolean)(False, FacturaVentaMovimientos(i).AscFacturaVentaDetalle.Err)
                                                                            End If
                                                                        Else
                                                                            Rollback()
                                                                            Return New RespuestaHTTP(Of Boolean)(False, FacturaVentaMovimientos(i).Err)
                                                                        End If
                                                                    Else
                                                                        Rollback()
                                                                        Return New RespuestaHTTP(Of Boolean)(False, RemitosVentaMovimientos(i).Err)
                                                                    End If
                                                                Else
                                                                    Rollback()
                                                                    Return New RespuestaHTTP(Of Boolean)(False, Movimientos_Remito_Factura(i).Err)
                                                                End If
                                                            Else
                                                                Rollback()
                                                                Return New RespuestaHTTP(Of Boolean)(False, FacturaVentaMovimientos(i).Err)
                                                            End If
                                                        Else
                                                            Rollback()
                                                            Return New RespuestaHTTP(Of Boolean)(False, FacturaVentaMovimientos(i).Err)
                                                        End If
                                                    End If
                                                Else
                                                    Rollback()
                                                    Return New RespuestaHTTP(Of Boolean)(False, RemitosVentaMovimientos(i).Err)
                                                End If
                                            Else
                                                Rollback()
                                                Return New RespuestaHTTP(Of Boolean)(False, RemitosVentaMovimientos(i).Err)
                                            End If
                                        Else
                                            Rollback()
                                            Return New RespuestaHTTP(Of Boolean)(False, RemitosVentaMovimientos(i).Err)
                                        End If
                                    Else
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(False, RemitosVentaMovimientos(i).AscStock.Err)
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(False, DetallesRemitosVenta(i).Err)
                                End If
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of Boolean)(False, DetallesRemitosVenta(i).Err)
                            End If
                        Next

                        Dim detalleRemito As List(Of ModeloDetalleRemitoVenta) = DetallesRemitosVenta.First.ListasdoPorIdRemitosVenta()

                        If Not IsNothing(detalleRemito) Then
                            Dim facturado As Boolean = True

                            For Each item In detalleRemito
                                If item.Facturado = "NO" Then
                                    facturado = False
                                End If
                            Next

                            If facturado Then
                                RemitoVenta.IdRemitosVenta = RemVtaUltId
                                RemitoVenta.Facturado = "SI"

                                If Not RemitoVenta.ModificarEstadoFacturacion() Then
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(Nothing, RemitoVenta.Err)
                                End If
                            End If

                            If Numeracion.ModificarNroRemito() Then
                                Commit()
                                Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of Boolean)(False, Numeracion.Err)
                            End If
                        Else
                            Rollback()
                            Return New RespuestaHTTP(Of Boolean)(Nothing, DetallesRemitosVenta.First.Err)
                        End If
                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(False, RemitoVentaMonedas.Err)
                    End If
                Else
                    Rollback()
                    Return New RespuestaHTTP(Of Boolean)(False, RemitoVenta.Err)
                End If
            Else
                Rollback()
                Return New RespuestaHTTP(Of Boolean)(False, RemitoVenta.Err)
            End If
        Catch ex As Exception
            If Transacciones.enTransaccion Then
                Rollback()
            End If

            Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message & ex.StackTrace})
        End Try
    End Function

    Public Function Modificar() As RespuestaHTTP(Of Boolean)
        Try
            Dim verificarNoEliminado As ModeloRemitosVenta = RemitoVenta.ConsultarPorId()

            If RemitoVenta.Err.Identificador = EnumErrores.OK Then
                Dim remVtaMov As New ModeloRemitosVentaMovimientos With {.AscDetalleRemitoVenta = New ModeloDetalleRemitoVenta With {.AscRemitosVenta = New ModeloRemitosVenta With {.IdRemitosVenta = RemitoVenta.IdRemitosVenta}}}
                Dim movRemFac As New ModeloMovimientos_Remito_Factura With {.AscRemitosVentaMovimientos = New ModeloRemitosVentaMovimientos With {.AscDetalleRemitoVenta = New ModeloDetalleRemitoVenta With {.AscRemitosVenta = New ModeloRemitosVenta With {.IdRemitosVenta = RemitoVenta.IdRemitosVenta}}}}
                Dim movResRem As New ModeloMovimientos_Reserva_Remito With {.AscRemitosVentaMovimientos = New ModeloRemitosVentaMovimientos With {.AscDetalleRemitoVenta = New ModeloDetalleRemitoVenta With {.AscRemitosVenta = New ModeloRemitosVenta With {.IdRemitosVenta = RemitoVenta.IdRemitosVenta}}}}
                Dim detRemVta As New ModeloDetalleRemitoVenta With {.AscRemitosVenta = New ModeloRemitosVenta With {.IdRemitosVenta = RemitoVenta.IdRemitosVenta}}

                BeginTransaction()

                If RemitoVentaMonedas.EliminarPorIdRemitosVenta() Then
                    Dim listResRemMov As List(Of ModeloMovimientos_Reserva_Remito) = movResRem.ListasdoPorIdRemitosVenta()

                    If Not IsNothing(listResRemMov) Then
                        For Each item In listResRemMov
                            If item.AscPedidosMovimientos.AscStock.Eliminar() Then
                                item.AscPedidosMovimientos.AscPedidosDetalle.Remitado = "NO"

                                If item.AscPedidosMovimientos.AscPedidosDetalle.ModificarEstadoRemitado() Then
                                    item.AscPedidosMovimientos.AscPedidosDetalle.AscPedidos.FechaCierrePedido = "0001-01-01"

                                    If item.AscPedidosMovimientos.AscPedidosDetalle.AscPedidos.ModificarFechaCierrePedido() Then
                                        item.AscPedidosMovimientos.AscPedidosDetalle.AscPedidos.Remitado = "NO"

                                        If item.AscPedidosMovimientos.AscPedidosDetalle.AscPedidos.ModificarEstadoRemitado() Then
                                            Dim detallePedido As List(Of ModeloPedidoDetalle) = item.AscPedidosMovimientos.AscPedidosDetalle.ListadoPorIdPedidos()

                                            If Not IsNothing(detallePedido) Then
                                                For Each det In detallePedido
                                                    If det.IdPedidosDetalle = item.AscPedidosMovimientos.AscPedidosDetalle.IdPedidosDetalle Then
                                                        item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Facturado = det.Remitado

                                                        If Not item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.ModificarFacturacion() Then
                                                            Rollback()
                                                            Return New RespuestaHTTP(Of Boolean)(False, item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Err)
                                                        End If
                                                    End If
                                                Next

                                                If item.AscPedidosMovimientos.Eliminar() Then
                                                    If Not item.Eliminar() Then
                                                        Rollback()
                                                        Return New RespuestaHTTP(Of Boolean)(False, item.Err)
                                                    End If
                                                Else
                                                    Rollback()
                                                    Return New RespuestaHTTP(Of Boolean)(False, item.AscPedidosMovimientos.Err)
                                                End If
                                            Else
                                                Rollback()
                                                Return New RespuestaHTTP(Of Boolean)(False, item.AscPedidosMovimientos.AscPedidosDetalle.Err)
                                            End If
                                        Else
                                            Rollback()
                                            Return New RespuestaHTTP(Of Boolean)(False, item.AscPedidosMovimientos.AscPedidosDetalle.AscPedidos.Err)
                                        End If
                                    Else
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(False, item.AscPedidosMovimientos.AscPedidosDetalle.AscPedidos.Err)
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(False, item.AscPedidosMovimientos.AscPedidosDetalle.Err)
                                End If
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of Boolean)(False, item.AscPedidosMovimientos.AscStock.Err)
                            End If
                        Next
                    ElseIf movResRem.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(False, movResRem.Err)
                    End If

                    Dim listRemFacMov As List(Of ModeloMovimientos_Remito_Factura) = movRemFac.ListasdoPorIdRemitosVenta()

                    If Not IsNothing(listRemFacMov) Then
                        For Each item In listRemFacMov
                            item.AscFacturaVentaMovimientos.AscFacturaVentaDetalle.Remitado = "NO"

                            If item.AscFacturaVentaMovimientos.AscFacturaVentaDetalle.ModificarRemitado() Then
                                item.AscFacturaVentaMovimientos.AscFacturaVentaDetalle.AscFacturaVenta.Remitado = "NO"

                                If item.AscFacturaVentaMovimientos.AscFacturaVentaDetalle.AscFacturaVenta.ModificarEstadoRemitado() Then
                                    item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Facturado = "NO"

                                    If item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.ModificarFacturacion() Then
                                        Dim movFacRes As New ModeloMovimientos_Factura_Reserva With {.AscFacturaVentaMovimientos = item.AscFacturaVentaMovimientos}

                                        If movFacRes.EliminarPorIdFacturaVentaMovimientos() Then
                                            If item.AscFacturaVentaMovimientos.Eliminar() Then
                                                If Not item.Eliminar() Then
                                                    Rollback()
                                                    Return New RespuestaHTTP(Of Boolean)(False, item.Err)
                                                End If
                                            Else
                                                Rollback()
                                                Return New RespuestaHTTP(Of Boolean)(False, item.AscFacturaVentaMovimientos.Err)
                                            End If
                                        Else
                                            Rollback()
                                            Return New RespuestaHTTP(Of Boolean)(False, movFacRes.Err)
                                        End If
                                    Else
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(False, item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Err)
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(False, item.AscFacturaVentaMovimientos.AscFacturaVentaDetalle.AscFacturaVenta.Err)
                                End If
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of Boolean)(False, item.AscFacturaVentaMovimientos.AscFacturaVentaDetalle.Err)
                            End If
                        Next
                    ElseIf movRemFac.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(False, movRemFac.Err)
                    End If

                    Dim listRemVtaMov As List(Of ModeloRemitosVentaMovimientos) = remVtaMov.ListasdoPorIdRemitosVenta()

                    If Not IsNothing(listRemVtaMov) Then
                        For Each item In listRemVtaMov
                            If item.Tipo = "REMITADO" Then
                                If item.AscStock.Eliminar() Then
                                    If Not item.Eliminar() Then
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(False, item.Err)
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(False, item.AscStock.Err)
                                End If
                            End If
                        Next
                    ElseIf remVtaMov.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(False, remVtaMov.Err)
                    End If

                    If detRemVta.EliminarPorIdRemitosVenta() Then
                        For Each item In RemitosVentaMovimientos
                            Dim stk As Integer = item.AscStock.CantidadStockFisicoPorIdArticulo()

                            If Not IsNothing(stk) Then
                                If stk < item.Cantidad Then
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.OPERACION_SIMULTANEA_NO_TERMINANTE, .Descripcion = "No hay suficiente Stock del articulo " + item.AscStock.AscArticulos.Detalle + " la cantidad en disponible es de " + stk + "."})
                                End If
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of Boolean)(False, item.AscStock.Err)
                            End If
                        Next

                        If RemitoVenta.Modificar() Then
                            If RemitoVentaMonedas.Insertar() Then
                                For i As Integer = 0 To DetallesRemitosVenta.Count - 1
                                    If DetallesRemitosVenta(i).Insertar() Then
                                        RemitosVentaMovimientos(i).AscStock.Movimiento = "EGRESO"

                                        If RemitosVentaMovimientos(i).AscStock.Insertar() Then
                                            Dim DetRemVtaUltId As Integer = DetallesRemitosVenta(i).UltimoId()

                                            If Not IsNothing(DetRemVtaUltId) Then
                                                Dim StkUltId As Integer = RemitosVentaMovimientos(i).AscStock.UltimoId()

                                                If Not IsNothing(StkUltId) Then
                                                    RemitosVentaMovimientos(i).AscDetalleRemitoVenta.IdDetalleRemitosVenta = DetRemVtaUltId
                                                    RemitosVentaMovimientos(i).AscStock.IdStock = StkUltId

                                                    If RemitosVentaMovimientos(i).Insertar() Then
                                                        Dim RemVtaMovUltId As Integer = RemitosVentaMovimientos(i).UltimoId()

                                                        If Not IsNothing(StkUltId) Then
                                                            If PedidosMovimientos(i).AscPedidosDetalle.IdPedidosDetalle <> 0 Then
                                                                RemitosVentaMovimientos(i).AscStock.AscDepositos.IdDeposito = 1
                                                                RemitosVentaMovimientos(i).AscStock.Movimiento = "RESERVA"

                                                                If RemitosVentaMovimientos(i).AscStock.Insertar() Then
                                                                    StkUltId = RemitosVentaMovimientos(i).AscStock.UltimoId()

                                                                    If Not IsNothing(StkUltId) Then
                                                                        PedidosMovimientos(i).AscStock.IdStock = StkUltId

                                                                        If PedidosMovimientos(i).Insertar() Then
                                                                            Dim pedMovUltId As Integer = PedidosMovimientos(i).UltimoId()

                                                                            If Not IsNothing(pedMovUltId) Then
                                                                                Movimientos_Reserva_Remito(i).AscRemitosVentaMovimientos.IdRemitosVentasMovimientos = RemVtaMovUltId
                                                                                Movimientos_Reserva_Remito(i).AscPedidosMovimientos.IdPedidosMovimientos = pedMovUltId

                                                                                If Movimientos_Reserva_Remito(i).Insertar() Then
                                                                                    Dim pedCantAnu As Double = PedidosMovimientos(i).CantidadAnulada()

                                                                                    If Not IsNothing(pedCantAnu) Then
                                                                                        Movimientos_Reserva_Remito(i).AscPedidosMovimientos = PedidosMovimientos(i)

                                                                                        Dim pedCantRet As Double = PedidosMovimientos(i).CantidadRetirada()

                                                                                        If Not IsNothing(pedCantRet) Then
                                                                                            Dim pedCantRes As Double = PedidosMovimientos(i).CantidadReservada()

                                                                                            If Not IsNothing(pedCantRes) Then
                                                                                                If pedCantRes = pedCantRet + pedCantAnu Then
                                                                                                    PedidosMovimientos(i).AscPedidosDetalle.Remitado = "SI"

                                                                                                    If PedidosMovimientos(i).AscPedidosDetalle.ModificarEstadoRemitado() Then
                                                                                                        Dim detallePedido As List(Of ModeloPedidoDetalle) = PedidosMovimientos(i).AscPedidosDetalle.ListadoPorIdPedidos()

                                                                                                        If Not IsNothing(detallePedido) Then
                                                                                                            Dim Remitado As Boolean = True

                                                                                                            For Each item In detallePedido
                                                                                                                If item.IdPedidosDetalle = Movimientos_Reserva_Remito(i).AscPedidosMovimientos.AscPedidosDetalle.IdPedidosDetalle Then
                                                                                                                    If item.Facturado = "SI" Then
                                                                                                                        Movimientos_Reserva_Remito(i).AscRemitosVentaMovimientos.AscDetalleRemitoVenta.IdDetalleRemitosVenta = DetRemVtaUltId
                                                                                                                        Movimientos_Reserva_Remito(i).AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Facturado = "SI"

                                                                                                                        If Not Movimientos_Reserva_Remito(i).AscRemitosVentaMovimientos.AscDetalleRemitoVenta.ModificarFacturacion() Then
                                                                                                                            Rollback()
                                                                                                                            Return New RespuestaHTTP(Of Boolean)(False, Movimientos_Reserva_Remito(i).AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Err)
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If

                                                                                                                If item.Remitado = "NO" Then
                                                                                                                    Remitado = False
                                                                                                                End If
                                                                                                            Next

                                                                                                            If Remitado Then
                                                                                                                PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.FechaCierrePedido = Date.Now.Date

                                                                                                                If PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.ModificarFechaCierrePedido() Then
                                                                                                                    PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.Remitado = "SI"

                                                                                                                    If Not PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.ModificarEstadoRemitado() Then
                                                                                                                        Rollback()
                                                                                                                        Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.Err)
                                                                                                                    End If
                                                                                                                Else
                                                                                                                    Rollback()
                                                                                                                    Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.Err)
                                                                                                                End If
                                                                                                            End If
                                                                                                        Else
                                                                                                            Rollback()
                                                                                                            Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).AscPedidosDetalle.Err)
                                                                                                        End If
                                                                                                    Else
                                                                                                        Rollback()
                                                                                                        Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).AscPedidosDetalle.Err)
                                                                                                    End If
                                                                                                End If
                                                                                            Else
                                                                                                Rollback()
                                                                                                Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).Err)
                                                                                            End If
                                                                                        Else
                                                                                            Rollback()
                                                                                            Return New RespuestaHTTP(Of Boolean)(False, Movimientos_Reserva_Remito(i).Err)
                                                                                        End If
                                                                                    Else
                                                                                        Rollback()
                                                                                        Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).Err)
                                                                                    End If
                                                                                Else
                                                                                    Rollback()
                                                                                    Return New RespuestaHTTP(Of Boolean)(False, Movimientos_Reserva_Remito(i).Err)
                                                                                End If
                                                                            Else
                                                                                Rollback()
                                                                                Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).Err)
                                                                            End If
                                                                        Else
                                                                            Rollback()
                                                                            Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).Err)
                                                                        End If
                                                                    Else
                                                                        Rollback()
                                                                        Return New RespuestaHTTP(Of Boolean)(False, RemitosVentaMovimientos(i).AscStock.Err)
                                                                    End If
                                                                Else
                                                                    Rollback()
                                                                    Return New RespuestaHTTP(Of Boolean)(False, RemitosVentaMovimientos(i).AscStock.Err)
                                                                End If
                                                            ElseIf FacturaVentaMovimientos(i).AscFacturaVentaDetalle.IdFacturaVentaDetalle <> 0 Then
                                                                If FacturaVentaMovimientos(i).Insertar() Then
                                                                    Dim facVtaMov As Integer = FacturaVentaMovimientos(i).UltimoId()

                                                                    If Not IsNothing(facVtaMov) Then
                                                                        Movimientos_Remito_Factura(i).AscRemitosVentaMovimientos.IdRemitosVentasMovimientos = RemVtaMovUltId
                                                                        Movimientos_Remito_Factura(i).AscFacturaVentaMovimientos.IdFacturaVentaMovimientos = facVtaMov

                                                                        If Movimientos_Remito_Factura(i).Insertar() Then
                                                                            RemitosVentaMovimientos(i).AscDetalleRemitoVenta.Facturado = "SI"

                                                                            If RemitosVentaMovimientos(i).AscDetalleRemitoVenta.ModificarFacturacion() Then
                                                                                Dim movFacRes As New ModeloMovimientos_Factura_Reserva With {.AscFacturaVentaMovimientos = FacturaVentaMovimientos(i)}
                                                                                Dim listMovFacRes As List(Of ModeloMovimientos_Factura_Reserva) = movFacRes.ListasdoPorIdDetalleRemitosVenta()

                                                                                If Not IsNothing(listMovFacRes) Then
                                                                                    For Each item In listMovFacRes
                                                                                        RemitosVentaMovimientos(i).AscStock.AscDepositos.IdDeposito = 1
                                                                                        RemitosVentaMovimientos(i).AscStock.Movimiento = "RESERVA"

                                                                                        If RemitosVentaMovimientos(i).AscStock.Insertar() Then
                                                                                            StkUltId = RemitosVentaMovimientos(i).AscStock.UltimoId()

                                                                                            If Not IsNothing(StkUltId) Then
                                                                                                PedidosMovimientos(i).AscPedidosDetalle.IdPedidosDetalle = item.AscPedidoMovimientos.AscPedidosDetalle.IdPedidosDetalle
                                                                                                PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.IdPedidos = item.AscPedidoMovimientos.AscPedidosDetalle.AscPedidos.IdPedidos
                                                                                                PedidosMovimientos(i).AscStock.IdStock = StkUltId

                                                                                                If PedidosMovimientos(i).Insertar() Then
                                                                                                    Dim pedMovUltId As Integer = PedidosMovimientos(i).UltimoId()

                                                                                                    If Not IsNothing(pedMovUltId) Then
                                                                                                        item.AscPedidoMovimientos.IdPedidosMovimientos = pedMovUltId
                                                                                                        item.AscFacturaVentaMovimientos.IdFacturaVentaMovimientos = facVtaMov
                                                                                                        item.Fecha = Date.Now.Date
                                                                                                        item.Tipo = "REMITADO"
                                                                                                        item.Cantidad = PedidosMovimientos(i).Cantidad
                                                                                                        item.Eliminado = "NO"

                                                                                                        If item.Insertar() Then
                                                                                                            Movimientos_Reserva_Remito(i).AscRemitosVentaMovimientos.IdRemitosVentasMovimientos = RemVtaMovUltId
                                                                                                            Movimientos_Reserva_Remito(i).AscPedidosMovimientos.IdPedidosMovimientos = pedMovUltId

                                                                                                            If Movimientos_Reserva_Remito(i).Insertar() Then
                                                                                                                Dim pedCantAnu As Double = PedidosMovimientos(i).CantidadAnulada()

                                                                                                                If Not IsNothing(pedCantAnu) Then
                                                                                                                    Dim pedCantRet As Double = PedidosMovimientos(i).CantidadRetirada()

                                                                                                                    If Not IsNothing(pedCantRet) Then
                                                                                                                        Dim pedCanRes As Double = PedidosMovimientos(i).CantidadReservada()

                                                                                                                        If Not IsNothing(pedCanRes) Then
                                                                                                                            If pedCanRes = pedCantRet + pedCantAnu Then
                                                                                                                                PedidosMovimientos(i).AscPedidosDetalle.Remitado = "SI"

                                                                                                                                If PedidosMovimientos(i).AscPedidosDetalle.ModificarEstadoRemitado() Then
                                                                                                                                    Dim detallePedido As List(Of ModeloPedidoDetalle) = PedidosMovimientos(i).AscPedidosDetalle.ListadoPorIdPedidos()

                                                                                                                                    If Not IsNothing(detallePedido) Then
                                                                                                                                        Dim Remitado As Boolean = True

                                                                                                                                        For Each detPed In detallePedido
                                                                                                                                            If detPed.IdPedidosDetalle = item.AscPedidoMovimientos.AscPedidosDetalle.IdPedidosDetalle Then
                                                                                                                                                If detPed.Facturado = "SI" Then
                                                                                                                                                    Movimientos_Reserva_Remito(i).AscRemitosVentaMovimientos.AscDetalleRemitoVenta.IdDetalleRemitosVenta = DetRemVtaUltId
                                                                                                                                                    Movimientos_Reserva_Remito(i).AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Facturado = "SI"

                                                                                                                                                    If Not Movimientos_Reserva_Remito(i).AscRemitosVentaMovimientos.AscDetalleRemitoVenta.ModificarFacturacion() Then
                                                                                                                                                        Rollback()
                                                                                                                                                        Return New RespuestaHTTP(Of Boolean)(False, Movimientos_Reserva_Remito(i).AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Err)
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If

                                                                                                                                            If detPed.Remitado = "NO" Then
                                                                                                                                                Remitado = False
                                                                                                                                            End If
                                                                                                                                        Next

                                                                                                                                        If Remitado Then
                                                                                                                                            PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.FechaCierrePedido = Date.Now.Date

                                                                                                                                            If PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.ModificarFechaCierrePedido() Then
                                                                                                                                                PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.Remitado = "SI"

                                                                                                                                                If Not PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.ModificarEstadoRemitado() Then
                                                                                                                                                    Rollback()
                                                                                                                                                    Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.Err)
                                                                                                                                                End If
                                                                                                                                            Else
                                                                                                                                                Rollback()
                                                                                                                                                Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.Err)
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    Else
                                                                                                                                        Rollback()
                                                                                                                                        Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).AscPedidosDetalle.Err)
                                                                                                                                    End If
                                                                                                                                Else
                                                                                                                                    Rollback()
                                                                                                                                    Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).AscPedidosDetalle.Err)
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        Else
                                                                                                                            Rollback()
                                                                                                                            Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).Err)
                                                                                                                        End If
                                                                                                                    Else
                                                                                                                        Rollback()
                                                                                                                        Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).Err)
                                                                                                                    End If
                                                                                                                Else
                                                                                                                    Rollback()
                                                                                                                    Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).Err)
                                                                                                                End If
                                                                                                            Else
                                                                                                                Rollback()
                                                                                                                Return New RespuestaHTTP(Of Boolean)(False, Movimientos_Reserva_Remito(i).Err)
                                                                                                            End If
                                                                                                        Else
                                                                                                            Rollback()
                                                                                                            Return New RespuestaHTTP(Of Boolean)(False, item.Err)
                                                                                                        End If
                                                                                                    Else
                                                                                                        Rollback()
                                                                                                        Return New RespuestaHTTP(Of Boolean)(False, PedidosMovimientos(i).Err)
                                                                                                    End If
                                                                                                End If
                                                                                            Else
                                                                                                Rollback()
                                                                                                Return New RespuestaHTTP(Of Boolean)(False, RemitosVentaMovimientos(i).AscStock.Err)
                                                                                            End If
                                                                                        Else
                                                                                            Rollback()
                                                                                            Return New RespuestaHTTP(Of Boolean)(False, RemitosVentaMovimientos(i).AscStock.Err)
                                                                                        End If
                                                                                    Next
                                                                                ElseIf movFacRes.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                                                                                    Rollback()
                                                                                    Return New RespuestaHTTP(Of Boolean)(False, movFacRes.Err)
                                                                                End If

                                                                                Dim facCanRem As Double = FacturaVentaMovimientos(i).CantidadRemitada()

                                                                                If Not IsNothing(facCanRem) Then
                                                                                    Dim facCanFac As Double = FacturaVentaMovimientos(i).CantidadFacturada()

                                                                                    If Not IsNothing(facCanFac) Then
                                                                                        Dim facCanAnu As Double = FacturaVentaMovimientos(i).CantidadAnulada()

                                                                                        If Not IsNothing(facCanAnu) Then
                                                                                            If facCanRem + facCanAnu = facCanFac Then
                                                                                                FacturaVentaMovimientos(i).AscFacturaVentaDetalle.Remitado = "SI"

                                                                                                If FacturaVentaMovimientos(i).AscFacturaVentaDetalle.ModificarRemitado() Then
                                                                                                    Dim detalleFactura As List(Of ModeloFacturaVentaDetalle) = FacturaVentaMovimientos(i).AscFacturaVentaDetalle.ListadoPorIdFacturaVenta()

                                                                                                    If Not IsNothing(detalleFactura) Then
                                                                                                        Dim Remitado As Boolean = True

                                                                                                        For Each item In detalleFactura
                                                                                                            If item.IdFacturaVentaDetalle = Movimientos_Remito_Factura(i).AscFacturaVentaMovimientos.AscFacturaVentaDetalle.IdFacturaVentaDetalle Then
                                                                                                                If item.Remitado = "SI" Then
                                                                                                                    Movimientos_Remito_Factura(i).AscRemitosVentaMovimientos.AscDetalleRemitoVenta.IdDetalleRemitosVenta = DetRemVtaUltId
                                                                                                                    Movimientos_Remito_Factura(i).AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Facturado = "SI"

                                                                                                                    If Not Movimientos_Remito_Factura(i).AscRemitosVentaMovimientos.AscDetalleRemitoVenta.ModificarFacturacion() Then
                                                                                                                        Rollback()
                                                                                                                        Return New RespuestaHTTP(Of Boolean)(False, Movimientos_Reserva_Remito(i).AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Err)
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If

                                                                                                            If item.Remitado = "NO" Then
                                                                                                                Remitado = False
                                                                                                            End If
                                                                                                        Next

                                                                                                        If Remitado Then
                                                                                                            FacturaVentaMovimientos(i).AscFacturaVentaDetalle.AscFacturaVenta.Remitado = "SI"

                                                                                                            If Not FacturaVentaMovimientos(i).AscFacturaVentaDetalle.AscFacturaVenta.ModificarEstadoRemitado() Then
                                                                                                                Rollback()
                                                                                                                Return New RespuestaHTTP(Of Boolean)(False, FacturaVentaMovimientos(i).AscFacturaVentaDetalle.AscFacturaVenta.Err)
                                                                                                            End If
                                                                                                        End If
                                                                                                    Else
                                                                                                        Rollback()
                                                                                                        Return New RespuestaHTTP(Of Boolean)(False, FacturaVentaMovimientos(i).AscFacturaVentaDetalle.Err)
                                                                                                    End If
                                                                                                Else
                                                                                                    Rollback()
                                                                                                    Return New RespuestaHTTP(Of Boolean)(False, FacturaVentaMovimientos(i).AscFacturaVentaDetalle.Err)
                                                                                                End If
                                                                                            End If
                                                                                        Else
                                                                                            Rollback()
                                                                                            Return New RespuestaHTTP(Of Boolean)(False, FacturaVentaMovimientos(i).AscFacturaVentaDetalle.Err)
                                                                                        End If
                                                                                    Else
                                                                                        Rollback()
                                                                                        Return New RespuestaHTTP(Of Boolean)(False, FacturaVentaMovimientos(i).AscFacturaVentaDetalle.Err)
                                                                                    End If
                                                                                Else
                                                                                    Rollback()
                                                                                    Return New RespuestaHTTP(Of Boolean)(False, FacturaVentaMovimientos(i).Err)
                                                                                End If
                                                                            Else
                                                                                Rollback()
                                                                                Return New RespuestaHTTP(Of Boolean)(False, RemitosVentaMovimientos(i).Err)
                                                                            End If
                                                                        Else
                                                                            Rollback()
                                                                            Return New RespuestaHTTP(Of Boolean)(False, Movimientos_Remito_Factura(i).Err)
                                                                        End If
                                                                    Else
                                                                        Rollback()
                                                                        Return New RespuestaHTTP(Of Boolean)(False, FacturaVentaMovimientos(i).Err)
                                                                    End If
                                                                Else
                                                                    Rollback()
                                                                    Return New RespuestaHTTP(Of Boolean)(False, FacturaVentaMovimientos(i).Err)
                                                                End If
                                                            End If
                                                        Else
                                                            Rollback()
                                                            Return New RespuestaHTTP(Of Boolean)(False, RemitosVentaMovimientos(i).Err)
                                                        End If
                                                    Else
                                                        Rollback()
                                                        Return New RespuestaHTTP(Of Boolean)(False, RemitosVentaMovimientos(i).Err)
                                                    End If
                                                Else
                                                    Rollback()
                                                    Return New RespuestaHTTP(Of Boolean)(False, RemitosVentaMovimientos(i).Err)
                                                End If
                                            Else
                                                Rollback()
                                                Return New RespuestaHTTP(Of Boolean)(False, RemitosVentaMovimientos(i).AscStock.Err)
                                            End If
                                        Else
                                            Rollback()
                                            Return New RespuestaHTTP(Of Boolean)(False, DetallesRemitosVenta(i).Err)
                                        End If
                                    Else
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(False, DetallesRemitosVenta(i).Err)
                                    End If
                                Next

                                Dim detalleRemito As List(Of ModeloDetalleRemitoVenta) = DetallesRemitosVenta.First.ListasdoPorIdRemitosVenta()

                                If Not IsNothing(detalleRemito) Then
                                    Dim facturado As Boolean = True

                                    For Each item In detalleRemito
                                        If item.Facturado = "NO" Then
                                            facturado = False
                                        End If
                                    Next

                                    If facturado Then
                                        RemitoVenta.Facturado = "SI"
                                    Else
                                        RemitoVenta.Facturado = "NO"
                                    End If

                                    If RemitoVenta.ModificarEstadoFacturacion() Then
                                        Commit()
                                        Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                                    Else
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(Nothing, RemitoVenta.Err)
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(Nothing, DetallesRemitosVenta.First.Err)
                                End If
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of Boolean)(False, RemitoVentaMonedas.Err)
                            End If
                        Else
                            Rollback()
                            Return New RespuestaHTTP(Of Boolean)(False, RemitoVenta.Err)
                        End If
                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(Nothing, detRemVta.Err)
                    End If
                Else
                    Rollback()
                    Return New RespuestaHTTP(Of Boolean)(Nothing, RemitoVentaMonedas.Err)
                End If
            ElseIf verificarNoEliminado.Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO Then
                Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.OPERACION_SIMULTANEA_TERMINANTE, .Descripcion = "El remito que intentas eliminar ya fue eliminada por otro usuario."})
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

    Public Function Eliminar() As RespuestaHTTP(Of Boolean)
        Try
            Dim verificarNoEliminado As ModeloRemitosVenta = RemitoVenta.ConsultarPorId()

            If RemitoVenta.Err.Identificador = EnumErrores.OK Then
                Dim remVtaMov As New ModeloRemitosVentaMovimientos With {.AscDetalleRemitoVenta = New ModeloDetalleRemitoVenta With {.AscRemitosVenta = New ModeloRemitosVenta With {.IdRemitosVenta = RemitoVenta.IdRemitosVenta}}}
                Dim movRemFac As New ModeloMovimientos_Remito_Factura With {.AscRemitosVentaMovimientos = New ModeloRemitosVentaMovimientos With {.AscDetalleRemitoVenta = New ModeloDetalleRemitoVenta With {.AscRemitosVenta = New ModeloRemitosVenta With {.IdRemitosVenta = RemitoVenta.IdRemitosVenta}}}}
                Dim movResRem As New ModeloMovimientos_Reserva_Remito With {.AscRemitosVentaMovimientos = New ModeloRemitosVentaMovimientos With {.AscDetalleRemitoVenta = New ModeloDetalleRemitoVenta With {.AscRemitosVenta = New ModeloRemitosVenta With {.IdRemitosVenta = RemitoVenta.IdRemitosVenta}}}}
                Dim detRemVta As New ModeloDetalleRemitoVenta With {.AscRemitosVenta = New ModeloRemitosVenta With {.IdRemitosVenta = RemitoVenta.IdRemitosVenta}}

                BeginTransaction()

                If RemitoVentaMonedas.EliminarPorIdRemitosVenta() Then
                    Dim listResRemMov As List(Of ModeloMovimientos_Reserva_Remito) = movResRem.ListasdoPorIdRemitosVenta()

                    If Not IsNothing(listResRemMov) Then
                        For Each item In listResRemMov
                            If item.AscPedidosMovimientos.AscStock.Eliminar() Then
                                item.AscPedidosMovimientos.AscPedidosDetalle.Remitado = "NO"

                                If item.AscPedidosMovimientos.AscPedidosDetalle.ModificarEstadoRemitado() Then
                                    item.AscPedidosMovimientos.AscPedidosDetalle.AscPedidos.FechaCierrePedido = "0001-01-01"

                                    If item.AscPedidosMovimientos.AscPedidosDetalle.AscPedidos.ModificarFechaCierrePedido() Then
                                        item.AscPedidosMovimientos.AscPedidosDetalle.AscPedidos.Remitado = "NO"

                                        If item.AscPedidosMovimientos.AscPedidosDetalle.AscPedidos.ModificarEstadoRemitado() Then
                                            Dim detallePedido As List(Of ModeloPedidoDetalle) = item.AscPedidosMovimientos.AscPedidosDetalle.ListadoPorIdPedidos()

                                            If Not IsNothing(detallePedido) Then
                                                For Each det In detallePedido
                                                    If det.IdPedidosDetalle = item.AscPedidosMovimientos.AscPedidosDetalle.IdPedidosDetalle Then
                                                        item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Facturado = det.Remitado

                                                        If Not item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.ModificarFacturacion() Then
                                                            Rollback()
                                                            Return New RespuestaHTTP(Of Boolean)(False, item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Err)
                                                        End If
                                                    End If
                                                Next

                                                If item.AscPedidosMovimientos.Eliminar() Then
                                                    If Not item.Eliminar() Then
                                                        Rollback()
                                                        Return New RespuestaHTTP(Of Boolean)(False, item.Err)
                                                    End If
                                                Else
                                                    Rollback()
                                                    Return New RespuestaHTTP(Of Boolean)(False, item.AscPedidosMovimientos.Err)
                                                End If
                                            Else
                                                Rollback()
                                                Return New RespuestaHTTP(Of Boolean)(False, item.AscPedidosMovimientos.AscPedidosDetalle.Err)
                                            End If
                                        Else
                                            Rollback()
                                            Return New RespuestaHTTP(Of Boolean)(False, item.AscPedidosMovimientos.AscPedidosDetalle.AscPedidos.Err)
                                        End If
                                    Else
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(False, item.AscPedidosMovimientos.AscPedidosDetalle.AscPedidos.Err)
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(False, item.AscPedidosMovimientos.AscPedidosDetalle.Err)
                                End If
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of Boolean)(False, item.AscPedidosMovimientos.AscStock.Err)
                            End If
                        Next
                    ElseIf movResRem.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(False, movResRem.Err)
                    End If

                    Dim listRemFacMov As List(Of ModeloMovimientos_Remito_Factura) = movRemFac.ListasdoPorIdRemitosVenta()

                    If Not IsNothing(listRemFacMov) Then
                        For Each item In listRemFacMov
                            item.AscFacturaVentaMovimientos.AscFacturaVentaDetalle.Remitado = "NO"

                            If item.AscFacturaVentaMovimientos.AscFacturaVentaDetalle.ModificarRemitado() Then
                                item.AscFacturaVentaMovimientos.AscFacturaVentaDetalle.AscFacturaVenta.Remitado = "NO"

                                If item.AscFacturaVentaMovimientos.AscFacturaVentaDetalle.AscFacturaVenta.ModificarEstadoRemitado() Then
                                    item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Facturado = "NO"

                                    If item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.ModificarFacturacion() Then
                                        Dim movFacRes As New ModeloMovimientos_Factura_Reserva With {.AscFacturaVentaMovimientos = item.AscFacturaVentaMovimientos}

                                        If movFacRes.EliminarPorIdFacturaVentaMovimientos() Then
                                            If item.AscFacturaVentaMovimientos.Eliminar() Then
                                                If Not item.Eliminar() Then
                                                    Rollback()
                                                    Return New RespuestaHTTP(Of Boolean)(False, item.Err)
                                                End If
                                            Else
                                                Rollback()
                                                Return New RespuestaHTTP(Of Boolean)(False, item.AscFacturaVentaMovimientos.Err)
                                            End If
                                        Else
                                            Rollback()
                                            Return New RespuestaHTTP(Of Boolean)(False, movFacRes.Err)
                                        End If
                                    Else
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(False, item.AscRemitosVentaMovimientos.AscDetalleRemitoVenta.Err)
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(False, item.AscFacturaVentaMovimientos.AscFacturaVentaDetalle.AscFacturaVenta.Err)
                                End If
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of Boolean)(False, item.AscFacturaVentaMovimientos.AscFacturaVentaDetalle.Err)
                            End If
                        Next
                    ElseIf movRemFac.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(False, movRemFac.Err)
                    End If

                    Dim listRemVtaMov As List(Of ModeloRemitosVentaMovimientos) = remVtaMov.ListasdoPorIdRemitosVenta()

                    If Not IsNothing(listRemVtaMov) Then
                        For Each item In listRemVtaMov
                            If item.Tipo = "REMITADO" Then
                                If item.AscStock.Eliminar() Then
                                    If Not item.Eliminar() Then
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(False, item.Err)
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(False, item.AscStock.Err)
                                End If
                            End If
                        Next
                    ElseIf remVtaMov.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(False, remVtaMov.Err)
                    End If

                    Dim detalleRemito As List(Of ModeloDetalleRemitoVenta) = detRemVta.ListasdoPorIdRemitosVenta()

                    If Not IsNothing(detalleRemito) Then
                        Dim facturado As Boolean = True

                        For Each item In detalleRemito
                            If item.Facturado = "NO" Then
                                facturado = False
                            End If
                        Next

                        If facturado Then
                            RemitoVenta.Facturado = "SI"
                        Else
                            RemitoVenta.Facturado = "NO"
                        End If

                        If RemitoVenta.ModificarEstadoFacturacion() Then
                            If detRemVta.EliminarPorIdRemitosVenta() Then
                                If RemitoVenta.Eliminar() Then
                                    Commit()
                                    Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(Nothing, RemitoVenta.Err)
                                End If
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of Boolean)(Nothing, detRemVta.Err)
                            End If
                        Else
                            Rollback()
                            Return New RespuestaHTTP(Of Boolean)(Nothing, RemitoVenta.Err)
                        End If
                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(Nothing, detRemVta.Err)
                    End If
                Else
                    Rollback()
                    Return New RespuestaHTTP(Of Boolean)(Nothing, RemitoVentaMonedas.Err)
                End If
            ElseIf verificarNoEliminado.Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO Then
                Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.OPERACION_SIMULTANEA_TERMINANTE, .Descripcion = "El remito que intentas eliminar ya fue eliminada por otro usuario."})
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
#End Region
End Class
