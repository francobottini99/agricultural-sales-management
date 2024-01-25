Imports Comunicacion

Public Class TareasFacturaCompra
    Inherits EnlaceTransacciones(Of TransaccionesFacturaCompra)

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

    Public Async Function verFacturaCompra() As Task(Of List(Of FacturaCompra))
        Try
            Dim list As New List(Of FacturaCompra)

            For Each item In Await Transaccion.verRegistros()
                list.Add(Drivers.FacturaCompra(item))
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

    Public Async Function Servicio_Eliminar(_FacturaCompra As FacturaCompra, _FacturaCompraMoneda As FacturaCompraMonedas, _CuentaCorritenteCompra As CuentaCorrienteCompra) As Task(Of Boolean)
        Try
            Await Transaccion.Servicio_elimRegistro(New ServicioFacturaCompra With {
                                                        .FacturaCompra = Drivers.FacturaCompra(_FacturaCompra),
                                                        .FacturaCompraMoneda = Drivers.FacturaCompraMonedas(_FacturaCompraMoneda),
                                                        .CuentaCorritenteCompra = Drivers.CuentaCorrienteCompra(_CuentaCorritenteCompra)
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

    Public Async Function Servicio_Insertar(_FacturaCompra As FacturaCompra, _CuentaCorritenteCompra As CuentaCorrienteCompra, _FacturaCompraMoneda As FacturaCompraMonedas, _DetalleFacturaCompra As List(Of FacturaCompraDetalle),
                                            _RemitosCompraMovimientos As List(Of RemitoCompraMovimientos), _FacturaCompraMovimientos As List(Of FacturaCompraMovimientos), _Movimientos_Remito_Factura As List(Of Movimientos_RemitoCompra_FacturaCompra)) As Task(Of Boolean)
        Try
            Dim _ModeloFacturaCompraDetalle As New List(Of ModeloFacturaCompraDetalle)
            Dim _ModeloRemitosCompraMovimientos As New List(Of ModeloRemitosCompraMovimientos)
            Dim _ModeloFacturaCompraMovimientos As New List(Of ModeloFacturaCompraMovimientos)
            Dim _ModeloMovimientos_Remito_Factura As New List(Of ModeloMovimientos_RemitoCompra_FacturaCompra)

            For Each item In _DetalleFacturaCompra
                _ModeloFacturaCompraDetalle.Add(Drivers.FacturaCompraDetalle(item))
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

            Await Transaccion.Servicio_insRegistro(New ServicioFacturaCompra With {
                                                        .FacturaCompra = Drivers.FacturaCompra(_FacturaCompra),
                                                        .FacturaCompraDetalle = _ModeloFacturaCompraDetalle,
                                                        .CuentaCorritenteCompra = Drivers.CuentaCorrienteCompra(_CuentaCorritenteCompra),
                                                        .FacturaCompraMoneda = Drivers.FacturaCompraMonedas(_FacturaCompraMoneda),
                                                        .FacturaCompraMovimientos = _ModeloFacturaCompraMovimientos,
                                                        .RemitosCompraMovimientos = _ModeloRemitosCompraMovimientos,
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

    Public Async Function Servicio_Modificar(_FacturaCompra As FacturaCompra, _CuentaCorritenteCompra As CuentaCorrienteCompra, _FacturaCompraMoneda As FacturaCompraMonedas, _DetalleFacturaCompra As List(Of FacturaCompraDetalle),
                                            _RemitosCompraMovimientos As List(Of RemitoCompraMovimientos), _FacturaCompraMovimientos As List(Of FacturaCompraMovimientos), _Movimientos_Remito_Factura As List(Of Movimientos_RemitoCompra_FacturaCompra)) As Task(Of Boolean)
        Try
            Dim _ModeloFacturaCompraDetalle As New List(Of ModeloFacturaCompraDetalle)
            Dim _ModeloRemitosCompraMovimientos As New List(Of ModeloRemitosCompraMovimientos)
            Dim _ModeloFacturaCompraMovimientos As New List(Of ModeloFacturaCompraMovimientos)
            Dim _ModeloMovimientos_Remito_Factura As New List(Of ModeloMovimientos_RemitoCompra_FacturaCompra)

            For Each item In _DetalleFacturaCompra
                _ModeloFacturaCompraDetalle.Add(Drivers.FacturaCompraDetalle(item))
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

            Await Transaccion.Servicio_modRegistro(New ServicioFacturaCompra With {
                                                        .FacturaCompra = Drivers.FacturaCompra(_FacturaCompra),
                                                        .FacturaCompraDetalle = _ModeloFacturaCompraDetalle,
                                                        .CuentaCorritenteCompra = Drivers.CuentaCorrienteCompra(_CuentaCorritenteCompra),
                                                        .FacturaCompraMoneda = Drivers.FacturaCompraMonedas(_FacturaCompraMoneda),
                                                        .FacturaCompraMovimientos = _ModeloFacturaCompraMovimientos,
                                                        .RemitosCompraMovimientos = _ModeloRemitosCompraMovimientos,
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

#End Region

#Region "METODOS PUBLICOS UTILIDADES"
    Public Shared Sub LlenarDGV(ByRef DGV As Windows.Forms.DataGridView, _listFacturas As List(Of FacturaCompra))
        For Each Item In _listFacturas
            DGV.Rows.Add(Item.IdFacturaCompra, Item.AscProveedores.IdProveedor, Item.AscCuentaCorrienteCompra.IdCuentaCorrienteCompra, Format(Item.Fecha, "dd/MM/yyyy"),
                         Format(Item.FechaVto, "dd/MM/yyyy"), Item.ClaseComprobante, Item.AscProveedores.RazonSocial, Item.Prefijo, Item.NroComprobante, Format(Item.ImporteNeto, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"),
                         Format(Item.Iva, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"), Format(Item.ImporteTotal, DatosSesion._MonedaPPal.Simbolo + " ##,#0.00"), Item.Observaciones)
        Next
    End Sub
#End Region
End Class
