Imports AccesoDatos

Public Class ModeloFacturaVentaMonedas
    Inherits EnlaceTransacciones(Of TransaccionesFacturaVentaMoneda)

    Private _idFacturaVtaMonedas As Integer
    Private _TipoCambio As Double
    Private _ImporteNeto As Double
    Private _DescuentoGral As Double
    Private _BaseImponible As Double
    Private _IVA As Double
    Private _ImporteTotal As Double
    Private _Eliminado As String
    Private _ascFacturaVenta As ModeloFacturaVenta
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesFacturaVentaMoneda(), "FACTURA VENTA MONEDAS")

        Err = New Errores()
        AscFacturaVenta = New ModeloFacturaVenta()
    End Sub

    Public Sub New(idFacturaVtaMonedas As Integer, tipoCambio As Double, importeNeto As Double, descuentoGral As Double, baseImponible As Double,
                   iVA As Double, importeTotal As Double, eliminado As String, ascFacturaVenta As ModeloFacturaVenta, err As Errores)
        MyBase.New(New TransaccionesFacturaVentaMoneda(), "FACTURA VENTA MONEDAS")

        Me.IdFacturaVtaMonedas = idFacturaVtaMonedas
        Me.TipoCambio = tipoCambio
        Me.ImporteNeto = importeNeto
        Me.DescuentoGral = descuentoGral
        Me.BaseImponible = baseImponible
        Me.IVA = iVA
        Me.ImporteTotal = importeTotal
        Me.Eliminado = eliminado
        Me.AscFacturaVenta = ascFacturaVenta
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdFacturaVtaMonedas As Integer
        Get
            Return _idFacturaVtaMonedas
        End Get
        Set(value As Integer)
            _idFacturaVtaMonedas = value
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

    Public Property AscFacturaVenta As ModeloFacturaVenta
        Get
            Return _ascFacturaVenta
        End Get
        Set(value As ModeloFacturaVenta)
            _ascFacturaVenta = value
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

    Public Function EliminarPorIdFacturaVenta() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"
        detalleOperacion = "ELIMINAR LOS REGISTROS IDENTIFICADOS POR LA ID FACTURA VENTA"

        EjecutarTransaccion("EliminarPorIdFacturaVenta", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                If Err.Descripcion = "-" Then
                    Err.Identificador = EnumErrores.ERROR_INFORMACION
                    Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdFacturaVtaMonedas + "] de la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ConsultarPorIdFacturaVenta() As ModeloFacturaVentaMonedas
        Dim resultado As New TablaFacturaVentaMonedas

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR REGISTRO REMITOS VENTA MONEDAS IDENTIFICADO POR ID REMITOS VENTA"

        EjecutarTransaccion("ConsultarPorIdFacturaVenta", resultado)

        If Not IsNothing(resultado) Then
            Return New ModeloFacturaVentaMonedas With {
                    .IdFacturaVtaMonedas = resultado.idFacturaVtaMonedas,
                    .TipoCambio = resultado.TipoCambio,
                    .ImporteNeto = resultado.ImporteNeto,
                    .DescuentoGral = resultado.DescuentoGral,
                    .BaseImponible = resultado.BaseImponible,
                    .IVA = resultado.IVA,
                    .ImporteTotal = resultado.ImporteTotal
                }
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el registro de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloFacturaVentaMonedas)
        Dim resultado As New List(Of TablaFacturaVentaMonedas)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE FACTURA VENTA MONEDAS"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return Drivers.FacturaVentaMonedas(resultado)
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
                    resultado = Me.Transaccion.insRegistro(New TablaFacturaVentaMonedas With {
                                                                .TipoCambio = TipoCambio,
                                                                .ImporteNeto = ImporteNeto,
                                                                .DescuentoGral = DescuentoGral,
                                                                .BaseImponible = BaseImponible,
                                                                .IVA = IVA,
                                                                .ImporteTotal = ImporteTotal,
                                                                .Eliminado = Eliminado,
                                                                .ascFacturaVenta = New TablaFacturaVenta With {.idFacturaVenta = AscFacturaVenta.IdFacturaVenta}
                                                           })
                Case "EliminarPorIdFacturaVenta"
                    resultado = Me.Transaccion.elimRegistroPorIdFacturaVenta(AscFacturaVenta.IdFacturaVenta)
                Case "ConsultarPorIdFacturaVenta"
                    resultado = Me.Transaccion.verRegistroPorIdFacturaVenta(AscFacturaVenta.IdFacturaVenta)
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
