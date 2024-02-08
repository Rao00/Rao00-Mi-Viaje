		-----------------------------------------------------
		-- Ejercicio 5.5. Escribe las siguientes consultas
		--					utilizando la BD JARDINERIA
		-----------------------------------------------------

					--------------------------
					--		CONSULTAS	    --
					--------------------------

-----------------------------------
-- A) Consultas de conjuntos (4) --
-----------------------------------

USE JARDINERIA

-- 1. Devuelve los códigos de los clientes que realizaron pedidos en 2022 y los clientes que realizaron pagos por transferencia. Utiliza la unión.
SELECT DISTINCT(p.codCliente)
  FROM PEDIDOS p
 WHERE YEAR(p.fecha_pedido) = 2022
 UNION
SELECT p.codCliente
  FROM PAGOS p
 WHERE p.codFormaPago = 'T' 
;

-- 2. Devuelve los códigos de los clientes que realizaron pedidos en 2022 y que también realizaron algún pago por transferencia. Utiliza la intersección.
SELECT DISTINCT(p.codCliente)
  FROM PEDIDOS p
 WHERE YEAR(p.fecha_pedido) = 2022
 INTERSECT
SELECT p.codCliente
  FROM PAGOS p
 WHERE p.codFormaPago = 'T' 
;

-- 3. Devuelve los códigos de los clientes que realizaron pedidos en 2022 PERO QUE NO los clientes que realizaron pagos por transferencia. Utiliza la diferencia.
SELECT DISTINCT(p.codCliente)
  FROM PEDIDOS p
 WHERE YEAR(p.fecha_pedido) = 2022
 EXCEPT
SELECT p.codCliente
  FROM PAGOS p
 WHERE p.codFormaPago = 'T' 
;

-- 4. Propón el enunciado de una consulta de conjuntos y escribe la consulta SQL.

-- 4.1. Devuelve los codigos de los clientes que realizaros pagos en Enero y en Mayo de 2019 pero que no hayan realizado pedidos en 2020 por paypal 
SELECT p.codCliente
  FROM PAGOS p
 WHERE MONTH(p.fechaHora_pago) IN (1,5)
   AND YEAR(p.fechaHora_pago) = 2019
 EXCEPT
SELECT p.codCliente
  FROM PEDIDOS p,
       PAGOS pa
 WHERE p.codCliente = pa.codCliente
   AND YEAR(p.fecha_pedido) = 2020
   AND pa.codFormaPago = 'P'
;

----------------------------------
--    B) Subconsultas (20)      --
----------------------------------
-- Con operadores básicos de comparación

-- 1. Devuelve el nombre del cliente con mayor límite de crédito.
SELECT c.nombre_cliente
  FROM CLIENTES c
 WHERE c.limite_credito = (SELECT MAX(c.limite_credito)
 						                 FROM CLIENTES c)
;

-- 2. Devuelve el nombre del producto que tenga el precio de venta más caro.
SELECT p.nombre
  FROM PRODUCTOS p
 WHERE p.precio_venta = (SELECT MAX(p.precio_venta)
 					                 FROM PRODUCTOS p)
;

-- 3. Devuelve el producto que más unidades tiene en stock. Si salen varios, quédate solo con uno.
SELECT p.codProducto, p.nombre
  FROM PRODUCTOS p
 WHERE p.codProducto = (SELECT MIN(p.codProducto)
					            	  FROM PRODUCTOS p
					            	 WHERE p.cantidad_en_stock = (SELECT MAX(p.cantidad_en_stock)
					            							                		FROM PRODUCTOS p))
;

-- 4. Devuelve el producto que menos unidades tiene en stock.
SELECT p.codProducto, p.nombre
  FROM PRODUCTOS p
 WHERE p.codProducto = (SELECT MIN(p.codProducto)
						              FROM PRODUCTOS p
						             WHERE p.cantidad_en_stock = (SELECT MIN(p.cantidad_en_stock)
						            								                FROM PRODUCTOS p))
;

-- 5. Devuelve el nombre, los apellidos y el email de los empleados que están a cargo de Alberto Soria.
SELECT e.nombre, e.apellido1, e.apellido2, e.email
  FROM EMPLEADOS e
 WHERE e.codEmplJefe = (SELECT ej.codEmpleado 
                          FROM EMPLEADOS ej 
                         WHERE ej.nombre = 'Alberto'
                           AND ej.apellido1 = 'Soria')
;

-- 6. Propón el enunciado de una consulta de conjuntos y escribe la consulta SQL (puede ser de cualquier tipo, con IN, NOT IN, ALL, ANY, etc).

-- 6.1. Devuelve los codigos de los clientes que realizaros pagos en Enero y en Mayo de 2019, su empleado de ventas tiene como jefe a Alberto Soria no tiene que haber realizado pedidos en 2020 ni por paypal ni por transaccion
SELECT p.codCliente
  FROM PAGOS p,
       CLIENTES c
 WHERE MONTH(p.fechaHora_pago) IN (1,5)
   AND YEAR(p.fechaHora_pago) = 2019
   AND c.codEmpl_ventas = ANY (SELECT e.codEmpleado
                                 FROM EMPLEADOS e
                                WHERE e.codEmplJefe = (SELECT ej.codEmpleado 
                                                         FROM EMPLEADOS ej 
                                                        WHERE ej.nombre = 'Alberto'
                                                          AND ej.apellido1 = 'Soria'))
 EXCEPT
