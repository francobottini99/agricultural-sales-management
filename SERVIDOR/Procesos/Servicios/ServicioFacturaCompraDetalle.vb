Imports AccesoDatos

Public Class ServicioFacturaCompraDetalle
    Inherits EnlaceTransacciones(Of Transacciones)

    Private _FacturaCompraDetalle As ModeloFacturaCompraDetalle

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New Transacciones(), "SERVICIO")

        FacturaCompraDetalle = New ModeloFacturaCompraDetalle()
    End Sub

    Public Sub New(facturaCompraDetalle As ModeloFacturaCompraDetalle)
        MyBase.New(New Transacciones(), "SERVICIO")

        Me.FacturaCompraDetalle = facturaCompraDetalle
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property FacturaCompraDetalle As ModeloFacturaCompraDetalle
        Get
            Return _FacturaCompraDetalle
        End Get
        Set(value As ModeloFacturaCompraDetalle)
            _FacturaCompraDetalle = value
        End Set
    End Property
#End Region

    Public Function ListadoSinRemitar_Proveedor() As RespuestaHTTP(Of List(Of ModeloFacturaCompraDetalle))
        FacturaCompraDetalle.Remitado = "NO"

        Dim listFacturaCompraDetalle As List(Of ModeloFacturaCompraDetalle) = FacturaCompraDetalle.ListadoFiltradoPorIdProveedorYRemitado()

        If Not IsNothing(listFacturaCompraDetalle) Then
            For i As Integer = listFacturaCompraDetalle.Count - 1 To 0 Step -1
                Dim movRemFac As New ModeloMovimientos_RemitoCompra_FacturaCompra With {.AscFacturaCompraMovimientos = New ModeloFacturaCompraMovimientos With {.AscFacturaCompraDetalle = New ModeloFacturaCompraDetalle With {.IdFacturaCompraDetalle = listFacturaCompraDetalle(i).IdFacturaCompraDetalle}}}

                Dim facCanRem As Double = movRemFac.CantidadRemitada()

                If Not IsNothing(facCanRem) Then
                    listFacturaCompraDetalle(i).Cantidad -= facCanRem

                    If listFacturaCompraDetalle(i).Cantidad < 1 Then
                        listFacturaCompraDetalle.Remove(listFacturaCompraDetalle(i))
                    End If
                Else
                    Return New RespuestaHTTP(Of List(Of ModeloFacturaCompraDetalle))(Nothing, movRemFac.Err)
                End If
            Next

            Return New RespuestaHTTP(Of List(Of ModeloFacturaCompraDetalle))(listFacturaCompraDetalle, Nothing)
        Else
            Return New RespuestaHTTP(Of List(Of ModeloFacturaCompraDetalle))(Nothing, FacturaCompraDetalle.Err)
        End If
    End Function
End Class
