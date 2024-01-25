Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class PPalController
        Inherits Controller

        <HttpGet>
        <Route("PPal/GuardarDolar/{Json}")>
        Public Function GuardarDolar(ByVal Json As String) As String
            Dim servicio As New ServicioParidadCambiaria(New ModeloMonedas(), JsonConvert.DeserializeObject(Of ModeloParidadCambiaria)(Json))

            Return JsonConvert.SerializeObject(servicio.Insertar())
        End Function
    End Class
End Namespace