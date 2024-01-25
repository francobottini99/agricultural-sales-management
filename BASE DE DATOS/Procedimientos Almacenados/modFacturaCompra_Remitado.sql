CREATE DEFINER=`root`@`localhost` PROCEDURE `modFacturaCompra_Remitado`(
	in fcID int(11),
	in fcRem varchar(2)
)
BEGIN
	UPDATE FacturaCompra
	SET 
        Remitado = fcRem
	WHERE 
		idFacturaCompra = fcID;
END
