CREATE DEFINER=`root`@`localhost` PROCEDURE `elimRemitosCompraMovimientos_IdRemitoCompra`(
	in IdRemCom int(11)
)
BEGIN
	UPDATE RemitosCompraMovimientos JOIN DetalleRemitosCompra ON RemitosCompraMovimientos.DetalleRemitosCompra_idDetalleRemitosCompra = DetalleRemitosCompra.idDetalleRemitosCompra
	SET 
		RemitosCompraMovimientos.Eliminado = "SI"
	WHERE 
		DetalleRemitosCompra.RemitosCompra_idRemitosCompra = IdRemCom And RemitosCompraMovimientos.Tipo = "REMITADO";
END