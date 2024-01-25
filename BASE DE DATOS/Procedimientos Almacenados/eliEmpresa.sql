CREATE DEFINER=`root`@`localhost` PROCEDURE `eliEmpresa`(
	in id int(11)
)
BEGIN
	DELETE
	FROM
		Empresa
	WHERE
		idEmpresa = ID;
END