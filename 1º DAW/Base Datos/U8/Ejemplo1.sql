USE JARDINERIA

GO

CREATE OR ALTER PROCEDURE prueba
AS
BEGIN
 PRINT ('hola mundo')
END

EXEC prueba

GO
------------------------------------------------------------

CREATE OR ALTER PROCEDURE numero (@numero INT)
AS
BEGIN
    PRINT CONCAT('El numero es ', @numero)
END

DECLARE @num INT = FLOOR(RAND()*10)
EXEC numero @num

GO
------------------------------------------------------------

CREATE OR ALTER PROCEDURE numero (@numero INT = 200, @multiple INT = 1, @salida INT OUTPUT)
AS
BEGIN
    SET @salida = @numero * @multiple
END

DECLARE @num INT = 200
DECLARE @mult INT = 50
DECLARE @resultado INT

EXEC numero @num,@mult,@resultado OUTPUT

PRINT CONCAT('El resultado es: ',@resultado)

GO
