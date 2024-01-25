CREATE DEFINER=`root`@`localhost` PROCEDURE `verMovimientos_RemitoCompra_FacturaCompra_idFacturaCompra`(
	in idFC int(11)
)
BEGIN
	SELECT
		Movimientos_RemitoCompra_FacturaCompra.idMovimientos_RemitoCompra_FacturaCompra,
        Movimientos_RemitoCompra_FacturaCompra.Fecha AS mrfFecha,
        Movimientos_RemitoCompra_FacturaCompra.Tipo AS mrfTipo,
        Movimientos_RemitoCompra_FacturaCompra.Cantidad AS mrfCantidad,
        Movimientos_RemitoCompra_FacturaCompra.Eliminado AS mrfEliminado,
        FacturaCompraMovimientos.idFacturaCompraMovimientos,
        FacturaCompraMovimientos.Fecha AS fcmFecha,
        FacturaCompraMovimientos.Tipo AS fcmTipo,
        FacturaCompraMovimientos.Cantidad AS fcmCantidad,
        FacturaCompraMovimientos.Eliminado AS fcmEliminado,
        FacturaCompraMovimientos.Usuarios_idUsuarios AS fcmUsuarios_idUsuarios,
        RemitosCompraMovimientos.idRemitosCompraMovimientos,
        RemitosCompraMovimientos.Fecha AS rcmFecha,
        RemitosCompraMovimientos.Tipo AS rcmTipo,
        RemitosCompraMovimientos.Cantidad AS rcmCantidad,
        RemitosCompraMovimientos.Eliminado AS rcmEliminado,
        RemitosCompraMovimientos.Usuarios_idUsuarios AS rcmUsuarios_idUsuarios,
        RemitosCompraMovimientos.Stock_idStock AS rcmStock_idStock,
        FacturaCompraDetalle.idFacturaCompraDetalle,
        FacturaCompraDetalle.Descripcion AS fcdDescripcion,
		FacturaCompraDetalle.Unidad AS fcdUnidad,       
        FacturaCompraDetalle.Cantidad AS fcdCantidad,
        FacturaCompraDetalle.Precio AS fcdPrecio,
        FacturaCompraDetalle.Importe AS fcdImporte,
        FacturaCompraDetalle.AlicuotaIVA AS fcdAlicuotaIVA,
        FacturaCompraDetalle.Remitado AS fcdRemitado,
        FacturaCompraDetalle.Eliminado AS fcdEliminado,
        FacturaCompraDetalle.Articulos_idArticulos AS fcdArticulos_idArticulos,
        FacturaCompra.idFacturaCompra,
        FacturaCompra.Fecha AS fcFecha,
        FacturaCompra.FechaVto AS fcFechaVto,
        FacturaCompra.Prefijo AS fcPrefijo,
        FacturaCompra.NroComprobante AS fcNroComprobante,
        FacturaCompra.ImporteNeto AS fcImporteNeto,
        FacturaCompra.DescuentoGral AS fcDescuentoGral,
        FacturaCompra.BaseImponible AS fcBaseImponible,
        FacturaCompra.Iva AS fcIva,
        FacturaCompra.ImporteTotal AS fcImporteTotal,
		FacturaCompra.Observaciones AS fcObservaciones,
        FacturaCompra.Remitado AS fcRemitado,
        FacturaCompra.Eliminado AS fcEliminado,
        FacturaCompra.Proveedores_idProveedores AS fcProveedores_idProveedores,
        FacturaCompra.Usuarios_idUsuarios AS fcUsuarios_idUsuarios,
        FacturaCompra.CuentaCorrienteCompra_idCuentaCorrienteCompra AS fcCuentaCorrienteCompra_idCuentaCorrienteCompra,
        DetalleRemitosCompra.idDetalleRemitosCompra,
        DetalleRemitosCompra.Descripcion AS drcDescripcion,
        DetalleRemitosCompra.Cantidad AS drcCantidad,
        DetalleRemitosCompra.Unidad AS drcUnidad,
        DetalleRemitosCompra.Precio AS drcPrecio,
        DetalleRemitosCompra.Importe AS drcImporte,
        DetalleRemitosCompra.AlicuotaIVA AS drcAlicuotaIVA,
        DetalleRemitosCompra.Facturado AS drcFacturado,
        DetalleRemitosCompra.Eliminado AS drcEliminado,
        DetalleRemitosCompra.RemitosCompra_idRemitosCompra AS drcRemitosVenta_idRemitosVenta,
        Articulos.idArticulos,
        Articulos.CodArticulo,
        Articulos.Detalle AS artDetalle,
        Depositos.idDepositos,
        Depositos.Nombre
	FROM
		Movimientos_RemitoCompra_FacturaCompra JOIN FacturaCompraMovimientos ON Movimientos_RemitoCompra_FacturaCompra.FacturaCompraMovimientos_idFacturaCompraMovimientos = FacturaCompraMovimientos.idFacturaCompraMovimientos
											   JOIN RemitosCompraMovimientos ON Movimientos_RemitoCompra_FacturaCompra.RemitosCompraMovimientos_idRemitosCompraMovimientos = RemitosCompraMovimientos.idRemitosCompraMovimientos
											   JOIN FacturaCompraDetalle ON FacturaCompraMovimientos.FacturaCompraDetalle_idFacturaCompraDetalle = FacturaCompraDetalle.idFacturaCompraDetalle
											   JOIN DetalleRemitosCompra ON RemitosCompraMovimientos.DetalleRemitosCompra_idDetalleRemitosCompra = DetalleRemitosCompra.idDetalleRemitosCompra
											   JOIN Articulos ON DetalleRemitosCompra.Articulos_idArticulos = Articulos.idArticulos
											   JOIN Stock ON RemitosCompraMovimientos.Stock_idStock = Stock.idStock
											   JOIN Depositos ON Stock.Depositos_idDepositos = Depositos.idDepositos
											   JOIN FacturaCompra ON FacturaCompraDetalle.FacturaCompra_idFacturaCompra = FacturaCompra.idFacturaCompra
    WHERE
		FacturaCompraDetalle.FacturaCompra_idFacturaCompra = idFC And Movimientos_RemitoCompra_FacturaCompra.Eliminado = "NO";
END
