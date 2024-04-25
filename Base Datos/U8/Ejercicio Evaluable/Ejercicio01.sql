USE JARDINERIA

GO

				---------------------------
				--   UD8  -  PROC & FUNC -- 
				---------------------------
-------------------------------------------------------------------------------------------
-- NOTA: Recuerda cuidar la limpieza del código (tabulaciones, nombres de tablas en mayúscula,
--		nombres de variables en minúscula, poner comentarios sin excederse, código organizado y fácil de seguir, etc.)
-------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------
-- 1. Implementa un procedimiento llamado 'getNombreCliente' que devuelva el nombre de un cliente a partir de su código.
--		Parámetros de entrada:  codCliente INT
--		Parámetros de salida:   nombreCliente VARCHAR(50)
--		Tabla:                  CLIENTES
--		
--		El procedimiento devolverá 0 si finaliza correctamente.
--		Debes utilizar TRY/CATCH, validación de parámetros y transacciones si fueran necesarias.
--	
--	  * Comprueba que el funcionamiento es correcto realizando una llamada desde un script y comprobando la finalización del mismo
--      Recuerda utilizar en el script:
--              EXEC @ret = getNombreCliente @codCliente, @nombreCliente OUTPUT
--              IF @ret <> 0 ...
-------------------------------------------------------------------------------------------

CREATE OR ALTER PROCEDURE getNombreCliente (@codCliente INT, @nombreCliente VARCHAR(50) OUTPUT)
AS
BEGIN TRY
  IF NOT EXISTS (SELECT * FROM CLIENTES WHERE codCliente = @codCliente)
  BEGIN
    PRINT 'Cliente no encontrado'
    RETURN -1
  END
  SELECT @nombreCliente = nombre_cliente FROM CLIENTES WHERE codCliente = @codCliente
  RETURN 0
END TRY
BEGIN CATCH
  PRINT CONCAT('Codigo = ', ERROR_NUMBER(), CHAR(10),
               'Linea = ', ERROR_LINE(), CHAR(10),
               'Mensaje = ', ERROR_MESSAGE(), CHAR(10),
               'Transaccion = ', ERROR_PROCEDURE())
END CATCH

GO

DECLARE @codigoCliente INT = 78974
DECLARE @nombreCliente VARCHAR(50)
DECLARE @errorTemp INT

EXEC @errorTemp = getNombreCliente @codigoCliente, @nombreCliente OUTPUT

IF @errorTemp = 0
BEGIN
  PRINT @nombreCliente
END

GO
-------------------------------------------------------------------------------------------
-- 2. Implementa un procedimiento llamado 'getPedidosPagosCliente' que devuelva el número de pedidos y de pagos a partir de un código de cliente.
--		Parámetros de entrada:  codCliente INT
--		Parámetros de salida:   numPedidos INT
--                              numPagos INT
--		Tabla:                  CLIENTES
--		
--		El procedimiento devolverá 0 si finaliza correctamente.
--		Debes utilizar TRY/CATCH, validación de parámetros y transacciones si fueran necesarias.
--	
--	  * Comprueba que el funcionamiento es correcto realizando una llamada desde un script y comprobando la finalización del mismo
--      Recuerda utilizar en el script:
--              EXEC @ret = getPedidosPagosCliente @codCliente, @numPedidos OUTPUT, @numPagos OUTPUT
--              IF @ret <> 0 ...
-------------------------------------------------------------------------------------------

CREATE OR ALTER PROCEDURE getPedidosPagosCliente (@codCliente INT, @numPedidos INT OUTPUT, @numPagos INT OUTPUT)
AS
BEGIN
  IF NOT EXISTS (SELECT * FROM CLIENTES WHERE codCliente = @codCliente)
  BEGIN
    PRINT 'Cliente no encontrado'
    RETURN -1
  END
  SELECT @numPedidos = COUNT(codPedido) FROM PEDIDOS WHERE codCliente = @codCliente
  SELECT @numPagos = COUNT(codCliente) FROM PAGOS WHERE codCliente = @codCliente
  IF @numPedidos <= 0
  BEGIN
    PRINT 'Cliente no tiene pedidos'
    RETURN -2
  END
  IF @numPagos <= 0
  BEGIN
    PRINT 'Cliente no tiene pagos'
    RETURN -3
  END
  RETURN 0
END

GO

DECLARE @codCliente INT = 4
DECLARE @numPedidos INT
DECLARE @numPagos INT
DECLARE @temp INT

EXEC @temp = getPedidosPagosCliente @codCliente, @numPedidos OUTPUT, @numPagos OUTPUT

