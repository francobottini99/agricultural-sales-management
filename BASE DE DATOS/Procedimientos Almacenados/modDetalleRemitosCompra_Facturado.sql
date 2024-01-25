CREATE DEFINER=`root`@`localhost` PROCEDURE `modDetalleRemitosCompra_Facturado`(
	in drcID int(11),
	in drcFac varchar(2)
)
BEGIN
	UPDATE DetalleRemitosCompra
	SET 
        Facturado = drcFac
	WHERE 
		idDetalleRemitosCompra = drcID;
END