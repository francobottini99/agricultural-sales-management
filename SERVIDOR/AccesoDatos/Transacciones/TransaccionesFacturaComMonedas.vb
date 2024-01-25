Imports MySql.Data.MySqlClient

Public Class TransaccionesFacturaComMonedas
    Inherits Transacciones
    Implements ITransaccionesFacturaComMonedas

    Public Function elimRegistroPorIdFacturaCompra(id As Integer) As Integer Implements ITransaccionesFacturaComMonedas.elimRegistroPorIdFacturaCompra
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdFc", id))

        Return ExecuteNonQuery("sigeva.elimFacturaComMonedas_idFacturaCompra")
    End Function

    Public Function verRegistrosPorIdFacturaCompra(id As Integer) As TablaFacturaComMonedas Implements ITransaccionesFacturaComMonedas.verRegistrosPorIdFacturaCompra
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idFc", id))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verFacturaComMonedas_idFacturaCompra")

        If resultTable.Rows.Count > 0 Then
            Return New TablaFacturaComMonedas With {
                        .idFacturaComMonedas = resultTable.Rows(0).Item("idFacturaComMonedas"),
                        .TipoCambio = resultTable.Rows(0).Item("TipoCambio"),
                        .ImporteNeto = resultTable.Rows(0).Item("ImporteNeto"),
                        .DescuentoGral = resultTable.Rows(0).Item("DescuentoGral"),
                        .BaseImponible = resultTable.Rows(0).Item("BaseImponible"),
                        .IVA = resultTable.Rows(0).Item("Iva"),
                        .ImporteTotal = resultTable.Rows(0).Item("ImporteTotal")
            }
        Else
            Return Nothing
        End If
    End Function

    Public Function verRegistros() As List(Of TablaFacturaComMonedas) Implements ITransaccionesGenericas(Of TablaFacturaComMonedas).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaFacturaComMonedas) As Integer Implements ITransaccionesGenericas(Of TablaFacturaComMonedas).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@fcmTic", param.TipoCambio))
        parametros.Add(New MySqlParameter("@fcmImN", param.ImporteNeto))
        parametros.Add(New MySqlParameter("@fcmDsc", param.DescuentoGral))
        parametros.Add(New MySqlParameter("@fcmBim", param.BaseImponible))
        parametros.Add(New MySqlParameter("@fcmIva", param.IVA))
        parametros.Add(New MySqlParameter("@fcmImT", param.ImporteTotal))
        parametros.Add(New MySqlParameter("@fcmEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@fcmIdFc", param.ascFacturaCompra.idFacturaCompra))

        Return ExecuteNonQuery("sigeva.insFacturaComMonedas")
    End Function

    Public Function modRegistro(param As TablaFacturaComMonedas) As Integer Implements ITransaccionesGenericas(Of TablaFacturaComMonedas).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaFacturaComMonedas).elimRegistro
        Throw New NotImplementedException()
    End Function

    Private Function listFacturaComMonedas(tabla As DataTable) As List(Of TablaFacturaComMonedas)
        If tabla.Rows.Count > 0 Then
            Dim factura As New List(Of TablaFacturaComMonedas)

            For Each item As DataRow In tabla.Rows
                factura.Add(New TablaFacturaComMonedas With {
                    .idFacturaComMonedas = item("idFacturaComMonedas"),
                    .TipoCambio = item("TipoCambio"),
                    .ImporteNeto = item("ImporteNeto"),
                    .DescuentoGral = item("DescuentoGral"),
                    .BaseImponible = item("BaseImponible"),
                    .IVA = item("Iva"),
                    .ImporteTotal = item("ImporteTotal")
                })
            Next

            Return factura
        Else
            Return Nothing
        End If
    End Function
End Class
