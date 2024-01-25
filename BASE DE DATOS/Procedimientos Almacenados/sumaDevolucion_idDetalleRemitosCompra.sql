CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaDevolucion_idDetalleRemitosCompra`(
	in idDetRem int(11)
)
BEGIN
	SELECT
		Sum(Cantidad) as CantidadDevuelta
	FROM
		RemitosCompraMovimientos
	WHERE 
		DetalleRemitosCompra_idDetalleRemitosCompra = idDetRem AND Tipo = "DEVOLUCION" AND Eliminado = "NO";
END
