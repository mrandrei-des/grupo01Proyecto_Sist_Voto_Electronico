-- PROCEDIMIENTO ALMACENADO QUE CONSULTA VOTANTES POR PROVINCIA EN EL PADRÓN NACIONAL
-- EXEC sp_Consulta_PadronNacional_x_Cedula '303210175'
CREATE PROC sp_Consulta_PadronNacional_x_Cedula
(
@CedulaVotante varchar(9)
)
AS
BEGIN
	SELECT Cedula as 'CÉDULA', Codele as 'COD_ELECTORAL', PrimerApellido AS 'PRIMER APELLIDO', SegundoApellido AS 'SEGUNDO APELLIDO', 
	Nombre as NOMBRE, FORMAT(FechaVencimientoCedula, 'dd-MM-yyyy') AS 'FECHA VENCIMIENTO CÉDULA' 
	FROM PadronNacional 
	WHERE Cedula = @CedulaVotante
	ORDER BY PrimerApellido ASC, SegundoApellido ASC, Nombre ASC, Cedula ASC 
END