IF @temp = 0
BEGIN
  PRINT CONCAT('El cliente con codigo ', @codCliente, ' ha realizado ', @numPedidos, ' pedidos y ha realizado ', @numPagos, ' pagos')
END

GO
-------------------------------------------------------------------------------------------
-- 3. Implementa un procedimiento llamado 'crearCategoriaProducto' que inserte una nueva categoría de producto en la base de datos JARDINERIA.
--		Parámetros de entrada: codCategoria CHAR(2),
--							   nombre VARCHAR(50),
--                             descripcion_texto VARCHAR(MAX), 
--                             descripcion_html VARCHAR(MAX),
--                             imagen VARCHAR(256)

--		Parámetros de salida: <ninguno>
--		Tabla: CATEGORIA_PRODUCTOS
--		
--		# Se debe comprobar que todos los parámetros obligatorios están informados. Si falta alguno, devolver -1 y finalizar.
--		# Se debe comprobar que la categoría no exista previamente en la tabla. Si ya existe, imprimir mensaje indicándolo, devolver -1 y finalizar.
--		
--		El procedimiento devolverá 0 si finaliza correctamente.
--		Debes utilizar TRY/CATCH, validación de parámetros y transacciones si fueran necesarias.
--	
--	  * Comprueba que el funcionamiento es correcto realizando una llamada desde un script y comprobando la finalización del mismo
--      Recuerda utilizar en el script:
--              EXEC @ret = crearCategoriaProducto ...
--              IF @ret <> 0 ...
-------------------------------------------------------------------------------------------

CREATE OR ALTER PROCEDURE crearCategoriaProducto (@codCategoria CHAR(2), @nombre VARCHAR(50), @descripcion_texto VARCHAR(MAX), @descripcion_html VARCHAR(MAX), @imagen VARCHAR(256))
AS
BEGIN
  IF EXISTS (SELECT @codCategoria FROM CATEGORIA_PRODUCTOS WHERE codCategoria = @codCategoria)
  BEGIN
    PRINT('El codigo de categoria ya esta registrado')
    RETURN -1
  END
  IF EXISTS (SELECT @nombre FROM CATEGORIA_PRODUCTOS WHERE nombre = @nombre)
  BEGIN
    PRINT('El nombre de categoria ya esta registrado')
    RETURN -2
  END
  BEGIN TRY
  BEGIN TRANSACTION
    INSERT INTO CATEGORIA_PRODUCTOS (codCategoria, nombre, descripcion_texto, descripcion_html, imagen)
    VALUES (@codCategoria, @nombre, @descripcion_texto, @descripcion_html, @imagen)
  COMMIT
    RETURN 0
  END TRY
  BEGIN CATCH
    PRINT CONCAT('Codigo = ', ERROR_NUMBER(), CHAR(10),
               'Linea = ', ERROR_LINE(), CHAR(10),
               'Mensaje = ', ERROR_MESSAGE(), CHAR(10),
               'Transaccion = ', ERROR_PROCEDURE())
    ROLLBACK
  END CATCH
END

GO

DECLARE @codCategoria CHAR(2) = 18
DECLARE @nombre VARCHAR(50) = 'Patatas'
DECLARE @descripcion_texto VARCHAR(MAX) = 'Productos ornamentales de decoracion'
DECLARE @descripcion_html VARCHAR(MAX) = 'https:\\ornamentales.com'
DECLARE @imagen VARCHAR(256) = 'C:/Sprites/Ornamentales.png'
DECLARE @ret INT

EXEC @ret = crearCategoriaProducto @codCategoria, @nombre, @descripcion_texto, @descripcion_html, @imagen

IF @ret = 0
BEGIN
  PRINT 'La categoria se ha creado con éxito'
END

GO
-------------------------------------------------------------------------------------------
-- 4. Implementa un procedimiento llamado 'acuseRecepcionPedidosCliente' que actualice la fecha de entrega de los pedidos
--      a la fecha del momento actual y su estado a 'Entregado' para el codCliente pasado por parámetro y solo para los 
--      pedidos que estén en estado 'Pendiente' y no tengan fecha de entrega.

--		Parámetros de entrada: codCliente INT
--		Parámetros de salida:  numPedidosAct INT
--		Tabla: PEDIDOS

--	  * Comprueba que el funcionamiento es correcto realizando una llamada desde un script y comprobando la finalización del mismo
--
--      Ayuda: Recuerda utilizar:
--              EXEC @ret = acuseRecepcionPedidosCliente ...
--              IF @ret <> 0 ...
--
--	  * Ayuda para obtener el número de registros actualizados:
--		Se puede hacer una SELECT antes de ejecutar la sentencia de actualización o bien utilizar la variable @@ROWCOUNT
--
-------------------------------------------------------------------------------------------

