CREATE DEFINER=`root`@`localhost` PROCEDURE `insDeposito`(
    in dNombre varchar (255),
    in dDir varchar(255),
    in dLoc varchar (255),
    in dProv varchar (255),    
    in dCP varchar (45),    
    in dElim varchar(2),
    in dIdUs int(11)
)
BEGIN
INSERT INTO Depositos (
		Nombre,
		Direccion,
        Localidad,
        Provincia,
        CP,
        Eliminado,
        Usuarios_idUsuarios
)
	VALUES (dNombre, dDir, dLoc, dProv, dCP, dElim, dIdUs);
END