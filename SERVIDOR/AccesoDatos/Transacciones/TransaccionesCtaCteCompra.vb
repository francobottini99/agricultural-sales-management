Imports MySql.Data.MySqlClient

Public Class TransaccionesCtaCteCompra
    Inherits Transacciones
    Implements ITransaccionesCtaCteCompra

    Public Function verUltimoID() As TablaCuentaCorrienteCompra Implements ITransaccionesCtaCteCompra.verUltimoID
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdCuentaCorrienteCompra")

        If resultTable.Rows.Count > 0 Then
            Return New TablaCuentaCorrienteCompra With {.idCuentaCorrienteCompra = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verRegistros() As List(Of TablaCuentaCorrienteCompra) Implements ITransaccionesGenericas(Of TablaCuentaCorrienteCompra).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaCuentaCorrienteCompra) As Integer Implements ITransaccionesGenericas(Of TablaCuentaCorrienteCompra).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@cccFec", param.Fecha))
        parametros.Add(New MySqlParameter("@cccVto", param.FechaVto))
        parametros.Add(New MySqlParameter("@cccCom", param.Comprobante))
        parametros.Add(New MySqlParameter("@cccNum", param.Numero))
        parametros.Add(New MySqlParameter("@cccDet", param.Detalle))
        parametros.Add(New MySqlParameter("@cccDeb", param.Debito))
        parametros.Add(New MySqlParameter("@cccCre", param.Credito))
        parametros.Add(New MySqlParameter("@cccEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@cccVis", param.Visible))
        parametros.Add(New MySqlParameter("@cccIdProv", param.ascProveedores.idProveedor))
        parametros.Add(New MySqlParameter("@cccIdUs", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.insCuentaCorrienteCompra")
    End Function

    Public Function modRegistro(param As TablaCuentaCorrienteCompra) As Integer Implements ITransaccionesGenericas(Of TablaCuentaCorrienteCompra).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaCuentaCorrienteCompra).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdCc", id))

        Return ExecuteNonQuery("sigeva.elimCuentaCorrienteCompra")
    End Function

    Public Function verCuentaCorrienteVentaPorIdProveedor(idProveedor As Integer) As List(Of TablaCuentaCorrienteCompra) Implements ITransaccionesCtaCteCompra.verCuentaCorrienteVentaPorIdProveedor
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@cccIdProv", idProveedor)
        }

        Return Driver(ExecuteReader("sigeva.verCuentaCorrienteCompra_idProveedor"))
    End Function

    Private Function Driver(tabla As DataTable) As List(Of TablaCuentaCorrienteCompra)
        If tabla.Rows.Count > 0 Then
            Dim lista As New List(Of TablaCuentaCorrienteCompra)

            For Each item As DataRow In tabla.Rows
                lista.Add(New TablaCuentaCorrienteCompra With {
                    .idCuentaCorrienteCompra = item("idCuentaCorrienteCompra"),
                    .Fecha = item("Fecha"),
                    .FechaVto = item("FechaVto"),
                    .Comprobante = item("Comprobante"),
                    .Numero = item("Numero"),
                    .Detalle = item("Detalle"),
                    .Debito = item("Debito"),
                    .Credito = item("Credito"),
                    .Eliminado = item("Eliminado"),
                    .Visible = item("Visible"),
                    .ascProveedores = New TablaProveedores With {.idProveedor = item("Proveedores_idProveedores")},
                    .ascUsuarios = New TablaUsuarios With {.idUsuario = item("Usuarios_idUsuarios")}
                })
            Next

            Return lista
        Else
            Return Nothing
        End If
    End Function
End Class
