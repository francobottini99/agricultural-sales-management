Imports Comunicacion

Public Class TareasUsuario
    Inherits EnlaceTransacciones(Of TransaccionesUsuarios)

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
    Public Async Function Servicio_Insertar(_Usuario As Usuario) As Task(Of Boolean)
        Try
            Await Transaccion.Servicio_insRegistro(Drivers.Usuario(_Usuario))

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

    Public Async Function Servicio_Modificar(_Usuario As Usuario) As Task(Of Boolean)
        Try
            Await Transaccion.Servicio_modRegistro(Drivers.Usuario(_Usuario))

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

    Public Async Function FinalizarSesion(_Usuario As Usuario) As Task(Of Boolean)
        Try
            Await Transaccion.modFinalizarSesion(Drivers.Usuario(_Usuario))

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

    Public Async Function ObtenerCredenciales(nombre As String, contraseña As String) As Task(Of Usuario)
        Try
            Return Drivers.Usuario(Await Transaccion.verRegistroPorNombreYContraseña(nombre, contraseña))
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

    Public Async Function ListadoCompleto() As Task(Of List(Of Usuario))
        Try
            Dim list As New List(Of Usuario)

            For Each item In Await Transaccion.verRegistros()
                list.Add(Drivers.Usuario(item))
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

#Region "METODOS PUBLICOS UTILIDADES"
    Public Shared Sub LlenarDGV(ByRef DGV As Windows.Forms.DataGridView, _listDepositos As List(Of Usuario))
        For Each Item In _listDepositos
            DGV.Rows.Add(Item.IdUsuario, Item.AscPerfilUs.IdPerfil, Format(CDate(Item.FechaAlta), "dd/MM/yyyy"),
                                 Item.Tipo, Item.Nombre, Item.Contraseña, Item.Estado, Item.AscPerfilUs.NombrePerfil,
                                 System.Drawing.Image.FromStream(New System.IO.MemoryStream(Convert.FromBase64String(Item.Imagen))))
        Next
    End Sub
#End Region
End Class
