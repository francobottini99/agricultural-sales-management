Imports Comunicacion

Public Class TareasRecibosVenta
    Inherits EnlaceTransacciones(Of TransaccionesRecibosVenta)

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
    Public Async Function Servicio_Insertar(_RecibosVenta As RecibosVenta, _Numeracion As Numeracion, _CuentaCorrienteVenta As CuentaCorrienteVenta, _RecibosVentaDetalle As List(Of RecibosVentaDetalle),
                                            _Caja As List(Of Caja), _MovimientoValores As List(Of MovimientoValores), _RecibosVentaMonedas As List(Of RecibosVentaMonedas)) As Task(Of Boolean)
        Try
            Dim RecibosVentaDetalle As New List(Of ModeloRecibosVentaDetalle)
            Dim Caja As New List(Of ModeloCaja)
            Dim MovimientoValores As New List(Of ModeloMovimientoValores)
            Dim RecibosVentaMonedas As New List(Of ModeloRecibosVentaMonedas)

            For Each item In _RecibosVentaDetalle
                RecibosVentaDetalle.Add(Drivers.RecibosVentaDetalle(item))
            Next

            For Each item In _Caja
                Caja.Add(Drivers.Caja(item))
            Next

            For Each item In _MovimientoValores
                MovimientoValores.Add(Drivers.MovimientoValores(item))
            Next

            For Each item In _RecibosVentaMonedas
                RecibosVentaMonedas.Add(Drivers.RecibosVentaMonedas(item))
            Next

            Await Transaccion.Servicio_insRegistro(New ServicioRecibosVenta With {
                                                        .RecibosVenta = Drivers.RecibosVenta(_RecibosVenta),
                                                        .Numeracion = Drivers.Numeracion(_Numeracion),
                                                        .CuentaCorrienteVenta = Drivers.CuentaCorrienteVenta(_CuentaCorrienteVenta),
                                                        .RecibosVentaDetalle = RecibosVentaDetalle,
                                                        .Caja = Caja,
                                                        .MovimientoValores = MovimientoValores,
                                                        .RecibosVentaMonedas = RecibosVentaMonedas
                                                   })

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
End Class
