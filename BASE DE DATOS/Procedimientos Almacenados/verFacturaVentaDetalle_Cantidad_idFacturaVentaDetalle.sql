CREATE DEFINER=`root`@`localhost` PROCEDURE `verFacturaVentaDetalle_Cantidad_idFacturaVentaDetalle`(
	in idDetFac int(11)
)
BEGIN
	SELECT
		FacturaVentaDetalle.Cantidad
	FROM
		FacturaVentaDetalle
	WHERE
		idFacturaVentaDetalle = idDetFac And Eliminado = "NO";
END