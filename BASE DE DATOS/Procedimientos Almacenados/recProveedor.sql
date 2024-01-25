CREATE DEFINER=`root`@`localhost` PROCEDURE `recProveedor`(
	in idP int(11)
)
BEGIN
	UPDATE Proveedores
	SET 
		Eliminado = "NO"
	WHERE 
		idProveedores = idP;
END