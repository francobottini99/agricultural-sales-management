CREATE DEFINER=`root`@`localhost` PROCEDURE `modDetalleRemitosVenta_Facturado`(
	in drcID int(11),
	in drcFac varchar(2)
)
BEGIN
	UPDATE DetalleRemitosVenta
	SET 
        Facturado = drcFac
	WHERE 
		idDetalleRemitosVenta = drcID;
END