CREATE DEFINER=`root`@`localhost` PROCEDURE `insFacturaComMonedas`(
    in fcmTic double,
    in fcmImN double,
    in fcmDsc double,
    in fcmBim double,    
    in fcmIva double,    
    in fcmImT double,
    in fcmEli varchar(2),
    in fcmIdFc int(11)
)
BEGIN 
INSERT INTO FacturaComMonedas (
		TipoCambio,
		ImporteNeto,
		DescuentoGral,
        BaseImponible,
        Iva,
        ImporteTotal,
		Eliminado,
        FacturaCompra_idFacturaCompra
)
	VALUES (fcmTic, fcmImN, fcmDsc, fcmBim, fcmIva, fcmImT, fcmEli, fcmIdFc);
END