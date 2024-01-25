Imports AccesoDatos

Public Class ServicioDetalleRemitoVenta
    Inherits EnlaceTransacciones(Of Transacciones)

    Private _DetalleRemitoVenta As ModeloDetalleRemitoVenta

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New Transacciones(), "SERVICIO")

        DetalleRemitoVenta = New ModeloDetalleRemitoVenta()
    End Sub

    Public Sub New(detallePedido As ModeloDetalleRemitoVenta)
        MyBase.New(New Transacciones(), "SERVICIO")

        Me.DetalleRemitoVenta = detallePedido
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property DetalleRemitoVenta As ModeloDetalleRemitoVenta
        Get
            Return _DetalleRemitoVenta
        End Get
        Set(value As ModeloDetalleRemitoVenta)
            _DetalleRemitoVenta = value
        End Set
    End Property
#End Region

    Public Function ListadoSinFacturar_Cliente() As RespuestaHTTP(Of List(Of ModeloDetalleRemitoVenta))
        DetalleRemitoVenta.Facturado = "NO"

        Dim listDetalleRemito As List(Of ModeloDetalleRemitoVenta) = DetalleRemitoVenta.ListadoFiltradoPorIdClienteYFacturado()

        If Not IsNothing(listDetalleRemito) Then
            For i As Integer = listDetalleRemito.Count - 1 To 0 Step -1
                Dim movRem As New ModeloRemitosVentaMovimientos With {.AscDetalleRemitoVenta = New ModeloDetalleRemitoVenta With {.IdDetalleRemitosVenta = listDetalleRemito(i).IdDetalleRemitosVenta}}

                Dim remCanFac As Double = movRem.CantidadFacturada()

                If Not IsNothing(remCanFac) Then
                    Dim remCanDev As Double = movRem.CantidadDevuelta()

                    If Not IsNothing(remCanFac) Then
                        listDetalleRemito(i).Cantidad -= (remCanDev + remCanFac)

                        If listDetalleRemito(i).Cantidad < 1 Then
                            listDetalleRemito.Remove(listDetalleRemito(i))
                        End If
                    Else
                        Return New RespuestaHTTP(Of List(Of ModeloDetalleRemitoVenta))(Nothing, movRem.Err)
                    End If
                Else
                    Return New RespuestaHTTP(Of List(Of ModeloDetalleRemitoVenta))(Nothing, movRem.Err)
                End If
            Next

            Return New RespuestaHTTP(Of List(Of ModeloDetalleRemitoVenta))(listDetalleRemito, Nothing)
        Else
            Return New RespuestaHTTP(Of List(Of ModeloDetalleRemitoVenta))(Nothing, DetalleRemitoVenta.Err)
        End If
    End Function
End Class