CREATE OR ALTER PROCEDURE acuseRecepcionPedidosCliente(@codCliente INT)
AS
BEGIN
  SELECT @codCliente = codCliente FROM PEDIDOS WHERE codCliente = @codCliente
  IF @codCliente IS NOT NULL
  BEGIN
    UPDATE PEDIDOS
    SET fecha_entrega = GETDATE(),
        codEstado = 'E'
    WHERE codEstado = 'P' AND fecha_entrega IS NULL AND codCliente = @codCliente
  END
  PRINT CONCAT('Se han modificado ', @@ROWCOUNT, ' registros')
END
GO
-------------------------------------------------------------------------------------------
-- 5. Implementa un procedimiento llamado 'crearOficina' que inserte una nueva oficina en JARDINERIA.
--		Parámetros de entrada: codOficina CHAR(6)
--                             ciudad VARCHAR(40)
--                             pais VARCHAR(50)
--                             codigo_postal CHAR(5)
--                             telefono VARCHAR(15)
--                             linea_direccion1 VARCHAR(100)
--                             linea_direccion2 VARCHAR(100) (no obligatorio)

--		Parámetros de salida: <ninguno>
--		Tabla: OFICINAS
--		
--		# Se debe comprobar que todos los parámetros obligatorios están informados, sino devolver -1 y finalizar
--		# Se debe comprobar que el codOficina no exista previamente en la tabla, y si así fuera, 
--			imprimir un mensaje indicándolo y se devolverá -1
--		
--		El procedimiento devolverá 0 si finaliza correctamente.
--		Debes utilizar TRY/CATCH, validación de parámetros y transacciones si fueran necesarias.
--	
--	  * Comprueba que el funcionamiento es correcto realizando una llamada desde un script y comprobando la finalización del mismo
--
--      Ayuda: Recuerda utilizar:
--              EXEC @ret = crearOficina ...
--              IF @ret <> 0 ...
-------------------------------------------------------------------------------------------

CREATE OR ALTER PROCEDURE crearOficina (@codOficina CHAR(6), @ciudad VARCHAR(40), @pais VARCHAR(50), @codigo_postal CHAR(5), @telefono VARCHAR(15), @linea_direccion1 VARCHAR(100), @linea_direccion2 VARCHAR(100) = NULL)
AS
IF (@codOficina IS NULL)
BEGIN
  SET @codOficina = UPPER(CONCAT(LEFT(@ciudad, 3), '-', LEFT(@pais, 2)))
END
IF (@codOficina IS NOT NULL AND @ciudad IS NOT NULL AND @pais IS NOT NULL AND @codigo_postal IS NOT NULL AND @telefono IS NOT NULL AND @linea_direccion1 IS NOT NULL)
BEGIN
  IF NOT EXISTS(SELECT codOficina FROM OFICINAS WHERE codOficina = @codOficina)
  BEGIN
    INSERT INTO OFICINAS
    VALUES (@codOficina, @ciudad, @pais, @codigo_postal, @telefono, @linea_direccion1, @linea_direccion2)
    PRINT CONCAT('El codigo ', @codOficina, ' se ha registrado exitosamente')
    RETURN 0
  END
  PRINT CONCAT('El codigo ', @codOficina, ' ya esta registrado')
  RETURN -2
END
RETURN -1

GO

select * from OFICINAS

DECLARE @ret INT

EXEC @ret = crearOficina NULL, 'Alicante', 'España', '03005', '697145244', 'Calle Medico Andres Hector'

IF @ret = -1
BEGIN
 PRINT 'Falta algun valor'
END

GO
-------------------------------------------------------------------------------------------
-- 6. Implementa un procedimiento llamado 'cambioJefes' que actualice el jefe/a de los empleados/as del
--      que tuvieran inicialmente (ant_codEmplJefe) al nuevo/a (des_codEmplJefe)
--    NOTA: Es un proceso que ocurre si alguien asciende de categoría.

--		Parámetros de entrada: ant_codEmplJefe INT
--                             des_codEmplJefe INT

--		Parámetros de salida: numEmpleados INT (número de empleados que han actualizado su jefe)
--		Tabla: EMPLEADOS

--	  * Comprueba que el funcionamiento es correcto realizando una llamada desde un script y comprobando la finalización del mismo
--
--      Ayuda: Recuerda utilizar:
--              EXEC @ret = cambioJefes ...
--              IF @ret <> 0 ...
-------------------------------------------------------------------------------------------

