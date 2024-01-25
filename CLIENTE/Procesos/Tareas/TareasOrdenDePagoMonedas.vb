Imports Comunicacion

Public Class TareasOrdenDePagoMonedas
    Inherits EnlaceTransacciones(Of TransaccionesOrdenDePagoMonedas)

    Private _Err As Errores

#Region "CONSTRUCTORES"
    Public Sub New()
        Err = New Errores()
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property Err As Errores
        Get
            Return _Err
        End Get
        Set(value As Errores)
            _Err = value
        End Set
    End Property
#End Region

#Region "METODOS PUBLICOS ACCESO A COMUNICACIONES"
    Public Async Function Insertar(_OrdenDePagoMonedas As OrdenDePagoMonedas) As Task(Of Boolean)
        Try
            Await Transaccion.insRegistro(Drivers.OrdenDePagoMonedas(_OrdenDePagoMonedas))

            Return True
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return False
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return False
        End Try
    End Function

    Public Async Function Modificar(_OrdenDePagoMonedas As OrdenDePagoMonedas) As Task(Of Boolean)
        Try
            Await Transaccion.modRegistro(Drivers.OrdenDePagoMonedas(_OrdenDePagoMonedas))

            Return True
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return False
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return False
        End Try
    End Function

    Public Async Function Eliminar(id As Integer) As Task(Of Boolean)
        Try
            Await Transaccion.elimRegistro(id)

            Return True
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return False
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return False
        End Try
    End Function

    Public Async Function EliminarPorIdOrdenDePago(id As Integer) As Task(Of Boolean)
        Try
            Await Transaccion.elimRegistroPorIdOrdenDePago(id)

            Return True
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return False
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return False
        End Try
    End Function

    Public Async Function ListadoCompleto() As Task(Of List(Of OrdenDePagoMonedas))
        Try
            Dim list As New List(Of OrdenDePagoMonedas)

            For Each item In Await Transaccion.verRegistros()
                list.Add(Drivers.OrdenDePagoMonedas(item))
            Next

            Return list
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return Nothing
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return Nothing
        End Try
    End Function

    Public Async Function ListadoFiltradoIdOrdenDePago(Id As Integer) As Task(Of List(Of OrdenDePagoMonedas))
        Try
            Dim list As New List(Of OrdenDePagoMonedas)

            For Each item In Await Transaccion.verRegistroPorIdOrdenDePago(Id)
                list.Add(Drivers.OrdenDePagoMonedas(item))
            Next

            Return list
        Catch ex As ExcepcionError
            Err.Descripcion = ex.Err.Descripcion
            Err.Identificador = ex.Err.Identificador

            Return Nothing
        Catch ex As Exception
            Err.Descripcion = ex.Message
            Err.Identificador = EnumErrores.ERROR_DESCONOCIDO

            Return Nothing
        End Try
    End Function
#End Region

End Class
