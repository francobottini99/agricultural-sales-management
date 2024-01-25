CREATE DEFINER=`root`@`localhost` PROCEDURE `verDetalleRemitoCompraCantidadFacturada_idDRC`(
	in idDRC int(11)
)
BEGIN
	SELECT
        DetalleRemitosCompra.CantidadFacturada
	FROM
		DetalleRemitosCompra
	WHERE
		idDetalleRemitosCompra = idDRC;
END