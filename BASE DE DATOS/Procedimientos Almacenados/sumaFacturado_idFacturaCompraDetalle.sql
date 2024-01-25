CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaFacturado_idFacturaCompraDetalle`(
	in idDetFac int(11)
)
BEGIN
	SELECT
		Sum(Cantidad) as CantidadFacturada
	FROM
		FacturaCompraMovimientos
	WHERE 
		FacturaCompraDetalle_idFacturaCompraDetalle = idDetFac AND Tipo = "FACTURADO" AND Eliminado = "NO";
END
