CREATE DEFINER=`root`@`localhost` PROCEDURE `verChequera_ChqDisponibles`(
)
BEGIN
	SELECT
		*
	FROM
		Chequera
	WHERE
		ChqDisponibles > 0 AND Eliminada = "NO";
END