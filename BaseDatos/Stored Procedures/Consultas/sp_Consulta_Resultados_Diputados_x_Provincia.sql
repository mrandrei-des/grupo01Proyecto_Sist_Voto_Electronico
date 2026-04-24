-- PROCEDIMIENTO ALMACENADO QUE OBTIENE LA CANTIDAD DE VOTOS VÁLIDOS EMITIDOS POR PARTIDO POLÍTICO
-- EXEC sp_Consulta_Resultados_Diputados_x_Provincia '1'
CREATE OR ALTER PROC sp_Consulta_Resultados_Diputados_x_Provincia
(
@CodProvincia varchar(1)
)
AS
BEGIN
	SELECT a.PartidoVotado AS CodigoPartido, b.Descripcion, COUNT(*) as CantidadVotosEmitidos 
	FROM VotosRecibidos_Diputados a, PartidosPoliticos b 
	WHERE a.PartidoVotado = b.CodigoPartido and a.PartidoVotado not in ('NULO','BLANCO') 
	and LEFT(a.Codelec, 1) = @CodProvincia 
	GROUP BY a.PartidoVotado, b.Descripcion
	ORDER BY CantidadVotosEmitidos DESC;
END
