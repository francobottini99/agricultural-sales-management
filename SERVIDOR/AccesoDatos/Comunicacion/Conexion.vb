Imports MySql.Data.MySqlClient

Public MustInherit Class Conexion
    Private ReadOnly cadenaConn As String
    Protected ReadOnly dbNombre As String

    Public Sub New()
        cadenaConn = "Server=localhost;Port=5859;Uid=root;Pwd=admin@FeedLot;Database=sigeva"
        dbNombre = "sigeva"
    End Sub

    Protected Function ObtenerConexion() As MySqlConnection
        Return New MySqlConnection(cadenaConn)
    End Function
End Class
