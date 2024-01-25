Imports MySql.Data.MySqlClient

Public Class TransaccionesRemitosCompraMovimientos
    Inherits Transacciones
    Implements ITransaccionesRemitosCompraMovimientos

    Public Function verRegistros() As List(Of TablaRemitosCompraMovimientos) Implements ITransaccionesGenericas(Of TablaRemitosCompraMovimientos).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaRemitosCompraMovimientos) As Integer Implements ITransaccionesGenericas(Of TablaRemitosCompraMovimientos).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@rcmFec", param.Fecha))
        parametros.Add(New MySqlParameter("@rcmTip", param.Tipo))
        parametros.Add(New MySqlParameter("@rcmCan", param.Cantidad))
        parametros.Add(New MySqlParameter("@rcmEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@rcmIdU", param.ascUsuarios.idUsuario))
        parametros.Add(New MySqlParameter("@rcmIdD", param.ascDetalleRemtioCompra.idDetalleRemitosCompra))
        parametros.Add(New MySqlParameter("@rcmIdS", param.ascStock.idStock))

        Return ExecuteNonQuery("sigeva.insRemitosCompraMovimientos")
    End Function

    Public Function modRegistro(param As TablaRemitosCompraMovimientos) As Integer Implements ITransaccionesGenericas(Of TablaRemitosCompraMovimientos).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaRemitosCompraMovimientos).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@rcmId", id))

        Return ExecuteNonQuery("sigeva.elimRemitosCompraMovimientos")
    End Function

    Public Function verRegistrosPorIdRemitosCompra(id As Integer) As List(Of TablaRemitosCompraMovimientos) Implements ITransaccionesRemitosCompraMovimientos.verRegistrosPorIdRemitosCompra
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idRC", id))

        Return listRemitoVentaMovimientos(ExecuteReader("sigeva.verRemitosCompraMovimientos_idRemitosCompra"))
    End Function

    Public Function verCantidadRemitada(idDetRem As Integer) As TablaRemitosCompraMovimientos Implements ITransaccionesRemitosCompraMovimientos.verCantidadRemitada
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idDetRem", idDetRem))

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaRemitado_idDetalleRemitosCompra")

        If resultTable.Rows.Count > 0 Then
            Return New TablaRemitosCompraMovimientos With {.Cantidad = resultTable.Rows(0).Item("CantidadRemitada")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verCantidadDevuelta(idDetRem As Integer) As TablaRemitosCompraMovimientos Implements ITransaccionesRemitosCompraMovimientos.verCantidadDevuelta
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idDetRem", idDetRem))

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaDevolucion_idDetalleRemitosCompra")

        If resultTable.Rows.Count > 0 Then
            Return New TablaRemitosCompraMovimientos With {.Cantidad = resultTable.Rows(0).Item("CantidadDevuelta")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verCantidadFacturada(idDetRem As Integer) As TablaRemitosCompraMovimientos Implements ITransaccionesRemitosCompraMovimientos.verCantidadFacturada
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idDetRem", idDetRem))

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaFacturado_idDetalleRemitosCompra_RemitosCompraMovimientos")

        If resultTable.Rows.Count > 0 Then
            Return New TablaRemitosCompraMovimientos With {.Cantidad = resultTable.Rows(0).Item("CantidadFacturada")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verUltimoId() As TablaRemitosCompraMovimientos Implements ITransaccionesRemitosCompraMovimientos.verUltimoId
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdRemitosCompraMovimientos")

        If resultTable.Rows.Count > 0 Then
            Return New TablaRemitosCompraMovimientos With {.idRemitosCompraMovimientos = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function

    Private Function listRemitoVentaMovimientos(tabla As DataTable) As List(Of TablaRemitosCompraMovimientos)
        If tabla.Rows.Count > 0 Then
            Dim detalle As New List(Of TablaRemitosCompraMovimientos)

            For Each item As DataRow In tabla.Rows
                detalle.Add(New TablaRemitosCompraMovimientos With {
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
                            .ascRemitosCompra = New TablaRemitosCompra With {.idRemitosCompra = item("drcRemitosCompra_idRemitosCompra")}
                        }
                })
            Next

            Return detalle
        Else
            Return Nothing
        End If
    End Function

End Class
