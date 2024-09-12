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

UPDATE DETALLE_PEDIDOS
   SET cantidad = 3
 WHERE codPedido = 129
   AND numeroLinea = 1

GO

UPDATE DETALLE_PEDIDOS
   SET cantidad = 2
 WHERE codPedido = 129
   AND numeroLinea = 2

GO

UPDATE DETALLE_PEDIDOS
   SET cantidad = 1
 WHERE codPedido = 129
   AND numeroLinea = 3

--7. Modifica la fecha del pedido que hemos creado a la fecha y hora actuales.

UPDATE PEDIDOS
   SET fecha_pedido = GETDATE()
 WHERE codPedido = 129

--8. Incrementa en un 5% el precio de los productos que están incluidos en el pedido que has creado.
-- Recuerda que puede que tengas que redondear y/o utilizar la función CAST (XXX as FLOAT)

SELECT * FROM PRODUCTOS

UPDATE PRODUCTOS
   SET precio_venta += precio_venta * 0.05
 WHERE codProducto = ANY(SELECT codProducto
                           FROM DETALLE_PEDIDOS
                          WHERE codPedido = 129)

--9. Vuelve a dejar el precio de dichos productos como estaba anteriormente.

UPDATE PRODUCTOS
   SET precio_venta = CEILING(precio_venta - precio_venta * 0.05) 
 WHERE codProducto = ANY(SELECT codProducto
                           FROM DETALLE_PEDIDOS
                          WHERE codPedido = 129)

--10. ¿Cuál sería la secuencia de borrado de registros de tablas hasta que finalmente se pueda borrar la oficina de Alicante que creamos en el ejercicio 1? Una vez tengas el script, comprueba que se puede eliminar.

DELETE FROM DETALLE_PEDIDOS
 WHERE codPedido = 129
GO
DELETE FROM PEDIDOS
 WHERE codPedido = 129
GO
DELETE FROM CLIENTES 
 WHERE codCliente = 39
GO
DELETE FROM EMPLEADOS
 WHERE codEmpleado = 32
GO
DELETE FROM OFICINAS
 WHERE codOficina = 'ALI-ES'

--11. Incrementa en un 20% el precio de los productos que NO estén incluidos en ningún pedido.
-- Recuerda que puede que tengas que redondear y/o utilizar la función CAST (XXX as FLOAT)

UPDATE PRODUCTOS
   SET precio_venta += precio_venta*0.2
 WHERE codProducto NOT IN (SELECT codProducto
                             FROM DETALLE_PEDIDOS)

--12. Vuelve a dejar el precio de los productos como estaba anteriormente.

UPDATE PRODUCTOS
   SET precio_venta -= precio_venta*0.2
 WHERE codProducto NOT IN (SELECT codProducto
                             FROM DETALLE_PEDIDOS)

--13. Elimina los clientes que no hayan realizado ningún pago.

DELETE FROM CLIENTES
 WHERE codCliente NOT IN (SELECT codCliente
                            FROM PAGOS)

--14. Elimina los clientes que no hayan realizado un mínimo de 2 pedidos (NOTA: al ejecutar la sentencia fallará por la integridad referencial, es decir, porque hay tablas que tiene relacionado el idCliente como FK).

DELETE FROM CLIENTES
 WHERE codCliente NOT IN (SELECT codCliente
                            FROM PEDIDOS
                           GROUP BY codCliente
                          HAVING COUNT(codPedido) >= 2) 

--15. Borra los pagos del cliente con menor límite de crédito.

DELETE FROM PAGOS
 WHERE codCliente = (SELECT TOP 1 codCliente
                       FROM CLIENTES
                      ORDER BY limite_credito ASC)

--16. Actualiza la ciudad a Alicante para aquellos clientes que tengan un límite de crédito inferior a TODOS los precios de los productos de la categoría Ornamentales (puede que no haya ninguno).

UPDATE CLIENTES
   SET ciudad = 'Alicante'
 WHERE limite_credito < ALL(SELECT precio_venta
                              FROM PRODUCTOS
                             WHERE codCategoria = 'OR')


--17. Actualiza la ciudad a Madrid para aquellos clientes que tengan un límite de crédito mensual inferior a ALGUNO de los precios de los productos de la categoría Ornamentales.

