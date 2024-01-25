CREATE DEFINER=`root`@`localhost` PROCEDURE `modNumeracion_NroReserva`(
	in nId int(11),
	in nNro int(11)
)
BEGIN
	UPDATE Numeracion
	SET 
        NroReserva = nNro
	WHERE 
		idNumeracion = nId;
END