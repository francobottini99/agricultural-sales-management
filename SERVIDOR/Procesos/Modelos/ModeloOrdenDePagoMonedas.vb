Imports AccesoDatos

Public Class ModeloOrdenDePagoMonedas
    Inherits EnlaceTransacciones(Of TransaccionesOrdenDePagoMonedas)

    Private _idOrdenDePagoMonedas As Integer
    Private _TipoCambio As Double
    Private _ImporteNeto As Double
    Private _DescuentoGral As Double
    Private _BaseImponible As Double
    Private _IVA As Double
    Private _ImporteTotal As Double
    Private _Eliminado As String
    Private _ascOrdenDePago As ModeloOrdenDePago
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesOrdenDePagoMonedas(), "ORDEN DE PAGO MONEDAS")

        Err = New Errores()
        AscOrdenDePago = New ModeloOrdenDePago()
    End Sub

    Public Sub New(idOrdenDePagoMonedas As Integer, tipoCambio As Double, importeNeto As Double, descuentoGral As Double,
                   baseImponible As Double, iVA As Double, importeTotal As Double, eliminado As String, ascOrdenDePago As ModeloOrdenDePago, err As Errores)
        MyBase.New(New TransaccionesOrdenDePagoMonedas(), "ORDEN DE PAGO MONEDAS")

        Me.IdOrdenDePagoMonedas = idOrdenDePagoMonedas
        Me.TipoCambio = tipoCambio
        Me.ImporteNeto = importeNeto
        Me.DescuentoGral = descuentoGral
        Me.BaseImponible = baseImponible
        Me.IVA = iVA
        Me.ImporteTotal = importeTotal
        Me.Eliminado = eliminado
        Me.AscOrdenDePago = ascOrdenDePago
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdOrdenDePagoMonedas As Integer
        Get
            Return _idOrdenDePagoMonedas
        End Get
        Set(value As Integer)
            _idOrdenDePagoMonedas = value
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

    Public Property AscOrdenDePago As ModeloOrdenDePago
        Get
            Return _ascOrdenDePago
        End Get
        Set(value As ModeloOrdenDePago)
            _ascOrdenDePago = value
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
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdOrdenDePagoMonedas.ToString() + "] en la tabla " + tabla

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
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdOrdenDePagoMonedas.ToString() + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloOrdenDePagoMonedas)
        Dim resultado As New List(Of TablaOrdenDePagoMonedas)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE ORDENES DE PAGO MONEDAS"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloOrdenDePagoMonedas(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function
    Public Function EliminarPorIdOrdenDePago() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"
        detalleOperacion = "ELIMINAR LOS REGISTROS IDENTIFICADOS POR LA ID ORDEN DE PAGO"

        EjecutarTransaccion("EliminarPorIdOrdenDePago", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                If Err.Descripcion = "-" Then
                    Err.Identificador = EnumErrores.ERROR_INFORMACION
                    Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdOrdenDePagoMonedas.ToString() + "] de la tabla " + tabla
                End If

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ConsultarPorIdOrdenDePago() As List(Of ModeloOrdenDePagoMonedas)
        Dim resultado As New List(Of TablaOrdenDePagoMonedas)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR REGISTROS IDENTIFICADOS POR ID ORDEN DE PAGO"

        EjecutarTransaccion("ConsultarPorIdOrdenDePago", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloOrdenDePagoMonedas(resultado)
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
    Private Function listModeloOrdenDePagoMonedas(objeto As List(Of TablaOrdenDePagoMonedas)) As List(Of ModeloOrdenDePagoMonedas)
        Dim ordenesDePagoMonedas As New List(Of ModeloOrdenDePagoMonedas)

        For Each item In objeto
            ordenesDePagoMonedas.Add(Drivers.OrdenDePagoMonedas(item))
        Next

        Return ordenesDePagoMonedas
    End Function

    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(Drivers.OrdenDePagoMonedas(Me))
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(Drivers.OrdenDePagoMonedas(Me))
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdOrdenDePagoMonedas)
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case "EliminarPorIdOrdenDePago"
                    resultado = Me.Transaccion.elimRegistroPorIdOrdenDePago(AscOrdenDePago.IdOrdenDePago)
                Case "ConsultarPorIdOrdenDePago"
                    resultado = Me.Transaccion.verRegistroPorIdOrdenDePago(AscOrdenDePago.IdOrdenDePago)
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
