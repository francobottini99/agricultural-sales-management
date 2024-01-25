Public Interface ITransaccionesGenericas(Of Entidad As Class)
    Function verRegistros() As List(Of Entidad)
    Function insRegistro(param As Entidad) As Integer
    Function modRegistro(param As Entidad) As Integer
    Function elimRegistro(id As Integer) As Integer
End Interface
