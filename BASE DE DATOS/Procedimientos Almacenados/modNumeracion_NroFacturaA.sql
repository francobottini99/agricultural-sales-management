CREATE DEFINER=`root`@`localhost` PROCEDURE `modNumeracion_NroFacturaA`(
	in nId int(11),
	in nNro int(11)
)
BEGIN
	UPDATE Numeracion
	SET 
        NroFacturaA = nNro
	WHERE 
		idNumeracion = nId;
END