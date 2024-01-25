Imports MySql.Data.MySqlClient

Public Class TransaccionesRecibosVentaDetalle
    Inherits Transacciones
    Implements ITransaccionesRecibosVentaDetalle

    Public Function verRegistros() As List(Of TablaRecibosVentaDetalle) Implements ITransaccionesGenericas(Of TablaRecibosVentaDetalle).verRegistros
        Return listRecibosVentaDetalle(ExecuteReader("sigeva.verRecibosVentaDetalle"))
    End Function

    Public Function insRegistro(param As TablaRecibosVentaDetalle) As Integer Implements ITransaccionesGenericas(Of TablaRecibosVentaDetalle).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@rvdMed", param.MedioPago))
        parametros.Add(New MySqlParameter("@rvdNro", param.NroComprobante))
        parametros.Add(New MySqlParameter("@rvdBan", param.EntidadEmisora))
        parametros.Add(New MySqlParameter("@rvdSuc", param.SucursalEntidad))
        parametros.Add(New MySqlParameter("@rvdLib", param.Librador))
        parametros.Add(New MySqlParameter("@rvdCob", param.FechaCobro))
        parametros.Add(New MySqlParameter("@rvdMon", param.Moneda))
        parametros.Add(New MySqlParameter("@rvdImp", param.Importe))
        parametros.Add(New MySqlParameter("@rvdEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@rvdIdRv", param.ascRecibosVenta.idRecibosVenta))

        Return ExecuteNonQuery("sigeva.insRecibosVentaDetalle")
    End Function

    Public Function modRegistro(param As TablaRecibosVentaDetalle) As Integer Implements ITransaccionesGenericas(Of TablaRecibosVentaDetalle).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@rvdId", param.idRecibosVentaDetalle))
        parametros.Add(New MySqlParameter("@rvdMed", param.MedioPago))
        parametros.Add(New MySqlParameter("@rvdNro", param.NroComprobante))
        parametros.Add(New MySqlParameter("@rvdBan", param.EntidadEmisora))
        parametros.Add(New MySqlParameter("@rvdSuc", param.SucursalEntidad))
        parametros.Add(New MySqlParameter("@rvdLib", param.Librador))
        parametros.Add(New MySqlParameter("@rvdCob", param.FechaCobro))
        parametros.Add(New MySqlParameter("@rvdMon", param.Moneda))
        parametros.Add(New MySqlParameter("@rvdImp", param.Importe))
        parametros.Add(New MySqlParameter("@rvdEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@rvdIdRv", param.ascRecibosVenta.idRecibosVenta))

        Return ExecuteNonQuery("sigeva.modRecibosVentaDetalle")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaRecibosVentaDetalle).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@rvdId", id))

        Return ExecuteNonQuery("sigeva.elimRecibosVentaDetalle")
    End Function

    Private Function listRecibosVentaDetalle(tabla As DataTable) As List(Of TablaRecibosVentaDetalle)
        If tabla.Rows.Count > 0 Then
            Dim recibosVentaDetalle As New List(Of TablaRecibosVentaDetalle)

            For Each item As DataRow In tabla.Rows
                recibosVentaDetalle.Add(New TablaRecibosVentaDetalle With {
                    .idRecibosVentaDetalle = item("idRecibosVentaDetalle"),
                    .MedioPago = item("MedioPago"),
                    .NroComprobante = item("NroComprobante"),
                    .EntidadEmisora = item("EntidadEmisora"),
                    .SucursalEntidad = item("SucursalEntidad"),
                    .Librador = item("Librador"),
                    .FechaCobro = item("FechaCobro"),
                    .Moneda = item("Moneda"),
                    .Importe = item("Importe"),
                    .Eliminado = item("Eliminado"),
                    .ascRecibosVenta = New TablaRecibosVenta With {.idRecibosVenta = item("RecibosVenta_idRecibosVenta")}
                })
            Next

            Return recibosVentaDetalle
        Else
            Return Nothing
        End If
    End Function
End Class
