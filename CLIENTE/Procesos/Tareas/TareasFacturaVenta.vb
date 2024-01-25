Imports Comunicacion

Public Class TareasFacturaVenta
    Inherits EnlaceTransacciones(Of TransaccionesFacturaVenta)

    Private _Err As Errores
    Private _FechaVtoCAE As Date
    Private _CAE As String

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

    Public Property FechaVtoCAE As Date
        Get
            Return _FechaVtoCAE
        End Get
        Set(value As Date)
            _FechaVtoCAE = value
        End Set
    End Property

    Public Property CAE As String
        Get
            Return _CAE
        End Get
        Set(value As String)
            _CAE = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS ACCESO A COMUNICACIONES"
    Public Async Function Servicio_Insertar(_FacturaVenta As FacturaVenta, _FacturaVentaMoneda As FacturaVentaMonedas, _CuentaCorrienteVenta As CuentaCorrienteVenta, _Numeracion As Numeracion, _DetalleFacturaVenta As List(Of FacturaVentaDetalle),
                                            _RemitosVentaMovimientos As List(Of RemitoVentaMovimientos), _PedidosMovimientos As List(Of PedidosMovimientos), _FacturaVentaMovimientos As List(Of FacturaVentaMovimientos),
                                            _Movimientos_Factura_Reserva As List(Of Movimientos_Factura_Reserva), _Movimientos_Remito_Factura As List(Of Movimientos_Remito_Factura)) As Task(Of Boolean)
        Try
            Dim result As FEResultCAE = Await Transaccion.Servicio_insRegistro(New ServicioFacturaVenta With {
                                                        .FacturaVenta = Drivers.FacturaVenta(_FacturaVenta),
                                                        .FacturaVentaMoneda = Drivers.FacturaVentaMonedas(_FacturaVentaMoneda),
                                                        .Numeracion = Drivers.Numeracion(_Numeracion),
                                                        .CuentaCorritenteVenta = Drivers.CuentaCorrienteVenta(_CuentaCorrienteVenta),
                                                        .FacturaVentaDetalle = Drivers.FacturaVentaDetalle(_DetalleFacturaVenta),
                                                        .RemitosVentaMovimientos = Drivers.RemitosVentaMovimientos(_RemitosVentaMovimientos),
                                                        .PedidosMovimientos = Drivers.PedidosMovimientos(_PedidosMovimientos),
                                                        .Movimientos_Remito_Factura = Drivers.Movimientos_Remito_Factura(_Movimientos_Remito_Factura),
                                                        .Movimientos_Factura_Reserva = Drivers.Movimientos_Factura_Reserva(_Movimientos_Factura_Reserva),
                                                        .FacturaVentaMovimientos = Drivers.FacturaVentaMovimientos(_FacturaVentaMovimientos)
                                                   })

            CAE = result.CAE
            FechaVtoCAE = CDate(Mid(result.FchVtoCAE, 1, 4) & "/" & Mid(result.FchVtoCAE, 5, 2) & "/" & Mid(result.FchVtoCAE, 7, 2))

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
