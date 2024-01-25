Imports MySql.Data.MySqlClient

Public Class TransaccionesMovimientoValores
    Inherits Transacciones
    Implements ITransaccionesMovimientoValores

    Public Function verRegistros() As List(Of TablaMovimientoValores) Implements ITransaccionesGenericas(Of TablaMovimientoValores).verRegistros
        Return listMovmientoValores(ExecuteReader("sigeva.verMovimientoValores"))
    End Function

    Public Function insRegistro(param As TablaMovimientoValores) As Integer Implements ITransaccionesGenericas(Of TablaMovimientoValores).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@mvFec", param.Fecha))
        parametros.Add(New MySqlParameter("@mvMov", param.Movimiento))
        parametros.Add(New MySqlParameter("@mvOrDe", param.OrigenDestino))
        parametros.Add(New MySqlParameter("@mvEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@mvIdVal", param.ascValoresEnCartera.idValoresEnCartera))
        parametros.Add(New MySqlParameter("@mvIdCaj", param.ascCaja.idCaja))

        Return ExecuteNonQuery("sigeva.insMovimientoValores")
    End Function

    Public Function modRegistro(param As TablaMovimientoValores) As Integer Implements ITransaccionesGenericas(Of TablaMovimientoValores).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@mvIdMoV", param.idMovimientoValores))
        parametros.Add(New MySqlParameter("@mvFec", param.Fecha))
        parametros.Add(New MySqlParameter("@mvMov", param.Movimiento))
        parametros.Add(New MySqlParameter("@mvOrDe", param.OrigenDestino))
        parametros.Add(New MySqlParameter("@mvEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@mvIdVal", param.ascValoresEnCartera.idValoresEnCartera))
        parametros.Add(New MySqlParameter("@mvIdCaj", param.ascCaja.idCaja))

        Return ExecuteNonQuery("sigeva.modMovimientoValores")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaMovimientoValores).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@mvIdMoV", id))

        Return ExecuteNonQuery("sigeva.elimMovimientoValores")
    End Function

    Public Function verRegistroPorIdCaja(idCaja As Integer) As TablaMovimientoValores Implements ITransaccionesMovimientoValores.verRegistroPorIdCaja
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@mvIdCaj", idCaja))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verMovimientoValores_idCaja")

        If resultTable.Rows.Count > 0 Then
            Return New TablaMovimientoValores With {
                .idMovimientoValores = resultTable.Rows(0).Item("idMovimientoValores"),
                .Fecha = resultTable.Rows(0).Item("Fecha"),
                .Movimiento = resultTable.Rows(0).Item("Movimiento"),
                .OrigenDestino = resultTable.Rows(0).Item("OrigenDestino"),
                .Eliminado = resultTable.Rows(0).Item("Eliminado"),
                .ascValoresEnCartera = New TablaValoresEnCartera With {.idValoresEnCartera = resultTable.Rows(0).Item("ValoresEnCartera_idValoresEnCartera")},
                .ascCaja = New TablaCaja With {.idCaja = resultTable.Rows(0).Item("Caja_idCaja")}
            }
        Else
            Return Nothing
        End If
    End Function

    Public Function verListadoPorIdValoresEnCartera(idValoresEnCartera As Integer) As List(Of TablaMovimientoValores) Implements ITransaccionesMovimientoValores.verListadoPorIdValoresEnCartera
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@mvIdVal", idValoresEnCartera))

        Return listMovmientoValores(ExecuteReader("sigeva.verMovimientoValores_idValoresEnCartera"))
    End Function

    Private Function listMovmientoValores(tabla As DataTable) As List(Of TablaMovimientoValores)
        If tabla.Rows.Count > 0 Then
            Dim movimientoValores As New List(Of TablaMovimientoValores)

            For Each item As DataRow In tabla.Rows
                movimientoValores.Add(New TablaMovimientoValores With {
                    .idMovimientoValores = item("idMovimientoValores"),
                    .Fecha = item("Fecha"),
                    .Movimiento = item("Movimiento"),
                    .OrigenDestino = item("OrigenDestino"),
                    .Eliminado = item("Eliminado"),
                    .ascValoresEnCartera = New TablaValoresEnCartera With {.idValoresEnCartera = item("ValoresEnCartera_idValoresEnCartera")},
                    .ascCaja = New TablaCaja With {.idCaja = item("Caja_idCaja")}
                })
            Next

            Return movimientoValores
        Else
            Return Nothing
        End If
    End Function
End Class
