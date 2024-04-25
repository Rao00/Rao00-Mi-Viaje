USE JARDINERIA

GO

DROP PROCEDURE PrintError

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
    BEGIN TRY
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
    END TRY
    BEGIN CATCH
        PRINT PrintError(ERROR_NUMBER(), ERROR_MESSAGE(), ERROR_LINE(), ERROR_PROCEDURE())
        ROLLBACK
    END CATCH
END

GO