USE JARDINERIA

						---------------------------
						-- EJERCICIOS UD7 - TSQL -- 
						---------------------------
-------------------------------------------------------------------------------------------
-- NOTA: Recuerda cuidar la limpieza del código (tabulaciones, nombres de tablas en mayúscula,
--		nombres de variables en minúscula, poner comentarios sin excederse, código organizado y fácil de seguir, etc.)
-------------------------------------------------------------------------------------------
-- 1. Crea un script que use un bucle para calcular la potencia de un número.
--		Tendremos dos variables: el número y la potencia
--
--		Ejemplo.
--		Número = 3		Potencia = 4		Resultado = 3*3*3*3 = 81
--
--		Si el número o la potencia son 0 o <0 devolverá el mensaje: “La operación no se puede realizar.
-------------------------------------------------------------------------------------------

DECLARE @numero INT = 5
DECLARE @potencia INT = 3
DECLARE @resultado INT = 1
DECLARE @i INT = @potencia
DECLARE @exit VARCHAR(50)

IF (@numero > 0 AND @potencia > 0)
BEGIN
	WHILE (@i > 0)
	BEGIN
		SET @resultado *= @numero
		SET @i -= 1
		SET @exit = CONCAT(@exit, @numero)
		IF (@i > 0)
		BEGIN
			SET @exit = CONCAT(@exit,'*')
		END
	END
	PRINT CONCAT('Numero = ', @numero, ' Potencia = ', @potencia, ' Resultado = ', @exit, ' = ', @resultado)
END
ELSE
BEGIN
	PRINT 'El numero y la potencia deben ser mayor que 0'
END
GO
-------------------------------------------------------------------------------------------
-- 2. Crea un script que calcule las soluciones de una ecuación de segundo grado ax^2 + bx + c = 0
--
--	Debes crear variables para los valores a, b y c.
--  Al principio debe comprobarse que los tres valores son positivos, en otro caso, 
--		se devolverá el mensaje 'Cálculo no implementado'
--	
--	Consulta esta página para obtener la fórmula a implementar (recuerda que habrá DOS soluciones): 
--		http://recursostic.educacion.es/descartes/web/Descartes1/4a_eso/Ecuacion_de_segundo_grado/Ecua_seg.htm#solgen

--	Salida esperada para los valores: a=3, b=-4, c=1 --> sol1= 1 y sol2= 0.33
--	
--	NOTA: Si no sale lo mismo, te recomiendo revisar bien el orden de prioridad de los operadores... ()
-------------------------------------------------------------------------------------------

DECLARE @a INT = -3
DECLARE @b INT = -4
DECLARE @c INT = 1
DECLARE @resultadoPos DECIMAL(9,2)
DECLARE @resultadoNeg DECIMAL(9,2)

IF (@a > 0 AND @c > 0)
BEGIN
	SET @resultadoPos = (@b*-1 + (SQRT(POWER(@b,2) - (4 * (@a * @c)))))/(2 * @a)
	SET @resultadoNeg = (@b*-1 - (SQRT(POWER(@b,2) - (4 * (@a * @c)))))/(2 * @a)
	PRINT CONCAT('a = ', @a, ', b = ', @b, ', c = ', @c, ' --> solPositiva = ', @resultadoPos, ' y solNegativa = ', @resultadoNeg)
END
ELSE
BEGIN
	PRINT 'El numero A o el numero C no pueden ser negativos ni iguales a 0'
END

GO
-------------------------------------------------------------------------------------------
-- 3. Crea un script que calcule la serie de Fibonacci para un número dado.

-- La sucesión es: 1,1,2,3,5,8,13,21,34,55,89,144,233,377,610,987,1597...
-- Si te fijas, se calcula sumando el número anterior al siguiente:
--	Ejemplo. Si se introduce el numero 3 significa que tendremos que hacer 3 iteraciones:
--			ini = 1
--			0+1 = 1
--			1+1 = 2
--			2+1 = 3
--			3+2 = 5
--			5+3 = 8
--			...
-- 
--	Ayuda: Quizás necesites guardar en algún sitio el valor actual de la serie antes de sumarlo...
-------------------------------------------------------------------------------------------

