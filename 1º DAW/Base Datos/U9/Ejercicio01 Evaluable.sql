
------------------------------------------------------------------------------------------------------------------------------------------------------------------------
/* Disparador Biblioteca
 * 
 * Necesitamos crear un trigger para cuando demos de baja un Socio en la biblioteca.
 * Deberemos comprobar si éste tiene algún libro sin devolver (fecha devolución nula),
 * en caso de ser así, que inserte un registro en la tabla LIBROS_PERDIDOS (ISBN, DNI, nombre, fechaBaja), 
 * donde el campo fechaBaja corresponde con la fecha del sistema que tenga en ese momento el ordenador.
 *
 */
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

USE [BIBLIOTECA-EJER-3]

GO

CREATE TABLE LIBROS_PERDIDOS(
    ISBN        CHAR(13),
    DNI         CHAR(9),
    fechaBaja   SMALLDATETIME
)
    
GO

CREATE OR ALTER TRIGGER TR_SOCIO ON SOCIO
INSTEAD OF DELETE
AS
BEGIN
    INSERT INTO LIBROS_PERDIDOS
    SELECT P.ISBN, D.DNI, GETDATE() 
      FROM PRESTAMO P, deleted D
     WHERE P.DNI = D.DNI
       AND P.fechaDevolucion IS NULL

    DELETE FROM PRESTAMO WHERE DNI = ANY(SELECT PRESTAMO.DNI 
                                           FROM PRESTAMO, DELETED 
                                          WHERE PRESTAMO.DNI = DELETED.DNI)
    DELETE FROM SOCIO WHERE DNI = ANY(SELECT SOCIO.DNI 
                                        FROM SOCIO, DELETED 
                                       WHERE SOCIO.DNI = DELETED.DNI)
END

------------------------------------------------------------------------------------------------------------------------------------------------------------------------
/* Disparador Servicio Tecnico
 * 
 * Crear un disparador para que cuando demos de baja un Técnico se compruebe si la suma
 * del importe de las reparaciones de este técnico es mayor que 2500 €, y si lo cumple,
 * guardaremos sus datos personales en una tabla llamada TECNICOS_RESERVA con la
 * misma estructura que la tabla TECNICOS más un campo FechaBaja (con la fecha en la que
 * se realiza la baja, que será la fecha del sistema).
 *
 */
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

GO

CREATE DATABASE ServicioTecnico

GO

USE ServicioTecnico

GO

CREATE TABLE TECNICOS(
  DNI     CHAR(9),
  nombre  VARCHAR(50),
  ciudad  VARCHAR(50),
  salario DECIMAL(9,2),
  CONSTRAINT PK_TECNICOS PRIMARY KEY (DNI)
)

GO

CREATE TABLE REPARACIONES(
  idReparacion  INT IDENTITY,
  fecha         SMALLDATETIME,
  DNI_Tecnico   CHAR(9),
  concepto      VARCHAR(255),
  importe       DECIMAL(9,2)
  CONSTRAINT PK_IDREPARACION PRIMARY KEY (idReparacion),
  CONSTRAINT FK_REPARACIONES_TECNICOS FOREIGN KEY (DNI_Tecnico) REFERENCES TECNICOS(DNI)  
)

CREATE TABLE TECNICOS_RESERVA(
  DNI       CHAR(9),
  nombre    VARCHAR(50),
  ciudad    VARCHAR(50),
  salario   DECIMAL(9,2),
  fechaBaja SMALLDATETIME,
  CONSTRAINT PK_TECNICOSRESERVA PRIMARY KEY (DNI)
)

GO

CREATE OR ALTER TRIGGER TR_TECNICOS ON TECNICOS
INSTEAD OF DELETE
AS
BEGIN
  DECLARE @minGanancias INT = 2500
  IF ((SELECT SUM(importe) 
         FROM REPARACIONES, deleted 
        WHERE DNI_Tecnico = deleted.DNI) > @minGanancias)
  BEGIN
    INSERT INTO TECNICOS_RESERVA
    SELECT D.DNI, D.nombre, D.ciudad, D.salario, GETDATE()
    FROM deleted D
  END
