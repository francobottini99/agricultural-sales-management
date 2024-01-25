CREATE DEFINER=`root`@`localhost` PROCEDURE `elimCaja`(
	in idC int(11)
)
BEGIN
	UPDATE Caja
	SET 
		Eliminado = "SI"
	WHERE 
		idCaja = idC;
END