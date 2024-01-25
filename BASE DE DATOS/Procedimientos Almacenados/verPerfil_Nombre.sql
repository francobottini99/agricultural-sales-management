CREATE DEFINER=`root`@`localhost` PROCEDURE `verPerfil_Nombre`(
	in pNombre varchar(255)
)
BEGIN
	SELECT
		*
	FROM
		Perfilesusuario
	WHERE
		NombrePerfil = pNombre  And Eliminar = "NO";
END