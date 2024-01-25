Imports MySql.Data.MySqlClient

Public Class TransaccionesPedidoMovimientos
    Inherits Transacciones
    Implements ITransaccionesPedidoMovimientos

    Public Function elimRegistroPorCampos(param As TablaPedidoMovimientos) As Integer Implements ITransaccionesPedidoMovimientos.elimRegistroPorCampos
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@pmMov", param.Tipo))
        parametros.Add(New MySqlParameter("@pmCan", param.Cantidad))
        parametros.Add(New MySqlParameter("@pmIdPedDet", param.ascPedidosDetalle.idPedidosDetalle))

        Return ExecuteNonQuery("sigeva.elimPedidoMoviminetos_Tipo_Cantidad_idPedidosDetalle")
    End Function

    Public Function verRegistrosPorIdPedidoDetalle(id As Integer) As List(Of TablaPedidoMovimientos) Implements ITransaccionesPedidoMovimientos.verRegistrosPorIdPedidoDetalle
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@pmIdPedDet", id))

        Return listPedidoMovimientos(ExecuteReader("sigeva.verPedidosMovimientos_idPedidosDetalle"))
    End Function

    Public Function verRegistrosPorIdPedidoDetalleTipo(id As Integer, tipo As String) As List(Of TablaPedidoMovimientos) Implements ITransaccionesPedidoMovimientos.verRegistrosPorIdPedidoDetalleTipo
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@pmId", id))
        parametros.Add(New MySqlParameter("@pmTip", tipo))

        Return listPedidoMovimientos(ExecuteReader("sigeva.verPedidosMovimientos_idPedidosDetalle_Tipo"))
    End Function

    Public Function elimRegistroPorIdPedidoDetalle(id As Integer) As Integer Implements ITransaccionesPedidoMovimientos.elimRegistroPorIdPedidoDetalle
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@dpId", id))

        Return ExecuteNonQuery("sigeva.elimPedidoMoviminetos_idPedidosDetalle")
    End Function

    Public Function verCantidadRetirada(idDetPed As Integer) As TablaPedidoMovimientos Implements ITransaccionesPedidoMovimientos.verCantidadRetirada
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idDetPed", idDetPed))

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaRetirado_idPedidosDetalle")

        If resultTable.Rows.Count > 0 Then
            Return New TablaPedidoMovimientos With {.Cantidad = resultTable.Rows(0).Item("CantidadRetirada")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verUltimoId() As TablaPedidoMovimientos Implements ITransaccionesPedidoMovimientos.verUltimoId
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdPedidosMovimientos")

        If resultTable.Rows.Count > 0 Then
            Return New TablaPedidoMovimientos With {.idPedidosMovimientos = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verCantidadReservada(idDetPed As Integer) As TablaPedidoMovimientos Implements ITransaccionesPedidoMovimientos.verCantidadReservada
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idDetPed", idDetPed))

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaReservado_idPedidosDetalle")

        If resultTable.Rows.Count > 0 Then
            Return New TablaPedidoMovimientos With {.Cantidad = resultTable.Rows(0).Item("CantidadReservada")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verCantidadFacturada(idDetPed As Integer) As TablaPedidoMovimientos Implements ITransaccionesPedidoMovimientos.verCantidadFacturada
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idDetPed", idDetPed))

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaFacturado_idPedidosDetalle_PedidosMovimientos")

        If resultTable.Rows.Count > 0 Then
            Return New TablaPedidoMovimientos With {.Cantidad = resultTable.Rows(0).Item("CantidadFacturada")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verCantidadRemitada(idDetPed As Integer) As TablaPedidoMovimientos Implements ITransaccionesPedidoMovimientos.verCantidadRemitada
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idDetPed", idDetPed))

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaRemitado_idPedidosDetalle_PedidosMovimientos")

        If resultTable.Rows.Count > 0 Then
            Return New TablaPedidoMovimientos With {.Cantidad = resultTable.Rows(0).Item("CantidadRemitada")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verCantidadAnulada(idDetPed As Integer) As TablaPedidoMovimientos Implements ITransaccionesPedidoMovimientos.verCantidadAnulada
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idDetPed", idDetPed))

        Dim resultTable As DataTable = ExecuteReader("sigeva.sumaAnulado_idPedidosDetalle")

        If resultTable.Rows.Count > 0 Then
            Return New TablaPedidoMovimientos With {.Cantidad = resultTable.Rows(0).Item("CantidadAnulada")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verRegistros() As List(Of TablaPedidoMovimientos) Implements ITransaccionesGenericas(Of TablaPedidoMovimientos).verRegistros
        Throw New NotImplementedException()
    End Function

    Public Function insRegistro(param As TablaPedidoMovimientos) As Integer Implements ITransaccionesGenericas(Of TablaPedidoMovimientos).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@dpFecha", param.Fecha))
        parametros.Add(New MySqlParameter("@dpTip", param.Tipo))
        parametros.Add(New MySqlParameter("@dpCant", param.Cantidad))
        parametros.Add(New MySqlParameter("@dpElim", param.Eliminado))
        parametros.Add(New MySqlParameter("@dpIdUs", param.ascUsuarios.idUsuario))
        parametros.Add(New MySqlParameter("@dpIdPed", param.ascPedidosDetalle.idPedidosDetalle))
        parametros.Add(New MySqlParameter("@dpIdStk", param.ascStock.idStock))

        Return ExecuteNonQuery("sigeva.insPedidoMovimientos")
    End Function

    Public Function modRegistro(param As TablaPedidoMovimientos) As Integer Implements ITransaccionesGenericas(Of TablaPedidoMovimientos).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@dpId", param.idPedidosMovimientos))
        parametros.Add(New MySqlParameter("@dpFecha", param.Fecha))
        parametros.Add(New MySqlParameter("@dpMov", param.Tipo))
        parametros.Add(New MySqlParameter("@dpCant", param.Cantidad))
        parametros.Add(New MySqlParameter("@dpElim", param.Eliminado))
        parametros.Add(New MySqlParameter("@dpIdUs", param.ascUsuarios.idUsuario))
        parametros.Add(New MySqlParameter("@dpIdPed", param.ascPedidosDetalle.idPedidosDetalle))
        parametros.Add(New MySqlParameter("@dpIdStk", param.ascStock.idStock))

        Return ExecuteNonQuery("sigeva.modPedidoMovimiento")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaPedidoMovimientos).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@pdId", id))

        Return ExecuteNonQuery("sigeva.elimPedidoMoviminetos")
    End Function

    Private Function listPedidoMovimientos(tabla As DataTable) As List(Of TablaPedidoMovimientos)
        If tabla.Rows.Count > 0 Then
            Dim pedidoMovimientos As New List(Of TablaPedidoMovimientos)

            For Each item As DataRow In tabla.Rows
                pedidoMovimientos.Add(New TablaPedidoMovimientos With {
                    .idPedidosMovimientos = item("idPedidosMovimientos"),
                    .Fecha = item("Fecha"),
                    .Tipo = item("Tipo"),
                    .Cantidad = item("Cantidad"),
                    .ascUsuarios = New TablaUsuarios With {
                        .idUsuario = item("Usuarios_idUsuarios")
                    },
                    .ascPedidosDetalle = New TablaPedidoDetalle With {
                        .idPedidosDetalle = item("PedidosDetalle_idPedidosDetalle")
                    },
                    .ascStock = New TablaStock With {
                        .idStock = item("Stock_idStock")
                    }
                })
            Next

            Return pedidoMovimientos
        Else
            Return Nothing
        End If
    End Function
End Class
