CREATE DEFINER=`root`@`localhost` PROCEDURE `elimRecibosVentaMonedas`(
	in IdRvm int(11)
)
BEGIN
	UPDATE RecibosVentaMonedas
	SET 
		Eliminado = "SI"
	WHERE 
		idRecibosVentaMonedas = IdRvm;
END