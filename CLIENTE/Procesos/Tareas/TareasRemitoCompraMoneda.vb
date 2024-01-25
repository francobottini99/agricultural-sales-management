Imports Comunicacion

Public Class TareasRemitoCompraMoneda
    Inherits EnlaceTransacciones(Of TransaccionesRemitoComMonedas)

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
    Public Async Function ListadoCompleto() As Task(Of List(Of RemitoCompraMonedas))
        Try
            Dim list As New List(Of RemitoCompraMonedas)

            For Each item In Await Transaccion.verRegistros()
                list.Add(Drivers.RemitoCompraMonedas(item))
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

    Public Async Function verRemitosComMonPorID(Id) As Task(Of RemitoCompraMonedas)
        Try

            Return Drivers.RemitoCompraMonedas(Await Transaccion.verRegistroPorIdRemitosCompra(Id))

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
