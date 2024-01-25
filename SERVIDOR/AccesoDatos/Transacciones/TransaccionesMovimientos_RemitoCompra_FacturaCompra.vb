Imports MySql.Data.MySqlClient

Public Class TransaccionesMovimientos_RemitoCompra_FacturaCompra
    Inherits Transacciones
    Implements ITransaccionesMovimientos_RemitoCompra_FacturaCompra

    Public Function verRegistros() As List(Of TablaMovimientos_RemitoCompra_FacturaCompra) Implements ITransaccionesGenericas(Of TablaMovimientos_RemitoCompra_FacturaCompra).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaMovimientos_RemitoCompra_FacturaCompra) As Integer Implements ITransaccionesGenericas(Of TablaMovimientos_RemitoCompra_FacturaCompra).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@mrfFec", param.Fecha))
        parametros.Add(New MySqlParameter("@mrfTip", param.Tipo))
        parametros.Add(New MySqlParameter("@mrfCan", param.Cantidad))
        parametros.Add(New MySqlParameter("@mrfEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@mrfIdD", param.ascRemitosCompraMovimientos.idRemitosCompraMovimientos))
        parametros.Add(New MySqlParameter("@mrfIdF", param.ascFacturaCompraMovimientos.idFacturaCompraMovimientos))

        Return ExecuteNonQuery("sigeva.insMovimientos_RemitoCompra_FacturaCompra")
    End Function

    Public Function modRegistro(param As TablaMovimientos_RemitoCompra_FacturaCompra) As Integer Implements ITransaccionesGenericas(Of TablaMovimientos_RemitoCompra_FacturaCompra).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaMovimientos_RemitoCompra_FacturaCompra).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@mrfId", id))

        Return ExecuteNonQuery("sigeva.elimMovimientos_RemitoCompra_FacturaCompra")
    End Function

    Public Function verCantidadRemitada(idDetFac As Integer) As TablaMovimientos_RemitoCompra_FacturaCompra Implements ITransaccionesMovimientos_RemitoCompra_FacturaCompra.verCantidadRemitada
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idDetFac", idDetFac))

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaRemitado_idFacturaCompraDetalle")

        If resultTable.Rows.Count > 0 Then
            Return New TablaMovimientos_RemitoCompra_FacturaCompra With {.Cantidad = resultTable.Rows(0).Item("CantidadRemitada")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verCantidadFacturada(idDetRem As Integer) As TablaMovimientos_RemitoCompra_FacturaCompra Implements ITransaccionesMovimientos_RemitoCompra_FacturaCompra.verCantidadFacturada
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idDetRem", idDetRem))

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaFacturado_idDetalleRemitosCompra")

        If resultTable.Rows.Count > 0 Then
            Return New TablaMovimientos_RemitoCompra_FacturaCompra With {.Cantidad = resultTable.Rows(0).Item("CantidadFacturada")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verRegistrosPorIdRemitosCompra(id As Integer) As List(Of TablaMovimientos_RemitoCompra_FacturaCompra) Implements ITransaccionesMovimientos_RemitoCompra_FacturaCompra.verRegistrosPorIdRemitosCompra
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idRC", id))

        Return listMovimientos_Factura_Remito(ExecuteReader("sigeva.verMovimientos_RemitoCompra_FacturaCompra_idRemitosCompra"))
    End Function

    Public Function verRegistrosPorIdFacturaCompra(id As Integer) As List(Of TablaMovimientos_RemitoCompra_FacturaCompra) Implements ITransaccionesMovimientos_RemitoCompra_FacturaCompra.verRegistrosPorIdFacturaCompra
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idFC", id))

        Return listMovimientos_Factura_Remito(ExecuteReader("sigeva.verMovimientos_RemitoCompra_FacturaCompra_idFacturaCompra"))
    End Function

    Private Function listMovimientos_Factura_Remito(tabla As DataTable) As List(Of TablaMovimientos_RemitoCompra_FacturaCompra)
        If tabla.Rows.Count > 0 Then
            Dim detalle As New List(Of TablaMovimientos_RemitoCompra_FacturaCompra)

            For Each item As DataRow In tabla.Rows
                detalle.Add(New TablaMovimientos_RemitoCompra_FacturaCompra With {
                    .idMovimientos_RemitoCompra_FacturaCompra = item("idMovimientos_RemitoCompra_FacturaCompra"),
                    .Fecha = item("mrfFecha"),
                    .Tipo = item("mrfTipo"),
                    .Cantidad = item("mrfCantidad"),
                    .Eliminado = item("mrfEliminado"),
                    .ascFacturaCompraMovimientos = New TablaFacturaCompraMovimientos With {
                        .idFacturaCompraMovimientos = item("idFacturaCompraMovimientos"),
                        .Fecha = item("fcmFecha"),
                        .Tipo = item("fcmTipo"),
                        .Cantidad = item("fcmCantidad"),
                        .Eliminado = item("fcmEliminado"),
                        .ascUsuarios = New TablaUsuarios With {.idUsuario = item("fcmUsuarios_idUsuarios")},
                        .ascFacturaCompraDetalle = New TablaFacturaCompraDetalle With {
                            .idFacturaCompraDetalle = item("idFacturaCompraDetalle"),
                            .Descripcion = item("fcdDescripcion"),
                            .Cantidad = item("fcdCantidad"),
                            .Unidad = item("fcdUnidad"),
                            .Precio = item("fcdPrecio"),
                            .Importe = item("fcdImporte"),
                            .AlicuotaIVA = item("fcdAlicuotaIVA"),
                            .Remitado = item("fcdRemitado"),
                            .Eliminado = item("fcdEliminado"),
                            .ascArticulos = New TablaArticulos With {.idArticulo = item("fcdArticulos_idArticulos")},
                            .ascFacturaCompra = New TablaFacturaCompra With {
                                .idFacturaCompra = item("idFacturaCompra"),
                                .Fecha = item("fcFecha"),
                                .FechaVto = item("fcFechaVto"),
                                .Prefijo = item("fcPrefijo"),
                                .NroComprobante = item("fcNroComprobante"),
                                .ImporteNeto = item("fcImporteNeto"),
                                .DescuentoGral = item("fcDescuentoGral"),
                                .BaseImponible = item("fcBaseImponible"),
                                .Iva = item("fcIva"),
                                .ImporteTotal = item("fcImporteTotal"),
                                .Observaciones = item("fcObservaciones"),
                                .Remitado = item("fcRemitado"),
                                .Eliminado = item("fcEliminado"),
                                .ascProveedores = New TablaProveedores With {.idProveedor = item("fcProveedores_idProveedores")},
                                .ascUsuarios = New TablaUsuarios With {.idUsuario = item("fcUsuarios_idUsuarios")},
                                .ascCuentaCorrienteCompra = New TablaCuentaCorrienteCompra With {.idCuentaCorrienteCompra = item("fcCuentaCorrienteCompra_idCuentaCorrienteCompra")}
                            }
                        }
                    },
                    .ascRemitosCompraMovimientos = New TablaRemitosCompraMovimientos With {
                        .idRemitosCompraMovimientos = item("idRemitosCompraMovimientos"),
                        .Fecha = item("rcmFecha"),
                        .Tipo = item("rcmTipo"),
                        .Cantidad = item("rcmCantidad"),
                        .Eliminado = item("rcmEliminado"),
                        .ascUsuarios = New TablaUsuarios With {.idUsuario = item("rcmUsuarios_idUsuarios")},
                        .ascStock = New TablaStock With {
                            .idStock = item("rcmStock_idStock"),
                            .ascDepositos = New TablaDepositos With {
                                .idDeposito = item("idDepositos"),
                                .Nombre = item("Nombre")
                            }
                        },
                        .ascDetalleRemtioCompra = New TablaDetalleRemitoCompra With {
                            .idDetalleRemitosCompra = item("idDetalleRemitosCompra"),
                            .Descripcion = item("drcDescripcion"),
                            .Cantidad = item("drcCantidad"),
                            .Unidad = item("drcUnidad"),
                            .Precio = item("drcPrecio"),
                            .Importe = item("drcImporte"),
                            .AlicuotaIVA = item("drcAlicuotaIVA"),
                            .Facturado = item("drcFacturado"),
                            .Eliminado = item("drcEliminado"),
                            .ascArticulos = New TablaArticulos With {
                                .idArticulo = item("idArticulos"),
                                .CodArticulo = item("CodArticulo"),
                                .Detalle = item("artDetalle")
                            },
                            .ascRemitosCompra = New TablaRemitosCompra With {.idRemitosCompra = item("drcRemitosVenta_idRemitosVenta")}
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
