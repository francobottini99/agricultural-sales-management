CREATE DEFINER=`root`@`localhost` PROCEDURE `elimDetalleRemVenta_IdArticulo_IdRemVenta`(
	in IdRc int(11),
    in IdArt int(11)
)
BEGIN
	UPDATE DetalleRemitosVenta
	SET 
		Eliminado = "SI"
	WHERE 
		RemitosVenta_idRemitosVenta = IdRc AND Articulos_idArticulos = IdArt;
END