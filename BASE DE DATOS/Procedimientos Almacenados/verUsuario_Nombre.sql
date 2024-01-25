CREATE DEFINER=`root`@`localhost` PROCEDURE `verUsuario_Nombre`(
	in uNombre varchar(255)
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
		Nombre = uNombre  And Eliminado = "NO";
END