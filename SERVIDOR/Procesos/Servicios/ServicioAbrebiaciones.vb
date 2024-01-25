Public Class ServicioAbrebiaciones
    Private _Rubro As ModeloRubro
    Private _SubRubro As ModeloSubRubro

#Region "CONSTRUCTORES"
    Public Sub New(Abrebiatura As String)
        Rubro = New ModeloRubro With {.Abrebiatura = Abrebiatura}
        SubRubro = New ModeloSubRubro With {.Abrebiatura = Abrebiatura}
    End Sub

    Public Sub New(rubro As ModeloRubro, subRubro As ModeloSubRubro)
        Me.Rubro = rubro
        Me.SubRubro = subRubro
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

    Public Property SubRubro As ModeloSubRubro
        Get
            Return _SubRubro
        End Get
        Set(value As ModeloSubRubro)
            _SubRubro = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS"
    Public Function ExisteAbrebiatura() As RespuestaHTTP(Of Boolean)
        Try
            Dim verificarRubro As Boolean = Rubro.ExistePorAbrebiatura()
            Dim verificarSubRubro As Boolean = SubRubro.ExistePorAbrebiatura()

            If IsNothing(verificarRubro) Then
                Return New RespuestaHTTP(Of Boolean)(Nothing, Rubro.Err)
            Else
                If IsNothing(verificarSubRubro) Then
                    Return New RespuestaHTTP(Of Boolean)(Nothing, SubRubro.Err)
                Else
                    If verificarRubro Or verificarSubRubro Then
                        Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                    Else
                        Return New RespuestaHTTP(Of Boolean)(False, Nothing)
                    End If
                End If
            End If
        Catch ex As Exception
            Return New RespuestaHTTP(Of Boolean)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message})
        End Try
    End Function
#End Region
End Class
