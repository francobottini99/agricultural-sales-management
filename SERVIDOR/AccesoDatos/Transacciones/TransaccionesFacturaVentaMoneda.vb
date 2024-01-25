Imports MySql.Data.MySqlClient

Public Class TransaccionesFacturaVentaMoneda
    Inherits Transacciones
    Implements ITransaccionesFacturaVentaMoneda

    Public Function verRegistroPorIdFacturaVenta(id As Integer) As TablaFacturaVentaMonedas Implements ITransaccionesFacturaVentaMoneda.verRegistroPorIdFacturaVenta
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idFv", id))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verFacturaVtaMonedas_idFacturaVenta")

        If resultTable.Rows.Count > 0 Then
            Return New TablaFacturaVentaMonedas With {
                        .idFacturaVtaMonedas = resultTable.Rows(0).Item("idFacturaVtaMonedas"),
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

    Public Function elimRegistroPorIdFacturaVenta(id As Integer) As Integer Implements ITransaccionesFacturaVentaMoneda.elimRegistroPorIdFacturaVenta
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdFv", id))

        Return ExecuteNonQuery("sigeva.elimFacturaVtaMonedas_idFacturaVenta")
    End Function

    Public Function verRegistros() As List(Of TablaFacturaVentaMonedas) Implements ITransaccionesGenericas(Of TablaFacturaVentaMonedas).verRegistros
        Return listFacturaVentaMonedas(ExecuteReader("sigeva.verFacturaVtaMonedas"))
    End Function

    Public Function insRegistro(param As TablaFacturaVentaMonedas) As Integer Implements ITransaccionesGenericas(Of TablaFacturaVentaMonedas).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@fvmTic", param.TipoCambio))
        parametros.Add(New MySqlParameter("@fvmImN", param.ImporteNeto))
        parametros.Add(New MySqlParameter("@fvmDsc", param.DescuentoGral))
        parametros.Add(New MySqlParameter("@fvmBim", param.BaseImponible))
        parametros.Add(New MySqlParameter("@fvmIva", param.IVA))
        parametros.Add(New MySqlParameter("@fvmImT", param.ImporteTotal))
        parametros.Add(New MySqlParameter("@fvmEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@fvmIdFv", param.ascFacturaVenta.idFacturaVenta))

        Return ExecuteNonQuery("sigeva.insFacturaVtaMonedas")
    End Function

    Public Function modRegistro(param As TablaFacturaVentaMonedas) As Integer Implements ITransaccionesGenericas(Of TablaFacturaVentaMonedas).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaFacturaVentaMonedas).elimRegistro
        Throw New NotImplementedException()
    End Function

    Private Function listFacturaVentaMonedas(tabla As DataTable) As List(Of TablaFacturaVentaMonedas)
        If tabla.Rows.Count > 0 Then
            Dim facturaVentaMonedas As New List(Of TablaFacturaVentaMonedas)

            For Each item As DataRow In tabla.Rows
                facturaVentaMonedas.Add(New TablaFacturaVentaMonedas With {
                        .idFacturaVtaMonedas = item("idFacturaVtaMonedas"),
                        .TipoCambio = item("TipoCambio"),
                        .ImporteNeto = item("ImporteNeto"),
                        .DescuentoGral = item("DescuentoGral"),
                        .BaseImponible = item("BaseImponible"),
                        .IVA = item("Iva"),
                        .ImporteTotal = item("ImporteTotal"),
                        .ascFacturaVenta = New TablaFacturaVenta With {.idFacturaVenta = item("FacturaVenta_idFacturaVenta")}
                    })
            Next

            Return facturaVentaMonedas
        Else
            Return Nothing
        End If
    End Function
End Class
