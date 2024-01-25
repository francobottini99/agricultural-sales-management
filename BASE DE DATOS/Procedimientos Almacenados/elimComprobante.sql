CREATE DEFINER=`root`@`localhost` PROCEDURE `elimComprobante`(
	in idC int(11)
)
BEGIN
	UPDATE RemitosCompra
	SET 
		Eliminado = "SI"
	WHERE 
		idRemitosCompra = idC;
END