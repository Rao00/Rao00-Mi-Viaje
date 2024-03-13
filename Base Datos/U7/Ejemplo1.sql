USE JARDINERIA

DECLARE @varPrecioMin INT = 75
DECLARE @varPrecioMax INT = 200
SELECT *
  FROM PRODUCTOS
 WHERE precio_venta >= @varPrecioMin
   AND precio_venta <= @varPrecioMax

DECLARE @codCategoria CHAR(2) = 'FR'
DECLARE @nombre VARCHAR(100) = 'Pera'

SELECT * 
  FROM PRODUCTOS
 WHERE codCategoria = @codCategoria
   AND nombre LIKE CONCAT(@nombre, '%')

EXEC sp_columns PRODUCTOS

GO

DECLARE @minPrecio DECIMAL(7,2)
DECLARE @maxPrecio DECIMAL(7,2)
DECLARE @codCategoria CHAR(2)
DECLARE @nombreCategoria VARCHAR(100) = 'Frutales'

SELECT @codCategoria = codCategoria
  FROM CATEGORIA_PRODUCTOS
 WHERE nombre = @nombreCategoria

SELECT @minPrecio = MIN(precio_venta),
       @maxPrecio = MAX(precio_venta)
  FROM PRODUCTOS
 WHERE codCategoria = @codCategoria

PRINT CONCAT('El precio mas bajo ha sido ', @minPrecio)
PRINT CONCAT('El precio mas alto ha sido ', @maxPrecio)

GO

DECLARE @codCategoria VARCHAR(100)

SELECT @codCategoria = cp.nombre
  FROM CATEGORIA_PRODUCTOS cp
 WHERE cp.codCategoria = (SELECT TOP 1 p.codCategoria
                         FROM PRODUCTOS p
                        GROUP BY p.codCategoria
                        ORDER BY COUNT(p.codProducto) DESC)       

PRINT @codCategoria

DECLARE @nombre VARCHAR(50)
DECLARE @apellido1 VARCHAR(50)
DECLARE @apellido2 VARCHAR(50)

SELECT @nombre = nombre,
       @apellido1 = apellido1,
       @apellido2 = apellido2
  FROM EMPLEADOS
 WHERE codEmpleado = 9

PRINT CONCAT(@nombre, ' ', @apellido1, ' ', @apellido2)

SELECT * FROM EMPLEADOS


DECLARE @idCliente VARCHAR(100)
DECLARE @codCliente INT
DECLARE @numPagos INT

SELECT TOP(1) @codCliente = c.codCliente,
              @idCliente = c.nombre_cliente, 
              @numPagos = COUNT(p.codCliente)
  FROM CLIENTES c,
       PAGOS p
 WHERE c.codCliente = p.codCliente
 GROUP BY c.nombre_cliente, c.codCliente
 ORDER BY NEWID()
 
IF @numPagos > 0
BEGIN 
  PRINT CONCAT('El cliente ', @idCliente, ' ha realizado ', @numPagos, ' pagos')
END
ELSE
BEGIN
  DECLARE @numPedidos INT
  SELECT @numPedidos = COUNT(codCliente)
    FROM PEDIDOS
   WHERE codCliente = @codCliente
  PRINT CONCAT('El cliente ', @idCliente, ' no ha realizado pagos pero ha realizado ', @numPedidos)
END

-----------------------------------------------------------------------------------------------

DECLARE @i INT = 0

WHILE (@i < 10)
BEGIN
  PRINT @i + 1 
  SET @i += 1
END

-----------------------------------------------------------------------------------------------

Go

DECLARE @i INT = 1

WHILE (@i <= 30)
BEGIN
  IF (@i%5 = 0)
  BEGIN
    PRINT @i
  END
  SET @i += 1
END

GO

DECLARE @i INT = 1

WHILE (@i <= 200)
BEGIN
  IF (@i%7 = 0 AND @i <> 7)
  BEGIN
    PRINT @i
    BREAK
  END
  SET @i += 1
END

GO

DECLARE @i INT
DECLARE @max INT
DECLARE @nombre VARCHAR(50)

SELECT @i = MIN(codCliente), @max = MAX(codCliente) 
  FROM CLIENTES

WHILE (@i < @max)
BEGIN

  SELECT @nombre = nombre_cliente 
    FROM CLIENTES 
   WHERE codCliente = @i

  SET @i += 1
  IF (@nombre IS NOT NULL)
  BEGIN
    PRINT CONCAT(@i, ') ', @nombre)
  END
  SET @nombre = NULL
END

------------------------------------------------------------------------------------------
GO

DECLARE @xd INT

BEGIN TRY
  DECLARE @ruleta INT = FLOOR(RAND()*10)
  DECLARE @error INT = 10/@ruleta
  PRINT @ruleta
END TRY

BEGIN CATCH
  PRINT ERROR_MESSAGE()
  PRINT CONCAT('NUMERO DE ERROR: ', ERROR_NUMBER())
  PRINT CONCAT('LINEA: ', ERROR_LINE()) 
  PRINT ERROR_PROCEDURE()
  RETURN
END CATCH

GO
------------------------------------------------------------------------------------------

SET IMPLICIT_TRANSACTIONS OFF

BEGIN TRY
  BEGIN TRAN
    SELECT * FROM SYS.MESSAGES WHERE severity > 18
  COMMIT
END TRY
BEGIN CATCH
  PRINT ERROR_LINE()
  ROLLBACK
END CATCH