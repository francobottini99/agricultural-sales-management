CREATE DEFINER=`root`@`localhost` PROCEDURE `modRemitoVenta_Facturado`(
	in rcID int(11),
	in rcFac varchar(2)
)
BEGIN
	UPDATE RemitosVenta
	SET 
        Facturado = rcFac
	WHERE 
		idRemitosVenta = rcID;
END