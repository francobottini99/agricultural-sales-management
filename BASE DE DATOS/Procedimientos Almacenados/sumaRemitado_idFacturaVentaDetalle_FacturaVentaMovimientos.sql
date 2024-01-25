CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaRemitado_idFacturaVentaDetalle_FacturaVentaMovimientos`(
	in idDetFac int(11)
)
BEGIN
	SELECT
		Sum(Cantidad) as CantidadRemitada
	FROM
		FacturaVentaMovimientos
	WHERE 
		FacturaVentaDetalle_idFacturaVentaDetalle = idDetFac AND Tipo = "REMITADO" AND Eliminado = "NO";
END