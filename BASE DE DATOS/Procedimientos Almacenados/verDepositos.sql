CREATE DEFINER=`root`@`localhost` PROCEDURE `verDepositos`(
)
BEGIN
	SELECT
		*
	FROM
		Depositos
	WHERE
		Eliminado = "NO";
END