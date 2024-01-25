CREATE DEFINER=`root`@`localhost` PROCEDURE `modNumeracion_NroDevolucion`(
	in nId int(11),
	in nNro int(11)
)
BEGIN
	UPDATE Numeracion
	SET 
        NroDevolucion = nNro
	WHERE 
		idNumeracion = nId;
END
