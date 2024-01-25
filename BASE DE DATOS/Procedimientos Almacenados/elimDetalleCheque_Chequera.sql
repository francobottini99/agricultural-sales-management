CREATE DEFINER=`root`@`localhost` PROCEDURE `elimDetalleCheque_Chequera`(
	in IdChra int(11)
)
BEGIN
	UPDATE DetalleCheque
	SET 
		Eliminado = "SI"
	WHERE 
		Chequera_idChequera = IdChra;
END