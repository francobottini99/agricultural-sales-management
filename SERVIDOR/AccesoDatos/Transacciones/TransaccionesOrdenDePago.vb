Imports MySql.Data.MySqlClient

Public Class TransaccionesOrdenDePago
    Inherits Transacciones
    Implements ITransaccionesOrdenDePago

    Public Function verRegistros() As List(Of TablaOrdenDePago) Implements ITransaccionesGenericas(Of TablaOrdenDePago).verRegistros
        Return listOrdenDePago(ExecuteReader("sigeva.verOrdenDePago"))
    End Function

    Public Function insRegistro(param As TablaOrdenDePago) As Integer Implements ITransaccionesGenericas(Of TablaOrdenDePago).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@opNro", param.NroComprobante))
        parametros.Add(New MySqlParameter("@opFec", param.Fecha))
        parametros.Add(New MySqlParameter("@opImP", param.ImportePesos))
        parametros.Add(New MySqlParameter("@opImD", param.ImporteDolares))
        parametros.Add(New MySqlParameter("@opObs", param.Observaciones))
        parametros.Add(New MySqlParameter("@opEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@opIdUs", param.ascUsuarios.idUsuario))
        parametros.Add(New MySqlParameter("@opIdProv", param.ascProveedores.idProveedor))
        parametros.Add(New MySqlParameter("@opIdCtaCte", param.ascCuentaCorrienteCompra.idCuentaCorrienteCompra))

        Return ExecuteNonQuery("sigeva.insOrdenDePago")
    End Function

    Public Function modRegistro(param As TablaOrdenDePago) As Integer Implements ITransaccionesGenericas(Of TablaOrdenDePago).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@opId", param.idOrdenDePago))
        parametros.Add(New MySqlParameter("@opNro", param.NroComprobante))
        parametros.Add(New MySqlParameter("@opFec", param.Fecha))
        parametros.Add(New MySqlParameter("@opImP", param.ImportePesos))
        parametros.Add(New MySqlParameter("@opImD", param.ImporteDolares))
        parametros.Add(New MySqlParameter("@opObs", param.Observaciones))
        parametros.Add(New MySqlParameter("@opEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@opIdUs", param.ascUsuarios.idUsuario))
        parametros.Add(New MySqlParameter("@opIdProv", param.ascProveedores.idProveedor))
        parametros.Add(New MySqlParameter("@opIdCtaCte", param.ascCuentaCorrienteCompra.idCuentaCorrienteCompra))

        Return ExecuteNonQuery("sigeva.modOrdenDePago")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaOrdenDePago).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@opId", id))

        Return ExecuteNonQuery("sigeva.elimOrdenDePago")
    End Function

    Public Function verUltimoID() As TablaOrdenDePago Implements ITransaccionesOrdenDePago.verUltimoID
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdOrdenDePago")

        If resultTable.Rows.Count > 0 Then
            Return New TablaOrdenDePago With {.idOrdenDePago = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verOrdenDePagoPorId(id As Integer) As TablaOrdenDePago Implements ITransaccionesOrdenDePago.verOrdenDePagoPorId
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@id", id))

        Return listOrdenDePago(ExecuteReader("sigeva.verOrdenDePago_idOrdenDePago")).First
    End Function

    Private Function listOrdenDePago(tabla As DataTable) As List(Of TablaOrdenDePago)
        If tabla.Rows.Count > 0 Then
            Dim ordenesDePago As New List(Of TablaOrdenDePago)

            For Each item As DataRow In tabla.Rows
                ordenesDePago.Add(New TablaOrdenDePago With {
                    .idOrdenDePago = item("idOrdenDePago"),
                    .NroComprobante = item("NroComprobante"),
                    .Fecha = item("Fecha"),
                    .ImportePesos = item("ImportePesos"),
                    .ImporteDolares = item("ImporteDolares"),
                    .Observaciones = item("Observaciones"),
                    .Eliminado = item("Eliminado"),
                    .ascUsuarios = New TablaUsuarios With {.idUsuario = item("Usuarios_idUsuarios")},
                    .ascProveedores = New TablaProveedores With {.idProveedor = item("Proveedores_idProveedores")},
                    .ascCuentaCorrienteCompra = New TablaCuentaCorrienteCompra With {.idCuentaCorrienteCompra = item("CuentaCorrienteCompra_idCuentaCorrienteCompra")}
                })
            Next

            Return ordenesDePago
        Else
            Return Nothing
        End If
    End Function
End Class
