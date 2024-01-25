Imports MySql.Data.MySqlClient

Public Class TransaccionesProveedores
    Inherits Transacciones
    Implements ITransaccionesProveedores

    Public Function Recuperar(id As Integer) As Integer Implements ITransaccionesProveedores.Recuperar
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idP", id))

        Return ExecuteNonQuery("sigeva.recProveedor")
    End Function

    Public Function verExisteProveedorNombre(nombre As String) As String() Implements ITransaccionesProveedores.verExisteProveedorNombre
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@pNombre", nombre))

        Return ExisteProveedor(ExecuteReader("sigeva.verProveedor_Nombre"))
    End Function

    Public Function verExisteProveedorCuit(cuit As String) As String() Implements ITransaccionesProveedores.verExisteProveedorCuit
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@pCuit", cuit))

        Return ExisteProveedor(ExecuteReader("sigeva.verProveedor_CUIT"))
    End Function

    Public Function verExisteProveedorNombreCuit(nombre As String, cuit As String) As String() Implements ITransaccionesProveedores.verExisteProveedorNombreCuit
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@pNombre", nombre))
        parametros.Add(New MySqlParameter("@pCuit", cuit))

        Return ExisteProveedor(ExecuteReader("sigeva.verProveedor_Nombre_CUIT"))
    End Function

    Public Function verRegistros() As List(Of TablaProveedores) Implements ITransaccionesGenericas(Of TablaProveedores).verRegistros
        Return listProveedores(ExecuteReader("sigeva.verProveedores"))
    End Function

    Public Function insRegistro(param As TablaProveedores) As Integer Implements ITransaccionesGenericas(Of TablaProveedores).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@pFecha", param.FechaAlta))
        parametros.Add(New MySqlParameter("@pRazSoc", param.RazonSocial))
        parametros.Add(New MySqlParameter("@pDir", param.Direccion))
        parametros.Add(New MySqlParameter("@pLoc", param.Localidad))
        parametros.Add(New MySqlParameter("@pProv", param.Provincia))
        parametros.Add(New MySqlParameter("@pCP", param.CodPostal))
        parametros.Add(New MySqlParameter("@pPais", param.Pais))
        parametros.Add(New MySqlParameter("@pTE", param.Telefono))
        parametros.Add(New MySqlParameter("@pMail", param.Mail))
        parametros.Add(New MySqlParameter("@pWeb", param.Web))
        parametros.Add(New MySqlParameter("@pCuit", param.CUIT))
        parametros.Add(New MySqlParameter("@pIB", param.IIBB))
        parametros.Add(New MySqlParameter("@pSitIVA", param.SituacionIVA))
        parametros.Add(New MySqlParameter("@pEst", param.Estado))
        parametros.Add(New MySqlParameter("@pElim", param.Eliminado))
        parametros.Add(New MySqlParameter("@pIdUs", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.insProveedor")
    End Function

    Public Function modRegistro(param As TablaProveedores) As Integer Implements ITransaccionesGenericas(Of TablaProveedores).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idP", param.idProveedor))
        parametros.Add(New MySqlParameter("@pFec", param.FechaAlta))
        parametros.Add(New MySqlParameter("@pRS", param.RazonSocial))
        parametros.Add(New MySqlParameter("@pDir", param.Direccion))
        parametros.Add(New MySqlParameter("@pLoc", param.Localidad))
        parametros.Add(New MySqlParameter("@pProv", param.Provincia))
        parametros.Add(New MySqlParameter("@pCP", param.CodPostal))
        parametros.Add(New MySqlParameter("@pPais", param.Pais))
        parametros.Add(New MySqlParameter("@pTE", param.Telefono))
        parametros.Add(New MySqlParameter("@pMail", param.Mail))
        parametros.Add(New MySqlParameter("@pWeb", param.Web))
        parametros.Add(New MySqlParameter("@pCUIT", param.CUIT))
        parametros.Add(New MySqlParameter("@pIB", param.IIBB))
        parametros.Add(New MySqlParameter("@pSIva", param.SituacionIVA))

        Return ExecuteNonQuery("sigeva.modProveedor")
    End Function

    Public Function verRegistroPorID(id As Integer) As TablaProveedores Implements ITransaccionesProveedores.verRegistroPorID
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idProv", id))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verProveedor_idProveedor")

        If resultTable.Rows.Count > 0 Then
            Return New TablaProveedores With {
                    .idProveedor = resultTable.Rows(0).Item("idProveedores"),
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
                    .ascUsuarios = New TablaUsuarios With {.idUsuario = resultTable.Rows(0).Item("Usuarios_idUsuarios")}
                }
        Else
            Return Nothing
        End If
    End Function
    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaProveedores).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdP", id))

        Return ExecuteNonQuery("sigeva.elimProveedor")
    End Function

    Private Function listProveedores(tabla As DataTable) As List(Of TablaProveedores)
        If tabla.Rows.Count > 0 Then
            Dim prov As New List(Of TablaProveedores)

            For Each item As DataRow In tabla.Rows
                prov.Add(New TablaProveedores With {
                    .idProveedor = item("idProveedores"),
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
                    .Estado = item("Estado"),
                    .Eliminado = item("Eliminado"),
                    .ascUsuarios = New TablaUsuarios With {.idUsuario = item("Usuarios_idUsuarios")}
                })
            Next

            Return prov
        Else
            Return Nothing
        End If
    End Function

    Private Function ExisteProveedor(tabla As DataTable) As String()
        If tabla.Rows.Count > 0 Then
            If tabla.Rows(0).Item("Eliminado") = "NO" Then
                Return New String() {"Si-Act", ""}
            Else
                Return New String() {"Si-Elim", tabla.Rows(0).Item("idProveedores").ToString()}
            End If
        Else
            Return New String() {"No", ""}
        End If
    End Function
End Class
