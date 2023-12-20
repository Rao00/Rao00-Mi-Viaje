
CREATE DATABASE DEUDAS

GO

USE DEUDAS

GO

CREATE TABLE DEUDORES(
    idDeudor    INT IDENTITY    NOT NULL,
    nombre      VARCHAR(100)    NOT NULL,
    apellidos   VARCHAR(200),

    CONSTRAINT PK_DEUDORES PRIMARY KEY (idDeudor)
)

GO

CREATE TABLE COMISIONES(
    idComision          INT IDENTITY    NOT NULL,
    cantidadDias        INT             NOT NULL,
    porcentajeComision  INT             NOT NULL,

    CONSTRAINT PK_COMISIONES PRIMARY KEY (idComision)
)

GO

CREATE TABLE TOTAL_DEUDAS(
	idPrestamo		INT	IDENTITY	NOT NULL,
    idDeudor        INT             NOT NULL,
    idComision      INT             NOT NULL,
    fecha_incio     SMALLDATETIME   NOT NULL,
    cantidad		DECIMAL(9,2)    NOT NULL,

    CONSTRAINT PK_TOTAL_DEUDAS PRIMARY KEY (idPrestamo),
    CONSTRAINT FK_DEUDAS_DEUDORES FOREIGN KEY (idDeudor) REFERENCES DEUDORES(idDeudor),
    CONSTRAINT FK_DEUDAS_COMISIONES FOREIGN KEY (idComision) REFERENCES COMISIONES(idComision),
)

GO

SELECT DISTINCT 
                FROM TOTAL_DEUDAS TD INNER JOIN DEUDORES D ON TD.idDeudor = D.idDeudor,
					COMISIONES C
                WHERE D.nombre = UPPER('Poxi')
                GROUP BY TD.idDeudor


INSERT INTO COMISIONES(min, max)
	VALUES	(0, 6),
			(7, 13),
			(14, 20),
			(21, 365)

DELETE COMISIONES
	VALUES *

SELECT *
	FROM COMISIONES
