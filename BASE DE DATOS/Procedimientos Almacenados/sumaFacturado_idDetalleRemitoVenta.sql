CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaFacturado_idDetalleRemitoVenta`(
	in idDetRem int(11)
)
BEGIN
	SELECT
		Sum(Movimientos_Remito_Factura.Cantidad) as CantidadFacturada
	FROM
		Movimientos_Remito_Factura JOIN RemitosVentasMovimientos ON Movimientos_Remito_Factura.RemitosVentasMovimientos_idRemitosVentasMovimientos = RemitosVentasMovimientos.idRemitosVentasMovimientos
	WHERE 
		RemitosVentasMovimientos.DetalleRemitosVenta_idDetalleRemitosVenta = idDetRem AND Movimientos_Remito_Factura.Tipo = "FACTURADO" AND Movimientos_Remito_Factura.Eliminado = "NO";
END
