CREATE DEFINER=`root`@`localhost` PROCEDURE `modChequera_ChqEmitidos`(
	in cId int(11),
	in cCant int(11)
)
BEGIN
	UPDATE Chequera
	SET 
        ChqEmitidos = ChqEmitidos + cCant,
        ChqDisponibles = ChqDisponibles - cCant
	WHERE 
		idChequera = cId;
END