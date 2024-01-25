CREATE DEFINER=`root`@`localhost` PROCEDURE `elimPedidoMoviminetos`(
	in pdId int(11)
)
BEGIN
	UPDATE PedidosMovimientos
	SET 
		Eliminado = "SI"
	WHERE 
		idPedidosMovimientos = pdId;
END