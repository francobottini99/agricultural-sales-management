CREATE DEFINER=`root`@`localhost` PROCEDURE `consUncUsuario`(
	in uUsuario varchar(45),
    in uContraseña varchar (255)
)
BEGIN
	SELECT
		Usuarios.*,
        Perfilesusuario.NombrePerfil
	FROM
		Usuarios JOIN Perfilesusuario ON Usuarios.PerfilesUsuario_idPerfilesUsuario = Perfilesusuario.idPerfilesUsuario
	WHERE
		Usuarios.Nombre = uUsuario And Usuarios.Contraseña = uContraseña And Usuarios.Eliminado = "NO";
END