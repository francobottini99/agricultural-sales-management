CREATE DEFINER=`root`@`localhost` PROCEDURE `modMovimientoValores`(
	in mvIdMoV int(11),
    in mvFec date,  
    in mvMov varchar(255),
    in mvOrDe varchar(255),
    in mvEli varchar(2),
    in mvIdVal int(11),
	in mvIdCaj int(11)
)
BEGIN
	UPDATE MovimientoValores
	SET 
		Fecha = mvFec,
        Movimiento = mvMov,
        OrigenDestino = mvOrDe,
		Eliminado = mvEli,
		ValoresEnCartera_idValoresEnCartera = mvIdVal,
        Caja_idCaja = mvIdCaj
	WHERE 
		idMovimientoValores = mvIdMoV;
END
