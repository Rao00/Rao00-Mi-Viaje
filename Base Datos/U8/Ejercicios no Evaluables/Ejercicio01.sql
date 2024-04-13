USE JARDINERIA

GO

CREATE OR ALTER PROCEDURE nombreCliente(@codCliente INT, @salida VARCHAR(50) OUTPUT)
AS
BEGIN
    IF (@codCliente IS NULL)
    BEGIN
        SET @salida = '-1'
    END

    SELECT @salida = nombre_cliente
      FROM CLIENTES
     WHERE codCliente = @codCliente
    
    IF (@salida IS NOT NULL)
    BEGIN
        RETURN
    END
    SET @salida = CONCAT('El cliente con el codigo ', @codCliente, ' no existe!')
END

GO

DECLARE @codCliente INT = 2
DECLARE @salida VARCHAR(50)
EXEC nombreCliente @codCliente, @salida OUTPUT

PRINT (@salida)

GO

USE TIENDA

GO

CREATE OR ALTER PROCEDURE CreateNewFabricante (@nombre VARCHAR(100), @id INT OUTPUT)
AS
BEGIN
    DECLARE @temp VARCHAR(100) = NULL
    SELECT @temp = nombre FROM FABRICANTE WHERE nombre = @nombre
    IF (@temp IS NULL)
    BEGIN
        INSERT INTO FABRICANTE (nombre)
        VALUES (@nombre)
        SELECT  @id = codigo FROM FABRICANTE WHERE @nombre = nombre
        RETURN 0
    END
    SELECT  @id = codigo FROM FABRICANTE WHERE @nombre = nombre
    RETURN -1
END

GO

DECLARE @nombre VARCHAR(100) = 'Tendo Garden 24'
DECLARE @id INT
DECLARE @comprobador INT
EXEC @comprobador = CreateNewFabricante @nombre, @id OUTPUT
IF (@comprobador = 0)
BEGIN
    PRINT CONCAT('Se ha añadido a ', @nombre, ' con el id ', @id)
END
ELSE
BEGIN
    PRINT CONCAT('El fabricante ', @nombre, ' ya existe y esta guardado con id ', @id)
END