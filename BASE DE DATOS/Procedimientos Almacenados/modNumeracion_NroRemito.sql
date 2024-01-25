CREATE DEFINER=`root`@`localhost` PROCEDURE `modNumeracion_NroRemito`(
	in nId int(11),
	in nNro int(11)
)
BEGIN
	UPDATE Numeracion
	SET 
        NroRemito = nNro
	WHERE 
		idNumeracion = nId;
END