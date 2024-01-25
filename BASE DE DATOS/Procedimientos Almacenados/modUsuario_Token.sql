CREATE DEFINER=`root`@`localhost` PROCEDURE `modUsuario_Token`(
	in idU int(11),
    in uToken varchar (45)
)
BEGIN
	UPDATE Usuarios
	SET 
		Token = uToken
	WHERE 
		idUsuarios = idU;
END