Imports Comunicacion

Public Class TareasParidadCamb
    Inherits EnlaceTransacciones(Of TransaccionesParidadCambiaria)

    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        Err = New Errores()
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property Err As Errores
        Get
            Return _Err
        End Get
        Set(value As Errores)
            _Err = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS ACCESO A COMUNICACIONES"

    Public Async Function ListadoPorIdMoneda(Id As Integer) As Task(Of List(Of ParidadCambiaria))
        Try
            Dim list As New List(Of ParidadCambiaria)

            For Each item In Await Transaccion.verRegistrosPorIdMonedas(Id)
                list.Add(Drivers.ParidadCambiaria(item))
            Next

            Return list
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return Nothing
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return Nothing
        End Try
    End Function
#End Region
End Class
