CREATE DEFINER=`root`@`localhost` PROCEDURE `verValoresEnCartera_Disponible`(
	in vecDisp varchar(2)
)
BEGIN
	SELECT
		*
	FROM
		ValoresEnCartera
	WHERE
		Disponible = vecDisp And Eliminado = "NO"
	ORDER BY FechaCobro ASC;
END