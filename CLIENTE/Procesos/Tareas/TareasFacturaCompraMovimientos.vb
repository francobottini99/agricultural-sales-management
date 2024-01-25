Imports Comunicacion

Public Class TareasFacturaCompraMovimientos
    Inherits EnlaceTransacciones(Of TransaccionesFacturaCompraMovimientos)

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
    Public Async Function ListadoPorIdFacturaCompra(id As Integer) As Task(Of List(Of FacturaCompraMovimientos))
        Try
            Dim list As New List(Of FacturaCompraMovimientos)

            For Each item In Await Transaccion.verRegistrosPorIdFacturaCompra(id)
                list.Add(Drivers.FacturaCompraMovimientos(item))
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
