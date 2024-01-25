CREATE DEFINER=`root`@`localhost` PROCEDURE `elimDetallePedido_idPedidos`(
	in idP int(11)
)
BEGIN
	UPDATE PedidosDetalle
	SET 
		Eliminado = "SI"
	WHERE 
		Pedidos_idPedidos = idP;
END