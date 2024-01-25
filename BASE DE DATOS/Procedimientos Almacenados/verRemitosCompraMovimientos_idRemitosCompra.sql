CREATE DEFINER=`root`@`localhost` PROCEDURE `verRemitosCompraMovimientos_idRemitosCompra`(
	in idRC int(11)
)
BEGIN
	SELECT
        RemitosCompraMovimientos.idRemitosCompraMovimientos,
        RemitosCompraMovimientos.Fecha AS rcmFecha,
        RemitosCompraMovimientos.Tipo AS rcmTipo,
        RemitosCompraMovimientos.Cantidad AS rcmCantidad,
        RemitosCompraMovimientos.Eliminado AS rcmEliminado,
        RemitosCompraMovimientos.Usuarios_idUsuarios AS rcmUsuarios_idUsuarios,
        RemitosCompraMovimientos.Stock_idStock AS rcmStock_idStock,
        DetalleRemitosCompra.idDetalleRemitosCompra,
        DetalleRemitosCompra.Descripcion AS drcDescripcion,
        DetalleRemitosCompra.Cantidad AS drcCantidad,
        DetalleRemitosCompra.Unidad AS drcUnidad,
        DetalleRemitosCompra.Precio AS drcPrecio,
        DetalleRemitosCompra.Importe AS drcImporte,
        DetalleRemitosCompra.AlicuotaIVA AS drcAlicuotaIVA,
        DetalleRemitosCompra.Facturado AS drcFacturado,
        DetalleRemitosCompra.Eliminado AS drcEliminado,
        DetalleRemitosCompra.RemitosCompra_idRemitosCompra AS drcRemitosCompra_idRemitosCompra,
        Articulos.idArticulos,
        Articulos.CodArticulo,
        Articulos.Detalle AS artDetalle,
        Depositos.idDepositos,
        Depositos.Nombre
	FROM
		RemitosCompraMovimientos JOIN DetalleRemitosCompra ON RemitosCompraMovimientos.DetalleRemitosCompra_idDetalleRemitosCompra = DetalleRemitosCompra.idDetalleRemitosCompra
								 JOIN Articulos ON DetalleRemitosCompra.Articulos_idArticulos = Articulos.idArticulos
                                 JOIN Stock ON RemitosCompraMovimientos.Stock_idStock = Stock.idStock
                                 JOIN Depositos ON Stock.Depositos_idDepositos = Depositos.idDepositos
	WHERE
		DetalleRemitosCompra.RemitosCompra_idRemitosCompra = idRC And RemitosCompraMovimientos.Eliminado = "NO";
END