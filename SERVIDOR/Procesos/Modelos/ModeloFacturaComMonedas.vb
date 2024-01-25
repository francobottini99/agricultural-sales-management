Imports AccesoDatos

Public Class ModeloFacturaComMonedas
    Inherits EnlaceTransacciones(Of TransaccionesFacturaComMonedas)

    Private _idFacturaComMonedas As Integer
    Private _TipoCambio As Double
    Private _ImporteNeto As Double
    Private _DescuentoGral As Double
    Private _BaseImponible As Double
    Private _IVA As Double
    Private _ImporteTotal As Double
    Private _Eliminado As String
    Private _ascFacturaCompra As ModeloFacturaCompra
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesFacturaComMonedas(), "FACTURA COMPRA MONEDAS")

        Err = New Errores()
        AscFacturaCompra = New ModeloFacturaCompra()
    End Sub

    Public Sub New(idFacturaComMonedas As Integer, tipoCambio As Double, importeNeto As Double, descuentoGral As Double, baseImponible As Double,
                   iVA As Double, importeTotal As Double, eliminado As String, ascFacturaCompra As ModeloFacturaCompra, err As Errores)
        MyBase.New(New TransaccionesFacturaComMonedas(), "FACTURA COMPRA MONEDAS")

        Me.IdFacturaComMonedas = idFacturaComMonedas
        Me.TipoCambio = tipoCambio
        Me.ImporteNeto = importeNeto
        Me.DescuentoGral = descuentoGral
        Me.BaseImponible = baseImponible
        Me.IVA = iVA
        Me.ImporteTotal = importeTotal
        Me.Eliminado = eliminado
        Me.AscFacturaCompra = ascFacturaCompra
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdFacturaComMonedas As Integer
        Get
            Return _idFacturaComMonedas
        End Get
        Set(value As Integer)
            _idFacturaComMonedas = value
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

    Public Property AscFacturaCompra As ModeloFacturaCompra
        Get
            Return _ascFacturaCompra
        End Get
        Set(value As ModeloFacturaCompra)
            _ascFacturaCompra = value
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

    Public Function EliminarPorIdFacturaCompra() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"
        detalleOperacion = "ELIMINAR LOS REGISTROS IDENTIFICADOS POR LA ID FACTURA COMPRA"

        EjecutarTransaccion("EliminarPorIdFacturaCompra", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + AscFacturaCompra.IdFacturaCompra.ToString() + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ConsultarPorIdFacturaCompra() As ModeloFacturaComMonedas
        Dim resultado As New TablaFacturaComMonedas

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR REGISTRO REMITOS COMPRA MONEDAS IDENTIFICADO POR ID REMITOS COMPRA"

        EjecutarTransaccion("ConsultarPorIdFacturaCompra", resultado)

        If Not IsNothing(resultado) Then
            Return New ModeloFacturaComMonedas With {
                    .IdFacturaComMonedas = resultado.idFacturaComMonedas,
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
#End Region

#Region "METODOS PRIVADOS"
    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(New TablaFacturaComMonedas With {
                                                                .TipoCambio = TipoCambio,
                                                                .ImporteNeto = ImporteNeto,
                                                                .DescuentoGral = DescuentoGral,
                                                                .BaseImponible = BaseImponible,
                                                                .IVA = IVA,
                                                                .ImporteTotal = ImporteTotal,
                                                                .Eliminado = Eliminado,
                                                                .ascFacturaCompra = New TablaFacturaCompra With {.idFacturaCompra = AscFacturaCompra.IdFacturaCompra}
                                                           })
                Case "EliminarPorIdFacturaCompra"
                    resultado = Me.Transaccion.elimRegistroPorIdFacturaCompra(AscFacturaCompra.IdFacturaCompra)
                Case "ConsultarPorIdFacturaCompra"
                    resultado = Me.Transaccion.verRegistrosPorIdFacturaCompra(AscFacturaCompra.IdFacturaCompra)
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
