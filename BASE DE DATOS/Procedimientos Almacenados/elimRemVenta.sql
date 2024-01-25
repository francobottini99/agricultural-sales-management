CREATE DEFINER=`root`@`localhost` PROCEDURE `elimRemVenta`(
	in IdRV int(11)
)
BEGIN
	UPDATE RemitosVenta
	SET 
		Eliminado = "SI"
	WHERE 
		idRemitosVenta = IdRV;
END