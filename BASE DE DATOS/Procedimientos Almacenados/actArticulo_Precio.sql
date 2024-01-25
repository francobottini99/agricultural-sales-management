CREATE DEFINER=`root`@`localhost` PROCEDURE `actArticulo_Precio`(
	in idAr int(11),
    in aPrecio double,
    in aFechaActualizacionPrecio date
)
BEGIN
	UPDATE Articulos
	SET 
		Precio = aPrecio,
        FechaActualizacionPrecio = aFechaActualizacionPrecio
	WHERE 
		idArticulos = idAr;
END