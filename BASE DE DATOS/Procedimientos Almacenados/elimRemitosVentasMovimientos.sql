CREATE DEFINER=`root`@`localhost` PROCEDURE `elimRemitosVentasMovimientos`(
	in rvmId int(11)
)
BEGIN
	UPDATE RemitosVentasMovimientos
	SET 
		Eliminado = "SI"
	WHERE 
		idRemitosVentasMovimientos = rvmId;
END