-- PROCEDIMIENTO ALMACENADO QUE GUARDA EL VOTO EMITIDO, PARA DIPUTACIÓN
-- EXEC sp_Inserta_Voto_Emitido
CREATE OR ALTER PROC sp_Inserta_Voto_Emitido_Diputado
(
@Codelec varchar(6),
@CodigoPartido varchar(6)
)
AS
BEGIN
	INSERT INTO VotosRecibidos_Diputados(Codelec, PartidoVotado, FechaEmisionVoto)
	VALUES (@Codelec, @CodigoPartido, GETDATE())
END
