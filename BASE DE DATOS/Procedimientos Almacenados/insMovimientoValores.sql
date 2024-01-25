CREATE DEFINER=`root`@`localhost` PROCEDURE `insMovimientoValores`(
    in mvFec date,  
    in mvMov varchar(255),
    in mvOrDe varchar(255),
    in mvEli varchar(2),
    in mvIdVal int(11),
	in mvIdCaj int(11)
)
BEGIN
INSERT INTO MovimientoValores (
		Fecha,
        Movimiento,
        OrigenDestino,
        Eliminado,
        ValoresEnCartera_idValoresEnCartera,
        Caja_idCaja
)
	VALUES (mvFec, mvMov, mvOrDe, mvEli, mvIdVal, mvIdCaj);
END