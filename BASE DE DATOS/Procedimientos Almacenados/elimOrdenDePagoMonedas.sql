CREATE DEFINER=`root`@`localhost` PROCEDURE `elimOrdenDePagoMonedas`(
	in IdOpm int(11)
)
BEGIN
	UPDATE OrdenDePagoMonedas
	SET 
		Eliminado = "SI"
	WHERE 
		idOrdenDePagoMonedas = IdOpm;
END
