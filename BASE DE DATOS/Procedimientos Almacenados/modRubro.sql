CREATE DEFINER=`root`@`localhost` PROCEDURE `modRubro`(
	in idR int(11),
	in rAb varchar (4),
    in rDes varchar (255),
    in rIdUs int(11)
)
BEGIN
	UPDATE Rubro
	SET 
		Abrebiatura = rAb,
		Descripcion = rDes,
		Usuarios_idUsuarios = rIdUs
	WHERE 
		idRubro = idR;
END