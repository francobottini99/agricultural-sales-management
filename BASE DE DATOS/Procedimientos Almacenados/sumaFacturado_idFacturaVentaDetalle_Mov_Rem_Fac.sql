CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaFacturado_idFacturaVentaDetalle_Mov_Rem_Fac`(
	in idDetFac int(11)
)
BEGIN
	SELECT
		Sum(Movimientos_Remito_Factura.Cantidad) as CantidadFacturada
	FROM
		Movimientos_Remito_Factura JOIN FacturaVentaMovimientos ON Movimientos_Remito_Factura.FacturaVentaMovimientos_idFacturaVentaMovimientos = FacturaVentaMovimientos.idFacturaVentaMovimientos
	WHERE 
		FacturaVentaMovimientos.FacturaVentaDetalle_idFacturaVentaDetalle = idDetFac AND Movimientos_Remito_Factura.Tipo = "FACTURADO" AND Movimientos_Remito_Factura.Eliminado = "NO";
END