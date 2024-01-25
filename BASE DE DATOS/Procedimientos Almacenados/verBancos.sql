CREATE DEFINER=`root`@`localhost` PROCEDURE `verBancos`(
)
BEGIN
	SELECT
		*
	FROM
		Bancos
	WHERE
		Eliminado = "NO";
END