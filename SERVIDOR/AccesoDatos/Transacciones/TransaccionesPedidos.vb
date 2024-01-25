Imports MySql.Data.MySqlClient

Public Class TransaccionesPedidos
    Inherits Transacciones
    Implements ITransaccionesPedidos

    Public Function modEstado(id As Integer, Remitado As String, Facturado As String) As Integer Implements ITransaccionesPedidos.modEstado
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@pdId", id))
        parametros.Add(New MySqlParameter("@pdRem", Remitado))
        parametros.Add(New MySqlParameter("@pdFac", Facturado))

        Return ExecuteNonQuery("sigeva.modPedido_Estado")
    End Function

    Public Function modEstadoRemitado(id As Integer, Remitado As String) As Integer Implements ITransaccionesPedidos.modEstadoRemitado
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@pId", id))
        parametros.Add(New MySqlParameter("@pRem", Remitado))

        Return ExecuteNonQuery("sigeva.modPedidos_Remitado")
    End Function

    Public Function modEstadoFacturado(id As Integer, Facturado As String) As Integer Implements ITransaccionesPedidos.modEstadoFacturado
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@pId", id))
        parametros.Add(New MySqlParameter("@pFac", Facturado))

        Return ExecuteNonQuery("sigeva.modPedidos_Facturado")
    End Function

    Public Function modFechaCierrePedido(id As Integer, fec As Date) As Integer Implements ITransaccionesPedidos.modFechaCierrePedido
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@pdId", id))
        parametros.Add(New MySqlParameter("@pdFecCierre", fec))

        Return ExecuteNonQuery("sigeva.modPedido_FechaCierrePedido")
    End Function

    Public Function verUltimoId() As TablaPedidos Implements ITransaccionesPedidos.verUltimoId
        Dim resultTable As DataTable = ExecuteReader("sigeva.verMaxIdPedidos")

        If resultTable.Rows.Count > 0 Then
            Return New TablaPedidos With {.idPedidos = resultTable.Rows(0).Item("UltimoId")}
        Else
            Return Nothing
        End If
    End Function

    Public Function verRegistros() As List(Of TablaPedidos) Implements ITransaccionesGenericas(Of TablaPedidos).verRegistros
        Return listPedidos(ExecuteReader("sigeva.verPedidos"))
    End Function

    Public Function verRegistrosRemitado(remitado As String) As List(Of TablaPedidos) Implements ITransaccionesPedidos.verRegistrosRemitado
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@pRem", remitado))

        Return listPedidos(ExecuteReader("sigeva.verPedidos_Remitado"))
    End Function

    Public Function verRegistrosFacturadoRemitado(facturado As String, remitado As String) As List(Of TablaPedidos) Implements ITransaccionesPedidos.verRegistrosFacturadoRemitado
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@pFac", facturado))
        parametros.Add(New MySqlParameter("@pRem", remitado))

        Return listPedidos(ExecuteReader("sigeva.verPedidos_Facturado_Remitado"))
    End Function

    Public Function insRegistro(param As TablaPedidos) As Integer Implements ITransaccionesGenericas(Of TablaPedidos).insRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@pdNro", param.NroPedido))
        parametros.Add(New MySqlParameter("@pdFecha", param.Fecha))
        parametros.Add(New MySqlParameter("@pdFecCierr", param.FechaCierrePedido))
        parametros.Add(New MySqlParameter("@pdRemi", param.Remitado))
        parametros.Add(New MySqlParameter("@pdFact", param.Facturado))
        parametros.Add(New MySqlParameter("@pdObs", param.Observaciones))
        parametros.Add(New MySqlParameter("@pdElim", param.Eliminado))
        parametros.Add(New MySqlParameter("@pdIdUs", param.ascUsuarios.idUsuario))
        parametros.Add(New MySqlParameter("@pdIdCli", param.ascClientes.idCliente))

        Return ExecuteNonQuery("sigeva.insPedido")
    End Function

    Public Function modRegistro(param As TablaPedidos) As Integer Implements ITransaccionesGenericas(Of TablaPedidos).modRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@pdId", param.idPedidos))
        parametros.Add(New MySqlParameter("@pdNro", param.NroPedido))
        parametros.Add(New MySqlParameter("@pdFec", param.Fecha))
        parametros.Add(New MySqlParameter("@pdFecCierre", param.FechaCierrePedido))
        parametros.Add(New MySqlParameter("@pdRemi", param.Remitado))
        parametros.Add(New MySqlParameter("@pdFact", param.Facturado))
        parametros.Add(New MySqlParameter("@pdObs", param.Observaciones))
        parametros.Add(New MySqlParameter("@pdElim", param.Eliminado))
        parametros.Add(New MySqlParameter("@pdIsUs", param.ascUsuarios.idUsuario))
        parametros.Add(New MySqlParameter("@pdIdCli", param.ascClientes.idCliente))

        Return ExecuteNonQuery("sigeva.modPedido")
    End Function

    Public Function elimRegistro(id As Integer) As Integer Implements ITransaccionesGenericas(Of TablaPedidos).elimRegistro
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@pdId", id))

        Return ExecuteNonQuery("sigeva.elimPedido")
    End Function

    Public Function verPedidosPorIDpedido(id As Integer) As TablaPedidos Implements ITransaccionesPedidos.verPedidosPorIDpedido
        parametros = New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("@id", id))

        Dim resultTable As DataTable = ExecuteReader("sigeva.verPedidos_idPedidos")

        If resultTable.Rows.Count > 0 Then
            Return New TablaPedidos With {
                .idPedidos = resultTable.Rows(0).Item("idPedidos"),
                .NroPedido = resultTable.Rows(0).Item("NroPedido"),
                .Fecha = resultTable.Rows(0).Item("Fecha"),
                .FechaCierrePedido = resultTable.Rows(0).Item("FechaCierrePedido"),
                .Remitado = resultTable.Rows(0).Item("Remitado"),
                .Facturado = resultTable.Rows(0).Item("Facturado"),
                .Observaciones = resultTable.Rows(0).Item("Observaciones"),
                .Eliminado = resultTable.Rows(0).Item("Eliminado"),
                .ascClientes = New TablaClientes With {.idCliente = resultTable.Rows(0).Item("Clientes_idClientes")},
                .ascUsuarios = New TablaUsuarios With {.idUsuario = resultTable.Rows(0).Item("Usuarios_idUsuarios")}
            }
        Else
            Return Nothing
        End If
    End Function

    Private Function listPedidos(tabla As DataTable) As List(Of TablaPedidos)
        If tabla.Rows.Count > 0 Then
            Dim pedidos As New List(Of TablaPedidos)

            For Each item As DataRow In tabla.Rows
                pedidos.Add(New TablaPedidos With {
                    .idPedidos = item("idPedidos"),
                    .NroPedido = item("NroPedido"),
                    .Fecha = item("Fecha"),
                    .FechaCierrePedido = item("FechaCierrePedido"),
                    .Remitado = item("Remitado"),
                    .Facturado = item("Facturado"),
                    .Observaciones = item("Observaciones"),
                    .ascClientes = New TablaClientes With {
                        .idCliente = item("Clientes_idClientes"),
                        .RazonSocial = item("RazonSocial")
                    },
                    .ascUsuarios = New TablaUsuarios With {
                        .idUsuario = item("Usuarios_idUsuarios")
                    }
                })
            Next

            Return pedidos
        Else
            Return Nothing
        End If
    End Function
End Class
