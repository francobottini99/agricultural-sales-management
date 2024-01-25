CREATE DEFINER=`root`@`localhost` PROCEDURE `modOrdenDePagoMonedas`(
	in opmId int(11),
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
	UPDATE OrdenDePagoMonedas
	SET 
		TipoCambio = opmTpc,
		ImporteNeto = opmImN,
        DescuentoGral = opmDes,
        BaseImponible = opmBas,
        Iva = opmIva,
        ImporteTotal = opmImT,
        Eliminado = opmEli,
		OrdenDePago_idOrdenDePago = opmIdOp
	WHERE 
		idOrdenDePagoMonedas = opmId;
END