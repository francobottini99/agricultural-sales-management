Imports MySql.Data.MySqlClient

Public Class TransaccionesFacturaVenta
    Inherits Transacciones
    Implements ITransaccionesFacturaVenta

    Public Function verUltimoID() As TablaFacturaVenta Implements ITransaccionesFacturaVenta.verUltimoID
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdFacturaVenta")

        If resultTable.Rows.Count > 0 Then
            Return New TablaFacturaVenta With {.idFacturaVenta = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function

    Public Function modEstadoRemitado(id As Integer, estRem As String) As Integer Implements ITransaccionesFacturaVenta.modEstadoRemitado
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@fvID", id))
        parametros.Add(New MySqlParameter("@fvRem", estRem))

        Return ExecuteNonQuery("sigeva.modFacturaVenta_Remitado")
    End Function

    Public Function modFacturaVentaCAE(id As Integer, CAE As String, fchVtoCAE As Date) As Integer Implements ITransaccionesFacturaVenta.modFacturaVentaCAE
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@fvID", id))
        parametros.Add(New MySqlParameter("@fvCAE", CAE))
        parametros.Add(New MySqlParameter("@fvFcCAE", fchVtoCAE))

        Return ExecuteNonQuery("sigeva.modFacturaVenta_CAE")
    End Function

    Public Function verFacturasVentaSinRemitar() As List(Of TablaFacturaVenta) Implements ITransaccionesFacturaVenta.verFacturasVentaSinRemitar
        Return listFacturasVenta(ExecuteReader("sigeva.verFacturaVenta_Sin_Remitar"))
    End Function

    Public Function verRegistros() As List(Of TablaFacturaVenta) Implements ITransaccionesGenericas(Of TablaFacturaVenta).verRegistros
        Return listFacturasVenta(ExecuteReader("sigeva.verFacturaVenta"))
    End Function

    Public Function insRegistro(param As TablaFacturaVenta) As Integer Implements ITransaccionesGenericas(Of TablaFacturaVenta).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@fvTipo", param.TipoComprobante))
        parametros.Add(New MySqlParameter("@fvClase", param.ClaseComprobante))
        parametros.Add(New MySqlParameter("@fvFec", param.Fecha))
        parametros.Add(New MySqlParameter("@fvFecVto", param.FechaVto))
        parametros.Add(New MySqlParameter("@fvPre", param.Prefijo))
        parametros.Add(New MySqlParameter("@fvNro", param.NroComprobante))
        parametros.Add(New MySqlParameter("@fvImN", param.ImporteNeto))
        parametros.Add(New MySqlParameter("@fvDsc", param.DescuentoGral))
        parametros.Add(New MySqlParameter("@fvBim", param.BaseImponible))
        parametros.Add(New MySqlParameter("@fvIva", param.Iva))
        parametros.Add(New MySqlParameter("@fvImT", param.ImporteTotal))
        parametros.Add(New MySqlParameter("@fvObs", param.Observaciones))
        parametros.Add(New MySqlParameter("@fvRem", param.Remitado))
        parametros.Add(New MySqlParameter("@fvEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@fvCAE", param.CAE))
        parametros.Add(New MySqlParameter("@fvFecCAE", param.FechaVtoCAE))
        parametros.Add(New MySqlParameter("@fvIdCli", param.ascClientes.idCliente))
        parametros.Add(New MySqlParameter("@fvIdUs", param.ascUsuarios.idUsuario))
        parametros.Add(New MySqlParameter("@fvIdCta", param.ascCtaCteVenta.idCuentaCorrienteVentas))

        Return ExecuteNonQuery("sigeva.insFacturaVenta")
    End Function

    Public Function modRegistro(param As TablaFacturaVenta) As Integer Implements ITransaccionesGenericas(Of TablaFacturaVenta).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@fvID", param.idFacturaVenta))
        parametros.Add(New MySqlParameter("@fvTipo", param.TipoComprobante))
        parametros.Add(New MySqlParameter("@fvClase", param.ClaseComprobante))
        parametros.Add(New MySqlParameter("@fvFec", param.Fecha))
        parametros.Add(New MySqlParameter("@fvFecVto", param.FechaVto))
        parametros.Add(New MySqlParameter("@fvPre", param.Prefijo))
        parametros.Add(New MySqlParameter("@fvNro", param.NroComprobante))
        parametros.Add(New MySqlParameter("@fvImN", param.ImporteNeto))
        parametros.Add(New MySqlParameter("@fvDsc", param.DescuentoGral))
        parametros.Add(New MySqlParameter("@fvBim", param.BaseImponible))
        parametros.Add(New MySqlParameter("@fvIva", param.Iva))
        parametros.Add(New MySqlParameter("@fvImT", param.ImporteTotal))
        parametros.Add(New MySqlParameter("@fvObs", param.Observaciones))
        parametros.Add(New MySqlParameter("@fvRem", param.Remitado))
        parametros.Add(New MySqlParameter("@fvEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@fvCAE", param.CAE))
        parametros.Add(New MySqlParameter("@fvFecCAE", param.FechaVtoCAE))
        parametros.Add(New MySqlParameter("@fvIdCli", param.ascClientes.idCliente))
        parametros.Add(New MySqlParameter("@fvIdUs", param.ascUsuarios.idUsuario))
        parametros.Add(New MySqlParameter("@fvIdCta", param.ascCtaCteVenta.idCuentaCorrienteVentas))

        Return ExecuteNonQuery("sigeva.modFacturaVenta")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaFacturaVenta).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdFv", id))

        Return ExecuteNonQuery("sigeva.elimFacturaVenta")
    End Function

    Private Function listFacturasVenta(tabla As DataTable) As List(Of TablaFacturaVenta)
        If tabla.Rows.Count > 0 Then
            Dim FV As New List(Of TablaFacturaVenta)

            For Each item As DataRow In tabla.Rows
                FV.Add(New TablaFacturaVenta With {
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
                    .ascClientes = New TablaClientes With {
                        .idCliente = item("Clientes_idClientes"),
                        .RazonSocial = item("RazonSocial"),
                        .Direccion = item("Direccion"),
                        .Localidad = item("Localidad"),
                        .Provincia = item("Provincia"),
                        .CodPostal = item("CP"),
                        .Pais = item("Pais"),
                        .Telefono = item("TE"),
                        .Mail = item("Mail"),
                        .Web = item("Web"),
                        .CUIT = item("CUIT"),
                        .IIBB = item("IIBB"),
                        .SituacionIVA = item("SituacionIVA"),
                        .Estado = item("Estado"),
                        .Eliminado = item("Eliminado")
                    },
                    .ascCtaCteVenta = New TablaCuentaCorrienteVenta With {.idCuentaCorrienteVentas = item("CuentaCorrienteVentas_idCuentaCorrienteVentas")}
                })
            Next

            Return FV
        Else
            Return Nothing
        End If
    End Function

End Class
