CREATE DEFINER=`root`@`localhost` PROCEDURE `elimMovimientoValores`(
	in mvIdMoV int(11)
)
BEGIN
	UPDATE MovimientoValores
	SET 
		Eliminado = "SI"
	WHERE 
		idMovimientoValores = mvIdMoV;
END
