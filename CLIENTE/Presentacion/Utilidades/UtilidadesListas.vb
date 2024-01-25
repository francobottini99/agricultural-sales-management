Public Class UtilidadesListas
    Public Shared Function FiltarLista(Of T)(lista As List(Of T), propiedad As String, filtro As String) As List(Of T)
        Dim listFiltrada As New List(Of T)

        For Each Item In lista
            Dim propertyInfo As Reflection.PropertyInfo = Item.GetType().GetProperty(propiedad)

            If UCase(propertyInfo.GetValue(Item)).Contains(UCase(filtro)) Then
                listFiltrada.Add(Item)
            End If
        Next

        Return listFiltrada
    End Function
End Class
