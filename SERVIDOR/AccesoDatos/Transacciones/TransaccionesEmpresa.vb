Imports System.IO
Imports MySql.Data.MySqlClient

Public Class TransaccionesEmpresa
    Inherits Transacciones
    Implements ITransaccionesEmpresa

    Public Function verRegistro() As TablaEmpresa Implements ITransaccionesEmpresa.verRegistro
        Dim resultTable As DataTable = ExecuteReader("sigeva.verEmpresa")

        If resultTable.Rows.Count > 0 Then
            Dim img As Byte() = resultTable.Rows(0).Item("Logo")

            Return New TablaEmpresa With {
                .idEmpresa = resultTable.Rows(0).Item("idEmpresa"),
                .RazonSocial = resultTable.Rows(0).Item("RazonSocial"),
                .Direccion = resultTable.Rows(0).Item("Direccion"),
                .Localidad = resultTable.Rows(0).Item("Localidad"),
                .Provincia = resultTable.Rows(0).Item("Provincia"),
                .CodPostal = resultTable.Rows(0).Item("CP"),
                .Pais = resultTable.Rows(0).Item("Pais"),
                .TE = resultTable.Rows(0).Item("TE"),
                .Mail = resultTable.Rows(0).Item("Mail"),
                .CUIT = resultTable.Rows(0).Item("CUIT"),
                .IIBB = resultTable.Rows(0).Item("IIBB"),
                .InicioActividad = resultTable.Rows(0).Item("InicioActividad"),
                .PrefijoFacturacion = resultTable.Rows(0).Item("PrefijoFacturacion"),
                .Web = resultTable.Rows(0).Item("Web"),
                .CondicionIVA = resultTable.Rows(0).Item("CondicionIVA"),
                .Logo = Convert.ToBase64String(New MemoryStream(img).ToArray()),
                .ascUsuarios = New TablaUsuarios With {.idUsuario = resultTable.Rows(0).Item("Usuarios_idUsuarios")}
            }
        Else
            Return Nothing
        End If
    End Function

    Public Function verRegistros() As List(Of TablaEmpresa) Implements ITransaccionesGenericas(Of TablaEmpresa).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaEmpresa) As Integer Implements ITransaccionesGenericas(Of TablaEmpresa).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@RS", param.RazonSocial))
        parametros.Add(New MySqlParameter("@Dir", param.Direccion))
        parametros.Add(New MySqlParameter("@Loc", param.Localidad))
        parametros.Add(New MySqlParameter("@Prov", param.Provincia))
        parametros.Add(New MySqlParameter("@CP", param.CodPostal))
        parametros.Add(New MySqlParameter("@Pais", param.Pais))
        parametros.Add(New MySqlParameter("@TE", param.TE))
        parametros.Add(New MySqlParameter("@Mail", param.Mail))
        parametros.Add(New MySqlParameter("@Cuit", param.CUIT))
        parametros.Add(New MySqlParameter("@IB", param.IIBB))
        parametros.Add(New MySqlParameter("@InAct", param.InicioActividad))
        parametros.Add(New MySqlParameter("@PrefFac", param.PrefijoFacturacion))
        parametros.Add(New MySqlParameter("@Web", param.Web))
        parametros.Add(New MySqlParameter("@CondIva", param.CondicionIVA))
        parametros.Add(New MySqlParameter("@Logv", New MemoryStream(Convert.FromBase64String(param.Logo)).ToArray()))
        parametros.Add(New MySqlParameter("@Us", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.insEmpresa")
    End Function

    Public Function modRegistro(param As TablaEmpresa) As Integer Implements ITransaccionesGenericas(Of TablaEmpresa).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@ID", param.idEmpresa))
        parametros.Add(New MySqlParameter("@RS", param.RazonSocial))
        parametros.Add(New MySqlParameter("@Dir", param.Direccion))
        parametros.Add(New MySqlParameter("@Loc", param.Localidad))
        parametros.Add(New MySqlParameter("@Prov", param.Provincia))
        parametros.Add(New MySqlParameter("@CP", param.CodPostal))
        parametros.Add(New MySqlParameter("@Pais", param.Pais))
        parametros.Add(New MySqlParameter("@TE", param.TE))
        parametros.Add(New MySqlParameter("@Mail", param.Mail))
        parametros.Add(New MySqlParameter("@Cuit", param.CUIT))
        parametros.Add(New MySqlParameter("@IB", param.IIBB))
        parametros.Add(New MySqlParameter("@InAct", param.InicioActividad))
        parametros.Add(New MySqlParameter("@PrefFac", param.PrefijoFacturacion))
        parametros.Add(New MySqlParameter("@Web", param.Web))
        parametros.Add(New MySqlParameter("@CondIva", param.CondicionIVA))
        parametros.Add(New MySqlParameter("@Log", New MemoryStream(Convert.FromBase64String(param.Logo)).ToArray()))
        parametros.Add(New MySqlParameter("@Us", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.modEmpresa")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaEmpresa).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@id", id))

        Return ExecuteNonQuery("sigeva.eliEmpresa")
    End Function

    Private Function listEmpresa(tabla As DataTable) As List(Of TablaEmpresa)
        If tabla.Rows.Count > 0 Then
            Dim empresa As New List(Of TablaEmpresa)

            For Each item As DataRow In tabla.Rows
                Dim img As Byte() = item("Logo")

                empresa.Add(New TablaEmpresa With {
                    .idEmpresa = item("idEmpresa"),
                    .RazonSocial = item("RazonSocial"),
                    .Direccion = item("Direccion"),
                    .Localidad = item("Localidad"),
                    .Provincia = item("Provincia"),
                    .CodPostal = item("CP"),
                    .Pais = item("Pais"),
                    .TE = item("TE"),
                    .Mail = item("Mail"),
                    .CUIT = item("CUIT"),
                    .IIBB = item("IIBB"),
                    .InicioActividad = item("InicioActividad"),
                    .PrefijoFacturacion = item("PrefijoFacturacion"),
                    .Web = item("Web"),
                    .CondicionIVA = item("CondicionIVA"),
                    .Logo = Convert.ToBase64String(New MemoryStream(img).ToArray()),
                    .ascUsuarios = New TablaUsuarios With {.idUsuario = item("Usuarios_idUsuarios")}
                })
            Next

            Return empresa
        Else
            Return Nothing
        End If
    End Function
End Class
