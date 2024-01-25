Imports MySql.Data.MySqlClient

Public Class TransaccionesDatosSistema
    Inherits Transacciones
    Implements ITransaccionesDatosSistema

    Public Function verRegistro() As TablaDatosSistema Implements ITransaccionesDatosSistema.verRegistro
        Dim resultTable As DataTable = ExecuteReader("sigeva.verDatosSistema")

        If resultTable.Rows.Count > 0 Then
            Return New TablaDatosSistema With {
                    .idDatosSistema = resultTable.Rows(0).Item("idDatosSistema"),
                    .MonedaFacturacion = resultTable.Rows(0).Item("MonedaFacturacion"),
                    .MonedaContable = resultTable.Rows(0).Item("MonedaContable"),
                    .AlicuotaIva1 = resultTable.Rows(0).Item("AlicuotaIva1"),
                    .AlicuotaIva2 = resultTable.Rows(0).Item("AlicuotaIva2"),
                    .AlicuotaIva3 = resultTable.Rows(0).Item("AlicuotaIva3"),
                    .AlicuotaMargen = resultTable.Rows(0).Item("AlicuotaMargen"),
                    .AlicuotaDesc1 = resultTable.Rows(0).Item("AlicuotaDesc1"),
                    .AlicuotaDesc2 = resultTable.Rows(0).Item("AlicuotaDesc2"),
                    .ascUsuarios = New TablaUsuarios With {.idUsuario = resultTable.Rows(0).Item("Usuarios_idUsuarios")}
                }
        Else
            Return Nothing
        End If
    End Function

    Public Function verRegistros() As List(Of TablaDatosSistema) Implements ITransaccionesGenericas(Of TablaDatosSistema).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaDatosSistema) As Integer Implements ITransaccionesGenericas(Of TablaDatosSistema).insRegistro
        Throw New NotImplementedException()
    End Function

    Public Function modRegistro(param As TablaDatosSistema) As Integer Implements ITransaccionesGenericas(Of TablaDatosSistema).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaDatosSistema).elimRegistro
        Throw New NotImplementedException()
    End Function
End Class
