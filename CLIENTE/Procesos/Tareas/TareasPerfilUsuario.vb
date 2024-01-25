Imports Comunicacion

Public Class TareasPerfilUsuario
    Inherits EnlaceTransacciones(Of TransaccionesPerfilUsuario)

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
    Public Async Function ServicioInsertar(_Perfil As PerfilUsuario) As Task(Of Boolean)
        Try
            Await Transaccion.Servicio_insRegistro(Drivers.PerfilesUsuario(_Perfil))

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

    Public Async Function ServicioModificar(_Perfil As PerfilUsuario) As Task(Of Boolean)
        Try
            Await Transaccion.Servicio_modRegistro(Drivers.PerfilesUsuario(_Perfil))

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

    Public Async Function ServicioEliminar(id As Integer) As Task(Of Boolean)
        Try
            Await Transaccion.Servicio_eliminar(id)

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

    Public Async Function ConsultarPorId(id As Integer) As Task(Of PerfilUsuario)
        Try
            Return Drivers.PerfilesUsuario(Await Transaccion.verPerfilUsuarioID(id))
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

    Public Async Function ListadoCompleto() As Task(Of List(Of PerfilUsuario))
        Try
            Dim list As New List(Of PerfilUsuario)

            For Each item In Await Transaccion.verRegistros()
                list.Add(Drivers.PerfilesUsuario(item))
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
