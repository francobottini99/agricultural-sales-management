CREATE DEFINER=`root`@`localhost` PROCEDURE `elimPerfil`(
	in IdP int(11)
)
BEGIN
	UPDATE Perfilesusuario
	SET 
		Eliminar = "SI"
	WHERE 
		idPerfilesUsuario = IdP;
END