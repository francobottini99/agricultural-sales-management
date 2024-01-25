Imports AccesoDatos

Public Class ServicioDevoluciones
    Inherits EnlaceTransacciones(Of Transacciones)

    Private _Devoluciones As ModeloDevoluciones
    Private _CuentaCorritenteVenta As ModeloCuentaCorrienteVenta
    Private _Numeracion As ModeloNumeracion
    Private _Stock As List(Of ModeloStock)
    Private _DetallesDevoluciones As List(Of ModeloDetalleDevoluciones)
    Private _RemitosVentaMovimientos As List(Of ModeloRemitosVentaMovimientos)
    Private _FacturaVentaMovimientos As List(Of ModeloFacturaVentaMovimientos)
    Private _Movimientos_Remito_Factura As List(Of ModeloMovimientos_Remito_Factura)


#Region "CONSTRUCTORES"
    Public Sub New(devoluciones As ModeloDevoluciones, cuentaCorritenteVenta As ModeloCuentaCorrienteVenta, numeracion As ModeloNumeracion, stock As List(Of ModeloStock),
                   detallesDevoluciones As List(Of ModeloDetalleDevoluciones), remitosVentaMovimientos As List(Of ModeloRemitosVentaMovimientos),
                   facturaVentaMovimientos As List(Of ModeloFacturaVentaMovimientos), movimientos_Remito_Factura As List(Of ModeloMovimientos_Remito_Factura))
        MyBase.New(New Transacciones(), "-")

        Me.Devoluciones = devoluciones
        Me.Numeracion = numeracion
        Me.DetallesDevoluciones = detallesDevoluciones
        Me.RemitosVentaMovimientos = remitosVentaMovimientos
        Me.FacturaVentaMovimientos = facturaVentaMovimientos
        Me.Movimientos_Remito_Factura = movimientos_Remito_Factura
        Me.CuentaCorritenteVenta = cuentaCorritenteVenta
        Me.Stock = stock
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property Devoluciones As ModeloDevoluciones
        Get
            Return _Devoluciones
        End Get
        Set(value As ModeloDevoluciones)
            _Devoluciones = value
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

    Public Property DetallesDevoluciones As List(Of ModeloDetalleDevoluciones)
        Get
            Return _DetallesDevoluciones
        End Get
        Set(value As List(Of ModeloDetalleDevoluciones))
            _DetallesDevoluciones = value
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

    Public Property FacturaVentaMovimientos As List(Of ModeloFacturaVentaMovimientos)
        Get
            Return _FacturaVentaMovimientos
        End Get
        Set(value As List(Of ModeloFacturaVentaMovimientos))
            _FacturaVentaMovimientos = value
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

    Public Property CuentaCorritenteVenta As ModeloCuentaCorrienteVenta
        Get
            Return _CuentaCorritenteVenta
        End Get
        Set(value As ModeloCuentaCorrienteVenta)
            _CuentaCorritenteVenta = value
        End Set
    End Property

    Public Property Stock As List(Of ModeloStock)
        Get
            Return _Stock
        End Get
        Set(value As List(Of ModeloStock))
            _Stock = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS"
    Public Function Insertar() As RespuestaHTTP(Of Boolean)
        Try
            BeginTransaction()

            If Devoluciones.Insertar() Then
                Dim devUltId As Integer = Devoluciones.UltimoId()

                If Not IsNothing(devUltId) Then
                    For i As Integer = 0 To DetallesDevoluciones.Count - 1
                        DetallesDevoluciones(i).AscDevoluciones.IdDevoluciones = devUltId

                        If DetallesDevoluciones(i).Insertar() Then
                            If Stock(i).Insertar() Then
                                Dim StkUltId As Integer = Stock(i).UltimoId()

                                If Not IsNothing(StkUltId) Then
                                    If RemitosVentaMovimientos(i).AscDetalleRemitoVenta.IdDetalleRemitosVenta <> 0 Then
                                        RemitosVentaMovimientos(i).AscStock.IdStock = StkUltId

                                        If Not RemitosVentaMovimientos(i).Insertar() Then
                                            'Dim ultIdRemMov As Integer = RemitosVentaMovimientos(i).UltimoId()

                                            'If Not IsNothing(ultIdRemMov) Then
                                            '    Dim listRemMov As List(Of ModeloRemitosVentaMovimientos) = RemitosVentaMovimientos(i).ListasdoPorIdDetalleRemitosVenta()

                                            '    If Not IsNothing(listRemMov) Then
                                            '        For j As Integer = 0 To listRemMov.Count - 1
                                            '            If listRemMov(j).Tipo = "FACTURADO" Then
                                            '                Dim facMov As New ModeloFacturaVentaMovimientos With {
                                            '                    .Fecha = RemitosVentaMovimientos(i).Fecha,
                                            '                    .Tipo = "DEVOLUCION",
                                            '                    .Cantidad = RemitosVentaMovimientos(i).Cantidad,
                                            '                    .Eliminado = "NO",
                                            '                    .AscUsuarios = Devoluciones.AscUsuarios,
                                            '                    .AscFacturaVentaDetalle = RemitosVentaMovimientos(i).AscDetalleRemitoVenta
                                            '                }

                                            '                Exit For
                                            '            ElseIf listRemMov(j).Tipo = "REMITADO" Then
                                            '                Dim listRemResMov As List(Of ModeloMovimientos_Reserva_Remito)

                                            '            End If
                                            '        Next
                                            '    Else
                                            '        Rollback()
                                            '        Return New RespuestaHTTP(Of Boolean)(False, RemitosVentaMovimientos(i).Err)
                                            '    End If
                                            'Else
                                            '    Rollback()
                                            '    Return New RespuestaHTTP(Of Boolean)(False, RemitosVentaMovimientos(i).Err)
                                            'End If
                                            'Else

                                            Rollback()
                                            Return New RespuestaHTTP(Of Boolean)(False, RemitosVentaMovimientos(i).Err)
                                        End If
                                    ElseIf FacturaVentaMovimientos(i).AscFacturaVentaDetalle.IdFacturaVentaDetalle <> 0 Then
                                        If Not FacturaVentaMovimientos(i).Insertar() Then

                                        End If
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(False, RemitosVentaMovimientos(i).Err)
                                End If
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of Boolean)(False, DetallesDevoluciones(i).Err)
                            End If
                        Else
                            Rollback()
                            Return New RespuestaHTTP(Of Boolean)(False, DetallesDevoluciones(i).Err)
                        End If
                    Next

                    If Numeracion.ModificarNroDevolucion() Then
                        Commit()
                        Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(False, Numeracion.Err)
                    End If
                Else
                    Rollback()
                    Return New RespuestaHTTP(Of Boolean)(False, Devoluciones.Err)
                End If
            Else
                Rollback()
                Return New RespuestaHTTP(Of Boolean)(False, Devoluciones.Err)
            End If
        Catch ex As Exception
            If Transacciones.enTransaccion Then
                Rollback()
            End If

            Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message & ex.StackTrace})
        End Try
    End Function
#End Region
End Class
