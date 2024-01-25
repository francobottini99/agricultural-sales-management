Imports MySql.Data.MySqlClient

Public Class TransaccionesDeposito
    Inherits Transacciones
    Implements ITransaccionesDepositos

    Public Function verExisteDepositoPorNombre(nombre As String) As Boolean Implements ITransaccionesDepositos.verExisteDepositoPorNombre
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@dNombre", nombre))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verDeposito_Nombre")

        If resultTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function verRegistros() As List(Of TablaDepositos) Implements ITransaccionesGenericas(Of TablaDepositos).verRegistros
        Return listDepositos(ExecuteReader("sigeva.verDepositos"))
    End Function

    Public Function insRegistro(param As TablaDepositos) As Integer Implements ITransaccionesGenericas(Of TablaDepositos).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@dNombre", param.Nombre))
        parametros.Add(New MySqlParameter("@dDir", param.Direccion))
        parametros.Add(New MySqlParameter("@dLoc", param.Localidad))
        parametros.Add(New MySqlParameter("@dProv", param.Provincia))
        parametros.Add(New MySqlParameter("@dCP", param.CodPostal))
        parametros.Add(New MySqlParameter("@dElim", param.Eliminado))
        parametros.Add(New MySqlParameter("@dIdUs", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.insDeposito")
    End Function

    Public Function modRegistro(param As TablaDepositos) As Integer Implements ITransaccionesGenericas(Of TablaDepositos).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idD", param.idDeposito))
        parametros.Add(New MySqlParameter("@dNom", param.Nombre))
        parametros.Add(New MySqlParameter("@dDir", param.Direccion))
        parametros.Add(New MySqlParameter("@dLoc", param.Localidad))
        parametros.Add(New MySqlParameter("@dProv", param.Provincia))
        parametros.Add(New MySqlParameter("@dCP", param.CodPostal))
        parametros.Add(New MySqlParameter("@idU", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.modDeposito")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaDepositos).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdD", id))

        Return ExecuteNonQuery("sigeva.elimDeposito")
    End Function

    Public Function verRegistroPorId(id As Integer) As TablaDepositos Implements ITransaccionesDepositos.verRegistroPorId
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@dId", id))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verDeposito_idDeposito")

        If resultTable.Rows.Count > 0 Then
            Return New TablaDepositos With {
                        .idDeposito = resultTable.Rows(0).Item("idDepositos"),
                        .Nombre = resultTable.Rows(0).Item("Nombre"),
                        .Direccion = resultTable.Rows(0).Item("Direccion"),
                        .Localidad = resultTable.Rows(0).Item("Localidad"),
                        .Provincia = resultTable.Rows(0).Item("Provincia"),
                        .CodPostal = resultTable.Rows(0).Item("CP"),
                        .Eliminado = resultTable.Rows(0).Item("Eliminado"),
                        .ascUsuarios = New TablaUsuarios With {.idUsuario = resultTable.Rows(0).Item("Usuarios_idUsuarios")}
            }
        Else
            Return Nothing
        End If
    End Function

    Private Function listDepositos(tabla As DataTable) As List(Of TablaDepositos)
        If tabla.Rows.Count > 0 Then
            Dim deposito As New List(Of TablaDepositos)

            For Each item As DataRow In tabla.Rows
                deposito.Add(New TablaDepositos With {
                        .idDeposito = item("idDepositos"),
                        .Nombre = item("Nombre"),
                        .Direccion = item("Direccion"),
                        .Localidad = item("Localidad"),
                        .Provincia = item("Provincia"),
                        .CodPostal = item("CP"),
                        .Eliminado = item("Eliminado"),
                        .ascUsuarios = New TablaUsuarios With {.idUsuario = item("Usuarios_idUsuarios")}
                    })
            Next

            Return deposito
        Else
            Return Nothing
        End If
    End Function

End Class
