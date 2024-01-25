CREATE DEFINER=`root`@`localhost` PROCEDURE `modDetalleRemitosCompra_CantidadFacturada`(
	in drcID int(11),
	in drcCant double 
)
BEGIN
	UPDATE DetalleRemitosCompra
	SET 
        CantidadFacturada = drcCant
	WHERE 
		idDetalleRemitosCompra = drcID;
END