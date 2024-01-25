CREATE DEFINER=`root`@`localhost` PROCEDURE `elimStock`(
	in IdSTK int(11)
)
BEGIN
	UPDATE Stock
	SET 
		Eliminado = "SI"
	WHERE 
		idStock = IdSTK;
END