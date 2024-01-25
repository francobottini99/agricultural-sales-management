Imports MySql.Data.MySqlClient

Public Class TransaccionesFacturaCompraMovimientos
    Inherits Transacciones
    Implements ITransaccionesFacturaCompraMovimientos

    Public Function verRegistros() As List(Of TablaFacturaCompraMovimientos) Implements ITransaccionesGenericas(Of TablaFacturaCompraMovimientos).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaFacturaCompraMovimientos) As Integer Implements ITransaccionesGenericas(Of TablaFacturaCompraMovimientos).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@fcmFec", param.Fecha))
        parametros.Add(New MySqlParameter("@fcmTip", param.Tipo))
        parametros.Add(New MySqlParameter("@fcmCan", param.Cantidad))
        parametros.Add(New MySqlParameter("@fcmEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@fcmIdU", param.ascUsuarios.idUsuario))
        parametros.Add(New MySqlParameter("@fcmIdF", param.ascFacturaCompraDetalle.idFacturaCompraDetalle))

        Return ExecuteNonQuery("sigeva.insFacturaCompraMovimientos")
    End Function

    Public Function modRegistro(param As TablaFacturaCompraMovimientos) As Integer Implements ITransaccionesGenericas(Of TablaFacturaCompraMovimientos).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaFacturaCompraMovimientos).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@fcmId", id))

        Return ExecuteNonQuery("sigeva.elimFacturaCompraMovimientos")
    End Function

    Public Function verUltimoId() As TablaFacturaCompraMovimientos Implements ITransaccionesFacturaCompraMovimientos.verUltimoId
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdFacturaCompraMovimientos")

        If resultTable.Rows.Count > 0 Then
            Return New TablaFacturaCompraMovimientos With {.idFacturaCompraMovimientos = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verCantidadFacturada(idDetFac As Integer) As TablaFacturaCompraMovimientos Implements ITransaccionesFacturaCompraMovimientos.verCantidadFacturada
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idDetFac", idDetFac))

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaFacturado_idFacturaCompraDetalle")

        If resultTable.Rows.Count > 0 Then
            Return New TablaFacturaCompraMovimientos With {.Cantidad = resultTable.Rows(0).Item("CantidadFacturada")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verCantidadAnulada(idDetFac As Integer) As TablaFacturaCompraMovimientos Implements ITransaccionesFacturaCompraMovimientos.verCantidadAnulada
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idDetFac", idDetFac))

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaAnulado_idFacturaCompraDetalle")

        If resultTable.Rows.Count > 0 Then
            Return New TablaFacturaCompraMovimientos With {.Cantidad = resultTable.Rows(0).Item("CantidadAnulada")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verCantidadRemitada(idDetFac As Integer) As TablaFacturaCompraMovimientos Implements ITransaccionesFacturaCompraMovimientos.verCantidadRemitada
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idDetFac", idDetFac))

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaRemitado_idFacturaCompraDetalle_FacturaCompraMovimientos")

        If resultTable.Rows.Count > 0 Then
            Return New TablaFacturaCompraMovimientos With {.Cantidad = resultTable.Rows(0).Item("CantidadRemitada")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verRegistrosPorIdFacturaCompra(id As Integer) As List(Of TablaFacturaCompraMovimientos) Implements ITransaccionesFacturaCompraMovimientos.verRegistrosPorIdFacturaCompra
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idFC", id))

        Return listFacturaCompraMovimientos(ExecuteReader("sigeva.verFacturaCompraMovimientos_idFacturaCompra"))
    End Function

    Private Function listFacturaCompraMovimientos(tabla As DataTable) As List(Of TablaFacturaCompraMovimientos)
        If tabla.Rows.Count > 0 Then
            Dim detalle As New List(Of TablaFacturaCompraMovimientos)

            For Each item As DataRow In tabla.Rows
                detalle.Add(New TablaFacturaCompraMovimientos With {
                        .idFacturaCompraMovimientos = item("idFacturaCompraMovimientos"),
                        .Fecha = item("fcmFecha"),
                        .Tipo = item("fcmTipo"),
                        .Cantidad = item("fcmCantidad"),
                        .Eliminado = item("fcmEliminado"),
                        .ascUsuarios = New TablaUsuarios With {.idUsuario = item("fcmUsuarios_idUsuarios")},
                        .ascFacturaCompraDetalle = New TablaFacturaCompraDetalle With {
                            .idFacturaCompraDetalle = item("idFacturaCompraDetalle"),
                            .Descripcion = item("dfcDescripcion"),
                            .Cantidad = item("dfcCantidad"),
                            .Unidad = item("dfcUnidad"),
                            .Precio = item("dfcPrecio"),
                            .Importe = item("dfcImporte"),
                            .AlicuotaIVA = item("dfcAlicuotaIVA"),
                            .Remitado = item("dfcRemitado"),
                            .Eliminado = item("dfcEliminado"),
                            .ascArticulos = New TablaArticulos With {
                                .idArticulo = item("idArticulos"),
                                .CodArticulo = item("CodArticulo"),
                                .Detalle = item("artDetalle")
                            },
                            .ascFacturaCompra = New TablaFacturaCompra With {.idFacturaCompra = item("dfcFacturaCompra_idFacturaCompra")}
                        }
                })
            Next

            Return detalle
        Else
            Return Nothing
        End If
    End Function
End Class
