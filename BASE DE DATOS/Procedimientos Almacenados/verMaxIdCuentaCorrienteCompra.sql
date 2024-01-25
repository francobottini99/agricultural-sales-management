CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdCuentaCorrienteCompra`()
BEGIN
	SELECT
		Max(idCuentaCorrienteCompra) as UltimoId
	FROM
		CuentaCorrienteCompra;
END