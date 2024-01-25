CREATE DEFINER=`root`@`localhost` PROCEDURE `insParidadCambiaria`(
	in pcFec datetime,
    in pcVC double,
    in pcVV double,
    in pcId int(11)
)
BEGIN
INSERT INTO Paridadcambiaria (
		Fecha,
		CotizacionCompra,
        CotizacionVenta,
        Eliminado,
		Monedas_idMonedas
)
	VALUES (pcFec, pcVC, pcVV, "NO", pcId);
END