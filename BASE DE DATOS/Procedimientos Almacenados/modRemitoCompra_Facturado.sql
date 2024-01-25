CREATE DEFINER=`root`@`localhost` PROCEDURE `modRemitoCompra_Facturado`(
	in rcID int(11),
	in rcFac varchar(2)
)
BEGIN
	UPDATE RemitosCompra
	SET 
        Facturado = rcFac
	WHERE 
		idRemitosCompra = rcID;
END