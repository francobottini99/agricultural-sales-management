Public Class ServicioOrdenDePago
    Public Property OrdenDePago As ModeloOrdenDePago
    Public Property OrdenDePagoDetalle As List(Of ModeloOrdenDePagoDetalle)
    Public Property CuentaCorrienteCompra As ModeloCuentaCorrienteCompra
    Public Property Caja As List(Of ModeloCaja)
    Public Property DetalleCheques As List(Of ModeloDetalleCheque)
    Public Property MovimientoValores As List(Of ModeloMovimientoValores)
    Public Property OrdenDePagoMonedas As List(Of ModeloOrdenDePagoMonedas)
    Public Property Numeracion As ModeloNumeracion

    Public Sub New()
        OrdenDePago = New ModeloOrdenDePago()
        OrdenDePagoDetalle = New List(Of ModeloOrdenDePagoDetalle)
        CuentaCorrienteCompra = New ModeloCuentaCorrienteCompra()
        Caja = New List(Of ModeloCaja)
        DetalleCheques = New List(Of ModeloDetalleCheque)
        MovimientoValores = New List(Of ModeloMovimientoValores)
        OrdenDePagoMonedas = New List(Of ModeloOrdenDePagoMonedas)
        Numeracion = New ModeloNumeracion()
    End Sub
End Class
