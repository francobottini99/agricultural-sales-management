CREATE DEFINER=`root`@`localhost` PROCEDURE `modFacturaVenta_Remitado`(
	in fvID int(11),
	in fvRem varchar(2)
)
BEGIN
	UPDATE FacturaVenta
	SET 
        Remitado = fvRem
	WHERE 
		idFacturaVenta = fvID;
END