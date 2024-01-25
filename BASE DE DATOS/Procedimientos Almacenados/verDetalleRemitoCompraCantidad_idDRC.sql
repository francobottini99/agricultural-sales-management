CREATE DEFINER=`root`@`localhost` PROCEDURE `verDetalleRemitoCompraCantidad_idDRC`(
	in idDRC int(11)
)
BEGIN
	SELECT
        DetalleRemitosCompra.Cantidad
	FROM
		DetalleRemitosCompra
	WHERE
		idDetalleRemitosCompra = idDRC;
END