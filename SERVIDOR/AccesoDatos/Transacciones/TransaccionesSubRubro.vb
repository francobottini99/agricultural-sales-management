Imports MySql.Data.MySqlClient

Public Class TransaccionesSubRubro
    Inherits Transacciones
    Implements ITransaccionesSubRubro

    Public Function verExisteSubRubroPorAbrebiatura(abrebiatura As String) As Boolean Implements ITransaccionesSubRubro.verExisteSubRubroPorAbrebiatura
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@srAb", abrebiatura))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verSubRubro_Abrebiatura")

        If resultTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function verExisteSubRubroPorIdRubro(id As Integer) As Boolean Implements ITransaccionesSubRubro.verExisteSubRubroPorIdRubro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idR", id))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verSubRubro_idR")

        If resultTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function verExisteSubRubroPorNombre(nombre As String) As Boolean Implements ITransaccionesSubRubro.verExisteSubRubroPorNombre
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@srDes", nombre))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verSubRubro_Descripcion")

        If resultTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function verRegistros() As List(Of TablaSubRubro) Implements ITransaccionesGenericas(Of TablaSubRubro).verRegistros
        Return listSubRubro(ExecuteReader("sigeva.verSubRubros"))
    End Function

    Public Function insRegistro(param As TablaSubRubro) As Integer Implements ITransaccionesGenericas(Of TablaSubRubro).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@srAb", param.Abrebiatura))
        parametros.Add(New MySqlParameter("@srDes", param.Descripcion))
        parametros.Add(New MySqlParameter("@srIdR", param.ascRubro.idRubro))
        parametros.Add(New MySqlParameter("@srIdUs", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.insSubRubro")
    End Function

    Public Function modRegistro(param As TablaSubRubro) As Integer Implements ITransaccionesGenericas(Of TablaSubRubro).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idSR", param.idSubRubro))
        parametros.Add(New MySqlParameter("@rAb", param.Abrebiatura))
        parametros.Add(New MySqlParameter("@rDes", param.Descripcion))
        parametros.Add(New MySqlParameter("@idR", param.ascRubro.idRubro))
        parametros.Add(New MySqlParameter("@rIdUs", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.modSubRubro")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaSubRubro).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdSR", id))

        Return ExecuteNonQuery("sigeva.elimSubRubro")
    End Function

    Public Function verRegistroPorId(id As Integer) As TablaSubRubro Implements ITransaccionesSubRubro.verRegistroPorId
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@subrubId", id))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verSubRubro_idSubRubro")

        If resultTable.Rows.Count > 0 Then
            Return New TablaSubRubro With {
                .idSubRubro = resultTable.Rows(0).Item("idSubRubro"),
                .Abrebiatura = resultTable.Rows(0).Item("Abrebiatura"),
                .Descripcion = resultTable.Rows(0).Item("Descripcion"),
                .Eliminado = resultTable.Rows(0).Item("Eliminado"),
                .ascRubro = New TablaRubro With {.idRubro = resultTable.Rows(0).Item("Rubro_idRubro")},
                .ascUsuarios = New TablaUsuarios With {.idUsuario = resultTable.Rows(0).Item("Usuarios_idUsuarios")}
            }
        Else
            Return Nothing
        End If
    End Function

    Private Function listSubRubro(tabla As DataTable) As List(Of TablaSubRubro)
        If tabla.Rows.Count > 0 Then
            Dim subRubro As New List(Of TablaSubRubro)

            For Each item As DataRow In tabla.Rows
                subRubro.Add(New TablaSubRubro With {
                .idSubRubro = item("idSubRubro"),
                .Abrebiatura = item("Abrebiatura"),
                .Descripcion = item("Descripcion"),
                .Eliminado = item("Eliminado"),
                .ascRubro = New TablaRubro With {
                    .idRubro = item("Rubro_idRubro")
                },
                .ascUsuarios = New TablaUsuarios With {
                    .idUsuario = item("Usuarios_idUsuarios"),
                    .Nombre = item("Nombre")
                }
            })
            Next

            Return subRubro
        Else
            Return Nothing
        End If
    End Function
End Class
