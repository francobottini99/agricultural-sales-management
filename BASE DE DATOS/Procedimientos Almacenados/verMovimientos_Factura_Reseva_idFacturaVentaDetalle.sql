CREATE DEFINER=`root`@`localhost` PROCEDURE `verMovimientos_Factura_Reseva_idFacturaVentaDetalle`(
	in idDfv int(11)
)
BEGIN
	SELECT
		Movimientos_Factura_Reseva.idMovimientos_Factura_Reseva,
        Movimientos_Factura_Reseva.Fecha AS mfrFecha,
        Movimientos_Factura_Reseva.Tipo AS mfrTipo,
        Movimientos_Factura_Reseva.Cantidad AS mfrCantidad,
        Movimientos_Factura_Reseva.Eliminado AS mfrEliminado,
        PedidosMovimientos.idPedidosMovimientos,
        PedidosMovimientos.Fecha AS pmFecha,
        PedidosMovimientos.Tipo AS pmTipo,
        PedidosMovimientos.Cantidad AS pmCantidad,
        PedidosMovimientos.Eliminado AS pmEliminado,
        PedidosMovimientos.Usuarios_idUsuarios AS pmUsuarios_idUsuarios,
        PedidosMovimientos.Stock_idStock AS pmStock_idStock,
        FacturaVentaMovimientos.idFacturaVentaMovimientos,
        FacturaVentaMovimientos.Fecha AS fvmFecha,
        FacturaVentaMovimientos.Tipo AS fvmTipo,
        FacturaVentaMovimientos.Cantidad AS fvmCantidad,
        FacturaVentaMovimientos.Eliminado AS fvmEliminado,
        FacturaVentaMovimientos.Usuarios_idUsuarios AS fvmUsuarios_idUsuarios,
		PedidosDetalle.idPedidosDetalle,
        PedidosDetalle.Cantidad AS pdCantidad,
        PedidosDetalle.Remitado AS pdRemitado,
        PedidosDetalle.Facturado AS pdFacturado,
        PedidosDetalle.Eliminado AS pdEliminado,
        PedidosDetalle.Articulos_idArticulos AS pdArticulos_idArticulos,
        Pedidos.idPedidos,
        Pedidos.NroPedido AS pNroPedido,
        Pedidos.Fecha AS pFecha,
        Pedidos.FechaCierrePedido AS pFechaCierrePedido,
        Pedidos.Remitado AS pRemitado,
        Pedidos.Facturado AS pFacturado,
        Pedidos.Observaciones AS pObservaciones,
        Pedidos.Eliminado AS pEliminado,
        Pedidos.Usuarios_idUsuarios AS pUsuarios_idUsuarios,
        Pedidos.Clientes_idClientes AS pClientes_idClientes,
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
        Articulos.idArticulos,
        Articulos.CodArticulo,
        Articulos.Detalle AS artDetalle
	FROM
		Movimientos_Factura_Reseva JOIN PedidosMovimientos ON Movimientos_Factura_Reseva.PedidosMovimientos_idPedidosMovimientos = PedidosMovimientos.idPedidosMovimientos
								   JOIN FacturaVentaMovimientos ON Movimientos_Factura_Reseva.FacturaVentaMovimientos_idRemitosMovimientos = FacturaVentaMovimientos.idFacturaVentaMovimientos
                                   JOIN PedidosDetalle ON PedidosMovimientos.PedidosDetalle_idPedidosDetalle = PedidosDetalle.idPedidosDetalle
                                   JOIN FacturaVentaDetalle ON FacturaVentaMovimientos.FacturaVentaDetalle_idFacturaVentaDetalle = FacturaVentaDetalle.idFacturaVentaDetalle
                                   JOIN Articulos ON FacturaVentaDetalle.Articulos_idArticulos = Articulos.idArticulos
                                   JOIN Pedidos ON PedidosDetalle.Pedidos_idPedidos = Pedidos.idPedidos
                                   JOIN FacturaVenta ON FacturaVentaDetalle.FacturaVenta_idFacturaVenta = FacturaVenta.idFacturaVenta
    WHERE
		FacturaVentaDetalle.idFacturaVentaDetalle = idDfv And Movimientos_Factura_Reseva.Eliminado = "NO";
END