Imports Comunicacion

Public Class TareasRubros
    Inherits EnlaceTransacciones(Of TransaccionesRubro)

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
    Public Async Function Servicio_Insertar(_Rubro As Rubros) As Task(Of Boolean)
        Try
            Await Transaccion.Servicio_insRegistro(Drivers.Rubros(_Rubro))

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

    Public Async Function Servicio_Modificar(_Rubro As Rubros) As Task(Of Boolean)
        Try
            Await Transaccion.Servicio_modRegistro(Drivers.Rubros(_Rubro))

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

    Public Async Function ListadoCompleto() As Task(Of List(Of Rubros))
        Try
            Dim list As New List(Of Rubros)

            For Each item In Await Transaccion.verRegistros()
                list.Add(Drivers.Rubros(item))
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

    Public Async Function Eliminar(id As Integer) As Task(Of Boolean)
        Try
            Await Transaccion.Servicio_eliRegistro(id)

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
    Public Shared Sub LlenarDGV(ByRef DGV As Windows.Forms.DataGridView, _listRubros As List(Of Rubros))
        For Each Item In _listRubros
            DGV.Rows.Add(Item.IdRubro, Item.AscUsuarios.IdUsuario, Item.Descripcion, Item.Abrebiatura, Item.AscUsuarios.Nombre)
        Next
    End Sub
#End Region
End Class
