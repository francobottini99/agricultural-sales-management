CREATE DEFINER=`root`@`localhost` PROCEDURE `elimMovimientos_RemitoCompra_FacturaCompra`(
	in mrfId int(11)
)
BEGIN
	UPDATE Movimientos_RemitoCompra_FacturaCompra
	SET 
		Eliminado = "SI"
	WHERE 
		idMovimientos_RemitoCompra_FacturaCompra = mrfId;
END
