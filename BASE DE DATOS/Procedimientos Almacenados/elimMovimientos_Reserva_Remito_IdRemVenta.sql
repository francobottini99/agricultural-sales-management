CREATE DEFINER=`root`@`localhost` PROCEDURE `elimMovimientos_Reserva_Remito_IdRemVenta`(
	in IdDRV int(11)
)
BEGIN
	UPDATE Movimientos_Reserva_Remito JOIN DetalleRemitosVenta ON Movimientos_Reserva_Remito.DetalleRemitosVenta_idDetalleRemitosVenta = DetalleRemitosVenta.idDetalleRemitosVenta
	SET 
		Movimientos_Reserva_Remito.Eliminado = "SI"
	WHERE 
		DetalleRemitosVenta.RemitosVenta_idRemitosVenta = IdDRV And Movimientos_Reserva_Remito.Tipo = "REMITADO";
END