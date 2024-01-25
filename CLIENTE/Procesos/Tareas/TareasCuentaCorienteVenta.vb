Imports Comunicacion

Public Class TareasCuentaCorienteVenta
    Inherits EnlaceTransacciones(Of TransaccionesCtaCteVenta)

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
    Public Async Function ListadoIdCliente(idCliente As Integer) As Task(Of List(Of CuentaCorrienteVenta))
        Try
            Return Drivers.CuentaCorrienteVenta(Await Transaccion.verPorIdCliente(idCliente))
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
