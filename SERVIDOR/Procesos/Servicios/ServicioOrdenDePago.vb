Imports AccesoDatos

Public Class ServicioOrdenDePago
    Inherits EnlaceTransacciones(Of Transacciones)

    Private _OrdenDePago As ModeloOrdenDePago
    Private _OrdenDePagoDetalle As List(Of ModeloOrdenDePagoDetalle)
    Private _CuentaCorrienteCompra As ModeloCuentaCorrienteCompra
    Private _Caja As List(Of ModeloCaja)
    Private _DetalleCheques As List(Of ModeloDetalleCheque)
    Private _MovimientoValores As List(Of ModeloMovimientoValores)
    Private _OrdenDePagoMonedas As List(Of ModeloOrdenDePagoMonedas)
    Private _Numeracion As ModeloNumeracion

#Region "CONSTRUCTORES"
    Public Sub New(ordenDePago As ModeloOrdenDePago, ordenDePagoDetalle As List(Of ModeloOrdenDePagoDetalle),
                   cuentaCorrienteCompra As ModeloCuentaCorrienteCompra, caja As List(Of ModeloCaja),
                   detalleCheques As List(Of ModeloDetalleCheque), movimientoValores As List(Of ModeloMovimientoValores),
                   ordenDePagoMonedas As List(Of ModeloOrdenDePagoMonedas), numeracion As ModeloNumeracion)
        MyBase.New(New Transacciones(), "-")

        Me.OrdenDePago = ordenDePago
        Me.OrdenDePagoDetalle = ordenDePagoDetalle
        Me.CuentaCorrienteCompra = cuentaCorrienteCompra
        Me.Caja = caja
        Me.DetalleCheques = detalleCheques
        Me.MovimientoValores = movimientoValores
        Me.OrdenDePagoMonedas = ordenDePagoMonedas
        Me.Numeracion = numeracion
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property OrdenDePago As ModeloOrdenDePago
        Get
            Return _OrdenDePago
        End Get
        Set(value As ModeloOrdenDePago)
            _OrdenDePago = value
        End Set
    End Property

    Public Property OrdenDePagoDetalle As List(Of ModeloOrdenDePagoDetalle)
        Get
            Return _OrdenDePagoDetalle
        End Get
        Set(value As List(Of ModeloOrdenDePagoDetalle))
            _OrdenDePagoDetalle = value
        End Set
    End Property

    Public Property CuentaCorrienteCompra As ModeloCuentaCorrienteCompra
        Get
            Return _CuentaCorrienteCompra
        End Get
        Set(value As ModeloCuentaCorrienteCompra)
            _CuentaCorrienteCompra = value
        End Set
    End Property

    Public Property Caja As List(Of ModeloCaja)
        Get
            Return _Caja
        End Get
        Set(value As List(Of ModeloCaja))
            _Caja = value
        End Set
    End Property

    Public Property DetalleCheques As List(Of ModeloDetalleCheque)
        Get
            Return _DetalleCheques
        End Get
        Set(value As List(Of ModeloDetalleCheque))
            _DetalleCheques = value
        End Set
    End Property

    Public Property MovimientoValores As List(Of ModeloMovimientoValores)
        Get
            Return _MovimientoValores
        End Get
        Set(value As List(Of ModeloMovimientoValores))
            _MovimientoValores = value
        End Set
    End Property

    Public Property OrdenDePagoMonedas As List(Of ModeloOrdenDePagoMonedas)
        Get
            Return _OrdenDePagoMonedas
        End Get
        Set(value As List(Of ModeloOrdenDePagoMonedas))
            _OrdenDePagoMonedas = value
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
#End Region

