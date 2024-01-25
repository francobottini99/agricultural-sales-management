CREATE DEFINER=`root`@`localhost` PROCEDURE `elimDetalleRemCompra_IdArticulo_IdRemCompra`(
	in IdRc int(11),
    in IdArt int(11)
)
BEGIN
	UPDATE DetalleRemitosCompra
	SET 
		Eliminado = "SI"
	WHERE 
		RemitosCompra_idRemitosCompra = IdRc AND Articulos_idArticulos = IdArt;
END