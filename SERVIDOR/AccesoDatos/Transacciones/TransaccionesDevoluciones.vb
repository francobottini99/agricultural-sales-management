Imports MySql.Data.MySqlClient

Public Class TransaccionesDevoluciones
    Inherits Transacciones
    Implements ITransaccionesDevoluciones

    Public Function verRegistros() As List(Of TablaDevoluciones) Implements ITransaccionesGenericas(Of TablaDevoluciones).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaDevoluciones) As Integer Implements ITransaccionesGenericas(Of TablaDevoluciones).insRegistro
        parametros = New List(Of MySqlParameter) From {
            New MySqlParameter("@dNroComp", param.NroComprobante),
            New MySqlParameter("@dFec", param.Fecha),
            New MySqlParameter("@dImp", param.Importe),
            New MySqlParameter("@dObs", param.Observaciones),
            New MySqlParameter("@dImpO", param.ImpOriginal),
            New MySqlParameter("@dImpC", param.ImpCopia),
            New MySqlParameter("@dElim", param.Eliminado),
            New MySqlParameter("@dIdCli", param.ascClientes.idCliente),
            New MySqlParameter("@dIdUs", param.ascUsuarios.idUsuario)
        }

        Return ExecuteNonQuery("sigeva.insDevoluciones")
    End Function

    Public Function modRegistro(param As TablaDevoluciones) As Integer Implements ITransaccionesGenericas(Of TablaDevoluciones).modRegistro
        Throw New NotImplementedException()
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaDevoluciones).elimRegistro
        Throw New NotImplementedException()
    End Function

    Public Function verUltimoId() As TablaDevoluciones Implements ITransaccionesDevoluciones.verUltimoId
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdDevoluciones")

        If resultTable.Rows.Count > 0 Then
            Return New TablaDevoluciones With {.idDevoluciones = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function
End Class
