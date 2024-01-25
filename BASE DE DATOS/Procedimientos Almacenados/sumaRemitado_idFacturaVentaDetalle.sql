CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaRemitado_idFacturaVentaDetalle`(
	in idDetFac int(11)
)
BEGIN
	SELECT
		Sum(Movimientos_Remito_Factura.Cantidad) as CantidadRemitada
	FROM
		Movimientos_Remito_Factura JOIN FacturaVentaMovimientos ON Movimientos_Remito_Factura.FacturaVentaMovimientos_idFacturaVentaMovimientos = FacturaVentaMovimientos.idFacturaVentaMovimientos
	WHERE 
		FacturaVentaMovimientos.FacturaVentaDetalle_idFacturaVentaDetalle = idDetFac AND Movimientos_Remito_Factura.Tipo = "REMITADO" AND Movimientos_Remito_Factura.Eliminado = "NO";
END