Imports AccesoDatos

Public Class ServicioRecibosVenta
    Inherits EnlaceTransacciones(Of Transacciones)

    Private _RecibosVenta As ModeloRecibosVenta
    Private _RecibosVentaDetalle As List(Of ModeloRecibosVentaDetalle)
    Private _CuentaCorrienteVenta As ModeloCuentaCorrienteVenta
    Private _Caja As List(Of ModeloCaja)
    Private _MovimientoValores As List(Of ModeloMovimientoValores)
    Private _RecibosVentaMonedas As List(Of ModeloRecibosVentaMonedas)
    Private _Numeracion As ModeloNumeracion

#Region "CONSTRUCTORES"
    Public Sub New(recibosVenta As ModeloRecibosVenta, recibosVentaDetalle As List(Of ModeloRecibosVentaDetalle),
                   cuentaCorrienteVenta As ModeloCuentaCorrienteVenta, caja As List(Of ModeloCaja),
                   movimientoValores As List(Of ModeloMovimientoValores), recibosVentaMonedas As List(Of ModeloRecibosVentaMonedas),
                   numeracion As ModeloNumeracion)
        MyBase.New(New Transacciones(), "-")

        Me.RecibosVenta = recibosVenta
        Me.RecibosVentaDetalle = recibosVentaDetalle
        Me.CuentaCorrienteVenta = cuentaCorrienteVenta
        Me.Caja = caja
        Me.MovimientoValores = movimientoValores
        Me.RecibosVentaMonedas = recibosVentaMonedas
        Me.Numeracion = numeracion
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property RecibosVenta As ModeloRecibosVenta
        Get
            Return _RecibosVenta
        End Get
        Set(value As ModeloRecibosVenta)
            _RecibosVenta = value
        End Set
    End Property

    Public Property RecibosVentaDetalle As List(Of ModeloRecibosVentaDetalle)
        Get
            Return _RecibosVentaDetalle
        End Get
        Set(value As List(Of ModeloRecibosVentaDetalle))
            _RecibosVentaDetalle = value
        End Set
    End Property

    Public Property CuentaCorrienteVenta As ModeloCuentaCorrienteVenta
        Get
            Return _CuentaCorrienteVenta
        End Get
        Set(value As ModeloCuentaCorrienteVenta)
            _CuentaCorrienteVenta = value
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

    Public Property MovimientoValores As List(Of ModeloMovimientoValores)
        Get
            Return _MovimientoValores
        End Get
        Set(value As List(Of ModeloMovimientoValores))
            _MovimientoValores = value
        End Set
    End Property

    Public Property RecibosVentaMonedas As List(Of ModeloRecibosVentaMonedas)
        Get
            Return _RecibosVentaMonedas
        End Get
        Set(value As List(Of ModeloRecibosVentaMonedas))
            _RecibosVentaMonedas = value
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

            If CuentaCorrienteVenta.Insertar() Then
                Dim idCtaCrt As Integer = CuentaCorrienteVenta.UltimoId()

                If Not IsNothing(idCtaCrt) Then
                    RecibosVenta.AscCuentaCorrienteVenta.IdCuentaCorrienteVentas = idCtaCrt

                    If RecibosVenta.Insertar() Then
                        Dim idRecVta As Integer = RecibosVenta.UltimoId()

                        If Not IsNothing(idRecVta) Then
                            For Each item In RecibosVentaMonedas
                                item.AscRecibosVenta.IdRecibosVenta = idRecVta

                                If Not item.Insertar() Then
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(Nothing, item.Err)
                                End If
                            Next

                            For Each item In RecibosVentaDetalle
                                item.AscRecibosVenta.IdRecibosVenta = idRecVta

                                If Not item.Insertar() Then
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
                                If item.AscValoresEnCartera.Insertar() Then
                                    Dim ultIdValor As Integer = item.AscValoresEnCartera.UltimoId()

                                    If Not IsNothing(ultIdValor) Then
                                        item.AscValoresEnCartera.IdValoresEnCartera = ultIdValor

                                        item.AscCaja.Descripcion = "[ " + item.AscValoresEnCartera.IdValoresEnCartera.ToString() + " ] - " + item.AscCaja.Descripcion

                                        If item.AscCaja.Insertar() Then
                                            Dim ultIdCaja As Integer = item.AscCaja.UltimoId()

                                            If Not IsNothing(ultIdCaja) Then
                                                item.AscCaja.IdCaja = ultIdCaja

                                                If Not item.Insertar() Then
                                                    Rollback()
                                                    Return New RespuestaHTTP(Of Boolean)(False, item.Err)
                                                End If
                                            Else
                                                Rollback()
                                                Return New RespuestaHTTP(Of Boolean)(False, item.AscCaja.Err)
                                            End If
                                        Else
                                            Rollback()
                                            Return New RespuestaHTTP(Of Boolean)(False, item.AscCaja.Err)
                                        End If
                                    Else
                                        Rollback()
                                        Return New RespuestaHTTP(Of Boolean)(False, item.AscValoresEnCartera.Err)
                                    End If
                                Else
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(False, item.AscValoresEnCartera.Err)
                                End If
                            Next

                            If Numeracion.ModificarNroRecibo() Then
                                Commit()
                                Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of Boolean)(False, Numeracion.Err)
                            End If
                        Else
                            Rollback()
                            Return New RespuestaHTTP(Of Boolean)(Nothing, RecibosVenta.Err)
                        End If
                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(Nothing, RecibosVenta.Err)
                    End If
                Else
                    Rollback()
                    Return New RespuestaHTTP(Of Boolean)(Nothing, CuentaCorrienteVenta.Err)
                End If
            Else
                Rollback()
                Return New RespuestaHTTP(Of Boolean)(Nothing, CuentaCorrienteVenta.Err)
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