CREATE OR ALTER PROCEDURE cambioJefes (@ant_codEmplJefe INT, @des_codEmplJefe INT)
AS
IF (@ant_codEmplJefe IS NULL OR @des_codEmplJefe IS NULL)
BEGIN
  RETURN -1
END
IF NOT EXISTS(SELECT codEmplJefe FROM EMPLEADOS WHERE codEmplJefe = @ant_codEmplJefe)
BEGIN
  RETURN -2
END
IF NOT EXISTS(SELECT codEmplJefe FROM EMPLEADOS WHERE codEmplJefe = @des_codEmplJefe)
BEGIN
  RETURN -3
END
IF (@ant_codEmplJefe = @des_codEmplJefe)
BEGIN
  RETURN -4
END
BEGIN TRY
BEGIN TRAN
  UPDATE EMPLEADOS
  SET codEmplJefe = @des_codEmplJefe
  WHERE codEmplJefe = @ant_codEmplJefe

  UPDATE EMPLEADOS
  SET codEmplJefe = NULL
  WHERE codEmpleado = @des_codEmplJefe
COMMIT
END TRY
BEGIN CATCH
  PRINT CONCAT('Codigo = ', ERROR_NUMBER(), CHAR(10),
               'Linea = ', ERROR_LINE(), CHAR(10),
               'Mensaje = ', ERROR_MESSAGE(), CHAR(10),
               'Transaccion = ', ERROR_PROCEDURE())
  ROLLBACK
END CATCH
GO

DECLARE @ret INT

EXEC @ret = cambioJefes 7, 6

IF (@ret = -1)
BEGIN
  PRINT('La expresion toma 2 valores que no son NULL')
END
IF (@ret = -2)
BEGIN
  PRINT('El primer valor no es un codigo de empleado valido')
END
IF (@ret = -3)
BEGIN
  PRINT('El segundo valor no es un codigo de empleado valido')
END
IF (@ret = -4)
BEGIN
  PRINT('Los empleados no pueden ser iguales')
END

GO
-------------------------------------------------------------------------------------------
-- 7. Implementa una función llamada getCostePedidos que reciba como parámetro un codCliente y devuelva
--		el coste de todos los pedidos realizados por dicho cliente.
--	
--	Recuerda que debes incluir la SELECT y comprobar el funcionamiento
-------------------------------------------------------------------------------------------

CREATE OR ALTER FUNCTION getCostePedidos (@codCliente INT)
RETURNS DECIMAL(9,2)
AS
BEGIN
  RETURN ISNULL((SELECT SUM(precio_unidad * cantidad)
                  FROM DETALLE_PEDIDOS
                 WHERE codPedido = ANY(SELECT codPedido FROM PEDIDOS WHERE codCliente = @codCliente)),'0')
END

GO

SELECT codCliente, dbo.getCostePedidos(codCliente)
  FROM CLIENTES;

GO
-------------------------------------------------------------------------------------------
-- 8. Implementa una función llamada numEmpleadosOfic que reciba como parámetro un codOficina y devuelva
--		el número de empleados que trabajan en ella
--	
--	Recuerda que debes incluir la SELECT y comprobar el funcionamiento
-------------------------------------------------------------------------------------------

CREATE OR ALTER FUNCTION numEmpleadosOfic (@codOficina CHAR(6))
RETURNS INT
AS
BEGIN
  RETURN (SELECT COUNT(codEmpleado)
            FROM EMPLEADOS
           WHERE codOficina = @codOficina)
END

GO

SELECT codOficina, dbo.numEmpleadosOfic(codOficina) AS cantidadEmpleados
  FROM OFICINAS
 WHERE dbo.numEmpleadosOfic(codOficina) > 0

-------------------------------------------------------------------------------------------
-- 9. Implementa una función llamada clientePagos_SN que reciba como parámetro un codCliente y devuelva
--		'S' si ha realizado pagos y 'N' si no ha realizado ningún pago.
--	
--	Recuerda que debes incluir la SELECT y comprobar el funcionamiento
-------------------------------------------------------------------------------------------



-------------------------------------------------------------------------------------------
-- 10. Implementa una función llamada pedidosPendientesAnyo que reciba como parámetros 'estado' y 'anyo'
--	    y devuelva una TABLA con los pedidos pendientes del año 2009 (estos datos deben ponerse directamente en la SELECT, NO son dinámicos)

--	Recuerda que debes incluir la SELECT y comprobar el funcionamiento
-------------------------------------------------------------------------------------------

