Imports Comunicacion

Public Class TareasMovimientos_Reserva_Remito
    Inherits EnlaceTransacciones(Of TransaccionesMovimientos_Reserva_Remito)

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
    Public Async Function ListadoMovimientosRemitoReservaPorIdRemitoVenta(id As Integer) As Task(Of List(Of Movimientos_Reserva_Remito))
        Try
            Dim list As New List(Of Movimientos_Reserva_Remito)

            For Each item In Await Transaccion.verRegistrosPorIdRemitosVenta(id)
                list.Add(Drivers.Movimientos_Reserva_Remito(item))
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
