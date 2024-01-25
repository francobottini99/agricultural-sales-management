CREATE DEFINER=`root`@`localhost` PROCEDURE `insDetalleRemitoCompra`(
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
INSERT INTO DetalleRemitosCompra (
		Descripcion,
		Cantidad,
		Unidad,
        Precio,
        Importe,
        AlicuotaIVA,
        Facturado,
		Eliminado,
        Articulos_idArticulos,
        RemitosCompra_idRemitosCompra
)
	VALUES (drcDes, drcCant, drcUni, drcPre, drcImp, drcIva, drcFac, drcEli, drcIdA, drcIdR);
END