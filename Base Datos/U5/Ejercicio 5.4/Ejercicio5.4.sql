		-----------------------------------------------------
		-- Ejercicio 5.4. Escribe las siguientes consultas
		--					utilizando la BD JARDINERIA
		-----------------------------------------------------

					--------------------------
					--		CONSULTAS	    --
					--------------------------

---------------------------------------
-- A) Consultas sobre una tabla (16) --
---------------------------------------

USE JARDINERIA

-- 1. Devuelve un listado con el código de oficina y la ciudad donde hay oficinas.
SELECT o.codOficina,
       o.ciudad
  FROM OFICINAS o
;
-- 2. Devuelve un listado con la ciudad y el teléfono de las oficinas del país España.
SELECT o.ciudad,
       o.telefono
  FROM OFICINAS o
 WHERE o.pais = 'España'
;
-- 3. Devuelve un listado con el nombre, apellidos y email de los empleados cuyo jefe tiene un código de jefe igual a 7.
SELECT e.nombre,
       e.apellido1,
       e.apellido2,
       e.email
  FROM EMPLEADOS e
 WHERE e.codEmplJefe = 7
;
-- 4. Devuelve el nombre del puesto, nombre, apellidos y email del empleado que NO tiene ningún jefe/a
SELECT e.puesto_cargo,
       e.nombre,
       e.apellido1,
       e.apellido2,
       e.email
  FROM EMPLEADOS e
 WHERE e.codEmplJefe IS NULL
;
-- 5. Devuelve un listado con el nombre, apellidos y puesto de aquellos empleados que no sean representantes de ventas.
SELECT e.nombre,
       e.apellido1,
       e.apellido2,
       e.puesto_cargo
  FROM EMPLEADOS e
 WHERE e.puesto_cargo <> 'Representante Ventas'
;
-- 6. Devuelve un listado con el nombre de los todos los clientes españoles.
SELECT c.nombre_cliente,
       c.pais
  FROM CLIENTES c
 WHERE c.pais = 'Spain'
;
-- 7. Devuelve un listado con los distintos estados por los que puede pasar un pedido.
SELECT ep.codEstado,
       ep.descripcion
  FROM ESTADOS_PEDIDO ep
;
-- 8. Devuelve un listado con el código de cliente de aquellos clientes que realizaron algún pago en 2023.
-- Ten en cuenta que deberás eliminar aquellos códigos de cliente que aparezcan repetidos.
SELECT c.nombre_cliente,
       p.fecha_pedido,
       COUNT(p.codPedido) cantidadPedidos
  FROM CLIENTES c,
       PEDIDOS p
 WHERE c.codCliente = p.codCliente
   AND YEAR(p.fecha_pedido) = 2023
 GROUP BY c.nombre_cliente, p.fecha_pedido
;
-- 9. Devuelve un listado con el código de pedido, código de cliente, fecha esperada y fecha de entrega de los pedidos que no han sido entregados a tiempo.
SELECT p.codPedido,
       p.codCliente,
       p.fecha_esperada,
       p.fecha_entrega
  FROM PEDIDOS p
 WHERE p.fecha_entrega > p.fecha_esperada
;
-- 10. Devuelve un listado con el código de pedido, código de cliente, fecha esperada y fecha de entrega de los 
-- pedidos cuya fecha de entrega ha sido al menos dos días antes de la fecha esperada.
SELECT p.codPedido,
       p.codCliente,
       p.fecha_esperada,
       p.fecha_entrega
  FROM PEDIDOS p
 WHERE p.fecha_entrega > p.fecha_esperada
;
-- Utilizando la función DATEADD
SELECT p.codPedido,
       p.codCliente,
       p.fecha_esperada,
       p.fecha_entrega
  FROM PEDIDOS p
 WHERE p.fecha_entrega >= DATEADD("D",2, p.fecha_esperada)
;
-- 11. Misma consulta pero utilizando la función DATEDIFF
SELECT p.codPedido,
       p.codCliente,
       p.fecha_esperada,
       p.fecha_entrega
  FROM PEDIDOS p
 WHERE DATEDIFF("D", p.fecha_esperada, p.fecha_entrega) >= 2
;
-- 12. Devuelve un listado de todos los pedidos que fueron rechazados en 2022
SELECT *
  FROM PEDIDOS p
 WHERE YEAR(p.fecha_pedido) = 2022
   AND codEstado = 'R'
;
-- 13. Devuelve un listado de todos los pedidos que han sido entregados en el mes de enero de cualquier año
SELECT *
  FROM PEDIDOS p
 WHERE MONTH(p.fecha_pedido) = 1
   AND p.codEstado = 'E'
