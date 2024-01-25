Imports MySql.Data.MySqlClient

Public Class TransaccionesDetalleCheques
    Inherits Transacciones
    Implements ITransaccionesDetalleCheques

    Public Function elimChequePorIdChequera(id As Integer) As Integer Implements ITransaccionesDetalleCheques.elimChequePorIdChequera
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdChra", id))

        Return ExecuteNonQuery("sigeva.elimDetalleCheque_Chequera")
    End Function

    Public Function verDetalleChequePorChequera(id As Integer) As List(Of TablaDetalleCheque) Implements ITransaccionesDetalleCheques.verDetalleChequePorChequera
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idChra", id))

        Return listCheques(ExecuteReader("sigeva.verCheques_Por_Chequera"))
    End Function

    Public Function verRegistros() As List(Of TablaDetalleCheque) Implements ITransaccionesGenericas(Of TablaDetalleCheque).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaDetalleCheque) As Integer Implements ITransaccionesGenericas(Of TablaDetalleCheque).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@Nro", param.Numero))
        parametros.Add(New MySqlParameter("@Fem", param.FechaEmision))
        parametros.Add(New MySqlParameter("@Fcob", param.FechaCobro))
        parametros.Add(New MySqlParameter("@Pl", param.PlazoDias))
        parametros.Add(New MySqlParameter("@Imp", param.Importe))
        parametros.Add(New MySqlParameter("@Dest", param.Destino))
        parametros.Add(New MySqlParameter("@EnDisp", param.EnDisponiblidad))
        parametros.Add(New MySqlParameter("@Cob", param.Cobrado))
        parametros.Add(New MySqlParameter("@An", param.Anulado))
        parametros.Add(New MySqlParameter("@Mdf", param.Modificado))
        parametros.Add(New MySqlParameter("@Modif", param.Modificacion))
        parametros.Add(New MySqlParameter("@Obs", param.Observaciones))
        parametros.Add(New MySqlParameter("@Elim", param.Eliminado))
        parametros.Add(New MySqlParameter("@idChq", param.ascChequera.idChequera))
        parametros.Add(New MySqlParameter("@Us", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.insDetalleCheque")
    End Function

    Public Function modRegistro(param As TablaDetalleCheque) As Integer Implements ITransaccionesGenericas(Of TablaDetalleCheque).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idChq", param.idDetalleCheque))
        parametros.Add(New MySqlParameter("@Nro", param.Numero))
        parametros.Add(New MySqlParameter("@Fem", param.FechaEmision))
        parametros.Add(New MySqlParameter("@Fcob", param.FechaCobro))
        parametros.Add(New MySqlParameter("@Pl", param.PlazoDias))
        parametros.Add(New MySqlParameter("@Imp", param.Importe))
        parametros.Add(New MySqlParameter("@Dest", param.Destino))
        parametros.Add(New MySqlParameter("@EnDisp", param.EnDisponiblidad))
        parametros.Add(New MySqlParameter("@Cob", param.Cobrado))
        parametros.Add(New MySqlParameter("@An", param.Anulado))
        parametros.Add(New MySqlParameter("@Mdf", param.Modificado))
        parametros.Add(New MySqlParameter("@Modif", param.Modificacion))
        parametros.Add(New MySqlParameter("@Obs", param.Observaciones))
        parametros.Add(New MySqlParameter("@Elim", param.Eliminado))
        parametros.Add(New MySqlParameter("@idChra", param.ascChequera.idChequera))
        parametros.Add(New MySqlParameter("@Us", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.modDetalleCheque")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaDetalleCheque).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdCh", id))

        Return ExecuteNonQuery("sigeva.elimDetalleCheque")
    End Function

    Private Function listCheques(tabla As DataTable) As List(Of TablaDetalleCheque)
        If tabla.Rows.Count > 0 Then
            Dim cheques As New List(Of TablaDetalleCheque)

            For Each item As DataRow In tabla.Rows
                cheques.Add(New TablaDetalleCheque With {
                    .idDetalleCheque = item("idDetalleCheque"),
                    .Numero = item("Numero"),
                    .FechaEmision = item("FechaEmision"),
                    .FechaCobro = item("FechaCobro"),
                    .PlazoDias = item("PlazoDias"),
                    .Importe = item("Importe"),
                    .Destino = item("Destino"),
                    .EnDisponiblidad = item("EnDisponiblidad"),
                    .Cobrado = item("Cobrado"),
                    .Anulado = item("Anulado"),
                    .Modificado = item("Modificado"),
                    .Modificacion = item("Modificacion"),
                    .Observaciones = item("Observaciones"),
                    .Eliminado = item("Eliminado"),
                    .ascChequera = New TablaChequera With {.idChequera = item("Chequera_idChequera")},
                    .ascUsuarios = New TablaUsuarios With {.idUsuario = item("Usuarios_idUsuarios")}
                })
            Next

            Return cheques
        Else
            Return Nothing
        End If
    End Function
End Class
