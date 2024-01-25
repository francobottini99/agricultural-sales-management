CREATE DEFINER=`root`@`localhost` PROCEDURE `verMovimientos_Reserva_Remito_idRemitosVenta`(
	in idRV int(11)
)
BEGIN
	SELECT
		Movimientos_Reserva_Remito.idMovimientos_Reserva_Remito,
        Movimientos_Reserva_Remito.Fecha AS mrrFecha,
        Movimientos_Reserva_Remito.Tipo AS mrrTipo,
        Movimientos_Reserva_Remito.Cantidad AS mrrCantidad,
        Movimientos_Reserva_Remito.Eliminado AS mrrEliminado,
        PedidosMovimientos.idPedidosMovimientos,
        PedidosMovimientos.Fecha AS pmFecha,
        PedidosMovimientos.Tipo AS pmTipo,
        PedidosMovimientos.Cantidad AS pmCantidad,
        PedidosMovimientos.Eliminado AS pmEliminado,
        PedidosMovimientos.Usuarios_idUsuarios AS pmUsuarios_idUsuarios,
        PedidosMovimientos.Stock_idStock AS pmStock_idStock,
        RemitosVentasMovimientos.idRemitosVentasMovimientos,
        RemitosVentasMovimientos.Fecha AS rvmFecha,
        RemitosVentasMovimientos.Tipo AS rvmTipo,
        RemitosVentasMovimientos.Cantidad AS rvmCantidad,
        RemitosVentasMovimientos.Eliminado AS rvmEliminado,
        RemitosVentasMovimientos.Usuarios_idUsuarios AS rvmUsuarios_idUsuarios,
        RemitosVentasMovimientos.Stock_idStock AS rvmStock_idStock,
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
		Movimientos_Reserva_Remito JOIN PedidosMovimientos ON Movimientos_Reserva_Remito.PedidosMovimientos_idPedidosMovimientos = PedidosMovimientos.idPedidosMovimientos
								   JOIN RemitosVentasMovimientos ON Movimientos_Reserva_Remito.RemitosVentasMovimientos_idRemitosMovimientos = RemitosVentasMovimientos.idRemitosVentasMovimientos
                                   JOIN PedidosDetalle ON PedidosMovimientos.PedidosDetalle_idPedidosDetalle = PedidosDetalle.idPedidosDetalle
                                   JOIN DetalleRemitosVenta ON RemitosVentasMovimientos.DetalleRemitosVenta_idDetalleRemitosVenta = DetalleRemitosVenta.idDetalleRemitosVenta
                                   JOIN Articulos ON DetalleRemitosVenta.Articulos_idArticulos = Articulos.idArticulos
                                   JOIN Stock ON RemitosVentasMovimientos.Stock_idStock = Stock.idStock
                                   JOIN Depositos ON Stock.Depositos_idDepositos = Depositos.idDepositos
                                   JOIN Pedidos ON PedidosDetalle.Pedidos_idPedidos = Pedidos.idPedidos
    WHERE
		DetalleRemitosVenta.RemitosVenta_idRemitosVenta = idRV And Movimientos_Reserva_Remito.Eliminado = "NO";
END