;
-- 14. Devuelve un listado con todos los pagos que se realizaron en el año 2022 mediante Paypal. Ordena el resultado de mayor a menor
SELECT *
  FROM PAGOS p
 WHERE p.codFormaPago = 'P'
   AND YEAR(p.fechaHora_pago) = 2022
 ORDER BY codCliente DESC
;
-- 15. Devuelve un listado con todas las formas de pago que aparecen en la tabla PAGOS. Ten en cuenta que no deben aparecer formas de pago repetidas.
SELECT p.codFormaPago
  FROM PAGOS p
 GROUP BY p.codFormaPago
;
-- 16. Devuelve un listado con todos los productos que pertenecen a la categoría Ornamentales y que tienen más de 100 unidades en stock.
-- El listado deberá estar ordenado por su precio de venta, mostrando en primer lugar los de mayor precio.
SELECT *
  FROM PRODUCTOS
 WHERE codCategoria = 'OR'
   AND cantidad_en_stock > 100
 ORDER BY precio_venta DESC
;
-- 17. Devuelve un listado con todos los clientes que sean de la ciudad de Madrid y cuyo representante de ventas tenga el código de empleado 11 o 30
SELECT *
  FROM CLIENTES
 WHERE ciudad = 'Madrid'
   AND (codEmpl_ventas = 11 OR codEmpl_ventas = 30)
;

----------------------------------------------------------------
-- B) Consultas de agrupación o de funciones de agregado (18) --
----------------------------------------------------------------

-- 18. ¿Cuántos empleados hay en la compañía?
SELECT ;

-- 19. ¿Cuántos clientes tiene cada país?
SELECT ;

-- 20. ¿Cuál fue el pago medio de 2022?
SELECT ;

-- 21. ¿Cuántos pedidos hay en cada estado? Ordena el resultado de forma descendente por el número de pedidos.
SELECT ;

-- 22. Calcula el precio de venta del producto más caro y más barato en una misma consulta.
SELECT ;

-- 23. ¿Cuántos clientes tiene la ciudad de Madrid?
SELECT ;

-- 24. ¿Calcula cuántos clientes tiene cada una de las ciudades que empiezan por M?
SELECT ;

-- 25. Devuelve el código de los representantes de ventas y el número de clientes al que atiende cada uno.
SELECT ;

-- 26. Calcula el número de clientes que no tiene asignado representante de ventas.
SELECT ;

-- 27. Calcula el número de productos diferentes que hay en cada uno de los pedidos.
SELECT ;

-- 28. Calcula la suma de la cantidad total de todos los productos que aparecen en cada uno de los pedidos
SELECT ;

-- 29. Devuelve un listado de los 20 productos más vendidos y el número total de unidades que se han vendido de cada uno.
-- El listado deberá estar ordenado por el número total de unidades vendidas.
SELECT ;

-- 30. Obtener el número de empleados por oficina, siempre que el número de empleados sea mayor que 4.
SELECT ;

-- 31. Obtener los clientes que hayan realizado más de dos pagos de mínimo 1000 euros.
-- Mostrar también el número de pagos realizados.
SELECT ;

----------------------------------------------------------------
--				C) Consultas multitabla (10)				  --
----------------------------------------------------------------

-- 32. Obtén los nombres de los productos, la cantidad y el precio para los productos incluidos en los pedidos 3 y 5. Ordénalo por número de pedido y número de producto ascendentemente.
SELECT ;

-- 33. Obtén un listado con los nombres de los clientes que han realizado algún pago. Deben aparecer los campos nombre cliente, fecha de pago y total ordenado ascendentemente por cliente y fecha.
SELECT ;

-- 34. Obtén un listado con el nombre de cada cliente y el nombre y apellido de su representante de ventas.
SELECT ;

-- 35. Muestra el nombre de los clientes que hayan realizado pagos junto con el nombre de sus representantes de ventas. Solo deben aparecer una vez.
SELECT ;

-- 36. Devuelve el nombre de los clientes que han hecho pedidos y el nombre de sus representantes junto con la ciudad de la oficina a la que pertenece el representante.
SELECT ;

-- 37. Lista la dirección de las oficinas que tengan clientes en Fuenlabrada.
SELECT ;

-- 38. Devuelve un listado con el nombre de los empleados junto con el nombre de sus jefes (debes utilizar dos alias para la tabla EMPLEADOS).
SELECT ;

-- 39. Devuelve el nombre de los clientes a los que no se les ha entregado a tiempo un pedido. Si se han retrasado varios pedidos, el cliente solo debe aparecer una vez.
SELECT ;

-- 40. Muestra el nombre de los clientes y el número de pagos que han realizado.
-- Deben aparecer todos, independientemente de si han realizado un pago o no.
SELECT ;

-- 41. Muestra el nombre de los clientes y el número de pedidos que han sido Entregados.
-- Deben aparecer todos, independientemente de si han realizado un pedido o no.
SELECT ;


