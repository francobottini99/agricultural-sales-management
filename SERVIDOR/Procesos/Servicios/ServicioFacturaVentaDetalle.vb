Imports AccesoDatos

Public Class ServicioFacturaVentaDetalle
    Inherits EnlaceTransacciones(Of Transacciones)

    Private _FacturaVentaDetalle As ModeloFacturaVentaDetalle

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New Transacciones(), "SERVICIO")

        FacturaVentaDetalle = New ModeloFacturaVentaDetalle()
    End Sub

    Public Sub New(facturaVentaDetalle As ModeloFacturaVentaDetalle)
        MyBase.New(New Transacciones(), "SERVICIO")

        Me.FacturaVentaDetalle = facturaVentaDetalle
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property FacturaVentaDetalle As ModeloFacturaVentaDetalle
        Get
            Return _FacturaVentaDetalle
        End Get
        Set(value As ModeloFacturaVentaDetalle)
            _FacturaVentaDetalle = value
        End Set
    End Property
#End Region

    Public Function ListadoSinRemitar_Cliente() As RespuestaHTTP(Of List(Of ModeloFacturaVentaDetalle))
        FacturaVentaDetalle.Remitado = "NO"

        Dim listFacturaVentaDetalle As List(Of ModeloFacturaVentaDetalle) = FacturaVentaDetalle.ListadoFiltradoPorIdClienteYRemitado()

        If Not IsNothing(listFacturaVentaDetalle) Then
            For i As Integer = listFacturaVentaDetalle.Count - 1 To 0 Step -1
                Dim movRemFac As New ModeloMovimientos_Remito_Factura With {.AscFacturaVentaMovimientos = New ModeloFacturaVentaMovimientos With {.AscFacturaVentaDetalle = New ModeloFacturaVentaDetalle With {.IdFacturaVentaDetalle = listFacturaVentaDetalle(i).IdFacturaVentaDetalle}}}

                Dim facCanRem As Double = movRemFac.CantidadRemitada()

                If Not IsNothing(facCanRem) Then
                    listFacturaVentaDetalle(i).Cantidad -= facCanRem

                    If listFacturaVentaDetalle(i).Cantidad < 1 Then
                        listFacturaVentaDetalle.Remove(listFacturaVentaDetalle(i))
                    End If
                Else
                    Return New RespuestaHTTP(Of List(Of ModeloFacturaVentaDetalle))(Nothing, movRemFac.Err)
                End If
            Next

            Return New RespuestaHTTP(Of List(Of ModeloFacturaVentaDetalle))(listFacturaVentaDetalle, Nothing)
        Else
            Return New RespuestaHTTP(Of List(Of ModeloFacturaVentaDetalle))(Nothing, FacturaVentaDetalle.Err)
        End If
    End Function

    Public Function ListadoRemitado_Cliente() As RespuestaHTTP(Of List(Of ModeloFacturaVentaDetalle))
        Dim listFacturaVentaDetalle As List(Of ModeloFacturaVentaDetalle) = FacturaVentaDetalle.ListadoFiltradoPorIdCliente()

        If Not IsNothing(listFacturaVentaDetalle) Then
            For i As Integer = listFacturaVentaDetalle.Count - 1 To 0 Step -1
                Dim movRemFac As New ModeloMovimientos_Remito_Factura With {.AscFacturaVentaMovimientos = New ModeloFacturaVentaMovimientos With {.AscFacturaVentaDetalle = New ModeloFacturaVentaDetalle With {.IdFacturaVentaDetalle = listFacturaVentaDetalle(i).IdFacturaVentaDetalle}}}

                Dim facCanRem As Double = movRemFac.CantidadRemitada()

                If Not IsNothing(facCanRem) Then
                    Dim remCanFac As Double = movRemFac.CantidadFacturadaIdFacturaVentaDetalle()

                    If Not IsNothing(remCanFac) Then
                        listFacturaVentaDetalle(i).Cantidad = facCanRem + remCanFac

                        If listFacturaVentaDetalle(i).Cantidad < 1 Then
                            listFacturaVentaDetalle.Remove(listFacturaVentaDetalle(i))
                        End If
                    Else
                        Return New RespuestaHTTP(Of List(Of ModeloFacturaVentaDetalle))(Nothing, movRemFac.Err)
                    End If
                Else
                    Return New RespuestaHTTP(Of List(Of ModeloFacturaVentaDetalle))(Nothing, movRemFac.Err)
                End If
            Next

            Return New RespuestaHTTP(Of List(Of ModeloFacturaVentaDetalle))(listFacturaVentaDetalle, Nothing)
        Else
            Return New RespuestaHTTP(Of List(Of ModeloFacturaVentaDetalle))(Nothing, FacturaVentaDetalle.Err)
        End If
    End Function
End Class
