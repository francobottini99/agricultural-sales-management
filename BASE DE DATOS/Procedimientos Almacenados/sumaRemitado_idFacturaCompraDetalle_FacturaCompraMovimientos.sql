CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaRemitado_idFacturaCompraDetalle_FacturaCompraMovimientos`(
	in idDetFac int(11)
)
BEGIN
	SELECT
		Sum(Cantidad) as CantidadRemitada
	FROM
		FacturaCompraMovimientos
	WHERE 
		FacturaCompraDetalle_idFacturaCompraDetalle = idDetFac AND Tipo = "REMITADO" AND Eliminado = "NO";
END