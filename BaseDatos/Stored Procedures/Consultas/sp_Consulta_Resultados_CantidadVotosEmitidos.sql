CREATE PROC sp_Consulta_Resultados_CantidadVotosEmitidos
AS
BEGIN
	SELECT a.CodigoPartido, b.Descripcion, COUNT(*) as CantidadVotosEmitidos 
	FROM VotosEmitidos a, PartidosPoliticos b 
	WHERE a.CodigoPartido = b.CodigoPartido and a.CodigoPartido not in ('NULO','BLANCO')
	GROUP BY a.CodigoPartido, b.Descripcion
	ORDER BY CantidadVotosEmitidos DESC;
END



with cte_votosValidos 
as
(
SELECT a.CodigoPartido, b.Descripcion, COUNT(*) as CantidadVotosEmitidos 
FROM VotosEmitidos a, PartidosPoliticos b 
WHERE a.CodigoPartido = b.CodigoPartido and a.CodigoPartido not in ('NULO','BLANCO')
GROUP BY a.CodigoPartido, b.Descripcion
)

SELECT SUM(CantidadVotosEmitidos) AS Dividendo
FROM cte_votosValidos 

DECLARE @Dividendo float, @Diputados_x_Provincia int, @Cociente float, @Subcociente float, @Diputados_x_CifraResidual int
SET @Dividendo = 13
SET @Diputados_x_Provincia = (SELECT Cantidad FROM Diputados_x_Provincia WHERE CodigoProvincia = '3')
SET @Cociente = (@Dividendo / @Diputados_x_Provincia)

SET @Subcociente = (@Cociente / 2)

SELECT @Dividendo as Dividendo, @Diputados_x_Provincia as Diputados_x_Provincia, @Cociente as Cociente, @Subcociente as Subcociente

SELECT a.CodigoPartido, b.Descripcion, COUNT(*) as CantidadVotosEmitidos 
FROM VotosEmitidos a, PartidosPoliticos b 
WHERE a.CodigoPartido = b.CodigoPartido and a.CodigoPartido not in ('NULO','BLANCO') 
GROUP BY a.CodigoPartido, b.Descripcion
HAVING COUNT(*) >= @Subcociente
ORDER BY CantidadVotosEmitidos DESC;

SELECT a.CodigoPartido, b.Descripcion, ROUND((COUNT(*) / @Cociente), 0) AS CantidadDiputadosCociente
FROM VotosEmitidos a, PartidosPoliticos b 
WHERE a.CodigoPartido = b.CodigoPartido and a.CodigoPartido not in ('NULO','BLANCO') 
GROUP BY a.CodigoPartido, b.Descripcion
HAVING COUNT(*) >= @Subcociente
ORDER BY ROUND((COUNT(*) / @Cociente), 0) DESC

SET @Diputados_x_CifraResidual = @Diputados_x_Provincia - 4

SELECT @Diputados_x_CifraResidual as DiputadosCifraResidual

SELECT a.CodigoPartido, b.Descripcion, (COUNT(*) - ROUND((COUNT(*) / @Cociente), 0)) AS CantidadDiputadosCociente
FROM VotosEmitidos a, PartidosPoliticos b 
WHERE a.CodigoPartido = b.CodigoPartido and a.CodigoPartido not in ('NULO','BLANCO') 
GROUP BY a.CodigoPartido, b.Descripcion
HAVING COUNT(*) >= @Subcociente
ORDER BY (COUNT(*) - ROUND((COUNT(*) / @Cociente), 0)) DESC
