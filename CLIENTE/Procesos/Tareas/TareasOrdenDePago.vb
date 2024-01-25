Imports Comunicacion

Public Class TareasOrdenDePago
    Inherits EnlaceTransacciones(Of TransaccionesOrdenDePago)

    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        Err = New Errores()
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property Err As Errores
        Get
            Return _Err
        End Get
        Set(value As Errores)
            _Err = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS ACCESO A COMUNICACIONES"
    Public Async Function Insertar(_OrdenDePago As OrdenDePago) As Task(Of Boolean)
        Try
            Await Transaccion.insRegistro(Drivers.OrdenDePago(_OrdenDePago))

            Return True
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return False
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return False
        End Try
    End Function

    Public Async Function Servicio_Insertar(_OrdenDePago As OrdenDePago, _Numeracion As Numeracion, _CuentaCorrienteCompra As CuentaCorrienteCompra, _OrdenDePagoDetalle As List(Of OrdenDePagoDetalle),
                                            _Caja As List(Of Caja), _DetalleCheques As List(Of DetalleCheque), _MovimientoValores As List(Of MovimientoValores), _OrdenDePagoMonedas As List(Of OrdenDePagoMonedas)) As Task(Of Boolean)
        Try
            Dim OrdenDePagoDetalle As New List(Of ModeloOrdenDePagoDetalle)
            Dim Caja As New List(Of ModeloCaja)
            Dim DetalleCheques As New List(Of ModeloDetalleCheque)
            Dim MovimientoValores As New List(Of ModeloMovimientoValores)
            Dim OrdenDePagoMonedas As New List(Of ModeloOrdenDePagoMonedas)

            For Each item In _OrdenDePagoDetalle
                OrdenDePagoDetalle.Add(Drivers.OrdenDePagoDetalle(item))
            Next

            For Each item In _Caja
                Caja.Add(Drivers.Caja(item))
            Next

            For Each item In _DetalleCheques
                DetalleCheques.Add(Drivers.DetalleCheque(item))
            Next

            For Each item In _MovimientoValores
                MovimientoValores.Add(Drivers.MovimientoValores(item))
            Next

            For Each item In _OrdenDePagoMonedas
                OrdenDePagoMonedas.Add(Drivers.OrdenDePagoMonedas(item))
            Next

            Await Transaccion.Servicio_insRegistro(New ServicioOrdenDePago With {
                                                        .OrdenDePago = Drivers.OrdenDePago(_OrdenDePago),
                                                        .Numeracion = Drivers.Numeracion(_Numeracion),
                                                        .CuentaCorrienteCompra = Drivers.CuentaCorrienteCompra(_CuentaCorrienteCompra),
                                                        .OrdenDePagoDetalle = OrdenDePagoDetalle,
                                                        .Caja = Caja,
                                                        .DetalleCheques = DetalleCheques,
                                                        .MovimientoValores = MovimientoValores,
                                                        .OrdenDePagoMonedas = OrdenDePagoMonedas
                                                   })

            Return True
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return False
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return False
        End Try
    End Function


    Public Async Function Modificar(_OrdenDePago As OrdenDePago) As Task(Of Boolean)
        Try
            Await Transaccion.modRegistro(Drivers.OrdenDePago(_OrdenDePago))

            Return True
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return False
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return False
        End Try
    End Function

    Public Async Function Eliminar(id As Integer) As Task(Of Boolean)
        Try
            Await Transaccion.elimRegistro(id)

            Return True
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return False
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return False
        End Try
    End Function

    Public Async Function ListadoCompleto() As Task(Of List(Of OrdenDePago))
        Try
            Dim list As New List(Of OrdenDePago)

            For Each item In Await Transaccion.verRegistros()
                list.Add(Drivers.OrdenDePago(item))
            Next

            Return list
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return Nothing
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return Nothing
        End Try
    End Function
#End Region

End Class
