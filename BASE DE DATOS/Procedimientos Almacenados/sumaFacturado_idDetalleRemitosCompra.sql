CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaFacturado_idDetalleRemitosCompra`(
	in idDetRem int(11)
)
BEGIN
	SELECT
		Sum(Movimientos_RemitoCompra_FacturaCompra.Cantidad) as CantidadFacturada
	FROM
		Movimientos_RemitoCompra_FacturaCompra JOIN RemitosCompraMovimientos ON Movimientos_RemitoCompra_FacturaCompra.RemitosCompraMovimientos_idRemitosCompraMovimientos = RemitosCompraMovimientos.idRemitosCompraMovimientos
	WHERE 
		RemitosCompraMovimientos.DetalleRemitosCompra_idDetalleRemitosCompra = idDetRem AND Movimientos_RemitoCompra_FacturaCompra.Tipo = "FACTURADO" AND Movimientos_RemitoCompra_FacturaCompra.Eliminado = "NO";
END