UPDATE CLIENTES
   SET ciudad = 'Madrid'
 WHERE limite_credito/12 < ANY(SELECT precio_venta
                                 FROM PRODUCTOS
                                WHERE codCategoria = 'OR')

--18. Establece a 0 el límite de crédito del cliente que menos unidades pedidas del producto OR-179.

SELECT * FROM PRODUCTOS

UPDATE CLIENTES
   SET limite_credito = 0
 WHERE codCliente = (SELECT TOP 1 p.codCliente
                       FROM PEDIDOS p,
                            DETALLE_PEDIDOS dp,
                            PRODUCTOS pr
                      WHERE pr.refInterna = 'OR-179'
                        AND p.codPedido = dp.codPedido
                        AND dp.codProducto = pr.codProducto
                      ORDER BY cantidad ASC)

--19. Modifica la tabla detalle_pedido para insertar un campo numérico llamado IVA. Establece el
--valor de ese campo a 18 para aquellos registros cuyo pedido tenga fecha a partir de Enero de
--2009. A continuación, actualiza el resto de pedidos estableciendo el IVA al 21.

ALTER TABLE DETALLE_PEDIDOS
  ADD IVA VARCHAR(3)

ALTER TABLE DETALLE_PEDIDOS
ALTER COLUMN IVA TINYINT

SELECT * FROM DETALLE_PEDIDOS

UPDATE DETALLE_PEDIDOS
   SET IVA = 18
 WHERE IVA <> 18
   AND YEAR(2009) <= ANY(SELECT YEAR(fecha_pedido)
                        FROM PEDIDOS)

UPDATE DETALLE_PEDIDOS
   SET IVA = 21
 WHERE IVA <> 21
   AND YEAR(2009) >= ANY(SELECT YEAR(fecha_pedido)
                        FROM PEDIDOS)

--20. Modifica la tabla detalle_pedido para incorporar un campo numérico llamado total_linea y
--actualiza todos sus registros para calcular su valor con la fórmula:
--total_linea = precio_unidad*cantidad * (1 + (iva/100));

SELECT * FROM DETALLE_PEDIDOS

ALTER TABLE DETALLE_PEDIDOS
  ADD total_linea AS CAST(precio_unidad*cantidad*(1+(IVA/100.0)) AS DECIMAL(9,2))
SELECT * FROM DETALLE_PEDIDOS

--21. Crea una tabla llamada HISTORICO_CLIENTES que tenga la misma estructura que CLIENTES y además un campo llamado fechaAlta de tipo DATE.
--Deberás insertar en una única sentencia los clientes cuyo nombre contenga la letra ‘s’ e informar el campo fechaAlta como la fecha/hora del momento en el que se inserta.

SELECT * FROM HISTORICO_CLIENTES

DROP TABLE HISTORICO_CLIENTES

CREATE TABLE HISTORICO_CLIENTES(
    codCliente        INT,
    nombre_cliente    VARCHAR(100),
    nombre_contacto   VARCHAR(100),
    apellido_contacto VARCHAR(200),
    telefono          VARCHAR(15),
    email             VARCHAR(200),
    linea_direccion1  VARCHAR(200),
    linea_direccion2  VARCHAR(200),
    ciudad            VARCHAR(100),
    pais              VARCHAR(50),
    codPostal         VARCHAR(5),
    codEmpl_ventas    INT,
    limite_credito    DECIMAL(9,2),
    fecha_alta        DATE
)

INSERT INTO HISTORICO_CLIENTES
SELECT *, GETDATE()
  FROM CLIENTES
 WHERE nombre_cliente LIKE('%s%') 


--22. Actualiza a NULL los campos pais y codigo_postal en la tabla CLIENTES para todos los registros. Utiliza una sentencia de actualización en la que se actualicen estos 2 campos a partir de los datos existentes en la tabla HISTORICO_CLIENTES. Comprueba que los datos se han trasladado correctamente.

SELECT * FROM CLIENTES

UPDATE CLIENTES
   SET pais = NULL, codPostal = NULL

UPDATE c
   SET c.pais = hc.pais,
       c.codPostal = hc.codPostal
  FROM CLIENTES c INNER JOIN HISTORICO_CLIENTES hc
    ON c.codCliente = hc.codCliente
