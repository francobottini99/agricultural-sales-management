Imports MySql.Data.MySqlClient

Public Class TransaccionesComprobantes
    Inherits Transacciones
    Implements ITransaccionesComprobantes

    Public Function verRegistros() As List(Of TablaComprobantes) Implements ITransaccionesGenericas(Of TablaComprobantes).verRegistros
        Return listComprobantes(ExecuteReader("sigeva.verComprobantes"))
    End Function

    Public Function insRegistro(param As TablaComprobantes) As Integer Implements ITransaccionesGenericas(Of TablaComprobantes).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@cNombre", param.Nombre))
        parametros.Add(New MySqlParameter("@cCop", param.Copias))
        parametros.Add(New MySqlParameter("@cTip", param.Tipo))
        parametros.Add(New MySqlParameter("@cLey", param.Leyenda))
        parametros.Add(New MySqlParameter("@cEnc", param.Encabezado))
        parametros.Add(New MySqlParameter("@cLeyEn", param.LeyendaEnc))
        parametros.Add(New MySqlParameter("@cPie", param.Pie))
        parametros.Add(New MySqlParameter("@cLeyP", param.LeyendaPie))
        parametros.Add(New MySqlParameter("@cCantEm", param.CantidadCompEmitidos))
        parametros.Add(New MySqlParameter("@cCantCop", param.CantidadCopiasComp))
        parametros.Add(New MySqlParameter("@cElim", param.Eliminado))
        parametros.Add(New MySqlParameter("@dIdUs", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.insComprobante")
    End Function

    Public Function modRegistro(param As TablaComprobantes) As Integer Implements ITransaccionesGenericas(Of TablaComprobantes).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@ciD", param.idComprobantes))
        parametros.Add(New MySqlParameter("@cNombre", param.Nombre))
        parametros.Add(New MySqlParameter("@cCop", param.Copias))
        parametros.Add(New MySqlParameter("@cTip", param.Tipo))
        parametros.Add(New MySqlParameter("@cLey", param.Leyenda))
        parametros.Add(New MySqlParameter("@cEnc", param.Encabezado))
        parametros.Add(New MySqlParameter("@cLeyEn", param.LeyendaEnc))
        parametros.Add(New MySqlParameter("@cPie", param.Pie))
        parametros.Add(New MySqlParameter("@cLeyP", param.LeyendaPie))
        parametros.Add(New MySqlParameter("@cCantEm", param.CantidadCompEmitidos))
        parametros.Add(New MySqlParameter("@cCantCop", param.CantidadCopiasComp))
        parametros.Add(New MySqlParameter("@cElim", param.Eliminado))
        parametros.Add(New MySqlParameter("@dIdUs", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.modComprobante")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaComprobantes).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idC", id))

        Return ExecuteNonQuery("sigeva.elimComprobante")
    End Function

    Private Function listComprobantes(tabla As DataTable) As List(Of TablaComprobantes)
        If tabla.Rows.Count > 0 Then
            Dim comprobante As New List(Of TablaComprobantes)

            For Each item As DataRow In tabla.Rows
                comprobante.Add(New TablaComprobantes With {
                    .idComprobantes = item("idComprobantes"),
                    .Nombre = item("Nombre"),
                    .Copias = item("Copias"),
                    .Tipo = item("Tipo"),
                    .Leyenda = item("Leyenda"),
                    .Encabezado = item("Encabezado"),
                    .LeyendaEnc = item("LeyendaEnc"),
                    .Pie = item("Pie"),
                    .LeyendaPie = item("LeyendaPie"),
                    .CantidadCompEmitidos = item("CantidadCompEmitidos"),
                    .CantidadCopiasComp = item("CantidadCopiasComp"),
                    .Eliminado = item("Eliminado"),
                    .ascUsuarios = New TablaUsuarios With {.idUsuario = item("Usuarios_idUsuarios")}
                })
            Next

            Return comprobante
        Else
            Return Nothing
        End If
    End Function
End Class
