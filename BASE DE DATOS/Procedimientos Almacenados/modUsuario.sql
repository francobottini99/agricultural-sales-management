CREATE DEFINER=`root`@`localhost` PROCEDURE `modUsuario`(
	in idU int(11),
    in uFechaAlta date,
    in uTipo varchar (45),
    in uUsuario varchar(45),
    in uContraseña varchar (255),
    in uImagen mediumblob,
    in uEstado varchar (45),
    in uIdP int(11)
)
BEGIN
	UPDATE Usuarios
	SET 
		FechaAlta = uFechaAlta,
		Tipo = uTipo,
		Nombre = uUsuario,
        Contraseña = uContraseña,
        Imagen = uImagen,
        Estado = uEstado,
        PerfilesUsuario_idPerfilesUsuario = uIdP
	WHERE 
		idUsuarios = idU;
END