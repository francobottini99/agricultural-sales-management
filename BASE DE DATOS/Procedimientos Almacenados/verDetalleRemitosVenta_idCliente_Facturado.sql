CREATE DEFINER=`root`@`localhost` PROCEDURE `verDetalleRemitosVenta_idCliente_Facturado`(
	in idCli int(11),
    in fac varchar(2)
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
		RemitosVenta.Clientes_idClientes = idCli And DetalleRemitosVenta.Facturado = fac And DetalleRemitosVenta.Eliminado = "NO";
END