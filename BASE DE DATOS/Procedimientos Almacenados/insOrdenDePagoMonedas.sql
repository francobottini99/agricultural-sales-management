CREATE DEFINER=`root`@`localhost` PROCEDURE `insOrdenDePagoMonedas`(
	in opmTpc double,
	in opmImN double,
    in opmDes double,  
	in opmBas double,
	in opmIva double,
    in opmImT double,
    in opmEli varchar(2),
    in opmIdOp int(11)
)
BEGIN
INSERT INTO OrdenDePagoMonedas (
		TipoCambio,
		ImporteNeto,
        DescuentoGral,
        BaseImponible,
        Iva,
        ImporteTotal,
        Eliminado,
		OrdenDePago_idOrdenDePago
)
	VALUES (opmTpc, opmImN, opmDes, opmBas, opmIva, opmImT, opmEli, opmIdOp);
END