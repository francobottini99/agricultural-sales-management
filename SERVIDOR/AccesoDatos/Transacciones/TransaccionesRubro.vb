Imports MySql.Data.MySqlClient

Public Class TransaccionesRubro
    Inherits Transacciones
    Implements ITransaccionesRubro

    Public Function verExisteRubroPorAbrebiatura(abrebiatura As String) As Boolean Implements ITransaccionesRubro.verExisteRubroPorAbrebiatura
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@rAb", abrebiatura))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verRubro_Abrebiatura")

        If resultTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function verExisteRubroPorNombre(nombre As String) As Boolean Implements ITransaccionesRubro.verExisteRubroPorNombre
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@rDes", nombre))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verRubro_Descripcion")

        If resultTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function verRegistros() As List(Of TablaRubro) Implements ITransaccionesGenericas(Of TablaRubro).verRegistros
        Return listRubro(ExecuteReader("sigeva.verRubros"))
    End Function

    Public Function insRegistro(param As TablaRubro) As Integer Implements ITransaccionesGenericas(Of TablaRubro).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@rAb", param.Abrebiatura))
        parametros.Add(New MySqlParameter("@rDes", param.Descripcion))
        parametros.Add(New MySqlParameter("@rIdUs", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.insRubro")
    End Function

    Public Function modRegistro(param As TablaRubro) As Integer Implements ITransaccionesGenericas(Of TablaRubro).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idR", param.idRubro))
        parametros.Add(New MySqlParameter("@rAb", param.Abrebiatura))
        parametros.Add(New MySqlParameter("@rDes", param.Descripcion))
        parametros.Add(New MySqlParameter("@rIdUs", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.modRubro")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaRubro).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdR", id))

        Return ExecuteNonQuery("sigeva.elimRubro")
    End Function

    Public Function verRegistroPorId(id As Integer) As TablaRubro Implements ITransaccionesRubro.verRegistroPorId
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@rId", id))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verRubro_idRubro")

        If resultTable.Rows.Count > 0 Then
            Return New TablaRubro With {
                    .idRubro = resultTable.Rows(0).Item("idRubro"),
                    .Abrebiatura = resultTable.Rows(0).Item("Abrebiatura"),
                    .Descripcion = resultTable.Rows(0).Item("Descripcion"),
                    .Eliminado = resultTable.Rows(0).Item("Eliminado"),
                    .ascUsuarios = New TablaUsuarios With {.idUsuario = resultTable.Rows(0).Item("Usuarios_idUsuarios")}
                   }
        Else
            Return Nothing
        End If
    End Function

    Private Function listRubro(tabla As DataTable) As List(Of TablaRubro)
        If tabla.Rows.Count > 0 Then
            Dim rubro As New List(Of TablaRubro)

            For Each item As DataRow In tabla.Rows
                rubro.Add(New TablaRubro With {
                    .idRubro = item("idRubro"),
                    .Abrebiatura = item("Abrebiatura"),
                    .Descripcion = item("Descripcion"),
                    .Eliminado = item("Eliminado"),
                    .ascUsuarios = New TablaUsuarios With {
                        .idUsuario = item("Usuarios_idUsuarios"),
                        .Nombre = item("Nombre")
                    }
                })
            Next

            Return rubro
        Else
            Return Nothing
        End If
    End Function

End Class
