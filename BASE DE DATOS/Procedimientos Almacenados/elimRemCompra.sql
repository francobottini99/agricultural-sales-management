CREATE DEFINER=`root`@`localhost` PROCEDURE `elimRemCompra`(
	in IdRC int(11)
)
BEGIN
	UPDATE RemitosCompra
	SET 
		Eliminado = "SI"
	WHERE 
		idRemitosCompra = IdRC;
END