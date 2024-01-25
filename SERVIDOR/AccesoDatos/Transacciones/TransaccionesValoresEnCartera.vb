Imports MySql.Data.MySqlClient

Public Class TransaccionesValoresEnCartera
    Inherits Transacciones
    Implements ITransaccionesValoresEnCartera

    Public Function verRegistros() As List(Of TablaValoresEnCartera) Implements ITransaccionesGenericas(Of TablaValoresEnCartera).verRegistros
        Return listValoresEnCartera(ExecuteReader("sigeva.verValoresEnCartera"))
    End Function

    Public Function insRegistro(param As TablaValoresEnCartera) As Integer Implements ITransaccionesGenericas(Of TablaValoresEnCartera).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@vecTip", param.TipoValor))
        parametros.Add(New MySqlParameter("@vecBan", param.Banco))
        parametros.Add(New MySqlParameter("@vecSuc", param.Sucursal))
        parametros.Add(New MySqlParameter("@vecNum", param.Numero))
        parametros.Add(New MySqlParameter("@vecLib", param.Librador))
        parametros.Add(New MySqlParameter("@vecFecC", param.FechaCobro))
        parametros.Add(New MySqlParameter("@vecMon", param.Moneda))
        parametros.Add(New MySqlParameter("@vecImp", param.Importe))
        parametros.Add(New MySqlParameter("@vecDisp", param.Disponible))
        parametros.Add(New MySqlParameter("@vecEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@vecIdUs", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.insValoresEnCartera")
    End Function

    Public Function modRegistro(param As TablaValoresEnCartera) As Integer Implements ITransaccionesGenericas(Of TablaValoresEnCartera).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@vecIdV", param.idValoresEnCartera))
        parametros.Add(New MySqlParameter("@vecTip", param.TipoValor))
        parametros.Add(New MySqlParameter("@vecBan", param.Banco))
        parametros.Add(New MySqlParameter("@vecSuc", param.Sucursal))
        parametros.Add(New MySqlParameter("@vecNum", param.Numero))
        parametros.Add(New MySqlParameter("@vecLib", param.Librador))
        parametros.Add(New MySqlParameter("@vecFecC", param.FechaCobro))
        parametros.Add(New MySqlParameter("@vecMon", param.Moneda))
        parametros.Add(New MySqlParameter("@vecImp", param.Importe))
        parametros.Add(New MySqlParameter("@vecDisp", param.Disponible))
        parametros.Add(New MySqlParameter("@vecEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@vecIdUs", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.modValoresEnCartera")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaValoresEnCartera).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdV", id))

        Return ExecuteNonQuery("sigeva.elimValoresEnCartera")
    End Function

    Public Function verListadoDisponible(Disponible As String) As List(Of TablaValoresEnCartera) Implements ITransaccionesValoresEnCartera.verListadoDisponible
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@vecDisp", Disponible))

        Return listValoresEnCartera(ExecuteReader("sigeva.verValoresEnCartera_Disponible"))
    End Function

    Public Function verSaldoPesos() As Double Implements ITransaccionesValoresEnCartera.verSaldoPesos
        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaValoresEnCartera_Pesos")

        If Not IsDBNull(resultTable.Rows(0).Item("Saldo")) Then
            Return resultTable.Rows(0).Item("Saldo")
        Else
            Return 0
        End If
    End Function

    Public Function verSaldoDolares() As Double Implements ITransaccionesValoresEnCartera.verSaldoDolares
        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaValoresEnCartera_Dolares")

        If Not IsDBNull(resultTable.Rows(0).Item("Saldo")) Then
            Return resultTable.Rows(0).Item("Saldo")
        Else
            Return 0
        End If
    End Function

    Public Function modDisponibilidad(id As Integer, disponible As String) As Integer Implements ITransaccionesValoresEnCartera.modDisponibilidad
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@vecIdV", id))
        parametros.Add(New MySqlParameter("@vecDisp", disponible))

        Return ExecuteNonQuery("sigeva.modValoresEnCartera_Disponible")
    End Function

    Public Function verUltimoId() As TablaValoresEnCartera Implements ITransaccionesValoresEnCartera.verUltimoId
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdValoresEnCartera")

        If resultTable.Rows.Count > 0 Then
            Return New TablaValoresEnCartera With {.idValoresEnCartera = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function

    Private Function listValoresEnCartera(tabla As DataTable) As List(Of TablaValoresEnCartera)
        If tabla.Rows.Count > 0 Then
            Dim valores As New List(Of TablaValoresEnCartera)

            For Each item As DataRow In tabla.Rows
                valores.Add(New TablaValoresEnCartera With {
                    .idValoresEnCartera = item("idValoresEnCartera"),
                    .TipoValor = item("TipoValor"),
                    .Banco = item("Banco"),
                    .Sucursal = item("Sucursal"),
                    .Numero = item("Numero"),
                    .Librador = item("Librador"),
                    .FechaCobro = item("FechaCobro"),
                    .Moneda = item("Moneda"),
                    .Importe = item("Importe"),
                    .Disponible = item("Disponible"),
                    .Eliminado = item("Eliminado"),
                    .ascUsuarios = New TablaUsuarios With {.idUsuario = item("Usuarios_idUsuarios")}
                })
            Next

            Return valores
        Else
            Return Nothing
        End If
    End Function
End Class
