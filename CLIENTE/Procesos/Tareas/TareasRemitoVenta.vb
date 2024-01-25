Imports Comunicacion

Public Class TareasRemitoVenta
    Inherits EnlaceTransacciones(Of TransaccionesRemitosVenta)

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
    Public Async Function Servicio_Insertar(_RemitoVenta As RemitoVenta, _RemitoVentaMon As RemitoVentaMonedas, _Numeracion As Numeracion, _DetalleRemitoVenta As List(Of DetalleRemitoVenta),
                                            _RemitosVentaMovimientos As List(Of RemitoVentaMovimientos), _PedidosMovimientos As List(Of PedidosMovimientos), _FacturaVentaMovimientos As List(Of FacturaVentaMovimientos),
                                            _Movimientos_Reserva_Remito As List(Of Movimientos_Reserva_Remito), _Movimientos_Remito_Factura As List(Of Movimientos_Remito_Factura)) As Task(Of Boolean)
        Try
            Dim _ModeloDetalleRemitoVenta As New List(Of ModeloDetalleRemitoVenta)
            Dim _ModeloRemitosVentaMovimientos As New List(Of ModeloRemitosVentaMovimientos)
            Dim _ModeloPedidosMovimientos As New List(Of ModeloPedidoMovimientos)
            Dim _ModeloFacturaVentaMovimientos As New List(Of ModeloFacturaVentaMovimientos)
            Dim _ModeloMovimientos_Reserva_Remito As New List(Of ModeloMovimientos_Reserva_Remito)
            Dim _ModeloMovimientos_Remito_Factura As New List(Of ModeloMovimientos_Remito_Factura)

            For Each item In _DetalleRemitoVenta
                _ModeloDetalleRemitoVenta.Add(Drivers.DetalleRemitoVenta(item))
            Next

            For Each item In _RemitosVentaMovimientos
                _ModeloRemitosVentaMovimientos.Add(Drivers.RemitosVentaMovimientos(item))
            Next

            For Each item In _PedidosMovimientos
                _ModeloPedidosMovimientos.Add(Drivers.PedidosMovimientos(item))
            Next

            For Each item In _Movimientos_Reserva_Remito
                _ModeloMovimientos_Reserva_Remito.Add(Drivers.Movimientos_Reserva_Remito(item))
            Next

            For Each item In _Movimientos_Remito_Factura
                _ModeloMovimientos_Remito_Factura.Add(Drivers.Movimientos_Remito_Factura(item))
            Next

            For Each item In _FacturaVentaMovimientos
                _ModeloFacturaVentaMovimientos.Add(Drivers.FacturaVentaMovimientos(item))
            Next

            Await Transaccion.Servicio_insRegistro(New ServicioRemitoVenta With {
                                                        .RemitoVenta = Drivers.RemitoVenta(_RemitoVenta),
                                                        .RemitoVentaMonedas = Drivers.RemitoVentaMonedas(_RemitoVentaMon),
                                                        .Numeracion = Drivers.Numeracion(_Numeracion),
                                                        .DetallesRemitosVenta = _ModeloDetalleRemitoVenta,
                                                        .RemitosVentaMovimientos = _ModeloRemitosVentaMovimientos,
                                                        .PedidosMovimientos = _ModeloPedidosMovimientos,
                                                        .Movimientos_Remito_Factura = _ModeloMovimientos_Remito_Factura,
                                                        .Movimientos_Reserva_Remito = _ModeloMovimientos_Reserva_Remito,
                                                        .FacturaVentaMovimientos = _ModeloFacturaVentaMovimientos
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

    Public Async Function Servicio_Modificar(_RemitoVenta As RemitoVenta, _RemitoVentaMon As RemitoVentaMonedas, _DetalleRemitoVenta As List(Of DetalleRemitoVenta), _RemitosVentaMovimientos As List(Of RemitoVentaMovimientos),
                                             _PedidosMovimientos As List(Of PedidosMovimientos), _FacturaVentaMovimientos As List(Of FacturaVentaMovimientos),
                                             _Movimientos_Reserva_Remito As List(Of Movimientos_Reserva_Remito), _Movimientos_Remito_Factura As List(Of Movimientos_Remito_Factura)) As Task(Of Boolean)
        Try
            Dim _ModeloDetalleRemitoVenta As New List(Of ModeloDetalleRemitoVenta)
            Dim _ModeloRemitosVentaMovimientos As New List(Of ModeloRemitosVentaMovimientos)
            Dim _ModeloPedidosMovimientos As New List(Of ModeloPedidoMovimientos)
            Dim _ModeloFacturaVentaMovimientos As New List(Of ModeloFacturaVentaMovimientos)
            Dim _ModeloMovimientos_Reserva_Remito As New List(Of ModeloMovimientos_Reserva_Remito)
            Dim _ModeloMovimientos_Remito_Factura As New List(Of ModeloMovimientos_Remito_Factura)

            For Each item In _DetalleRemitoVenta
                _ModeloDetalleRemitoVenta.Add(Drivers.DetalleRemitoVenta(item))
            Next

            For Each item In _RemitosVentaMovimientos
                _ModeloRemitosVentaMovimientos.Add(Drivers.RemitosVentaMovimientos(item))
            Next

            For Each item In _PedidosMovimientos
                _ModeloPedidosMovimientos.Add(Drivers.PedidosMovimientos(item))
            Next

            For Each item In _Movimientos_Reserva_Remito
                _ModeloMovimientos_Reserva_Remito.Add(Drivers.Movimientos_Reserva_Remito(item))
            Next

            For Each item In _Movimientos_Remito_Factura
                _ModeloMovimientos_Remito_Factura.Add(Drivers.Movimientos_Remito_Factura(item))
            Next

            For Each item In _FacturaVentaMovimientos
                _ModeloFacturaVentaMovimientos.Add(Drivers.FacturaVentaMovimientos(item))
            Next

            Await Transaccion.Servicio_modRegistro(New ServicioRemitoVenta With {
                                                        .RemitoVenta = Drivers.RemitoVenta(_RemitoVenta),
                                                        .RemitoVentaMonedas = Drivers.RemitoVentaMonedas(_RemitoVentaMon),
                                                        .DetallesRemitosVenta = _ModeloDetalleRemitoVenta,
                                                        .RemitosVentaMovimientos = _ModeloRemitosVentaMovimientos,
                                                        .PedidosMovimientos = _ModeloPedidosMovimientos,
                                                        .Movimientos_Remito_Factura = _ModeloMovimientos_Remito_Factura,
                                                        .Movimientos_Reserva_Remito = _ModeloMovimientos_Reserva_Remito,
                                                        .FacturaVentaMovimientos = _ModeloFacturaVentaMovimientos
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

    Public Async Function Servicio_Eliminar(_RemitoVenta As RemitoVenta, _RemitoVentaMon As RemitoVentaMonedas) As Task(Of Boolean)
        Try
            Await Transaccion.Servicio_elimRegistro(New ServicioRemitoVenta With {
                                                        .RemitoVenta = Drivers.RemitoVenta(_RemitoVenta),
                                                        .RemitoVentaMonedas = Drivers.RemitoVentaMonedas(_RemitoVentaMon)
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

    Public Async Function ListadoCompleto() As Task(Of List(Of RemitoVenta))
        Try
            Dim list As New List(Of RemitoVenta)

            For Each item In Await Transaccion.verRegistros()
                list.Add(Drivers.RemitoVenta(item))
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

    Public Async Function ListadoSinFacturar() As Task(Of List(Of RemitoVenta))
        Try
            Dim list As New List(Of RemitoVenta)

            For Each item In Await Transaccion.verSinFacturar()
                list.Add(Drivers.RemitoVenta(item))
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
#End Region

End Class
