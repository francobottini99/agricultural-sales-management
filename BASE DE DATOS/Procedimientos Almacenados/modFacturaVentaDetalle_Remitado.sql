CREATE DEFINER=`root`@`localhost` PROCEDURE `modFacturaVentaDetalle_Remitado`(
	in fvdID int(11),
	in fvdRem varchar(2)
)
BEGIN
	UPDATE FacturaVentaDetalle
	SET 
        Remitado = fvdRem
	WHERE 
		idFacturaVentaDetalle = fvdID;
END