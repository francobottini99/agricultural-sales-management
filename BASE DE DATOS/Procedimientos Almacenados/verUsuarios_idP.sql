CREATE DEFINER=`root`@`localhost` PROCEDURE `verUsuarios_idP`(
	in idP int(11)
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
		PerfilesUsuario_idPerfilesUsuario = idP And Eliminado = "NO";
END