SELECT p.codCliente
  FROM PEDIDOS p,
       PAGOS pa
 WHERE p.codCliente = pa.codCliente
   AND YEAR(p.fecha_pedido) = 2020
   AND pa.codFormaPago IN ('P', 'T')
;


--------------------------------------------------------------------
--  Subconsultas con ALL y ANY  --
--  IMPORTANTE: NO UTILIZAR MAX o MIN en las subconsultas
--------------------------------------------------------------------

-- 1. Devuelve el nombre del cliente con mayor límite de crédito.
SELECT c.nombre_cliente
  FROM CLIENTES c
 WHERE c.limite_credito > ALL(SELECT cl.limite_credito
                                FROM CLIENTES cl
                               WHERE c.codCliente <> cl.codCliente)
;

-- 2. Devuelve el nombre del producto que tenga el precio de venta más caro.
SELECT p.nombre
  FROM PRODUCTOS p
 WHERE p.precio_venta >= ALL(SELECT pl.precio_venta
                               FROM PRODUCTOS pl)
;

-- 3. Devuelve el producto que menos unidades tiene en stock.
SELECT p.nombre
  FROM PRODUCTOS p
 WHERE p.cantidad_en_stock <= ALL(SELECT pl.cantidad_en_stock
                                    FROM PRODUCTOS pl)
;


----------------------------------
-- Subconsultas con IN y NOT IN --
----------------------------------

-- 1. Devuelve un listado que muestre solamente los clientes que no han realizado ningún pago.
SELECT codCliente, nombre_cliente
  FROM CLIENTES
 WHERE codCliente NOT IN (SELECT codCliente
                            FROM PAGOS)
;

-- 2. Devuelve un listado que muestre solamente los clientes que han realizado algún pago.
SELECT codCliente, nombre_cliente
  FROM CLIENTES
 WHERE codCliente IN (SELECT codCliente
                        FROM PAGOS)
;
-- 3. Devuelve un listado de los productos que nunca han aparecido en un pedido.
SELECT codCliente, nombre_cliente
  FROM CLIENTES
 WHERE codCliente NOT IN (SELECT codCliente
                            FROM PEDIDOS)
;

-- 4. Devuelve el nombre, apellidos, puesto y teléfono de la oficina de aquellos empleados que no sean representante de ventas de ningún cliente.
SELECT e.nombre, e.apellido1, e.apellido2, e.puesto_cargo, o.telefono
  FROM EMPLEADOS e,
       OFICINAS o
 WHERE e.codEmpleado NOT IN (SELECT c.codEmpl_ventas
                               FROM CLIENTES c)
   AND e.codOficina = o.codOficina
;

-- 5. Devuelve las oficinas donde trabajan alguno de los empleados.
SELECT o.codOficina
  FROM OFICINAS o
 WHERE o.codOficina IN (SELECT e.codOficina
                          FROM EMPLEADOS e)
;
				   
-- 6. Devuelve un listado con los clientes que han realizado algún pedido pero no que hayan realizado ningún pago.
SELECT c.codCliente 
  FROM CLIENTES c
 WHERE c.codCliente IN (SELECT codCliente
                          FROM PEDIDOS)
   AND c.codCliente NOT IN (SELECT codCliente
                              FROM PAGOS)
;


------------------------------------------
-- Subconsultas con EXISTS y NOT EXISTS --
------------------------------------------

-- 1. Devuelve un listado que muestre solamente los clientes que no han realizado ningún pago.
SELECT c.codCliente
  FROM CLIENTES c
 WHERE NOT EXISTS (SELECT p.codCliente
                     FROM PAGOS p
                    WHERE p.codCliente = c.codCliente)
;

-- 2. Devuelve un listado que muestre solamente los clientes que han realizado algún pago.
SELECT c.codCliente
  FROM CLIENTES c
 WHERE EXISTS (SELECT p.codCliente
                 FROM PAGOS p
                WHERE p.codCliente = c.codCliente)
;

-- 3. Devuelve un listado de los productos que nunca han aparecido en un pedido.
SELECT p.codProducto
  FROM PRODUCTOS p
 WHERE NOT EXISTS(SELECT dp.codProducto
                    FROM DETALLE_PEDIDOS dp
                   WHERE dp.codProducto = p.codProducto)
;

-- 4. Devuelve un listado de los productos que han aparecido en un pedido alguna vez.
SELECT p.codProducto
  FROM PRODUCTOS p
 WHERE EXISTS(SELECT dp.codProducto
                FROM DETALLE_PEDIDOS dp
               WHERE dp.codProducto = p.codProducto)
;


---------------------------
--		  Vistas		 --
---------------------------

-- 1. Crea una vista que devuelva los códigos de los clientes que realizaron pedidos en 2009 y los clientes que realizaron pagos por transferencia. Utiliza la unión.
CREATE VIEW VcodCliente2009T AS
SELECT c.codCliente
  FROM CLIENTES c
 WHERE EXISTS (SELECT p.codCliente
                 FROM PEDIDOS p
                WHERE YEAR(p.fecha_pedido) = '2009'
                  AND p.codCliente = c.codCliente)
UNION
SELECT p.codCliente
  FROM PAGOS p
 WHERE p.codFormaPago = 'T'
;

-- 2. Escribe el código SQL para realizar una consulta a dicha vista

SELECT *
  FROM VcodCliente2009T

-- 3. Escribe el código SQL para eliminar dicha vista.

DROP VIEW VcodCliente2009T