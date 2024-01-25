CREATE DEFINER=`root`@`localhost` PROCEDURE `verBanco_Nombre`(
	in bNombre varchar(255)
)
BEGIN
	SELECT
		*
	FROM
		Bancos
	WHERE
		Nombre = bNombre  And Eliminado = "NO";
END