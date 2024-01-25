CREATE DEFINER=`root`@`localhost` PROCEDURE `verCheques_Por_Chequera`(
	in idChra int(11)
)
BEGIN
	SELECT
		*
	FROM
		DetalleCheque
	WHERE
		Chequera_idChequera = idChra And Eliminado = "NO";
END