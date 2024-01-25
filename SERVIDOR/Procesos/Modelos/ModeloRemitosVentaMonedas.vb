Imports AccesoDatos

Public Class ModeloRemitosVentaMonedas
    Inherits EnlaceTransacciones(Of TransaccionesRemitosVentaMonedas)

    Private _idRemitoVtaMonedas As Integer
    Private _TipoCambio As Double
    Private _ImporteNeto As Double
    Private _DescuentoGral As Double
    Private _BaseImponible As Double
    Private _IVA As Double
    Private _ImporteTotal As Double
    Private _Eliminado As String
    Private _ascRemitosventa As ModeloRemitosVenta
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesRemitosVentaMonedas(), "REMITO VENTA MONEDAS")

        AscRemitosventa = New ModeloRemitosVenta()
        Err = New Errores()
    End Sub

    Public Sub New(idRemitoVtaMonedas As Integer, tipoCambio As Double, importeNeto As Double, descuentoGral As Double, baseImponible As Double,
                   iVA As Double, importeTotal As Double, eliminado As String, ascRemitosventa As ModeloRemitosVenta, err As Errores)
        MyBase.New(New TransaccionesRemitosVentaMonedas(), "REMITO VENTA MONEDAS")

        Me.IdRemitoVtaMonedas = idRemitoVtaMonedas
        Me.TipoCambio = tipoCambio
        Me.ImporteNeto = importeNeto
        Me.DescuentoGral = descuentoGral
        Me.BaseImponible = baseImponible
        Me.IVA = iVA
        Me.ImporteTotal = importeTotal
        Me.Eliminado = eliminado
        Me.AscRemitosventa = ascRemitosventa
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdRemitoVtaMonedas As Integer
        Get
            Return _idRemitoVtaMonedas
        End Get
        Set(value As Integer)
            _idRemitoVtaMonedas = value
        End Set
    End Property

    Public Property TipoCambio As Double
        Get
            Return _TipoCambio
        End Get
        Set(value As Double)
            _TipoCambio = value
        End Set
    End Property

    Public Property ImporteNeto As Double
        Get
            Return _ImporteNeto
        End Get
        Set(value As Double)
            _ImporteNeto = value
        End Set
    End Property

    Public Property DescuentoGral As Double
        Get
            Return _DescuentoGral
        End Get
        Set(value As Double)
            _DescuentoGral = value
        End Set
    End Property

    Public Property BaseImponible As Double
        Get
            Return _BaseImponible
        End Get
        Set(value As Double)
            _BaseImponible = value
        End Set
    End Property

    Public Property IVA As Double
        Get
            Return _IVA
        End Get
        Set(value As Double)
            _IVA = value
        End Set
    End Property

    Public Property ImporteTotal As Double
        Get
            Return _ImporteTotal
        End Get
        Set(value As Double)
            _ImporteTotal = value
        End Set
    End Property

    Public Property Eliminado As String
        Get
            Return _Eliminado
        End Get
        Set(value As String)
            _Eliminado = value
        End Set
    End Property

    Public Property AscRemitosventa As ModeloRemitosVenta
        Get
            Return _ascRemitosventa
        End Get
        Set(value As ModeloRemitosVenta)
            _ascRemitosventa = value
        End Set
    End Property

    Public Property Err As Errores
        Get
            Return _Err
        End Get
        Set(value As Errores)
            _Err = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS"
    Public Function Insertar() As Boolean
        Dim resultado As Integer

        operacion = "INSERTAR"

        EjecutarTransaccion("Insertar", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo insertar el nuevo registro en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function EliminarPorIdRemitosVenta() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"
        detalleOperacion = "ELIMINAR LOS REGISTROS IDENTIFICADOS POR LA ID REMITOS VENTA"

        EjecutarTransaccion("EliminarPorIdRemitosVenta", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdRemitoVtaMonedas + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ConsultarPorIdRemitosVenta() As ModeloRemitosVentaMonedas
        Dim resultado As New TablaRemitosVentaMonedas

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR REGISTRO REMITOS VENTA MONEDAS IDENTIFICADO POR ID REMITOS VENTA"

        EjecutarTransaccion("ConsultarPorIdRemitosVenta", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.RemitoVentaMonedas(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el registro de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloRemitosVentaMonedas)
        Dim resultado As New List(Of TablaRemitosVentaMonedas)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE REMITOS VENTA MONEDAS"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.RemitoVentaMonedas(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function
#End Region

#Region "METODOS PRIVADOS"
    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(Drivers.RemitoVentaMonedas(Me))
                Case "EliminarPorIdRemitosVenta"
                    resultado = Me.Transaccion.elimRegistroPorIdRemitosVenta(AscRemitosventa.IdRemitosVenta)
                Case "ConsultarPorIdRemitosVenta"
                    resultado = Me.Transaccion.verRegistroPorIdRemitosVenta(AscRemitosventa.IdRemitosVenta)
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case Else
                    Err.Identificador = EnumErrores.TRANSACCION_DESCONOCIDA
                    Err.Descripcion = "La transaccion """ + transaccion + """ no se encuentra en el servidor"

                    resultado = Nothing
            End Select
        Catch ex As MySql.Data.MySqlClient.MySqlException
            Err.Identificador = EnumErrores.ERROR_MYSQL
            Err.Descripcion = ex.Message + " | " + ex.StackTrace

            resultado = Nothing
        Catch ex As Exception
            Err.Identificador = EnumErrores.ERROR_GENERAL
            Err.Descripcion = ex.Message + " | " + ex.StackTrace

            resultado = Nothing
        Finally
            detalleResultado = Err.Descripcion

            AñadirOperacion()
        End Try
    End Sub
#End Region
End Class
