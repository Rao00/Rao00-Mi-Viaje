-----------------------------------------------------
		-- Ejercicio 5.3. Escribe las siguientes consultas
		--					utilizando la BD TIENDA
		-----------------------------------------------------

					--------------------------
					--		CONSULTAS	    --
					--------------------------

-- 1. Calcula el n�mero total de productos que hay en la tabla productos.

SELECT COUNT(codigo) AS tProductos
  FROM PRODUCTO

-- 2. Calcula el n�mero de valores distintos de c�digo de fabricante aparecen en la tabla productos.

SELECT codigo_fabricante, COUNT(codigo_fabricante) AS cantidadFabricantes
  FROM PRODUCTO
 GROUP BY codigo_fabricante

-- 3. Calcula la media del precio de todos los productos.

SELECT AVG(precio) AS mediaPrecios
  FROM PRODUCTO

-- 4. Calcula el precio m�s barato de todos los productos.

SELECT MIN(precio) AS precioMinimo
  FROM PRODUCTO

-- 5. Calcula el precio m�s caro de todos los productos.

SELECT MAX(precio) AS precioMaximo
  FROM PRODUCTO

-- 6. Calcula la suma de los precios de todos los productos.

SELECT SUM(precio) AS totalPrecios
  FROM PRODUCTO

-- 7. Calcula el precio m�s barato de todos los productos del fabricante Asus.

SELECT codigo_fabricante, MIN(precio) AS precioMinimo
  FROM PRODUCTO
 WHERE codigo_fabricante = 1
 GROUP BY codigo_fabricante

-- 8. Calcula la suma de todos los productos del fabricante Asus.

SELECT codigo_fabricante, SUM(precio) AS precioTotal
  FROM PRODUCTO
 WHERE codigo_fabricante = 1
 GROUP BY codigo_fabricante

-- 9. Muestra el precio m�ximo, precio m�nimo, precio medio y el n�mero total de productos que tiene el fabricante Crucial.

SELECT codigo_fabricante, 
       SUM(precio) AS precioTotal,
       MIN(precio) AS precioMinimo,
       MAX(precio) AS precioMaximo,
       AVG(precio) AS precioMedio,
       COUNT(codigo) AS numTotal
  FROM PRODUCTO
 WHERE codigo_fabricante = 6
 GROUP BY codigo_fabricante

-- 10. Calcula el n�mero de productos que tienen un precio mayor o igual a 180�.

SELECT codigo, 
       precio
  FROM PRODUCTO
 WHERE precio >= 180 

-- 11. Calcula el n�mero de productos que tiene cada fabricante con un precio mayor o igual a 180�.

SELECT codigo_fabricante, 
       COUNT(codigo) AS nProductos
  FROM PRODUCTO
 WHERE precio >= 180
 GROUP BY codigo_fabricante


-- 12. Lista el precio medio los productos de cada fabricante.

SELECT codigo_fabricante, 
       AVG(precio) AS precioMedio
  FROM PRODUCTO
 GROUP BY codigo_fabricante

-- 13. Lista el c�digo de los fabricantes cuyos productos tienen un precio medio mayor o igual a 150�.

SELECT codigo_fabricante, 
       AVG(precio) AS precioMedio
  FROM PRODUCTO
 GROUP BY codigo_fabricante
HAVING AVG(precio) >= 150

-- 14. Devuelve un listado con los c�digos de los fabricantes que tienen 2 o m�s productos.

SELECT codigo_fabricante, 
       COUNT(codigo) AS nProductos
  FROM PRODUCTO
 GROUP BY codigo_fabricante
HAVING COUNT(codigo) >= 2

-- 15. Devuelve un listado con los c�digos de los fabricantes y el n�mero de productos que tiene cada uno con un precio superior o igual a 220 �. No es necesario mostrar el nombre de los fabricantes que no tienen productos que cumplan la condici�n.
-- Ejemplo del resultado esperado.
/*	codFabricante | NumProductos
	1				1
	2				2
	6				1			*/

SELECT codigo_fabricante, 
       COUNT(precio) AS totalProductos
  FROM PRODUCTO
 WHERE precio >= 220
 GROUP BY codigo_fabricante

-- 16. Devuelve un listado con los c�digos de los fabricantes donde la suma del precio de todos sus productos es superior a 1000 �.

SELECT codigo_fabricante, 
       SUM(precio) AS precioTotal
  FROM PRODUCTO
 GROUP BY codigo_fabricante
HAVING SUM(precio) >= 1000