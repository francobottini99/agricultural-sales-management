CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaFacturado_idPedidosDetalle`(
	in idDetPed int(11)
)
BEGIN
	SELECT
		Sum(Movimientos_Factura_Reseva.Cantidad) as CantidadFacturada
	FROM
		Movimientos_Factura_Reseva JOIN PedidosMovimientos ON Movimientos_Factura_Reseva.PedidosMovimientos_idPedidosMovimientos = PedidosMovimientos.idPedidosMovimientos
	WHERE 
		PedidosMovimientos.PedidosDetalle_idPedidosDetalle = idDetPed AND Movimientos_Factura_Reseva.Tipo = "FACTURADO" AND Movimientos_Factura_Reseva.Eliminado = "NO";
END