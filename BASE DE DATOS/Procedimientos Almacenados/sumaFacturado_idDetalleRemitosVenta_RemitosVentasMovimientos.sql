CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaFacturado_idDetalleRemitosVenta_RemitosVentasMovimientos`(
	in idDetRem int(11)
)
BEGIN
	SELECT
		Sum(Cantidad) as CantidadFacturada
	FROM
		RemitosVentasMovimientos
	WHERE 
		DetalleRemitosVenta_idDetalleRemitosVenta = idDetRem AND Tipo = "FACTURADO" AND Eliminado = "NO";
END