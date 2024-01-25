CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaRetirado_idPedidosDetalle`(
	in idDetPed int(11)
)
BEGIN
	SELECT
		Sum(Cantidad) as CantidadRetirada
	FROM
		PedidosMovimientos
	WHERE 
		PedidosDetalle_idPedidosDetalle = idDetPed AND Tipo = "RETIRO" AND Eliminado = "NO";
END