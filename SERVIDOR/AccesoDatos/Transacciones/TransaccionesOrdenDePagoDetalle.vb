Imports MySql.Data.MySqlClient

Public Class TransaccionesOrdenDePagoDetalle
    Inherits Transacciones
    Implements ITransaccionesOrdenDePagoDetalle

    Public Function verRegistros() As List(Of TablaOrdenDePagoDetalle) Implements ITransaccionesGenericas(Of TablaOrdenDePagoDetalle).verRegistros
        Return listOrdenDePagoDetalle(ExecuteReader("sigeva.verOrdenPagoDetalle"))
    End Function

    Public Function insRegistro(param As TablaOrdenDePagoDetalle) As Integer Implements ITransaccionesGenericas(Of TablaOrdenDePagoDetalle).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@opdMed", param.MedioPago))
        parametros.Add(New MySqlParameter("@opdNro", param.NroComprobante))
        parametros.Add(New MySqlParameter("@opdBan", param.EntidadEmisora))
        parametros.Add(New MySqlParameter("@opdSuc", param.SucursalEntidad))
        parametros.Add(New MySqlParameter("@opdLib", param.Librador))
        parametros.Add(New MySqlParameter("@opdCob", param.FechaCobro))
        parametros.Add(New MySqlParameter("@opdMon", param.Moneda))
        parametros.Add(New MySqlParameter("@opdImp", param.Importe))
        parametros.Add(New MySqlParameter("@opdEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@opdIdOp", param.ascOrdenDePago.idOrdenDePago))

        Return ExecuteNonQuery("sigeva.insOrdenPagoDetalle")
    End Function

    Public Function modRegistro(param As TablaOrdenDePagoDetalle) As Integer Implements ITransaccionesGenericas(Of TablaOrdenDePagoDetalle).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@opdId", param.idOrdenPagoDetalle))
        parametros.Add(New MySqlParameter("@opdMed", param.MedioPago))
        parametros.Add(New MySqlParameter("@opdNro", param.NroComprobante))
        parametros.Add(New MySqlParameter("@opdBan", param.EntidadEmisora))
        parametros.Add(New MySqlParameter("@opdSuc", param.SucursalEntidad))
        parametros.Add(New MySqlParameter("@opdLib", param.Librador))
        parametros.Add(New MySqlParameter("@opdCob", param.FechaCobro))
        parametros.Add(New MySqlParameter("@opdMon", param.Moneda))
        parametros.Add(New MySqlParameter("@opdImp", param.Importe))
        parametros.Add(New MySqlParameter("@opdEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@opdIdOp", param.ascOrdenDePago.idOrdenDePago))

        Return ExecuteNonQuery("sigeva.modOrdenPagoDetalle")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaOrdenDePagoDetalle).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@opdId", id))

        Return ExecuteNonQuery("sigeva.elimOrdenPagoDetalle")
    End Function

    Public Function elimRegistroPorIdOrdenDePago(id As Integer) As Integer Implements ITransaccionesOrdenDePagoDetalle.elimRegistroPorIdOrdenDePago
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdOp", id))

        Return ExecuteNonQuery("sigeva.elimOrdenDePagoDetalle_idOrdenDePago")
    End Function

    Private Function listOrdenDePagoDetalle(tabla As DataTable) As List(Of TablaOrdenDePagoDetalle)
        If tabla.Rows.Count > 0 Then
            Dim ordenesDePagoDetalle As New List(Of TablaOrdenDePagoDetalle)

            For Each item As DataRow In tabla.Rows
                ordenesDePagoDetalle.Add(New TablaOrdenDePagoDetalle With {
                    .idOrdenPagoDetalle = item("idOrdenPagoDetalle"),
                    .MedioPago = item("MedioPago"),
                    .NroComprobante = item("NroComprobante"),
                    .EntidadEmisora = item("EntidadEmisora"),
                    .SucursalEntidad = item("SucursalEntidad"),
                    .Librador = item("Librador"),
                    .FechaCobro = item("FechaCobro"),
                    .Moneda = item("Moneda"),
                    .Importe = item("Importe"),
                    .Eliminado = item("Eliminado"),
                    .ascOrdenDePago = New TablaOrdenDePago With {.idOrdenDePago = item("OrdenDePago_idOrdenDePago")}
                })
            Next

            Return ordenesDePagoDetalle
        Else
            Return Nothing
        End If
    End Function
End Class
