-- PROCEDIMIENTO ALMACENADO QUE OBTIENE LA CANTIDAD DE VOTOS VÁLIDOS EMITIDOS POR PARTIDO POLÍTICO
-- EXEC sp_Consulta_Resultados_CantidadVotosEmitidos
CREATE PROC sp_Consulta_Resultados_CantidadVotosEmitidos
AS
BEGIN
	SELECT a.CodigoPartido, b.Descripcion, COUNT(*) as CantidadVotosEmitidos 
	FROM VotosEmitidos a, PartidosPoliticos b 
	WHERE a.CodigoPartido = b.CodigoPartido and a.CodigoPartido not in ('NULO','BLANCO')
	GROUP BY a.CodigoPartido, b.Descripcion
	ORDER BY CantidadVotosEmitidos DESC;
END