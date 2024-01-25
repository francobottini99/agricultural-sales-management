Public Interface ITransaccionesProveedores
    Inherits ITransaccionesGenericas(Of ModeloProveedores)
    Function Recuperar(id As Integer) As Task
    Function verExisteProveedorNombre(nombre As String) As Task(Of String())
    Function verExisteProveedorCuit(cuit As String) As Task(Of String())
    Function verExisteProveedorNombreCuit(nombre As String, cuit As String) As Task(Of String())
    Function Servicio_insRegistro(param As ModeloProveedores) As Task
    Function Servicio_modRegistro(param As ModeloProveedores) As Task
End Interface
