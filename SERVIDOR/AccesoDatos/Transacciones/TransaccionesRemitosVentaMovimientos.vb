Imports MySql.Data.MySqlClient

Public Class TransaccionesRemitosVentaMovimientos
    Inherits Transacciones
    Implements ITransaccionesRemitosVentaMovimientos

    Public Function verRegistros() As List(Of TablaRemitosVentaMovimientos) Implements ITransaccionesGenericas(Of TablaRemitosVentaMovimientos).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaRemitosVentaMovimientos) As Integer Implements ITransaccionesGenericas(Of TablaRemitosVentaMovimientos).insRegistro
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@rvmFec", param.Fecha),
            New MySqlParameter("@rvmTip", param.Tipo),
            New MySqlParameter("@rvmCan", param.Cantidad),
            New MySqlParameter("@rvmEli", param.Eliminado),
            New MySqlParameter("@rvmIdU", param.ascUsuarios.idUsuario),
            New MySqlParameter("@rvmIdD", param.ascDetalleRemitoVenta.idDetalleRemitosVenta),
            New MySqlParameter("@rvmIdS", param.ascStock.idStock)
        }

        Return ExecuteNonQuery("sigeva.insRemitosVentasMovimientos")
    End Function

    Public Function modRegistro(param As TablaRemitosVentaMovimientos) As Integer Implements ITransaccionesGenericas(Of TablaRemitosVentaMovimientos).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function verRegistrosPorIdRemitosVenta(id As Integer) As List(Of TablaRemitosVentaMovimientos) Implements ITransaccionesRemitosVentaMovimientos.verRegistrosPorIdRemitosVenta
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@idRV", id)
        }

        Return listRemitoVentaMovimientos(ExecuteReader("sigeva.verRemitosVentasMovimientos_idRemitosVenta"))
    End Function

    Public Function verCantidadRemitada(idDetRem As Integer) As TablaRemitosVentaMovimientos Implements ITransaccionesRemitosVentaMovimientos.verCantidadRemitada
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@idDetRem", idDetRem)
        }

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaRemitado_idDetalleRemitosVenta")

        If resultTable.Rows.Count > 0 Then
            Return New TablaRemitosVentaMovimientos With {.Cantidad = resultTable.Rows(0).Item("CantidadRemitada")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verCantidadDevuelta(idDetRem As Integer) As TablaRemitosVentaMovimientos Implements ITransaccionesRemitosVentaMovimientos.verCantidadDevuelta
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@idDetRem", idDetRem)
        }

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaDevolucion_idDetalleRemitosVenta")

        If resultTable.Rows.Count > 0 Then
            Return New TablaRemitosVentaMovimientos With {.Cantidad = resultTable.Rows(0).Item("CantidadDevuelta")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verCantidadFacturada(idDetRem As Integer) As TablaRemitosVentaMovimientos Implements ITransaccionesRemitosVentaMovimientos.verCantidadFacturada
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@idDetRem", idDetRem)
        }

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaFacturado_idDetalleRemitosVenta_RemitosVentasMovimientos")

        If resultTable.Rows.Count > 0 Then
            Return New TablaRemitosVentaMovimientos With {.Cantidad = resultTable.Rows(0).Item("CantidadFacturada")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verUltimoId() As TablaRemitosVentaMovimientos Implements ITransaccionesRemitosVentaMovimientos.verUltimoId
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdRemitosVentasMovimientos")

        If resultTable.Rows.Count > 0 Then
            Return New TablaRemitosVentaMovimientos With {.idRemitosVentasMovimientos = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaRemitosVentaMovimientos).elimRegistro
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@rvmId", id)
        }

        Return ExecuteNonQuery("sigeva.elimRemitosVentasMovimientos")
    End Function

    Public Function verRegistrosPorIdDetalleRemitosVenta(id As Integer) As List(Of TablaRemitosVentaMovimientos) Implements ITransaccionesRemitosVentaMovimientos.verRegistrosPorIdDetalleRemitosVenta
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@idDRV", id)
        }

        Return listRemitoVentaMovimientos(ExecuteReader("sigeva.verRemitosVentasMovimientos_idDetalleRemitosVenta"))
    End Function

    Private Function listRemitoVentaMovimientos(tabla As DataTable) As List(Of TablaRemitosVentaMovimientos)
        If tabla.Rows.Count > 0 Then
            Dim detalle As New List(Of TablaRemitosVentaMovimientos)

            For Each item As DataRow In tabla.Rows
                detalle.Add(New TablaRemitosVentaMovimientos With {
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
                })
            Next

            Return detalle
        Else
            Return Nothing
        End If
    End Function
End Class
