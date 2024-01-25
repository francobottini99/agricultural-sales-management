Imports MySql.Data.MySqlClient

Public Class TransaccionesPedidoDetalle
    Inherits Transacciones
    Implements ITransaccionesPedidoDetalle

    Public Function modEstado(id As Integer, Remitado As String, Facturado As String) As Integer Implements ITransaccionesPedidoDetalle.modEstado
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@pdId", id))
        parametros.Add(New MySqlParameter("@pdRem", Remitado))
        parametros.Add(New MySqlParameter("@pdFac", Facturado))

        Return ExecuteNonQuery("sigeva.modPedidosDetalle_Estado")
    End Function

    Public Function modEstadoRemitado(id As Integer, Remitado As String) As Integer Implements ITransaccionesPedidoDetalle.modEstadoRemitado
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@pdId", id))
        parametros.Add(New MySqlParameter("@pdRem", Remitado))

        Return ExecuteNonQuery("sigeva.modPedidosDetalle_Remitado")
    End Function

    Public Function modEstadoFacturado(id As Integer, Facturado As String) As Integer Implements ITransaccionesPedidoDetalle.modEstadoFacturado
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@pdId", id))
        parametros.Add(New MySqlParameter("@pdFac", Facturado))

        Return ExecuteNonQuery("sigeva.modPedidosDetalle_Facturado")
    End Function

    Public Function elimRegistroPorIdPedido(id As Integer) As Integer Implements ITransaccionesPedidoDetalle.elimRegistroPorIdPedido
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idP", id))

        Return ExecuteNonQuery("sigeva.elimDetallePedido_idPedidos")
    End Function

    Public Function verUltimoId() As TablaPedidoDetalle Implements ITransaccionesPedidoDetalle.verUltimoId
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdPedidosDetalle")

        If resultTable.Rows.Count > 0 Then
            Return New TablaPedidoDetalle With {.idPedidosDetalle = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verRegistroPorId(id As Integer) As TablaPedidoDetalle Implements ITransaccionesPedidoDetalle.verRegistroPorId
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idPd", id))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verPedidosDetalle_idPedidosDetalle")

        If resultTable.Rows.Count > 0 Then
            Return New TablaPedidoDetalle With {
                    .idPedidosDetalle = resultTable.Rows(0).Item("idPedidosDetalle"),
                    .Cantidad = resultTable.Rows(0).Item("Cantidad"),
                    .Remitado = resultTable.Rows(0).Item("Remitado"),
                    .Facturado = resultTable.Rows(0).Item("Facturado"),
                    .ascArticulos = New TablaArticulos With {
                        .idArticulo = resultTable.Rows(0).Item("Articulos_idArticulos"),
                        .CodArticulo = resultTable.Rows(0).Item("CodArticulo"),
                        .Detalle = resultTable.Rows(0).Item("Detalle"),
                        .Unidad = resultTable.Rows(0).Item("Unidad")
                    },
                    .ascPedidos = New TablaPedidos With {.idPedidos = resultTable.Rows(0).Item("Pedidos_idPedidos")}
                }
        Else
            Return Nothing
        End If
    End Function

    Public Function verRegistrosPorIdPedido(id As Integer) As List(Of TablaPedidoDetalle) Implements ITransaccionesPedidoDetalle.verRegistrosPorIdPedido
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idP", id))

        Return listPedidoDetalle(ExecuteReader("sigeva.verPedidosDetalle_idPedidos"))
    End Function

    Public Function verRegistrosPorIdCliente(id As Integer) As List(Of TablaPedidoDetalle) Implements ITransaccionesPedidoDetalle.verRegistrosPorIdCliente
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idCli", id))

        Return listPedidoDetalle_Pedidos(ExecuteReader("sigeva.verPedidosDetalle_idCliente"))
    End Function

    Public Function verRegistroPorIdCliente_Remitado(id As Integer, remitado As String) As List(Of TablaPedidoDetalle) Implements ITransaccionesPedidoDetalle.verRegistroPorIdCliente_Remitado
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idCli", id))
        parametros.Add(New MySqlParameter("@remi", remitado))

        Return listPedidoDetalle_Pedidos(ExecuteReader("sigeva.verPedidosDetalle_idCliente_Remitado"))
    End Function

    Public Function verRegistroPorIdCliente_Facturado(id As Integer, facturado As String) As List(Of TablaPedidoDetalle) Implements ITransaccionesPedidoDetalle.verRegistroPorIdCliente_Facturado
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@idCli", id))
        parametros.Add(New MySqlParameter("@fac", facturado))

        Return listPedidoDetalle_Pedidos(ExecuteReader("sigeva.verPedidosDetalle_idCliente_Facturado"))
    End Function

    Public Function verRegistros() As List(Of TablaPedidoDetalle) Implements ITransaccionesGenericas(Of TablaPedidoDetalle).verRegistros
        Return listPedidoDetalle(ExecuteReader("sigeva.verPedidosDetalle"))
    End Function

    Public Function insRegistro(param As TablaPedidoDetalle) As Integer Implements ITransaccionesGenericas(Of TablaPedidoDetalle).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@dpCan", param.Cantidad))
        parametros.Add(New MySqlParameter("@dpRemi", param.Remitado))
        parametros.Add(New MySqlParameter("@dpFact", param.Facturado))
        parametros.Add(New MySqlParameter("@dpElim", param.Eliminado))
        parametros.Add(New MySqlParameter("@dpIdArt", param.ascArticulos.idArticulo))
        parametros.Add(New MySqlParameter("@dpIdPed", param.ascPedidos.idPedidos))

        Return ExecuteNonQuery("sigeva.insDetallePedido")
    End Function

    Public Function modRegistro(param As TablaPedidoDetalle) As Integer Implements ITransaccionesGenericas(Of TablaPedidoDetalle).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@dpId", param.idPedidosDetalle))
        parametros.Add(New MySqlParameter("@dpCan", param.Cantidad))
        parametros.Add(New MySqlParameter("@dpRemi", param.Remitado))
        parametros.Add(New MySqlParameter("@dpFact", param.Facturado))
        parametros.Add(New MySqlParameter("@dpElim", param.Eliminado))
        parametros.Add(New MySqlParameter("@dpIdArt", param.ascArticulos.idArticulo))
        parametros.Add(New MySqlParameter("@dpIdPed", param.ascPedidos.idPedidos))

        Return ExecuteNonQuery("sigeva.modDetPedido")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaPedidoDetalle).elimRegistro
        Throw New NotImplementedException()
    End Function

    Private Function listPedidoDetalle_Pedidos(tabla As DataTable) As List(Of TablaPedidoDetalle)
        If tabla.Rows.Count > 0 Then
            Dim pedidoDetalle As New List(Of TablaPedidoDetalle)

            For Each item As DataRow In tabla.Rows
                pedidoDetalle.Add(New TablaPedidoDetalle With {
                    .idPedidosDetalle = item("idPedidosDetalle"),
                    .Cantidad = item("Cantidad"),
                    .Remitado = item("Remitado"),
                    .Facturado = item("Facturado"),
                    .ascArticulos = New TablaArticulos With {
                        .idArticulo = item("Articulos_idArticulos"),
                        .CodArticulo = item("CodArticulo"),
                        .Detalle = item("Detalle")
                    },
                    .ascPedidos = New TablaPedidos With {
                        .idPedidos = item("Pedidos_idPedidos"),
                        .NroPedido = item("NroPedido"),
                        .Fecha = item("Fecha"),
                        .FechaCierrePedido = item("FechaCierrePedido"),
                        .Observaciones = item("Observaciones"),
                        .ascClientes = New TablaClientes With {
                            .idCliente = item("Clientes_idClientes")
                        },
                        .ascUsuarios = New TablaUsuarios With {
                            .idUsuario = item("Usuarios_idUsuarios")
                        }
                    }
                })
            Next

            Return pedidoDetalle
        Else
            Return Nothing
        End If
    End Function

    Private Function listPedidoDetalle(tabla As DataTable) As List(Of TablaPedidoDetalle)
        If tabla.Rows.Count > 0 Then
            Dim pedidoDetalle As New List(Of TablaPedidoDetalle)

            For Each item As DataRow In tabla.Rows
                pedidoDetalle.Add(New TablaPedidoDetalle With {
                    .idPedidosDetalle = item("idPedidosDetalle"),
                    .Cantidad = item("Cantidad"),
                    .Remitado = item("Remitado"),
                    .Facturado = item("Facturado"),
                    .ascArticulos = New TablaArticulos With {
                        .idArticulo = item("Articulos_idArticulos"),
                        .CodArticulo = item("CodArticulo"),
                        .Detalle = item("Detalle"),
                        .Unidad = item("Unidad")
                    },
                    .ascPedidos = New TablaPedidos With {
                        .idPedidos = item("Pedidos_idPedidos")
                    }
                })
            Next

            Return pedidoDetalle
        Else
            Return Nothing
        End If
    End Function

End Class
