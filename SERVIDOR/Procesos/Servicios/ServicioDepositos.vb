Public Class ServicioDepositos
    Private _Deposito As ModeloDepositos

#Region "CONSTRUCTORES"
    Public Sub New(deposito As ModeloDepositos)
        Me.Deposito = deposito
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property Deposito As ModeloDepositos
        Get
            Return _Deposito
        End Get
        Set(value As ModeloDepositos)
            _Deposito = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS"
    Public Function Insertar() As RespuestaHTTP(Of Boolean)
        Try
            Dim existe As Boolean = Deposito.ExistePorNombre()

            If Not IsNothing(existe) Then
                If existe Then
                    Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Ya existe un deposito con ese nombre dentro de la base de datos"})
                Else
                    If Deposito.Insertar() Then
                        Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                    Else
                        Return New RespuestaHTTP(Of Boolean)(False, Deposito.Err)
                    End If
                End If
            Else
                Return New RespuestaHTTP(Of Boolean)(False, Deposito.Err)
            End If
        Catch ex As Exception
            Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message})
        End Try
    End Function

    Public Function Modificar() As RespuestaHTTP(Of Boolean)
        Try
            Dim existe As Boolean = Deposito.ExistePorNombre()

            If Not IsNothing(existe) Then
                If existe Then
                    Dim registro As ModeloDepositos = Deposito.ConsultarPorId()

                    If Not IsNothing(registro) Then
                        If registro.Nombre <> Deposito.Nombre Then
                            Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_GENERAL, .Descripcion = "Ya existe un deposito con ese nombre dentro de la base de datos"})
                        End If
                    Else
                        Return New RespuestaHTTP(Of Boolean)(False, Deposito.Err)
                    End If
                End If

                If Deposito.Modificar() Then
                    Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                Else
                    Return New RespuestaHTTP(Of Boolean)(False, Deposito.Err)
                End If
            Else
                Return New RespuestaHTTP(Of Boolean)(False, Deposito.Err)
            End If
        Catch ex As Exception
            Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message})
        End Try
    End Function
#End Region
End Class
