CREATE DEFINER=`root`@`localhost` PROCEDURE `verDeposito_Nombre`(
	in dNombre varchar(255)
)
BEGIN
	SELECT
		*
	FROM
		Depositos
	WHERE
		Nombre = dNombre  And Eliminado = "NO";
END