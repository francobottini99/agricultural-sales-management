CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaRemitado_idPedidosDetalle`(
	in idDetPed int(11)
)
BEGIN
	SELECT
		Sum(Movimientos_Reserva_Remito.Cantidad) as CantidadRemitada
	FROM
		Movimientos_Reserva_Remito JOIN PedidosMovimientos ON Movimientos_Reserva_Remito.PedidosMovimientos_idPedidosMovimientos = PedidosMovimientos.idPedidosMovimientos
	WHERE 
		PedidosMovimientos.PedidosDetalle_idPedidosDetalle = idDetPed AND Movimientos_Reserva_Remito.Tipo = "REMITADO" AND Movimientos_Reserva_Remito.Eliminado = "NO";
END