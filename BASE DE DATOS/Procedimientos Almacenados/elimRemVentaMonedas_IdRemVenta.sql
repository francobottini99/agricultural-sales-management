CREATE DEFINER=`root`@`localhost` PROCEDURE `elimRemVentaMonedas_IdRemVenta`(
	in IdRV int(11)
)
BEGIN
	UPDATE RemitoVtaMonedas
	SET 
		Eliminado = "SI"
	WHERE 
		RemitosVenta_idRemitosVenta = IdRV;
END