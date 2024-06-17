
CREATE PROCEDURE SP_CRUD_ESTUDIANTES
(
	@procedimiento   INT,
	@IDEstudiante    NVARCHAR(12)=NULL,
	@NombreCompleto  NVARCHAR(40)=NULL,
	@FechaNAcimiento DATE=NULL,
	@Direccion       NVARCHAR(30)=NULL,
	@Telefono        NVARCHAR(10)=NULL,
	@Correo          NVARCHAR(30)=NULL,
	@IDGrado         NVARCHAR(10)=NULL,
	@IDUsuario       NVARCHAR(10)=NULL
)AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @Registro INT

	IF @procedimiento = 1
		BEGIN
			SELECT

				E.IDEstudiante,
				E.NombreCompleto,
				E.FechaNacimiento,
				DATEDIFF(YEAR, E.FechaNacimiento, GETDATE()) - 
				CASE 
					WHEN MONTH(GETDATE()) < MONTH(E.FechaNacimiento) OR 
						 (MONTH(GETDATE()) = MONTH(E.FechaNacimiento) AND DAY(GETDATE()) < DAY(E.FechaNacimiento))
					THEN 1 
					ELSE 0 
				END AS Edad,
				E.Direccion,
				E.Telefono,
				E.Correo,
				G.IDGrado,
				U.IDUsuario

			FROM 

				Estudiantes E WITH(NOLOCK)
				INNER JOIN Grados G ON G.IDGrado = E.IDGrado
				INNER JOIN Usuarios U ON U.IDUsuario = E.IDUsuario

			WHERE

				E.IDEstudiante = @IDEstudiante;
		END

	IF @procedimiento = 2
		BEGIN
			SELECT TOP 1 @Registro = 1
			FROM Estudiantes WITH(NOLOCK)
			WHERE IDEstudiante = @IDEstudiante;

		IF @@ROWCOUNT = 1
			BEGIN
				SELECT 300 AS error
				RETURN
			END
		BEGIN TRANSACTION
			INSERT INTO Estudiantes
				(
					IDEstudiante,
					NombreCompleto,
					FechaNacimiento,
					Direccion,
					Telefono,
					Correo,
					IDGrado,
					IDUsuario
				)

			VALUES
				(
					@IDEstudiante,
					@NombreCompleto,
					@FechaNAcimiento,
					@Direccion,
					@Telefono,
					@Correo,
					@IDGrado,
					@IDUsuario
				)
		COMMIT TRANSACTION
	END

	IF @procedimiento = 3
		BEGIN
			SELECT TOP 1 @Registro = 1
			FROM Estudiantes WITH(NOLOCK)
			WHERE IDEstudiante = @IDEstudiante;

			IF @@ROWCOUNT = 1
				BEGIN
					SELECT 301 AS error
					RETURN
				END

			BEGIN TRANSACTION
				UPDATE Estudiantes
				SET
					NombreCompleto = @NombreCompleto,
					FechaNacimiento = @FechaNAcimiento,
					Direccion = @Direccion,
					Telefono = @Telefono,
					Correo = @Correo,
					IDGrado = @IDGrado,
					IDUsuario = @IDUsuario
				WHERE
					IDEstudiante = @IDEstudiante;

			COMMIT TRANSACTION;
		END

	IF @Registro = 4
		BEGIN
			DELETE FROM Estudiantes
			WHERE IDEstudiante = @IDEstudiante;
		END
END


CREATE PROCEDURE SP_CRUD_DOCENTES
(
	@procedimiento   INT,
	@IDDocente       NVARCHAR(12)=NULL,
	@NombreCompleto  NVARCHAR(40)=NULL,
	@FechaNAcimiento DATE=NULL,
	@Direccion       NVARCHAR(30)=NULL,
	@Telefono        NVARCHAR(10)=NULL,
	@Correo          NVARCHAR(30)=NULL,
	@IDEspecialidad  NVARCHAR(10)=NULL,
	@IDUsuario       NVARCHAR(10)=NULL
)AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @Registro INT

	IF @procedimiento = 1
		BEGIN
			SELECT

				D.IDDocente,
				D.NombreCompleto,
				D.FechaNacimiento,
				DATEDIFF(YEAR, D.FechaNacimiento, GETDATE()) - 
				CASE 
					WHEN MONTH(GETDATE()) < MONTH(D.FechaNacimiento) OR 
						 (MONTH(GETDATE()) = MONTH(D.FechaNacimiento) AND DAY(GETDATE()) < DAY(D.FechaNacimiento))
					THEN 1 
					ELSE 0 
				END AS Edad,
				D.Direccion,
				D.Telefono,
				D.Correo,
				ES.IDEspecialidad,
				U.IDUsuario

			FROM 

				Docentes D WITH(NOLOCK)
				INNER JOIN Especialidades ES ON ES.IDEspecialidad = D.Especialidad
				INNER JOIN Usuarios U ON U.IDUsuario = D.IDUsuario

			WHERE

				D.IDDocente = @IDDocente;
		END

	IF @procedimiento = 2
		BEGIN
			SELECT TOP 1 @Registro = 1
			FROM Docentes WITH(NOLOCK)
			WHERE IDDocente = @IDDocente;

		IF @@ROWCOUNT = 1
			BEGIN
				SELECT 300 AS error
				RETURN
			END
		BEGIN TRANSACTION
			INSERT INTO Docentes
				(
					IDDocente,
					NombreCompleto,
					FechaNacimiento,
					Direccion,
					Telefono,
					Correo,
					Especialidad,
					IDUsuario
				)

			VALUES
				(
					@IDDocente,
					@NombreCompleto,
					@FechaNAcimiento,
					@Direccion,
					@Telefono,
					@Correo,
					@IDEspecialidad,
					@IDUsuario
				)
		COMMIT TRANSACTION
	END

	IF @procedimiento = 3
		BEGIN
			SELECT TOP 1 @Registro = 1
			FROM Docentes WITH(NOLOCK)
			WHERE IDDocente = @IDEspecialidad;

			IF @@ROWCOUNT = 1
				BEGIN
					SELECT 301 AS error
					RETURN
				END

			BEGIN TRANSACTION
				UPDATE Docentes
				SET
					NombreCompleto = @NombreCompleto,
					FechaNacimiento = @FechaNAcimiento,
					Direccion = @Direccion,
					Telefono = @Telefono,
					Correo = @Correo,
					Especialidad = @IDEspecialidad,
					IDUsuario = @IDUsuario
				WHERE
					IDDocente = @IDDocente;

			COMMIT TRANSACTION;
		END

	IF @Registro = 4
		BEGIN
			DELETE FROM Docentes
			WHERE IDDocente = @IDDocente;
		END
END