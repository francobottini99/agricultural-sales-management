CREATE DEFINER=`root`@`localhost` PROCEDURE `elimRemCompraMonedas_IdRemCompra`(
	in IdRCM int(11)
)
BEGIN
	UPDATE RemitoComMonedas
	SET 
		Eliminado = "SI"
	WHERE 
		RemitosCompra_idRemitosCompra = IdRCM;
END