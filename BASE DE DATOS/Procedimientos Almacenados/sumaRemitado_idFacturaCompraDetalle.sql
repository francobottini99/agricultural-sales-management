CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaRemitado_idFacturaCompraDetalle`(
	in idDetFac int(11)
)
BEGIN
	SELECT
		Sum(Movimientos_RemitoCompra_FacturaCompra.Cantidad) as CantidadRemitada
	FROM
		Movimientos_RemitoCompra_FacturaCompra JOIN FacturaCompraMovimientos ON Movimientos_RemitoCompra_FacturaCompra.FacturaCompraMovimientos_idFacturaCompraMovimientos = FacturaCompraMovimientos.idFacturaCompraMovimientos
	WHERE 
		FacturaCompraMovimientos.FacturaCompraDetalle_idFacturaCompraDetalle = idDetFac AND Movimientos_RemitoCompra_FacturaCompra.Tipo = "REMITADO" AND Movimientos_RemitoCompra_FacturaCompra.Eliminado = "NO";
END
