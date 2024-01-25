Imports MySql.Data.MySqlClient

Public Class TransaccionesStock
    Inherits Transacciones
    Implements ITransaccionesStock
    Public Function verUltimoId() As TablaStock Implements ITransaccionesStock.verUltimoId
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdStock")

        If resultTable.Rows.Count > 0 Then
            Return New TablaStock With {.idStock = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verStockFisico(idArt As Integer) As TablaStock Implements ITransaccionesStock.verStockFisico
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idArt", idArt))

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaStockFisico_idArticulos")

        If resultTable.Rows.Count > 0 Then
            Return New TablaStock With {.Cantidad = resultTable.Rows(0).Item("TotStock")}
        Else
            Return New TablaStock With {.Cantidad = 0}
        End If
    End Function

    Public Function verStockFisico(idArt As Integer, idDep As Integer) As TablaStock Implements ITransaccionesStock.verStockFisico
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idArt", idArt))
        parametros.Add(New MySqlParameter("@idDep", idDep))

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaStockFisico_idArticulos_idDeposito")

        If resultTable.Rows.Count > 0 Then
            Return New TablaStock With {.Cantidad = resultTable.Rows(0).Item("TotStock")}
        Else
            Return New TablaStock With {.Cantidad = 0}
        End If
    End Function

    Public Function verStockReservado(idArt As Integer) As TablaStock Implements ITransaccionesStock.verStockReservado
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idArt", idArt))

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaStockReservado_idArticulos")

        If resultTable.Rows.Count > 0 Then
            Return New TablaStock With {.Cantidad = resultTable.Rows(0).Item("TotStock")}
        Else
            Return New TablaStock With {.Cantidad = 0}
        End If
    End Function

    Public Function verStockPorIdArticulo(id As Integer) As List(Of TablaStock) Implements ITransaccionesStock.verStockPorIdArticulo
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idArt", id))

        Return listStock(ExecuteReader("sigeva.verStock_idArticulo"))
    End Function

    Public Function elimRegistroPorCampos(param As TablaStock) As Integer Implements ITransaccionesStock.elimRegistroPorCampos
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@stkFec", param.Fecha))
        parametros.Add(New MySqlParameter("@stkMov", param.Movimiento))
        parametros.Add(New MySqlParameter("@stkCan", param.Cantidad))
        parametros.Add(New MySqlParameter("@stkIdArt", param.ascArticulos.idArticulo))
        parametros.Add(New MySqlParameter("@stkIdDep", param.ascDepositos.idDeposito))

        Return ExecuteNonQuery("sigeva.elimStock_Fecha_Movimiento_Cantidad_idArticulo_idDeposito")
    End Function

    Public Function verRegistros() As List(Of TablaStock) Implements ITransaccionesGenericas(Of TablaStock).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaStock) As Integer Implements ITransaccionesGenericas(Of TablaStock).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@sFec", param.Fecha))
        parametros.Add(New MySqlParameter("@sMov", param.Movimiento))
        parametros.Add(New MySqlParameter("@sCan", param.Cantidad))
        parametros.Add(New MySqlParameter("@sEli", param.Eliminado))
        parametros.Add(New MySqlParameter("@sIdA", param.ascArticulos.idArticulo))
        parametros.Add(New MySqlParameter("@sIdD", param.ascDepositos.idDeposito))
        parametros.Add(New MySqlParameter("@sIdU", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.insStock")
    End Function

    Public Function modRegistro(param As TablaStock) As Integer Implements ITransaccionesGenericas(Of TablaStock).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idStk", param.idStock))
        parametros.Add(New MySqlParameter("@stkF", param.Fecha))
        parametros.Add(New MySqlParameter("@stkMov", param.Movimiento))
        parametros.Add(New MySqlParameter("@stkCan", param.Cantidad))
        parametros.Add(New MySqlParameter("@stkElim", param.Eliminado))
        parametros.Add(New MySqlParameter("@stkIdArt", param.ascArticulos.idArticulo))
        parametros.Add(New MySqlParameter("@stkIdDep", param.ascDepositos.idDeposito))
        parametros.Add(New MySqlParameter("@stkIdUs", param.ascUsuarios.idUsuario))

        Return ExecuteNonQuery("sigeva.modStock")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaStock).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@IdSTK", id))

        Return ExecuteNonQuery("sigeva.elimStock")
    End Function

    Private Function listStock(tabla As DataTable) As List(Of TablaStock)
        If tabla.Rows.Count > 0 Then
            Dim stock As New List(Of TablaStock)

            For Each item As DataRow In tabla.Rows
                stock.Add(New TablaStock With {
                    .idStock = item("idStock"),
                    .Fecha = item("Fecha"),
                    .Movimiento = item("Movimiento"),
                    .Cantidad = item("Cantidad"),
                    .ascArticulos = New TablaArticulos With {
                        .idArticulo = item("Articulos_idArticulos")
                    },
                    .ascDepositos = New TablaDepositos With {
                        .idDeposito = item("Depositos_idDepositos")
                    },
                    .ascUsuarios = New TablaUsuarios With {
                        .idUsuario = item("Usuarios_idUsuarios")
                    }
                })
            Next

            Return stock
        Else
            Return Nothing
        End If
    End Function
End Class
