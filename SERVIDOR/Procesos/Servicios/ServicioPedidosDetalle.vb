Imports AccesoDatos

Public Class ServicioPedidosDetalle
    Inherits EnlaceTransacciones(Of Transacciones)

    Private _DetallePedido As ModeloPedidoDetalle


#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New Transacciones(), "SERVICIO")

        DetallePedido = New ModeloPedidoDetalle()
    End Sub

    Public Sub New(detallePedido As ModeloPedidoDetalle)
        MyBase.New(New Transacciones(), "SERVICIO")

        Me.DetallePedido = detallePedido
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property DetallePedido As ModeloPedidoDetalle
        Get
            Return _DetallePedido
        End Get
        Set(value As ModeloPedidoDetalle)
            _DetallePedido = value
        End Set
    End Property
#End Region

    Public Function ListadoSinRemitar_Cliente() As RespuestaHTTP(Of List(Of ModeloPedidoDetalle))
        DetallePedido.Remitado = "NO"

        Dim listaPedidos As List(Of ModeloPedidoDetalle) = DetallePedido.ListadoFiltradoPorIdClienteYRemitado()

        If Not IsNothing(listaPedidos) Then
            For i As Integer = listaPedidos.Count - 1 To 0 Step -1
                Dim movFacRes As New ModeloMovimientos_Factura_Reserva With {.AscPedidoMovimientos = New ModeloPedidoMovimientos With {.AscPedidosDetalle = New ModeloPedidoDetalle With {.IdPedidosDetalle = listaPedidos(i).IdPedidosDetalle}}}
                Dim movResRem As New ModeloMovimientos_Reserva_Remito With {.AscPedidosMovimientos = New ModeloPedidoMovimientos With {.AscPedidosDetalle = New ModeloPedidoDetalle With {.IdPedidosDetalle = listaPedidos(i).IdPedidosDetalle}}}

                Dim pedCanFac As Double = movFacRes.CantidadFacturada()

                If Not IsNothing(pedCanFac) Then
                    listaPedidos(i).Cantidad -= pedCanFac

                    Dim pedCanRem As Double = movResRem.CantidadRemitada()

                    If Not IsNothing(pedCanRem) Then
                        listaPedidos(i).Cantidad -= pedCanRem

                        If listaPedidos(i).Cantidad < 1 Then
                            listaPedidos.Remove(listaPedidos(i))
                        End If
                    Else
                        Return New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(Nothing, movResRem.Err)
                    End If
                Else
                    Return New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(Nothing, movFacRes.Err)
                End If
            Next

            Return New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(listaPedidos, Nothing)
        Else
            Return New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(Nothing, DetallePedido.Err)
        End If
    End Function

    Public Function ListadoSinFacturar_Cliente() As RespuestaHTTP(Of List(Of ModeloPedidoDetalle))
        DetallePedido.Facturado = "NO"

        Dim listaPedidos As List(Of ModeloPedidoDetalle) = DetallePedido.ListadoFiltradoPorIdClienteYFacturado()

        If Not IsNothing(listaPedidos) Then
            For i As Integer = listaPedidos.Count - 1 To 0 Step -1
                Dim movFacRes As New ModeloMovimientos_Factura_Reserva With {.AscPedidoMovimientos = New ModeloPedidoMovimientos With {.AscPedidosDetalle = New ModeloPedidoDetalle With {.IdPedidosDetalle = listaPedidos(i).IdPedidosDetalle}}}
                Dim movResRem As New ModeloMovimientos_Reserva_Remito With {.AscPedidosMovimientos = New ModeloPedidoMovimientos With {.AscPedidosDetalle = New ModeloPedidoDetalle With {.IdPedidosDetalle = listaPedidos(i).IdPedidosDetalle}}}

                Dim pedCanFac As Double = movFacRes.CantidadFacturada()

                If Not IsNothing(pedCanFac) Then
                    listaPedidos(i).Cantidad -= pedCanFac

                    Dim pedCanRem As Double = movResRem.CantidadRemitada()

                    If Not IsNothing(pedCanRem) Then
                        listaPedidos(i).Cantidad -= pedCanRem

                        If listaPedidos(i).Cantidad < 1 Then
                            listaPedidos.Remove(listaPedidos(i))
                        End If
                    Else
                        Return New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(Nothing, movResRem.Err)
                    End If
                Else
                    Return New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(Nothing, movFacRes.Err)
                End If
            Next

            Return New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(listaPedidos, Nothing)
        Else
            Return New RespuestaHTTP(Of List(Of ModeloPedidoDetalle))(Nothing, DetallePedido.Err)
        End If
    End Function
End Class
