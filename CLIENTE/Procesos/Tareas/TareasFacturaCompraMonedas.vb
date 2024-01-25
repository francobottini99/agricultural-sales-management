Imports Comunicacion

Public Class TareasFacturaCompraMonedas
    Inherits EnlaceTransacciones(Of TransaccionesFacturaComMonedas)

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

    Public Async Function verFacturaCompraMonedas() As Task(Of List(Of FacturaCompraMonedas))
        Try
            Dim list As New List(Of FacturaCompraMonedas)

            For Each item In Await Transaccion.verRegistros()
                list.Add(Drivers.FacturaCompraMonedas(item))
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

    Public Async Function verFacturaCompraMonedasPorIDFacturaCompra(Id As Integer) As Task(Of FacturaCompraMonedas)
        Try

            Return Drivers.FacturaCompraMonedas(Await Transaccion.verRegistrosPorIdFacturaCompra(Id))

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

#End Region

End Class
