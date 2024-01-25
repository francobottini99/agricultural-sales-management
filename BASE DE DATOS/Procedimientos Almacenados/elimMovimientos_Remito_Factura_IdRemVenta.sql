CREATE DEFINER=`root`@`localhost` PROCEDURE `elimMovimientos_Remito_Factura_IdRemVenta`(
	in IdDRV int(11)
)
BEGIN
	UPDATE Movimientos_Remito_Factura JOIN DetalleRemitosVenta ON Movimientos_Remito_Factura.DetalleRemitosVenta_idDetalleRemitosVenta = DetalleRemitosVenta.idDetalleRemitosVenta
	SET 
		Movimientos_Remito_Factura.Eliminado = "SI"
	WHERE 
		DetalleRemitosVenta.RemitosVenta_idRemitosVenta = IdDRV And Movimientos_Remito_Factura.Tipo = "REMITADO";
END