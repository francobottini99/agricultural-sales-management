Imports AccesoDatos

Public Class ServicioMovimientoValores
    Inherits EnlaceTransacciones(Of Transacciones)

    Private _MovimientoValores As ModeloMovimientoValores

#Region "CONSTRUCTORES"
    Public Sub New(movimientoValores As ModeloMovimientoValores)
        MyBase.New(New Transacciones(), "-")

        Me.MovimientoValores = movimientoValores
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property MovimientoValores As ModeloMovimientoValores
        Get
            Return _MovimientoValores
        End Get
        Set(value As ModeloMovimientoValores)
            _MovimientoValores = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS"
    Public Function Insertar() As RespuestaHTTP(Of Boolean)
        Try
            BeginTransaction()

            If MovimientoValores.Movimiento = "INGRESO" Then
                If MovimientoValores.AscValoresEnCartera.Insertar() Then
                    Dim ultIdValor As Integer = MovimientoValores.AscValoresEnCartera.UltimoId()

                    If Not IsNothing(ultIdValor) Then
                        MovimientoValores.AscValoresEnCartera.IdValoresEnCartera = ultIdValor
                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(False, MovimientoValores.AscValoresEnCartera.Err)
                    End If
                Else
                    Rollback()
                    Return New RespuestaHTTP(Of Boolean)(False, MovimientoValores.AscValoresEnCartera.Err)
                End If
            End If

            MovimientoValores.AscCaja.Descripcion = "[ " + MovimientoValores.AscValoresEnCartera.IdValoresEnCartera.ToString() + " ] - " + MovimientoValores.AscCaja.Descripcion

            If MovimientoValores.AscCaja.Insertar() Then
                Dim ultIdCaja As Integer = MovimientoValores.AscCaja.UltimoId()

                If Not IsNothing(ultIdCaja) Then
                    MovimientoValores.AscCaja.IdCaja = ultIdCaja

                    If MovimientoValores.Insertar() Then
                        If MovimientoValores.Movimiento = "EGRESO" Then
                            MovimientoValores.AscValoresEnCartera.Disponible = "NO"

                            If MovimientoValores.AscValoresEnCartera.ModificarDisponibilidad() Then
                                Commit()
                                Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of Boolean)(False, MovimientoValores.AscValoresEnCartera.Err)
                            End If
                        Else
                            Commit()
                            Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                        End If
                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(False, MovimientoValores.Err)
                    End If
                Else
                    Rollback()
                    Return New RespuestaHTTP(Of Boolean)(False, MovimientoValores.AscCaja.Err)
                End If
            Else
                Rollback()
                Return New RespuestaHTTP(Of Boolean)(False, MovimientoValores.AscCaja.Err)
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
            BeginTransaction()

            MovimientoValores = MovimientoValores.ConsultarPorIdCaja()

            If Not IsNothing(MovimientoValores) Then
                If MovimientoValores.AscCaja.Eliminar() Then
                    If MovimientoValores.Eliminar() Then
                        If MovimientoValores.Movimiento = "INGRESO" Then
                            If MovimientoValores.AscValoresEnCartera.Eliminar() Then
                                Dim listMov As List(Of ModeloMovimientoValores) = MovimientoValores.ListadoPorIdValoresEnCartera()

                                If Not IsNothing(listMov) Then
                                    For Each item In listMov
                                        If item.AscCaja.Eliminar() Then
                                            If item.Eliminar() Then
                                                Commit()
                                                Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                                            Else
                                                Rollback()
                                                Return New RespuestaHTTP(Of Boolean)(False, item.Err)
                                            End If
                                        Else
                                            Rollback()
                                            Return New RespuestaHTTP(Of Boolean)(False, item.AscCaja.Err)
                                        End If
                                    Next

                                    Commit()
                                    Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                                ElseIf MovimientoValores.Err.Identificador <> EnumErrores.REGISTRO_NO_ENCONTRADO Then
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(False, MovimientoValores.Err)
                                Else
                                    Commit()
                                    Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                                End If
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of Boolean)(False, MovimientoValores.AscValoresEnCartera.Err)
                            End If
                        Else
                            MovimientoValores.AscValoresEnCartera.Disponible = "SI"

                            If MovimientoValores.AscValoresEnCartera.ModificarDisponibilidad() Then
                                Commit()
                                Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                            Else
                                Rollback()
                                Return New RespuestaHTTP(Of Boolean)(False, MovimientoValores.AscValoresEnCartera.Err)
                            End If
                        End If
                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(False, MovimientoValores.Err)
                    End If
                Else
                    Rollback()
                    Return New RespuestaHTTP(Of Boolean)(False, MovimientoValores.AscCaja.Err)
                End If
            Else
                Rollback()
                Return New RespuestaHTTP(Of Boolean)(False, MovimientoValores.Err)
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
