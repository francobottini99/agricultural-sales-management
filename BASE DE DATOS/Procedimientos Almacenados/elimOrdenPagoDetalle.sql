CREATE DEFINER=`root`@`localhost` PROCEDURE `elimOrdenPagoDetalle`(
	in opdId int(11)
)
BEGIN
	UPDATE OrdenPagoDetalle
	SET 
		Eliminado = "SI"
	WHERE 
		idOrdenPagoDetalle = opdId;
END