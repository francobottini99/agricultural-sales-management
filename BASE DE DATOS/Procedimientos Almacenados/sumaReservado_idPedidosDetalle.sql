CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaReservado_idPedidosDetalle`(
	in idDetPed int(11)
)
BEGIN
	SELECT
		Sum(Cantidad) as CantidadReservada
	FROM
		PedidosMovimientos
	WHERE 
		PedidosDetalle_idPedidosDetalle = idDetPed AND Tipo = "RESERVA" AND Eliminado = "NO";
END