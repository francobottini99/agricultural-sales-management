CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaAnulado_idPedidosDetalle`(
	in idDetPed int(11)
)
BEGIN
	SELECT
		Sum(Cantidad) as CantidadAnulada
	FROM
		PedidosMovimientos
	WHERE 
		PedidosDetalle_idPedidosDetalle = idDetPed AND Tipo = "ANULACION" AND Eliminado = "NO";
END