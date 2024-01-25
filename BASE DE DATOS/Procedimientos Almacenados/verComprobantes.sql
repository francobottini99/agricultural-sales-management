CREATE DEFINER=`root`@`localhost` PROCEDURE `verComprobantes`(
)
BEGIN
	SELECT
		*
	FROM
		Comprobantes
	WHERE
		Eliminado = "NO";
END