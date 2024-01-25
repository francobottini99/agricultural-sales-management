Imports AccesoDatos

Public Class ServicioRemitoCompra
    Inherits EnlaceTransacciones(Of Transacciones)

    Private _RemitoCompra As ModeloRemitosCompra
    Private _RemitoCompraMoneda As ModeloRemitoComMonedas
    Private _DetalleRemitoCompra As List(Of ModeloDetalleRemitoCompra)
    Private _Movimientos_Remito_Factura As List(Of ModeloMovimientos_RemitoCompra_FacturaCompra)
    Private _RemitosCompraMovimientos As List(Of ModeloRemitosCompraMovimientos)
    Private _FacturaCompraMovimientos As List(Of ModeloFacturaCompraMovimientos)

#Region "CONSTRUCTORES"
    Public Sub New(remitoCompra As ModeloRemitosCompra, remitoCompraMoneda As ModeloRemitoComMonedas, detalleRemitoCompra As List(Of ModeloDetalleRemitoCompra),
                   movimientos_Remito_Factura As List(Of ModeloMovimientos_RemitoCompra_FacturaCompra), remitosCompraMovimientos As List(Of ModeloRemitosCompraMovimientos), facturaCompraMovimientos As List(Of ModeloFacturaCompraMovimientos))
        MyBase.New(New Transacciones(), "-")

        Me.RemitoCompra = remitoCompra
        Me.RemitoCompraMoneda = remitoCompraMoneda
        Me.DetalleRemitoCompra = detalleRemitoCompra
        Me.Movimientos_Remito_Factura = movimientos_Remito_Factura
        Me.RemitosCompraMovimientos = remitosCompraMovimientos
        Me.FacturaCompraMovimientos = facturaCompraMovimientos
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property RemitoCompra As ModeloRemitosCompra
        Get
            Return _RemitoCompra
        End Get
        Set(value As ModeloRemitosCompra)
            _RemitoCompra = value
        End Set
    End Property

    Public Property RemitoCompraMoneda As ModeloRemitoComMonedas
        Get
            Return _RemitoCompraMoneda
        End Get
        Set(value As ModeloRemitoComMonedas)
            _RemitoCompraMoneda = value
        End Set
    End Property

    Public Property DetalleRemitoCompra As List(Of ModeloDetalleRemitoCompra)
        Get
            Return _DetalleRemitoCompra
        End Get
        Set(value As List(Of ModeloDetalleRemitoCompra))
            _DetalleRemitoCompra = value
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

            If RemitoCompra.Insertar() Then
                Dim RemCompUltId As Integer = RemitoCompra.UltimoId()

                If Not IsNothing(RemCompUltId) Then
                    RemitoCompraMoneda.AscRemitosCompra.IdRemitosCompra = RemCompUltId

                    If RemitoCompraMoneda.Insertar() Then
                        For i As Integer = 0 To DetalleRemitoCompra.Count - 1
                            DetalleRemitoCompra(i).AscRemitosCompra.IdRemitosCompra = RemCompUltId

                            If DetalleRemitoCompra(i).Insertar() Then
                                If RemitosCompraMovimientos(i).AscStock.Insertar() Then
                                    Dim DetRemUltId As Integer = DetalleRemitoCompra(i).UltimoId()

                                    If Not IsNothing(DetRemUltId) Then
                                        Dim StkUltId As Integer = RemitosCompraMovimientos(i).AscStock.UltimoId()

                                        If Not IsNothing(StkUltId) Then
                                            RemitosCompraMovimientos(i).AscDetalleRemtioCompra.IdDetalleRemitosCompra = DetRemUltId
                                            RemitosCompraMovimientos(i).AscStock.IdStock = StkUltId

                                            If RemitosCompraMovimientos(i).Insertar() Then
                                                Dim RemComMovUltId As Integer = RemitosCompraMovimientos(i).UltimoId()

                                                If Not IsNothing(RemComMovUltId) Then
                                                    If FacturaCompraMovimientos(i).AscFacturaCompraDetalle.IdFacturaCompraDetalle <> 0 Then
                                                        If FacturaCompraMovimientos(i).Insertar() Then
                                                            Dim FacMovUltId As Integer = FacturaCompraMovimientos(i).UltimoId()

                                                            If Not IsNothing(FacMovUltId) Then
                                                                Movimientos_Remito_Factura(i).AscRemitosCompraMovimientos.IdRemitosCompraMovimientos = RemComMovUltId
                                                                Movimientos_Remito_Factura(i).AscFacturaCompraMovimientos.IdFacturaCompraMovimientos = FacMovUltId

                                                                If Movimientos_Remito_Factura(i).Insertar() Then
                                                                    RemitosCompraMovimientos(i).AscDetalleRemtioCompra.Facturado = "SI"

                                                                    If RemitosCompraMovimientos(i).AscDetalleRemtioCompra.ModificarEstadoFacturacion() Then
                                                                        Dim facCanRem As Double = FacturaCompraMovimientos(i).CantidadRemitada()

                                                                        If Not IsNothing(facCanRem) Then
                                                                            Dim facCanFac As Double = FacturaCompraMovimientos(i).CantidadFacturada()

                                                                            If Not IsNothing(facCanFac) Then
                                                                                Dim facCanAnu As Double = FacturaCompraMovimientos(i).CantidadAnulada()

                                                                                If Not IsNothing(facCanAnu) Then
                                                                                    If facCanRem + facCanAnu = facCanFac Then
                                                                                        FacturaCompraMovimientos(i).AscFacturaCompraDetalle.Remitado = "SI"

                                                                                        If FacturaCompraMovimientos(i).AscFacturaCompraDetalle.ModificarRemitado() Then
                                                                                            Dim detalleFactura As List(Of ModeloFacturaCompraDetalle) = FacturaCompraMovimientos(i).AscFacturaCompraDetalle.ListadoPorIdFacturaCompra()

                                                                                            If Not IsNothing(detalleFactura) Then
                                                                                                Dim Remitado As Boolean = True

                                                                                                For Each item In detalleFactura
                                                                                                    If item.Remitado = "NO" Then
                                                                                                        Remitado = False
                                                                                                        Exit For
                                                                                                    End If
                                                                                                Next

                                                                                                If Remitado Then
                                                                                                    FacturaCompraMovimientos(i).AscFacturaCompraDetalle.AscFacturaCompra.Remitado = "SI"

                                                                                                    If Not FacturaCompraMovimientos(i).AscFacturaCompraDetalle.AscFacturaCompra.ModificarEstadoRemitado() Then
                                                                                                        Rollback()
                                                                                                        Return New RespuestaHTTP(Of Boolean)(False, FacturaCompraMovimientos(i).AscFacturaCompraDetalle.AscFacturaCompra.Err)
                                                                                                    End If
                                                                                                End If
                                                                                            Else
                                                                                                Rollback()
                                                                                                Return New RespuestaHTTP(Of Boolean)(False, FacturaCompraMovimientos(i).AscFacturaCompraDetalle.Err)
                                                                                            End If
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
                                                                            Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompraMovimientos(i).Err)
                                                                        End If
                                                                    Else
                                                                        Rollback()
                                                                        Return New RespuestaHTTP(Of Boolean)(Nothing, RemitosCompraMovimientos(i).AscDetalleRemtioCompra.Err)
                                                                    End If
                                                                Else
                                                                    Rollback()
                                                                    Return New RespuestaHTTP(Of Boolean)(Nothing, Movimientos_Remito_Factura(i).Err)
                                                                End If
                                                            Else
                                                                Rollback()
                                                                Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompraMovimientos(i).Err)
                                                            End If
                                                        Else
                                                            Rollback()
                                                            Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompraMovimientos(i).Err)
                                                        End If
                                                    End If
                                                Else
                                                    Rollback()
                                                    Return New RespuestaHTTP(Of Boolean)(Nothing, RemitosCompraMovimientos(i).Err)
                                                End If
                                            Else
                                                Rollback()
                                                Return New RespuestaHTTP(Of Boolean)(Nothing, RemitosCompraMovimientos(i).Err)
                                            End If
                                        Else
                                            Rollback()
                                            Return New RespuestaHTTP(Of Boolean)(Nothing, RemitosCompraMovimientos(i).AscStock.Err)
                                        End If
                                    Else
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(Nothing, DetalleRemitoCompra(i).Err)
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(Nothing, RemitosCompraMovimientos(i).AscStock.Err)
                                End If
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of Boolean)(Nothing, DetalleRemitoCompra(i).Err)
                            End If
                        Next

                        Dim detalleRemito As List(Of ModeloDetalleRemitoCompra) = DetalleRemitoCompra.First.ListasdoPorIdRemitosCompra()

                        If Not IsNothing(detalleRemito) Then
                            Dim facturado As Boolean = True

                            For Each item In detalleRemito
                                If item.Facturado = "NO" Then
                                    facturado = False
                                End If
                            Next

                            If facturado Then
                                RemitoCompra.IdRemitosCompra = RemCompUltId
                                RemitoCompra.Facturado = "SI"

                                If Not RemitoCompra.ModificarEstadoFacturacion() Then
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(Nothing, RemitoCompra.Err)
                                End If
                            End If

                            Commit()
                            Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                        Else
                            Rollback()
                            Return New RespuestaHTTP(Of Boolean)(Nothing, DetalleRemitoCompra.First.Err)
                        End If
                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(Nothing, RemitoCompraMoneda.Err)
                    End If
                Else
                    Rollback()
                    Return New RespuestaHTTP(Of Boolean)(Nothing, RemitoCompra.Err)
                End If
            Else
                Rollback()
                Return New RespuestaHTTP(Of Boolean)(Nothing, RemitoCompra.Err)
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
            Dim verificarNoEliminado As ModeloRemitosCompra = RemitoCompra.ConsultarPorId()

            If verificarNoEliminado.Err.Identificador = EnumErrores.OK Then
                Dim remComMov As New ModeloRemitosCompraMovimientos With {.AscDetalleRemtioCompra = New ModeloDetalleRemitoCompra With {.AscRemitosCompra = New ModeloRemitosCompra With {.IdRemitosCompra = RemitoCompra.IdRemitosCompra}}}
                Dim movRemFac As New ModeloMovimientos_RemitoCompra_FacturaCompra With {.AscRemitosCompraMovimientos = New ModeloRemitosCompraMovimientos With {.AscDetalleRemtioCompra = New ModeloDetalleRemitoCompra With {.AscRemitosCompra = New ModeloRemitosCompra With {.IdRemitosCompra = RemitoCompra.IdRemitosCompra}}}}
                Dim detRemCom As New ModeloDetalleRemitoCompra With {.AscRemitosCompra = New ModeloRemitosCompra With {.IdRemitosCompra = RemitoCompra.IdRemitosCompra}}

                BeginTransaction()

                If RemitoCompraMoneda.EliminarPorIdRemitosCompra() Then
                    Dim listRemFacMov As List(Of ModeloMovimientos_RemitoCompra_FacturaCompra) = movRemFac.ListasdoPorIdRemitosCompra()

                    If Not IsNothing(listRemFacMov) Then
                        For Each item In listRemFacMov
                            item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.Remitado = "NO"

                            If item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.ModificarRemitado() Then
                                item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.AscFacturaCompra.Remitado = "NO"

                                If item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.AscFacturaCompra.ModificarEstadoRemitado() Then
                                    item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.Facturado = "NO"

                                    If item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.ModificarEstadoFacturacion() Then
                                        If item.Tipo = "REMITADO" Then
                                            If item.AscFacturaCompraMovimientos.Eliminar() Then
                                                If Not item.Eliminar() Then
                                                    Rollback()
                                                    Return New RespuestaHTTP(Of Boolean)(False, item.Err)
                                                End If
                                            Else
                                                Rollback()
                                                Return New RespuestaHTTP(Of Boolean)(False, item.AscFacturaCompraMovimientos.Err)
                                            End If
                                        End If
                                    Else
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(False, item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.Err)
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(False, item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.AscFacturaCompra.Err)
                                End If
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of Boolean)(False, item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.Err)
                            End If
                        Next
                    ElseIf movRemFac.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(False, movRemFac.Err)
                    End If

                    Dim listRemComMov As List(Of ModeloRemitosCompraMovimientos) = remComMov.ListasdoPorIdRemitosCompra()

                    If Not IsNothing(listRemComMov) Then
                        For Each item In listRemComMov
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
                    ElseIf remComMov.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(False, remComMov.Err)
                    End If

                    Dim detalleRemito As List(Of ModeloDetalleRemitoCompra) = detRemCom.ListasdoPorIdRemitosCompra()

                    If Not IsNothing(detalleRemito) Then
                        Dim facturado As Boolean = True

                        For Each item In detalleRemito
                            If item.Facturado = "NO" Then
                                facturado = False
                            End If
                        Next

                        If facturado Then
                            RemitoCompra.Facturado = "SI"
                        Else
                            RemitoCompra.Facturado = "NO"
                        End If

                        If RemitoCompra.ModificarEstadoFacturacion() Then
                            If detRemCom.EliminarPorIdRemitosCompra() Then
                                If RemitoCompra.Eliminar() Then
                                    Commit()
                                    Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(Nothing, RemitoCompra.Err)
                                End If
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of Boolean)(Nothing, detRemCom.Err)
                            End If
                        Else
                            Rollback()
                            Return New RespuestaHTTP(Of Boolean)(Nothing, RemitoCompra.Err)
                        End If
                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(Nothing, detRemCom.Err)
                    End If
                Else
                    Rollback()
                    Return New RespuestaHTTP(Of Boolean)(Nothing, RemitoCompraMoneda.Err)
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

    Public Function Modificar() As RespuestaHTTP(Of Boolean)
        Try
            Dim verificarNoEliminado As ModeloRemitosCompra = RemitoCompra.ConsultarPorId()

            If verificarNoEliminado.Err.Identificador = EnumErrores.OK Then
                Dim remComMov As New ModeloRemitosCompraMovimientos With {.AscDetalleRemtioCompra = New ModeloDetalleRemitoCompra With {.AscRemitosCompra = New ModeloRemitosCompra With {.IdRemitosCompra = RemitoCompra.IdRemitosCompra}}}
                Dim movRemFac As New ModeloMovimientos_RemitoCompra_FacturaCompra With {.AscRemitosCompraMovimientos = New ModeloRemitosCompraMovimientos With {.AscDetalleRemtioCompra = New ModeloDetalleRemitoCompra With {.AscRemitosCompra = New ModeloRemitosCompra With {.IdRemitosCompra = RemitoCompra.IdRemitosCompra}}}}
                Dim detRemCom As New ModeloDetalleRemitoCompra With {.AscRemitosCompra = New ModeloRemitosCompra With {.IdRemitosCompra = RemitoCompra.IdRemitosCompra}}

                BeginTransaction()

                If RemitoCompraMoneda.EliminarPorIdRemitosCompra() Then
                    Dim listRemFacMov As List(Of ModeloMovimientos_RemitoCompra_FacturaCompra) = movRemFac.ListasdoPorIdRemitosCompra()

                    If Not IsNothing(listRemFacMov) Then
                        For Each item In listRemFacMov
                            item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.Remitado = "NO"

                            If item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.ModificarRemitado() Then
                                item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.AscFacturaCompra.Remitado = "NO"

                                If item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.AscFacturaCompra.ModificarEstadoRemitado() Then
                                    item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.Facturado = "NO"

                                    If item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.ModificarEstadoFacturacion() Then
                                        If item.Tipo = "REMITADO" Then
                                            If item.AscFacturaCompraMovimientos.Eliminar() Then
                                                If Not item.Eliminar() Then
                                                    Rollback()
                                                    Return New RespuestaHTTP(Of Boolean)(False, item.Err)
                                                End If
                                            Else
                                                Rollback()
                                                Return New RespuestaHTTP(Of Boolean)(False, item.AscFacturaCompraMovimientos.Err)
                                            End If
                                        End If
                                    Else
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(False, item.AscRemitosCompraMovimientos.AscDetalleRemtioCompra.Err)
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(False, item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.AscFacturaCompra.Err)
                                End If
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of Boolean)(False, item.AscFacturaCompraMovimientos.AscFacturaCompraDetalle.Err)
                            End If
                        Next
                    ElseIf movRemFac.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(False, movRemFac.Err)
                    End If

                    Dim listRemComMov As List(Of ModeloRemitosCompraMovimientos) = remComMov.ListasdoPorIdRemitosCompra()

                    If Not IsNothing(listRemComMov) Then
                        For Each item In listRemComMov
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
                    ElseIf remComMov.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(False, remComMov.Err)
                    End If

                    If detRemCom.EliminarPorIdRemitosCompra() Then
                        If RemitoCompra.Modificar() Then
                            If RemitoCompraMoneda.Insertar() Then
                                For i As Integer = 0 To DetalleRemitoCompra.Count - 1
                                    If DetalleRemitoCompra(i).Insertar() Then
                                        If RemitosCompraMovimientos(i).AscStock.Insertar() Then
                                            Dim DetRemUltId As Integer = DetalleRemitoCompra(i).UltimoId()

                                            If Not IsNothing(DetRemUltId) Then
                                                Dim StkUltId As Integer = RemitosCompraMovimientos(i).AscStock.UltimoId()

                                                If Not IsNothing(StkUltId) Then
                                                    RemitosCompraMovimientos(i).AscDetalleRemtioCompra.IdDetalleRemitosCompra = DetRemUltId
                                                    RemitosCompraMovimientos(i).AscStock.IdStock = StkUltId

                                                    If RemitosCompraMovimientos(i).Insertar() Then
                                                        Dim RemComMovUltId As Integer = RemitosCompraMovimientos(i).UltimoId()

                                                        If Not IsNothing(RemComMovUltId) Then
                                                            If FacturaCompraMovimientos(i).AscFacturaCompraDetalle.IdFacturaCompraDetalle <> 0 Then
                                                                If FacturaCompraMovimientos(i).Insertar() Then
                                                                    Dim FacMovUltId As Integer = FacturaCompraMovimientos(i).UltimoId()

                                                                    If Not IsNothing(FacMovUltId) Then
                                                                        Movimientos_Remito_Factura(i).AscRemitosCompraMovimientos.IdRemitosCompraMovimientos = RemComMovUltId
                                                                        Movimientos_Remito_Factura(i).AscFacturaCompraMovimientos.IdFacturaCompraMovimientos = FacMovUltId

                                                                        If Movimientos_Remito_Factura(i).Insertar() Then
                                                                            RemitosCompraMovimientos(i).AscDetalleRemtioCompra.Facturado = "SI"

                                                                            If RemitosCompraMovimientos(i).AscDetalleRemtioCompra.ModificarEstadoFacturacion() Then
                                                                                Dim facCanRem As Double = FacturaCompraMovimientos(i).CantidadRemitada()

                                                                                If Not IsNothing(facCanRem) Then
                                                                                    Dim facCanFac As Double = FacturaCompraMovimientos(i).CantidadFacturada()

                                                                                    If Not IsNothing(facCanFac) Then
                                                                                        Dim facCanAnu As Double = FacturaCompraMovimientos(i).CantidadAnulada()

                                                                                        If Not IsNothing(facCanAnu) Then
                                                                                            If facCanRem + facCanAnu = facCanFac Then
                                                                                                FacturaCompraMovimientos(i).AscFacturaCompraDetalle.Remitado = "SI"

                                                                                                If FacturaCompraMovimientos(i).AscFacturaCompraDetalle.ModificarRemitado() Then
                                                                                                    Dim detalleFactura As List(Of ModeloFacturaCompraDetalle) = FacturaCompraMovimientos(i).AscFacturaCompraDetalle.ListadoPorIdFacturaCompra()

                                                                                                    If Not IsNothing(detalleFactura) Then
                                                                                                        Dim Remitado As Boolean = True

                                                                                                        For Each item In detalleFactura
                                                                                                            If item.Remitado = "NO" Then
                                                                                                                Remitado = False
                                                                                                                Exit For
                                                                                                            End If
                                                                                                        Next

                                                                                                        If Remitado Then
                                                                                                            FacturaCompraMovimientos(i).AscFacturaCompraDetalle.AscFacturaCompra.Remitado = "SI"

                                                                                                            If Not FacturaCompraMovimientos(i).AscFacturaCompraDetalle.AscFacturaCompra.ModificarEstadoRemitado() Then
                                                                                                                Rollback()
                                                                                                                Return New RespuestaHTTP(Of Boolean)(False, FacturaCompraMovimientos(i).AscFacturaCompraDetalle.AscFacturaCompra.Err)
                                                                                                            End If
                                                                                                        End If
                                                                                                    Else
                                                                                                        Rollback()
                                                                                                        Return New RespuestaHTTP(Of Boolean)(False, FacturaCompraMovimientos(i).AscFacturaCompraDetalle.Err)
                                                                                                    End If
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
                                                                                    Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompraMovimientos(i).Err)
                                                                                End If
                                                                            Else
                                                                                Rollback()
                                                                                Return New RespuestaHTTP(Of Boolean)(Nothing, RemitosCompraMovimientos(i).AscDetalleRemtioCompra.Err)
                                                                            End If
                                                                        Else
                                                                            Rollback()
                                                                            Return New RespuestaHTTP(Of Boolean)(Nothing, Movimientos_Remito_Factura(i).Err)
                                                                        End If
                                                                    Else
                                                                        Rollback()
                                                                        Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompraMovimientos(i).Err)
                                                                    End If
                                                                Else
                                                                    Rollback()
                                                                    Return New RespuestaHTTP(Of Boolean)(Nothing, FacturaCompraMovimientos(i).Err)
                                                                End If
                                                            End If
                                                        Else
                                                            Rollback()
                                                            Return New RespuestaHTTP(Of Boolean)(Nothing, RemitosCompraMovimientos(i).Err)
                                                        End If
                                                    Else
                                                        Rollback()
                                                        Return New RespuestaHTTP(Of Boolean)(Nothing, RemitosCompraMovimientos(i).Err)
                                                    End If
                                                Else
                                                    Rollback()
                                                    Return New RespuestaHTTP(Of Boolean)(Nothing, RemitosCompraMovimientos(i).AscStock.Err)
                                                End If
                                            Else
                                                Rollback()
                                                Return New RespuestaHTTP(Of Boolean)(Nothing, DetalleRemitoCompra(i).Err)
                                            End If
                                        Else
                                            Rollback()
                                            Return New RespuestaHTTP(Of Boolean)(Nothing, RemitosCompraMovimientos(i).AscStock.Err)
                                        End If
                                    Else
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(Nothing, DetalleRemitoCompra(i).Err)
                                    End If
                                Next

                                Dim detalleRemito As List(Of ModeloDetalleRemitoCompra) = DetalleRemitoCompra.First.ListasdoPorIdRemitosCompra()

                                If Not IsNothing(detalleRemito) Then
                                    Dim facturado As Boolean = True

                                    For Each item In detalleRemito
                                        If item.Facturado = "NO" Then
                                            facturado = False
                                        End If
                                    Next

                                    If facturado Then
                                        RemitoCompra.Facturado = "SI"
                                    Else
                                        RemitoCompra.Facturado = "NO"
                                    End If

                                    If RemitoCompra.ModificarEstadoFacturacion() Then
                                        Commit()
                                        Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                                    Else
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(Nothing, RemitoCompra.Err)
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(Nothing, DetalleRemitoCompra.First.Err)
                                End If
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of Boolean)(Nothing, RemitoCompraMoneda.Err)
                            End If
                        Else
                            Rollback()
                            Return New RespuestaHTTP(Of Boolean)(Nothing, RemitoCompra.Err)
                        End If
                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(Nothing, detRemCom.Err)
                    End If
                Else
                    Rollback()
                    Return New RespuestaHTTP(Of Boolean)(Nothing, RemitoCompraMoneda.Err)
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
