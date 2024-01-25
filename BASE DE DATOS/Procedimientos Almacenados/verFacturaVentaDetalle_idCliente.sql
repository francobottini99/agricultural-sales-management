CREATE DEFINER=`root`@`localhost` PROCEDURE `verFacturaVentaDetalle_idCliente`(
	in idCli int(11)
)
BEGIN
	SELECT
		FacturaVentaDetalle.*,
		FacturaVenta.*, 
        Articulos.Detalle,
        Articulos.CodArticulo
	FROM
		FacturaVentaDetalle JOIN FacturaVenta ON FacturaVentaDetalle.FacturaVenta_idFacturaVenta = FacturaVenta.idFacturaVenta
					        JOIN Articulos ON FacturaVentaDetalle.Articulos_idArticulos = Articulos.idArticulos
	WHERE
		FacturaVenta.Clientes_idClientes = idCli And FacturaVentaDetalle.Eliminado = "NO";
END