Imports System.IO
Imports MySql.Data.MySqlClient

Public Class TransaccionesUsuarios
    Inherits Transacciones
    Implements ITransaccionesUsuarios

    Public Function verRegistroPorNombreYContraseña(nombre As String, contraseña As String) As TablaUsuarios Implements ITransaccionesUsuarios.verRegistroPorNombreYContraseña
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@uUsuario", nombre))
        parametros.Add(New MySqlParameter("@uContraseña", contraseña))

        Dim resultTable As DataTable = ExecuteReader("sigeva.consUncUsuario")

        If resultTable.Rows.Count > 0 Then
            Dim img As Byte() = resultTable.Rows(0).Item("Imagen")

            Return New TablaUsuarios With {
                    .idUsuario = resultTable.Rows(0).Item("idUsuarios"),
                    .FechaAlta = resultTable.Rows(0).Item("FechaAlta"),
                    .Tipo = resultTable.Rows(0).Item("Tipo"),
                    .Nombre = resultTable.Rows(0).Item("Nombre"),
                    .Imagen = Convert.ToBase64String(New MemoryStream(img).ToArray()),
                    .Estado = resultTable.Rows(0).Item("Estado"),
                    .Eliminado = resultTable.Rows(0).Item("Eliminado"),
                    .ascPerfilUs = New TablaPerfilUsuario With {
                        .IdPerfil = resultTable.Rows(0).Item("PerfilesUsuario_idPerfilesUsuario"),
                        .NombrePerfil = resultTable.Rows(0).Item("NombrePerfil")
                    }
                }
        Else
            Return Nothing
        End If
    End Function

    Public Function verExisteToken(token As String) As Boolean Implements ITransaccionesUsuarios.verExisteToken
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@uToken", token))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verUsuarios_Token")

        If resultTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function verExisteUsuarioPorIdPerfil(id As Integer) As Boolean Implements ITransaccionesUsuarios.verExisteUsuarioPorIdPerfil
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idP", id))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verUsuarios_idP")

        If resultTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function verExisteUsuarioPorNombre(nombre As String) As Boolean Implements ITransaccionesUsuarios.verExisteUsuarioPorNombre
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@uNombre", nombre))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verUsuario_Nombre")

        If resultTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function verRegistros() As List(Of TablaUsuarios) Implements ITransaccionesGenericas(Of TablaUsuarios).verRegistros
        Return listUsuarios(ExecuteReader("sigeva.verUsuariosActivos"))
    End Function

    Public Function insRegistro(param As TablaUsuarios) As Integer Implements ITransaccionesGenericas(Of TablaUsuarios).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@uFechaAlta", param.FechaAlta))
        parametros.Add(New MySqlParameter("@uTipo", param.Tipo))
        parametros.Add(New MySqlParameter("@uUsuario", param.Nombre))
        parametros.Add(New MySqlParameter("@uContraseña", param.Contraseña))
        parametros.Add(New MySqlParameter("@uImagen", New MemoryStream(Convert.FromBase64String(param.Imagen)).ToArray()))
        parametros.Add(New MySqlParameter("@uEstado", param.Estado))
        parametros.Add(New MySqlParameter("@uIdP", param.ascPerfilUs.IdPerfil))

        Return ExecuteNonQuery("sigeva.insUsuario")
    End Function

    Public Function modRegistro(param As TablaUsuarios) As Integer Implements ITransaccionesGenericas(Of TablaUsuarios).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idU", param.idUsuario))
        parametros.Add(New MySqlParameter("@uFechaAlta", param.FechaAlta))
        parametros.Add(New MySqlParameter("@uTipo", param.Tipo))
        parametros.Add(New MySqlParameter("@uUsuario", param.Nombre))
        parametros.Add(New MySqlParameter("@uContraseña", param.Contraseña))
        parametros.Add(New MySqlParameter("@uImagen", New MemoryStream(Convert.FromBase64String(param.Imagen)).ToArray()))
        parametros.Add(New MySqlParameter("@uEstado", param.Estado))
        parametros.Add(New MySqlParameter("@uIdP", param.ascPerfilUs.IdPerfil))

        Return ExecuteNonQuery("sigeva.modUsuario")
    End Function

    Public Function modRegistro_Token(id As Integer, token As String) As Integer Implements ITransaccionesUsuarios.modRegistro_Token
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idU", id))
        parametros.Add(New MySqlParameter("@uToken", token))

        Return ExecuteNonQuery("sigeva.modUsuario_Token")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaUsuarios).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idU", id))

        Return ExecuteNonQuery("sigeva.elimUsuario")
    End Function

    Public Function verRegistroPorId(id As Integer) As TablaUsuarios Implements ITransaccionesUsuarios.verRegistroPorId
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@uId", id))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verUsuarios_idUsuarios")

        If resultTable.Rows.Count > 0 Then
            Dim img As Byte() = resultTable.Rows(0).Item("Imagen")

            Return New TablaUsuarios With {
                    .idUsuario = resultTable.Rows(0).Item("idUsuarios"),
                    .FechaAlta = resultTable.Rows(0).Item("FechaAlta"),
                    .Tipo = resultTable.Rows(0).Item("Tipo"),
                    .Nombre = resultTable.Rows(0).Item("Nombre"),
                    .Contraseña = resultTable.Rows(0).Item("Contraseña"),
                    .Imagen = Convert.ToBase64String(New MemoryStream(img).ToArray()),
                    .Estado = resultTable.Rows(0).Item("Estado"),
                    .Eliminado = resultTable.Rows(0).Item("Eliminado"),
                    .ascPerfilUs = New TablaPerfilUsuario With {.IdPerfil = resultTable.Rows(0).Item("PerfilesUsuario_idPerfilesUsuario")}
            }
        Else
            Return Nothing
        End If
    End Function

    Private Function listUsuarios(tabla As DataTable) As List(Of TablaUsuarios)
        If tabla.Rows.Count > 0 Then
            Dim usuario As New List(Of TablaUsuarios)

            For Each item As DataRow In tabla.Rows
                Dim img As Byte() = item("Imagen")

                usuario.Add(New TablaUsuarios With {
                    .idUsuario = item("idUsuarios"),
                    .FechaAlta = item("FechaAlta"),
                    .Tipo = item("Tipo"),
                    .Nombre = item("Nombre"),
                    .Contraseña = item("Contraseña"),
                    .Imagen = Convert.ToBase64String(New MemoryStream(img).ToArray()),
                    .Estado = item("Estado"),
                    .Eliminado = item("Eliminado"),
                    .ascPerfilUs = New TablaPerfilUsuario With {
                        .IdPerfil = item("PerfilesUsuario_idPerfilesUsuario"),
                        .NombrePerfil = item("NombrePerfil")
                    }
                })
            Next

            Return usuario
        Else
            Return Nothing
        End If
    End Function
End Class
