Public Class ServicioRecibosVenta
    Public Property RecibosVenta As ModeloRecibosVenta
    Public Property RecibosVentaDetalle As List(Of ModeloRecibosVentaDetalle)
    Public Property CuentaCorrienteVenta As ModeloCuentaCorrienteVenta
    Public Property Caja As List(Of ModeloCaja)
    Public Property MovimientoValores As List(Of ModeloMovimientoValores)
    Public Property RecibosVentaMonedas As List(Of ModeloRecibosVentaMonedas)
    Public Property Numeracion As ModeloNumeracion

    Public Sub New()
        RecibosVenta = New ModeloRecibosVenta()
        RecibosVentaDetalle = New List(Of ModeloRecibosVentaDetalle)()
        CuentaCorrienteVenta = New ModeloCuentaCorrienteVenta()
        Caja = New List(Of ModeloCaja)()
        MovimientoValores = New List(Of ModeloMovimientoValores)()
        RecibosVentaMonedas = New List(Of ModeloRecibosVentaMonedas)()
        Numeracion = New ModeloNumeracion()
    End Sub
End Class
