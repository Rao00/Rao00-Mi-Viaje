
USE Deudas

GO

DECLARE @persona VARCHAR(50) = 'Ivan'
DECLARE @cantidad INT = 6

DECLARE @idPersona INT

SELECT @idPersona = d.idPersona
  FROM DEUDAS d INNER JOIN PERSONAS p
    ON p.idPersona = d.idPersona
 WHERE p.Nombre = @persona
   AND d.Cantidad = @cantidad

SET NOCOUNT ON
IF (@idPersona IS NULL)
BEGIN
  SELECT @idPersona = idPersona 
    FROM PERSONAS 
   WHERE Nombre = @persona
  INSERT INTO DEUDAS (idPersona, Cantidad, Fecha)
  VALUES (@idPersona, @Cantidad, GETDATE())
  PRINT CONCAT(@persona, ' se ha añadido con un adeudo de ', FORMAT(@cantidad, '# €'))
END
ELSE
BEGIN
  DELETE DEUDAS
  WHERE idPersona = @idPersona
    AND Cantidad = @cantidad
  PRINT CONCAT('Ha ', @persona, ' se le ha eliminado el adeudo de ', FORMAT(@cantidad, '# €'))
END