Public Class ServicioParidadCambiaria
    Private _Monedas As ModeloMonedas
    Private _ParidadCambiaria As ModeloParidadCambiaria

#Region "CONSTRUCTORES"
    Public Sub New(monedas As ModeloMonedas, paridadCambiaria As ModeloParidadCambiaria)
        Me.Monedas = monedas
        Me.ParidadCambiaria = paridadCambiaria
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property Monedas As ModeloMonedas
        Get
            Return _Monedas
        End Get
        Set(value As ModeloMonedas)
            _Monedas = value
        End Set
    End Property

    Public Property ParidadCambiaria As ModeloParidadCambiaria
        Get
            Return _ParidadCambiaria
        End Get
        Set(value As ModeloParidadCambiaria)
            _ParidadCambiaria = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS"
    Public Function Insertar() As RespuestaHTTP(Of Boolean)
        Try
            Monedas.Moneda = ParidadCambiaria.AscMonedas.Moneda

            Dim registro As ModeloMonedas = Monedas.ConsultarPorNombre()

            If Not IsNothing(registro) Then
                ParidadCambiaria.AscMonedas.IdMonedas = registro.IdMonedas

                If ParidadCambiaria.Insertar() Then
                    Return New RespuestaHTTP(Of Boolean)(True, Nothing)
                Else
                    Return New RespuestaHTTP(Of Boolean)(False, ParidadCambiaria.Err)
                End If
            Else
                Return New RespuestaHTTP(Of Boolean)(False, Monedas.Err)
            End If
        Catch ex As Exception
            Return New RespuestaHTTP(Of Boolean)(False, New Errores With {.Identificador = EnumErrores.ERROR_DESCONOCIDO, .Descripcion = ex.Message})
        End Try
    End Function
#End Region
End Class
