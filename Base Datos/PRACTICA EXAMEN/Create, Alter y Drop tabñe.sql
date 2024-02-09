
-------------------------------------------------------------------------------------------------------
----------------------------EJERCICIOS DE REPASO CREATE, DROP Y ALTER TABLE----------------------------
-------------------------------------------------------------------------------------------------------

----------------------------------------------EJERCICIO 1----------------------------------------------

--DUEÑO (DNI, nombre, dirección)
--  PK: DNI
--COCHE (numbastidor, marca, modelo, DNI)
--  PK: numbastidor
--  FK: DNI → DUEÑO

CREATE TABLE DUEÑO(
    DNI         CHAR(10),
    nombre      VARCHAR(100),
    direccion   VARCHAR(200)

    CONSTRAINT PK_DUEÑO PRIMARY KEY (DNI)
)

CREATE TABLE COCHE(
    numbastidor     CHAR(17),
    marca           VARCHAR(100),
    modelo          VARCHAR(100),
    DNI             CHAR(10)

    CONSTRAINT PK_COCHE PRIMARY KEY (numbastidor),
    CONSTRAINT FK_DNI_DUEÑO FOREIGN KEY (DNI) REFERENCES DUEÑO(DNI)
)

----------------------------------------------EJERCICIO 2----------------------------------------------

--PROVEEDOR (codProveedor, nombre, dirección)
--  PK: codProveedor
--ARTICULO (codArticulo, descripcion, precio, existencias)
--  PK: codArticulo
--SUMINISTRO (codProveedor, codArticulo)
--  PK: codProveedor, codArticulo
--  FK: codProveedor → PROVEEDOR
--  FK: codArticulo → ARTÍCULO 