CREATE DEFINER=`root`@`localhost` PROCEDURE `verPedidosMovimientos_idPedidosDetalle_Tipo`(
	in pmId int(11),
    in pmTip varchar(100)
)
BEGIN
	SELECT
		*
	FROM
		PedidosMovimientos
	WHERE
		Eliminado = "NO" AND PedidosDetalle_idPedidosDetalle = pmId AND Tipo = pmTip;
END