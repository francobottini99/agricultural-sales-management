Imports MySql.Data.MySqlClient

Public Class TransaccionesMovimientos_Remito_Factura
    Inherits Transacciones
    Implements ITransaccionesMovimientos_Remito_Factura

    Public Function verRegistros() As List(Of TablaMovimientos_Remito_Factura) Implements ITransaccionesGenericas(Of TablaMovimientos_Remito_Factura).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaMovimientos_Remito_Factura) As Integer Implements ITransaccionesGenericas(Of TablaMovimientos_Remito_Factura).insRegistro
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@mrfFec", param.Fecha),
            New MySqlParameter("@mrfTip", param.Tipo),
            New MySqlParameter("@mrfCan", param.Cantidad),
            New MySqlParameter("@mrfEli", param.Eliminado),
            New MySqlParameter("@mrfIdD", param.ascRemitosVentaMovimientos.idRemitosVentasMovimientos),
            New MySqlParameter("@mrfIdF", param.ascFacturaVentaMovimientos.idFacturaVentaMovimientos)
        }

        Return ExecuteNonQuery("sigeva.insMovimientos_Remito_Factura")
    End Function

    Public Function verCantidadRemitada(idDetFac As Integer) As TablaMovimientos_Remito_Factura Implements ITransaccionesMovimientos_Remito_Factura.verCantidadRemitada
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@idDetFac", idDetFac)
        }

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaRemitado_idFacturaVentaDetalle")

        If resultTable.Rows.Count > 0 Then
            Return New TablaMovimientos_Remito_Factura With {.Cantidad = resultTable.Rows(0).Item("CantidadRemitada")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verCantidadFacturada(idDetRem As Integer) As TablaMovimientos_Remito_Factura Implements ITransaccionesMovimientos_Remito_Factura.verCantidadFacturada
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@idDetRem", idDetRem)
        }

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaFacturado_idDetalleRemitoVenta")

        If resultTable.Rows.Count > 0 Then
            Return New TablaMovimientos_Remito_Factura With {.Cantidad = resultTable.Rows(0).Item("CantidadFacturada")}
        Else
            Return Nothing
        End If
    End Function

    Public Function modRegistro(param As TablaMovimientos_Remito_Factura) As Integer Implements ITransaccionesGenericas(Of TablaMovimientos_Remito_Factura).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaMovimientos_Remito_Factura).elimRegistro
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@mrfId", id)
        }

        Return ExecuteNonQuery("sigeva.elimMovimientos_Remito_Factura")
    End Function

    Public Function verRegistrosPorIdRemitosVenta(id As Integer) As List(Of TablaMovimientos_Remito_Factura) Implements ITransaccionesMovimientos_Remito_Factura.verRegistrosPorIdRemitosVenta
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@idRV", id)
        }

        Return listMovimientos_Reserva_Remito(ExecuteReader("sigeva.verMovimientos_Remito_Factura_idRemitosVenta"))
    End Function

    Public Function verRegistrosPorIdRemitosVentaMovimientos(id As Integer) As List(Of TablaMovimientos_Remito_Factura) Implements ITransaccionesMovimientos_Remito_Factura.verRegistrosPorIdRemitosVentaMovimientos
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@idRVM", id)
        }

        Return listMovimientos_Reserva_Remito(ExecuteReader("sigeva.verMovimientos_Remito_Factura_idRemitosVentaMovimientos"))
    End Function

    Public Function verCantidadFacturadaIdDetFac(idDetFac As Integer) As TablaMovimientos_Remito_Factura Implements ITransaccionesMovimientos_Remito_Factura.verCantidadFacturadaIdDetFac
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@idDetFac", idDetFac)
        }

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaFacturado_idFacturaVentaDetalle_Mov_Rem_Fac")

        If resultTable.Rows.Count > 0 Then
            Return New TablaMovimientos_Remito_Factura With {.Cantidad = resultTable.Rows(0).Item("CantidadFacturada")}
        Else
            Return Nothing
        End If
    End Function

    Private Function listMovimientos_Reserva_Remito(tabla As DataTable) As List(Of TablaMovimientos_Remito_Factura)
        If tabla.Rows.Count > 0 Then
            Dim detalle As New List(Of TablaMovimientos_Remito_Factura)

            For Each item As DataRow In tabla.Rows
                detalle.Add(New TablaMovimientos_Remito_Factura With {
                    .idMovimientos_Remito_Factura = item("idMovimientos_Remito_Factura"),
                    .Fecha = item("mrfFecha"),
                    .Tipo = item("mrfTipo"),
                    .Cantidad = item("mrfCantidad"),
                    .Eliminado = item("mrfEliminado"),
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
                    },
                    .ascRemitosVentaMovimientos = New TablaRemitosVentaMovimientos With {
                        .idRemitosVentasMovimientos = item("idRemitosVentasMovimientos"),
                        .Fecha = item("rvmFecha"),
                        .Tipo = item("rvmTipo"),
                        .Cantidad = item("rvmCantidad"),
                        .Eliminado = item("rvmEliminado"),
                        .ascUsuarios = New TablaUsuarios With {.idUsuario = item("rvmUsuarios_idUsuarios")},
                        .ascStock = New TablaStock With {
                            .idStock = item("rvmStock_idStock"),
                            .ascDepositos = New TablaDepositos With {
                                .idDeposito = item("idDepositos"),
                                .Nombre = item("Nombre")
                            }
                        },
                        .ascDetalleRemitoVenta = New TablaDetalleRemitoVenta With {
                            .idDetalleRemitosVenta = item("idDetalleRemitosVenta"),
                            .Descripcion = item("drvDescripcion"),
                            .Cantidad = item("drvCantidad"),
                            .Unidad = item("drvUnidad"),
                            .Precio = item("drvPrecio"),
                            .Importe = item("drvImporte"),
                            .AlicuotaIVA = item("drvAlicuotaIVA"),
                            .Facturado = item("drvFacturado"),
                            .Eliminado = item("drvEliminado"),
                            .ascArticulos = New TablaArticulos With {
                                .idArticulo = item("idArticulos"),
                                .CodArticulo = item("CodArticulo"),
                                .Detalle = item("artDetalle")
                            },
                            .ascRemitosVenta = New TablaRemitosVenta With {.idRemitosVenta = item("drvRemitosVenta_idRemitosVenta")}
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
