Imports AccesoDatos

Public Class ServicioChequera
    Inherits EnlaceTransacciones(Of Transacciones)

    Private _Chequera As ModeloChequera

#Region "CONSTRUCTORES"
    Public Sub New(chra As ModeloChequera)
        MyBase.New(New Transacciones(), "-")

        Me.Chequera = chra
    End Sub

#End Region

#Region "PROPIEDADES"
    Public Property Chequera As ModeloChequera
        Get
            Return _Chequera
        End Get
        Set(value As ModeloChequera)
            _Chequera = value
        End Set
    End Property

#End Region

#Region "METODOS PUBLICOS"
    Public Function Insertar() As RespuestaHTTP(Of Boolean)
        Try
            Dim existe As Boolean = Chequera.ExisteChequera()

            If Not IsNothing(existe) Then
                If existe Then
                    Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Ya existe una chequera con esa cuenta y esa numeración dentro de la base de datos"})
                Else
                    BeginTransaction()

                    If Chequera.Insertar() Then
                        Dim idChequera As Integer = Chequera.UltimoId()

                        If Not IsNothing(idChequera) Then
                            Chequera.IdChequera = idChequera

                            For i As Integer = 0 To Chequera.CantidadChq - 1
                                Dim detalleCheque As ModeloDetalleCheque = New ModeloDetalleCheque With {
                                                    .Numero = Chequera.NroChqInicial + i,
                                                    .FechaEmision = "0001-01-01",
                                                    .FechaCobro = "0001-01-01",
                                                    .PlazoDias = 0,
                                                    .Importe = 0,
                                                    .Destino = "-",
                                                    .EnDisponiblidad = "SI",
                                                    .Cobrado = "NO",
                                                    .Anulado = "NO",
                                                    .Modificado = "NO",
                                                    .Modificacion = "-",
                                                    .Observaciones = "-",
                                                    .Eliminado = "NO",
                                                    .AscChequera = Chequera,
                                                    .AscUsuarios = Chequera.AscUsuarios
                                               }

                                If Not detalleCheque.Insertar() Then
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(False, detalleCheque.Err)
                                End If
                            Next

                            Commit()
                            Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                        Else
                            Rollback()
                            Return New RespuestaHTTP(Of Boolean)(False, Chequera.Err)
                        End If
                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(False, Chequera.Err)
                    End If
                End If
            Else
                Return New RespuestaHTTP(Of Boolean)(False, Chequera.Err)
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
            BeginTransaction()

            Dim elimChq As Boolean = Chequera.EliminarChequesdeChequera()

            If Not IsNothing(elimChq) Then
                If elimChq Then
                    If Chequera.Modificar() Then
                        Dim idChequera As Integer = Chequera.UltimoId()

                        If Not IsNothing(idChequera) Then
                            Chequera.IdChequera = idChequera

                            For i As Integer = 0 To Chequera.CantidadChq - 1
                                Dim detalleCheque As ModeloDetalleCheque = New ModeloDetalleCheque With {
                                                    .Numero = Chequera.NroChqInicial + i,
                                                    .FechaEmision = "0001-01-01",
                                                    .FechaCobro = "0001-01-01",
                                                    .PlazoDias = 0,
                                                    .Importe = 0,
                                                    .Destino = "-",
                                                    .EnDisponiblidad = "SI",
                                                    .Cobrado = "NO",
                                                    .Anulado = "NO",
                                                    .Modificado = "NO",
                                                    .Modificacion = "-",
                                                    .Observaciones = "-",
                                                    .Eliminado = "NO",
                                                    .AscChequera = Chequera,
                                                    .AscUsuarios = Chequera.AscUsuarios
                                               }

                                If Not detalleCheque.Insertar() Then
                                    Rollback()
                                    Return New RespuestaHTTP(Of Boolean)(False, detalleCheque.Err)
                                End If
                            Next
                            Commit()
                            Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                        Else
                            Rollback()
                            Return New RespuestaHTTP(Of Boolean)(False, Chequera.Err)
                        End If
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(False, Chequera.Err)
                    End If
                Else
                    Rollback()
                    Return New RespuestaHTTP(Of Boolean)(False, Chequera.Err)
                End If
            Else
                Rollback()
                Return New RespuestaHTTP(Of Boolean)(False, Chequera.Err)
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

            Dim elimChq As Boolean = Chequera.EliminarChequesdeChequera()

            If Not IsNothing(elimChq) Then
                If elimChq Then
                    If Chequera.Eliminar() Then
                        Commit()
                        Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                    Else
                        Rollback()
                        Return New RespuestaHTTP(Of Boolean)(False, Chequera.Err)
                    End If
                Else
                    Rollback()
                    Return New RespuestaHTTP(Of Boolean)(False, Chequera.Err)
                End If
            Else
                Rollback()
                Return New RespuestaHTTP(Of Boolean)(False, Chequera.Err)
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
