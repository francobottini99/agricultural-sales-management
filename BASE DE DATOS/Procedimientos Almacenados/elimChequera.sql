CREATE DEFINER=`root`@`localhost` PROCEDURE `elimChequera`(
	in IdCh int(11)
)
BEGIN
	UPDATE Chequera
	SET 
		Eliminada = "SI"
	WHERE 
		idChequera = IdCh;
END