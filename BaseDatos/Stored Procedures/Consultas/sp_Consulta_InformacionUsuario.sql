CREATE OR ALTER PROC sp_Consulta_InformacionUsuario
(
@Cedula varchar(9)
)
AS
BEGIN
	SELECT a.Cedula, Contrasenna, CorreoElectronico as Correo, VotoPresidenteEmitido AS estadoVotoPresidente, 
	VotoDiputadoEmitido AS estadoVotoDiputado, IdEstado AS numEstado, IdPerfil as numPerfil, b.FechaVencimientoCedula
	FROM Usuarios a
	JOIN PadronNacional b on a.Cedula = b.Cedula
	WHERE a.Cedula = @Cedula
END