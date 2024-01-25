CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaDevolucion_idDetalleRemitosVenta`(
	in idDetRem int(11)
)
BEGIN
	SELECT
		Sum(Cantidad) as CantidadDevuelta
	FROM
		RemitosVentasMovimientos
	WHERE 
		DetalleRemitosVenta_idDetalleRemitosVenta = idDetRem AND Tipo = "DEVOLUCION" AND Eliminado = "NO";
END