Imports MySql.Data.MySqlClient

Public Class TransaccionesRemitosVentaMonedas
    Inherits Transacciones
    Implements ITransaccionesRemitosVentaMonedas

    Public Function verRegistroPorIdRemitosVenta(id As Integer) As TablaRemitosVentaMonedas Implements ITransaccionesRemitosVentaMonedas.verRegistroPorIdRemitosVenta
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idRv", id))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verRemitoVtaMonedas_idRemitosVenta")

        If resultTable.Rows.Count > 0 Then
            Return New TablaRemitosVentaMonedas With {
                        .idRemitoVtaMonedas = resultTable.Rows(0).Item("idRemitoVtaMonedas"),
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

    Public Function verRegistros() As List(Of TablaRemitosVentaMonedas) Implements ITransaccionesGenericas(Of TablaRemitosVentaMonedas).verRegistros
        Return listRemitosVentaMonedas(ExecuteReader("sigeva.verRemitoVtaMonedas"))
    End Function

    Public Function insRegistro(param As TablaRemitosVentaMonedas) As Integer Implements ITransaccionesGenericas(Of TablaRemitosVentaMonedas).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@rvmTic", param.TipoCambio))
        parametros.Add(New MySqlParameter("@rvmImN", param.ImporteNeto))
        parametros.Add(New MySqlParameter("@rvmDsc", param.DescuentoGral))
        parametros.Add(New MySqlParameter("@rvmBim", param.BaseImponible))
        parametros.Add(New MySqlParameter("@rvmIva", param.IVA))
        parametros.Add(New MySqlParameter("@rvmImT", param.ImporteTotal))
        parametros.Add(New MySqlParameter("@rvmElim", param.Eliminado))
        parametros.Add(New MySqlParameter("@rvmIdRv", param.ascRemitosventa.idRemitosVenta))

        Return ExecuteNonQuery("sigeva.insRemitoVenMonedas")
    End Function

    Public Function modRegistro(param As TablaRemitosVentaMonedas) As Integer Implements ITransaccionesGenericas(Of TablaRemitosVentaMonedas).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaRemitosVentaMonedas).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistroPorIdRemitosVenta(id As Integer) As Integer Implements ITransaccionesRemitosVentaMonedas.elimRegistroPorIdRemitosVenta
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdRV", id))

        Return ExecuteNonQuery("sigeva.elimRemVentaMonedas_IdRemVenta")
    End Function

    Private Function listRemitosVentaMonedas(tabla As DataTable) As List(Of TablaRemitosVentaMonedas)
        If tabla.Rows.Count > 0 Then
            Dim remitosVentaMonedas As New List(Of TablaRemitosVentaMonedas)

            For Each item As DataRow In tabla.Rows
                remitosVentaMonedas.Add(New TablaRemitosVentaMonedas With {
                        .idRemitoVtaMonedas = item("idRemitoVtaMonedas"),
                        .TipoCambio = item("TipoCambio"),
                        .ImporteNeto = item("ImporteNeto"),
                        .DescuentoGral = item("DescuentoGral"),
                        .BaseImponible = item("BaseImponible"),
                        .IVA = item("Iva"),
                        .ImporteTotal = item("ImporteTotal"),
                        .ascRemitosventa = New TablaRemitosVenta With {.idRemitosVenta = item("RemitosVenta_idRemitosVenta")}
                    })
            Next

            Return remitosVentaMonedas
        Else
            Return Nothing
        End If
    End Function
End Class
