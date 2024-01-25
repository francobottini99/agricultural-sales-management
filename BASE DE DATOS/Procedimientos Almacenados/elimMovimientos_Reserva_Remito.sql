CREATE DEFINER=`root`@`localhost` PROCEDURE `elimMovimientos_Reserva_Remito`(
	in mrrId int(11)
)
BEGIN
	UPDATE Movimientos_Reserva_Remito
	SET 
		Eliminado = "SI"
	WHERE 
		idMovimientos_Reserva_Remito = mrrId;
END