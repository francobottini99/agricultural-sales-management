Public Class ServicioUsuario
    Private _Usuario As ModeloUsuario

#Region "CONSTRUCTORES"
    Public Sub New(usuario As ModeloUsuario)
        Me.Usuario = usuario
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property Usuario As ModeloUsuario
        Get
            Return _Usuario
        End Get
        Set(value As ModeloUsuario)
            _Usuario = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS"
    Public Function Insertar() As RespuestaHTTP(Of Boolean)
        Try
            Dim existe As Boolean = Usuario.ExistePorNombre()

            If Not IsNothing(existe) Then
                If existe Then
                    Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Ya existe un usuario con ese nombre dentro de la base de datos"})
                Else
                    If Usuario.Insertar() Then
                        Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                    Else
                        Return New RespuestaHTTP(Of Boolean)(False, Usuario.Err)
                    End If
                End If
            Else
                Return New RespuestaHTTP(Of Boolean)(False, Usuario.Err)
            End If
        Catch ex As Exception
            Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message})
        End Try
    End Function

    Public Function Modificar() As RespuestaHTTP(Of Boolean)
        Try
            Dim existe As Boolean = Usuario.ExistePorNombre()

            If Not IsNothing(existe) Then
                If existe Then
                    Dim registro As ModeloUsuario = Usuario.ConsultarPorId()

                    If Not IsNothing(registro) Then
                        If registro.Nombre <> Usuario.Nombre Then
                            Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Ya existe un usuario con ese nombre dentro de la base de datos"})
                        End If
                    Else
                        Return New RespuestaHTTP(Of Boolean)(False, Usuario.Err)
                    End If
                End If

                If Usuario.Modificar() Then
                    Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                Else
                    Return New RespuestaHTTP(Of Boolean)(False, Usuario.Err)
                End If
            Else
                Return New RespuestaHTTP(Of Boolean)(False, Usuario.Err)
            End If
        Catch ex As Exception
            Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message})
        End Try
    End Function
#End Region

End Class
