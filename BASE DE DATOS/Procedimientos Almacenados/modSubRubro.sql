CREATE DEFINER=`root`@`localhost` PROCEDURE `modSubRubro`(
	in idSR int(11),
	in rAb varchar (4),
    in rDes varchar (255),
    in idR int(11),
    in rIdUs int(11)
)
BEGIN
	UPDATE Subrubro
	SET 
		Abrebiatura = rAb,
		Descripcion = rDes,
        Rubro_idRubro = idR,
		Usuarios_idUsuarios = rIdUs
	WHERE 
		idSubRubro = idSR;
END