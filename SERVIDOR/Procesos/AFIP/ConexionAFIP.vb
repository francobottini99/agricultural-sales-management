Imports System.IO
Imports WSAFIPFE

Public Class ConexionAFIP
    Private FE As Factura

    Private ReadOnly Licencia As String = ""
    Private ReadOnly CertificadoPC As String = "C:\Users\Sitrabo\Documents\El Atardecer\certificadoHomologacion1_Elatardecer.pfx"
    Private ReadOnly ClaveCertificado As String = "cjb23"
    Private ReadOnly DireccionTicket As String = "C:\Users\Sitrabo\Documents\El Atardecer\Ticket.txt"

    Private ReadOnly ModoTrabajo As Factura.modoFiscal
    Private ReadOnly TipoCbte As Factura.TipoComprobante
    Private ReadOnly Cuit As String
    Private ReadOnly PtoVta As Integer

    Public Property NroComprobanteAutorizado As Integer

    Public Sub New(modoTrabajo As Factura.modoFiscal, cuit As String, ptoVta As Integer, tipoCbte As Factura.TipoComprobante)
        Me.ModoTrabajo = modoTrabajo
        Me.Cuit = cuit
        Me.PtoVta = ptoVta
        Me.TipoCbte = tipoCbte
        NroComprobanteAutorizado = Nothing
    End Sub

    Public Function NuevaSesionAFIP() As Factura
        FE = New Factura()

        If IniciarSesion() Then
            Dim ticket As String = ObtenerTicket()

            If Not IsNothing(ticket) Then
                Dim nroAutorizado As Integer = ObtenerNroAutorizado()

                If nroAutorizado > 0 Then
                    NroComprobanteAutorizado = nroAutorizado

                    Return FE
                Else
                    Throw New Exception(FE.UltimoMensajeError & " - " & FE.F1RespuestaDetalleObservacionMsg)
                End If
            Else
                Throw New Exception(FE.UltimoMensajeError & " - " & FE.F1RespuestaDetalleObservacionMsg)
            End If
        Else
            Throw New Exception(FE.UltimoMensajeError & " - " & FE.F1RespuestaDetalleObservacionMsg)
        End If
    End Function

    Private Function IniciarSesion() As Boolean
        FE.ArchivoCertificadoPassword = ClaveCertificado

        Return FE.iniciar(ModoTrabajo, UtilidadesVarias.quitarGuiones(Cuit), CertificadoPC, Licencia)
    End Function

    Private Function ObtenerTicket() As String
        Dim ticket As String = RecuperarTicket()

        If ticket <> "" Then
            FE.f1RestaurarTicketAcceso(ticket)
        End If

        If Not FE.f1TicketEsValido Then
            If FE.f1ObtenerTicketAcceso() Then
                ticket = FE.f1GuardarTicketAcceso()

                GuardarTicket(ticket)

                Return ticket
            Else
                Return Nothing
            End If
        Else
            Return ticket
        End If
    End Function

    Private Function ObtenerNroAutorizado() As Integer
        Return FE.F1CompUltimoAutorizado(PtoVta, TipoCbte) + 1
    End Function

    Private Sub GuardarTicket(ticket As String)
        Dim fs As FileStream

        If File.Exists(DireccionTicket) Then
            File.Delete(DireccionTicket)
        End If

        fs = File.Create(DireccionTicket)
        fs.Close()

        Dim escribir As New StreamWriter(DireccionTicket)

        escribir.WriteLine(ticket)
        escribir.Close()
    End Sub

    Private Function RecuperarTicket() As String
        Dim leer As New StreamReader(DireccionTicket)
        Dim ticket As String = ""

        While leer.Peek <> -1
            Dim linea As String = leer.ReadLine()

            If String.IsNullOrEmpty(linea) Then
                Continue While
            End If

            ticket += linea
        End While

        leer.Close()

        Return ticket
    End Function
End Class
