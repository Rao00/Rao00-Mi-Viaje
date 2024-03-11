
SET DATEFORMAT dmy

USE Deudas

CREATE TABLE DEUDAS(
    idPersona   INT             NOT NULL,
    Cantidad    DECIMAL(9,2)    NOT NULL,
    Fecha       DATE            NOT NULL,
    Descripcion VARCHAR(500),
    Pagado      BIT DEFAULT 0,

CONSTRAINT PK_DEUDAS PRIMARY KEY (idPersona, Cantidad, Fecha),
CONSTRAINT FK_DEUDAS_PERSONAS FOREIGN KEY (idPersona) REFERENCES PERSONAS(idPersona)
)

GO

INSERT INTO DEUDAS(idPersona, Cantidad, Fecha, Descripcion)
VALUES  (1, 5, '8/3/2023', 'Gasofa Busot'),
        (1, 1.8, '8/3/2023', 'Monster antes Busot'),
        (3, 6, '21/2/2023', 'Fecha aproximada pero es lo del Malibu del otro dia, tambien el debes a alex (no valen mamadas)')

SELECT * FROM DEUDAS
