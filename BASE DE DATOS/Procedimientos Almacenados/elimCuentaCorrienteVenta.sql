CREATE DEFINER=`root`@`localhost` PROCEDURE `elimCuentaCorrienteVenta`(
	in IdCv int(11)
)
BEGIN
	UPDATE CuentaCorrienteVenta
	SET 
		Eliminado = "SI"
	WHERE 
		idCuentaCorrienteVentas = IdCv;
END