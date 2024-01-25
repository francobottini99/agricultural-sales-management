Public Class ExcepcionError
    Inherits ApplicationException
    Public Property Err As Errores

    Sub New(_Err As Errores)
        Err = _Err
    End Sub
End Class
