-- PROCEDIMIENTO ALMACENADO QUE GUARDA EL VOTO EMITIDO, PUEDE SER EL VOTO PRESIDENCIAL O POR DIPUTACIÓN
-- EXEC sp_Inserta_Voto_Emitido_Presidente
CREATE OR ALTER PROC sp_Inserta_Voto_Emitido_Presidente
(
@Codelec varchar(6),
@CodigoPartido varchar(6),
@CodigoCandidato varchar(50)
)
AS
BEGIN
	INSERT INTO VotosRecibidos_Presidente (Codelec, PartidoVotado, CandidatoVotado, FechaEmisionVoto)
	VALUES (@Codelec, @CodigoPartido, @CodigoCandidato, GETDATE())
END
