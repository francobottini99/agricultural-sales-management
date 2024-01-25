CREATE DEFINER=`root`@`localhost` PROCEDURE `insFacturaVtaMonedas`(
    in fvmTic double,
    in fvmImN double,
    in fvmDsc double,
    in fvmBim double,    
    in fvmIva double,    
    in fvmImT double,
    in fvmEli varchar(2),
    in fvmIdFv int(11)
)
BEGIN 
INSERT INTO FacturaVtaMonedas (
		TipoCambio,
		ImporteNeto,
		DescuentoGral,
        BaseImponible,
        Iva,
        ImporteTotal,
		Eliminado,
        FacturaVenta_idFacturaVenta
)
	VALUES (fvmTic, fvmImN, fvmDsc, fvmBim, fvmIva, fvmImT, fvmEli, fvmIdFv);
END