Imports Comunicacion

Public Class TareasFacturaCompraDetalle
    Inherits EnlaceTransacciones(Of TransaccionesFacturaCompraDetalle)

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
    Public Async Function verFacturasCompraDetalleSinRemitarIdProveedor(idProveedor As Integer) As Task(Of List(Of FacturaCompraDetalle))
        Try
            Dim list As New List(Of FacturaCompraDetalle)

            For Each item In Await Transaccion.verRegistrosSinRemitar_idProveedor(idProveedor)
                list.Add(Drivers.FacturaCompraDetalle(item))
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

    Public Async Function verFacturaCompraPorID(Id As Integer) As Task(Of List(Of FacturaCompraDetalle))
        Try
            Dim list As New List(Of FacturaCompraDetalle)

            For Each item In Await Transaccion.verRegistrosPorIdFacturaCompra(Id)
                list.Add(Drivers.FacturaCompraDetalle(item))
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
