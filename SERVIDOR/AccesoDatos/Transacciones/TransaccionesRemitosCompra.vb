Imports MySql.Data.MySqlClient

Public Class TransaccionesRemitosCompra
    Inherits Transacciones
    Implements ITransaccionesRemitosCompra

    Public Function verUltimoId() As TablaRemitosCompra Implements ITransaccionesRemitosCompra.verUltimoId
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdRemitosCompra")

        If resultTable.Rows.Count > 0 Then
            Return New TablaRemitosCompra With {.idRemitosCompra = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verSinFacturar() As List(Of TablaRemitosCompra) Implements ITransaccionesRemitosCompra.verSinFacturar
        Return listRemitoCompra(ExecuteReader("sigeva.verRemitosCompra_Sin_Facturar"))
    End Function

    Public Function modEstadoFacturacion(id As Integer, estFac As String) As Integer Implements ITransaccionesRemitosCompra.modEstadoFacturacion
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@rcID", id))
        parametros.Add(New MySqlParameter("@rcFac", estFac))

        Return ExecuteNonQuery("sigeva.modRemitoCompra_Facturado")
    End Function

    Public Function verRegistroPorId(id As Integer) As TablaRemitosCompra Implements ITransaccionesRemitosCompra.verRegistroPorId
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idRc", id))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verRemitosCompra_idRemitosCompra")

        If resultTable.Rows.Count > 0 Then
            Return New TablaRemitosCompra With {
                .idRemitosCompra = resultTable.Rows(0).Item("idRemitosCompra"),
                .NroComprobante = resultTable.Rows(0).Item("NroComprobante"),
                .Fecha = resultTable.Rows(0).Item("Fecha"),
                .Importe = resultTable.Rows(0).Item("Importe"),
                .Observaciones = resultTable.Rows(0).Item("Observaciones"),
                .ImpOriginal = resultTable.Rows(0).Item("ImpOriginal"),
                .ImpCopia = resultTable.Rows(0).Item("ImpCopia"),
                .Facturado = resultTable.Rows(0).Item("Facturado"),
                .ascProveedores = New TablaProveedores With {
                    .idProveedor = resultTable.Rows(0).Item("Proveedores_idProveedores"),
                    .RazonSocial = resultTable.Rows(0).Item("RazonSocial")
                },
                .ascUsuarios = New TablaUsuarios With {.idUsuario = resultTable.Rows(0).Item("Usuarios_idUsuarios")}
            }
        Else
            Return Nothing
        End If
    End Function

    Public Function verRegistros() As List(Of TablaRemitosCompra) Implements ITransaccionesGenericas(Of TablaRemitosCompra).verRegistros
        Return listRemitoCompra(ExecuteReader("sigeva.verRemitosCompra"))
    End Function

    Public Function insRegistro(param As TablaRemitosCompra) As Integer Implements ITransaccionesGenericas(Of TablaRemitosCompra).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@rcNroComp", param.NroComprobante))
        parametros.Add(New MySqlParameter("@rcFec", param.Fecha))
        parametros.Add(New MySqlParameter("@rcImp", param.Importe))
        parametros.Add(New MySqlParameter("@rcObs", param.Observaciones))
        parametros.Add(New MySqlParameter("@rcImpO", param.ImpOriginal))
        parametros.Add(New MySqlParameter("@rcImpC", param.ImpCopia))
        parametros.Add(New MySqlParameter("@rcElim", param.Eliminado))
        parametros.Add(New MySqlParameter("@rcFac", param.Facturado))
        parametros.Add(New MySqlParameter("@rcIdProv", param.ascProveedores.idProveedor))
        parametros.Add(New MySqlParameter("@rcIdUs", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.insRemitoCompra")
    End Function

    Public Function modRegistro(param As TablaRemitosCompra) As Integer Implements ITransaccionesGenericas(Of TablaRemitosCompra).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@rcID", param.idRemitosCompra))
        parametros.Add(New MySqlParameter("@rcComp", param.NroComprobante))
        parametros.Add(New MySqlParameter("@rcFec", param.Fecha))
        parametros.Add(New MySqlParameter("@rcImp", param.Importe))
        parametros.Add(New MySqlParameter("@rcObs", param.Observaciones))
        parametros.Add(New MySqlParameter("@rcImOr", param.ImpOriginal))
        parametros.Add(New MySqlParameter("@rcImCop", param.ImpCopia))
        parametros.Add(New MySqlParameter("@rcElim", param.Eliminado))
        parametros.Add(New MySqlParameter("@rcFac", param.Facturado))
        parametros.Add(New MySqlParameter("@rcIdProv", param.ascProveedores.idProveedor))
        parametros.Add(New MySqlParameter("@rcIdUs", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.modRemitoCompra")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaRemitosCompra).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdRC", id))

        Return ExecuteNonQuery("sigeva.elimRemCompra")
    End Function

    Private Function listRemitoCompra(tabla As DataTable) As List(Of TablaRemitosCompra)
        If tabla.Rows.Count > 0 Then
            Dim remitosCompra As New List(Of TablaRemitosCompra)

            For Each item As DataRow In tabla.Rows
                remitosCompra.Add(New TablaRemitosCompra With {
                        .idRemitosCompra = item("idRemitosCompra"),
                        .NroComprobante = item("NroComprobante"),
                        .Fecha = item("Fecha"),
                        .Importe = item("Importe"),
                        .Observaciones = item("Observaciones"),
                        .ImpOriginal = item("ImpOriginal"),
                        .ImpCopia = item("ImpCopia"),
                        .Facturado = item("Facturado"),
                        .ascProveedores = New TablaProveedores With {
                            .idProveedor = item("idProveedores"),
                            .RazonSocial = item("RazonSocial"),
                            .Direccion = item("Direccion"),
                            .Localidad = item("Localidad"),
                            .Provincia = item("Provincia"),
                            .CodPostal = item("CP"),
                            .Telefono = item("TE"),
                            .Mail = item("Mail"),
                            .Web = item("Web"),
                            .CUIT = item("CUIT"),
                            .IIBB = item("IIBB"),
                            .Estado = item("Estado")
                        },
                        .ascUsuarios = New TablaUsuarios With {
                            .idUsuario = item("Usuarios_idUsuarios"),
                            .Nombre = item("Nombre")
                        }
                    })
            Next

            Return remitosCompra
        Else
            Return Nothing
        End If
    End Function
End Class
