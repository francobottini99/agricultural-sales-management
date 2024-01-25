CREATE DEFINER=`root`@`localhost` PROCEDURE `insSubRubro`(
	in srAb varchar (4),
    in srDes varchar (255),
    in srIdR varchar (255),
    in srIdUs int(11)
)
BEGIN
INSERT INTO Subrubro (
		Abrebiatura,
		Descripcion,
        Eliminado,
        Rubro_idRubro,
		Usuarios_idUsuarios
)
	VALUES (srAb, srDes, "NO", srIdR, srIdUs);
END