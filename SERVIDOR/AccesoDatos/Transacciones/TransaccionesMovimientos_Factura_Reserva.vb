Imports MySql.Data.MySqlClient

Public Class TransaccionesMovimientos_Factura_Reserva
    Inherits Transacciones
    Implements ITransaccionesMovimientos_Factura_Reserva

    Public Function verRegistros() As List(Of TablaMovimientos_Factura_Reserva) Implements ITransaccionesGenericas(Of TablaMovimientos_Factura_Reserva).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaMovimientos_Factura_Reserva) As Integer Implements ITransaccionesGenericas(Of TablaMovimientos_Factura_Reserva).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@mfrFec", param.Fecha))
        parametros.Add(New MySqlParameter("@mfrTip", param.Tipo))
        parametros.Add(New MySqlParameter("@mfrCan", param.Cantidad))
        parametros.Add(New MySqlParameter("@mfrEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@mfrIdF", param.ascFacturaVentaMovimientos.idFacturaVentaMovimientos))
        parametros.Add(New MySqlParameter("@mfrIdP", param.ascPedidoMovimientos.idPedidosMovimientos))

        Return ExecuteNonQuery("sigeva.insMovimientos_Factura_Reserva")
    End Function

    Public Function verCantidadFacturada(idDetPed As Integer) As TablaMovimientos_Factura_Reserva Implements ITransaccionesMovimientos_Factura_Reserva.verCantidadFacturada
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idDetPed", idDetPed))

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaFacturado_idPedidosDetalle")

        If resultTable.Rows.Count > 0 Then
            Return New TablaMovimientos_Factura_Reserva With {.Cantidad = resultTable.Rows(0).Item("CantidadFacturada")}
        Else
            Return Nothing
        End If
    End Function

    Public Function elimRegistroPorIdFacturaVentaMovimientos(id As Integer) As Integer Implements ITransaccionesMovimientos_Factura_Reserva.elimRegistroPorIdFacturaVentaMovimientos
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idFacMov", id))

        Return ExecuteNonQuery("sigeva.elimMovimientos_Factura_Reseva_idFacturaVentaMovimientos")
    End Function

    Public Function verRegistrosPorIdDetalleFacturaVenta(id As Integer) As List(Of TablaMovimientos_Factura_Reserva) Implements ITransaccionesMovimientos_Factura_Reserva.verRegistrosPorIdDetalleFacturaVenta
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idDfv", id))

        Return listMovimientos_Factura_Reserva(ExecuteReader("sigeva.verMovimientos_Factura_Reseva_idFacturaVentaDetalle"))
    End Function

    Public Function modRegistro(param As TablaMovimientos_Factura_Reserva) As Integer Implements ITransaccionesGenericas(Of TablaMovimientos_Factura_Reserva).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaMovimientos_Factura_Reserva).elimRegistro
        Throw New NotImplementedException()
    End Function

    Private Function listMovimientos_Factura_Reserva(tabla As DataTable) As List(Of TablaMovimientos_Factura_Reserva)
        If tabla.Rows.Count > 0 Then
            Dim detalle As New List(Of TablaMovimientos_Factura_Reserva)

            For Each item As DataRow In tabla.Rows
                detalle.Add(New TablaMovimientos_Factura_Reserva With {
                    .idMovimientos_Factura_Reseva = item("idMovimientos_Factura_Reseva"),
                    .Fecha = item("mfrFecha"),
                    .Tipo = item("mfrTipo"),
                    .Cantidad = item("mfrCantidad"),
                    .Eliminado = item("mfrEliminado"),
                    .ascPedidoMovimientos = New TablaPedidoMovimientos With {
                        .idPedidosMovimientos = item("idPedidosMovimientos"),
                        .Fecha = item("pmFecha"),
                        .Tipo = item("pmTipo"),
                        .Cantidad = item("pmCantidad"),
                        .Eliminado = item("pmEliminado"),
                        .ascUsuarios = New TablaUsuarios With {.idUsuario = item("pmUsuarios_idUsuarios")},
                        .ascStock = New TablaStock With {.idStock = item("pmStock_idStock")},
                        .ascPedidosDetalle = New TablaPedidoDetalle With {
                            .idPedidosDetalle = item("idPedidosDetalle"),
                            .Cantidad = item("pdCantidad"),
                            .Remitado = item("pdRemitado"),
                            .Facturado = item("pdFacturado"),
                            .Eliminado = item("pdEliminado"),
                            .ascArticulos = New TablaArticulos With {
                                .idArticulo = item("idArticulos"),
                                .CodArticulo = item("CodArticulo"),
                                .Detalle = item("artDetalle")
                            },
                            .ascPedidos = New TablaPedidos With {
                                .idPedidos = item("idPedidos"),
                                .NroPedido = item("pNroPedido"),
                                .Fecha = item("pFecha"),
                                .FechaCierrePedido = item("pFechaCierrePedido"),
                                .Remitado = item("pRemitado"),
                                .Facturado = item("pFacturado"),
                                .Observaciones = item("pObservaciones"),
                                .Eliminado = item("pEliminado"),
                                .ascUsuarios = New TablaUsuarios With {.idUsuario = item("pUsuarios_idUsuarios")},
                                .ascClientes = New TablaClientes With {.idCliente = item("pClientes_idClientes")}
                            }
                        }
                    },
                    .ascFacturaVentaMovimientos = New TablaFacturaVentaMovimientos With {
                        .idFacturaVentaMovimientos = item("idFacturaVentaMovimientos"),
                        .Fecha = item("fvmFecha"),
                        .Tipo = item("fvmTipo"),
                        .Cantidad = item("fvmCantidad"),
                        .Eliminado = item("fvmEliminado"),
                        .ascUsuarios = New TablaUsuarios With {.idUsuario = item("fvmUsuarios_idUsuarios")},
                        .ascFacturaVentaDetalle = New TablaFacturaVentaDetalle With {
                            .idFacturaVentaDetalle = item("idFacturaVentaDetalle"),
                            .Descripcion = item("fvdDescripcion"),
                            .Cantidad = item("fvdCantidad"),
                            .Unidad = item("fvdUnidad"),
                            .Precio = item("fvdPrecio"),
                            .Importe = item("fvdImporte"),
                            .AlicuotaIVA = item("fvdAlicuotaIVA"),
                            .Remitado = item("fvdRemitado"),
                            .Eliminado = item("fvdEliminado"),
                            .ascArticulos = New TablaArticulos With {.idArticulo = item("fvdArticulos_idArticulos")},
                            .ascFacturaVenta = New TablaFacturaVenta With {
                                .idFacturaVenta = item("idFacturaVenta"),
                                .TipoComprobante = item("fvTipoComprobante"),
                                .ClaseComprobante = item("fvClaseComprobante"),
                                .Fecha = item("fvFecha"),
                                .FechaVto = item("fvFechaVto"),
                                .Prefijo = item("fvPrefijo"),
                                .NroComprobante = item("fvNroComprobante"),
                                .ImporteNeto = item("fvImporteNeto"),
                                .DescuentoGral = item("fvDescuentoGral"),
                                .BaseImponible = item("fvBaseImponible"),
                                .Iva = item("fvIva"),
                                .ImporteTotal = item("fvImporteTotal"),
                                .Observaciones = item("fvObservaciones"),
                                .Remitado = item("fvRemitado"),
                                .Eliminado = item("fvEliminado"),
                                .CAE = item("fvCAE"),
                                .FechaVtoCAE = item("fvFechaVtoCAE"),
                                .ascClientes = New TablaClientes With {.idCliente = item("fvClientes_idClientes")},
                                .ascUsuarios = New TablaUsuarios With {.idUsuario = item("fvUsuarios_idUsuarios")},
                                .ascCtaCteVenta = New TablaCuentaCorrienteVenta With {.idCuentaCorrienteVentas = item("fvCuentaCorrienteVentas_idCuentaCorrienteVentas")}
                            }
                        }
                    }
                })
            Next

            Return detalle
        Else
            Return Nothing
        End If
    End Function

End Class
