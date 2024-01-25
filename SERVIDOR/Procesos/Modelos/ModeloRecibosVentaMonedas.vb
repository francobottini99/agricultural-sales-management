Imports AccesoDatos

Public Class ModeloRecibosVentaMonedas
    Inherits EnlaceTransacciones(Of TransaccionesRecibosVentaMonedas)

    Private _idRecibosVentaMonedas As Integer
    Private _TipoCambio As Double
    Private _ImporteNeto As Double
    Private _DescuentoGral As Double
    Private _BaseImponible As Double
    Private _IVA As Double
    Private _ImporteTotal As Double
    Private _Eliminado As String
    Private _ascRecibosVenta As ModeloRecibosVenta
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesRecibosVentaMonedas(), "RECIBOS VENTA MONEDAS")

        AscRecibosVenta = New ModeloRecibosVenta()
        Err = New Errores()
    End Sub

    Public Sub New(idRecibosVentaMonedas As Integer, tipoCambio As Double, importeNeto As Double, descuentoGral As Double,
                   baseImponible As Double, iVA As Double, importeTotal As Double, eliminado As String, ascRecibosVenta As ModeloRecibosVenta)
        MyBase.New(New TransaccionesRecibosVentaMonedas(), "RECIBOS VENTA MONEDAS")

        Me.IdRecibosVentaMonedas = idRecibosVentaMonedas
        Me.TipoCambio = tipoCambio
        Me.ImporteNeto = importeNeto
        Me.DescuentoGral = descuentoGral
        Me.BaseImponible = baseImponible
        Me.IVA = iVA
        Me.ImporteTotal = importeTotal
        Me.Eliminado = eliminado
        Me.AscRecibosVenta = ascRecibosVenta
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdRecibosVentaMonedas As Integer
        Get
            Return _idRecibosVentaMonedas
        End Get
        Set(value As Integer)
            _idRecibosVentaMonedas = value
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

    Public Property AscRecibosVenta As ModeloRecibosVenta
        Get
            Return _ascRecibosVenta
        End Get
        Set(value As ModeloRecibosVenta)
            _ascRecibosVenta = value
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

    Public Function Modificar() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"

        EjecutarTransaccion("Modificar", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdRecibosVentaMonedas.ToString() + "] en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function Eliminar() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"

        EjecutarTransaccion("Eliminar", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdRecibosVentaMonedas.ToString() + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloRecibosVentaMonedas)
        Dim resultado As New List(Of TablaRecibosVentaMonedas)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE RECIBOS DE VENTA MONEDAS"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloRecibosVentaMonedas(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function
    Public Function EliminarPorIdRecibosVenta() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"
        detalleOperacion = "ELIMINAR LOS REGISTROS IDENTIFICADOS POR ID RECIBOS DE VENTA"

        EjecutarTransaccion("EliminarPorIdRecibosVenta", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                If Err.Descripcion = "-" Then
                    Err.Identificador = EnumErrores.ERROR_INFORMACION
                    Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdRecibosVentaMonedas.ToString() + "] de la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ConsultarPorIdRecibosVenta() As List(Of ModeloRecibosVentaMonedas)
        Dim resultado As New List(Of TablaRecibosVentaMonedas)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR REGISTROS IDENTIFICADOS POR ID RECIBOS DE VENTA"

        EjecutarTransaccion("ConsultarPorIdRecibosVenta", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloRecibosVentaMonedas(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function
#End Region

#Region "METODOS PRIVADOS"
    Private Function listModeloRecibosVentaMonedas(objeto As List(Of TablaRecibosVentaMonedas)) As List(Of ModeloRecibosVentaMonedas)
        Dim reciboVentaMonedas As New List(Of ModeloRecibosVentaMonedas)

        For Each item In objeto
            reciboVentaMonedas.Add(Drivers.RecibosVentaMonedas(item))
        Next

        Return reciboVentaMonedas
    End Function

    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(Drivers.RecibosVentaMonedas(Me))
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(Drivers.RecibosVentaMonedas(Me))
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdRecibosVentaMonedas)
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case "EliminarPorIdRecibosVenta"
                    resultado = Me.Transaccion.elimRegistroPorIdRecibosVenta(AscRecibosVenta.IdRecibosVenta)
                Case "ConsultarPorIdRecibosVenta"
                    resultado = Me.Transaccion.verRegistroPorIdRecibosVenta(AscRecibosVenta.IdRecibosVenta)
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
