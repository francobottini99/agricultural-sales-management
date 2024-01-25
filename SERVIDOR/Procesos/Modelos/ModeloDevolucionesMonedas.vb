Imports AccesoDatos

Public Class ModeloDevolucionesMonedas
    Inherits EnlaceTransacciones(Of TransaccionesDevolucionesMonedas)

    Private _idDevolucionesMonedas As Integer
    Private _TipoCambio As Double
    Private _ImporteNeto As Double
    Private _DescuentoGral As Double
    Private _BaseImponible As Double
    Private _IVA As Double
    Private _ImporteTotal As Double
    Private _Eliminado As String
    Private _ascDevoluciones As ModeloDevoluciones
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesDevolucionesMonedas(), "DEVOLUCIONES MONEDAS")

        AscDevoluciones = New ModeloDevoluciones()
        Err = New Errores()
    End Sub

    Public Sub New(idDevolucionesMonedas As Integer, tipoCambio As Double, importeNeto As Double, descuentoGral As Double,
                   baseImponible As Double, iVA As Double, importeTotal As Double, eliminado As String, ascDevoluciones As ModeloDevoluciones,
                   err As Errores)
        MyBase.New(New TransaccionesDevolucionesMonedas(), "DEVOLUCIONES MONEDAS")

        Me.IdDevolucionesMonedas = idDevolucionesMonedas
        Me.TipoCambio = tipoCambio
        Me.ImporteNeto = importeNeto
        Me.DescuentoGral = descuentoGral
        Me.BaseImponible = baseImponible
        Me.IVA = iVA
        Me.ImporteTotal = importeTotal
        Me.Eliminado = eliminado
        Me.AscDevoluciones = ascDevoluciones
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdDevolucionesMonedas As Integer
        Get
            Return _idDevolucionesMonedas
        End Get
        Set(value As Integer)
            _idDevolucionesMonedas = value
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

    Public Property AscDevoluciones As ModeloDevoluciones
        Get
            Return _ascDevoluciones
        End Get
        Set(value As ModeloDevoluciones)
            _ascDevoluciones = value
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

    Public Function EliminarPorIdDevoluciones() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"
        detalleOperacion = "ELIMINAR LOS REGISTROS IDENTIFICADOS POR LA ID DEVOLUCIONES"

        EjecutarTransaccion("EliminarPorIdDevoluciones", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdDevolucionesMonedas.ToString() + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function
#End Region

#Region "METODOS PRIVADOS"
    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(Drivers.DevolucionesMonedas(Me))
                Case "EliminarPorIdDevoluciones"
                    resultado = Me.Transaccion.elimRegistroPorIdDevoluciones(AscDevoluciones.IdDevoluciones)
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
