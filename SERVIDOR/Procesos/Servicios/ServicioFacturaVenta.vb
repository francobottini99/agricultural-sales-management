Imports AccesoDatos

Public Class ServicioFacturaVenta
    Inherits EnlaceTransacciones(Of Transacciones)

    Private _FacturaVenta As ModeloFacturaVenta
    Private _CuentaCorritenteVenta As ModeloCuentaCorrienteVenta
    Private _FacturaVentaMoneda As ModeloFacturaVentaMonedas
    Private _FacturaVentaDetalle As List(Of ModeloFacturaVentaDetalle)
    Private _Numeracion As ModeloNumeracion
    Private _Movimientos_Remito_Factura As List(Of ModeloMovimientos_Remito_Factura)
    Private _Movimientos_Factura_Reserva As List(Of ModeloMovimientos_Factura_Reserva)
    Private _RemitosVentaMovimientos As List(Of ModeloRemitosVentaMovimientos)
    Private _PedidosMovimientos As List(Of ModeloPedidoMovimientos)
    Private _FacturaVentaMovimientos As List(Of ModeloFacturaVentaMovimientos)

#Region "CONSTRUCTORES"
    Public Sub New(facturaVenta As ModeloFacturaVenta, cuentaCorritenteVenta As ModeloCuentaCorrienteVenta,
                   facturaVentaMoneda As ModeloFacturaVentaMonedas, facturaVentaDetalle As List(Of ModeloFacturaVentaDetalle), numeracion As ModeloNumeracion,
                   movimientos_Remito_Factura As List(Of ModeloMovimientos_Remito_Factura), movimientos_Factura_Reserva As List(Of ModeloMovimientos_Factura_Reserva), remitosVentaMovimientos As List(Of ModeloRemitosVentaMovimientos), pedidosMovimientos As List(Of ModeloPedidoMovimientos), facturaVentaMovimientos As List(Of ModeloFacturaVentaMovimientos))
        MyBase.New(New Transacciones(), "-")

        Me.FacturaVenta = facturaVenta
        Me.CuentaCorritenteVenta = cuentaCorritenteVenta
        Me.FacturaVentaMoneda = facturaVentaMoneda
        Me.FacturaVentaDetalle = facturaVentaDetalle
        Me.Numeracion = numeracion
        Me.Movimientos_Remito_Factura = movimientos_Remito_Factura
        Me.Movimientos_Factura_Reserva = movimientos_Factura_Reserva
        Me.RemitosVentaMovimientos = remitosVentaMovimientos
        Me.PedidosMovimientos = pedidosMovimientos
        Me.FacturaVentaMovimientos = facturaVentaMovimientos
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property FacturaVenta As ModeloFacturaVenta
        Get
            Return _FacturaVenta
        End Get
        Set(value As ModeloFacturaVenta)
            _FacturaVenta = value
        End Set
    End Property

    Public Property CuentaCorritenteVenta As ModeloCuentaCorrienteVenta
        Get
            Return _CuentaCorritenteVenta
        End Get
        Set(value As ModeloCuentaCorrienteVenta)
            _CuentaCorritenteVenta = value
        End Set
    End Property

    Public Property FacturaVentaMoneda As ModeloFacturaVentaMonedas
        Get
            Return _FacturaVentaMoneda
        End Get
        Set(value As ModeloFacturaVentaMonedas)
            _FacturaVentaMoneda = value
        End Set
    End Property

    Public Property FacturaVentaDetalle As List(Of ModeloFacturaVentaDetalle)
        Get
            Return _FacturaVentaDetalle
        End Get
        Set(value As List(Of ModeloFacturaVentaDetalle))
            _FacturaVentaDetalle = value
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

    Public Property Movimientos_Remito_Factura As List(Of ModeloMovimientos_Remito_Factura)
        Get
            Return _Movimientos_Remito_Factura
        End Get
        Set(value As List(Of ModeloMovimientos_Remito_Factura))
            _Movimientos_Remito_Factura = value
        End Set
    End Property

    Public Property Movimientos_Factura_Reserva As List(Of ModeloMovimientos_Factura_Reserva)
        Get
            Return _Movimientos_Factura_Reserva
        End Get
        Set(value As List(Of ModeloMovimientos_Factura_Reserva))
            _Movimientos_Factura_Reserva = value
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
    Public Function Insertar() As RespuestaHTTP(Of FEResultCAE)
        Try
            BeginTransaction()

            FacturaVenta.CAE = "Pendiente"
            FacturaVenta.FechaVtoCAE = "0001-01-01"

            If CuentaCorritenteVenta.Insertar() Then
                Dim idCtaCrt As Integer = CuentaCorritenteVenta.UltimoId()

                If Not IsNothing(idCtaCrt) Then
                    FacturaVenta.AscCtaCteVenta.IdCuentaCorrienteVentas = idCtaCrt

                    If FacturaVenta.Insertar() Then
                        Dim idFac As Integer = FacturaVenta.UltimoId()

                        If Not IsNothing(idFac) Then
                            FacturaVentaMoneda.AscFacturaVenta.IdFacturaVenta = idFac

                            If FacturaVentaMoneda.Insertar() Then
                                For i As Integer = 0 To FacturaVentaDetalle.Count - 1
                                    FacturaVentaDetalle(i).AscFacturaVenta.IdFacturaVenta = idFac

                                    If FacturaVentaDetalle(i).AscArticulos.IdArticulo = 2 Then
                                        FacturaVentaDetalle(i).Remitado = "-"
                                    End If

                                    If FacturaVentaDetalle(i).Insertar() Then
                                        If FacturaVentaDetalle(i).AscArticulos.IdArticulo <> 2 Then
                                            Dim detFacVtaUltId As Integer = FacturaVentaDetalle(i).UltimoId()

                                            If Not IsNothing(detFacVtaUltId) Then
                                                FacturaVentaMovimientos(i).AscFacturaVentaDetalle.IdFacturaVentaDetalle = detFacVtaUltId

                                                If FacturaVentaMovimientos(i).Insertar() Then
                                                    Dim facVtaMovUltId As Integer = FacturaVentaMovimientos(i).UltimoId()

                                                    If Not IsNothing(facVtaMovUltId) Then
                                                        If PedidosMovimientos(i).AscPedidosDetalle.IdPedidosDetalle <> 0 Then
                                                            PedidosMovimientos(i).AscStock.IdStock = 1

                                                            If PedidosMovimientos(i).Insertar() Then
                                                                Dim pedMovUltId As Integer = PedidosMovimientos(i).UltimoId()

                                                                If Not IsNothing(pedMovUltId) Then
                                                                    Movimientos_Factura_Reserva(i).AscFacturaVentaMovimientos.IdFacturaVentaMovimientos = facVtaMovUltId
                                                                    Movimientos_Factura_Reserva(i).AscPedidoMovimientos.IdPedidosMovimientos = pedMovUltId

                                                                    If Movimientos_Factura_Reserva(i).Insertar() Then
                                                                        Dim pedCantAnu As Double = PedidosMovimientos(i).CantidadAnulada()

                                                                        If Not IsNothing(pedCantAnu) Then
                                                                            Dim pedCantFac As Double = PedidosMovimientos(i).CantidadFacturada()

                                                                            If Not IsNothing(pedCantFac) Then
                                                                                Dim pedCantRes As Double = PedidosMovimientos(i).CantidadReservada()

                                                                                If Not IsNothing(pedCantRes) Then
                                                                                    If pedCantRes = pedCantFac + pedCantAnu Then
                                                                                        PedidosMovimientos(i).AscPedidosDetalle.Facturado = "SI"

                                                                                        If PedidosMovimientos(i).AscPedidosDetalle.ModificarEstadoFacturado() Then
                                                                                            Dim detallePedido As List(Of ModeloPedidoDetalle) = PedidosMovimientos(i).AscPedidosDetalle.ListadoPorIdPedidos()

                                                                                            If Not IsNothing(detallePedido) Then
                                                                                                Dim Facturado As Boolean = True

                                                                                                For Each item In detallePedido
                                                                                                    If item.IdPedidosDetalle = Movimientos_Factura_Reserva(i).AscPedidoMovimientos.AscPedidosDetalle.IdPedidosDetalle Then
                                                                                                        If item.Remitado = "SI" Then
                                                                                                            Movimientos_Factura_Reserva(i).AscFacturaVentaMovimientos.AscFacturaVentaDetalle.IdFacturaVentaDetalle = detFacVtaUltId
                                                                                                            Movimientos_Factura_Reserva(i).AscFacturaVentaMovimientos.AscFacturaVentaDetalle.Remitado = "SI"

                                                                                                            If Not Movimientos_Factura_Reserva(i).AscFacturaVentaMovimientos.AscFacturaVentaDetalle.ModificarRemitado() Then
                                                                                                                Rollback()
                                                                                                                Return New RespuestaHTTP(Of FEResultCAE)(Nothing, Movimientos_Factura_Reserva(i).AscFacturaVentaMovimientos.AscFacturaVentaDetalle.Err)
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If

                                                                                                    If item.Facturado = "NO" Then
                                                                                                        Facturado = False
                                                                                                    End If
                                                                                                Next

                                                                                                If Facturado Then
                                                                                                    PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.Facturado = "SI"

                                                                                                    If Not PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.ModificarEstadoFacturado() Then
                                                                                                        Rollback()
                                                                                                        Return New RespuestaHTTP(Of FEResultCAE)(Nothing, PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.Err)
                                                                                                    End If
                                                                                                End If
                                                                                            Else
                                                                                                Rollback()
                                                                                                Return New RespuestaHTTP(Of FEResultCAE)(Nothing, PedidosMovimientos(i).AscPedidosDetalle.Err)
                                                                                            End If
                                                                                        Else
                                                                                            Rollback()
                                                                                            Return New RespuestaHTTP(Of FEResultCAE)(Nothing, PedidosMovimientos(i).AscPedidosDetalle.Err)
                                                                                        End If
                                                                                    End If
                                                                                Else
                                                                                    Rollback()
                                                                                    Return New RespuestaHTTP(Of FEResultCAE)(Nothing, PedidosMovimientos(i).Err)
                                                                                End If
                                                                            Else
                                                                                Rollback()
                                                                                Return New RespuestaHTTP(Of FEResultCAE)(Nothing, PedidosMovimientos(i).Err)
                                                                            End If
                                                                        Else
                                                                            Rollback()
                                                                            Return New RespuestaHTTP(Of FEResultCAE)(Nothing, PedidosMovimientos(i).Err)
                                                                        End If
                                                                    Else
                                                                        Rollback()
                                                                        Return New RespuestaHTTP(Of FEResultCAE)(Nothing, Movimientos_Factura_Reserva(i).Err)
                                                                    End If
                                                                Else
                                                                    Rollback()
                                                                    Return New RespuestaHTTP(Of FEResultCAE)(Nothing, PedidosMovimientos(i).Err)
                                                                End If
                                                            Else
                                                                Rollback()
                                                                Return New RespuestaHTTP(Of FEResultCAE)(Nothing, PedidosMovimientos(i).Err)
                                                            End If
                                                        ElseIf RemitosVentaMovimientos(i).AscDetalleRemitoVenta.IdDetalleRemitosVenta <> 0 Then
                                                            RemitosVentaMovimientos(i).AscStock.IdStock = 1

                                                            If RemitosVentaMovimientos(i).Insertar() Then
                                                                Dim remVtaMovUltId As Integer = RemitosVentaMovimientos(i).UltimoId()

                                                                If Not IsNothing(remVtaMovUltId) Then
                                                                    Movimientos_Remito_Factura(i).AscRemitosVentaMovimientos.IdRemitosVentasMovimientos = remVtaMovUltId
                                                                    Movimientos_Remito_Factura(i).AscFacturaVentaMovimientos.IdFacturaVentaMovimientos = facVtaMovUltId

                                                                    If Movimientos_Remito_Factura(i).Insertar() Then
                                                                        FacturaVentaMovimientos(i).AscFacturaVentaDetalle.Remitado = "SI"

                                                                        If FacturaVentaMovimientos(i).AscFacturaVentaDetalle.ModificarRemitado() Then
                                                                            Dim movRemRes As New ModeloMovimientos_Reserva_Remito With {.AscRemitosVentaMovimientos = RemitosVentaMovimientos(i)}
                                                                            Dim listMovRemRes As List(Of ModeloMovimientos_Reserva_Remito) = movRemRes.ListasdoPorIdDetalleRemitosVenta()

                                                                            If Not IsNothing(listMovRemRes) Then
                                                                                For Each item In listMovRemRes
                                                                                    PedidosMovimientos(i).AscPedidosDetalle.IdPedidosDetalle = item.AscPedidosMovimientos.AscPedidosDetalle.IdPedidosDetalle
                                                                                    PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.IdPedidos = item.AscPedidosMovimientos.AscPedidosDetalle.AscPedidos.IdPedidos
                                                                                    PedidosMovimientos(i).AscStock.IdStock = 1

                                                                                    If PedidosMovimientos(i).Insertar() Then
                                                                                        Dim pedMovUltId As Integer = PedidosMovimientos(i).UltimoId()

                                                                                        If Not IsNothing(pedMovUltId) Then
                                                                                            item.AscPedidosMovimientos.IdPedidosMovimientos = pedMovUltId
                                                                                            item.AscRemitosVentaMovimientos.IdRemitosVentasMovimientos = remVtaMovUltId
                                                                                            item.Fecha = Date.Now.Date
                                                                                            item.Tipo = "FACTURADO"
                                                                                            item.Cantidad = PedidosMovimientos(i).Cantidad
                                                                                            item.Eliminado = "NO"

                                                                                            If item.Insertar() Then
                                                                                                Movimientos_Factura_Reserva(i).AscFacturaVentaMovimientos.IdFacturaVentaMovimientos = facVtaMovUltId
                                                                                                Movimientos_Factura_Reserva(i).AscPedidoMovimientos.IdPedidosMovimientos = pedMovUltId

                                                                                                If Movimientos_Factura_Reserva(i).Insertar() Then
                                                                                                    Dim pedCantAnu As Double = PedidosMovimientos(i).CantidadAnulada()

                                                                                                    If Not IsNothing(pedCantAnu) Then
                                                                                                        Dim pedCantFac As Double = PedidosMovimientos(i).CantidadFacturada()

                                                                                                        If Not IsNothing(pedCantFac) Then
                                                                                                            Dim pedCantRes As Double = PedidosMovimientos(i).CantidadReservada()

                                                                                                            If Not IsNothing(pedCantRes) Then
                                                                                                                If pedCantRes = pedCantFac + pedCantAnu Then
                                                                                                                    PedidosMovimientos(i).AscPedidosDetalle.Facturado = "SI"

                                                                                                                    If PedidosMovimientos(i).AscPedidosDetalle.ModificarEstadoFacturado() Then
                                                                                                                        Dim detallePedido As List(Of ModeloPedidoDetalle) = PedidosMovimientos(i).AscPedidosDetalle.ListadoPorIdPedidos()

                                                                                                                        If Not IsNothing(detallePedido) Then
                                                                                                                            Dim Facturado As Boolean = True

                                                                                                                            For Each detPed In detallePedido
                                                                                                                                If detPed.IdPedidosDetalle = item.AscPedidosMovimientos.AscPedidosDetalle.IdPedidosDetalle Then
                                                                                                                                    If detPed.Remitado = "SI" Then
                                                                                                                                        Movimientos_Factura_Reserva(i).AscFacturaVentaMovimientos.AscFacturaVentaDetalle.IdFacturaVentaDetalle = detFacVtaUltId
                                                                                                                                        Movimientos_Factura_Reserva(i).AscFacturaVentaMovimientos.AscFacturaVentaDetalle.Remitado = "SI"

                                                                                                                                        If Not Movimientos_Factura_Reserva(i).AscFacturaVentaMovimientos.AscFacturaVentaDetalle.ModificarRemitado() Then
                                                                                                                                            Rollback()
                                                                                                                                            Return New RespuestaHTTP(Of FEResultCAE)(Nothing, Movimientos_Factura_Reserva(i).AscFacturaVentaMovimientos.AscFacturaVentaDetalle.Err)
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If

                                                                                                                                If detPed.Facturado = "NO" Then
                                                                                                                                    Facturado = False
                                                                                                                                End If
                                                                                                                            Next

                                                                                                                            If Facturado Then
                                                                                                                                PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.Facturado = "SI"

                                                                                                                                If Not PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.ModificarEstadoFacturado() Then
                                                                                                                                    Rollback()
                                                                                                                                    Return New RespuestaHTTP(Of FEResultCAE)(Nothing, PedidosMovimientos(i).AscPedidosDetalle.AscPedidos.Err)
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        Else
                                                                                                                            Rollback()
                                                                                                                            Return New RespuestaHTTP(Of FEResultCAE)(Nothing, PedidosMovimientos(i).AscPedidosDetalle.Err)
                                                                                                                        End If
                                                                                                                    Else
                                                                                                                        Rollback()
                                                                                                                        Return New RespuestaHTTP(Of FEResultCAE)(Nothing, PedidosMovimientos(i).AscPedidosDetalle.Err)
                                                                                                                    End If
                                                                                                                End If
                                                                                                            Else
                                                                                                                Rollback()
                                                                                                                Return New RespuestaHTTP(Of FEResultCAE)(Nothing, PedidosMovimientos(i).Err)
                                                                                                            End If
                                                                                                        Else
                                                                                                            Rollback()
                                                                                                            Return New RespuestaHTTP(Of FEResultCAE)(Nothing, PedidosMovimientos(i).Err)
                                                                                                        End If
                                                                                                    Else
                                                                                                        Rollback()
                                                                                                        Return New RespuestaHTTP(Of FEResultCAE)(Nothing, PedidosMovimientos(i).Err)
                                                                                                    End If
                                                                                                Else
                                                                                                    Rollback()
                                                                                                    Return New RespuestaHTTP(Of FEResultCAE)(Nothing, Movimientos_Factura_Reserva(i).Err)
                                                                                                End If
                                                                                            Else
                                                                                                Rollback()
                                                                                                Return New RespuestaHTTP(Of FEResultCAE)(Nothing, item.Err)
                                                                                            End If
                                                                                        Else
                                                                                            Rollback()
                                                                                            Return New RespuestaHTTP(Of FEResultCAE)(Nothing, PedidosMovimientos(i).Err)
                                                                                        End If
                                                                                    Else
                                                                                        Rollback()
                                                                                        Return New RespuestaHTTP(Of FEResultCAE)(Nothing, PedidosMovimientos(i).Err)
                                                                                    End If
                                                                                Next
                                                                            ElseIf movRemRes.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                                                                                Rollback()
                                                                                Return New RespuestaHTTP(Of FEResultCAE)(Nothing, movRemRes.Err)
                                                                            End If

                                                                            Dim facCanFac As Double = RemitosVentaMovimientos(i).CantidadFacturada()

                                                                            If Not IsNothing(facCanFac) Then
                                                                                Dim remCanDev As Double = RemitosVentaMovimientos(i).CantidadDevuelta()

                                                                                If Not IsNothing(remCanDev) Then
                                                                                    Dim remCanRem As Double = RemitosVentaMovimientos(i).CantidadRemitada()

                                                                                    If Not IsNothing(remCanRem) Then
                                                                                        If facCanFac = remCanDev + remCanRem Then
                                                                                            RemitosVentaMovimientos(i).AscDetalleRemitoVenta.Facturado = "SI"

                                                                                            If RemitosVentaMovimientos(i).AscDetalleRemitoVenta.ModificarFacturacion() Then
                                                                                                Dim detalleRemito As List(Of ModeloDetalleRemitoVenta) = RemitosVentaMovimientos(i).AscDetalleRemitoVenta.ListasdoPorIdRemitosVenta()

                                                                                                If Not IsNothing(detalleRemito) Then
                                                                                                    Dim Facturado As Boolean = True

                                                                                                    For Each item In detalleRemito
                                                                                                        If item.Facturado = "NO" Then
                                                                                                            Facturado = False
                                                                                                            Exit For
                                                                                                        End If
                                                                                                    Next

                                                                                                    If Facturado Then
                                                                                                        RemitosVentaMovimientos(i).AscDetalleRemitoVenta.AscRemitosVenta.Facturado = "SI"

                                                                                                        If Not RemitosVentaMovimientos(i).AscDetalleRemitoVenta.AscRemitosVenta.ModificarEstadoFacturacion() Then
                                                                                                            Rollback()
                                                                                                            Return New RespuestaHTTP(Of FEResultCAE)(Nothing, RemitosVentaMovimientos(i).AscDetalleRemitoVenta.AscRemitosVenta.Err)
                                                                                                        End If
                                                                                                    End If
                                                                                                Else
                                                                                                    Rollback()
                                                                                                    Return New RespuestaHTTP(Of FEResultCAE)(Nothing, RemitosVentaMovimientos(i).AscDetalleRemitoVenta.Err)
                                                                                                End If
                                                                                            Else
                                                                                                Rollback()
                                                                                                Return New RespuestaHTTP(Of FEResultCAE)(Nothing, RemitosVentaMovimientos(i).AscDetalleRemitoVenta.Err)
                                                                                            End If
                                                                                        ElseIf facCanFac > remCanDev + remCanRem Then
                                                                                            Rollback()
                                                                                            Return New RespuestaHTTP(Of FEResultCAE)(Nothing, New Errores With {.Identificador = EnumErrores.OPERACION_SIMULTANEA_NO_TERMINANTE, .Descripcion = "El item """ & FacturaVentaDetalle(i).Descripcion & """ de la factura ya fue parcial o completamente facturado por otro usuario."})
                                                                                        End If
                                                                                    Else
                                                                                        Rollback()
                                                                                        Return New RespuestaHTTP(Of FEResultCAE)(Nothing, Movimientos_Remito_Factura(i).AscRemitosVentaMovimientos.Err)
                                                                                    End If
                                                                                Else
                                                                                    Rollback()
                                                                                    Return New RespuestaHTTP(Of FEResultCAE)(Nothing, Movimientos_Remito_Factura(i).AscRemitosVentaMovimientos.Err)
                                                                                End If
                                                                            Else
                                                                                Rollback()
                                                                                Return New RespuestaHTTP(Of FEResultCAE)(Nothing, Movimientos_Remito_Factura(i).Err)
                                                                            End If
                                                                        Else
                                                                            Rollback()
                                                                            Return New RespuestaHTTP(Of FEResultCAE)(Nothing, FacturaVentaMovimientos(i).AscFacturaVentaDetalle.Err)
                                                                        End If
                                                                    Else
                                                                        Rollback()
                                                                        Return New RespuestaHTTP(Of FEResultCAE)(Nothing, Movimientos_Remito_Factura(i).Err)
                                                                    End If
                                                                Else
                                                                    Rollback()
                                                                    Return New RespuestaHTTP(Of FEResultCAE)(Nothing, RemitosVentaMovimientos(i).Err)
                                                                End If
                                                            Else
                                                                Rollback()
                                                                Return New RespuestaHTTP(Of FEResultCAE)(Nothing, RemitosVentaMovimientos(i).Err)
                                                            End If
                                                        End If
                                                    Else
                                                        Rollback()
                                                        Return New RespuestaHTTP(Of FEResultCAE)(Nothing, FacturaVentaMovimientos(i).Err)
                                                    End If
                                                Else
                                                    Rollback()
                                                    Return New RespuestaHTTP(Of FEResultCAE)(Nothing, FacturaVentaMovimientos(i).Err)
                                                End If
                                            Else
                                                Rollback()
                                                Return New RespuestaHTTP(Of FEResultCAE)(Nothing, FacturaVentaDetalle(i).Err)
                                            End If
                                        End If
                                    Else
                                        Rollback()
                                        Return New RespuestaHTTP(Of FEResultCAE)(Nothing, FacturaVentaDetalle(i).AscFacturaVenta.Err)
                                    End If
                                Next

                                Dim detalleFactura As List(Of ModeloFacturaVentaDetalle) = FacturaVentaDetalle.First.ListadoPorIdFacturaVenta()

                                If Not IsNothing(detalleFactura) Then
                                    Dim remitada As Boolean = True

                                    For Each item In detalleFactura
                                        If item.Remitado = "NO" Then
                                            remitada = False
                                        End If
                                    Next

                                    If remitada Then
                                        FacturaVenta.IdFacturaVenta = idFac
                                        FacturaVenta.Remitado = "SI"

                                        If Not FacturaVenta.ModificarEstadoRemitado() Then
                                            Rollback()
                                            Return New RespuestaHTTP(Of FEResultCAE)(Nothing, FacturaVenta.Err)
                                        End If
                                    End If

                                    Dim cont As Boolean
                                    Dim nroFac As Integer

                                    If FacturaVenta.ClaseComprobante = "A" Then
                                        cont = Numeracion.ModificarNroFacturaA()
                                        nroFac = Numeracion.NroFacturaA
                                    Else
                                        cont = Numeracion.ModificarNroFacturaB()
                                        nroFac = Numeracion.NroFacturaB
                                    End If

                                    If cont Then
                                        Dim resultAFIP As New FEResultCAE

                                        If FacturaVenta.TipoComprobante <> "X" Then
                                            Dim empresa As New ModeloEmpresa()
                                            Dim datosEmpresa As ModeloEmpresa = empresa.Consultar()

                                            If Not IsNothing(datosEmpresa) Then
                                                Dim connAFIP As New ConexionAFIP(WSAFIPFE.Factura.modoFiscal.Test, datosEmpresa.CUIT, FacturaVenta.Prefijo.TrimStart("0"), UtilidadesVarias.CodComprobanteAFIP(FacturaVenta.ClaseComprobante))
                                                Dim FE As WSAFIPFE.Factura = connAFIP.NuevaSesionAFIP()

                                                If connAFIP.NroComprobanteAutorizado <> nroFac Then
                                                    Rollback()
                                                    Return New RespuestaHTTP(Of FEResultCAE)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AFIP, .Descripcion = "Incongruencias entre el numero comprobante registrado en el sistema y el registrado por AFIP. Contactar Administrador [AFIP: " & connAFIP.NroComprobanteAutorizado & " - SIS: " & nroFac & "]"})
                                                End If

                                                Dim concepto As EnumConceptos
                                                Dim detIvas As New List(Of Iva)
                                                Dim alicIvas As New Dictionary(Of Double, Double)
                                                Dim Prod As Boolean = False
                                                Dim Serv As Boolean = False

                                                For Each item In FacturaVentaDetalle
                                                    If alicIvas.ContainsKey(item.AlicuotaIVA) Then
                                                        alicIvas(item.AlicuotaIVA) += item.Importe
                                                    Else
                                                        alicIvas.Add(item.AlicuotaIVA, item.Importe)
                                                    End If

                                                    If item.AscArticulos.IdArticulo = 2 Then
                                                        Serv = True
                                                    End If

                                                    If item.AscArticulos.IdArticulo <> 2 Then
                                                        Prod = True
                                                    End If
                                                Next

                                                If Prod And Serv Then
                                                    concepto = EnumConceptos.Productos_Servicios
                                                ElseIf Prod Then
                                                    concepto = EnumConceptos.Productos
                                                ElseIf Serv Then
                                                    concepto = EnumConceptos.Servicios
                                                Else
                                                    Rollback()
                                                    Return New RespuestaHTTP(Of FEResultCAE)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AFIP, .Descripcion = "Ocurrio un error identificando el concepto de la factura a emitir (Prodoctos - Servicios - Productos y Servicios). Contactar Administrador"})
                                                End If

                                                For Each key In alicIvas.Keys
                                                    If Not IsNothing(UtilidadesVarias.CodIvaAFIP(key)) Then
                                                        detIvas.Add(New Iva With {
                                                            .Id = UtilidadesVarias.CodIvaAFIP(key),
                                                            .BaseImp = Math.Round(alicIvas(key), 2),
                                                            .Importe = Math.Round(alicIvas(key) * key / 100, 2)
                                                        })
                                                    Else
                                                        Return New RespuestaHTTP(Of FEResultCAE)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AFIP, .Descripcion = "El valor de %" + key + " no es una alicuota de IVA valida"})
                                                    End If
                                                Next

                                                Dim solicitud As New FERequestCAE With {
                                                    .FeCabReq = New FECabeceraRequest With {
                                                        .CantReg = 1,
                                                        .CbteTipo = UtilidadesVarias.CodComprobanteAFIP(FacturaVenta.ClaseComprobante),
                                                        .PtoVta = FacturaVenta.Prefijo.TrimStart("0")
                                                    },
                                                    .FeDetReq = New FEDetalleRequestCAE With {
                                                        .Concepto = concepto,
                                                        .DocTipo = WSAFIPFE.Factura.TipoDocumento.CUIT,
                                                        .DocNro = UtilidadesVarias.quitarGuiones(FacturaVenta.AscClientes.CUIT),
                                                        .CbteDesde = connAFIP.NroComprobanteAutorizado,
                                                        .CbteHasta = connAFIP.NroComprobanteAutorizado,
                                                        .CbteFch = UtilidadesVarias.quitarGuiones(Format(FacturaVenta.Fecha, "yyyy-MM-dd")),
                                                        .ImpTotal = Math.Round(FacturaVenta.ImporteTotal, 2),
                                                        .ImpTotConc = 0,
                                                        .ImpNeto = Math.Round(FacturaVenta.ImporteNeto, 2),
                                                        .ImpOpEx = 0,
                                                        .ImpTrib = 0,
                                                        .ImpIVA = Math.Round(FacturaVenta.Iva, 2),
                                                        .MonId = "DOL",
                                                        .MonCotiz = Math.Round(FacturaVentaMoneda.TipoCambio, 6),
                                                        .AlicIva = detIvas
                                                    }
                                                }

                                                If concepto = EnumConceptos.Productos_Servicios Or concepto = EnumConceptos.Servicios Then
                                                    solicitud.FeDetReq.FchServDesde = solicitud.FeDetReq.CbteFch
                                                    solicitud.FeDetReq.FchServHasta = solicitud.FeDetReq.CbteFch
                                                    solicitud.FeDetReq.FchVtoPago = solicitud.FeDetReq.CbteFch
                                                End If

                                                resultAFIP = New Facturacion(FE).Facturar(solicitud)
                                            Else
                                                Rollback()
                                                Return New RespuestaHTTP(Of FEResultCAE)(Nothing, empresa.Err)
                                            End If
                                        Else
                                            resultAFIP.Obtenido = True
                                            resultAFIP.DetalleResultado = "-"
                                            resultAFIP.CAE = "-"
                                            resultAFIP.FchVtoCAE = "0001-01-01"
                                        End If

                                        If resultAFIP.Obtenido Then
                                            If resultAFIP.DetalleResultado <> "R" Then
                                                FacturaVenta.CAE = resultAFIP.CAE
                                                FacturaVenta.FechaVtoCAE = CDate(Mid(resultAFIP.FchVtoCAE, 1, 4) & "/" & Mid(resultAFIP.FchVtoCAE, 5, 2) & "/" & Mid(resultAFIP.FchVtoCAE, 7, 2))
                                                FacturaVenta.IdFacturaVenta = idFac

                                                Commit()

                                                If FacturaVenta.ModificarFacturaVentaCAE() Then
                                                    Return New RespuestaHTTP(Of FEResultCAE)(resultAFIP, Nothing)
                                                Else
                                                    FacturaVenta.Err.Descripcion = "Factura autorizada por AFIP, error al grabar CAE: " + FacturaVenta.Err.Descripcion

                                                    Return New RespuestaHTTP(Of FEResultCAE)(Nothing, FacturaVenta.Err)
                                                End If
                                            Else
                                                Dim err As String

                                                If resultAFIP.Observaciones <> "" And resultAFIP.MsgError <> "" Then
                                                    err = resultAFIP.MsgError + " - " + resultAFIP.Observaciones
                                                ElseIf resultAFIP.Observaciones = "" And resultAFIP.MsgError <> "" Then
                                                    err = resultAFIP.MsgError
                                                Else
                                                    err = resultAFIP.Observaciones
                                                End If

                                                Rollback()
                                                Return New RespuestaHTTP(Of FEResultCAE)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AFIP, .Descripcion = err})
                                            End If
                                        Else
                                            Dim err As String

                                            If resultAFIP.Observaciones <> "" And resultAFIP.MsgError <> "" Then
                                                err = resultAFIP.MsgError + " - " + resultAFIP.Observaciones
                                            ElseIf resultAFIP.Observaciones = "" And resultAFIP.MsgError <> "" Then
                                                err = resultAFIP.MsgError
                                            Else
                                                err = resultAFIP.Observaciones
                                            End If

                                            Rollback()
                                            Return New RespuestaHTTP(Of FEResultCAE)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AFIP, .Descripcion = err})
                                        End If
                                    Else
                                        Rollback()
                                        Return New RespuestaHTTP(Of FEResultCAE)(Nothing, Numeracion.Err)
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of FEResultCAE)(Nothing, FacturaVentaDetalle.First.Err)
                                End If
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of FEResultCAE)(Nothing, FacturaVentaMoneda.Err)
                            End If
                        Else
                            Rollback()
                            Return New RespuestaHTTP(Of FEResultCAE)(Nothing, FacturaVenta.Err)
                        End If
                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of FEResultCAE)(Nothing, FacturaVenta.Err)
                    End If
                Else
                    Rollback()
                    Return New RespuestaHTTP(Of FEResultCAE)(Nothing, CuentaCorritenteVenta.Err)
                End If
            Else
                Rollback()
                Return New RespuestaHTTP(Of FEResultCAE)(Nothing, CuentaCorritenteVenta.Err)
            End If
        Catch ex As Exception
            If Transacciones.enTransaccion Then
                Rollback()
            End If

            Return New RespuestaHTTP(Of FEResultCAE)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = ex.Message & ex.StackTrace})
        End Try
    End Function
#End Region
End Class
