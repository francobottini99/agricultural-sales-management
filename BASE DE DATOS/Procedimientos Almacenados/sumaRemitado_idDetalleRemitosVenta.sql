CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaRemitado_idDetalleRemitosVenta`(
	in idDetRem int(11)
)
BEGIN
	SELECT
		Sum(Cantidad) as CantidadRemitada
	FROM
		RemitosVentasMovimientos
	WHERE 
		DetalleRemitosVenta_idDetalleRemitosVenta = idDetRem AND Tipo = "REMITADO" AND Eliminado = "NO";
END