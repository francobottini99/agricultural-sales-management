Public Interface ITransaccionesProveedores
    Inherits ITransaccionesGenericas(Of TablaProveedores)
    Function Recuperar(id As Integer) As Integer
    Function verExisteProveedorNombre(nombre As String) As String()
    Function verExisteProveedorCuit(cuit As String) As String()
    Function verExisteProveedorNombreCuit(nombre As String, cuit As String) As String()
    Function verRegistroPorID(id As Integer) As TablaProveedores
End Interface
