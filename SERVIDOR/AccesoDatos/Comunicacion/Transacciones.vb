Imports MySql.Data.MySqlClient

Public Class Transacciones
    Inherits Conexion

    Protected parametros As List(Of MySqlParameter)
    Private Shared Transaccion As MySqlTransaction

    Public Property ProcedimientoAlmacenado As String
    Public Shared Property enTransaccion As Boolean
    Public Shared Property Conn As MySqlConnection

    Public Sub New()
        parametros = New List(Of MySqlParameter)
    End Sub

    Public Sub BeginTransaction()
        If IsNothing(Conn) Then
            Conn = ObtenerConexion()
        End If

        Conn.Open()

        Transaccion = Conn.BeginTransaction()

        enTransaccion = True
    End Sub

    Public Sub Rollback()
        transaccion.Rollback()
        Conn.Close()

        enTransaccion = False
    End Sub

    Public Sub Commit()
        transaccion.Commit()
        Conn.Close()

        enTransaccion = False
    End Sub

    Protected Function ExecuteNonQuery(ProcedimientoAlmacenado As String) As Integer
        Me.ProcedimientoAlmacenado = ProcedimientoAlmacenado.Substring(ProcedimientoAlmacenado.IndexOf(".") + 1)

        If enTransaccion Then
            Return NonQuery(ProcedimientoAlmacenado, Conn)
        Else
            Using Conn = ObtenerConexion()
                Return NonQuery(ProcedimientoAlmacenado, Conn)
            End Using
        End If
    End Function

    Protected Function ExecuteReader(ProcedimientoAlmacenado As String) As DataTable
        Me.ProcedimientoAlmacenado = ProcedimientoAlmacenado.Substring(ProcedimientoAlmacenado.IndexOf(".") + 1)

        If enTransaccion Then
            Return Reader(ProcedimientoAlmacenado, Conn)
        Else
            Using Conn = ObtenerConexion()
                Return Reader(ProcedimientoAlmacenado, Conn)
            End Using
        End If
    End Function

    Private Function Reader(ProcedimientoAlmacenado As String, ByRef conn As MySqlConnection) As DataTable
        Using Cmd As MySqlCommand = New MySqlCommand(ProcedimientoAlmacenado, conn)
            Cmd.CommandType = CommandType.StoredProcedure

            If parametros.Count > 0 Then
                For Each item As MySqlParameter In parametros
                    Cmd.Parameters.Add(item)
                Next
            End If

            If Not enTransaccion Then
                conn.Open()
            End If

            Using Sdr As MySqlDataReader = Cmd.ExecuteReader()
                Using tabla As DataTable = New DataTable
                    tabla.Load(Sdr)

                    parametros.Clear()

                    Return tabla
                End Using
            End Using
        End Using
    End Function

    Private Function NonQuery(ProcedimientoAlmacenado As String, ByRef conn As MySqlConnection) As Integer
        Using Cmd As MySqlCommand = New MySqlCommand(ProcedimientoAlmacenado, conn)
            Cmd.CommandType = CommandType.StoredProcedure

            For Each item As MySqlParameter In parametros
                Cmd.Parameters.Add(item)
            Next

            If Not enTransaccion Then
                conn.Open()
            End If

            Dim resultado As Integer = Cmd.ExecuteNonQuery()

            parametros.Clear()

            Return resultado
        End Using
    End Function
End Class
