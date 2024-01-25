Imports MySql.Data.MySqlClient

Public Class TransaccionesOrdenDePagoMonedas
    Inherits Transacciones
    Implements ITransaccionesOrdenDePagoMonedas

    Public Function verRegistroPorIdOrdenDePago(id As Integer) As List(Of TablaOrdenDePagoMonedas) Implements ITransaccionesOrdenDePagoMonedas.verRegistroPorIdOrdenDePago
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idOpm", id))

        Return listOrdenDePagoMonedas(ExecuteReader("sigeva.verOrdenDePagoMonedas_idOrdenDePago"))
    End Function

    Public Function elimRegistroPorIdOrdenDePago(id As Integer) As Integer Implements ITransaccionesOrdenDePagoMonedas.elimRegistroPorIdOrdenDePago
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdOp", id))

        Return ExecuteNonQuery("sigeva.elimOrdenDePagoMonedas_idOrdenDePago")
    End Function

    Public Function verRegistros() As List(Of TablaOrdenDePagoMonedas) Implements ITransaccionesGenericas(Of TablaOrdenDePagoMonedas).verRegistros
        Return listOrdenDePagoMonedas(ExecuteReader("sigeva.verOrdenPagoMonedas"))
    End Function

    Public Function insRegistro(param As TablaOrdenDePagoMonedas) As Integer Implements ITransaccionesGenericas(Of TablaOrdenDePagoMonedas).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@opmTpc", param.TipoCambio))
        parametros.Add(New MySqlParameter("@opmImN", param.ImporteNeto))
        parametros.Add(New MySqlParameter("@opmDes", param.DescuentoGral))
        parametros.Add(New MySqlParameter("@opmBas", param.BaseImponible))
        parametros.Add(New MySqlParameter("@opmIva", param.IVA))
        parametros.Add(New MySqlParameter("@opmImT", param.ImporteTotal))
        parametros.Add(New MySqlParameter("@opmEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@opmIdOp", param.ascOrdenDePago.idOrdenDePago))

        Return ExecuteNonQuery("sigeva.insOrdenDePagoMonedas")
    End Function

    Public Function modRegistro(param As TablaOrdenDePagoMonedas) As Integer Implements ITransaccionesGenericas(Of TablaOrdenDePagoMonedas).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@opmId", param.idOrdenDePagoMonedas))
        parametros.Add(New MySqlParameter("@opmTpc", param.TipoCambio))
        parametros.Add(New MySqlParameter("@opmImN", param.ImporteNeto))
        parametros.Add(New MySqlParameter("@opmDes", param.DescuentoGral))
        parametros.Add(New MySqlParameter("@opmBas", param.BaseImponible))
        parametros.Add(New MySqlParameter("@opmIva", param.IVA))
        parametros.Add(New MySqlParameter("@opmImT", param.ImporteTotal))
        parametros.Add(New MySqlParameter("@opmEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@opmIdOp", param.ascOrdenDePago.idOrdenDePago))

        Return ExecuteNonQuery("sigeva.modOrdenDePagoMonedas")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaOrdenDePagoMonedas).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdOpm", id))

        Return ExecuteNonQuery("sigeva.elimOrdenDePagoMonedas")
    End Function

    Private Function listOrdenDePagoMonedas(tabla As DataTable) As List(Of TablaOrdenDePagoMonedas)
        If tabla.Rows.Count > 0 Then
            Dim opm As New List(Of TablaOrdenDePagoMonedas)

            For Each item As DataRow In tabla.Rows
                opm.Add(New TablaOrdenDePagoMonedas With {
                    .idOrdenDePagoMonedas = item("idOrdenDePagoMonedas"),
                    .TipoCambio = item("TipoCambio"),
                    .ImporteNeto = item("ImporteNeto"),
                    .DescuentoGral = item("DescuentoGral"),
                    .BaseImponible = item("BaseImponible"),
                    .IVA = item("Iva"),
                    .ImporteTotal = item("ImporteTotal"),
                    .Eliminado = item("Eliminado"),
                    .ascOrdenDePago = New TablaOrdenDePago With {.idOrdenDePago = item("OrdenDePago_idOrdenDePago")}
                })
            Next

            Return opm
        Else
            Return Nothing
        End If
    End Function

End Class
