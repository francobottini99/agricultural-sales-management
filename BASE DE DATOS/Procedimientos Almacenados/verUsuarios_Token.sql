CREATE DEFINER=`root`@`localhost` PROCEDURE `verUsuarios_Token`(
	in uToken varchar(45)
)
BEGIN
	SELECT
		Usuarios.idUsuarios,
        Usuarios.Nombre
	FROM
		Usuarios
	WHERE
		Token = uToken  And Eliminado = "NO";
END