CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaFacturado_idDetalleRemitosCompra_RemitosCompraMovimientos`(
	in idDetRem int(11)
)
BEGIN
	SELECT
		Sum(Cantidad) as CantidadFacturada
	FROM
		RemitosCompraMovimientos
	WHERE 
		DetalleRemitosCompra_idDetalleRemitosCompra = idDetRem AND Tipo = "FACTURADO" AND Eliminado = "NO";
END