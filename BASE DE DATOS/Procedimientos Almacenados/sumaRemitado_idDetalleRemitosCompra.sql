CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaRemitado_idDetalleRemitosCompra`(
	in idDetRem int(11)
)
BEGIN
	SELECT
		Sum(Cantidad) as CantidadRemitada
	FROM
		RemitosCompraMovimientos
	WHERE 
		DetalleRemitosCompra_idDetalleRemitosCompra = idDetRem AND Tipo = "REMITADO" AND Eliminado = "NO";
END
