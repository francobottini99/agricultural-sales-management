CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdDetalleRemitosCompra`()
BEGIN
	SELECT
		Max(idDetalleRemitosCompra) as UltimoId
	FROM
		DetalleRemitosCompra;
END