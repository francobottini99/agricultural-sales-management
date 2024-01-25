CREATE DEFINER=`root`@`localhost` PROCEDURE `elimRemitoVentaMovimientos_IdRemVenta`(
	in IdDRV int(11)
)
BEGIN
	UPDATE RemitosMovimientos JOIN DetalleRemitosVenta ON RemitosMovimientos.DetalleRemitosVenta_idDetalleRemitosVenta = DetalleRemitosVenta.idDetalleRemitosVenta
	SET 
		RemitosMovimientos.Eliminado = "SI"
	WHERE 
		DetalleRemitosVenta.RemitosVenta_idRemitosVenta = IdDRV And RemitosMovimientos.Tipo = "REMITADO";
END