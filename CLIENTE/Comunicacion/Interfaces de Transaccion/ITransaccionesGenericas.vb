Public Interface ITransaccionesGenericas(Of Entidad As Class)
    Function verRegistros() As Task(Of List(Of Entidad))
    Function insRegistro(param As Entidad) As Task
    Function modRegistro(param As Entidad) As Task
    Function elimRegistro(id As Integer) As Task
End Interface
