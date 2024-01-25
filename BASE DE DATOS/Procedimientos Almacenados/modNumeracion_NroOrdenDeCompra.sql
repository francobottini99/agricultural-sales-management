CREATE DEFINER=`root`@`localhost` PROCEDURE `modNumeracion_NroOrdenDeCompra`(
	in nId int(11),
	in nNro int(11)
)
BEGIN
	UPDATE Numeracion
	SET 
        NroOrdenCompra = nNro
	WHERE 
		idNumeracion = nId;
END