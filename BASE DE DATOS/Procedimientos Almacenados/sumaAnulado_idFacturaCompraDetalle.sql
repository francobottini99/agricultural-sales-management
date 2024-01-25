CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaAnulado_idFacturaCompraDetalle`(
	in idDetFac int(11)
)
BEGIN
	SELECT
		Sum(Cantidad) as CantidadAnulada
	FROM
		FacturaCompraMovimientos
	WHERE 
		FacturaCompraDetalle_idFacturaCompraDetalle = idDetFac AND Tipo = "ANULADO" AND Eliminado = "NO";
END