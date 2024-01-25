CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdPedidos`()
BEGIN
	SELECT
		Max(idPedidos) as UltimoId
	FROM
		Pedidos;
END