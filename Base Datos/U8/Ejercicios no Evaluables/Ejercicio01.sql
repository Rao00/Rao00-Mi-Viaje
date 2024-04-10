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