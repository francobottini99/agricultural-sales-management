Imports WSAFIPFE

Public Class Facturacion
    Private ReadOnly FE As Factura

    Public Sub New(Fe As Factura)
        Me.FE = Fe
    End Sub

    Public Function Facturar(solicitud As FERequestCAE) As FEResultCAE
        FE.F1CabeceraCantReg = solicitud.FeCabReq.CantReg
        FE.F1CabeceraCbteTipo = solicitud.FeCabReq.CbteTipo
        FE.F1CabeceraPtoVta = solicitud.FeCabReq.PtoVta

        FE.f1Indice = 0
        FE.F1DetalleConcepto = solicitud.FeDetReq.Concepto
        FE.F1DetalleDocTipo = solicitud.FeDetReq.DocTipo
        FE.F1DetalleDocNro = solicitud.FeDetReq.DocNro
        FE.F1DetalleCbteDesde = solicitud.FeDetReq.CbteDesde
        FE.F1DetalleCbteHasta = solicitud.FeDetReq.CbteHasta
        FE.F1DetalleCbteFch = solicitud.FeDetReq.CbteFch
        FE.F1DetalleImpTotal = solicitud.FeDetReq.ImpTotal
        FE.F1DetalleImpTotalConc = solicitud.FeDetReq.ImpTotConc
        FE.F1DetalleImpNeto = solicitud.FeDetReq.ImpNeto
        FE.F1DetalleImpOpEx = solicitud.FeDetReq.ImpOpEx
        FE.F1DetalleImpIva = solicitud.FeDetReq.ImpIVA
        FE.F1DetalleImpTrib = solicitud.FeDetReq.ImpTrib
        FE.F1DetalleMonId = solicitud.FeDetReq.MonId
        FE.F1DetalleMonCotiz = solicitud.FeDetReq.MonCotiz
        FE.F1DetalleFchServDesde = solicitud.FeDetReq.FchServDesde
        FE.F1DetalleFchServHasta = solicitud.FeDetReq.FchServHasta
        FE.F1DetalleFchVtoPago = solicitud.FeDetReq.FchVtoPago

        Dim indice As Integer = 0
        If Not IsNothing(solicitud.FeDetReq.CbtesAsoc) Then
            FE.F1DetalleCbtesAsocItemCantidad = solicitud.FeDetReq.CbtesAsoc.Count

            For Each item In solicitud.FeDetReq.CbtesAsoc
                FE.f1IndiceItem = indice
                FE.F1DetalleCbtesAsocTipo = item.Tipo
                FE.F1DetalleCbtesAsocPtoVta = item.PtoVta
                FE.F1DetalleCbtesAsocNro = item.Nro
                FE.F1DetalleCbtesAsocCUIT = item.Cuit
                FE.F1DetalleCbtesAsocCbteFch = item.CbteFch
                indice += 1
            Next
        End If

        indice = 0
        If Not IsNothing(solicitud.FeDetReq.Opcinales) Then
            FE.F1DetalleOpcionalItemCantidad = solicitud.FeDetReq.Opcinales.Count

            For Each item In solicitud.FeDetReq.Opcinales
                FE.f1IndiceItem = indice
                FE.F1DetalleOpcionalId = item.Id
                FE.F1DetalleOpcionalValor = item.Valor
                indice += 1
            Next
        End If

        indice = 0
        If Not IsNothing(solicitud.FeDetReq.AlicIva) Then
            FE.F1DetalleIvaItemCantidad = solicitud.FeDetReq.AlicIva.Count

            For Each item In solicitud.FeDetReq.AlicIva
                FE.f1IndiceItem = indice
                FE.F1DetalleIvaId = item.Id
                FE.F1DetalleIvaBaseImp = item.BaseImp
                FE.F1DetalleIvaImporte = item.Importe
                indice += 1
            Next
        End If

        indice = 0
        If Not IsNothing(solicitud.FeDetReq.Tributos) Then
            FE.F1DetalleTributoItemCantidad = solicitud.FeDetReq.Tributos.Count

            For Each item In solicitud.FeDetReq.Tributos
                FE.f1IndiceItem = indice
                FE.F1DetalleTributoId = item.Id
                FE.F1DetalleTributoDesc = item.Desc
                FE.F1DetalleTributoBaseImp = item.BaseImp
                FE.F1DetalleTributoAlic = item.Alic
                FE.F1DetalleTributoImporte = item.Importe
                indice += 1
            Next
        End If

        Dim resp As New FEResultCAE With {
            .Obtenido = FE.F1CAESolicitar()
        }

        If resp.Obtenido Then
            resp.CAE = FE.F1RespuestaDetalleCae
            resp.FchVtoCAE = FE.F1RespuestaDetalleCAEFchVto
            resp.DetalleResultado = FE.F1RespuestaDetalleResultado
        Else
            resp.MsgError = "[" & FE.UltimoNumeroError & "] " & FE.UltimoMensajeError
            resp.Observaciones = FE.F1RespuestaDetalleObservacionMsg
        End If

        Return resp
    End Function
End Class
