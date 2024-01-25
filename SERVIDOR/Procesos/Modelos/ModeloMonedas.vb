Imports AccesoDatos

Public Class ModeloMonedas
    Inherits EnlaceTransacciones(Of TransaccionesMonedas)

    Private _idMonedas As Integer
    Private _Tipo As String
    Private _Moneda As String
    Private _Simbolo As String
    Private _Eliminado As String
    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        MyBase.New(New TransaccionesMonedas(), "MONEDAS")

        Err = New Errores()
    End Sub

    Public Sub New(idMonedas As Integer, tipo As String, moneda As String, simbolo As String, eliminado As String, err As Errores)
        MyBase.New(New TransaccionesMonedas(), "MONEDAS")

        Me.IdMonedas = idMonedas
        Me.Tipo = tipo
        Me.Moneda = moneda
        Me.Simbolo = simbolo
        Me.Eliminado = eliminado
        Me.Err = err
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property IdMonedas As Integer
        Get
            Return _idMonedas
        End Get
        Set(value As Integer)
            _idMonedas = value
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

    Public Property Moneda As String
        Get
            Return _Moneda
        End Get
        Set(value As String)
            _Moneda = value
        End Set
    End Property

    Public Property Simbolo As String
        Get
            Return _Simbolo
        End Get
        Set(value As String)
            _Simbolo = value
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
    Public Function ListadoCompleto() As List(Of ModeloMonedas)
        Dim resultado As New List(Of TablaMonedas)

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR EL LISTADO COMPLETO DE MONEDAS"

        EjecutarTransaccion("ListadoCompleto", resultado)

        If Not IsNothing(resultado) Then
            Return listModeloMonedas(resultado)
        Else
            If Err.Descripcion = "-" Then
                Err.Identificador = EnumErrores.REGISTRO_NO_ENCONTRADO
                Err.Descripcion = "No se pudo obtener el listado completo de la tabla " + tabla
            End If

            Return Nothing
        End If
    End Function

    Public Function ConsultarPorNombre() As ModeloMonedas
        Dim resultado As New TablaMonedas

        operacion = "CONSULTAR"
        detalleOperacion = "CONSULTAR UN REGISTRO DE LA TABLA MONEDAS ESPECIFICADO POR SI ID"

        EjecutarTransaccion("ConsultarPorNombre", resultado)

        If Not IsNothing(resultado) Then
            Return New ModeloMonedas With {
                    .IdMonedas = resultado.idMonedas,
                    .Tipo = resultado.Tipo,
                    .Moneda = resultado.Moneda,
                    .Simbolo = resultado.Simbolo
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
    Private Function listModeloMonedas(objeto As List(Of TablaMonedas)) As List(Of ModeloMonedas)
        Dim monedas As New List(Of ModeloMonedas)

        For Each item In objeto
            monedas.Add(New ModeloMonedas With {
                            .IdMonedas = item.idMonedas,
                            .Tipo = item.Tipo,
                            .Moneda = item.Moneda,
                            .Simbolo = item.Simbolo
                        })
        Next

        Return monedas
    End Function

    Private Sub EjecutarTransaccion(transaccion As String, ByRef resultado As Object)
        Err = New Errores()

        Try
            Select Case transaccion
                Case "ListadoCompleto"
                    resultado = Me.Transaccion.verRegistros()
                Case "ConsultarPorNombre"
                    resultado = Me.Transaccion.verRegistroPorNombre(Moneda)
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