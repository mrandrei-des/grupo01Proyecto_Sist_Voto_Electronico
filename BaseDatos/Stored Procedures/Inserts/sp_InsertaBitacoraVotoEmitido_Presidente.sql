-- PROCEDIMIENTO ALMACENADO QUE GUARDA UN REGISTRO DE LA FECHA Y HORA EN QUE EL VOTANTE EMITIÓ EL SUFRAGIO PARA PRESIDENTE, ESTO SIMULANDO LA FIRMA QUE SE HACE REALMENTE
-- EXEC sp_InsertaBitacoraVotoEmitido_Presidente ''
CREATE OR ALTER PROC sp_InsertaBitacoraVotoEmitido_Presidente
(
@CedulaVotante varchar(9)
)
AS
BEGIN
	INSERT INTO BitacoraVotoEmitido_Presidente(Cedula, FechaEmisionVoto)
	VALUES (@CedulaVotante, GETDATE())
END