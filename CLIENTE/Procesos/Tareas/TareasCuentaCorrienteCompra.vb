Imports Comunicacion

Public Class TareasCuentaCorrienteCompra
    Inherits EnlaceTransacciones(Of TransaccionesCtaCteCompra)

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
    Public Async Function ListadoIdProveedor(idProveedor As Integer) As Task(Of List(Of CuentaCorrienteCompra))
        Try
            Return Drivers.CuentaCorrienteCompra(Await Transaccion.verPorIdProveedores(idProveedor))
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
