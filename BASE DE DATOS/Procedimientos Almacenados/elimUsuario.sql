CREATE DEFINER=`root`@`localhost` PROCEDURE `elimUsuario`(
	in IdU int(11)
)
BEGIN
	UPDATE Usuarios
	SET 
		Eliminado = "SI"
	WHERE 
		idUsuarios = IdU;
END