﻿Public Class TablaUsuarios
    Public Property idUsuario As Integer
    Public Property FechaAlta As Date
    Public Property Nombre As String
    Public Property Tipo As String
    Public Property Contraseña As String
    Public Property Imagen As String
    Public Property Estado As String
    Public Property Token As String
    Public Property Eliminado As String
    Public Property ascPerfilUs As TablaPerfilUsuario

    Public Sub New()
        ascPerfilUs = New TablaPerfilUsuario
    End Sub
End Class
