USE JARDINERIA

GO

CREATE OR ALTER TRIGGER TR_CLIENTES ON CLIENTES
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @ciudad VARCHAR(50) = (SELECT ciudad FROM INSERTED)
    IF (@ciudad = 'Alicante')
    BEGIN
        INSERT INTO CLIENTES
        SELECT * FROM INSERTED
    END
    ELSE
    BEGIN
        SELECT * FROM INSERTED
        PRINT('No se ha podido ingresar el registro somos racistas solo alicantinos')
    END
END

SELECT * FROM CLIENTES

INSERT INTO CLIENTES
VALUES (39, 'Carles', 'Morales', 'Rao', 697145245, 'carmorama@gmail.com', 'carmor 2', NULL, 'Fuentealbilla', 'ESPAÑA', 03004, 11, 698741)

DELETE FROM CLIENTES WHERE codCliente = 39 