Imports AccesoDatos

Public Class ModeloDetalleCheque
    Inherits EnlaceTransacciones(Of TransaccionesDetalleCheques)

    Private _idDetalleCheque As Integer
    Private _Numero As Integer
    Private _FechaEmision As Date
    Private _FechaCobro As Date
    Private _PlazoDias As Integer
    Private _Importe As Double
    Private _Destino As String
    Private _EnDisponiblidad As String
    Private _Cobrado As String
    Private _Anulado As String
    Private _Modificado As String
    Private _Modificacion As String
    Private _Observaciones As String
    Private _Eliminado As String
    Private _ascChequera As ModeloChequera
    Private _ascUsuarios As ModeloUsuario
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesDetalleCheques(), "DETALLE CHEQUES")

        Err = New Errores()
        AscUsuarios = New ModeloUsuario()
        ascChequera = New ModeloChequera()
    End Sub

    Public Sub New(idDetalleCheque As Integer, numero As Integer, fechaEmision As Date, fechaCobro As Date, plazoDias As Integer,
                   importe As Double, destino As String, enDisponiblidad As String, anulado As String, modificado As String,
                   modificacion As String, observaciones As String, eliminado As String, ascChequera As ModeloChequera,
                   ascUsuarios As ModeloUsuario, err As Errores, Optional cobrado As String = Nothing)
        MyBase.New(New TransaccionesDetalleCheques(), "DETALLE CHEQUES")

        Me.IdDetalleCheque = idDetalleCheque
        Me.Numero = numero
        Me.FechaEmision = fechaEmision
        Me.FechaCobro = fechaCobro
        Me.PlazoDias = plazoDias
        Me.Importe = importe
        Me.Destino = destino
        Me.EnDisponiblidad = enDisponiblidad
        Me.Anulado = anulado
        Me.Modificado = modificado
        Me.Modificacion = modificacion
        Me.Observaciones = observaciones
        Me.Eliminado = eliminado
        Me.AscChequera = ascChequera
        Me.AscUsuarios = ascUsuarios
        Me.Err = err
        Me.Cobrado = cobrado
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdDetalleCheque As Integer
        Get
            Return _idDetalleCheque
        End Get
        Set(value As Integer)
            _idDetalleCheque = value
        End Set
    End Property

    Public Property Numero As Integer
        Get
            Return _Numero
        End Get
        Set(value As Integer)
            _Numero = value
        End Set
    End Property

    Public Property FechaEmision As Date
        Get
            Return _FechaEmision
        End Get
        Set(value As Date)
            _FechaEmision = value
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

    Public Property PlazoDias As Integer
        Get
            Return _PlazoDias
        End Get
        Set(value As Integer)
            _PlazoDias = value
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

    Public Property Destino As String
        Get
            Return _Destino
        End Get
        Set(value As String)
            _Destino = value
        End Set
    End Property

    Public Property EnDisponiblidad As String
        Get
            Return _EnDisponiblidad
        End Get
        Set(value As String)
            _EnDisponiblidad = value
        End Set
    End Property

    Public Property Anulado As String
        Get
            Return _Anulado
        End Get
        Set(value As String)
            _Anulado = value
        End Set
    End Property

    Public Property Modificado As String
        Get
            Return _Modificado
        End Get
        Set(value As String)
            _Modificado = value
        End Set
    End Property

    Public Property Modificacion As String
        Get
            Return _Modificacion
        End Get
        Set(value As String)
            _Modificacion = value
        End Set
    End Property

    Public Property Observaciones As String
        Get
            Return _Observaciones
        End Get
        Set(value As String)
            _Observaciones = value
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

    Public Property AscChequera As ModeloChequera
        Get
            Return _ascChequera
        End Get
        Set(value As ModeloChequera)
            _ascChequera = value
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

    Public Property Cobrado As String
        Get
            Return _Cobrado
        End Get
        Set(value As String)
            _Cobrado = value
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
        idUs = AscUsuarios.IdUsuarios

        EjecutarTransaccion("Modificar", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                If Err.Descripcion = "-" Then
                    Err.Identificador = EnumErrores.ERROR_INFORMACION
                    Err.Descripcion = "No se pudo modificar el registro [ID: " + IdDetalleCheque.ToString() + "] en la tabla " + tabla
                End If

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
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdDetalleCheque + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function EliminarPorIdChequera() As Boolean
        Dim resultado As Integer

        operacion = "ELIMINAR"
        detalleOperacion = "ELIMINA LOS REGISTRO DE LA TABLA ESPECIFICADOS POR SU ID CHEQUERA"

        EjecutarTransaccion("EliminarPorIdChequera", resultado)

        If Not IsNothing(resultado) Then
            If resultado > 0 Then
                Return True
            Else
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdDetalleCheque + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoPorIdChequera() As List(Of ModeloDetalleCheque)
        Dim resultado As New List(Of TablaDetalleCheque)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO DE CHEQUES POR ID CHEQUERA"

        EjecutarTransaccion("ListadoPorIdChequera", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloDetalleCheque(resultado)
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
    Private Function listModeloDetalleCheque(objeto As List(Of TablaDetalleCheque)) As List(Of ModeloDetalleCheque)
        Dim detalleCheques As New List(Of ModeloDetalleCheque)

        For Each item In objeto
            detalleCheques.Add(Drivers.DetalleCheque(item))
        Next

        Return detalleCheques
    End Function

    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(Drivers.DetalleCheque(Me))
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(Drivers.DetalleCheque(Me))
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdDetalleCheque)
                Case "EliminarPorIdChequera"
                    resultado = Me.Transaccion.elimChequePorIdChequera(AscChequera.IdChequera)
                Case "ListadoPorIdChequera"
                    resultado = Me.Transaccion.verDetalleChequePorChequera(AscChequera.IdChequera)
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
