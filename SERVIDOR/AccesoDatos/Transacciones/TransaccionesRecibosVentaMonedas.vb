Imports MySql.Data.MySqlClient

Public Class TransaccionesRecibosVentaMonedas
    Inherits Transacciones
    Implements ITransaccionesRecibosVentaMonedas

    Public Function verRegistroPorIdRecibosVenta(id As Integer) As List(Of TablaRecibosVentaMonedas) Implements ITransaccionesRecibosVentaMonedas.verRegistroPorIdRecibosVenta
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idRvm", id))

        Return listRecibosVentaMonedas(ExecuteReader("sigeva.verRecibosVentaMonedas_idRecibosVenta"))
    End Function

    Public Function elimRegistroPorIdRecibosVenta(id As Integer) As Integer Implements ITransaccionesRecibosVentaMonedas.elimRegistroPorIdRecibosVenta
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idRv", id))

        Return ExecuteNonQuery("sigeva.elimRecibosVentaMonedas_idRecibosVenta")
    End Function

    Public Function verRegistros() As List(Of TablaRecibosVentaMonedas) Implements ITransaccionesGenericas(Of TablaRecibosVentaMonedas).verRegistros
        Return listRecibosVentaMonedas(ExecuteReader("sigeva.verRecibosVentaMonedas"))
    End Function

    Public Function insRegistro(param As TablaRecibosVentaMonedas) As Integer Implements ITransaccionesGenericas(Of TablaRecibosVentaMonedas).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@rvmTpc", param.TipoCambio))
        parametros.Add(New MySqlParameter("@rvmImN", param.ImporteNeto))
        parametros.Add(New MySqlParameter("@rvmDes", param.DescuentoGral))
        parametros.Add(New MySqlParameter("@rvmBas", param.BaseImponible))
        parametros.Add(New MySqlParameter("@rvmIva", param.IVA))
        parametros.Add(New MySqlParameter("@rvmImT", param.ImporteTotal))
        parametros.Add(New MySqlParameter("@rvmEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@rvmIdRv", param.ascRecibosVenta.idRecibosVenta))

        Return ExecuteNonQuery("sigeva.insRecibosVentaMonedas")
    End Function

    Public Function modRegistro(param As TablaRecibosVentaMonedas) As Integer Implements ITransaccionesGenericas(Of TablaRecibosVentaMonedas).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@rvmId", param.idRecibosVentaMonedas))
        parametros.Add(New MySqlParameter("@rvmTpc", param.TipoCambio))
        parametros.Add(New MySqlParameter("@rvmImN", param.ImporteNeto))
        parametros.Add(New MySqlParameter("@rvmDes", param.DescuentoGral))
        parametros.Add(New MySqlParameter("@rvmBas", param.BaseImponible))
        parametros.Add(New MySqlParameter("@rvmIva", param.IVA))
        parametros.Add(New MySqlParameter("@rvmImT", param.ImporteTotal))
        parametros.Add(New MySqlParameter("@rvmEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@rvmIdRv", param.ascRecibosVenta.idRecibosVenta))

        Return ExecuteNonQuery("sigeva.modRecibosVentaMonedas")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaRecibosVentaMonedas).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdRvm", id))

        Return ExecuteNonQuery("sigeva.elimRecibosVentaMonedas")
    End Function

    Private Function listRecibosVentaMonedas(tabla As DataTable) As List(Of TablaRecibosVentaMonedas)
        If tabla.Rows.Count > 0 Then
            Dim rvm As New List(Of TablaRecibosVentaMonedas)

            For Each item As DataRow In tabla.Rows
                rvm.Add(New TablaRecibosVentaMonedas With {
                    .idRecibosVentaMonedas = item("idRecibosVentaMonedas"),
                    .TipoCambio = item("TipoCambio"),
                    .ImporteNeto = item("ImporteNeto"),
                    .DescuentoGral = item("DescuentoGral"),
                    .BaseImponible = item("BaseImponible"),
                    .IVA = item("Iva"),
                    .ImporteTotal = item("ImporteTotal"),
                    .Eliminado = item("Eliminado"),
                    .ascRecibosVenta = New TablaRecibosVenta With {.idRecibosVenta = item("RecibosVenta_idRecibosVenta")}
                })
            Next

            Return rvm
        Else
            Return Nothing
        End If
    End Function
End Class
