Imports MySql.Data.MySqlClient

Public Class TransaccionesChequera
    Inherits Transacciones
    Implements ITransaccionesChequera

    Public Function verExisteChequeEnChequera(nro As Integer) As Boolean Implements ITransaccionesChequera.verExisteChequeEnChequera
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@nroChq", nro))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verChequera_NroChq")

        If resultTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function verUltimoID() As TablaChequera Implements ITransaccionesChequera.verUltimoID
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdChequera")

        If resultTable.Rows.Count > 0 Then
            Return New TablaChequera With {.idChequera = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verRegistros() As List(Of TablaChequera) Implements ITransaccionesGenericas(Of TablaChequera).verRegistros
        Return listChequeras(ExecuteReader("sigeva.verChequera"))
    End Function

    Public Function insRegistro(param As TablaChequera) As Integer Implements ITransaccionesGenericas(Of TablaChequera).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@NroCta", param.NroCuenta))
        parametros.Add(New MySqlParameter("@Fec", param.FechaAlta))
        parametros.Add(New MySqlParameter("@Bco", param.Banco))
        parametros.Add(New MySqlParameter("@NroCh", param.NroChqInicial))
        parametros.Add(New MySqlParameter("@CantCh", param.CantidadChq))
        parametros.Add(New MySqlParameter("@ChEm", param.ChqEmitidos))
        parametros.Add(New MySqlParameter("@ChAn", param.ChqAnulados))
        parametros.Add(New MySqlParameter("@ChDisp", param.ChqDisponibles))
        parametros.Add(New MySqlParameter("@Observ", param.Observaciones))
        parametros.Add(New MySqlParameter("@Elim", param.Eliminada))
        parametros.Add(New MySqlParameter("@Us", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.insChequera")
    End Function

    Public Function modRegistro(param As TablaChequera) As Integer Implements ITransaccionesGenericas(Of TablaChequera).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idChq", param.idChequera))
        parametros.Add(New MySqlParameter("@NroCta", param.NroCuenta))
        parametros.Add(New MySqlParameter("@Fec", param.FechaAlta))
        parametros.Add(New MySqlParameter("@Bco", param.Banco))
        parametros.Add(New MySqlParameter("@NroCh", param.NroChqInicial))
        parametros.Add(New MySqlParameter("@CantCh", param.CantidadChq))
        parametros.Add(New MySqlParameter("@ChEm", param.ChqEmitidos))
        parametros.Add(New MySqlParameter("@ChAn", param.ChqAnulados))
        parametros.Add(New MySqlParameter("@ChDisp", param.ChqDisponibles))
        parametros.Add(New MySqlParameter("@Observ", param.Observaciones))
        parametros.Add(New MySqlParameter("@Elim", param.Eliminada))
        parametros.Add(New MySqlParameter("@Us", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.modChequera")
    End Function

    Public Function verExisteChequera(cta As String, nro As Integer) As Boolean Implements ITransaccionesChequera.verExisteChequera
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@NroCta", cta))
        parametros.Add(New MySqlParameter("@NroCh", nro))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verChequera_Por_Cta_NroChInic")

        If resultTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function elimChequesdeChequera(nro As Integer) As Integer Implements ITransaccionesChequera.elimChequesdeChequera
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdChra", nro))

        Return ExecuteNonQuery("sigeva.elimDetalleCheque_Chequera")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaChequera).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdCh", id))

        Return ExecuteNonQuery("sigeva.elimChequera")
    End Function

    Public Function verListadoSinCompletar() As List(Of TablaChequera) Implements ITransaccionesChequera.verListadoSinCompletar
        Return listChequeras(ExecuteReader("sigeva.verChequera_ChqDisponibles"))
    End Function

    Public Function modChqEmitidos(id As Integer, Cant As Integer) As Integer Implements ITransaccionesChequera.modChqEmitidos
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@cId", id))
        parametros.Add(New MySqlParameter("@cCant", Cant))

        Return ExecuteNonQuery("sigeva.modChequera_ChqEmitidos")
    End Function

    Private Function listChequeras(tabla As DataTable) As List(Of TablaChequera)
        If tabla.Rows.Count > 0 Then
            Dim cheaquera As New List(Of TablaChequera)

            For Each item As DataRow In tabla.Rows
                cheaquera.Add(New TablaChequera With {
                    .idChequera = item("idChequera"),
                    .NroCuenta = item("NroCuenta"),
                    .FechaAlta = item("FechaAlta"),
                    .Banco = item("Banco"),
                    .NroChqInicial = item("NroChqInicial"),
                    .CantidadChq = item("CantidadChq"),
                    .ChqEmitidos = item("ChqEmitidos"),
                    .ChqAnulados = item("ChqAnulados"),
                    .ChqDisponibles = item("ChqDisponibles"),
                    .Observaciones = item("Observaciones"),
                    .Eliminada = item("Eliminada"),
                    .ascUsuarios = New TablaUsuarios With {.idUsuario = item("Usuarios_idUsuarios")}
                })
            Next

            Return cheaquera
        Else
            Return Nothing
        End If
    End Function

End Class
