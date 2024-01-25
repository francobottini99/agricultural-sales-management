Imports MySql.Data.MySqlClient

Public Class TransaccionesCtaCteVenta
    Inherits Transacciones
    Implements ITransaccionesCtaCteVenta

    Public Function verUltimoID() As TablaCuentaCorrienteVenta Implements ITransaccionesCtaCteVenta.verUltimoID
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdCuentaCorrienteVenta")

        If resultTable.Rows.Count > 0 Then
            Return New TablaCuentaCorrienteVenta With {.idCuentaCorrienteVentas = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verRegistros() As List(Of TablaCuentaCorrienteVenta) Implements ITransaccionesGenericas(Of TablaCuentaCorrienteVenta).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaCuentaCorrienteVenta) As Integer Implements ITransaccionesGenericas(Of TablaCuentaCorrienteVenta).insRegistro
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@ccvFec", param.Fecha),
            New MySqlParameter("@ccvVto", param.FechaVto),
            New MySqlParameter("@ccvCom", param.Comprobante),
            New MySqlParameter("@ccvNum", param.Numero),
            New MySqlParameter("@ccvDet", param.Detalle),
            New MySqlParameter("@ccvDeb", param.Debito),
            New MySqlParameter("@ccvCre", param.Credito),
            New MySqlParameter("@ccvEli", param.Eliminado),
            New MySqlParameter("@ccvVis", param.Visible),
            New MySqlParameter("@ccvIdCli", param.ascClientes.idCliente),
            New MySqlParameter("@ccvIdUs", param.ascUsuarios.idUsuario)
        }

        Return ExecuteNonQuery("sigeva.insCuentaCorrienteVenta")
    End Function

    Public Function modRegistro(param As TablaCuentaCorrienteVenta) As Integer Implements ITransaccionesGenericas(Of TablaCuentaCorrienteVenta).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaCuentaCorrienteVenta).elimRegistro
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@IdCv", id)
        }

        Return ExecuteNonQuery("sigeva.elimCuentaCorrienteVenta")
    End Function

    Public Function verCuentaCorrienteVentaPorIdCliente(idCliente As Integer) As List(Of TablaCuentaCorrienteVenta) Implements ITransaccionesCtaCteVenta.verCuentaCorrienteVentaPorIdCliente
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@ccvIdCli", idCliente)
        }

        Return Driver(ExecuteReader("sigeva.verCuentaCorrienteVentas_idCliente"))
    End Function

    Private Function Driver(tabla As DataTable) As List(Of TablaCuentaCorrienteVenta)
        If tabla.Rows.Count > 0 Then
            Dim lista As New List(Of TablaCuentaCorrienteVenta)

            For Each item As DataRow In tabla.Rows
                lista.Add(New TablaCuentaCorrienteVenta With {
                    .idCuentaCorrienteVentas = item("idCuentaCorrienteVentas"),
                    .Fecha = item("Fecha"),
                    .FechaVto = item("FechaVto"),
                    .Comprobante = item("Comprobante"),
                    .Numero = item("Numero"),
                    .Detalle = item("Detalle"),
                    .Debito = item("Debito"),
                    .Credito = item("Credito"),
                    .Eliminado = item("Eliminado"),
                    .Visible = item("Visible"),
                    .ascClientes = New TablaClientes With {.idCliente = item("Clientes_idClientes")},
                    .ascUsuarios = New TablaUsuarios With {.idUsuario = item("Usuarios_idUsuarios")}
                })
            Next

            Return lista
        Else
            Return Nothing
        End If
    End Function
End Class
