CREATE DEFINER=`root`@`localhost` PROCEDURE `verNumeracion`(
)
BEGIN
	SELECT
		*
	FROM
		Numeracion
	WHERE
		Eliminado = "NO";
END