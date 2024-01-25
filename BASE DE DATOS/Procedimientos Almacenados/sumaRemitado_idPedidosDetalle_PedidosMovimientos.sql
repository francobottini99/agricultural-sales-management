CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaRemitado_idPedidosDetalle_PedidosMovimientos`(
	in idDetPed int(11)
)
BEGIN
	SELECT
		Sum(Cantidad) as CantidadRemitada
	FROM
		PedidosMovimientos
	WHERE 
		PedidosDetalle_idPedidosDetalle = idDetPed AND Tipo = "REMITADO" AND Eliminado = "NO";
END