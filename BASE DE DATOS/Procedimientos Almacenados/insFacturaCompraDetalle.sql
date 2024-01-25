CREATE DEFINER=`root`@`localhost` PROCEDURE `insFacturaCompraDetalle`(
    in fcdDes varchar(255),
    in fcdUni varchar(255),
    in fcdCan double,
    in fcdPre double,    
    in fcdImp double,    
    in fcdIva double,
    in fcdRem varchar(2),
    in fcdEli varchar(2),
    in fcdIdA int(11),
    in fcdIdF int(11)
)
BEGIN
INSERT INTO FacturaCompraDetalle (
		Descripcion,
		Unidad,
		Cantidad,
        Precio,
        Importe,
        AlicuotaIVA,
        Remitado,
		Eliminado,
        Articulos_idArticulos,
        FacturaCompra_idFacturaCompra
)
	VALUES (fcdDes, fcdUni, fcdCan, fcdPre, fcdImp, fcdIva, fcdRem, fcdEli, fcdIdA, fcdIdF);
END