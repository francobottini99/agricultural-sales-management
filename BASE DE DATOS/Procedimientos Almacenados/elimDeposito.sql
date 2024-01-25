CREATE DEFINER=`root`@`localhost` PROCEDURE `elimDeposito`(
	in IdD int(11)
)
BEGIN
	UPDATE Depositos
	SET 
		Eliminado = "SI"
	WHERE 
		idDepositos = IdD;
END