Imports Comunicacion

Public Class TareasMonedas
    Inherits EnlaceTransacciones(Of TransaccionesMonedas)

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
    Public Async Function ListadoCompleto() As Task(Of List(Of Monedas))
        Try
            Dim list As New List(Of Monedas)

            For Each item In Await Transaccion.verRegistros()
                list.Add(Drivers.Monedas(item))
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

#Region "METODOS PUBLICOS UTILIDADES"
    Public Shared Function FiltrarMonedaPpal(listaMonedas As List(Of Monedas)) As Monedas
        For Each item In listaMonedas
            If item.Tipo = "Principal" Then
                Return item
            End If
        Next

        Return Nothing
    End Function

    Public Shared Function FiltrarMonedaContable(listaMonedas As List(Of Monedas)) As Monedas
        For Each item In listaMonedas
            If item.Tipo = "Contable" Then
                Return item
            End If
        Next

        Return Nothing
    End Function
#End Region

End Class
