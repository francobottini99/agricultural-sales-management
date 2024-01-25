CREATE DEFINER=`root`@`localhost` PROCEDURE `elimBanco`(
	in idB int(11)
)
BEGIN
	UPDATE Bancos
	SET 
		Eliminado = "SI"
	WHERE 
		idBancos = idB;
END