CREATE DEFINER=`root`@`localhost` PROCEDURE `verOrdenDePago`(
)
BEGIN
	SELECT
		*
	FROM
		OrdenDePago
	WHERE
		Eliminado = "NO";
END