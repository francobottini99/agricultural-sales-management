Imports MySql.Data.MySqlClient

Public Class TransaccionesParidadCambiaria
    Inherits Transacciones
    Implements ITransaccionesParidadCambiaria

    Public Function verRegistrosPorIdMonedas(id As Integer) As List(Of TablaParidadCambiaria) Implements ITransaccionesParidadCambiaria.verRegistrosPorIdMonedas
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idM", id))

        Return listParidadCambiaria(ExecuteReader("sigeva.verParidadCambiaria_idMoneda"))
    End Function

    Public Function verRegistros() As List(Of TablaParidadCambiaria) Implements ITransaccionesGenericas(Of TablaParidadCambiaria).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaParidadCambiaria) As Integer Implements ITransaccionesGenericas(Of TablaParidadCambiaria).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@pcFec", param.Fecha))
        parametros.Add(New MySqlParameter("@pcVC", param.CotizacionCompra))
        parametros.Add(New MySqlParameter("@pcVV", param.CotizacionVenta))
        parametros.Add(New MySqlParameter("@pcId", param.ascMonedas.idMonedas))

        Return ExecuteNonQuery("sigeva.insParidadCambiaria")
    End Function

    Public Function modRegistro(param As TablaParidadCambiaria) As Integer Implements ITransaccionesGenericas(Of TablaParidadCambiaria).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaParidadCambiaria).elimRegistro
        Throw New NotImplementedException()
    End Function

    Private Function listParidadCambiaria(tabla As DataTable) As List(Of TablaParidadCambiaria)
        If tabla.Rows.Count > 0 Then
            Dim paridadCambiaria As New List(Of TablaParidadCambiaria)

            For Each item As DataRow In tabla.Rows
                paridadCambiaria.Add(New TablaParidadCambiaria With {
                        .idParidadCambiaria = item("idParidadCambiaria"),
                        .Fecha = item("Fecha"),
                        .CotizacionCompra = item("CotizacionCompra"),
                        .CotizacionVenta = item("CotizacionVenta"),
                        .ascMonedas = New TablaMonedas With {.idMonedas = item("Monedas_idMonedas")}
                    })
            Next

            Return paridadCambiaria
        Else
            Return Nothing
        End If
    End Function
End Class
