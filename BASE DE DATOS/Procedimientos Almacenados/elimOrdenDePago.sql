CREATE DEFINER=`root`@`localhost` PROCEDURE `elimOrdenDePago`(
	in opId int(11)
)
BEGIN
	UPDATE OrdenDePago
	SET 
		Eliminado = "SI"
	WHERE 
		idOrdenDePago = opId;
END
