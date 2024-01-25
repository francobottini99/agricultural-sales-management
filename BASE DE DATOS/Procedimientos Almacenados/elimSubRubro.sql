CREATE DEFINER=`root`@`localhost` PROCEDURE `elimSubRubro`(
	in IdSR int(11)
)
BEGIN
	UPDATE Subrubro
	SET 
		Eliminado = "SI"
	WHERE 
		idSubRubro = IdSR;
END