CREATE DEFINER=`root`@`localhost` PROCEDURE `elimValoresEnCartera`(
	in IdV int(11)
)
BEGIN
	UPDATE ValoresEnCartera
	SET 
		Eliminado = "SI"
	WHERE 
		idValoresEnCartera = IdV;
END