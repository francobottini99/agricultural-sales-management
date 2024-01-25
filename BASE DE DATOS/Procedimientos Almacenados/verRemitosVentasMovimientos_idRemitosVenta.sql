CREATE DEFINER=`root`@`localhost` PROCEDURE `verRemitosVentasMovimientos_idRemitosVenta`(
	in idRV int(11)
)
BEGIN
	SELECT
        RemitosVentasMovimientos.idRemitosVentasMovimientos,
        RemitosVentasMovimientos.Fecha AS rvmFecha,
        RemitosVentasMovimientos.Tipo AS rvmTipo,
        RemitosVentasMovimientos.Cantidad AS rvmCantidad,
        RemitosVentasMovimientos.Eliminado AS rvmEliminado,
        RemitosVentasMovimientos.Usuarios_idUsuarios AS rvmUsuarios_idUsuarios,
        RemitosVentasMovimientos.Stock_idStock AS rvmStock_idStock,
        DetalleRemitosVenta.idDetalleRemitosVenta,
        DetalleRemitosVenta.Descripcion AS drvDescripcion,
        DetalleRemitosVenta.Cantidad AS drvCantidad,
        DetalleRemitosVenta.Unidad AS drvUnidad,
        DetalleRemitosVenta.Precio AS drvPrecio,
        DetalleRemitosVenta.Importe AS drvImporte,
        DetalleRemitosVenta.AlicuotaIVA AS drvAlicuotaIVA,
        DetalleRemitosVenta.Facturado AS drvFacturado,
        DetalleRemitosVenta.Eliminado AS drvEliminado,
        DetalleRemitosVenta.Articulos_idArticulos AS drvArticulos_idArticulos,
        DetalleRemitosVenta.RemitosVenta_idRemitosVenta AS drvRemitosVenta_idRemitosVenta,
        Articulos.idArticulos,
        Articulos.CodArticulo,
        Articulos.Detalle AS artDetalle,
        Depositos.idDepositos,
        Depositos.Nombre
	FROM
		RemitosVentasMovimientos JOIN DetalleRemitosVenta ON RemitosVentasMovimientos.DetalleRemitosVenta_idDetalleRemitosVenta = DetalleRemitosVenta.idDetalleRemitosVenta
								 JOIN Articulos ON DetalleRemitosVenta.Articulos_idArticulos = Articulos.idArticulos
                                 JOIN Stock ON RemitosVentasMovimientos.Stock_idStock = Stock.idStock
                                 JOIN Depositos ON Stock.Depositos_idDepositos = Depositos.idDepositos
	WHERE
		DetalleRemitosVenta.RemitosVenta_idRemitosVenta = idRV And RemitosVentasMovimientos.Eliminado = "NO";
END