Imports Comunicacion

Public Class TareasBancos
    Inherits EnlaceTransacciones(Of TransaccionesBancos)

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
    Public Async Function Servicio_Insertar(_Banco As Bancos) As Task(Of Boolean)
        Try
            Await Transaccion.Servicio_insRegistro(Drivers.Bancos(_Banco))

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

    Public Async Function Servicio_Modificar(_Banco As Bancos) As Task(Of Boolean)
        Try
            Await Transaccion.Servicio_modRegistro(Drivers.Bancos(_Banco))

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

    Public Async Function ListadoCompleto() As Task(Of List(Of Bancos))
        Try
            Dim list As New List(Of Bancos)

            For Each item In Await Transaccion.verRegistros()
                list.Add(Drivers.Bancos(item))
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
    Public Shared Sub LlenarDGV(ByRef DGV As Windows.Forms.DataGridView, _listBancos As List(Of Bancos))
        For Each Item In _listBancos
            DGV.Rows.Add(Item.IdBancos, Item.Nombre, Item.Eliminado, Item.AscUsuarios.IdUsuario)
        Next
    End Sub
#End Region
End Class
