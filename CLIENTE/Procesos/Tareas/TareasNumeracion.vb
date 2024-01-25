Imports Comunicacion

Public Class TareasNumeracion
    Inherits EnlaceTransacciones(Of TransaccionesNumeracion)

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
    Public Async Function Insertar(_Numeracion As Numeracion) As Task(Of Boolean)
        Try
            Await Transaccion.insRegistro(Drivers.Numeracion(_Numeracion))

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

    Public Async Function Modificar(_Numeracion As Numeracion) As Task(Of Boolean)
        Try
            Await Transaccion.modRegistro(Drivers.Numeracion(_Numeracion))

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

    Public Async Function ListadoCompleto() As Task(Of List(Of Numeracion))
        Try
            Dim list As New List(Of Numeracion)

            For Each item In Await Transaccion.verRegistros()
                list.Add(Drivers.Numeracion(item))
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
    Public Shared Sub LlenarDGV(ByRef DGV As Windows.Forms.DataGridView, _list As List(Of Numeracion))
        For Each Item In _list
            DGV.Rows.Add(Item.IdNumeracion, Item.PuntoVenta, Item.Descripcion, Item.NroReserva, Item.NroRemito, Item.NroRecibo,
                         Item.NroOrdenCompra, Item.NroFacturaA, Item.NroFacturaB, Item.NroFacturaC, Item.NroFacturaX, Item.NroNotaCreditoA,
                         Item.NroNotaCreditoB, Item.NroNotaCreditoC, Item.NroNotaCreditoX, Item.NroNotaDebitoA, Item.NroNotaDebitoB, Item.NroNotaDebitoC,
                         Item.NroNotaDebitoX, Item.NroRecibo, Item.NroOrdenCompra, Item.Eliminado, Item.AscUsuarios.IdUsuario)
        Next
    End Sub
#End Region
End Class
