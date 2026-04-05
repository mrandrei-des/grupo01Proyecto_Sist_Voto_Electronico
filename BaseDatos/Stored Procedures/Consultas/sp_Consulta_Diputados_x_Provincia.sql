-- PROCEDIMIENTO ALMACENADO QUE CONSULTA LA CANTIDAD DE DIPUTADOS A DISTRIBUIR EN LA PROVINCIA INDICADA
-- EXEC sp_Consulta_Diputados_x_Provincia '2'
CREATE PROC sp_Consulta_Diputados_x_Provincia
(
@CodProvincia varchar(1)
)
AS
BEGIN
	SELECT CodigoProvincia as CodProvincia, Cantidad 
	FROM Diputados_x_Provincia
	WHERE CodigoProvincia = @CodProvincia
END
