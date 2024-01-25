CREATE DEFINER=`root`@`localhost` PROCEDURE `elimRemitosCompraMovimientos`(
	in rcmId int(11)
)
BEGIN
	UPDATE RemitosCompraMovimientos
	SET 
		Eliminado = "SI"
	WHERE 
		idRemitosCompraMovimientos = rcmId;
END
