CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdPedidosMovimientos`()
BEGIN
	SELECT
		Max(idPedidosMovimientos) as UltimoId
	FROM
		PedidosMovimientos;
END