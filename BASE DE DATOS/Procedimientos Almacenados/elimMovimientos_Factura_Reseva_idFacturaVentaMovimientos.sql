CREATE DEFINER=`root`@`localhost` PROCEDURE `elimMovimientos_Factura_Reseva_idFacturaVentaMovimientos`(
	in idFacMov int(11)
)
BEGIN
	UPDATE
		Movimientos_Factura_Reseva
	SET 
		Movimientos_Factura_Reseva.Eliminado = "SI"
	WHERE 
		Movimientos_Factura_Reseva.FacturaVentaMovimientos_idRemitosMovimientos = idFacMov And Movimientos_Factura_Reseva.Tipo = "REMITADO";
END