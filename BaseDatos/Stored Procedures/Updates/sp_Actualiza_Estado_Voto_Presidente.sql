-- PROCEDIMIENTO ALMACENADO QUE ACTUALIZA EL ESTADO DEL VOTANTE UNA VEZ EMITIÓ EL SUFRAGIO PARA PRESIDENCIA
-- EXEC sp_Actualiza_Estado_Voto_Presidente
ALTER PROC sp_Actualiza_Estado_Voto_Presidente
(
@CedulaUsuario varchar(9)
)
AS
BEGIN
	UPDATE Usuarios SET VotoPresidenteEmitido = 1
	WHERE Cedula = @CedulaUsuario

	IF(SELECT VotoDiputadoEmitido FROM Usuarios WHERE Cedula = @CedulaUsuario) = 1
		BEGIN
			UPDATE Usuarios SET IdEstado = 3
			WHERE Cedula = @CedulaUsuario
		END
END
