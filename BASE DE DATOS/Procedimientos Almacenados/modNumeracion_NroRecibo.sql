CREATE DEFINER=`root`@`localhost` PROCEDURE `modNumeracion_NroRecibo`(
	in nId int(11),
	in nNro int(11)
)
BEGIN
	UPDATE Numeracion
	SET 
        NroRecibo = nNro
	WHERE 
		idNumeracion = nId;
END