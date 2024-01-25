CREATE DEFINER=`root`@`localhost` PROCEDURE `modFacturaCompraDetalle_Remitado`(
	in fcdID int(11),
	in fcdRem varchar(2)
)
BEGIN
	UPDATE FacturaCompraDetalle
	SET 
        Remitado = fcdRem
	WHERE 
		idFacturaCompraDetalle = fcdID;
END