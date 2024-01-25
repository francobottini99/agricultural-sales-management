CREATE DEFINER=`root`@`localhost` PROCEDURE `verFacturaCompraMovimientos_idFacturaCompra`(
	in idFC int(11)
)
BEGIN
	SELECT
        FacturaCompraMovimientos.idFacturaCompraMovimientos,
        FacturaCompraMovimientos.Fecha AS fcmFecha,
        FacturaCompraMovimientos.Tipo AS fcmTipo,
        FacturaCompraMovimientos.Cantidad AS fcmCantidad,
        FacturaCompraMovimientos.Eliminado AS fcmEliminado,
        FacturaCompraMovimientos.Usuarios_idUsuarios AS fcmUsuarios_idUsuarios,
        FacturaCompraDetalle.idFacturaCompraDetalle,
        FacturaCompraDetalle.Descripcion AS dfcDescripcion,
        FacturaCompraDetalle.Cantidad AS dfcCantidad,
        FacturaCompraDetalle.Unidad AS dfcUnidad,
        FacturaCompraDetalle.Precio AS dfcPrecio,
        FacturaCompraDetalle.Importe AS dfcImporte,
        FacturaCompraDetalle.AlicuotaIVA AS dfcAlicuotaIVA,
        FacturaCompraDetalle.Remitado AS dfcRemitado,
        FacturaCompraDetalle.Eliminado AS dfcEliminado,
        FacturaCompraDetalle.FacturaCompra_idFacturaCompra AS dfcFacturaCompra_idFacturaCompra,
        Articulos.idArticulos,
        Articulos.CodArticulo,
        Articulos.Detalle AS artDetalle
	FROM
		FacturaCompraMovimientos JOIN FacturaCompraDetalle ON FacturaCompraMovimientos.FacturaCompraDetalle_idFacturaCompraDetalle = FacturaCompraDetalle.idFacturaCompraDetalle
								 JOIN Articulos ON FacturaCompraDetalle.Articulos_idArticulos = Articulos.idArticulos
	WHERE
		FacturaCompraDetalle.FacturaCompra_idFacturaCompra = idFC And FacturaCompraMovimientos.Eliminado = "NO";
END