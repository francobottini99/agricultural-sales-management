CREATE DEFINER=`root`@`localhost` PROCEDURE `verDetalleRemitosVenta_idCliente`(
	in idCli int(11)
)
BEGIN
	SELECT
		DetalleRemitosVenta.*,
		RemitosVenta.*, 
        Articulos.Detalle,
        Articulos.CodArticulo
	FROM
		DetalleRemitosVenta JOIN RemitosVenta ON DetalleRemitosVenta.RemitosVenta_idRemitosVenta = RemitosVenta.idRemitosVenta
					        JOIN Articulos ON DetalleRemitosVenta.Articulos_idArticulos = Articulos.idArticulos
	WHERE
		RemitosVenta.Clientes_idClientes = idCli And DetalleRemitosVenta.Eliminado = "NO";
END