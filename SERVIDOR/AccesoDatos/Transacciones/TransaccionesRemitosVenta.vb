Imports MySql.Data.MySqlClient

Public Class TransaccionesRemitosVenta
    Inherits Transacciones
    Implements ITransaccionesRemtiosVenta

    Public Function verUltimoId() As TablaRemitosVenta Implements ITransaccionesRemtiosVenta.verUltimoId
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdRemitosVenta")

        If resultTable.Rows.Count > 0 Then
            Return New TablaRemitosVenta With {.idRemitosVenta = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verRegistroPorId(id As Integer) As TablaRemitosVenta Implements ITransaccionesRemtiosVenta.verRegistroPorId
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idRv", id))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verRemitosVenta_idRemitosVenta")

        If resultTable.Rows.Count > 0 Then
            Return New TablaRemitosVenta With {
                .idRemitosVenta = resultTable.Rows(0).Item("idRemitosVenta"),
                .NroComprobante = resultTable.Rows(0).Item("NroComprobante"),
                .Fecha = resultTable.Rows(0).Item("Fecha"),
                .Importe = resultTable.Rows(0).Item("Importe"),
                .Observaciones = resultTable.Rows(0).Item("Observaciones"),
                .ImpOriginal = resultTable.Rows(0).Item("ImpOriginal"),
                .ImpCopia = resultTable.Rows(0).Item("ImpCopia"),
                .Facturado = resultTable.Rows(0).Item("Facturado"),
                .CAE = resultTable.Rows(0).Item("CAE"),
                .FechaVtoCAE = resultTable.Rows(0).Item("FechaVtaCAE"),
                .ascClientes = New TablaClientes With {
                    .idCliente = resultTable.Rows(0).Item("Clientes_idClientes"),
                    .RazonSocial = resultTable.Rows(0).Item("RazonSocial")
                },
                .ascUsuarios = New TablaUsuarios With {.idUsuario = resultTable.Rows(0).Item("Usuarios_idUsuarios")}
            }
        Else
            Return Nothing
        End If
    End Function

    Public Function verSinFacturar() As List(Of TablaRemitosVenta) Implements ITransaccionesRemtiosVenta.verSinFacturar
        Return listRemitoVenta(ExecuteReader("sigeva.verRemitosVenta_Sin_Facturar"))
    End Function

    Public Function modEstadoFacturacion(id As Integer, estFact As String) As Integer Implements ITransaccionesRemtiosVenta.modEstadoFacturacion
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@rcID", id))
        parametros.Add(New MySqlParameter("@rcFac", estFact))

        Return ExecuteNonQuery("sigeva.modRemitoVenta_Facturado")
    End Function

    Public Function verRegistros() As List(Of TablaRemitosVenta) Implements ITransaccionesGenericas(Of TablaRemitosVenta).verRegistros
        Return listRemitoVenta(ExecuteReader("sigeva.verRemitosVenta"))
    End Function

    Public Function insRegistro(param As TablaRemitosVenta) As Integer Implements ITransaccionesGenericas(Of TablaRemitosVenta).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@rvNroComp", param.NroComprobante))
        parametros.Add(New MySqlParameter("@rvFec", param.Fecha))
        parametros.Add(New MySqlParameter("@rvImp", param.Importe))
        parametros.Add(New MySqlParameter("@rvObs", param.Observaciones))
        parametros.Add(New MySqlParameter("@rvImpO", param.ImpOriginal))
        parametros.Add(New MySqlParameter("@rvImpC", param.ImpCopia))
        parametros.Add(New MySqlParameter("@rvFac", param.Facturado))
        parametros.Add(New MySqlParameter("@rvElim", param.Eliminado))
        parametros.Add(New MySqlParameter("@rvCAE", param.CAE))
        parametros.Add(New MySqlParameter("@rvFecCAE", param.FechaVtoCAE))
        parametros.Add(New MySqlParameter("@rvIdCli", param.ascClientes.idCliente))
        parametros.Add(New MySqlParameter("@rvIdUs", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.insRemitoVenta")
    End Function

    Public Function modRegistro(param As TablaRemitosVenta) As Integer Implements ITransaccionesGenericas(Of TablaRemitosVenta).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@rvID", param.idRemitosVenta))
        parametros.Add(New MySqlParameter("@rvComp", param.NroComprobante))
        parametros.Add(New MySqlParameter("@rvFec", param.Fecha))
        parametros.Add(New MySqlParameter("@rvImp", param.Importe))
        parametros.Add(New MySqlParameter("@rvObs", param.Observaciones))
        parametros.Add(New MySqlParameter("@rvImOr", param.ImpOriginal))
        parametros.Add(New MySqlParameter("@rvImCop", param.ImpCopia))
        parametros.Add(New MySqlParameter("@rvFac", param.Facturado))
        parametros.Add(New MySqlParameter("@rvElim", param.Eliminado))
        parametros.Add(New MySqlParameter("@rvCAE", param.CAE))
        parametros.Add(New MySqlParameter("@rvFecCAE", param.FechaVtoCAE))
        parametros.Add(New MySqlParameter("@rvIdCli", param.ascClientes.idCliente))
        parametros.Add(New MySqlParameter("@rvIdUs", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.modRemitoVenta")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaRemitosVenta).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdRV", id))

        Return ExecuteNonQuery("sigeva.elimRemVenta")
    End Function

    Private Function listRemitoVenta(tabla As DataTable) As List(Of TablaRemitosVenta)
        If tabla.Rows.Count > 0 Then
            Dim remitosVenta As New List(Of TablaRemitosVenta)

            For Each item As DataRow In tabla.Rows
                remitosVenta.Add(New TablaRemitosVenta With {
                        .idRemitosVenta = item("idRemitosVenta"),
                        .NroComprobante = item("NroComprobante"),
                        .Fecha = item("Fecha"),
                        .Importe = item("Importe"),
                        .Observaciones = item("Observaciones"),
                        .ImpOriginal = item("ImpOriginal"),
                        .ImpCopia = item("ImpCopia"),
                        .Facturado = item("Facturado"),
                        .CAE = item("CAE"),
                        .FechaVtoCAE = item("FechaVtaCAE"),
                        .ascClientes = New TablaClientes With {
                            .idCliente = item("idClientes"),
                            .RazonSocial = item("RazonSocial"),
                            .Direccion = item("Direccion"),
                            .Localidad = item("Localidad"),
                            .Provincia = item("Provincia"),
                            .CodPostal = item("CP"),
                            .Telefono = item("TE"),
                            .Mail = item("Mail"),
                            .Web = item("Web"),
                            .CUIT = item("CUIT"),
                            .IIBB = item("IIBB"),
                            .Estado = item("Estado")
                        },
                        .ascUsuarios = New TablaUsuarios With {
                            .idUsuario = item("Usuarios_idUsuarios"),
                            .Nombre = item("Nombre")
                        }
                    })
            Next

            Return remitosVenta
        Else
            Return Nothing
        End If
    End Function
End Class