DECLARE @i INT = 2
DECLARE @temp INT = 0
DECLARE @valor INT = 1
DECLARE @total INT

WHILE (@i > 0)
BEGIN
	SET @total = @temp + @valor
	PRINT CONCAT(@temp, '+', @valor, ' = ', @total)
	SET @temp = @valor
	SET @valor = @total
	SET @i -= 1
END

GO
-------------------------------------------------------------------------------------------
-- 4. Utilizando la BD JARDINERIA, crea un script que realice lo siguiente:
--		Obtén el nombre del cliente con código 3 y guárdalo en una variable
--		Obtén el número de pedidos realizados por dicho cliente y guárdalo en una variable
--		Muestra por pantalla el mensaje: 'El cliente XXXX ha realizado YYYY pedidos.'
--		
--		Resultado esperado: El cliente Gardening Associates ha realizado 9 pedidos.
--
--	    Reto opcional: Implementa el script utilizando una única consulta.
-------------------------------------------------------------------------------------------

USE JARDINERIA

DECLARE @codCliente INT = 3
DECLARE @nombreCliente VARCHAR(50)
DECLARE @numPedidos INT

SELECT @nombreCliente = c.nombre_cliente,
	   @numPedidos = COUNT(p.codCliente)
  FROM CLIENTES c INNER JOIN PEDIDOS p
    ON c.codCliente = p.codCliente
 WHERE c.codCliente = @codCliente
 GROUP BY c.codCliente, c.nombre_cliente

PRINT CONCAT('El cliente ', @nombreCliente, ' ha realizado ', @numPedidos, ' pedidos')

GO
-------------------------------------------------------------------------------------------
-- 5. Utilizando la BD JARDINERIA, crea un script que realice lo siguiente:
--		Obtén el nombre y los apellidos de todos los empleados de la empresa
--		Deberás mostrar cada uno de ellos línea a línea utilizando PRINT
--		
--		Salida esperada:
--			Magaña Perez, Marcos
--			López Martinez, Ruben
--			Soria Carrasco, Alberto
--			Solís Jerez, Maria
--			...
--
--		Reto opcional: Modifica el script anterior para que muestre sólo los que trabajen en la oficina de Londres
--		Salida esperada:
--			Johnson , Amy
--			Westfalls , Larry
--			Walton , John
-------------------------------------------------------------------------------------------

USE JARDINERIA

DECLARE @i INT = 0
DECLARE @max INT
DECLARE @nombre VARCHAR(50)
DECLARE @apellido1 VARCHAR(50)
DECLARE @apellido2 VARCHAR(50)

SELECT @max = COUNT(codEmpleado)
  FROM EMPLEADOS

WHILE (@i < @max)
BEGIN
	SET @nombre = NULL
	SELECT @nombre = e.nombre,
		   @apellido1 = e.apellido1,
		   @apellido2 = e.apellido2
	  FROM EMPLEADOS e
	 WHERE codEmpleado = @i
	   AND e.codOficina = 'LON-UK'
	IF (@nombre IS NOT NULL)
	BEGIN
		PRINT CONCAT(@apellido1, ' ', @apellido2, ', ', @nombre)
	END 
	SET @i += 1
END

GO

-------------------------------------------------------------------------------------------
-- 6. Utilizando la BD JARDINERIA, crea un script que realice lo siguiente:
--		Reutilizando el script del ejercicio 4, agrega la siguiente información a la salida:
--			Número de pedidos realizados por cada cliente
--			NOTA: Realízalo utilizando una consulta específica para obtener el número de pedidos de cada cliente.

