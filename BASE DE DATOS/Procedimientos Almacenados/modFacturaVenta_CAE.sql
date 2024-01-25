CREATE DEFINER=`root`@`localhost` PROCEDURE `modFacturaVenta_CAE`(
	in fvID int(11),
	in fvCAE varchar(100),
    in fvFcCAE date
)
BEGIN
	UPDATE FacturaVenta
	SET 
        CAE = fvCAE,
        FechaVtoCAE = fvFcCAE
	WHERE 
		idFacturaVenta = fvID;
END
