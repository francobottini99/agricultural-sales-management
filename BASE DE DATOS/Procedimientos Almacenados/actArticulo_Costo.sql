CREATE DEFINER=`root`@`localhost` PROCEDURE `actArticulo_Costo`(
	in idAr int(11),
    in aCosto double,
    in aFechaActualizacionCosto date
)
BEGIN
	UPDATE Articulos
	SET 
		Costo = aCosto,
        FechaActualizacionCosto = aFechaActualizacionCosto
	WHERE 
		idArticulos = idAr;
END