CREATE DEFINER=`root`@`localhost` PROCEDURE `elimDevolucionesMonedas_idDevoluciones`(
	in dmIdD int(11)
)
BEGIN
	UPDATE DevolucionesMonedas
	SET 
		Eliminado = "SI"
	WHERE 
		Devoluciones_idDevoluciones = dmIdD;
END