--		Salida esperada:
--			El cliente GoldFish Garden ha realizado 11 pedidos.
--			El cliente Gardening Associates ha realizado 9 pedidos.
--			El cliente Gerudo Valley ha realizado 5 pedidos.
--			El cliente Tendo Garden ha realizado 5 pedidos.
--			El cliente Lasas S.A. ha realizado 0 pedidos.
--			...
--
--		Reto opcional:
--		Muestra también el coste total de todos los pedidos para cada cliente.
--
--		Salida esperada:
--			El cliente GoldFish Garden ha realizado 11 pedidos por un coste total de 10365.00.
--			El cliente Gardening Associates ha realizado 9 pedidos por un coste total de 13726.00.
--			El cliente Gerudo Valley ha realizado 5 pedidos por un coste total de 81849.00.
--			El cliente Tendo Garden ha realizado 5 pedidos por un coste total de 23794.00.
--			El cliente Lasas S.A. ha realizado 0 pedidos por un coste total de 0.00.
--			...
-------------------------------------------------------------------------------------------

USE JARDINERIA

DECLARE @nombreCliente VARCHAR(50)
DECLARE @numPedidos INT
DECLARE @max INT
DECLARE @i INT = 0

SELECT @max = COUNT(*) FROM CLIENTES

WHILE (@i < @max)
BEGIN
	SELECT @nombreCliente = c.nombre_cliente,
		@numPedidos = COUNT(p.codCliente)
	FROM CLIENTES c INNER JOIN PEDIDOS p
		ON c.codCliente = p.codCliente
	WHERE c.codCliente = @i
	GROUP BY c.codCliente, c.nombre_cliente
	PRINT CONCAT('El cliente ', @nombreCliente, ' ha realizado ', @numPedidos, ' pedidos')
END

GO

-------------------------------------------------------------------------------------------
-- 7. Utilizando la BD JARDINERIA, crea un script que realice las siguientes operaciones:
--	Importante: debes utilizar TRY/CATCH y Transacciones si fueran necesarias.

--		Crea una nueva oficina (datos inventados)
--		Crea un nuevo empleado con datos inventados (el codEmpleado a insertar debes obtenerlo automáticamente)
--		Crea un nuevo cliente (datos inventados) (el codCliente a insertar debes obtenerlo automáticamente)
--		Asigna como representante de ventas el cliente anterior
-------------------------------------------------------------------------------------------



-------------------------------------------------------------------------------------------
-- 8. Utilizando la BD JARDINERIA, crea un script que realice las siguientes operaciones:
--	Importante: debes utilizar TRY/CATCH y Transacciones si fueran necesarias.
--
--		Debes eliminar la oficina, el empleado y el cliente creados en el apartado anterior.
--		Debes crear variables con los identificadores de clave primaria para eliminar
--			todos los datos de cada una de las tablas en una sola ejecución
-------------------------------------------------------------------------------------------




-------------------------------------------------------------------------------------------
-- 9. Utilizando la BD JARDINERIA, crea un script que realice lo siguiente:
--		Crea un nuevo cliente (invéntate los datos). No debes indicar directamente el código, 
--			sino buscar cuál le tocaría con una SELECT y guardarlo en una variable.

--		Crea un nuevo pedido para dicho cliente (fechaPedido será la fecha actual, fecha esperada 10 días 
--				después de la fecha de pedido, fecha entrega y comentarios a NULL y estado PENDIENTE)
--			Dicho pedido debe constar de dos productos (los códigos de producto se declaran como variables y se utilizan después)
--			El precio de cada producto debes obtenerlo utilizando SELECT antes de insertarlo en DETALLE_PEDIDOS,
--			de tal manera que, si modificamos los códigos de producto, el script seguirá funcionando.
--			La cantidad de los productos comprados puede ser la que tú quieras.

--		Recuerda que debes utilizar TRANSACCIONES (si fueran necesarias) y TRY/CATCH

--		Reto opcional:
--			Crea también un nuevo pago para dicho cliente cuyo importe coincida con lo que cuesta el pedido completo
--				Puedes indicar directamente el idtransaccion como 'ak-std-000026', aunque es mejor que lo obtengas dinámicante
--				utilizando funciones de SQL Server (piensa que los 6 últimos caracteres son números...)
--				Forma de pago debe ser: 'PayPal' y Fechapago la del día
-------------------------------------------------------------------------------------------


