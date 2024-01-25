CREATE DEFINER=`root`@`localhost` PROCEDURE `verMonedasActivas`(
)
BEGIN
	SELECT
		*
	FROM
        Monedas
	WHERE
		Eliminado = "NO";
END