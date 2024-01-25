CREATE DEFINER=`root`@`localhost` PROCEDURE `modNumeracion_NroFacturaB`(
	in nId int(11),
	in nNro int(11)
)
BEGIN
	UPDATE Numeracion
	SET 
        NroFacturaB = nNro
	WHERE 
		idNumeracion = nId;
END