SELECT p.*,
       c.nombre_cliente Nombre
  FROM PAGOS p, CLIENTES c
 WHERE p.codCliente = c.codCliente

SELECT p.*,
       c.nombre_cliente Nombre
  FROM PEDIDOS p,
       CLIENTES c
 WHERE p.codCliente = c.codCliente

SELECT  e.*,
        ej.Nombre NombreJefe,
        ej.Apellido1 ApellidoJefe
  FROM EMPLEADOS e LEFT JOIN EMPLEADOS ej
    ON e.codEmplJefe = ej.codEmpleado
   AND e.codEmpleado IS NULL

SELECT pe.codPedido, pe.fecha_pedido,
       d.codProducto, d.cantidad,
       pr.nombre nombreProducto, cp.nombre nombreCategoria
  FROM PEDIDOS pe, 
       DETALLE_PEDIDOS d,
       PRODUCTOS pr, 
       CATEGORIA_PRODUCTOS cp
 WHERE d.codPedido = pe.codPedido
   AND d.codProducto = pr.codProducto
   AND pr.codCategoria = cp.codCategoria

/* pedidos de cada clientes */

SELECT c.codCliente,
       c.nombre_cliente, 
       COUNT(p.codPedido) cantidadPedidos
  FROM PEDIDOS p RIGHT JOIN CLIENTES c
    ON p.codCliente = c.codCliente
 GROUP BY c.codCliente, c.nombre_cliente