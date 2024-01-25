CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaFacturado_idFacturaVentaDetalle`(
	in idDetFac int(11)
)
BEGIN
	SELECT
		Sum(Cantidad) as CantidadFacturada
	FROM
		FacturaVentaMovimientos
	WHERE 
		FacturaVentaDetalle_idFacturaVentaDetalle = idDetFac AND Tipo = "FACTURADO" AND Eliminado = "NO";
END