Imports MySql.Data.MySqlClient

Public Class TransaccionesMovimientos_Reserva_Remito
    Inherits Transacciones
    Implements ITransaccionesMovimientos_Reserva_Remito

    Public Function verRegistros() As List(Of TablaMovimientos_Reserva_Remito) Implements ITransaccionesGenericas(Of TablaMovimientos_Reserva_Remito).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaMovimientos_Reserva_Remito) As Integer Implements ITransaccionesGenericas(Of TablaMovimientos_Reserva_Remito).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@mrrFec", param.Fecha))
        parametros.Add(New MySqlParameter("@mrrTip", param.Tipo))
        parametros.Add(New MySqlParameter("@mrrCan", param.Cantidad))
        parametros.Add(New MySqlParameter("@mrrEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@mrrIdP", param.ascPedidosMovimientos.idPedidosMovimientos))
        parametros.Add(New MySqlParameter("@mrrIdD", param.ascRemitosVentaMovimientos.idRemitosVentasMovimientos))

        Return ExecuteNonQuery("sigeva.insMovimientos_Reserva_Remito")
    End Function

    Public Function elimRegistroPorIdRemitosVenta(id As Integer) As Integer Implements ITransaccionesMovimientos_Reserva_Remito.elimRegistroPorIdRemitosVenta
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdDRV", id))

        Return ExecuteNonQuery("sigeva.elimMovimientos_Reserva_Remito_IdRemVenta")
    End Function

    Public Function verCantidadRemitada(idDetPed As Integer) As TablaMovimientos_Reserva_Remito Implements ITransaccionesMovimientos_Reserva_Remito.verCantidadRemitada
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idDetPed", idDetPed))

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaRemitado_idPedidosDetalle")

        If resultTable.Rows.Count > 0 Then
            Return New TablaMovimientos_Reserva_Remito With {.Cantidad = resultTable.Rows(0).Item("CantidadRemitada")}
        Else
            Return Nothing
        End If
    End Function

    Public Function modRegistro(param As TablaMovimientos_Reserva_Remito) As Integer Implements ITransaccionesGenericas(Of TablaMovimientos_Reserva_Remito).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaMovimientos_Reserva_Remito).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@mrrId", id))

        Return ExecuteNonQuery("sigeva.elimMovimientos_Reserva_Remito")
    End Function

    Public Function verRegistrosPorIdRemitosVenta(id As Integer) As List(Of TablaMovimientos_Reserva_Remito) Implements ITransaccionesMovimientos_Reserva_Remito.verRegistrosPorIdRemitosVenta
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idRV", id))

        Return listMovimientos_Reserva_Remito(ExecuteReader("sigeva.verMovimientos_Reserva_Remito_idRemitosVenta"))
    End Function

    Public Function verRegistrosPorIdDetalleRemitosVenta(id As Integer) As List(Of TablaMovimientos_Reserva_Remito) Implements ITransaccionesMovimientos_Reserva_Remito.verRegistrosPorIdDetalleRemitosVenta
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idDrv", id))

        Return listMovimientos_Reserva_Remito(ExecuteReader("sigeva.verMovimientos_Reserva_Remito_idDetalleRemitosVenta"))
    End Function

    Private Function listMovimientos_Reserva_Remito(tabla As DataTable) As List(Of TablaMovimientos_Reserva_Remito)
        If tabla.Rows.Count > 0 Then
            Dim detalle As New List(Of TablaMovimientos_Reserva_Remito)

            For Each item As DataRow In tabla.Rows
                detalle.Add(New TablaMovimientos_Reserva_Remito With {
                    .idMovimientos_Reserva_Remito = item("idMovimientos_Reserva_Remito"),
                    .Fecha = item("mrrFecha"),
                    .Tipo = item("mrrTipo"),
                    .Cantidad = item("mrrCantidad"),
                    .Eliminado = item("mrrEliminado"),
                    .ascPedidosMovimientos = New TablaPedidoMovimientos With {
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
                            .ascArticulos = New TablaArticulos With {.idArticulo = item("pdArticulos_idArticulos")},
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
