CREATE DEFINER=`root`@`localhost` PROCEDURE `elimProveedor`(
	in IdP int(11)
)
BEGIN
	UPDATE Proveedores
	SET 
		Eliminado = "SI"
	WHERE 
		idProveedores = IdP;
END