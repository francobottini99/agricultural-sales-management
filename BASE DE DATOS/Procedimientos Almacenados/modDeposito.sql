CREATE DEFINER=`root`@`localhost` PROCEDURE `modDeposito`(
	in idD int(11),
    in dNom varchar (255),
    in dDir varchar(255),
    in dLoc varchar (255),
    in dProv varchar (255),
    in dCP varchar (45),
    in idU int(11)
)
BEGIN
	UPDATE Depositos
	SET 
		Nombre = dNom,
		Direccion = dDir,
        Localidad = dLoc,
        Provincia = dProv,
        CP = dCP,
        Usuarios_idUsuarios = idU
	WHERE 
		idDepositos = idD;
END