CREATE DEFINER=`root`@`localhost` PROCEDURE `elimNumeracion`(
	in nId int(11)
)
BEGIN
	UPDATE Numeracion
	SET 
		Eliminado = "SI"
	WHERE 
		idNumeracion = nId;
END
