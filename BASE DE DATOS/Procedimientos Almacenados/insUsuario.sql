CREATE DEFINER=`root`@`localhost` PROCEDURE `insUsuario`(
	in uFechaAlta date,
    in uTipo varchar (45),
    in uUsuario varchar(45),
    in uContraseña varchar (255),
    in uImagen mediumblob,
    in uEstado varchar (45),
    in uIdP int(11)
)
BEGIN
INSERT INTO Usuarios (
		FechaAlta,
		Tipo,
		Nombre,
        Contraseña,
        Imagen,
        Estado,
        Token,
		Eliminado,
        PerfilesUsuario_idPerfilesUsuario
)
	VALUES (uFechaAlta, uTipo, uUsuario, uContraseña, uImagen, uEstado, "-", "NO", uIdP);
END