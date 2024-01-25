Imports MySql.Data.MySqlClient

Public Class TransaccionesBancos
    Inherits Transacciones
    Implements ITransaccionesBancos

    Public Function verExisteBancoPorNombre(nombre As String) As Boolean Implements ITransaccionesBancos.verExisteBancoPorNombre
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@bNombre", nombre))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verBanco_Nombre")

        If resultTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function verRegistros() As List(Of TablaBancos) Implements ITransaccionesGenericas(Of TablaBancos).verRegistros
        Return listBancos(ExecuteReader("sigeva.verBancos"))
    End Function

    Public Function insRegistro(param As TablaBancos) As Integer Implements ITransaccionesGenericas(Of TablaBancos).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@bNombre", param.Nombre))
        parametros.Add(New MySqlParameter("@bElim", param.Eliminado))
        parametros.Add(New MySqlParameter("@bIdUs", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.insBanco")
    End Function

    Public Function modRegistro(param As TablaBancos) As Integer Implements ITransaccionesGenericas(Of TablaBancos).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idB", param.idBancos))
        parametros.Add(New MySqlParameter("@bNom", param.Nombre))
        parametros.Add(New MySqlParameter("@idU", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.modBancos")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaBancos).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdB", id))

        Return ExecuteNonQuery("sigeva.elimBanco")
    End Function

    Public Function verRegistroPorId(id As Integer) As TablaBancos Implements ITransaccionesBancos.verRegistroPorId
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@bId", id))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verBancos_idBanco")

        If resultTable.Rows.Count > 0 Then
            Return New TablaBancos With {
                    .idBancos = resultTable.Rows(0).Item("idBancos"),
                    .Nombre = resultTable.Rows(0).Item("Nombre"),
                    .Eliminado = resultTable.Rows(0).Item("Eliminado"),
                    .ascUsuarios = New TablaUsuarios With {.idUsuario = resultTable.Rows(0).Item("Usuarios_idUsuarios")}
            }
        Else
            Return Nothing
        End If
    End Function

    Private Function listBancos(tabla As DataTable) As List(Of TablaBancos)
        If tabla.Rows.Count > 0 Then
            Dim bancos As New List(Of TablaBancos)

            For Each item As DataRow In tabla.Rows
                bancos.Add(New TablaBancos With {
                    .idBancos = item("idBancos"),
                    .Nombre = item("Nombre"),
                    .Eliminado = item("Eliminado"),
                    .ascUsuarios = New TablaUsuarios With {.idUsuario = item("Usuarios_idUsuarios")}
                })
            Next

            Return bancos
        Else
            Return Nothing
        End If
    End Function
End Class
