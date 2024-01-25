CREATE DEFINER=`root`@`localhost` PROCEDURE `elimRecibosVentaMonedas_idRecibosVenta`(
	in idRv int(11)
)
BEGIN
	UPDATE RecibosVentaMonedas
	SET 
		Eliminado = "SI"
	WHERE 
		RecibosVenta_idRecibosVenta = idRv;
END