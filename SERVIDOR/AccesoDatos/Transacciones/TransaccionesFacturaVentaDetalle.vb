Imports MySql.Data.MySqlClient

Public Class TransaccionesFacturaVentaDetalle
    Inherits Transacciones
    Implements ITransaccionesDetalleFacturaVenta

    Public Function elimRegistroPorIdFacturaVenta(id As Integer) As Integer Implements ITransaccionesDetalleFacturaVenta.elimRegistroPorIdFacturaVenta
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@IdFv", id)
        }

        Return ExecuteNonQuery("sigeva.elimFacturaVentaDetalle_idFacturaVenta")
    End Function

    Public Function modEstadoRemitado(id As Integer, EstRem As String) As Integer Implements ITransaccionesDetalleFacturaVenta.modEstadoRemitado
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@fvdID", id),
            New MySqlParameter("@fvdRem", EstRem)
        }

        Return ExecuteNonQuery("sigeva.modFacturaVentaDetalle_Remitado")
    End Function

    Public Function verDetalleFacturaVentaPorIdFacturaVenta(id As Integer) As List(Of TablaFacturaVentaDetalle) Implements ITransaccionesDetalleFacturaVenta.verDetalleFacturaVentaPorIdFacturaVenta
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@idFv", id)
        }

        Return listDetalleFacturaVenta(ExecuteReader("sigeva.verFacturaVentaDetalle_idFacturaVenta"))
    End Function

    Public Function verCantidadFacturada(idDetFac As Integer) As TablaFacturaVentaDetalle Implements ITransaccionesDetalleFacturaVenta.verCantidadFacturada
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@idDetFac", idDetFac)
        }

        Dim resultTable As DataTable = ExecuteReader("sigeva.verFacturaVentaDetalle_Cantidad_idFacturaVentaDetalle")

        If resultTable.Rows.Count > 0 Then
            Return New TablaFacturaVentaDetalle With {.Cantidad = resultTable.Rows(0).Item("Cantidad")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verUltimoId() As TablaFacturaVentaDetalle Implements ITransaccionesDetalleFacturaVenta.verUltimoId
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdFacturaVentaDetalle")

        If resultTable.Rows.Count > 0 Then
            Return New TablaFacturaVentaDetalle With {.idFacturaVentaDetalle = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verRegistroPorIdCliente_Remitado(id As Integer, remitado As String) As List(Of TablaFacturaVentaDetalle) Implements ITransaccionesDetalleFacturaVenta.verRegistroPorIdCliente_Remitado
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@idCli", id),
            New MySqlParameter("@remi", remitado)
        }

        Return listDetalleFacturaVenta_FacturaVenta(ExecuteReader("sigeva.verFacturaVentaDetalle_idCliente_Remitado"))
    End Function

    Public Function verRegistros() As List(Of TablaFacturaVentaDetalle) Implements ITransaccionesGenericas(Of TablaFacturaVentaDetalle).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaFacturaVentaDetalle) As Integer Implements ITransaccionesGenericas(Of TablaFacturaVentaDetalle).insRegistro
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@fvdDes", param.Descripcion),
            New MySqlParameter("@fvdUni", param.Unidad),
            New MySqlParameter("@fvdCan", param.Cantidad),
            New MySqlParameter("@fvdPre", param.Precio),
            New MySqlParameter("@fvdImp", param.Importe),
            New MySqlParameter("@fvdIva", param.AlicuotaIVA),
            New MySqlParameter("@fvdRem", param.Remitado),
            New MySqlParameter("@fvdEli", param.Eliminado),
            New MySqlParameter("@fvIdFv", param.ascFacturaVenta.idFacturaVenta),
            New MySqlParameter("@fvIdArt", param.ascArticulos.idArticulo)
        }

        Return ExecuteNonQuery("sigeva.insFacturaVentaDetalle")
    End Function

    Public Function modRegistro(param As TablaFacturaVentaDetalle) As Integer Implements ITransaccionesGenericas(Of TablaFacturaVentaDetalle).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaFacturaVentaDetalle).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Function verRegistroPorIdCliente(id As Integer) As List(Of TablaFacturaVentaDetalle) Implements ITransaccionesDetalleFacturaVenta.verRegistroPorIdCliente
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@idCli", id)
        }

        Return listDetalleFacturaVenta_FacturaVenta(ExecuteReader("sigeva.verFacturaVentaDetalle_idCliente"))
    End Function

    Private Function listDetalleFacturaVenta(tabla As DataTable) As List(Of TablaFacturaVentaDetalle)
        If tabla.Rows.Count > 0 Then
            Dim detalle As New List(Of TablaFacturaVentaDetalle)

            For Each item As DataRow In tabla.Rows
                detalle.Add(New TablaFacturaVentaDetalle With {
                    .idFacturaVentaDetalle = item("idFacturaVentaDetalle"),
                    .Descripcion = item("Descripcion"),
                    .Unidad = item("Unidad"),
                    .Cantidad = item("Cantidad"),
                    .Precio = item("Precio"),
                    .Importe = item("Importe"),
                    .AlicuotaIVA = item("AlicuotaIVA"),
                    .Remitado = item("Remitado"),
                    .ascArticulos = New TablaArticulos With {
                        .idArticulo = item("Articulos_idArticulos"),
                        .CodArticulo = item("CodArticulo")
                    },
                    .ascFacturaVenta = New TablaFacturaVenta With {.idFacturaVenta = item("FacturaVenta_idFacturaVenta")}
                })
            Next

            Return detalle
        Else
            Return Nothing
        End If
    End Function

    Private Function listDetalleFacturaVenta_FacturaVenta(tabla As DataTable) As List(Of TablaFacturaVentaDetalle)
        If tabla.Rows.Count > 0 Then
            Dim detalle As New List(Of TablaFacturaVentaDetalle)

            For Each item As DataRow In tabla.Rows
                detalle.Add(New TablaFacturaVentaDetalle With {
                    .idFacturaVentaDetalle = item("idFacturaVentaDetalle"),
                    .Descripcion = item("Descripcion"),
                    .Unidad = item("Unidad"),
                    .Cantidad = item("Cantidad"),
                    .Precio = item("Precio"),
                    .Importe = item("Importe"),
                    .AlicuotaIVA = item("AlicuotaIVA"),
                    .Remitado = item("Remitado"),
                    .ascArticulos = New TablaArticulos With {
                        .idArticulo = item("Articulos_idArticulos"),
                        .CodArticulo = item("CodArticulo"),
                        .Detalle = item("Detalle")
                    },
                    .ascFacturaVenta = New TablaFacturaVenta With {
                        .idFacturaVenta = item("idFacturaVenta"),
                        .TipoComprobante = item("TipoComprobante"),
                        .ClaseComprobante = item("ClaseComprobante"),
                        .Fecha = item("Fecha"),
                        .FechaVto = item("FechaVto"),
                        .Prefijo = item("Prefijo"),
                        .NroComprobante = item("NroComprobante"),
                        .ImporteNeto = item("ImporteNeto"),
                        .DescuentoGral = item("DescuentoGral"),
                        .BaseImponible = item("BaseImponible"),
                        .Iva = item("Iva"),
                        .ImporteTotal = item("ImporteTotal"),
                        .Observaciones = item("Observaciones"),
                        .Remitado = item("Remitado"),
                        .Eliminado = item("Eliminado"),
                        .CAE = item("CAE"),
                        .FechaVtoCAE = item("FechaVtoCAE"),
                        .ascUsuarios = New TablaUsuarios With {.idUsuario = item("Usuarios_idUsuarios")},
                        .ascClientes = New TablaClientes With {.idCliente = item("Clientes_idClientes")},
                        .ascCtaCteVenta = New TablaCuentaCorrienteVenta With {.idCuentaCorrienteVentas = item("CuentaCorrienteVentas_idCuentaCorrienteVentas")}
                    }
                })
            Next

            Return detalle
        Else
            Return Nothing
        End If
    End Function
End Class

