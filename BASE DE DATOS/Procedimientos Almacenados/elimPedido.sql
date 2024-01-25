CREATE DEFINER=`root`@`localhost` PROCEDURE `elimPedido`(
	in pdId int(11)
)
BEGIN
	UPDATE Pedidos
	SET 
		Eliminado = "SI"
	WHERE 
		idPedidos = pdId;
END