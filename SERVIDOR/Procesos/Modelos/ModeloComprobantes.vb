Imports AccesoDatos

Public Class ModeloComprobantes
    Inherits EnlaceTransacciones(Of TransaccionesComprobantes)

    Private _idComprobantes As Integer
    Private _Nombre As String
    Private _Tipo As String
    Private _Copias As Integer
    Private _Leyenda As String
    Private _Encabezado As String
    Private _LeyendaEnc As String
    Private _Pie As String
    Private _LeyendaPie As String
    Private _CantidadCompEmitidos As Integer
    Private _CantidadCopiasComp As Integer
    Private _Eliminado As String
    Private _ascUsuarios As ModeloUsuario
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesComprobantes(), "COMPROBANTES")

        Err = New Errores()
        AscUsuarios = New ModeloUsuario()
    End Sub

    Public Sub New(idComprobantes As Integer, nombre As String, tipo As String, copias As Integer, leyenda As String, encabezado As String,
                   leyendaEnc As String, pie As String, leyendaPie As String, cantidadCompEmitidos As Integer, cantidadCopiasComp As Integer,
                   eliminado As String, ascUsuarios As ModeloUsuario, err As Errores)
        MyBase.New(New TransaccionesComprobantes(), "COMPROBANTES")

        Me.IdComprobantes = idComprobantes
        Me.Nombre = nombre
        Me.Tipo = tipo
        Me.Copias = copias
        Me.Leyenda = leyenda
        Me.Encabezado = encabezado
        Me.LeyendaEnc = leyendaEnc
        Me.Pie = pie
        Me.LeyendaPie = leyendaPie
        Me.CantidadCompEmitidos = cantidadCompEmitidos
        Me.CantidadCopiasComp = cantidadCopiasComp
        Me.Eliminado = eliminado
        Me.AscUsuarios = ascUsuarios
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdComprobantes As Integer
        Get
            Return _idComprobantes
        End Get
        Set(value As Integer)
            _idComprobantes = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return _Tipo
        End Get
        Set(value As String)
            _Tipo = value
        End Set
    End Property

    Public Property Copias As Integer
        Get
            Return _Copias
        End Get
        Set(value As Integer)
            _Copias = value
        End Set
    End Property

    Public Property Leyenda As String
        Get
            Return _Leyenda
        End Get
        Set(value As String)
            _Leyenda = value
        End Set
    End Property

    Public Property Encabezado As String
        Get
            Return _Encabezado
        End Get
        Set(value As String)
            _Encabezado = value
        End Set
    End Property

    Public Property LeyendaEnc As String
        Get
            Return _LeyendaEnc
        End Get
        Set(value As String)
            _LeyendaEnc = value
        End Set
    End Property

    Public Property Pie As String
        Get
            Return _Pie
        End Get
        Set(value As String)
            _Pie = value
        End Set
    End Property

    Public Property LeyendaPie As String
        Get
            Return _LeyendaPie
        End Get
        Set(value As String)
            _LeyendaPie = value
        End Set
    End Property

    Public Property CantidadCompEmitidos As Integer
        Get
            Return _CantidadCompEmitidos
        End Get
        Set(value As Integer)
            _CantidadCompEmitidos = value
        End Set
    End Property

    Public Property CantidadCopiasComp As Integer
        Get
            Return _CantidadCopiasComp
        End Get
        Set(value As Integer)
            _CantidadCopiasComp = value
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
                Err.Identificador = EnumErrores.ERROR_INFORMACION
                Err.Descripcion = "No se pudo modificar el registro [ID: " + IdComprobantes + "] en la tabla " + tabla

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
                Err.Descripcion = "No se pudo eliminar el registro [ID: " + IdComprobantes + "] de la tabla " + tabla

                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function ListadoCompleto() As List(Of ModeloComprobantes)
        Dim resultado As New List(Of TablaComprobantes)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE COMPROBANTES"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloComprobantes(resultado)
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
    Private Function listModeloComprobantes(objeto As List(Of TablaComprobantes)) As List(Of ModeloComprobantes)
        Dim comprobantes As New List(Of ModeloComprobantes)

        For Each item In objeto
            comprobantes.Add(New ModeloComprobantes With {
                                .IdComprobantes = item.idComprobantes,
                                .Nombre = item.Nombre,
                                .Copias = item.Copias,
                                .Tipo = item.Tipo,
                                .Leyenda = item.Leyenda,
                                .Encabezado = item.Encabezado,
                                .LeyendaEnc = item.LeyendaEnc,
                                .Pie = item.Pie,
                                .LeyendaPie = item.LeyendaPie,
                                .CantidadCompEmitidos = item.CantidadCompEmitidos,
                                .CantidadCopiasComp = item.CantidadCopiasComp,
                                .Eliminado = item.Eliminado,
                                .AscUsuarios = New ModeloUsuario With {.IdUsuarios = item.ascUsuarios.idUsuario}
                             })
        Next

        Return comprobantes
    End Function

    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "Insertar"
                    resultado = Me.Transaccion.insRegistro(New TablaComprobantes With {
                                                                .Nombre = Nombre,
                                                                .Copias = Copias,
                                                                .Tipo = Tipo,
                                                                .Leyenda = Leyenda,
                                                                .Encabezado = Encabezado,
                                                                .LeyendaEnc = LeyendaEnc,
                                                                .Pie = Pie,
                                                                .LeyendaPie = LeyendaPie,
                                                                .CantidadCompEmitidos = CantidadCompEmitidos,
                                                                .CantidadCopiasComp = CantidadCopiasComp,
                                                                .Eliminado = Eliminado,
                                                                .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios}
                                                           })
                Case "Modificar"
                    resultado = Me.Transaccion.modRegistro(New TablaComprobantes With {
                                                                .idComprobantes = IdComprobantes,
                                                                .Nombre = Nombre,
                                                                .Copias = Copias,
                                                                .Tipo = Tipo,
                                                                .Leyenda = Leyenda,
                                                                .Encabezado = Encabezado,
                                                                .LeyendaEnc = LeyendaEnc,
                                                                .Pie = Pie,
                                                                .LeyendaPie = LeyendaPie,
                                                                .CantidadCompEmitidos = CantidadCompEmitidos,
                                                                .CantidadCopiasComp = CantidadCopiasComp,
                                                                .Eliminado = Eliminado,
                                                                .ascUsuarios = New TablaUsuarios With {.idUsuario = AscUsuarios.IdUsuarios}
                                                           })
                Case "Eliminar"
                    resultado = Me.Transaccion.elimRegistro(IdComprobantes)
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
