CREATE DEFINER=`root`@`localhost` PROCEDURE `verMovimientos_Remito_Factura_idRemitosVentaMovimientos`(
	in idRVM int(11)
)
BEGIN
	SELECT
		Movimientos_Remito_Factura.idMovimientos_Remito_Factura,
        Movimientos_Remito_Factura.Fecha AS mrfFecha,
        Movimientos_Remito_Factura.Tipo AS mrfTipo,
        Movimientos_Remito_Factura.Cantidad AS mrfCantidad,
        Movimientos_Remito_Factura.Eliminado AS mrfEliminado,
        FacturaVentaMovimientos.idFacturaVentaMovimientos,
        FacturaVentaMovimientos.Fecha AS fvmFecha,
        FacturaVentaMovimientos.Tipo AS fvmTipo,
        FacturaVentaMovimientos.Cantidad AS fvmCantidad,
        FacturaVentaMovimientos.Eliminado AS fvmEliminado,
        FacturaVentaMovimientos.Usuarios_idUsuarios AS fvmUsuarios_idUsuarios,
        RemitosVentasMovimientos.idRemitosVentasMovimientos,
        RemitosVentasMovimientos.Fecha AS rvmFecha,
        RemitosVentasMovimientos.Tipo AS rvmTipo,
        RemitosVentasMovimientos.Cantidad AS rvmCantidad,
        RemitosVentasMovimientos.Eliminado AS rvmEliminado,
        RemitosVentasMovimientos.Usuarios_idUsuarios AS rvmUsuarios_idUsuarios,
        RemitosVentasMovimientos.Stock_idStock AS rvmStock_idStock,
        FacturaVentaDetalle.idFacturaVentaDetalle,
        FacturaVentaDetalle.Descripcion AS fvdDescripcion,
		FacturaVentaDetalle.Unidad AS fvdUnidad,       
        FacturaVentaDetalle.Cantidad AS fvdCantidad,
        FacturaVentaDetalle.Precio AS fvdPrecio,
        FacturaVentaDetalle.Importe AS fvdImporte,
        FacturaVentaDetalle.AlicuotaIVA AS fvdAlicuotaIVA,
        FacturaVentaDetalle.Remitado AS fvdRemitado,
        FacturaVentaDetalle.Eliminado AS fvdEliminado,
        FacturaVentaDetalle.Articulos_idArticulos AS fvdArticulos_idArticulos,
        FacturaVenta.idFacturaVenta,
        FacturaVenta.TipoComprobante AS fvTipoComprobante,
        FacturaVenta.ClaseComprobante AS fvClaseComprobante,
        FacturaVenta.Fecha AS fvFecha,
        FacturaVenta.FechaVto AS fvFechaVto,
        FacturaVenta.Prefijo AS fvPrefijo,
        FacturaVenta.NroComprobante AS fvNroComprobante,
        FacturaVenta.ImporteNeto AS fvImporteNeto,
        FacturaVenta.DescuentoGral AS fvDescuentoGral,
        FacturaVenta.BaseImponible AS fvBaseImponible,
        FacturaVenta.Iva AS fvIva,
        FacturaVenta.ImporteTotal AS fvImporteTotal,
		FacturaVenta.Observaciones AS fvObservaciones,
        FacturaVenta.Remitado AS fvRemitado,
        FacturaVenta.Eliminado AS fvEliminado,
        FacturaVenta.CAE AS fvCAE,
        FacturaVenta.FechaVtoCAE AS fvFechaVtoCAE,
        FacturaVenta.Clientes_idClientes AS fvClientes_idClientes,
        FacturaVenta.Usuarios_idUsuarios AS fvUsuarios_idUsuarios,
        FacturaVenta.CuentaCorrienteVentas_idCuentaCorrienteVentas AS fvCuentaCorrienteVentas_idCuentaCorrienteVentas,
        DetalleRemitosVenta.idDetalleRemitosVenta,
        DetalleRemitosVenta.Descripcion AS drvDescripcion,
        DetalleRemitosVenta.Cantidad AS drvCantidad,
        DetalleRemitosVenta.Unidad AS drvUnidad,
        DetalleRemitosVenta.Precio AS drvPrecio,
        DetalleRemitosVenta.Importe AS drvImporte,
        DetalleRemitosVenta.AlicuotaIVA AS drvAlicuotaIVA,
        DetalleRemitosVenta.Facturado AS drvFacturado,
        DetalleRemitosVenta.Eliminado AS drvEliminado,
        DetalleRemitosVenta.RemitosVenta_idRemitosVenta AS drvRemitosVenta_idRemitosVenta,
        Articulos.idArticulos,
        Articulos.CodArticulo,
        Articulos.Detalle AS artDetalle,
        Depositos.idDepositos,
        Depositos.Nombre
	FROM
		Movimientos_Remito_Factura JOIN FacturaVentaMovimientos ON Movimientos_Remito_Factura.FacturaVentaMovimientos_idFacturaVentaMovimientos = FacturaVentaMovimientos.idFacturaVentaMovimientos
								   JOIN RemitosVentasMovimientos ON Movimientos_Remito_Factura.RemitosVentasMovimientos_idRemitosVentasMovimientos = RemitosVentasMovimientos.idRemitosVentasMovimientos
                                   JOIN FacturaVentaDetalle ON FacturaVentaMovimientos.FacturaVentaDetalle_idFacturaVentaDetalle = FacturaVentaDetalle.idFacturaVentaDetalle
                                   JOIN DetalleRemitosVenta ON RemitosVentasMovimientos.DetalleRemitosVenta_idDetalleRemitosVenta = DetalleRemitosVenta.idDetalleRemitosVenta
                                   JOIN Articulos ON DetalleRemitosVenta.Articulos_idArticulos = Articulos.idArticulos
                                   JOIN Stock ON RemitosVentasMovimientos.Stock_idStock = Stock.idStock
                                   JOIN Depositos ON Stock.Depositos_idDepositos = Depositos.idDepositos
                                   JOIN FacturaVenta ON FacturaVentaDetalle.FacturaVenta_idFacturaVenta = FacturaVenta.idFacturaVenta
    WHERE
		RemitosVentasMovimientos.idRemitosVentasMovimientos = idRVM And Movimientos_Remito_Factura.Eliminado = "NO";
END