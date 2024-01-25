CREATE DEFINER=`root`@`localhost` PROCEDURE `verSubRubros`(
)
BEGIN
	SELECT
		Subrubro.*,
        Usuarios.Nombre
	FROM
		Subrubro JOIN Usuarios ON Subrubro.Usuarios_idUsuarios = Usuarios.idUsuarios
	WHERE
		Subrubro.Eliminado = "NO";
END