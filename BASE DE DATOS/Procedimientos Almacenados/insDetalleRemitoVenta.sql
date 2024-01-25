CREATE DEFINER=`root`@`localhost` PROCEDURE `insDetalleRemitoVenta`(
    in drcDes varchar(255),
    in drcCant double,
    in drcUni varchar(255),
    in drcPre double,    
    in drcImp double,    
    in drcIva double,
    in drcFac varchar(2),
    in drcEli varchar(2),
    in drcIdA int(11),
    in drcIdR int(11)
)
BEGIN
INSERT INTO DetalleRemitosVenta (
		Descripcion,
		Cantidad,
		Unidad,
        Precio,
        Importe,
        AlicuotaIVA,
        Facturado,
		Eliminado,
        Articulos_idArticulos,
        RemitosVenta_idRemitosVenta
)
	VALUES (drcDes, drcCant, drcUni, drcPre, drcImp, drcIva, drcFac, drcEli, drcIdA, drcIdR);
END