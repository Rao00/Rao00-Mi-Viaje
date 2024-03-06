
USE JARDINERIA

-------------------------------------------------------

EXEC sp_columns HOLA

DECLARE @codCategoria CHAR(2)
DECLARE @nombreCategoria VARCHAR(50)

SELECT TOP 1 @codCategoria = p.codCategoria
  FROM PRODUCTOS p
 GROUP BY p.codCategoria
 ORDER BY COUNT(p.codCategoria) DESC

SELECT @nombreCategoria = nombre
  FROM CATEGORIA_PRODUCTOS
 WHERE codCategoria = @codCategoria

PRINT CONCAT('La gama que mas productos tiene es ', @nombreCategoria)

-------------------------------------------------------

EXEC sp_columns EMPLEADOS

DECLARE @codEmpleado INT = 7
DECLARE @nombreJefe VARCHAR(160)
DECLARE @nombreEmpleado VARCHAR(160)

SELECT @nombreEmpleado = CONCAT(e.nombre, ' ', e.apellido1, ' ', e.apellido2),
       @nombreJefe = CONCAT(j.nombre, ' ', j.apellido1, ' ', j.apellido2)
  FROM EMPLEADOS e INNER JOIN EMPLEADOS j
    ON e.codEmpleado = j.codEmplJefe
 WHERE e.codEmpleado = @codEmpleado

PRINT CONCAT('El empleado ', @nombreEmpleado, ' tiene como jefe a ', @nombreJefe)

-------------------------------------------------------

DECLARE @codCliente INT = 9
DECLARE @numPedidos INT
DECLARE @nombreCliente VARCHAR(50)

SELECT @numPedidos = COUNT(p.codPedido), 
       @nombreCliente = c.nombre_cliente
  FROM PEDIDOS p INNER JOIN CLIENTES c
    ON p.codCliente = c.codCliente
 WHERE c.codCliente = @codCliente
 GROUP BY p.codCliente, c.nombre_cliente

PRINT CONCAT('El cliente ', @nombreCliente, ' ha realizado ', @numPedidos, ' pedido/s')

EXEC sp_columns CLIENTES

-------------------------------------------------------
GO

EXEC sp_columns ESTADOS_PEDIDO

DECLARE @codPedido INT = 12
DECLARE @codCliente INT
DECLARE @nombre_cliente VARCHAR(50)
DECLARE @fechaPedido DATE
DECLARE @codEstadoPedido CHAR(1)
DECLARE @nombreEstado VARCHAR(15)

/*SELECT * FROM PEDIDOS WHERE codPedido = @codPedido*/

SELECT @codCliente = codCliente,
       @fechaPedido = fecha_pedido,
       @codEstadoPedido = codEstado
  FROM PEDIDOS
 WHERE codPedido = @codPedido

SELECT @nombre_cliente = nombre_cliente
  FROM CLIENTES
 WHERE codCliente = @codCliente

SELECT @nombreEstado = descripcion
  FROM ESTADOS_PEDIDO
 WHERE codEstado = @codEstadoPedido

PRINT CONCAT('El pedido ', @codPedido, ' realizado por el cliente ', @nombre_cliente, ' se realizó el ', FORMAT(@fechaPedido, 'dd/MM/yyyy'), ' y su estado es ', @nombreEstado)

-------------------------------------------------------

DECLARE @porcentaje DECIMAL(3,2) = 0.2
DECLARE @codGama CHAR(2) = 'OR'
DECLARE @nombreGama VARCHAR(50)

SELECT @nombreGama = nombre
  FROM CATEGORIA_PRODUCTOS
 WHERE codCategoria = @codGama

SET NOCOUNT NO
UPDATE PRODUCTOS
   SET precio_venta = precio_venta*(1+@porcentaje)
 WHERE codCategoria = @codGama
PRINT CONCAT('Se han acutalizado ', @@ROWCOUNT, ' productos')

IF (@porcentaje > 0)
BEGIN
  PRINT CONCAT('Se ha aumentado el precio de ', @nombreGama, ' en un ', FLOOR((@porcentaje)*100), '%')
END
ELSE IF (@porcentaje < 0)
BEGIN
  PRINT CONCAT('Se ha reducido el precio de ', @nombreGama, ' en un ', ABS(FLOOR((@porcentaje)*100)), '%')
END

-------------------------------------------------------

GO
DECLARE @numProductos INT = 3
DECLARE @cantidadClientes INT

SELECT @cantidadClientes = COUNT(DISTINCT codCliente)
  FROM PEDIDOS
 WHERE codPedido IN(SELECT dp.codPedido 
                      FROM DETALLE_PEDIDOS dp 
                     GROUP BY dp.codPedido
                    HAVING COUNT(dp.codPedido) >= @numProductos)

PRINT CONCAT(@cantidadClientes, ' cliente/s han hecho al menos 1 pedido con ', @numProductos, ' productos en el mismo pedido')
