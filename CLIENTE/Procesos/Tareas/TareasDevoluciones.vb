Imports Comunicacion

Public Class TareasDevoluciones
    Inherits EnlaceTransacciones(Of TransaccionesDevoluciones)

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
    Public Async Function Servicio_Insertar(_Devoluciones As Devoluciones, _CuentaCorrienteVenta As CuentaCorrienteVenta, _Numeracion As Numeracion, _Stock As List(Of Stock),
                                            _DetalleDevoluciones As List(Of DetalleDevoluciones), _RemitosVentaMovimientos As List(Of RemitoVentaMovimientos),
                                            _FacturaVentaMovimientos As List(Of FacturaVentaMovimientos), _Movimientos_Remito_Factura As List(Of Movimientos_Remito_Factura)) As Task(Of Boolean)
        Try
            Await Transaccion.Servicio_insRegistro(New ServicioDevoluciones With {
                                                        .Devoluciones = Drivers.Devoluciones(_Devoluciones),
                                                        .CuentaCorritenteVenta = Drivers.CuentaCorrienteVenta(_CuentaCorrienteVenta),
                                                        .Numeracion = Drivers.Numeracion(_Numeracion),
                                                        .Stock = Drivers.Stock(_Stock),
                                                        .DetallesDevoluciones = Drivers.DetalleDevoluciones(_DetalleDevoluciones),
                                                        .RemitosVentaMovimientos = Drivers.RemitosVentaMovimientos(_RemitosVentaMovimientos),
                                                        .FacturaVentaMovimientos = Drivers.FacturaVentaMovimientos(_FacturaVentaMovimientos),
                                                        .Movimientos_Remito_Factura = Drivers.Movimientos_Remito_Factura(_Movimientos_Remito_Factura)
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
