CREATE DEFINER=`root`@`localhost` PROCEDURE `elimDetalleRemVenta_IdRemVenta`(
	in IdDRV int(11)
)
BEGIN
	UPDATE DetalleRemitosVenta
	SET 
		Eliminado = "SI"
	WHERE 
		RemitosVenta_idRemitosVenta = IdDRV;
END