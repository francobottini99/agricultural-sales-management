Imports AccesoDatos

Public Class ServicioDetalleRemitoCompra
    Inherits EnlaceTransacciones(Of Transacciones)

    Private _DetalleRemitoCompra As ModeloDetalleRemitoCompra

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New Transacciones(), "SERVICIO")

        DetalleRemitoCompra = New ModeloDetalleRemitoCompra()
    End Sub

    Public Sub New(detalleCompra As ModeloDetalleRemitoCompra)
        MyBase.New(New Transacciones(), "SERVICIO")

        Me.DetalleRemitoCompra = detalleCompra
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property DetalleRemitoCompra As ModeloDetalleRemitoCompra
        Get
            Return _DetalleRemitoCompra
        End Get
        Set(value As ModeloDetalleRemitoCompra)
            _DetalleRemitoCompra = value
        End Set
    End Property
#End Region

    Public Function ListadoSinFacturar_Proveedor() As RespuestaHTTP(Of List(Of ModeloDetalleRemitoCompra))
        DetalleRemitoCompra.Facturado = "NO"

        Dim listDetalleRemito As List(Of ModeloDetalleRemitoCompra) = DetalleRemitoCompra.ListadoFiltradoPorIdProveedorYFacturado()

        If Not IsNothing(listDetalleRemito) Then
            For i As Integer = listDetalleRemito.Count - 1 To 0 Step -1
                Dim movRemFac As New ModeloMovimientos_RemitoCompra_FacturaCompra With {.AscRemitosCompraMovimientos = New ModeloRemitosCompraMovimientos With {.AscDetalleRemtioCompra = New ModeloDetalleRemitoCompra With {.IdDetalleRemitosCompra = listDetalleRemito(i).IdDetalleRemitosCompra}}}

                Dim remCanFac As Double = movRemFac.CantidadFacturada()

                If Not IsNothing(remCanFac) Then
                    listDetalleRemito(i).Cantidad -= remCanFac

                    If listDetalleRemito(i).Cantidad < 1 Then
                        listDetalleRemito.Remove(listDetalleRemito(i))
                    End If
                Else
                    Return New RespuestaHTTP(Of List(Of ModeloDetalleRemitoCompra))(Nothing, movRemFac.Err)
                End If
            Next

            Return New RespuestaHTTP(Of List(Of ModeloDetalleRemitoCompra))(listDetalleRemito, Nothing)
        Else
            Return New RespuestaHTTP(Of List(Of ModeloDetalleRemitoCompra))(Nothing, DetalleRemitoCompra.Err)
        End If
    End Function
End Class
