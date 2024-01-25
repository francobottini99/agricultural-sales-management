CREATE DEFINER=`root`@`localhost` PROCEDURE `verRubros`(
)
BEGIN
	SELECT
		Rubro.*,
        Usuarios.Nombre
	FROM
		Rubro JOIN Usuarios ON Rubro.Usuarios_idUsuarios = Usuarios.idUsuarios
	WHERE
		Rubro.Eliminado = "NO";
END