CREATE DEFINER=`root`@`localhost` PROCEDURE `elimFacturaCompraMovimientos`(
	in fcmId int(11)
)
BEGIN
	UPDATE FacturaCompraMovimientos
	SET 
		Eliminado = "SI"
	WHERE 
		idFacturaCompraMovimientos = fcmId;
END
