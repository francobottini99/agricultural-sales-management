CREATE DEFINER=`root`@`localhost` PROCEDURE `elimDetalleCheque`(
	in IdCh int(11)
)
BEGIN
	UPDATE DetalleCheque
	SET 
		Eliminado = "SI"
	WHERE 
		idDetalleCheque = IdCh;
END