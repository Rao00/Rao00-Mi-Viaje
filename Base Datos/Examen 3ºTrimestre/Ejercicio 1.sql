
----------------------------------Ejercicio 1----------------------------------

DECLARE LeerOficinas CURSOR FOR 
SELECT codOficina, ciudad
FROM OFICINAS
OPEN LeerOficinas
    DECLARE @cont INT = 0
    DECLARE @max INT = (SELECT COUNT(1) FROM OFICINAS)
    DECLARE @salida VARCHAR(MAX)

    WHILE (@cont < @max)
    BEGIN
        DECLARE @codOficina CHAR(6)
        DECLARE @ciudad VARCHAR(40)
        DECLARE @numEmpleados INT

        SELECT @codOficina = codOficina, @ciudad = ciudad
          FROM OFICINAS
         ORDER BY codOficina ASC
        OFFSET @cont ROWS
         FETCH NEXT 1 ROWS ONLY

        SELECT @numEmpleados = COUNT(1) 
          FROM EMPLEADOS
         WHERE codOficina = @codOficina

        PRINT CONCAT('La oficina ', @codOficina, ' ubicada en la ciudad ', @ciudad,', tiene un total de ', @numEmpleados,' empleados')
        SET @cont += 1
    END
CLOSE LeerOficinas
DEALLOCATE LeerOficinas

GO
----------------------------------Ejercicio 2----------------------------------

CREATE OR ALTER FUNCTION cuentaProductosCategoria (@codCategoria CHAR(2), @minPrecio DECIMAL(11,2), @maxPrecio DECIMAL(11,2))
RETURNS INT
AS
BEGIN
    RETURN (SELECT COUNT(1)
              FROM PRODUCTOS
             WHERE precio_venta >= @minPrecio
               AND precio_venta <= @maxPrecio
               AND codCategoria = @codCategoria)
END

GO

CREATE OR ALTER FUNCTION obtenerCostePedido (@codPedido INT)
RETURNS DECIMAL(11,2)
BEGIN
    RETURN (SELECT SUM(precio_unidad * cantidad)
              FROM DETALLE_PEDIDOS
             WHERE codPedido = @codPedido)
END

GO

SELECT * 
  FROM PRODUCTOS
 WHERE codProducto = dbo.cuentaProductosCategoria ('OR', 5, 10)

SELECT * 
  FROM PAGOS
 WHERE importe_pago = dbo.obtenerCostePedido(1)

GO
----------------------------------Ejercicio 3----------------------------------

CREATE OR ALTER PROCEDURE realizarPago(@codCliente INT, @codFormaPago CHAR, @importe_pago DECIMAL(11,2), @codPedido INT)
AS
BEGIN
    DECLARE @errorCodigos INT
    SELECT @errorCodigos = codCliente FROM CLIENTES WHERE codCliente = @codCliente
    IF(@codCliente IS NULL OR @errorCodigos IS NULL)
    BEGIN
        RETURN -1
    END

    DECLARE @errorFormaPago CHAR
    SELECT @errorFormaPago = codFormaPago FROM FORMA_PAGO WHERE codFormaPago = @codFormaPago
    IF(@codFormaPago IS NULL OR @errorFormaPago IS NULL)
    BEGIN
        RETURN -2
    END

    IF(@importe_pago IS NULL OR @importe_pago < 0)
    BEGIN
        RETURN -3
    END

    SET @errorCodigos = NULL
    SELECT @errorCodigos = codPedido FROM PEDIDOS WHERE codPedido = @codPedido
    IF(@codPedido IS NULL OR @errorCodigos IS NULL)
    BEGIN
        RETURN -4
    END

    DECLARE @idTransaccion VARCHAR(15) = 'ak-std-000000'
    DECLARE @numIdTransaccion INT = 0
    
    SELECT @numIdTransaccion = CAST(SUBSTRING(id_transaccion,8,8) AS INT)+1
      FROM PAGOS
     ORDER BY id_transaccion DESC
    OFFSET 0 ROWS
     FETCH NEXT 1 ROWS ONLY

    SET @idTransaccion = CONCAT(SUBSTRING(@idTransaccion, 0, 14-LEN(@numIdTransaccion)), @numIdTransaccion)

    BEGIN TRY
    BEGIN TRAN
        INSERT INTO PAGOS
        VALUES (@codCliente, @idTransaccion, GETDATE(), @importe_pago, @codFormaPago, @codPedido)

        UPDATE PEDIDOS
           SET codEstado = 'F',
               comentarios = CONCAT(comentarios, CHAR(10), 'Pago realizado.')
         WHERE codPedido = @codPedido
    COMMIT
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT('Error al realizar el pago')
        RETURN -10
    END CATCH

    PRINT ('Pago realizado con exito')
    RETURN 1
END

GO

DECLARE @exit VARCHAR(MAX)
EXEC @exit = realizarPago 8, 'B', 98.20, 9
PRINT @exit

GO
----------------------------------Ejercicio 4----------------------------------

CREATE OR ALTER TRIGGER TR_CATEGORIA_PRODUCTOS ON CATEGORIA_PRODUCTOS
INSTEAD OF UPDATE, DELETE
AS
BEGIN
    INSERT INTO HIST_CAT_PRODUCTOS
    SELECT *, GETDATE() AS fechaOperacion 
      FROM deleted
END

GO

USE JARDINERIA

SELECT * FROM OFICINAS FOR JSON PATH