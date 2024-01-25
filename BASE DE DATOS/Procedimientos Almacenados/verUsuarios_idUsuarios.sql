CREATE DEFINER=`root`@`localhost` PROCEDURE `verUsuarios_idUsuarios`(
	in uId int(11)
)
BEGIN
	SELECT
		Usuarios.idUsuarios,
        Usuarios.FechaAlta,
        Usuarios.Tipo,
        Usuarios.Nombre,
        Usuarios.Contraseña,
        Usuarios.Imagen,
        Usuarios.Estado,
        Usuarios.Eliminado,
        Usuarios.PerfilesUsuario_idPerfilesUsuario
	FROM
		Usuarios
	WHERE
		idUsuarios = uId  And Eliminado = "NO";
END