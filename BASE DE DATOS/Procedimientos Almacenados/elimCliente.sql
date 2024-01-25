CREATE DEFINER=`root`@`localhost` PROCEDURE `elimCliente`(
	in IdC int(11)
)
BEGIN
	UPDATE Clientes
	SET 
		Eliminado = "SI"
	WHERE 
		idClientes = IdC;
END