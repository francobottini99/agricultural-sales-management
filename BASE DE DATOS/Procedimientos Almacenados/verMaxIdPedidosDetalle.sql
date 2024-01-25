CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdPedidosDetalle`()
BEGIN
	SELECT
		Max(idPedidosDetalle) as UltimoId
	FROM
		PedidosDetalle;
END