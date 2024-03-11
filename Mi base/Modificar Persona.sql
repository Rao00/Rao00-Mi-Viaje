
USE Deudas

GO

DECLARE @persona VARCHAR(50) = 'Alex'
DECLARE @apellido1 VARCHAR(50) = 'Pazos'
DECLARE @apellido2 VARCHAR(50) = NULL
DECLARE @telefono VARCHAR(50) = '644745938'

DECLARE @idPersona INT

SELECT @idPersona = p.idPersona
  FROM PERSONAS p
 WHERE p.Nombre = @persona
   AND p.apellido1 = @apellido1

SET NOCOUNT ON
IF (@idPersona IS NULL)
BEGIN
  INSERT INTO PERSONAS(Nombre, Apellido1, Apellido2, Telefono)
  VALUES (@persona, @apellido1, @apellido2, @telefono)
  PRINT CONCAT(@persona, ' ', @apellido1, ' se ha añadido a la base de datos')
END
ELSE
BEGIN
  PRINT CONCAT(@persona, ' ', @apellido1, ' ya existe')
END