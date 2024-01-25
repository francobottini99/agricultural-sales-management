Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class Movimientos_RemitoCompra_FacturaCompraController
        Inherits Controller

        Private MovRemFac As ModeloMovimientos_RemitoCompra_FacturaCompra

        <HttpGet>
        <Route("Movimientos_RemitoCompra_FacturaCompra/Filtrar_idRemitosCompra/{Json}")>
        Public Function Filtrar_idRemitosCompra(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                MovRemFac = New ModeloMovimientos_RemitoCompra_FacturaCompra With {.AscRemitosCompraMovimientos = New ModeloRemitosCompraMovimientos With {.AscDetalleRemtioCompra = New ModeloDetalleRemitoCompra With {.AscRemitosCompra = New ModeloRemitosCompra With {.IdRemitosCompra = JsonConvert.DeserializeObject(Of Integer)(Json)}}}}

                Dim lista As List(Of ModeloMovimientos_RemitoCompra_FacturaCompra) = MovRemFac.ListasdoPorIdRemitosCompra()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMovimientos_RemitoCompra_FacturaCompra))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMovimientos_RemitoCompra_FacturaCompra))(Nothing, MovRemFac.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloMovimientos_RemitoCompra_FacturaCompra)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("Movimientos_RemitoCompra_FacturaCompra/Filtrar_idFacturaCompra/{Json}")>
        Public Function Filtrar_idFacturaCompra(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                MovRemFac = New ModeloMovimientos_RemitoCompra_FacturaCompra With {.AscFacturaCompraMovimientos = New ModeloFacturaCompraMovimientos With {.AscFacturaCompraDetalle = New ModeloFacturaCompraDetalle With {.AscFacturaCompra = New ModeloFacturaCompra With {.IdFacturaCompra = JsonConvert.DeserializeObject(Of Integer)(Json)}}}}

                Dim lista As List(Of ModeloMovimientos_RemitoCompra_FacturaCompra) = MovRemFac.ListasdoPorIdFacturaCompra()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMovimientos_RemitoCompra_FacturaCompra))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMovimientos_RemitoCompra_FacturaCompra))(Nothing, MovRemFac.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of ModeloMovimientos_RemitoCompra_FacturaCompra)(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace