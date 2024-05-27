USE TIENDA

SELECT * 
  FROM FABRICANTE
 ORDER BY codigo ASC
 OFFSET 5 ROWS
 FETCH NEXT 1 ROWS ONLY

---------------------- EJERCICIO 1 ----------------------

DECLARE @cont INT = 1
DECLARE @max INT = (SELECT COUNT(1) FROM PRODUCTO)

WHILE (@cont <= @max)
BEGIN
    DECLARE @producto VARCHAR(50) = NULL
    SELECT @producto = nombre 
      FROM PRODUCTO
     ORDER BY codigo ASC
    OFFSET @cont-1 ROWS 
     FETCH NEXT 1 ROWS ONLY
    
    IF (@producto IS NOT NULL)
    BEGIN
        PRINT(@producto)
    END

    SET @cont += 1
END

GO
---------------------- EJERCICIO 2 ----------------------

DECLARE @cont INT = 1
DECLARE @max INT = (SELECT COUNT(1) FROM PRODUCTO)

WHILE (@cont <= @max)
BEGIN
    DECLARE @producto VARCHAR(50) = NULL
    DECLARE @precio DECIMAL(9,2) = NULL
    SELECT @producto = nombre, @precio = precio
      FROM PRODUCTO
     ORDER BY codigo ASC
    OFFSET @cont-1 ROWS 
     FETCH NEXT 1 ROWS ONLY
    
    IF (@producto IS NOT NULL AND @precio IS NOT NULL)
    BEGIN
        PRINT CONCAT('El producto ', @producto, ' tiene como precio ', @precio, ' €')
    END

    SET @cont += 1
END

GO
---------------------- EJERCICIO 3 ----------------------

DECLARE @cont INT = 1
DECLARE @max INT = (SELECT COUNT(1) FROM FABRICANTE)

WHILE (@cont <= @max)
BEGIN
    DECLARE @fabricante INT = NULL
    DECLARE @nombreFabricante VARCHAR(60) = NULL

    SELECT @fabricante = codigo, @nombreFabricante = nombre
      FROM FABRICANTE
     ORDER BY codigo ASC
    OFFSET @cont-1 ROWS 
     FETCH NEXT 1 ROWS ONLY

    DECLARE @cont2 INT = 1
    DECLARE @max2 INT = (SELECT COUNT(1) FROM PRODUCTO WHERE codigo_fabricante = @fabricante)
    DECLARE @precioTotal DECIMAL(9,2) = 0

    WHILE (@cont2 <= @max2)
    BEGIN
        DECLARE @precioTemp DECIMAL(9,2)

        SELECT @precioTemp = precio 
          FROM PRODUCTO
         WHERE codigo_fabricante = @fabricante
         ORDER BY codigo_fabricante
        OFFSET @cont2-1 ROWS
         FETCH NEXT 1 ROWS ONLY

        SET @precioTotal += @precioTemp
        SET @cont2 += 1
    END

    PRINT CONCAT('El fabricante ', @nombreFabricante, ' tiene un total acumulado de ', @precioTotal, ' €')
    
    SET @cont += 1
END

GO
---------------------- EJERCICIO 4 ----------------------

USE JARDINERIA

DECLARE @cont INT = 1
DECLARE @max INT = (SELECT COUNT(1) FROM EMPLEADOS)

WHILE (@cont <= @max)
BEGIN
    DECLARE @nombre VARCHAR(50) = NULL
    DECLARE @apellido1 VARCHAR(50) = NULL
    DECLARE @apellido2 VARCHAR(50) = NULL
    DECLARE @email VARCHAR(100) = NULL

    SELECT @nombre = nombre, 
           @apellido1 = apellido1,
           @apellido2 = apellido2,
           @email = email
      FROM EMPLEADOS
     ORDER BY codEmpleado ASC
    OFFSET @cont-1 ROWS
     FETCH NEXT 1 ROWS ONLY
    
    IF(@nombre IS NOT NULL)
    BEGIN
        PRINT CONCAT(@nombre, ' ', @apellido1, ' ', @apellido2, ' tiene el email ', @email)
    END

    SET @cont += 1
END

GO
---------------------- EJERCICIO 5 ----------------------

USE JARDINERIA

DECLARE @cont INT = 1
DECLARE @max INT = 20
DECLARE @numPagina INT = 1

WHILE (@cont <= @max)
BEGIN
    DECLARE @pedido INT = NULL

    SELECT @pedido = codPedido
      FROM PEDIDOS
     ORDER BY codPedido ASC
    OFFSET @cont-1+((@numPagina-1)*@max) ROWS 
     FETCH NEXT 1 ROWS ONLY

    DECLARE @cont2 INT = 1
    DECLARE @max2 INT = (SELECT COUNT(1) FROM DETALLE_PEDIDOS WHERE codPedido = @pedido)
    DECLARE @precioTotal DECIMAL(9,2) = 0

    WHILE (@cont2 <= @max2)
    BEGIN
        DECLARE @precioTemp DECIMAL(9,2) = 0 

        SELECT @precioTemp = precio_unidad * cantidad
          FROM DETALLE_PEDIDOS
         WHERE codPedido = @pedido
         ORDER BY codPedido
        OFFSET @cont2-1 ROWS
         FETCH NEXT 1 ROWS ONLY

        SET @precioTotal += @precioTemp
        SET @cont2 += 1
    END

    IF (@pedido IS NOT NULL)
    BEGIN
        PRINT CONCAT('Nº Pedido ', @pedido, ' tiene un coste total de ', @precioTotal, ' €')
    END

    SET @cont += 1
END