-------------------------------------------------------------------------------------

CREATE OR ALTER PROCEDURE ReadProfesores (@DNI CHAR(9) = '00000000A')
AS
BEGIN
	IF (@DNI = '00000000A')
	BEGIN
		RETURN SELECT * FROM Personas WHERE DNI = (SELECT DNI FROM Profesores)
	END
	ELSE
	BEGIN
		RETURN SELECT * FROM Personas WHERE DNI = (SELECT DNI FROM Profesores WHERE DNI = @DNI)
	END
END

-------------------------------------------------------------------------------------
GO
-------------------------------------------------------------------------------------

CREATE OR ALTER PROCEDURE ReadAlumnos (@DNI CHAR(9) = '00000000A')
AS
BEGIN
	IF (@DNI = '00000000A')
	BEGIN
		RETURN SELECT * FROM Personas WHERE DNI = (SELECT DNI FROM Alumnos)
	END
	ELSE
	BEGIN
		RETURN SELECT * FROM Personas WHERE DNI = (SELECT DNI FROM Alumnos WHERE DNI = @DNI)
	END
END

-------------------------------------------------------------------------------------
GO
-------------------------------------------------------------------------------------

CREATE OR ALTER PROCEDURE ReadCursos (@codCurso INT = NULL)
AS
BEGIN
	IF (@DNI IS NULL)
	BEGIN
		RETURN SELECT * FROM Cursos
	END
	ELSE
	BEGIN
		RETURN SELECT * FROM Cursos WHERE codCurso = @codCurso
	END
END

-------------------------------------------------------------------------------------
GO
-------------------------------------------------------------------------------------

CREATE OR ALTER PROCEDURE AddPersona (@DNI CHAR(9), @nombre VARCHAR(50), @apellido VARCHAR(50),
									  @telefono CHAR(9), @email VARCHAR(100), @direccion VARCHAR(100),
									  @tipo VARCHAR(10), @datoPersona VARCHAR(50))
AS
BEGIN
	IF (@DNI IS NULL)
	BEGIN
		RETURN -1
	END 
	INSERT INTO Personas(DNI, nombre, apellido, telefono, email, direccion) VALUES (@DNI, @nombre, @apellido, @telefono, @email, @direccion)
	IF (@tipo = 'Profesor')
	BEGIN
		INSERT INTO Profesores (DNI, asignatura1) VALUES (@DNI, @datoPersona)
	END
	IF (@tipo = 'Alumno')
	BEGIN
		DECLARE @idCurso INT = (SELECT codCurso FROM Cursos WHERE Nombre = @datoPersona)
		INSERT INTO Alumnos (DNI, codCurso) VALUES (@DNI, @idCurso)
	END
	RETURN 1
END

GO

CREATE OR ALTER PROCEDURE DeletePersona (@DNI CHAR(9))
AS
BEGIN
	IF (@DNI IS NULL)
	BEGIN
		RETURN -1
	END
	DELETE FROM Profesores WHERE DNI = @DNI
	DELETE FROM Personas WHERE DNI = @DNI
	RETURN 1
END

-------------------------------------------------------------------------------------
GO
-------------------------------------------------------------------------------------

CREATE OR ALTER PROCEDURE 