Imports AccesoDatos

Public Class ModeloValoresEnCartera
    Inherits EnlaceTransacciones(Of TransaccionesValoresEnCartera)

    Private _idValoresEnCartera As Integer
    Private _TipoValor As String
    Private _Banco As String
    Private _Sucursal As String
    Private _Numero As String
    Private _Librador As String
    Private _FechaCobro As Date
    Private _Moneda As String
    Private _Importe As Double
    Private _Disponible As String
    Private _Eliminado As String
    Private _ascUsuarios As ModeloUsuario
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesValoresEnCartera(), "VALORES EN CARTERA")

        AscUsuarios = New ModeloUsuario()
    End Sub

    Public Sub New(idValoresEnCartera As Integer, tipoValor As String, moneda As String, banco As String, numero As String, librador As String, fechaCobro As Date,
                   importe As Double, disponible As String, eliminado As String, ascUsuarios As ModeloUsuario, ascBancos As ModeloBancos, err As Errores, sucursal As String)
        MyBase.New(New TransaccionesValoresEnCartera(), "VALORES EN CARTERA")

        Me.IdValoresEnCartera = idValoresEnCartera
        Me.TipoValor = tipoValor
        Me.Numero = numero
        Me.Librador = librador
        Me.FechaCobro = fechaCobro
        Me.Importe = importe
        Me.Disponible = disponible
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
        Me.Err = err
        Me.Moneda = moneda
        Me.Banco = banco
        Me.Sucursal = sucursal
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdValoresEnCartera As Integer
        Get
            Return _idValoresEnCartera
        End Get
        Set(value As Integer)
            _idValoresEnCartera = value
        End Set
    End Property

    Public Property TipoValor As String
        Get
            Return _TipoValor
        End Get
        Set(value As String)
            _TipoValor = value
        End Set
    End Property

    Public Property Numero As String
        Get
            Return _Numero
        End Get
        Set(value As String)
            _Numero = value
        End Set
    End Property

    Public Property Librador As String
        Get
            Return _Librador
        End Get
        Set(value As String)
            _Librador = value
        End Set
    End Property

    Public Property FechaCobro As Date
        Get
            Return _FechaCobro
        End Get
        Set(value As Date)
            _FechaCobro = value
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

    Public Property Disponible As String
        Get
            Return _Disponible
        End Get
        Set(value As String)
            _Disponible = value
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

    Public Property Moneda As String
        Get
            Return _Moneda
        End Get
        Set(value As String)
            _Moneda = value
        End Set
    End Property

    Public Property Banco As String
        Get
            Return _Banco
        End Get
        Set(value As String)
            _Banco = value
        End Set
    End Property

    Public Property Sucursal As String
        Get
            Return _Sucursal
        End Get
        Set(value As String)
            _Sucursal = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS"
    Public Function Insertar() As Boolean
        Dim resultado As Integer

        operacion = "INSERTAR"
        idUs = AscUsuarios.IdUsuarios

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

    Public Function Modificar() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        idUs = AscUsuarios.IdUsuarios

        EjecutarTransaccion("Modificar", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdValoresEnCartera.ToString() + "] en la tabla " + tabla

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
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdValoresEnCartera.ToString() + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloValoresEnCartera)
        Dim resultado As New List(Of TablaValoresEnCartera)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE VALORES EN CARTERA"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloValoresEnCartera(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ListadoDisponible() As List(Of ModeloValoresEnCartera)
        Dim resultado As New List(Of TablaValoresEnCartera)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO DE VALORES EN CARTERA DISPONIBLES"

        EjecutarTransaccion("ListadoDisponible", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloValoresEnCartera(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function SaldoPesos() As Double
        Dim resultado As Double

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL SALDO DE LOS VALORES EN CARTERA EN PESOS"

        EjecutarTransaccion("SaldoPesos", resultado)

        If Not IsNothing(resultado) Then
            Return resultado
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el saldo de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function SaldoDolares() As Double
        Dim resultado As Double

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL SALDO DE LOS VALORES EN CARTERA EN DOLARES"

        EjecutarTransaccion("SaldoDolares", resultado)

        If Not IsNothing(resultado) Then
            Return resultado
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el saldo de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ModificarDisponibilidad() As Boolean
        Dim resultado As Integer

        operacion = "MODIFICAR"
        detalleOperacion = "MODIFICA LA DISPONIBILIDAD DE UN VALOR EN CARTERA"

        EjecutarTransaccion("ModificarDisponibilidad", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo modificar la disponibilidad del registro [ID: " + IdValoresEnCartera.ToString() + "] en la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function UltimoId() As Integer
        Dim resultado As New TablaValoresEnCartera

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL ID DEL ULTIMO REGISTRO INGRESADO EN LA TABLA"

        EjecutarTransaccion("UltimoId", resultado)

        If Not IsNothing(resultado) Then
            Return resultado.idValoresEnCartera
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el ultimo registro de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function
#End Region

#Region "METODOS PRIVADOS"
    Private Function listModeloValoresEnCartera(objeto As List(Of TablaValoresEnCartera)) As List(Of ModeloValoresEnCartera)
        Dim valores As New List(Of ModeloValoresEnCartera)

        For Each item In objeto
            valores.Add(Drivers.ValoreEnCartera(item))
        Next

        Return valores
    End Function

    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(Drivers.ValoreEnCartera(Me))
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(Drivers.ValoreEnCartera(Me))
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdValoresEnCartera)
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case "ListadoDisponible"
                    resultado = Me.Transaccion.verListadoDisponible(Disponible)
                Case "SaldoPesos"
                    resultado = Me.Transaccion.verSaldoPesos()
                Case "SaldoDolares"
                    resultado = Me.Transaccion.verSaldoDolares()
                Case "ModificarDisponibilidad"
                    resultado = Me.Transaccion.modDisponibilidad(IdValoresEnCartera, Disponible)
                Case "UltimoId"
                    resultado = Me.Transaccion.verUltimoId()
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
