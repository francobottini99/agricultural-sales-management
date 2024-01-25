Public Class ServicioSubRubro
    Private _SubRub As ModeloSubRubro

#Region "CONSTRUCTORES"
    Public Sub New(subRub As ModeloSubRubro)
        Me.SubRub = subRub
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property SubRub As ModeloSubRubro
        Get
            Return _SubRub
        End Get
        Set(value As ModeloSubRubro)
            _SubRub = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS"
    Public Function Insertar() As RespuestaHTTP(Of Boolean)
        Try
            Dim existe As Boolean = SubRub.ExistePorNombre()

            If Not IsNothing(existe) Then
                If existe Then
                    Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Ya existe un sub rubro con ese nombre dentro de la base de datos"})
                Else
                    Dim servAb As New ServicioAbrebiaciones(SubRub.Abrebiatura)
                    Dim exsAb As RespuestaHTTP(Of Boolean) = servAb.ExisteAbrebiatura()

                    If Not IsNothing(exsAb.Cuerpo) Then
                        If exsAb.Cuerpo Then
                            Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Ya existe un rubro o un sub rubro con esa abreviatura dentro de la base de datos"})
                        Else
                            If SubRub.Insertar() Then
                                Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                            Else
                                Return New RespuestaHTTP(Of Boolean)(False, SubRub.Err)
                            End If
                        End If
                    Else
                        Return New RespuestaHTTP(Of Boolean)(False, exsAb.Err)
                    End If
                End If
            Else
                Return New RespuestaHTTP(Of Boolean)(False, SubRub.Err)
            End If
        Catch ex As Exception
            Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message})
        End Try
    End Function

    Public Function Modificar() As RespuestaHTTP(Of Boolean)
        Try
            Dim existe As Boolean = SubRub.ExistePorNombre()

            If Not IsNothing(existe) Then
                Dim registro As ModeloSubRubro = SubRub.ConsultarPorId()

                If Not IsNothing(registro) Then
                    If existe Then
                        If registro.Descripcion <> SubRub.Descripcion Then
                            Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Ya existe un sub rubro con ese nombre dentro de la base de datos"})
                        End If
                    End If

                    Dim servAb As New ServicioAbrebiaciones(SubRub.Abrebiatura)
                    Dim exsAb As RespuestaHTTP(Of Boolean) = servAb.ExisteAbrebiatura()

                    If Not IsNothing(exsAb.Cuerpo) Then
                        If exsAb.Cuerpo Then
                            If registro.Abrebiatura <> SubRub.Abrebiatura Then
                                Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Ya existe un rubro o un sub rubro con esa abreviatura dentro de la base de datos"})
                            End If
                        End If

                        If SubRub.Modificar() Then
                            Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                        Else
                            Return New RespuestaHTTP(Of Boolean)(False, SubRub.Err)
                        End If
                    Else
                        Return New RespuestaHTTP(Of Boolean)(False, exsAb.Err)
                    End If
                Else
                    Return New RespuestaHTTP(Of Boolean)(False, registro.Err)
                End If
            Else
                Return New RespuestaHTTP(Of Boolean)(False, SubRub.Err)
            End If
        Catch ex As Exception
            Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message})
        End Try
    End Function
#End Region
End Class
