CREATE DEFINER=`root`@`localhost` PROCEDURE `verPedidosMovimientos_idPedidosDetalle`(
	in pmIdPedDet int(11)
)
BEGIN
	SELECT
		*
	FROM
		PedidosMovimientos
	WHERE
		Eliminado = "NO" AND PedidosDetalle_idPedidosDetalle = pmIdPedDet;
END