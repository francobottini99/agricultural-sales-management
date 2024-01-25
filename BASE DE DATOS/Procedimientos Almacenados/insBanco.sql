CREATE DEFINER=`root`@`localhost` PROCEDURE `insBanco`(
    in bNombre varchar (255),  
    in bElim varchar(2),
    in bIdUs int(11)
)
BEGIN
INSERT INTO Bancos (
		Nombre,
        Eliminado,
        Usuarios_idUsuarios
)
	VALUES (bNombre, bElim, bIdUs);
END