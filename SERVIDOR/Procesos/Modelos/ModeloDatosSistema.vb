Imports AccesoDatos
Public Class ModeloDatosSistema
    Inherits EnlaceTransacciones(Of TransaccionesDatosSistema)

    Private _idDatosSistema As Integer
    Private _MonedaFacturacion As String
    Private _MonedaContable As String
    Private _AlicuotaIva1 As Double
    Private _AlicuotaIva2 As Double
    Private _AlicuotaIva3 As Double
    Private _AlicuotaMargen As Double
    Private _AlicuotaDesc1 As Double
    Private _AlicuotaDesc2 As Double
    Private _ascUsuarios As ModeloUsuario
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesDatosSistema(), "DATOS SISTEMA")

        AscUsuarios = New ModeloUsuario()
        Err = New Errores()
    End Sub

    Public Sub New(idDatosSistema As Integer, monedaFacturacion As String, monedaContable As String, alicuotaIva1 As Double, alicuotaIva2 As Double,
                   alicuotaIva3 As Double, alicuotaMargen As Double, alicuotaDesc1 As Double, alicuotaDesc2 As Double, ascUsuarios As ModeloUsuario, err As Errores)
        MyBase.New(New TransaccionesDatosSistema(), "DATOS SISTEMA")

        Me.IdDatosSistema = idDatosSistema
        Me.MonedaFacturacion = monedaFacturacion
        Me.MonedaContable = monedaContable
        Me.AlicuotaIva1 = alicuotaIva1
        Me.AlicuotaIva2 = alicuotaIva2
        Me.AlicuotaIva3 = alicuotaIva3
        Me.AlicuotaMargen = alicuotaMargen
        Me.AlicuotaDesc1 = alicuotaDesc1
        Me.AlicuotaDesc2 = alicuotaDesc2
        Me.AscUsuarios = ascUsuarios
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdDatosSistema As Integer
        Get
            Return _idDatosSistema
        End Get
        Set(value As Integer)
            _idDatosSistema = value
        End Set
    End Property

    Public Property MonedaFacturacion As String
        Get
            Return _MonedaFacturacion
        End Get
        Set(value As String)
            _MonedaFacturacion = value
        End Set
    End Property

    Public Property MonedaContable As String
        Get
            Return _MonedaContable
        End Get
        Set(value As String)
            _MonedaContable = value
        End Set
    End Property

    Public Property AlicuotaIva1 As Double
        Get
            Return _AlicuotaIva1
        End Get
        Set(value As Double)
            _AlicuotaIva1 = value
        End Set
    End Property

    Public Property AlicuotaIva2 As Double
        Get
            Return _AlicuotaIva2
        End Get
        Set(value As Double)
            _AlicuotaIva2 = value
        End Set
    End Property

    Public Property AlicuotaIva3 As Double
        Get
            Return _AlicuotaIva3
        End Get
        Set(value As Double)
            _AlicuotaIva3 = value
        End Set
    End Property

    Public Property AlicuotaMargen As Double
        Get
            Return _AlicuotaMargen
        End Get
        Set(value As Double)
            _AlicuotaMargen = value
        End Set
    End Property

    Public Property AlicuotaDesc1 As Double
        Get
            Return _AlicuotaDesc1
        End Get
        Set(value As Double)
            _AlicuotaDesc1 = value
        End Set
    End Property

    Public Property AlicuotaDesc2 As Double
        Get
            Return _AlicuotaDesc2
        End Get
        Set(value As Double)
            _AlicuotaDesc2 = value
        End Set
    End Property

    Public Property AscUsuarios As ModeloUsuario
        Get
            Return _ascUsuarios
        End Get
        Set(value As ModeloUsuario)
            _ascUsuarios = value
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
    Public Function Consultar() As ModeloDatosSistema
        Dim resultado As New TablaDatosSistema

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTA EL REGISTRO DE DATOS DEL SISTEMA"

        EjecutarTransaccion("Consultar", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.DatosSistema(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el registro de la tabla " + tabla
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
                Case "Consultar"
                    resultado = Me.Transaccion.verRegistro()
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
