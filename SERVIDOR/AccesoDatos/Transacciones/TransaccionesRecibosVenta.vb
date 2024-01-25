Imports MySql.Data.MySqlClient

Public Class TransaccionesRecibosVenta
    Inherits Transacciones
    Implements ITransaccionesRecibosVenta

    Public Function verRegistros() As List(Of TablaRecibosVenta) Implements ITransaccionesGenericas(Of TablaRecibosVenta).verRegistros
        Return listRecibosVenta(ExecuteReader("sigeva.verRecibosVenta"))
    End Function

    Public Function insRegistro(param As TablaRecibosVenta) As Integer Implements ITransaccionesGenericas(Of TablaRecibosVenta).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@rvNro", param.NroComprobante))
        parametros.Add(New MySqlParameter("@rvFec", param.Fecha))
        parametros.Add(New MySqlParameter("@rvImP", param.ImportePesos))
        parametros.Add(New MySqlParameter("@rvImD", param.ImporteDolares))
        parametros.Add(New MySqlParameter("@rvObs", param.Observaciones))
        parametros.Add(New MySqlParameter("@rvEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@rvIdUs", param.ascUsuarios.idUsuario))
        parametros.Add(New MySqlParameter("@rvIdCli", param.ascClientes.idCliente))
        parametros.Add(New MySqlParameter("@rvIdCtaCte", param.ascCuentaCorrienteVenta.idCuentaCorrienteVentas))

        Return ExecuteNonQuery("sigeva.insRecibosVenta")
    End Function

    Public Function modRegistro(param As TablaRecibosVenta) As Integer Implements ITransaccionesGenericas(Of TablaRecibosVenta).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@rvId", param.idRecibosVenta))
        parametros.Add(New MySqlParameter("@rvNro", param.NroComprobante))
        parametros.Add(New MySqlParameter("@rvFec", param.Fecha))
        parametros.Add(New MySqlParameter("@rvImP", param.ImportePesos))
        parametros.Add(New MySqlParameter("@rvImD", param.ImporteDolares))
        parametros.Add(New MySqlParameter("@rvObs", param.Observaciones))
        parametros.Add(New MySqlParameter("@rvEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@rvIdUs", param.ascUsuarios.idUsuario))
        parametros.Add(New MySqlParameter("@rvIdCli", param.ascClientes.idCliente))
        parametros.Add(New MySqlParameter("@rvIdCtaCte", param.ascCuentaCorrienteVenta.idCuentaCorrienteVentas))

        Return ExecuteNonQuery("sigeva.modRecibosVenta")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaRecibosVenta).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@rvId", id))

        Return ExecuteNonQuery("sigeva.elimRecibosVenta")
    End Function

    Public Function verUltimoID() As TablaRecibosVenta Implements ITransaccionesRecibosVenta.verUltimoID
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdRecibosVenta")

        If resultTable.Rows.Count > 0 Then
            Return New TablaRecibosVenta With {.idRecibosVenta = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function

    Private Function listRecibosVenta(tabla As DataTable) As List(Of TablaRecibosVenta)
        If tabla.Rows.Count > 0 Then
            Dim recibosVenta As New List(Of TablaRecibosVenta)

            For Each item As DataRow In tabla.Rows
                recibosVenta.Add(New TablaRecibosVenta With {
                    .idRecibosVenta = item("idRecibosVenta"),
                    .NroComprobante = item("NroComprobante"),
                    .Fecha = item("Fecha"),
                    .ImportePesos = item("ImportePesos"),
                    .ImporteDolares = item("ImporteDolares"),
                    .Observaciones = item("Observaciones"),
                    .Eliminado = item("Eliminado"),
                    .ascUsuarios = New TablaUsuarios With {.idUsuario = item("Usuarios_idUsuarios")},
                    .ascClientes = New TablaClientes With {.idCliente = item("Clientes_idClientes")},
                    .ascCuentaCorrienteVenta = New TablaCuentaCorrienteVenta With {.idCuentaCorrienteVentas = item("CuentaCorrienteVentas_idCuentaCorrienteVentas")}
                })
            Next

            Return recibosVenta
        Else
            Return Nothing
        End If
    End Function
End Class
