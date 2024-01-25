CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdDetalleRemitosVenta`()
BEGIN
	SELECT
		Max(idDetalleRemitosVenta) as UltimoId
	FROM
		DetalleRemitosVenta;
END