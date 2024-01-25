CREATE DEFINER=`root`@`localhost` PROCEDURE `insArticulo`(
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
INSERT INTO Articulos (
		CodArticulo,
		Detalle,
		Unidad,
		Costo,
        FechaActualizacionCosto,
        Precio,
        FechaActualizacionPrecio,
		AlicuotaIVA,
        StockMinimo,
        Observaciones,
        Imagen,
        Eliminado,
        Usuarios_idUsuarios,
        Rubro_idRubro,
        SubRubro_idSubRubro
)
	VALUES (aCdArt, aDetalle, aUnidad, aCosto, aFechaActualizacionCosto, aPrecio, aFechaActualizacionPrecio, aAlicuotaIVA, aStockMinimo, aObservaciones, aImagen, "NO", aidUsuarios, aidRubro, aidSubRubro);
END