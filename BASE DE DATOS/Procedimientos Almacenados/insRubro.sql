CREATE DEFINER=`root`@`localhost` PROCEDURE `insRubro`(
	in rAb varchar (4),
    in rDes varchar (255),
    in rIdUs int(11)
)
BEGIN
INSERT INTO Rubro (
		Abrebiatura,
		Descripcion,
        Eliminado,
		Usuarios_idUsuarios
)
	VALUES (rAb, rDes, "NO", rIdUs);
END