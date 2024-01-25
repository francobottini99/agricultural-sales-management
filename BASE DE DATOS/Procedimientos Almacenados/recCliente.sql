CREATE DEFINER=`root`@`localhost` PROCEDURE `recCliente`(
	in idC int(11)
)
BEGIN
	UPDATE Clientes
	SET 
		Eliminado = "NO"
	WHERE 
		idClientes = idC;
END