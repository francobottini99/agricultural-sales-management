CREATE DEFINER=`root`@`localhost` PROCEDURE `verValoresEnCartera`(
)
BEGIN
	SELECT
		*
	FROM
		ValoresEnCartera
	WHERE 
		Eliminado = "NO"
	ORDER BY FechaCobro ASC;
END