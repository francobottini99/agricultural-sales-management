CREATE DEFINER=`root`@`localhost` PROCEDURE `modArticulo`(
	in idAr int(11),
    in aCdArt varchar(100),
	in aDetalle varchar(255),
    in aUnidad varchar(100),
    in aCosto double,
    in aFechaActualizacionCosto date,
    in aPrecio double,    
    in aFechaActualizacionPrecio date,    
    in aAlicuotaIVA double,
    in aStockMinimo double,
    in aObservaciones text, 
    in aImagen mediumblob,
    in aidUsuarios int(11),
    in aidRubro int(11),
    in aidSubRubro int(11)
)
BEGIN
	UPDATE Articulos
	SET 
		CodArticulo = aCdArt,
		Detalle = aDetalle,
		Unidad = aUnidad,
		Costo = aCosto,
        FechaActualizacionCosto = aFechaActualizacionCosto,
        Precio = aPrecio,
        FechaActualizacionPrecio = aFechaActualizacionPrecio,
		AlicuotaIVA = aAlicuotaIVA,
        StockMinimo = aStockMinimo,
        Observaciones = aObservaciones,
        Imagen = aImagen,
        Usuarios_idUsuarios = aidUsuarios,
        Rubro_idRubro = aidRubro,
        SubRubro_idSubRubro = aidSubRubro
	WHERE 
		idArticulos = idAr;
END