Imports Comunicacion

Public Class TareasRemitoCompra
    Inherits EnlaceTransacciones(Of TransaccionesRemitoCompra)

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
    Public Async Function ListadoCompleto() As Task(Of List(Of RemitoCompra))
        Try
            Dim list As New List(Of RemitoCompra)

            For Each item In Await Transaccion.verRegistros()
                list.Add(Drivers.RemitoCompra(item))
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

    Public Async Function ListadoSinFacturar() As Task(Of List(Of RemitoCompra))
        Try
            Dim list As New List(Of RemitoCompra)

            For Each item In Await Transaccion.verSinFacturar()
                list.Add(Drivers.RemitoCompra(item))
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

    Public Async Function verRemitosPorID(Id) As Task(Of RemitoCompra)
        Try

            Return Drivers.RemitoCompra(Await Transaccion.verRegistroPorId(Id))

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

    Public Async Function UltimoID() As Task(Of Integer)
        Try
            Return Await Transaccion.verUltimoId
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

    Public Async Function Servicio_Insertar(_RemitoCompra As RemitoCompra, _RemitoCompraMon As RemitoCompraMonedas, _DetalleRemitoCompra As List(Of DetalleRemitoCompra),
                                            _RemitosCompraMovimientos As List(Of RemitoCompraMovimientos), _FacturaCompraMovimientos As List(Of FacturaCompraMovimientos),
                                            _Movimientos_Remito_Factura As List(Of Movimientos_RemitoCompra_FacturaCompra)) As Task(Of Boolean)
        Try
            Dim _ModeloDetalleRemitoCompra As New List(Of ModeloDetalleRemitoCompra)
            Dim _ModeloRemitosCompraMovimientos As New List(Of ModeloRemitosCompraMovimientos)
            Dim _ModeloFacturaCompraMovimientos As New List(Of ModeloFacturaCompraMovimientos)
            Dim _ModeloMovimientos_Remito_Factura As New List(Of ModeloMovimientos_RemitoCompra_FacturaCompra)

            For Each item In _DetalleRemitoCompra
                _ModeloDetalleRemitoCompra.Add(Drivers.DetalleRemitoCompra(item))
            Next

            For Each item In _RemitosCompraMovimientos
                _ModeloRemitosCompraMovimientos.Add(Drivers.RemitosCompraMovimientos(item))
            Next

            For Each item In _Movimientos_Remito_Factura
                _ModeloMovimientos_Remito_Factura.Add(Drivers.Movimientos_RemitoCompra_FacturaCompra(item))
            Next

            For Each item In _FacturaCompraMovimientos
                _ModeloFacturaCompraMovimientos.Add(Drivers.FacturaCompraMovimientos(item))
            Next


            Await Transaccion.Servicio_insRegistro(New ServicioRemitoCompra With {
                                                        .RemitoCompra = Drivers.RemitoCompra(_RemitoCompra),
                                                        .RemitoCompraMoneda = Drivers.RemitoCompraMonedas(_RemitoCompraMon),
                                                        .DetalleRemitoCompra = _ModeloDetalleRemitoCompra,
                                                        .RemitosCompraMovimientos = _ModeloRemitosCompraMovimientos,
                                                        .FacturaCompraMovimientos = _ModeloFacturaCompraMovimientos,
                                                        .Movimientos_Remito_Factura = _ModeloMovimientos_Remito_Factura
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

    Public Async Function Servicio_Modificar(_RemitoCompra As RemitoCompra, _RemitoCompraMon As RemitoCompraMonedas, _DetalleRemitoCompra As List(Of DetalleRemitoCompra),
                                            _RemitosCompraMovimientos As List(Of RemitoCompraMovimientos), _FacturaCompraMovimientos As List(Of FacturaCompraMovimientos),
                                            _Movimientos_Remito_Factura As List(Of Movimientos_RemitoCompra_FacturaCompra)) As Task(Of Boolean)
        Try
            Dim _ModeloDetalleRemitoCompra As New List(Of ModeloDetalleRemitoCompra)
            Dim _ModeloRemitosCompraMovimientos As New List(Of ModeloRemitosCompraMovimientos)
            Dim _ModeloFacturaCompraMovimientos As New List(Of ModeloFacturaCompraMovimientos)
            Dim _ModeloMovimientos_Remito_Factura As New List(Of ModeloMovimientos_RemitoCompra_FacturaCompra)

            For Each item In _DetalleRemitoCompra
                _ModeloDetalleRemitoCompra.Add(Drivers.DetalleRemitoCompra(item))
            Next

            For Each item In _RemitosCompraMovimientos
                _ModeloRemitosCompraMovimientos.Add(Drivers.RemitosCompraMovimientos(item))
            Next

            For Each item In _Movimientos_Remito_Factura
                _ModeloMovimientos_Remito_Factura.Add(Drivers.Movimientos_RemitoCompra_FacturaCompra(item))
            Next

            For Each item In _FacturaCompraMovimientos
                _ModeloFacturaCompraMovimientos.Add(Drivers.FacturaCompraMovimientos(item))
            Next


            Await Transaccion.Servicio_modRegistro(New ServicioRemitoCompra With {
                                                        .RemitoCompra = Drivers.RemitoCompra(_RemitoCompra),
                                                        .RemitoCompraMoneda = Drivers.RemitoCompraMonedas(_RemitoCompraMon),
                                                        .DetalleRemitoCompra = _ModeloDetalleRemitoCompra,
                                                        .RemitosCompraMovimientos = _ModeloRemitosCompraMovimientos,
                                                        .FacturaCompraMovimientos = _ModeloFacturaCompraMovimientos,
                                                        .Movimientos_Remito_Factura = _ModeloMovimientos_Remito_Factura
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

    Public Async Function Servicio_Eliminar(_RemitoCompra As RemitoCompra, _RemitoCompraMon As RemitoCompraMonedas) As Task(Of Boolean)
        Try
            Await Transaccion.Servicio_elimRegistro(New ServicioRemitoCompra With {
                                                        .RemitoCompra = Drivers.RemitoCompra(_RemitoCompra),
                                                        .RemitoCompraMoneda = Drivers.RemitoCompraMonedas(_RemitoCompraMon)
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

#Region "METODOS PUBLICOS UTILIDADES"
    Public Shared Sub LlenarDGV(ByRef DGV As Windows.Forms.DataGridView, _listRemitosCompra As List(Of RemitoCompra))
        For Each Item In _listRemitosCompra
            DGV.Rows.Add(Item.IdRemitosCompra, Item.AscProveedores.IdProveedor, Item.AscUsuarios.IdUsuario, Format(Item.Fecha, "dd/MM/yyyy"),
                         Item.NroComprobante, Item.AscProveedores.RazonSocial, Format(Item.Importe, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"), Item.Facturado, Item.Observaciones)
        Next
    End Sub
#End Region
End Class
