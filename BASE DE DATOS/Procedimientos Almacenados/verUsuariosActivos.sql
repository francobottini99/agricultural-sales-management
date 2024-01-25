CREATE DEFINER=`root`@`localhost` PROCEDURE `verUsuariosActivos`(
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
        Usuarios.PerfilesUsuario_idPerfilesUsuario,
        Perfilesusuario.NombrePerfil
	FROM
        Usuarios JOIN Perfilesusuario ON Usuarios.PerfilesUsuario_idPerfilesUsuario = Perfilesusuario.idPerfilesUsuario
	WHERE
		Eliminado = "NO" And Tipo != "Super Usuario";
END