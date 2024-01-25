Imports MySql.Data.MySqlClient

Public Class TransaccionesRemitoComMonedas
    Inherits Transacciones
    Implements ITransaccionesRemitoComMonedas


    Public Function elimRegistroPorIdRemitosCompra(id As Integer) As Integer Implements ITransaccionesRemitoComMonedas.elimRegistroPorIdRemitosCompra
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdRCM", id))

        Return ExecuteNonQuery("sigeva.elimRemCompraMonedas_IdRemCompra")
    End Function

    Public Function verRegistroPorIdRemitosCompra(id As Integer) As TablaRemitoComMonedas Implements ITransaccionesRemitoComMonedas.verRegistroPorIdRemitosCompra
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idRc", id))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verRemitoComMonedas_idRemitosCompra")

        If resultTable.Rows.Count > 0 Then
            Return New TablaRemitoComMonedas With {
                        .idRemitoComMonedas = resultTable.Rows(0).Item("idRemitoComMonedas"),
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

    Public Function verRegistros() As List(Of TablaRemitoComMonedas) Implements ITransaccionesGenericas(Of TablaRemitoComMonedas).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaRemitoComMonedas) As Integer Implements ITransaccionesGenericas(Of TablaRemitoComMonedas).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@rcmTic", param.TipoCambio))
        parametros.Add(New MySqlParameter("@rcmImN", param.ImporteNeto))
        parametros.Add(New MySqlParameter("@rcmDsc", param.DescuentoGral))
        parametros.Add(New MySqlParameter("@rcmBim", param.BaseImponible))
        parametros.Add(New MySqlParameter("@rcmIva", param.IVA))
        parametros.Add(New MySqlParameter("@rcmImT", param.ImporteTotal))
        parametros.Add(New MySqlParameter("@rcmElim", param.Eliminado))
        parametros.Add(New MySqlParameter("@rcmIdRc", param.ascRemitosCompra.idRemitosCompra))

        Return ExecuteNonQuery("sigeva.insRemitoComMonedas")
    End Function

    Public Function modRegistro(param As TablaRemitoComMonedas) As Integer Implements ITransaccionesGenericas(Of TablaRemitoComMonedas).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaRemitoComMonedas).elimRegistro
        Throw New NotImplementedException()
    End Function
End Class
