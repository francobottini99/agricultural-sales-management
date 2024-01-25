Imports AccesoDatos

Public Class ModeloRegistroOperaciones
    Inherits EnlaceTransacciones(Of TransaccionesRegistroOperaciones)

    Private _idRegistroOperaciones As Integer
    Private _Fecha As Date
    Private _Hora As Date
    Private _Operacion As String
    Private _DetalleOperacion As String
    Private _TablasAfectadas As String
    Private _ProcedimientoAlmacenado As String
    Private _DocumentosEmitidos As String
    Private _ReportesEmitidos As String
    Private _ResultadoOperacion As String
    Private _DetalleResultado As String
    Private _ascUsuarios As ModeloUsuario
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesRegistroOperaciones(), "REGISTRO OPERACIONES")

        AscUsuarios = New ModeloUsuario()
        Err = New Errores()
    End Sub

    Public Sub New(idRegistroOperaciones As Integer, fecha As Date, hora As Date, operacion As String, detalleOperacion As String,
                   tablasAfectadas As String, procedimientoAlmacenado As String, documentosEmitidos As String, reportesEmitidos As String,
                   resultadoOperacion As String, detalleResultado As String, ascUsuarios As ModeloUsuario, err As Errores)
        MyBase.New(New TransaccionesRegistroOperaciones(), "REGISTRO OPERACIONES")

        Me.IdRegistroOperaciones = idRegistroOperaciones
        Me.Fecha = fecha
        Me.Hora = hora
        Me.Operacion = operacion
        Me.DetalleOperacion = detalleOperacion
        Me.TablasAfectadas = tablasAfectadas
        Me.ProcedimientoAlmacenado = procedimientoAlmacenado
        Me.DocumentosEmitidos = documentosEmitidos
        Me.ReportesEmitidos = reportesEmitidos
        Me.ResultadoOperacion = resultadoOperacion
        Me.DetalleResultado = detalleResultado
        Me.AscUsuarios = ascUsuarios
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdRegistroOperaciones As Integer
        Get
            Return _idRegistroOperaciones
        End Get
        Set(value As Integer)
            _idRegistroOperaciones = value
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

    Public Property Hora As Date
        Get
            Return _Hora
        End Get
        Set(value As Date)
            _Hora = value
        End Set
    End Property

    Public Shadows Property Operacion As String
        Get
            Return _Operacion
        End Get
        Set(value As String)
            _Operacion = value
        End Set
    End Property

    Public Shadows Property DetalleOperacion As String
        Get
            Return _DetalleOperacion
        End Get
        Set(value As String)
            _DetalleOperacion = value
        End Set
    End Property

    Public Property TablasAfectadas As String
        Get
            Return _TablasAfectadas
        End Get
        Set(value As String)
            _TablasAfectadas = value
        End Set
    End Property

    Public Property ProcedimientoAlmacenado As String
        Get
            Return _ProcedimientoAlmacenado
        End Get
        Set(value As String)
            _ProcedimientoAlmacenado = value
        End Set
    End Property

    Public Shadows Property DocumentosEmitidos As String
        Get
            Return _DocumentosEmitidos
        End Get
        Set(value As String)
            _DocumentosEmitidos = value
        End Set
    End Property

    Public Shadows Property ReportesEmitidos As String
        Get
            Return _ReportesEmitidos
        End Get
        Set(value As String)
            _ReportesEmitidos = value
        End Set
    End Property

    Public Property ResultadoOperacion As String
        Get
            Return _ResultadoOperacion
        End Get
        Set(value As String)
            _ResultadoOperacion = value
        End Set
    End Property

    Public Shadows Property DetalleResultado As String
        Get
            Return _DetalleResultado
        End Get
        Set(value As String)
            _DetalleResultado = value
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

#Region "METODOS"
    Public Function Insertar() As Boolean
        Dim resultado As Integer

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
#End Region

#Region "METODOS PRIVADOS"
    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(New TablaRegistroOpreaciones With {
                                    .Fecha = Fecha,
                                    .Hora = Hora,
                                    .Operacion = Operacion,
                                    .DetalleOperacion = DetalleOperacion,
                                    .TablasAfectadas = TablasAfectadas,
                                    .ProcedimientoAlmacenado = ProcedimientoAlmacenado,
                                    .DocumentosEmitidos = DocumentosEmitidos,
                                    .ReportesEmitidos = ReportesEmitidos,
                                    .ResultadoOperacion = ResultadoOperacion,
                                    .DetalleResultado = DetalleResultado,
                                    .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios}
                                })
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
            DetalleResultado = Err.Descripcion

            If transaccion <> "Insertar" Then
                AñadirOperacion()
            End If
        End Try
    End Sub
#End Region

End Class
