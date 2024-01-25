Imports MySql.Data.MySqlClient

Public Class TransaccionesFacturaVentaMovimientos
    Inherits Transacciones
    Implements ITransaccionesFacturaVentaMovimientos

    Public Function verRegistros() As List(Of TablaFacturaVentaMovimientos) Implements ITransaccionesGenericas(Of TablaFacturaVentaMovimientos).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaFacturaVentaMovimientos) As Integer Implements ITransaccionesGenericas(Of TablaFacturaVentaMovimientos).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@fvmFec", param.Fecha))
        parametros.Add(New MySqlParameter("@fvmTip", param.Tipo))
        parametros.Add(New MySqlParameter("@fvmCan", param.Cantidad))
        parametros.Add(New MySqlParameter("@fvmEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@fvmIdU", param.ascUsuarios.idUsuario))
        parametros.Add(New MySqlParameter("@fvmIdF", param.ascFacturaVentaDetalle.idFacturaVentaDetalle))

        Return ExecuteNonQuery("sigeva.insFacturaVentaMovimientos")
    End Function

    Public Function modRegistro(param As TablaFacturaVentaMovimientos) As Integer Implements ITransaccionesGenericas(Of TablaFacturaVentaMovimientos).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaFacturaVentaMovimientos).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@fvmId", id))

        Return ExecuteNonQuery("sigeva.elimFacturaVentaMovimientos")
    End Function

    Public Function verUltimoId() As TablaFacturaVentaMovimientos Implements ITransaccionesFacturaVentaMovimientos.verUltimoId
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdFacturaVentaMovimientos")

        If resultTable.Rows.Count > 0 Then
            Return New TablaFacturaVentaMovimientos With {.idFacturaVentaMovimientos = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verCantidadFacturada(idDetFac As Integer) As TablaFacturaVentaMovimientos Implements ITransaccionesFacturaVentaMovimientos.verCantidadFacturada
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idDetFac", idDetFac))

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaFacturado_idFacturaVentaDetalle")

        If resultTable.Rows.Count > 0 Then
            Return New TablaFacturaVentaMovimientos With {.Cantidad = resultTable.Rows(0).Item("CantidadFacturada")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verCantidadAnulada(idDetFac As Integer) As TablaFacturaVentaMovimientos Implements ITransaccionesFacturaVentaMovimientos.verCantidadAnulada
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idDetFac", idDetFac))

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaAnulado_idFacturaVentaDetalle")

        If resultTable.Rows.Count > 0 Then
            Return New TablaFacturaVentaMovimientos With {.Cantidad = resultTable.Rows(0).Item("CantidadAnulada")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verCantidadRemitada(idDetFac As Integer) As TablaFacturaVentaMovimientos Implements ITransaccionesFacturaVentaMovimientos.verCantidadRemitada
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idDetFac", idDetFac))

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaRemitado_idFacturaVentaDetalle_FacturaVentaMovimientos")

        If resultTable.Rows.Count > 0 Then
            Return New TablaFacturaVentaMovimientos With {.Cantidad = resultTable.Rows(0).Item("CantidadRemitada")}
        Else
            Return Nothing
        End If
    End Function
End Class
