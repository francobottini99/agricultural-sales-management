Public Class ServicioRubros
    Private _Rubro As ModeloRubro

#Region "CONSTRUCTORES"
    Public Sub New(rubro As ModeloRubro)
        Me.Rubro = rubro
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property Rubro As ModeloRubro
        Get
            Return _Rubro
        End Get
        Set(value As ModeloRubro)
            _Rubro = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS"
    Public Function Insertar() As RespuestaHTTP(Of Boolean)
        Try
            Dim existe As Boolean = Rubro.ExistePorNombre()

            If Not IsNothing(existe) Then
                If existe Then
                    Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Ya existe un rubro con ese nombre dentro de la base de datos"})
                Else
                    Dim servAb As New ServicioAbrebiaciones(Rubro.Abrebiatura)
                    Dim exsAb As RespuestaHTTP(Of Boolean) = servAb.ExisteAbrebiatura()

                    If Not IsNothing(exsAb.Cuerpo) Then
                        If exsAb.Cuerpo Then
                            Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Ya existe un rubro o un sub rubro con esa abreviatura dentro de la base de datos"})
                        Else
                            If Rubro.Insertar() Then
                                Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                            Else
                                Return New RespuestaHTTP(Of Boolean)(False, Rubro.Err)
                            End If
                        End If
                    Else
                        Return New RespuestaHTTP(Of Boolean)(False, exsAb.Err)
                    End If
                End If
            Else
                Return New RespuestaHTTP(Of Boolean)(False, Rubro.Err)
            End If
        Catch ex As Exception
            Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message})
        End Try
    End Function

    Public Function Modificar() As RespuestaHTTP(Of Boolean)
        Try
            Dim existe As Boolean = Rubro.ExistePorNombre()

            If Not IsNothing(existe) Then
                Dim registro As ModeloRubro = Rubro.ConsultarPorId()

                If Not IsNothing(registro) Then
                    If existe Then
                        If registro.Descripcion <> Rubro.Descripcion Then
                            Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Ya existe un rubro con ese nombre dentro de la base de datos"})
                        End If
                    End If

                    Dim servAb As New ServicioAbrebiaciones(Rubro.Abrebiatura)
                    Dim exsAb As RespuestaHTTP(Of Boolean) = servAb.ExisteAbrebiatura()

                    If Not IsNothing(exsAb.Cuerpo) Then
                        If exsAb.Cuerpo Then
                            If registro.Abrebiatura <> Rubro.Abrebiatura Then
                                Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Ya existe un rubro o un sub rubro con esa abreviatura dentro de la base de datos"})
                            End If
                        End If

                        If Rubro.Modificar() Then
                            Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                        Else
                            Return New RespuestaHTTP(Of Boolean)(False, Rubro.Err)
                        End If
                    Else
                        Return New RespuestaHTTP(Of Boolean)(False, exsAb.Err)
                    End If
                Else
                    Return New RespuestaHTTP(Of Boolean)(False, registro.Err)
                End If
            Else
                Return New RespuestaHTTP(Of Boolean)(False, Rubro.Err)
            End If
        Catch ex As Exception
            Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message})
        End Try
    End Function

    Public Function Eliminar() As RespuestaHTTP(Of Boolean)
        Dim SubRubro As New ModeloSubRubro With {.AscRubro = New ModeloRubro With {.IdRubro = Rubro.IdRubro}}
        Dim existe As Boolean = SubRubro.ExistePorIdRubro()

        If Not IsNothing(existe) Then
            If existe Then
                Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "El rubro que desea eliminar esta asociado a uno o mas sub rubro por lo tanto no puede ser eliminado"})
            Else
                If Rubro.Eliminar() Then
                    Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                Else
                    Return New RespuestaHTTP(Of Boolean)(False, Rubro.Err)
                End If
            End If
        Else
            Return New RespuestaHTTP(Of Boolean)(False, SubRubro.Err)
        End If
    End Function
#End Region
End Class
