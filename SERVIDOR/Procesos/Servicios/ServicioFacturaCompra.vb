Imports AccesoDatos

Public Class ServicioFacturaCompra
    Inherits EnlaceTransacciones(Of Transacciones)

    Private _FacturaCompra As ModeloFacturaCompra
    Private _CuentaCorritenteCompra As ModeloCuentaCorrienteCompra
    Private _FacturaCompraMoneda As ModeloFacturaComMonedas
    Private _FacturaCompraDetalle As List(Of ModeloFacturaCompraDetalle)
    Private _Movimientos_Remito_Factura As List(Of ModeloMovimientos_RemitoCompra_FacturaCompra)
    Private _RemitosCompraMovimientos As List(Of ModeloRemitosCompraMovimientos)
    Private _FacturaCompraMovimientos As List(Of ModeloFacturaCompraMovimientos)

#Region "CONSTRUCTORES"
    Public Sub New(facturaCompra As ModeloFacturaCompra, cuentaCorritenteCompra As ModeloCuentaCorrienteCompra, facturaCompraMoneda As ModeloFacturaComMonedas, facturaCompraDetalle As List(Of ModeloFacturaCompraDetalle), movimientos_Remito_Factura As List(Of ModeloMovimientos_RemitoCompra_FacturaCompra), remitosCompraMovimientos As List(Of ModeloRemitosCompraMovimientos), facturaCompraMovimientos As List(Of ModeloFacturaCompraMovimientos))
        MyBase.New(New Transacciones(), "-")

        Me.FacturaCompra = facturaCompra
        Me.CuentaCorritenteCompra = cuentaCorritenteCompra
        Me.FacturaCompraMoneda = facturaCompraMoneda
        Me.FacturaCompraDetalle = facturaCompraDetalle
        Me.Movimientos_Remito_Factura = movimientos_Remito_Factura
        Me.RemitosCompraMovimientos = remitosCompraMovimientos
        Me.FacturaCompraMovimientos = facturaCompraMovimientos
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property FacturaCompra As ModeloFacturaCompra
        Get
            Return _FacturaCompra
        End Get
        Set(value As ModeloFacturaCompra)
            _FacturaCompra = value
        End Set
    End Property

    Public Property CuentaCorritenteCompra As ModeloCuentaCorrienteCompra
        Get
            Return _CuentaCorritenteCompra
        End Get
        Set(value As ModeloCuentaCorrienteCompra)
            _CuentaCorritenteCompra = value
        End Set
    End Property

    Public Property FacturaCompraMoneda As ModeloFacturaComMonedas
        Get
            Return _FacturaCompraMoneda
        End Get
        Set(value As ModeloFacturaComMonedas)
            _FacturaCompraMoneda = value
        End Set
    End Property

    Public Property FacturaCompraDetalle As List(Of ModeloFacturaCompraDetalle)
        Get
            Return _FacturaCompraDetalle
        End Get
        Set(value As List(Of ModeloFacturaCompraDetalle))
            _FacturaCompraDetalle = value
        End Set
    End Property

    Public Property Movimientos_Remito_Factura As List(Of ModeloMovimientos_RemitoCompra_FacturaCompra)
        Get
            Return _Movimientos_Remito_Factura
        End Get
        Set(value As List(Of ModeloMovimientos_RemitoCompra_FacturaCompra))
            _Movimientos_Remito_Factura = value
        End Set
    End Property

    Public Property RemitosCompraMovimientos As List(Of ModeloRemitosCompraMovimientos)
        Get
            Return _RemitosCompraMovimientos
        End Get
        Set(value As List(Of ModeloRemitosCompraMovimientos))
            _RemitosCompraMovimientos = value
        End Set
    End Property

    Public Property FacturaCompraMovimientos As List(Of ModeloFacturaCompraMovimientos)
        Get
            Return _FacturaCompraMovimientos
        End Get
        Set(value As List(Of ModeloFacturaCompraMovimientos))
            _FacturaCompraMovimientos = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS"
    Public Function Insertar() As RespuestaHTTP(Of Boolean)
        Try
            BeginTransaction()

            If CuentaCorritenteCompra.Insertar() Then
                Dim idCtaCrt As Integer = CuentaCorritenteCompra.UltimoId()

                If Not IsNothing(idCtaCrt) Then
                    FacturaCompra.AscCuentaCorrienteCompra.IdCuentaCorrienteCompra = idCtaCrt

                    If FacturaCompra.Insertar() Then
                        Dim UltIdFac As Integer = FacturaCompra.UltimoId()

                        If Not IsNothing(UltIdFac) Then
                            FacturaCompraMoneda.AscFacturaCompra.IdFacturaCompra = UltIdFac

                            If FacturaCompraMoneda.Insertar() Then
                                For i As Integer = 0 To FacturaCompraDetalle.Count - 1
                                    FacturaCompraDetalle(i).AscFacturaCompra.IdFacturaCompra = UltIdFac

                                    If FacturaCompraDetalle(i).AscArticulos.IdArticulo = 2 Then
                                        FacturaCompraDetalle(i).Remitado = "-"
                                    End If

                                    If FacturaCompraDetalle(i).Insertar() Then
                                        If FacturaCompraDetalle(i).AscArticulos.IdArticulo <> 2 Then
                                            Dim detFacUltId As Integer = FacturaCompraDetalle(i).UltimoId()

                                            If Not IsNothing(detFacUltId) Then
                                                FacturaCompraMovimientos(i).AscFacturaCompraDetalle.IdFacturaCompraDetalle = detFacUltId

                                                If FacturaCompraMovimientos(i).Insertar() Then
                                                    Dim facComMovUltId As Integer = FacturaCompraMovimientos(i).UltimoId()

                                                    If Not IsNothing(facComMovUltId) Then
                                                        If RemitosCompraMovimientos(i).AscDetalleRemtioCompra.IdDetalleRemitosCompra <> 0 Then
                                                            RemitosCompraMovimientos(i).AscStock.IdStock = 1

                                                            If RemitosCompraMovimientos(i).Insertar() Then
                                                                Dim remComMovUltId As Integer = RemitosCompraMovimientos(i).UltimoId()

                                                                If Not IsNothing(remComMovUltId) Then
                                                                    Movimientos_Remito_Factura(i).AscRemitosCompraMovimientos.IdRemitosCompraMovimientos = remComMovUltId
                                                                    Movimientos_Remito_Factura(i).AscFacturaCompraMovimientos.IdFacturaCompraMovimientos = facComMovUltId

                                                                    If Movimientos_Remito_Factura(i).Insertar() Then
                                                                        FacturaCompraMovimientos(i).AscFacturaCompraDetalle.Remitado = "SI"

                                                                        If FacturaCompraMovimientos(i).AscFacturaCompraDetalle.ModificarRemitado() Then
                                                                            Dim remCanFac As Double = RemitosCompraMovimientos(i).CantidadFacturada()

                                                                            If Not IsNothing(remCanFac) Then
                                                                                Dim remCanDev As Double = RemitosCompraMovimientos(i).CantidadDevuelta()

                                                                                If Not IsNothing(remCanDev) Then
                                                                                    Dim remCanRem As Double = RemitosCompraMovimientos(i).CantidadRemitada()

                                                                                    If Not IsNothing(remCanRem) Then
                                                                                        If remCanFac = remCanDev + remCanRem Then
                                                                                            RemitosCompraMovimientos(i).AscDetalleRemtioCompra.Facturado = "SI"

                                                                                            If RemitosCompraMovimientos(i).AscDetalleRemtioCompra.ModificarEstadoFacturacion() Then
                                                                                                Dim detalleRemito As List(Of ModeloDetalleRemitoCompra) = RemitosCompraMovimientos(i).AscDetalleRemtioCompra.ListasdoPorIdRemitosCompra()

                                                                                                If Not IsNothing(detalleRemito) Then
                                                                                                    Dim Facturado As Boolean = True

                                                                                                    For Each item In detalleRemito
                                                                                                        If item.Facturado = "NO" Then
                                                                                                            Facturado = False
                                                                                                            Exit For
                                                                                                        End If
                                                                                                    Next

                                                                                                    If Facturado Then
                                                                                                        RemitosCompraMovimientos(i).AscDetalleRemtioCompra.AscRemitosCompra.Facturado = "SI"

                                                                                                        If Not RemitosCompraMovimientos(i).AscDetalleRemtioCompra.AscRemitosCompra.ModificarEstadoFacturacion() Then
                                                                                                            Rollback()
                                                                                                            Return New RespuestaHTTP(Of Boolean)(Nothing, RemitosCompraMovimientos(i).AscDetalleRemtioCompra.AscRemitosCompra.Err)
                                                                                                        End If
                                                                                                    End If
                                                                                                Else
                                                                                                    Rollback()
                                                                                                    Return New RespuestaHTTP(Of Boolean)(Nothing, RemitosCompraMovimientos(i).AscDetalleRemtioCompra.Err)
                                                                                                End If
                                                                                            Else
                                                                                                Rollback()
                                                                                                Return New RespuestaHTTP(Of Boolean)(Nothing, RemitosCompraMovimientos(i).AscDetalleRemtioCompra.Err)
                                                                                            End If
                                                                                        ElseIf remCanFac > remCanDev + remCanRem Then
                                                                                            Rollback()
                                                                                            Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.OPERACION_SIMULTANEA_NO_TERMINANTE, .Descripcion = "El item """ & FacturaCompraDetalle(i).Descripcion & """ de la factura ya fue parcial o completamente facturado por otro usuario."})
                                                                                        End If
                                                                                    Else
                                                                                        Rollback()
                                                                                        Return New RespuestaHTTP(Of Boolean)(Nothing, Movimientos_Remito_Factura(i).AscRemitosCompraMovimientos.Err)
                                                                                    End If
                                                                                Else
                                                                                    Rollback()
                                                                                    Return New RespuestaHTTP(Of Boolean)(Nothing, Movimientos_Remito_Factura(i).AscRemitosCompraMovimientos.Err)
                                                                                End If
                                                                            Else
                                                                                Rollback()
                                                                                Return New RespuestaHTTP(Of Boolean)(Nothing, Movimientos_Remito_Factura(i).Err)
                                                                            End If
                                                                        Else
                                                                            Rollback()
                                                                            Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompraMovimientos(i).AscFacturaCompraDetalle.Err)
                                                                        End If
                                                                    Else
                                                                        Rollback()
                                                                        Return New RespuestaHTTP(Of Boolean)(Nothing, Movimientos_Remito_Factura(i).Err)
                                                                    End If
                                                                Else
                                                                    Rollback()
                                                                    Return New RespuestaHTTP(Of Boolean)(Nothing, RemitosCompraMovimientos(i).Err)
                                                                End If
                                                            Else
                                                                Rollback()
                                                                Return New RespuestaHTTP(Of Boolean)(Nothing, RemitosCompraMovimientos(i).Err)
                                                            End If
                                                        End If
                                                    Else
                                                        Rollback()
                                                        Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompraMovimientos(i).Err)
                                                    End If
                                                Else
                                                    Rollback()
                                                    Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompraMovimientos(i).Err)
                                                End If
                                            Else
                                                Rollback()
                                                Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompraDetalle(i).Err)
                                            End If
                                        End If
                                    Else
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompraDetalle(i).AscFacturaCompra.Err)
                                    End If
                                Next

                                Dim detalleFactura As List(Of ModeloFacturaCompraDetalle) = FacturaCompraDetalle.First.ListadoPorIdFacturaCompra()

                                If Not IsNothing(detalleFactura) Then
                                    Dim remitada As Boolean = True

                                    For Each item In detalleFactura
                                        If item.Remitado = "NO" Then
                                            remitada = False
                                        End If
                                    Next

                                    If remitada Then
                                        FacturaCompra.IdFacturaCompra = UltIdFac
                                        FacturaCompra.Remitado = "SI"

                                        If Not FacturaCompra.ModificarEstadoRemitado() Then
                                            Rollback()
                                            Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompra.Err)
                                        End If
                                    End If

                                    Commit()
                                    Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompraDetalle.First.Err)
                                End If
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompraMoneda.Err)
                            End If
                        Else
                            Rollback()
                            Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompra.Err)
                        End If
                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompra.Err)
                    End If
                Else
                    Rollback()
                    Return New RespuestaHTTP(Of Boolean)(Nothing, CuentaCorritenteCompra.Err)
                End If
            Else
                Rollback()
                Return New RespuestaHTTP(Of Boolean)(Nothing, CuentaCorritenteCompra.Err)
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
            Dim verificarNoEliminado As ModeloFacturaCompra = FacturaCompra.ConsultarPorId()

            If verificarNoEliminado.Err.Identificador = EnumErrores.OK Then
                Dim facComMov As New ModeloFacturaCompraMovimientos With {.AscFacturaCompraDetalle = New ModeloFacturaCompraDetalle With {.AscFacturaCompra = New ModeloFacturaCompra With {.IdFacturaCompra = FacturaCompra.IdFacturaCompra}}}
                Dim movRemFac As New ModeloMovimientos_RemitoCompra_FacturaCompra With {.AscFacturaCompraMovimientos = New ModeloFacturaCompraMovimientos With {.AscFacturaCompraDetalle = New ModeloFacturaCompraDetalle With {.AscFacturaCompra = New ModeloFacturaCompra With {.IdFacturaCompra = FacturaCompra.IdFacturaCompra}}}}
                Dim detFacCom As New ModeloFacturaCompraDetalle With {.AscFacturaCompra = New ModeloFacturaCompra With {.IdFacturaCompra = FacturaCompra.IdFacturaCompra}}

                BeginTransaction()

                If CuentaCorritenteCompra.Eliminar() Then
                    If FacturaCompraMoneda.EliminarPorIdFacturaCompra() Then
                        Dim listRemFacMov As List(Of ModeloMovimientos_RemitoCompra_FacturaCompra) = movRemFac.ListasdoPorIdFacturaCompra()

                        If Not IsNothing(listRemFacMov) Then
                            For Each item In listRemFacMov
                                item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.Facturado = "NO"

                                If item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.ModificarEstadoFacturacion() Then
                                    item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.AscRemitosCompra.Facturado = "NO"

                                    If item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.AscRemitosCompra.ModificarEstadoFacturacion() Then
                                        item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.Remitado = "NO"

                                        If item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.ModificarRemitado() Then
                                            If item.Tipo = "FACTURADO" Then
                                                If item.AscRemitosCompraMovimientos.Eliminar() Then
                                                    If Not item.Eliminar() Then
                                                        Rollback()
                                                        Return New RespuestaHTTP(Of Boolean)(False, item.Err)
                                                    End If
                                                Else
                                                    Rollback()
                                                    Return New RespuestaHTTP(Of Boolean)(False, item.AscRemitosCompraMovimientos.Err)
                                                End If
                                            End If
                                        Else
                                            Rollback()
                                            Return New RespuestaHTTP(Of Boolean)(False, item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.Err)
                                        End If
                                    Else
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(False, item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.AscRemitosCompra.Err)
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(False, item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.Err)
                                End If
                            Next
                        ElseIf movRemFac.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                            Rollback()
                            Return New RespuestaHTTP(Of Boolean)(False, movRemFac.Err)
                        End If

                        Dim listFacComMov As List(Of ModeloFacturaCompraMovimientos) = facComMov.ListasdoPorIdFacturaCompra()

                        If Not IsNothing(listFacComMov) Then
                            For Each item In listFacComMov
                                If item.Tipo = "FACTURADO" Then
                                    If Not item.Eliminar() Then
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(False, item.Err)
                                    End If
                                End If
                            Next
                        ElseIf facComMov.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                            Rollback()
                            Return New RespuestaHTTP(Of Boolean)(False, facComMov.Err)
                        End If

                        If detFacCom.EliminarPorIdFacturaCompra() Then
                            If CuentaCorritenteCompra.Insertar() Then
                                Dim idCtaCrt As Integer = CuentaCorritenteCompra.UltimoId()

                                If Not IsNothing(idCtaCrt) Then
                                    FacturaCompra.AscCuentaCorrienteCompra.IdCuentaCorrienteCompra = idCtaCrt

                                    If FacturaCompra.Modificar() Then
                                        Dim UltIdFac As Integer = FacturaCompra.UltimoId()

                                        If Not IsNothing(UltIdFac) Then
                                            FacturaCompraMoneda.AscFacturaCompra.IdFacturaCompra = UltIdFac

                                            If FacturaCompraMoneda.Insertar() Then
                                                For i As Integer = 0 To FacturaCompraDetalle.Count - 1
                                                    FacturaCompraDetalle(i).AscFacturaCompra.IdFacturaCompra = UltIdFac

                                                    If FacturaCompraDetalle(i).AscArticulos.IdArticulo = 2 Then
                                                        FacturaCompraDetalle(i).Remitado = "-"
                                                    End If

                                                    If FacturaCompraDetalle(i).Insertar() Then
                                                        If FacturaCompraDetalle(i).AscArticulos.IdArticulo <> 2 Then
                                                            Dim detFacUltId As Integer = FacturaCompraDetalle(i).UltimoId()

                                                            If Not IsNothing(detFacUltId) Then
                                                                FacturaCompraMovimientos(i).AscFacturaCompraDetalle.IdFacturaCompraDetalle = detFacUltId

                                                                If FacturaCompraMovimientos(i).Insertar() Then
                                                                    Dim facComMovUltId As Integer = FacturaCompraMovimientos(i).UltimoId()

                                                                    If Not IsNothing(facComMovUltId) Then
                                                                        If RemitosCompraMovimientos(i).AscDetalleRemtioCompra.IdDetalleRemitosCompra <> 0 Then
                                                                            RemitosCompraMovimientos(i).AscStock.IdStock = 1

                                                                            If RemitosCompraMovimientos(i).Insertar() Then
                                                                                Dim remComMovUltId As Integer = RemitosCompraMovimientos(i).UltimoId()

                                                                                If Not IsNothing(remComMovUltId) Then
                                                                                    Movimientos_Remito_Factura(i).AscRemitosCompraMovimientos.IdRemitosCompraMovimientos = remComMovUltId
                                                                                    Movimientos_Remito_Factura(i).AscFacturaCompraMovimientos.IdFacturaCompraMovimientos = facComMovUltId

                                                                                    If Movimientos_Remito_Factura(i).Insertar() Then
                                                                                        FacturaCompraMovimientos(i).AscFacturaCompraDetalle.Remitado = "SI"

                                                                                        If FacturaCompraMovimientos(i).AscFacturaCompraDetalle.ModificarRemitado() Then
                                                                                            Dim remCanFac As Double = RemitosCompraMovimientos(i).CantidadFacturada()

                                                                                            If Not IsNothing(remCanFac) Then
                                                                                                Dim remCanDev As Double = RemitosCompraMovimientos(i).CantidadDevuelta()

                                                                                                If Not IsNothing(remCanDev) Then
                                                                                                    Dim remCanRem As Double = RemitosCompraMovimientos(i).CantidadRemitada()

                                                                                                    If Not IsNothing(remCanRem) Then
                                                                                                        If remCanFac = remCanDev + remCanRem Then
                                                                                                            RemitosCompraMovimientos(i).AscDetalleRemtioCompra.Facturado = "SI"

                                                                                                            If RemitosCompraMovimientos(i).AscDetalleRemtioCompra.ModificarEstadoFacturacion() Then
                                                                                                                Dim detalleRemito As List(Of ModeloDetalleRemitoCompra) = RemitosCompraMovimientos(i).AscDetalleRemtioCompra.ListasdoPorIdRemitosCompra()

                                                                                                                If Not IsNothing(detalleRemito) Then
                                                                                                                    Dim Facturado As Boolean = True

                                                                                                                    For Each item In detalleRemito
                                                                                                                        If item.Facturado = "NO" Then
                                                                                                                            Facturado = False
                                                                                                                            Exit For
                                                                                                                        End If
                                                                                                                    Next

                                                                                                                    If Facturado Then
                                                                                                                        RemitosCompraMovimientos(i).AscDetalleRemtioCompra.AscRemitosCompra.Facturado = "SI"

                                                                                                                        If Not RemitosCompraMovimientos(i).AscDetalleRemtioCompra.AscRemitosCompra.ModificarEstadoFacturacion() Then
                                                                                                                            Rollback()
                                                                                                                            Return New RespuestaHTTP(Of Boolean)(Nothing, RemitosCompraMovimientos(i).AscDetalleRemtioCompra.AscRemitosCompra.Err)
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                Else
                                                                                                                    Rollback()
                                                                                                                    Return New RespuestaHTTP(Of Boolean)(Nothing, RemitosCompraMovimientos(i).AscDetalleRemtioCompra.Err)
                                                                                                                End If
                                                                                                            Else
                                                                                                                Rollback()
                                                                                                                Return New RespuestaHTTP(Of Boolean)(Nothing, RemitosCompraMovimientos(i).AscDetalleRemtioCompra.Err)
                                                                                                            End If
                                                                                                        ElseIf remCanFac > remCanDev + remCanRem Then
                                                                                                            Rollback()
                                                                                                            Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.OPERACION_SIMULTANEA_NO_TERMINANTE, .Descripcion = "El item """ & FacturaCompraDetalle(i).Descripcion & """ de la factura ya fue parcial o completamente facturado por otro usuario."})
                                                                                                        End If
                                                                                                    Else
                                                                                                        Rollback()
                                                                                                        Return New RespuestaHTTP(Of Boolean)(Nothing, Movimientos_Remito_Factura(i).AscRemitosCompraMovimientos.Err)
                                                                                                    End If
                                                                                                Else
                                                                                                    Rollback()
                                                                                                    Return New RespuestaHTTP(Of Boolean)(Nothing, Movimientos_Remito_Factura(i).AscRemitosCompraMovimientos.Err)
                                                                                                End If
                                                                                            Else
                                                                                                Rollback()
                                                                                                Return New RespuestaHTTP(Of Boolean)(Nothing, Movimientos_Remito_Factura(i).Err)
                                                                                            End If
                                                                                        Else
                                                                                            Rollback()
                                                                                            Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompraMovimientos(i).AscFacturaCompraDetalle.Err)
                                                                                        End If
                                                                                    Else
                                                                                        Rollback()
                                                                                        Return New RespuestaHTTP(Of Boolean)(Nothing, Movimientos_Remito_Factura(i).Err)
                                                                                    End If
                                                                                Else
                                                                                    Rollback()
                                                                                    Return New RespuestaHTTP(Of Boolean)(Nothing, RemitosCompraMovimientos(i).Err)
                                                                                End If
                                                                            Else
                                                                                Rollback()
                                                                                Return New RespuestaHTTP(Of Boolean)(Nothing, RemitosCompraMovimientos(i).Err)
                                                                            End If
                                                                        End If
                                                                    Else
                                                                        Rollback()
                                                                        Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompraMovimientos(i).Err)
                                                                    End If
                                                                Else
                                                                    Rollback()
                                                                    Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompraMovimientos(i).Err)
                                                                End If
                                                            Else
                                                                Rollback()
                                                                Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompraDetalle(i).Err)
                                                            End If
                                                        End If
                                                    Else
                                                        Rollback()
                                                        Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompraDetalle(i).AscFacturaCompra.Err)
                                                    End If
                                                Next

                                                Dim detalleFactura As List(Of ModeloFacturaCompraDetalle) = FacturaCompraDetalle.First.ListadoPorIdFacturaCompra()

                                                If Not IsNothing(detalleFactura) Then
                                                    Dim remitada As Boolean = True

                                                    For Each item In detalleFactura
                                                        If item.Remitado = "NO" Then
                                                            remitada = False
                                                        End If
                                                    Next

                                                    If remitada Then
                                                        FacturaCompra.IdFacturaCompra = UltIdFac
                                                        FacturaCompra.Remitado = "SI"

                                                        If Not FacturaCompra.ModificarEstadoRemitado() Then
                                                            Rollback()
                                                            Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompra.Err)
                                                        End If
                                                    End If

                                                    Commit()
                                                    Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                                                Else
                                                    Rollback()
                                                    Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompraDetalle.First.Err)
                                                End If
                                            Else
                                                Rollback()
                                                Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompraMoneda.Err)
                                            End If
                                        Else
                                            Rollback()
                                            Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompra.Err)
                                        End If
                                    Else
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompra.Err)
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(Nothing, CuentaCorritenteCompra.Err)
                                End If
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of Boolean)(Nothing, CuentaCorritenteCompra.Err)
                            End If
                        Else
                            Rollback()
                            Return New RespuestaHTTP(Of Boolean)(Nothing, detFacCom.Err)
                        End If
                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompraMoneda.Err)
                    End If
                Else
                    Rollback()
                    Return New RespuestaHTTP(Of Boolean)(Nothing, CuentaCorritenteCompra.Err)
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
            Dim verificarNoEliminado As ModeloFacturaCompra = FacturaCompra.ConsultarPorId()

            If verificarNoEliminado.Err.Identificador = EnumErrores.OK Then
                Dim facComMov As New ModeloFacturaCompraMovimientos With {.AscFacturaCompraDetalle = New ModeloFacturaCompraDetalle With {.AscFacturaCompra = New ModeloFacturaCompra With {.IdFacturaCompra = FacturaCompra.IdFacturaCompra}}}
                Dim movRemFac As New ModeloMovimientos_RemitoCompra_FacturaCompra With {.AscFacturaCompraMovimientos = New ModeloFacturaCompraMovimientos With {.AscFacturaCompraDetalle = New ModeloFacturaCompraDetalle With {.AscFacturaCompra = New ModeloFacturaCompra With {.IdFacturaCompra = FacturaCompra.IdFacturaCompra}}}}
                Dim detFacCom As New ModeloFacturaCompraDetalle With {.AscFacturaCompra = New ModeloFacturaCompra With {.IdFacturaCompra = FacturaCompra.IdFacturaCompra}}

                BeginTransaction()

                If CuentaCorritenteCompra.Eliminar() Then
                    If FacturaCompraMoneda.EliminarPorIdFacturaCompra() Then
                        Dim listRemFacMov As List(Of ModeloMovimientos_RemitoCompra_FacturaCompra) = movRemFac.ListasdoPorIdFacturaCompra()

                        If Not IsNothing(listRemFacMov) Then
                            For Each item In listRemFacMov
                                item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.Facturado = "NO"

                                If item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.ModificarEstadoFacturacion() Then
                                    item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.AscRemitosCompra.Facturado = "NO"

                                    If item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.AscRemitosCompra.ModificarEstadoFacturacion() Then
                                        item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.Remitado = "NO"

                                        If item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.ModificarRemitado() Then
                                            If item.Tipo = "FACTURADO" Then
                                                If item.AscRemitosCompraMovimientos.Eliminar() Then
                                                    If Not item.Eliminar() Then
                                                        Rollback()
                                                        Return New RespuestaHTTP(Of Boolean)(False, item.Err)
                                                    End If
                                                Else
                                                    Rollback()
                                                    Return New RespuestaHTTP(Of Boolean)(False, item.AscRemitosCompraMovimientos.Err)
                                                End If
                                            End If
                                        Else
                                            Rollback()
                                            Return New RespuestaHTTP(Of Boolean)(False, item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.Err)
                                        End If
                                    Else
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(False, item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.AscRemitosCompra.Err)
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(False, item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.Err)
                                End If
                            Next
                        ElseIf movRemFac.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                            Rollback()
                            Return New RespuestaHTTP(Of Boolean)(False, movRemFac.Err)
                        End If

                        Dim listFacComMov As List(Of ModeloFacturaCompraMovimientos) = facComMov.ListasdoPorIdFacturaCompra()

                        If Not IsNothing(listFacComMov) Then
                            For Each item In listFacComMov
                                If item.Tipo = "FACTURADO" Then
                                    If Not item.Eliminar() Then
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(False, item.Err)
                                    End If
                                End If
                            Next
                        ElseIf facComMov.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                            Rollback()
                            Return New RespuestaHTTP(Of Boolean)(False, facComMov.Err)
                        End If

                        Dim detalleFactura As List(Of ModeloFacturaCompraDetalle) = detFacCom.ListadoPorIdFacturaCompra()

                        If Not IsNothing(detalleFactura) Then
                            Dim remitado As Boolean = True

                            For Each item In detalleFactura
                                If item.Remitado = "NO" Then
                                    remitado = False
                                End If
                            Next

                            If remitado Then
                                FacturaCompra.Remitado = "SI"
                            Else
                                FacturaCompra.Remitado = "NO"
                            End If

                            If FacturaCompra.ModificarEstadoRemitado() Then
                                If detFacCom.EliminarPorIdFacturaCompra() Then
                                    If FacturaCompra.Eliminar() Then
                                        Commit()
                                        Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                                    Else
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompra.Err)
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(Nothing, detFacCom.Err)
                                End If
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompra.Err)
                            End If
                        Else
                            Rollback()
                            Return New RespuestaHTTP(Of Boolean)(Nothing, detFacCom.Err)
                        End If
                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompraMoneda.Err)
                    End If
                Else
                    Rollback()
                    Return New RespuestaHTTP(Of Boolean)(Nothing, CuentaCorritenteCompra.Err)
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
