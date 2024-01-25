Imports AccesoDatos

Public Class ModeloDetalleDevoluciones
    Inherits EnlaceTransacciones(Of TransaccionesDetalleDevoluciones)

    Private _idDetalleDevoluciones As Integer
    Private _Descripcion As String
    Private _Cantidad As Double
    Private _Unidad As String
    Private _Precio As Double
    Private _Importe As Double
    Private _AlicuotaIVA As Double
    Private _Eliminado As String
    Private _ascArticulos As ModeloArticulos
    Private _ascDetalleRemitoVenta As ModeloDetalleRemitoVenta
    Private _ascDevoluciones As ModeloDevoluciones
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesDetalleDevoluciones(), "DETALLE DEVOLUCIONES")

        AscArticulos = New ModeloArticulos()
        AscDetalleRemitoVenta = New ModeloDetalleRemitoVenta()
        AscDevoluciones = New ModeloDevoluciones()
        Err = New Errores()
    End Sub

    Public Sub New(idDetalleDevoluciones As Integer, descripcion As String, cantidad As Double, unidad As String, precio As Double,
                   importe As Double, alicuotaIVA As Double, eliminado As String, ascArticulos As ModeloArticulos,
                   ascDetalleRemitoVenta As ModeloDetalleRemitoVenta, ascDevoluciones As ModeloDevoluciones, err As Errores)
        MyBase.New(New TransaccionesDetalleDevoluciones(), "DETALLE DEVOLUCIONES")

        Me.IdDetalleDevoluciones = idDetalleDevoluciones
        Me.Descripcion = descripcion
        Me.Cantidad = cantidad
        Me.Unidad = unidad
        Me.Precio = precio
        Me.Importe = importe
        Me.AlicuotaIVA = alicuotaIVA
        Me.Eliminado = eliminado
        Me.AscArticulos = ascArticulos
        Me.AscDetalleRemitoVenta = ascDetalleRemitoVenta
        Me.AscDevoluciones = ascDevoluciones
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdDetalleDevoluciones As Integer
        Get
            Return _idDetalleDevoluciones
        End Get
        Set(value As Integer)
            _idDetalleDevoluciones = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property Cantidad As Double
        Get
            Return _Cantidad
        End Get
        Set(value As Double)
            _Cantidad = value
        End Set
    End Property

    Public Property Unidad As String
        Get
            Return _Unidad
        End Get
        Set(value As String)
            _Unidad = value
        End Set
    End Property

    Public Property Precio As Double
        Get
            Return _Precio
        End Get
        Set(value As Double)
            _Precio = value
        End Set
    End Property

    Public Property Importe As Double
        Get
            Return _Importe
        End Get
        Set(value As Double)
            _Importe = value
        End Set
    End Property

    Public Property AlicuotaIVA As Double
        Get
            Return _AlicuotaIVA
        End Get
        Set(value As Double)
            _AlicuotaIVA = value
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

    Public Property AscArticulos As ModeloArticulos
        Get
            Return _ascArticulos
        End Get
        Set(value As ModeloArticulos)
            _ascArticulos = value
        End Set
    End Property

    Public Property AscDetalleRemitoVenta As ModeloDetalleRemitoVenta
        Get
            Return _ascDetalleRemitoVenta
        End Get
        Set(value As ModeloDetalleRemitoVenta)
            _ascDetalleRemitoVenta = value
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
                If Err.Descripcion = "-" Then
                    Err.Identificador = EnumErrores.ERROR_INFORMACION
                    Err.Descripcion = "No se pudo insertar el nuevo registro en la tabla " + tabla
                End If

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
                    resultado = Me.Transaccion.insRegistro(Drivers.DetalleDevoluciones(Me))
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
