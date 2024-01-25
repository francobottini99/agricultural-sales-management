Imports MySql.Data.MySqlClient

Public Class TransaccionesFacturaCompraDetalle
    Inherits Transacciones
    Implements ITransaccionesFacturaCompraDetalle

    Public Function elimRegistroPorIdFacturaCompra(id As Integer) As Integer Implements ITransaccionesFacturaCompraDetalle.elimRegistroPorIdFacturaCompra
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdFc", id))

        Return ExecuteNonQuery("sigeva.elimFacturaCompraDetalle_idFacturaCompra")
    End Function

    Public Function verRegistrosPorIdFacturaCompra(id As Integer) As List(Of TablaFacturaCompraDetalle) Implements ITransaccionesFacturaCompraDetalle.verRegistrosPorIdFacturaCompra
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdFc", id))

        Return listFacturaCompraDetalle(ExecuteReader("sigeva.verFacturaCompraDetalle_idFacturaCompra"))
    End Function

    Public Function verRegistroPorIdProveedor_Remitado(id As Integer, remitado As String) As List(Of TablaFacturaCompraDetalle) Implements ITransaccionesFacturaCompraDetalle.verRegistroPorIdProveedor_Remitado
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idProv", id))
        parametros.Add(New MySqlParameter("@remi", remitado))

        Return listDetalleFacturaCompra_FacturaCompra(ExecuteReader("sigeva.verFacturaCompraDetalle_idProveedor_Remitado"))
    End Function

    Public Function modEstadoRemitado(id As Integer, EstRem As String) As Integer Implements ITransaccionesFacturaCompraDetalle.modEstadoRemitado
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@fcdID", id))
        parametros.Add(New MySqlParameter("@fcdRem", EstRem))

        Return ExecuteNonQuery("sigeva.modFacturaCompraDetalle_Remitado")
    End Function

    Public Function verRegistros() As List(Of TablaFacturaCompraDetalle) Implements ITransaccionesGenericas(Of TablaFacturaCompraDetalle).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaFacturaCompraDetalle) As Integer Implements ITransaccionesGenericas(Of TablaFacturaCompraDetalle).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@fcdDes", param.Descripcion))
        parametros.Add(New MySqlParameter("@fcdUni", param.Unidad))
        parametros.Add(New MySqlParameter("@fcdCan", param.Cantidad))
        parametros.Add(New MySqlParameter("@fcdPre", param.Precio))
        parametros.Add(New MySqlParameter("@fcdImp", param.Importe))
        parametros.Add(New MySqlParameter("@fcdIva", param.AlicuotaIVA))
        parametros.Add(New MySqlParameter("@fcdRem", param.Remitado))
        parametros.Add(New MySqlParameter("@fcdEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@fcdIdA", param.ascArticulos.idArticulo))
        parametros.Add(New MySqlParameter("@fcdIdF", param.ascFacturaCompra.idFacturaCompra))

        Return ExecuteNonQuery("sigeva.insFacturaCompraDetalle")
    End Function

    Public Function verUltimoId() As TablaFacturaCompraDetalle Implements ITransaccionesFacturaCompraDetalle.verUltimoId
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdFacturaCompraDetalle")

        If resultTable.Rows.Count > 0 Then
            Return New TablaFacturaCompraDetalle With {.idFacturaCompraDetalle = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function

    Public Function modRegistro(param As TablaFacturaCompraDetalle) As Integer Implements ITransaccionesGenericas(Of TablaFacturaCompraDetalle).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaFacturaCompraDetalle).elimRegistro
        Throw New NotImplementedException()
    End Function

    Private Function listFacturaCompraDetalle(tabla As DataTable) As List(Of TablaFacturaCompraDetalle)
        If tabla.Rows.Count > 0 Then
            Dim facturaDetalle As New List(Of TablaFacturaCompraDetalle)

            For Each item As DataRow In tabla.Rows
                facturaDetalle.Add(New TablaFacturaCompraDetalle With {
                    .idFacturaCompraDetalle = item("idFacturaCompraDetalle"),
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
                    }
                })
            Next

            Return facturaDetalle
        Else
            Return Nothing
        End If
    End Function

    Private Function listDetalleFacturaCompra_FacturaCompra(tabla As DataTable) As List(Of TablaFacturaCompraDetalle)
        If tabla.Rows.Count > 0 Then
            Dim detalle As New List(Of TablaFacturaCompraDetalle)

            For Each item As DataRow In tabla.Rows
                detalle.Add(New TablaFacturaCompraDetalle With {
                    .idFacturaCompraDetalle = item("idFacturaCompraDetalle"),
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
                    .ascFacturaCompra = New TablaFacturaCompra With {
                        .idFacturaCompra = item("idFacturaCompra"),
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
                        .ascUsuarios = New TablaUsuarios With {.idUsuario = item("Usuarios_idUsuarios")},
                        .ascProveedores = New TablaProveedores With {.idProveedor = item("Proveedores_idProveedores")},
                        .ascCuentaCorrienteCompra = New TablaCuentaCorrienteCompra With {.idCuentaCorrienteCompra = item("CuentaCorrienteCompra_idCuentaCorrienteCompra")}
                    }
                })
            Next

            Return detalle
        Else
            Return Nothing
        End If
    End Function
End Class
