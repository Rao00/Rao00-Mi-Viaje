USE JARDINERIA

---------------------------
-- Actividad. Jardinería --
---------------------------

-- 1. Inserta una nueva oficina en Alicante.

SELECT * FROM OFICINAS

INSERT INTO OFICINAS(codOficina, ciudad, pais, codPostal, telefono, linea_direccion1)
VALUES ('ALI-ES', 'Alicante', 'España', '03005', '+34 965 145 245', 'Calle ni idea nº 4')

UPDATE OFICINAS
SET codOficina = 'ALI-ES'
WHERE ciudad = 'Alicante'

-- 2. Inserta un nuevo empleado para la oficina de Alicante que sea representante de ventas.

SELECT * FROM EMPLEADOS

INSERT INTO EMPLEADOS  (codEmpleado, nombre, apellido1, apellido2, 
                        tlf_extension_ofi, email, 
                        puesto_cargo, 
                        salario, codOficina, codEmplJefe)
VALUES (32, 'Carles', 'Morales', 'Amat', 
        '3211', 'carles@gmail.com', 
        'Representante de ventas', 
        7800, 'ALI-ES', 2)

--3. Inserta un cliente que tenga como representante de ventas el empleado que creamos en el paso anterior.

SELECT * FROM CLIENTES

INSERT INTO CLIENTES (codCliente, nombre_cliente, 
                      nombre_contacto, apellido_contacto,
                      telefono, email,
                      linea_direccion1,
                      ciudad, pais, codPostal,
                      codEmpl_ventas, limite_credito)
VALUES (39, 'Manuel', 
        'Amuel', 'Contreyes', 
        '420696969', 'amuel@gmail.com', 
        'calle campo 31', 
        'Guardamar del segura', 'España', '03140',
        32, 9999999)

-- 4. Inserta un pedido que contenga al menos tres productos para el cliente que acabamos de crear.

SELECT * FROM PEDIDOS 
SELECT * FROM DETALLE_PEDIDOS

INSERT INTO PEDIDOS (codPedido, fecha_pedido, fecha_esperada, codEstado, codCliente)
VALUES (129, GETDATE(), GETDATE() + DAY(1), 'P', 39)
INSERT INTO DETALLE_PEDIDOS (codPedido, codProducto, cantidad, precio_unidad, numeroLinea)
VALUES (129, 87, 723, 70, 1),
       (129, 57, 3502, 29, 2),
       (129, 66, 1089, 9, 3)

--5. Actualiza y/o borra el código del cliente que creamos en el paso anterior. ¿Ha sido posible
--actualizarlo o borrarlo? ¿Por qué? Averigua si hubo cambios en las tablas relacionadas.

UPDATE CLIENTES
   SET codCliente = 300
 WHERE codCliente = 39

DELETE FROM CLIENTES WHERE codCliente = 39

-- No se puede eliminar los datos ni modificarlos ya que la tabla clientes es parte de una FK que bloquea su modificacion

--6. Actualiza la cantidad de unidades solicitadas en el pedido que has creado del siguiente modo:
-- para el 1er producto serán 3 unidades, para el producto 2 serán 2 unidades y el tercero 1 unidad.



--7. Modifica la fecha del pedido que hemos creado a la fecha y hora actuales.


--8. Incrementa en un 5% el precio de los productos que están incluidos en el pedido que has creado.
-- Recuerda que puede que tengas que redondear y/o utilizar la función CAST (XXX as FLOAT)


--9. Vuelve a dejar el precio de dichos productos como estaba anteriormente.


--10. ¿Cuál sería la secuencia de borrado de registros de tablas hasta que finalmente se pueda borrar la oficina de Alicante que creamos en el ejercicio 1? Una vez tengas el script, comprueba que se puede eliminar.


--11. Incrementa en un 20% el precio de los productos que NO estén incluidos en ningún pedido.
-- Recuerda que puede que tengas que redondear y/o utilizar la función CAST (XXX as FLOAT)



--12. Vuelve a dejar el precio de los productos como estaba anteriormente.



--13. Elimina los clientes que no hayan realizado ningún pago.



--14. Elimina los clientes que no hayan realizado un mínimo de 2 pedidos (NOTA: al ejecutar la sentencia fallará por la integridad referencial, es decir, porque hay tablas que tiene relacionado el idCliente como FK).



--15. Borra los pagos del cliente con menor límite de crédito.



--16. Actualiza la ciudad a Alicante para aquellos clientes que tengan un límite de crédito inferior a TODOS los precios de los productos de la categoría Ornamentales (puede que no haya ninguno).



--17. Actualiza la ciudad a Madrid para aquellos clientes que tengan un límite de crédito mensual inferior a ALGUNO de los precios de los productos de la categoría Ornamentales.



--18. Establece a 0 el límite de crédito del cliente que menos unidades pedidas del producto OR-179.



--19. Modifica la tabla detalle_pedido para insertar un campo numérico llamado IVA. Establece el
--valor de ese campo a 18 para aquellos registros cuyo pedido tenga fecha a partir de Enero de
--2009. A continuación, actualiza el resto de pedidos estableciendo el IVA al 21.



--20. Modifica la tabla detalle_pedido para incorporar un campo numérico llamado total_linea y
--actualiza todos sus registros para calcular su valor con la fórmula:
--total_linea = precio_unidad*cantidad * (1 + (iva/100));


--21. Crea una tabla llamada HISTORICO_CLIENTES que tenga la misma estructura que CLIENTES y además un campo llamado fechaAlta de tipo DATE.
--Deberás insertar en una única sentencia los clientes cuyo nombre contenga la letra ‘s’ e informar el campo fechaAlta como la fecha/hora del momento en el que se inserta.


--22. Actualiza a NULL los campos region, pais y codigo_postal en la tabla CLIENTES para todos los registros. Utiliza una sentencia de actualización en la que se actualicen estos 3 campos a partir de los datos existentes en la tabla HISTORICO_CLIENTES. Comprueba que los datos se han trasladado correctamente.


