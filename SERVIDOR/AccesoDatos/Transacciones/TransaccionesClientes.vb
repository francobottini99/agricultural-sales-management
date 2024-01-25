Imports MySql.Data.MySqlClient

Public Class TransaccionesClientes
    Inherits Transacciones
    Implements ITransaccionesClientes

    Public Function Recuperar(id As Integer) As Integer Implements ITransaccionesClientes.Recuperar
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idC", id))

        Return ExecuteNonQuery("sigeva.recCliente")
    End Function

    Public Function verExisteClienteNombre(nombre As String) As String() Implements ITransaccionesClientes.verExisteClienteNombre
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@cNombre", nombre))

        Return ExisteCliente(ExecuteReader("sigeva.verCliente_Nombre"))
    End Function

    Public Function verExisteClienteCuit(cuit As String) As String() Implements ITransaccionesClientes.verExisteClienteCuit
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@cCuit", cuit))

        Return ExisteCliente(ExecuteReader("sigeva.verCliente_CUIT"))
    End Function

    Public Function verExisteClienteNombreCuit(nombre As String, cuit As String) As String() Implements ITransaccionesClientes.verExisteClienteNombreCuit
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@cNombre", nombre))
        parametros.Add(New MySqlParameter("@cCuit", cuit))

        Return ExisteCliente(ExecuteReader("sigeva.verCliente_Nombre_CUIT"))
    End Function

    Public Function verRegistroPorID(id As Integer) As TablaClientes Implements ITransaccionesClientes.verRegistroPorID
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idCli", id))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verCliente_idCliente")

        If resultTable.Rows.Count > 0 Then
            Return New TablaClientes With {
                    .idCliente = resultTable.Rows(0).Item("idClientes"),
                    .FechaAlta = resultTable.Rows(0).Item("FechaAlta"),
                    .RazonSocial = resultTable.Rows(0).Item("RazonSocial"),
                    .Direccion = resultTable.Rows(0).Item("Direccion"),
                    .Localidad = resultTable.Rows(0).Item("Localidad"),
                    .Provincia = resultTable.Rows(0).Item("Provincia"),
                    .CodPostal = resultTable.Rows(0).Item("CP"),
                    .Pais = resultTable.Rows(0).Item("Pais"),
                    .Telefono = resultTable.Rows(0).Item("TE"),
                    .Mail = resultTable.Rows(0).Item("Mail"),
                    .Web = resultTable.Rows(0).Item("Web"),
                    .CUIT = resultTable.Rows(0).Item("CUIT"),
                    .IIBB = resultTable.Rows(0).Item("IIBB"),
                    .SituacionIVA = resultTable.Rows(0).Item("Web"),
                    .CreditoAsignado = resultTable.Rows(0).Item("CreditoAsignado"),
                    .CreditoConsumido = resultTable.Rows(0).Item("CreditoConsumido"),
                    .Clasificacion = resultTable.Rows(0).Item("Clasificacion"),
                    .ascUsuarios = New TablaUsuarios With {.idUsuario = resultTable.Rows(0).Item("Usuarios_idUsuarios")}
                }
        Else
            Return Nothing
        End If
    End Function

    Public Function verRegistros() As List(Of TablaClientes) Implements ITransaccionesGenericas(Of TablaClientes).verRegistros
        Return listClientes(ExecuteReader("sigeva.verClientes"))
    End Function

    Public Function insRegistro(param As TablaClientes) As Integer Implements ITransaccionesGenericas(Of TablaClientes).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@cFecha", param.FechaAlta))
        parametros.Add(New MySqlParameter("@cRazSoc", param.RazonSocial))
        parametros.Add(New MySqlParameter("@cDir", param.Direccion))
        parametros.Add(New MySqlParameter("@cLoc", param.Localidad))
        parametros.Add(New MySqlParameter("@cProv", param.Provincia))
        parametros.Add(New MySqlParameter("@cCP", param.CodPostal))
        parametros.Add(New MySqlParameter("@cPais", param.Pais))
        parametros.Add(New MySqlParameter("@cTE", param.Telefono))
        parametros.Add(New MySqlParameter("@cMail", param.Mail))
        parametros.Add(New MySqlParameter("@cWeb", param.Web))
        parametros.Add(New MySqlParameter("@cCuit", param.CUIT))
        parametros.Add(New MySqlParameter("@cIB", param.IIBB))
        parametros.Add(New MySqlParameter("@cSitIVA", param.SituacionIVA))
        parametros.Add(New MySqlParameter("@cCred", param.CreditoAsignado))
        parametros.Add(New MySqlParameter("@cCons", param.CreditoConsumido))
        parametros.Add(New MySqlParameter("@cEst", param.Estado))
        parametros.Add(New MySqlParameter("@cClas", param.Clasificacion))
        parametros.Add(New MySqlParameter("@cElim", param.Eliminado))
        parametros.Add(New MySqlParameter("@cIdUs", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.insCliente")
    End Function

    Public Function modRegistro(param As TablaClientes) As Integer Implements ITransaccionesGenericas(Of TablaClientes).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idC", param.idCliente))
        parametros.Add(New MySqlParameter("@cFec", param.FechaAlta))
        parametros.Add(New MySqlParameter("@cRS", param.RazonSocial))
        parametros.Add(New MySqlParameter("@cDir", param.Direccion))
        parametros.Add(New MySqlParameter("@cLoc", param.Localidad))
        parametros.Add(New MySqlParameter("@cProv", param.Provincia))
        parametros.Add(New MySqlParameter("@cCP", param.CodPostal))
        parametros.Add(New MySqlParameter("@cPais", param.Pais))
        parametros.Add(New MySqlParameter("@cTE", param.Telefono))
        parametros.Add(New MySqlParameter("@cMail", param.Mail))
        parametros.Add(New MySqlParameter("@cWeb", param.Web))
        parametros.Add(New MySqlParameter("@cCUIT", param.CUIT))
        parametros.Add(New MySqlParameter("@cIB", param.IIBB))
        parametros.Add(New MySqlParameter("@cSIva", param.SituacionIVA))
        parametros.Add(New MySqlParameter("@cCred", param.CreditoAsignado))
        parametros.Add(New MySqlParameter("@cClas", param.Clasificacion))

        Return ExecuteNonQuery("sigeva.modCliente")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaClientes).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdC", id))

        Return ExecuteNonQuery("sigeva.elimCliente")
    End Function

    Private Function listClientes(tabla As DataTable) As List(Of TablaClientes)
        If tabla.Rows.Count > 0 Then
            Dim cli As New List(Of TablaClientes)

            For Each item As DataRow In tabla.Rows
                cli.Add(New TablaClientes With {
                    .idCliente = item("idClientes"),
                    .FechaAlta = item("FechaAlta"),
                    .RazonSocial = item("RazonSocial"),
                    .Direccion = item("Direccion"),
                    .Localidad = item("Localidad"),
                    .Provincia = item("Provincia"),
                    .CodPostal = item("CP"),
                    .Pais = item("Pais"),
                    .Telefono = item("TE"),
                    .Mail = item("Mail"),
                    .Web = item("Web"),
                    .CUIT = item("CUIT"),
                    .IIBB = item("IIBB"),
                    .SituacionIVA = item("SituacionIVA"),
                    .CreditoAsignado = item("CreditoAsignado"),
                    .CreditoConsumido = item("CreditoConsumido"),
                    .Estado = item("Estado"),
                    .Clasificacion = item("Clasificacion"),
                    .Eliminado = item("Eliminado"),
                    .ascUsuarios = New TablaUsuarios With {.idUsuario = item("Usuarios_idUsuarios")}
                })
            Next

            Return cli
        Else
            Return Nothing
        End If
    End Function

    Private Function ExisteCliente(tabla As DataTable) As String()
        If tabla.Rows.Count > 0 Then
            If tabla.Rows(0).Item("Eliminado") = "NO" Then
                Return New String() {"Si-Act", ""}
            Else
                Return New String() {"Si-Elim", tabla.Rows(0).Item("idClientes").ToString()}
            End If
        Else
            Return New String() {"No", ""}
        End If
    End Function
End Class
