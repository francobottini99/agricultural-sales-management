Imports Comunicacion

Public Class TareasDetalleCheque
    Inherits EnlaceTransacciones(Of TransaccionesDetalleCheques)

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
    Public Async Function Insertar(_DetalleChequq As DetalleCheque) As Task(Of Boolean)
        Try
            Await Transaccion.insRegistro(Drivers.DetalleCheque(_DetalleChequq))

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

    Public Async Function Modificar(_DetalleChequq As DetalleCheque) As Task(Of Boolean)
        Try
            Await Transaccion.modRegistro(Drivers.DetalleCheque(_DetalleChequq))

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

    Public Async Function EliminarIdChequera(idChequera As Integer) As Task(Of Boolean)
        Try
            Await Transaccion.elimChequePorIdChequera(idChequera)

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

    Public Async Function ListadoIdChequera(idChequera As Integer) As Task(Of List(Of DetalleCheque))
        Try
            Dim list As New List(Of DetalleCheque)

            For Each item In Await Transaccion.verDetalleChequePorChequera(idChequera)
                list.Add(Drivers.DetalleCheque(item))
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

    Public Async Function ListadoIdChequeraEnDisponibilidad(idChequera As Integer) As Task(Of List(Of DetalleCheque))
        Try
            Dim list As New List(Of DetalleCheque)

            For Each item In Await Transaccion.verDetalleChequePorChequera(idChequera)
                If item.EnDisponiblidad = "SI" Then
                    list.Add(Drivers.DetalleCheque(item))
                End If
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
