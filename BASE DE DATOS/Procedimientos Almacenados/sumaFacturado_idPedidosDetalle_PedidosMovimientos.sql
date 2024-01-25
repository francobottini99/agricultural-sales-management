CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaFacturado_idPedidosDetalle_PedidosMovimientos`(
	in idDetPed int(11)
)
BEGIN
	SELECT
		Sum(Cantidad) as CantidadFacturada
	FROM
		PedidosMovimientos
	WHERE 
		PedidosDetalle_idPedidosDetalle = idDetPed AND Tipo = "FACTURADO" AND Eliminado = "NO";
END