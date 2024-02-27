USE JARDINERIA

DECLARE @varPrecioMin INT = 75
DECLARE @varPrecioMax INT = 200
SELECT *
  FROM PRODUCTOS
 WHERE precio_venta >= @varPrecioMin
   AND precio_venta <= @varPrecioMax

DECLARE @codCategoria CHAR(2) = 'FR'
DECLARE @nombre VARCHAR(100) = 'Pera'

SELECT * 
  FROM PRODUCTOS
 WHERE codCategoria = @codCategoria
   AND nombre LIKE CONCAT(@nombre, '%')