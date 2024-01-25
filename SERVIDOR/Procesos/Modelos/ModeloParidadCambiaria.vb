Imports AccesoDatos

Public Class ModeloParidadCambiaria
    Inherits EnlaceTransacciones(Of TransaccionesParidadCambiaria)

    Private _idParidadCambiaria As Integer
    Private _Fecha As DateTime
    Private _CotizacionCompra As Double
    Private _CotizacionVenta As Double
    Private _Eliminado As String
    Private _ascMonedas As ModeloMonedas
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesParidadCambiaria(), "PARIDAD CAMBIARIA")

        Err = New Errores()
        AscMonedas = New ModeloMonedas()
    End Sub

    Public Sub New(idParidadCambiaria As Integer, fecha As Date, cotizacionCompra As Double, cotizacionVenta As Double, eliminado As String,
                   ascMonedas As ModeloMonedas, err As Errores)
        MyBase.New(New TransaccionesParidadCambiaria(), "PARIDAD CAMBIARIA")

        Me.IdParidadCambiaria = idParidadCambiaria
        Me.Fecha = fecha
        Me.CotizacionCompra = cotizacionCompra
        Me.CotizacionVenta = cotizacionVenta
        Me.Eliminado = eliminado
        Me.AscMonedas = ascMonedas
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdParidadCambiaria As Integer
        Get
            Return _idParidadCambiaria
        End Get
        Set(value As Integer)
            _idParidadCambiaria = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property

    Public Property CotizacionCompra As Double
        Get
            Return _CotizacionCompra
        End Get
        Set(value As Double)
            _CotizacionCompra = value
        End Set
    End Property

    Public Property CotizacionVenta As Double
        Get
            Return _CotizacionVenta
        End Get
        Set(value As Double)
            _CotizacionVenta = value
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

    Public Property AscMonedas As ModeloMonedas
        Get
            Return _ascMonedas
        End Get
        Set(value As ModeloMonedas)
            _ascMonedas = value
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

    Public Function ListadoPorIdMonedas() As List(Of ModeloParidadCambiaria)
        Dim resultado As New List(Of TablaParidadCambiaria)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO DE PARIDAD CAMBIARIA FILTRADO POR ID MONEDAS"

        EjecutarTransaccion("ListadoPorIdMonedas", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloParidadCambiaria(resultado)
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
    Private Function listModeloParidadCambiaria(objeto As List(Of TablaParidadCambiaria)) As List(Of ModeloParidadCambiaria)
        Dim paridadCambiaria As New List(Of ModeloParidadCambiaria)

        For Each item In objeto
            paridadCambiaria.Add(New ModeloParidadCambiaria With {
                                    .IdParidadCambiaria = item.idParidadCambiaria,
                                    .Fecha = item.Fecha,
                                    .CotizacionCompra = item.CotizacionCompra,
                                    .CotizacionVenta = item.CotizacionVenta,
                                    .AscMonedas = New ModeloMonedas With {.IdMonedas = item.ascMonedas.idMonedas}
                                 })
        Next

        Return paridadCambiaria
    End Function

    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(New TablaParidadCambiaria With {
                                                                .Fecha = Fecha,
                                                                .CotizacionCompra = CotizacionCompra,
                                                                .CotizacionVenta = CotizacionVenta,
                                                                .ascMonedas = New TablaMonedas With {.idMonedas = AscMonedas.IdMonedas}
                                                           })
                Case "ListadoPorIdMonedas"
                    resultado = Me.Transaccion.verRegistrosPorIdMonedas(AscMonedas.IdMonedas)
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

