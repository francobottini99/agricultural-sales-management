CREATE DEFINER=`root`@`localhost` PROCEDURE `verChequera`(
)
BEGIN
	SELECT
		*
	FROM
		Chequera
	WHERE
		Eliminada = "NO";
END