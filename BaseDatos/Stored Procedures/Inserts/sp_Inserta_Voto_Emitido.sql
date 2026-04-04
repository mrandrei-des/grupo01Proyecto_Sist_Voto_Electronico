-- PROCEDIMIENTO ALMACENADO QUE GUARDA EL VOTO EMITIDO, PUEDE SER EL VOTO PRESIDENCIAL O POR DIPUTACIÓN
-- EXEC sp_Inserta_Voto_Emitido
CREATE PROC sp_Inserta_Voto_Emitido
(
@Cedula varchar(9),
@TipoEleccion smallint,
@Codele varchar(6),
@CodigoPartido varchar(6),
@CodigoCandidato varchar(50)
)
AS
BEGIN
	INSERT INTO VotosEmitidos (Cedula, IdTipoEleccion, Codele, NumeroJuntaReceptora, CodigoPartido, CodigoCandidato, FechaEmisionVoto)
	VALUES (@Cedula, @TipoEleccion, @Codele, '00000', @CodigoPartido, @CodigoCandidato, GETDATE())
END