END

GO
------------------------------------------------------------------------------------------------------------------------------------------------------------------------
/* Disparador ALMACENES
 * 
 * Crear un disparador para que cuando demos de baja un Proveedor se realice lo siguiente:
 * Comprobar si ese proveedor suministra algún artículo cuyo Stock sea igual a 0, y si
 * es así, que añada a la tabla ARTICULOS_INEXISTENTES esos artículos (la tabla
 * ARTICULOS_INEXISTENTES tendrá los mismos campos que la tabla ARTICULOS
 * más la fecha de inserción (fecha del sistema) y el nombre del proveedor que se da
 * de baja)
 *
 */
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

USE [SUMINISTRO-RECURSO]

CREATE TABLE ALMACENES(
  codAlmacen  INT,
  descripcion VARCHAR(100),
  direccion   VARCHAR(100),
  ciudad      VARCHAR(100),
  CONSTRAINT PK_ALMACENES PRIMARY KEY (codAlmacen)
)

CREATE TABLE ARTICULO(
  codArticulo   INT,
  nombre        VARCHAR(50),
  stock         INT,
  pvp           DECIMAL(9,2),
  precio_compra DECIMAL(9,2),
  codAlmacen    INT,
  codProveedor  INT,
  CONSTRAINT PK_ARTICULO PRIMARY KEY (codArticulo),
  CONSTRAINT FK_ARTICULO_ALMACEN FOREIGN KEY (codAlmacen) REFERENCES ALMACENES(codAlmacen),
  CONSTRAINT FK_ARTICULO_PROVEEDOR FOREIGN KEY (codProveedor) REFERENCES PROVEEDOR(idProv),
)

CREATE TABLE ARTICULOS_INEXISTENTES(
  codArticulo     INT,
  nombre          VARCHAR(50),
  stock           INT,
  pvp             DECIMAL(9,2),
  precio_compra   DECIMAL(9,2),
  codAlmacen      INT,
  codProveedor    INT,
  fechaInsercion  SMALLDATETIME
)

GO

CREATE OR ALTER TRIGGER TR_PROVEEDOR ON PROVEEDOR
INSTEAD OF DELETE
AS
BEGIN
  INSERT INTO ARTICULOS_INEXISTENTES (codArticulo, nombre, stock, pvp, precio_compra, codAlmacen, codProveedor, fechaInsercion)
  SELECT codArticulo, a.nombre, stock, pvp, precio_compra, codAlmacen, codProveedor, GETDATE()
    FROM ARTICULO a, DELETED d 
   WHERE a.codProveedor = d.idProv
     AND a.stock = 0
END

GO
------------------------------------------------------------------------------------------------------------------------------------------------------------------------
/* Disparador JARDINERIA
 * 
 * Por motivos legales, cada vez que se realiza la actualización de un cliente en la tabla
 * CLIENTES queremos que se almacenen todos sus datos en la tabla
 * CLIENTES_HISTORICO (tendrá la misma estructura que la tabla CLIENTES más un campo
 * con la fecha en la que se realiza la modificación).
 *
 */
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

USE JARDINERIA

SELECT *
  INTO CLIENTES_HISTORICO
  FROM CLIENTES
 WHERE 'HOLA' = NULL

GO

ALTER TABLE CLIENTES_HISTORICO
  ADD CONSTRAINT PK_CODCLIENTE PRIMARY KEY 

GO

CREATE OR ALTER TRIGGER TR_CLIENTES ON CLIENTES
AFTER UPDATE
AS
BEGIN
  SELECT *, GETDATE()
  INTO CLIENTES_HISTORICO
  FROM DELETED
END
