Imports Comunicacion

Public Class TareasDetalleRemitoCompra
    Inherits EnlaceTransacciones(Of TransaccionesDetalleRemitoCompra)

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

    Public Async Function ListadoDetalleRemitoCompra(idRemitoCompra As Integer) As Task(Of List(Of DetalleRemitoCompra))
        Try
            Dim list As New List(Of DetalleRemitoCompra)

            For Each item In Await Transaccion.verRegistrosPorIdRemtiosCompra(idRemitoCompra)
                list.Add(Drivers.DetalleRemitoCompra(item))
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

    Public Async Function verDetalleRemitosCompraSinFacturarIdProveedor(idProv As Integer) As Task(Of List(Of DetalleRemitoCompra))
        Try
            Dim list As New List(Of DetalleRemitoCompra)

            For Each item In Await Transaccion.verRegistrosSinFacturar_idProveedor(idProv)
                list.Add(Drivers.DetalleRemitoCompra(item))
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

    Public Async Function verCantidad(Id As Integer) As Task(Of Double)
        Try
            Return Await Transaccion.verCantidad(Id)
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
    Public Shared Sub LlenarDGV(ByRef DGV As Windows.Forms.DataGridView, _lisDRC As List(Of DetalleRemitoCompra))
        For Each Item In _lisDRC
            DGV.Rows.Add(Item.IdDetalleRemitosCompra, Item.AscArticulos.IdArticulo, Item.Descripcion,
                         Item.Cantidad, Item.Unidad, Format(Item.Precio, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"),
                         Format(Item.Importe, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"), Item.AlicuotaIVA, Item.Facturado, Item.AscArticulos.CodArticulo)
        Next
    End Sub

    Private Shared Function CountRem(ByRef DGV As Windows.Forms.DataGridView, ByVal idDetRem As Integer) As Integer
        Dim Count As Double = 0

        For Each item As Windows.Forms.DataGridViewRow In DGV.Rows
            If idDetRem = item.Cells("idDetalleRemitoCompra").Value Then
                Count = Count + UtilidadesVarias.SoloNumeros(item.Cells("Cantidad").Value)
            End If
        Next

        Return Count
    End Function
#End Region

End Class
