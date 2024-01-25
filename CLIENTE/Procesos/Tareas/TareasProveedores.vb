Imports Comunicacion
Public Class TareasProveedores
    Inherits EnlaceTransacciones(Of TransaccionesProveedores)

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
    Public Async Function ListadoCompleto() As Task(Of List(Of Proveedores))
        Try
            Dim list As New List(Of Proveedores)

            For Each item In Await Transaccion.verRegistros()
                list.Add(Drivers.Proveedores(item))
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

    Public Async Function Servicio_Insertar(_Proveedores As Proveedores) As Task(Of Boolean)
        Try
            Await Transaccion.Servicio_insRegistro(Drivers.Proveedores(_Proveedores))

            Return True
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return False
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return False
        End Try
    End Function

    Public Async Function Servicio_Modificar(_Proveedores As Proveedores) As Task(Of Boolean)
        Try
            Await Transaccion.Servicio_modRegistro(Drivers.Proveedores(_Proveedores))

            Return True
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return False
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return False
        End Try
    End Function

    Public Async Function Eliminar(id As Integer) As Task(Of Boolean)
        Try
            Await Transaccion.elimRegistro(id)

            Return True
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return False
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return False
        End Try
    End Function
#End Region

#Region "METODOS PUBLICOS UTILIDADES"
    Public Shared Sub LlenarDGV(ByRef DGV As Windows.Forms.DataGridView, _listProveedores As List(Of Proveedores))
        For Each Item In _listProveedores
            DGV.Rows.Add(Item.IdProveedor, Format(CDate(Item.FechaAlta), "dd/MM/yyyy"), Item.RazonSocial, Item.Direccion, Item.Localidad, Item.Provincia, Item.CodPostal,
                         Item.Pais, Item.Telefono, Item.Mail, Item.Web, Item.CUIT, Item.IIBB, Item.SituacionIVA, Item.Estado,
                         Item.Eliminado, Item.AscUsuarios.IdUsuario)

        Next
    End Sub

#End Region


End Class
