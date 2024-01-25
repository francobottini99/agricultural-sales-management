Imports Comunicacion

Public Class TareasDetalleRemitoVenta
    Inherits EnlaceTransacciones(Of TransaccionesDetalleRemitoVenta)

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
    Public Async Function ListadoDetalleRemitoVenta(idRemitoVenta As Integer) As Task(Of List(Of DetalleRemitoVenta))
        Try
            Dim list As New List(Of DetalleRemitoVenta)

            For Each item In Await Transaccion.verRegistrosPorIdRemitosVenta(idRemitoVenta)
                list.Add(Drivers.DetalleRemitoVenta(item))
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

    Public Async Function verDetalleRemitosVentaSinFacturarIdCliente(idCliente As Integer) As Task(Of List(Of DetalleRemitoVenta))
        Try
            Dim list As New List(Of DetalleRemitoVenta)

            For Each item In Await Transaccion.verRegistrosSinFacturar_idCliente(idCliente)
                list.Add(Drivers.DetalleRemitoVenta(item))
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

    Public Async Function verDetalleRemitosVentaIdCliente(idCliente As Integer) As Task(Of List(Of DetalleRemitoVenta))
        Try
            Return Drivers.DetalleRemitoVenta(Await Transaccion.verRegistrosPorIdCliente(idCliente))
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

    Public Async Function verDetalleRemitoVentaPorId(id As Integer) As Task(Of DetalleRemitoVenta)
        Try
            Return Drivers.DetalleRemitoVenta(Await Transaccion.verRegistroPorId(id))
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

    Public Async Function verDetalleRemitoPorIdClienteYFacturado(id As Integer, facturado As String) As Task(Of List(Of DetalleRemitoVenta))
        Try
            Dim list As New List(Of DetalleRemitoVenta)

            For Each item In Await Transaccion.verRegistrosPorIdClienteYFacturado(New ModeloDetalleRemitoVenta With {.AscRemitosVenta = New ModeloRemitosVenta With {.AscClientes = New ModeloCliente With {.IdCliente = id}}, .Facturado = facturado})
                list.Add(Drivers.DetalleRemitoVenta(item))
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
