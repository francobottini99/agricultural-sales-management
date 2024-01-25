CREATE DEFINER=`root`@`localhost` PROCEDURE `elimRecibosVentaDetalle`(
	in rvdId int(11)
)
BEGIN
	UPDATE RecibosVentaDetalle
	SET 
		Eliminado = "SI"
	WHERE 
		idRecibosVentaDetalle = rvdId;
END