Imports System.Net.Http
Imports System.Web.Http
Imports Newtonsoft.Json
Imports Procesos

Namespace Controllers
    Public Class StockController
        Inherits Controller

        Private Stock As ModeloStock

        <HttpPost>
        <Route("Stock/Insertar")>
        Public Function Insertar() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Stock = JsonConvert.DeserializeObject(Of ModeloStock)(ObtenerDatosEntrantes(Request))

                If Stock.Insertar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, Stock.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMonedas))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("Stock/UltimoID")>
        Public Function UltimoID() As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Stock = New ModeloStock()

                Dim ultId As Integer = Stock.UltimoId()

                If Not IsNothing(ultId) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Integer)(ultId, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Integer)(Nothing, Stock.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMonedas))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("Stock/StockFisico/{Json}")>
        Public Function StockFisico(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Stock = New ModeloStock With {.AscArticulos = New ModeloArticulos With {.IdArticulo = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                Dim cant As Integer = Stock.CantidadStockFisicoPorIdArticulo()

                If Not IsNothing(cant) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Integer)(cant, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Integer)(Nothing, Stock.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMonedas))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("Stock/StockFisicoDeposito/{Json}")>
        Public Function StockFisicoDeposito(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Dim IDs() As Integer = JsonConvert.DeserializeObject(Of Integer())(Json)

                Stock = New ModeloStock With {
                        .AscArticulos = New ModeloArticulos With {.IdArticulo = IDs(0)},
                        .AscDepositos = New ModeloDepositos With {.IdDeposito = IDs(1)}
                    }

                Dim cant As Integer = Stock.CantidadStockFisicoPorIdArticuloYIdDeposito()

                If Not IsNothing(cant) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Integer)(cant, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Integer)(Nothing, Stock.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMonedas))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("Stock/StockReservado/{Json}")>
        Public Function StockReservado(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Stock = New ModeloStock With {.AscArticulos = New ModeloArticulos With {.IdArticulo = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                Dim cant As Integer = Stock.CantidadStockReservadoPorIdArticulo()

                If Not IsNothing(cant) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Integer)(cant, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Integer)(Nothing, Stock.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMonedas))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("Stock/Eliminar/{Json}")>
        Public Function Eliminar(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Stock = New ModeloStock With {.IdStock = JsonConvert.DeserializeObject(Of Integer)(Json)}

                If Stock.Eliminar() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, Stock.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMonedas))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("Stock/Eliminar_Fecha_Movimiento_Cantidad_idArticulo_idDeposito/{Json}")>
        Public Function Eliminar_Fecha_Movimiento_Cantidad_idArticulo_idDeposito(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Stock = JsonConvert.DeserializeObject(Of ModeloStock)(Json)

                If Stock.EliminarPorCampos() Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(True, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of Boolean)(False, Stock.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMonedas))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function

        <HttpGet>
        <Route("Stock/Filtrar_idArticulo/{Json}")>
        Public Function Filtrar_idArticulo(ByVal Json As String) As String
            If UtilidadesVarias.VerificarToken(Request.Headers) Then
                Stock = New ModeloStock With {.AscArticulos = New ModeloArticulos With {.IdArticulo = JsonConvert.DeserializeObject(Of Integer)(Json)}}

                Dim lista As List(Of ModeloStock) = Stock.ListadoStockPorIdArticulo()

                If Not IsNothing(lista) Then
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloStock))(lista, Nothing)))
                Else
                    Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloStock))(Nothing, Stock.Err)))
                End If
            Else
                Return UtilidadesVarias.Ecy.EncryptData(JsonConvert.SerializeObject(New RespuestaHTTP(Of List(Of ModeloMonedas))(Nothing, New Errores With {.Identificador = EnumErrores.ERROR_AUTETICACION, .Descripcion = "Error de Autorizacion: No tienes acceso a la informacion solicitada"})))
            End If
        End Function
    End Class
End Namespace