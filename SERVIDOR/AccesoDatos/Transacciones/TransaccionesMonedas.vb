Imports MySql.Data.MySqlClient

Public Class TransaccionesMonedas
    Inherits Transacciones
    Implements ITransaccionesMonedas

    Public Function verRegistroPorNombre(nombre As String) As TablaMonedas Implements ITransaccionesMonedas.verRegistroPorNombre
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@mMoneda", nombre))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verMoneda_Moneda")

        If resultTable.Rows.Count > 0 Then
            Return New TablaMonedas With {
                        .idMonedas = resultTable.Rows(0).Item("idMonedas"),
                        .Tipo = resultTable.Rows(0).Item("Tipo"),
                        .Moneda = resultTable.Rows(0).Item("Moneda"),
                        .Simbolo = resultTable.Rows(0).Item("Simbolo")
                }
        Else
            Return Nothing
        End If
    End Function

    Public Function verRegistros() As List(Of TablaMonedas) Implements ITransaccionesGenericas(Of TablaMonedas).verRegistros
        Return listMonedas(ExecuteReader("sigeva.verMonedasActivas"))
    End Function

    Public Function insRegistro(param As TablaMonedas) As Integer Implements ITransaccionesGenericas(Of TablaMonedas).insRegistro
        Throw New NotImplementedException()
    End Function

    Public Function modRegistro(param As TablaMonedas) As Integer Implements ITransaccionesGenericas(Of TablaMonedas).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaMonedas).elimRegistro
        Throw New NotImplementedException()
    End Function

    Private Function listMonedas(tabla As DataTable) As List(Of TablaMonedas)
        If tabla.Rows.Count > 0 Then
            Dim monedas As New List(Of TablaMonedas)

            For Each item As DataRow In tabla.Rows
                monedas.Add(New TablaMonedas With {
                        .idMonedas = item("idMonedas"),
                        .Tipo = item("Tipo"),
                        .Moneda = item("Moneda"),
                        .Simbolo = item("Simbolo")
                    })
            Next

            Return monedas
        Else
            Return Nothing
        End If
    End Function

End Class
