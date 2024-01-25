CREATE DEFINER=`root`@`localhost` PROCEDURE `verPerfil_idP`(
	in idP int(11)
)
BEGIN
	SELECT
		*
	FROM
		Perfilesusuario
	WHERE
		idPerfilesUsuario = idP and Eliminar = "NO";
END