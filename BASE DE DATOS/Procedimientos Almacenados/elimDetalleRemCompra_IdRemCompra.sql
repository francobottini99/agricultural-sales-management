CREATE DEFINER=`root`@`localhost` PROCEDURE `elimDetalleRemCompra_IdRemCompra`(
	in IdDRC int(11)
)
BEGIN
	UPDATE DetalleRemitosCompra
	SET 
		Eliminado = "SI"
	WHERE 
		RemitosCompra_idRemitosCompra = IdDRC;
END