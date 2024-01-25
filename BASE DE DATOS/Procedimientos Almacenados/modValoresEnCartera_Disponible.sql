CREATE DEFINER=`root`@`localhost` PROCEDURE `modValoresEnCartera_Disponible`(
	in vecIdV int(11),
	in vecDisp varchar(2)
)
BEGIN
	UPDATE ValoresEnCartera
	SET 
        Disponible = vecDisp
	WHERE 
		idValoresEnCartera = vecIdV;
END