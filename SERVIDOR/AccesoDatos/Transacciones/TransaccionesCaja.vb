Imports MySql.Data.MySqlClient

Public Class TransaccionesCaja
    Inherits Transacciones
    Implements ITransaccionesCaja

    Public Function verRegistros() As List(Of TablaCaja) Implements ITransaccionesGenericas(Of TablaCaja).verRegistros
        Return listCaja(ExecuteReader("sigeva.verCaja"))
    End Function

    Public Function insRegistro(param As TablaCaja) As Integer Implements ITransaccionesGenericas(Of TablaCaja).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@cFec", param.Fecha))
        parametros.Add(New MySqlParameter("@cMov", param.Movimiento))
        parametros.Add(New MySqlParameter("@cCom", param.Comprobante))
        parametros.Add(New MySqlParameter("@cDet", param.Detalle))
        parametros.Add(New MySqlParameter("@cMon", param.Moneda))
        parametros.Add(New MySqlParameter("@cIng", param.Ingreso))
        parametros.Add(New MySqlParameter("@cEgr", param.Egreso))
        parametros.Add(New MySqlParameter("@cObs", param.Observaciones))
        parametros.Add(New MySqlParameter("@cEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@cIdUs", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.insCaja")
    End Function

    Public Function modRegistro(param As TablaCaja) As Integer Implements ITransaccionesGenericas(Of TablaCaja).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdC", param.idCaja))
        parametros.Add(New MySqlParameter("@cFec", param.Fecha))
        parametros.Add(New MySqlParameter("@cMov", param.Movimiento))
        parametros.Add(New MySqlParameter("@cCom", param.Comprobante))
        parametros.Add(New MySqlParameter("@cDet", param.Detalle))
        parametros.Add(New MySqlParameter("@cMon", param.Moneda))
        parametros.Add(New MySqlParameter("@cIng", param.Ingreso))
        parametros.Add(New MySqlParameter("@cEgr", param.Egreso))
        parametros.Add(New MySqlParameter("@cObs", param.Observaciones))
        parametros.Add(New MySqlParameter("@cEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@cIdUs", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.modCaja")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaCaja).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdC", id))

        Return ExecuteNonQuery("sigeva.elimCaja")
    End Function

    Public Function verRegistrosFechaDesdeHasta(fecDesde As Date, fecHasta As Date) As List(Of TablaCaja) Implements ITransaccionesCaja.verRegistrosFechaDesdeHasta
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@cFecD", fecDesde))
        parametros.Add(New MySqlParameter("@cFecH", fecHasta))

        Return listCaja(ExecuteReader("sigeva.verCaja_FecDesde_FecHasta"))
    End Function

    Public Function verMinFecha() As TablaCaja Implements ITransaccionesCaja.verMinFecha
        Dim resultTable As DataTable = ExecuteReader("sigeva.verCaja_MinFecha")

        If resultTable.Rows.Count > 0 Then
            Return New TablaCaja With {.Fecha = resultTable.Rows(0).Item("minFecha")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verMaxFecha() As TablaCaja Implements ITransaccionesCaja.verMaxFecha
        Dim resultTable As DataTable = ExecuteReader("sigeva.verCaja_MaxFecha")

        If resultTable.Rows.Count > 0 Then
            Return New TablaCaja With {.Fecha = resultTable.Rows(0).Item("maxFecha")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verSaldoPesos() As Double Implements ITransaccionesCaja.verSaldoPesos
        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaCaja_Pesos")

        If Not IsDBNull(resultTable.Rows(0).Item("Saldo")) Then
            Return resultTable.Rows(0).Item("Saldo")
        Else
            Return 0
        End If
    End Function

    Public Function verSaldoDolares() As Double Implements ITransaccionesCaja.verSaldoDolares
        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaCaja_Dolares")

        If Not IsDBNull(resultTable.Rows(0).Item("Saldo")) Then
            Return resultTable.Rows(0).Item("Saldo")
        Else
            Return 0
        End If
    End Function

    Public Function verUltimoId() As TablaCaja Implements ITransaccionesCaja.verUltimoId
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdCaja")

        If resultTable.Rows.Count > 0 Then
            Return New TablaCaja With {.idCaja = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function

    Private Function listCaja(tabla As DataTable) As List(Of TablaCaja)
        If tabla.Rows.Count > 0 Then
            Dim caja As New List(Of TablaCaja)

            For Each item As DataRow In tabla.Rows
                caja.Add(New TablaCaja With {
                    .idCaja = item("idCaja"),
                    .Fecha = item("Fecha"),
                    .Movimiento = item("Movimiento"),
                    .Comprobante = item("Comprobante"),
                    .Detalle = item("Detalle"),
                    .Moneda = item("Moneda"),
                    .Ingreso = item("Ingreso"),
                    .Egreso = item("Egreso"),
                    .Observaciones = item("Observaciones"),
                    .Eliminado = item("Eliminado"),
                    .ascUsuarios = New TablaUsuarios With {.idUsuario = item("Usuarios_idUsuarios")}
                })
            Next

            Return caja
        Else
            Return Nothing
        End If
    End Function
End Class
