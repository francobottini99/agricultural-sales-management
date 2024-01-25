Imports Comunicacion

Public Class TareasComprobantes
    Inherits EnlaceTransacciones(Of TransaccionesComprobantes)

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
    Public Async Function ListadoCompleto() As Task(Of List(Of Comprobantes))
        Try
            Dim list As New List(Of Comprobantes)

            For Each item In Await Transaccion.verRegistros()
                list.Add(Drivers.Comprobantes(item))
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

    Public Async Function Insertar(_Comprobante As Comprobantes) As Task(Of Boolean)
        Try
            Await Transaccion.insRegistro(Drivers.Comprobantes(_Comprobante))

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
    Public Async Function Modificar(_Comprobante As Comprobantes) As Task(Of Boolean)
        Try
            Await Transaccion.modRegistro(Drivers.Comprobantes(_Comprobante))

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
    Public Shared Sub LlenarDGV(ByRef DGV As Windows.Forms.DataGridView, _listComprobantes As List(Of Comprobantes))
        For Each Item In _listComprobantes
            DGV.Rows.Add(Item.IdComprobantes, Item.Nombre, Item.Copias, Item.Tipo, Item.Leyenda, Item.Encabezado, Item.LeyendaEnc,
                         Item.Pie, Item.LeyendaPie, Item.CantidadCompEmitidos, Item.CantidadCopiasComp, Item.Eliminado, Item.AscUsuarios.IdUsuario)
        Next
    End Sub
#End Region

End Class