#Region "METODOS PUBLICOS"
    Public Function Insertar() As RespuestaHTTP(Of Boolean)
        Try
            BeginTransaction()

            If CuentaCorrienteCompra.Insertar() Then
                Dim idCtaCrt As Integer = CuentaCorrienteCompra.UltimoId()

                If Not IsNothing(idCtaCrt) Then
                    OrdenDePago.AscCuentaCorrienteCompra.IdCuentaCorrienteCompra = idCtaCrt

                    If OrdenDePago.Insertar() Then
                        Dim idOrdPag As Integer = OrdenDePago.UltimoId()

                        If Not IsNothing(idOrdPag) Then
                            For Each item In OrdenDePagoMonedas
                                item.AscOrdenDePago.IdOrdenDePago = idOrdPag

                                If Not item.Insertar() Then
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(Nothing, item.Err)
                                End If
                            Next

                            For Each item In OrdenDePagoDetalle
                                item.AscOrdenDePago.IdOrdenDePago = idOrdPag

                                If Not item.Insertar() Then
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(Nothing, item.Err)
                                End If
                            Next

                            For Each item In DetalleCheques
                                If item.Modificar() Then
                                    item.AscChequera.ChqEmitidos = 1

                                    If Not item.AscChequera.ModificarChqEmitidos() Then
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(Nothing, item.Err)
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(Nothing, item.Err)
                                End If
                            Next

                            For Each item In Caja
                                If Not item.Insertar() Then
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(Nothing, item.Err)
                                End If
                            Next

                            For Each item In MovimientoValores
                                If item.AscCaja.Insertar() Then
                                    Dim idCaj As Integer = item.AscCaja.UltimoId()

                                    If Not IsNothing(idCaj) Then
                                        item.AscCaja.IdCaja = idCaj

                                        If item.Insertar() Then
                                            item.AscValoresEnCartera.Disponible = "NO"

                                            If Not item.AscValoresEnCartera.ModificarDisponibilidad() Then
                                                Rollback()
                                                Return New RespuestaHTTP(Of Boolean)(False, item.AscValoresEnCartera.Err)
                                            End If
                                        Else
                                            Rollback()
                                            Return New RespuestaHTTP(Of Boolean)(Nothing, item.Err)
                                        End If
                                    Else
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(Nothing, item.AscCaja.Err)
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(Nothing, item.AscCaja.Err)
                                End If
                            Next

                            If Numeracion.ModificarNroOrdenDeCompra() Then
                                Commit()
                                Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of Boolean)(False, Numeracion.Err)
                            End If
                        Else
                            Rollback()
                            Return New RespuestaHTTP(Of Boolean)(Nothing, OrdenDePago.Err)
                        End If
                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(Nothing, OrdenDePago.Err)
                    End If
                Else
                    Rollback()
                    Return New RespuestaHTTP(Of Boolean)(Nothing, CuentaCorrienteCompra.Err)
                End If
            Else
                Rollback()
                Return New RespuestaHTTP(Of Boolean)(Nothing, CuentaCorrienteCompra.Err)
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
            Dim verificarNoEliminado As ModeloOrdenDePago = OrdenDePago.ConsultarPorId()

            If verificarNoEliminado.Err.Identificador = EnumErrores.OK Then
                BeginTransaction()

                OrdenDePago.NroComprobante = verificarNoEliminado.NroComprobante
                OrdenDePagoMonedas.First.AscOrdenDePago.IdOrdenDePago = OrdenDePago.IdOrdenDePago

                If OrdenDePagoMonedas.First.EliminarPorIdOrdenDePago() Then
                    OrdenDePagoDetalle.First.AscOrdenDePago.IdOrdenDePago = OrdenDePago.IdOrdenDePago

                    If OrdenDePagoDetalle.First.EliminarPorIdOrdenDePago() Then

                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(Nothing, OrdenDePagoDetalle.First.Err)
                    End If
                Else
                    Rollback()
                    Return New RespuestaHTTP(Of Boolean)(Nothing, OrdenDePagoMonedas.First.Err)
                End If

                'Dim listaDetPedido As List(Of ModeloOrdenDePagoDetalle) = OrdenDePagoDetalle.ListadoPorIdPedidos()

                'If Not IsNothing(listaDetPedido) Then
                '    For Each item In listaDetPedido
                '        Dim pedMov As New ModeloPedidoMovimientos With {.AscPedidosDetalle = New ModeloPedidoDetalle With {.IdPedidosDetalle = item.IdPedidosDetalle}, .Tipo = "RESERVA"}
                '        Dim listaPedMov As List(Of ModeloPedidoMovimientos) = pedMov.ListadoPorIdPedidosDetalleTipo()

                '        If Not IsNothing(listaPedMov) Then
                '            For Each itemMov In listaPedMov
                '                If itemMov.AscStock.Eliminar() Then
                '                    If Not itemMov.Eliminar() Then
                '                        Rollback()
                '                        Return New RespuestaHTTP(Of Boolean)(Nothing, itemMov.Err)
                '                    End If
                '                Else
                '                    Rollback()
                '                    Return New RespuestaHTTP(Of Boolean)(Nothing, itemMov.AscStock.Err)
                '                End If
                '            Next
                '        Else
                '            Rollback()
                '            Return New RespuestaHTTP(Of Boolean)(Nothing, pedMov.Err)
                '        End If
                '    Next

                '    If DetallePedido.EliminarPorIdPedido() Then
                '        If Pedido.Eliminar() Then
                '            Commit()
                '            Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                '        Else
                '            Rollback()
                '            Return New RespuestaHTTP(Of Boolean)(Nothing, Pedido.Err)
                '        End If
                '    Else
                '        Rollback()
                '        Return New RespuestaHTTP(Of Boolean)(Nothing, DetallePedido.Err)
                '    End If
                'Else
                '    Rollback()
                '    Return New RespuestaHTTP(Of Boolean)(Nothing, DetallePedido.Err)
                'End If

            ElseIf verificarNoEliminado.Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO Then
                Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.OPERACION_SIMULTANEA_TERMINANTE, .Descripcion = "La Orden de Pago que intentas eliminar ya fue eliminada por otro usuario."})
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
