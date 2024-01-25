CREATE DEFINER=`root`@`localhost` PROCEDURE `elimRecibosVenta`(
	in rvId int(11)
)
BEGIN
	UPDATE RecibosVenta
	SET 
		Eliminado = "SI"
	WHERE 
		idRecibosVenta = rvId;
END