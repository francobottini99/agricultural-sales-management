CREATE DEFINER=`root`@`localhost` PROCEDURE `elimCuentaCorrienteCompra`(
	in IdCc int(11)
)
BEGIN
	UPDATE CuentaCorrienteCompra
	SET 
		Eliminado = "SI"
	WHERE 
		idCuentaCorrienteCompra = IdCc;
END