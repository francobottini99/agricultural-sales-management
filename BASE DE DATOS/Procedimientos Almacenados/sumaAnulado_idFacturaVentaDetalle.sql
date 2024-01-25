CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaAnulado_idFacturaVentaDetalle`(
	in idDetFac int(11)
)
BEGIN
	SELECT
		Sum(Cantidad) as CantidadAnulada
	FROM
		FacturaVentaMovimientos
	WHERE 
		FacturaVentaDetalle_idFacturaVentaDetalle = idDetFac AND Tipo = "ANULADO" AND Eliminado = "NO";
END