CREATE DEFINER=`root`@`localhost` PROCEDURE `insFacturaVentaDetalle`(
    in fvdDes varchar(255),
    in fvdUni varchar(255),
    in fvdCan double,
    in fvdPre double,    
    in fvdImp double,    
    in fvdIva double,
	in fvdRem varchar(2),
    in fvdEli varchar(2),
    in fvIdFv int(11),
    in fvIdArt int(11)
)
BEGIN
INSERT INTO FacturaVentaDetalle (
		Descripcion,
		Unidad,
		Cantidad,
        Precio,
        Importe,
        AlicuotaIVA,
		Remitado,
        Eliminado,
        FacturaVenta_idFacturaVenta,
        Articulos_idArticulos
)
	VALUES (fvdDes, fvdUni, fvdCan, fvdPre, fvdImp, fvdIva, fvdRem, fvdEli, fvIdFv, fvIdArt);
END