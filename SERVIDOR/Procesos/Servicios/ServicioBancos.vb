Public Class ServicioBancos
    Private _Banco As ModeloBancos

#Region "CONSTRUCTORES"
    Public Sub New(banco As ModeloBancos)
        Me.Banco = banco
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property Banco As ModeloBancos
        Get
            Return _Banco
        End Get
        Set(value As ModeloBancos)
            _Banco = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS"
    Public Function Insertar() As RespuestaHTTP(Of Boolean)
        Try
            Dim existe As Boolean = Banco.ExistePorNombre()

            If Not IsNothing(existe) Then
                If existe Then
                    Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Ya existe un banco con ese nombre dentro de la base de datos"})
                Else
                    If Banco.Insertar() Then
                        Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                    Else
                        Return New RespuestaHTTP(Of Boolean)(False, Banco.Err)
                    End If
                End If
            Else
                Return New RespuestaHTTP(Of Boolean)(False, Banco.Err)
            End If
        Catch ex As Exception
            Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message})
        End Try
    End Function

    Public Function Modificar() As RespuestaHTTP(Of Boolean)
        Try
            Dim existe As Boolean = Banco.ExistePorNombre()

            If Not IsNothing(existe) Then
                If existe Then
                    Dim registro As ModeloBancos = Banco.ConsultarPorId()

                    If Not IsNothing(registro) Then
                        If registro.Nombre <> Banco.Nombre Then
                            Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Ya existe un banco con ese nombre dentro de la base de datos"})
                        End If
                    Else
                        Return New RespuestaHTTP(Of Boolean)(False, Banco.Err)
                    End If
                End If

                If Banco.Modificar() Then
                    Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                Else
                    Return New RespuestaHTTP(Of Boolean)(False, Banco.Err)
                End If
            Else
                Return New RespuestaHTTP(Of Boolean)(False, Banco.Err)
            End If
        Catch ex As Exception
            Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message})
        End Try
    End Function
#End Region
End Class
