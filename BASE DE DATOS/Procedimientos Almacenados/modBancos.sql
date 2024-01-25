CREATE DEFINER=`root`@`localhost` PROCEDURE `modBancos`(
	in idB int(11),
    in bNom varchar (255),
    in idU int(11)
)
BEGIN
	UPDATE Bancos
	SET 
		Nombre = bNom,
        Usuarios_idUsuarios = idU
	WHERE 
		idBancos = idB;
END