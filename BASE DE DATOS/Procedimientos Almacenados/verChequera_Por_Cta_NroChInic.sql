CREATE DEFINER=`root`@`localhost` PROCEDURE `verChequera_Por_Cta_NroChInic`(
	in NroCta varchar(100),
    in NroCh int(11)
)
BEGIN
	SELECT
		*
	FROM
		Chequera
	WHERE
		NroCuenta = NroCta And NroChqInicial = NroCh  And Eliminada = "NO";
END