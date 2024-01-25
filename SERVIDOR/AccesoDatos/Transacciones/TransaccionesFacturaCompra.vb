Imports MySql.Data.MySqlClient

Public Class TransaccionesFacturaCompra
    Inherits Transacciones
    Implements ITransaccionesFacturaCompra

    Public Function verUltimoId() As TablaFacturaCompra Implements ITransaccionesFacturaCompra.verUltimoId
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdFacturaCompra")

        If resultTable.Rows.Count > 0 Then
            Return New TablaFacturaCompra With {.idFacturaCompra = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function

    Public Function modEstadoRemitado(id As Integer, estRem As String) As Integer Implements ITransaccionesFacturaCompra.modEstadoRemitado
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@fcID", id))
        parametros.Add(New MySqlParameter("@fcRem", estRem))

        Return ExecuteNonQuery("sigeva.modFacturaCompra_Remitado")
    End Function

    Public Function verRegistros() As List(Of TablaFacturaCompra) Implements ITransaccionesGenericas(Of TablaFacturaCompra).verRegistros
        Return listFacturaCompra(ExecuteReader("sigeva.verFacturaCompra"))
    End Function

    Public Function insRegistro(param As TablaFacturaCompra) As Integer Implements ITransaccionesGenericas(Of TablaFacturaCompra).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@fcFec", param.Fecha))
        parametros.Add(New MySqlParameter("@fcTip", param.TipoComprobante))
        parametros.Add(New MySqlParameter("@fcCla", param.ClaseComprobante))
        parametros.Add(New MySqlParameter("@fcFecVto", param.FechaVto))
        parametros.Add(New MySqlParameter("@fcPre", param.Prefijo))
        parametros.Add(New MySqlParameter("@fcNro", param.NroComprobante))
        parametros.Add(New MySqlParameter("@fcImN", param.ImporteNeto))
        parametros.Add(New MySqlParameter("@fcDsc", param.DescuentoGral))
        parametros.Add(New MySqlParameter("@fcBim", param.BaseImponible))
        parametros.Add(New MySqlParameter("@fcIva", param.Iva))
        parametros.Add(New MySqlParameter("@fcImT", param.ImporteTotal))
        parametros.Add(New MySqlParameter("@fcObs", param.Observaciones))
        parametros.Add(New MySqlParameter("@fcRem", param.Remitado))
        parametros.Add(New MySqlParameter("@fcEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@fcIdUs", param.ascUsuarios.idUsuario))
        parametros.Add(New MySqlParameter("@fcIdProv", param.ascProveedores.idProveedor))
        parametros.Add(New MySqlParameter("@fcIdCta", param.ascCuentaCorrienteCompra.idCuentaCorrienteCompra))

        Return ExecuteNonQuery("sigeva.insFacturaCompra")
    End Function

    Public Function modRegistro(param As TablaFacturaCompra) As Integer Implements ITransaccionesGenericas(Of TablaFacturaCompra).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@fcID", param.idFacturaCompra))
        parametros.Add(New MySqlParameter("@fcTip", param.TipoComprobante))
        parametros.Add(New MySqlParameter("@fcCla", param.ClaseComprobante))
        parametros.Add(New MySqlParameter("@fcFec", param.Fecha))
        parametros.Add(New MySqlParameter("@fcFecVto", param.FechaVto))
        parametros.Add(New MySqlParameter("@fcPre", param.Prefijo))
        parametros.Add(New MySqlParameter("@fcNro", param.NroComprobante))
        parametros.Add(New MySqlParameter("@fcImN", param.ImporteNeto))
        parametros.Add(New MySqlParameter("@fcDsc", param.DescuentoGral))
        parametros.Add(New MySqlParameter("@fcBim", param.BaseImponible))
        parametros.Add(New MySqlParameter("@fcIva", param.Iva))
        parametros.Add(New MySqlParameter("@fcImT", param.ImporteTotal))
        parametros.Add(New MySqlParameter("@fcObs", param.Observaciones))
        parametros.Add(New MySqlParameter("@fcRem", param.Remitado))
        parametros.Add(New MySqlParameter("@fcEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@fcIdUs", param.ascUsuarios.idUsuario))
        parametros.Add(New MySqlParameter("@fcIdProv", param.ascProveedores.idProveedor))
        parametros.Add(New MySqlParameter("@fcIdCta", param.ascCuentaCorrienteCompra.idCuentaCorrienteCompra))

        Return ExecuteNonQuery("sigeva.modFacturaCompra")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaFacturaCompra).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdFc", id))

        Return ExecuteNonQuery("sigeva.elimFacturaCompra")
    End Function

    Public Function verRegistroPorId(id As Integer) As TablaFacturaCompra Implements ITransaccionesFacturaCompra.verRegistroPorId
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idFc", id))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verFacturaCompra_idFacturaCompra")

        If resultTable.Rows.Count > 0 Then
            Return New TablaFacturaCompra With {
                        .idFacturaCompra = resultTable.Rows(0).Item("idFacturaCompra"),
                        .TipoComprobante = resultTable.Rows(0).Item("TipoComprobante"),
                        .ClaseComprobante = resultTable.Rows(0).Item("ClaseComprobante"),
                        .Fecha = resultTable.Rows(0).Item("Fecha"),
                        .FechaVto = resultTable.Rows(0).Item("FechaVto"),
                        .Prefijo = resultTable.Rows(0).Item("Prefijo"),
                        .NroComprobante = resultTable.Rows(0).Item("NroComprobante"),
                        .ImporteNeto = resultTable.Rows(0).Item("ImporteNeto"),
                        .DescuentoGral = resultTable.Rows(0).Item("DescuentoGral"),
                        .BaseImponible = resultTable.Rows(0).Item("BaseImponible"),
                        .Iva = resultTable.Rows(0).Item("Iva"),
                        .ImporteTotal = resultTable.Rows(0).Item("ImporteTotal"),
                        .Observaciones = resultTable.Rows(0).Item("Observaciones"),
                        .Remitado = resultTable.Rows(0).Item("Remitado"),
                        .Eliminado = resultTable.Rows(0).Item("Eliminado"),
                        .ascUsuarios = New TablaUsuarios With {
                            .idUsuario = resultTable.Rows(0).Item("Usuarios_idUsuarios")
                        },
                        .ascCuentaCorrienteCompra = New TablaCuentaCorrienteCompra With {
                            .idCuentaCorrienteCompra = resultTable.Rows(0).Item("CuentaCorrienteCompra_idCuentaCorrienteCompra")
                        },
                        .ascProveedores = New TablaProveedores With {
                            .idProveedor = resultTable.Rows(0).Item("Proveedores_idProveedores"),
                            .RazonSocial = resultTable.Rows(0).Item("RazonSocial"),
                            .Direccion = resultTable.Rows(0).Item("Direccion"),
                            .Localidad = resultTable.Rows(0).Item("Localidad"),
                            .Provincia = resultTable.Rows(0).Item("Provincia"),
                            .CodPostal = resultTable.Rows(0).Item("CP"),
                            .Pais = resultTable.Rows(0).Item("Pais"),
                            .Telefono = resultTable.Rows(0).Item("TE"),
                            .Mail = resultTable.Rows(0).Item("Mail"),
                            .Web = resultTable.Rows(0).Item("Web"),
                            .CUIT = resultTable.Rows(0).Item("CUIT"),
                            .IIBB = resultTable.Rows(0).Item("IIBB"),
                            .SituacionIVA = resultTable.Rows(0).Item("SituacionIVA"),
                            .Estado = resultTable.Rows(0).Item("Estado"),
                            .Eliminado = resultTable.Rows(0).Item("Eliminado")
                        }
            }
        Else
            Return Nothing
        End If
    End Function

    Private Function listFacturaCompra(tabla As DataTable) As List(Of TablaFacturaCompra)
        If tabla.Rows.Count > 0 Then
            Dim factura As New List(Of TablaFacturaCompra)

            For Each item As DataRow In tabla.Rows
                factura.Add(New TablaFacturaCompra With {
                        .idFacturaCompra = item("idFacturaCompra"),
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
                        .ascUsuarios = New TablaUsuarios With {
                            .idUsuario = item("Usuarios_idUsuarios")
                        },
                        .ascCuentaCorrienteCompra = New TablaCuentaCorrienteCompra With {
                            .idCuentaCorrienteCompra = item("CuentaCorrienteCompra_idCuentaCorrienteCompra")
                        },
                        .ascProveedores = New TablaProveedores With {
                            .idProveedor = item("Proveedores_idProveedores"),
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
                        }
                    })
            Next

            Return factura
        Else
            Return Nothing
        End If
    End Function
End Class
