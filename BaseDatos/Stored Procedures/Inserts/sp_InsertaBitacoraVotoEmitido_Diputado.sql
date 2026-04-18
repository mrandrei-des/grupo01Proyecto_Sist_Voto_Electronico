-- PROCEDIMIENTO ALMACENADO QUE GUARDA UN REGISTRO DE LA FECHA Y HORA EN QUE EL VOTANTE EMITIÓ EL SUFRAGIO PARA DIPUTADOS, ESTO SIMULANDO LA FIRMA QUE SE HACE REALMENTE
-- EXEC sp_InsertaBitacoraVotoEmitido_Diputado ''
CREATE OR ALTER PROC sp_InsertaBitacoraVotoEmitido_Diputado
(
@CedulaVotante varchar(9)
)
AS
BEGIN
	INSERT INTO BitacoraVotoEmitido_Diputados(Cedula, FechaEmisionVoto)
	VALUES (@CedulaVotante, GETDATE())
END