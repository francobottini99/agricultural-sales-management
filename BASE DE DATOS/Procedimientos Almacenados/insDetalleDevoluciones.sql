CREATE DEFINER=`root`@`localhost` PROCEDURE `insDetalleDevoluciones`(
    in ddDes varchar(255),
    in ddCant double,
    in ddUni varchar(255),
    in ddPre double,    
    in ddImp double,    
    in ddIva double,
    in ddEli varchar(2),
    in ddIdA int(11),
    in ddIdDR int(11),
    in ddIdD int(11)
)
BEGIN
INSERT INTO DetalleDevoluciones (
		Descripcion,
		Cantidad,
		Unidad,
        Precio,
        Importe,
        AlicuotaIVA,
		Eliminado,
        Articulos_idArticulos,
        DetalleRemitosVenta_idDetalleRemitosVenta,
        Devoluciones_idDevoluciones
)
	VALUES (ddDes, ddCant, ddUni, ddPre, ddImp, ddIva, ddEli, ddIdA, ddIdDR, ddIdD);
END