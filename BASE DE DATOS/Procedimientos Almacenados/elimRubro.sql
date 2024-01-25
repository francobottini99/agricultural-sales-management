CREATE DEFINER=`root`@`localhost` PROCEDURE `elimRubro`(
	in IdR int(11)
)
BEGIN
	UPDATE Rubro
	SET 
		Eliminado = "SI"
	WHERE 
		idRubro = IdR;
END