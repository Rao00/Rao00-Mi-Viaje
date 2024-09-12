CREATE DATABASE Deudas

USE Deudas

GO

CREATE TABLE PERSONAS(
    idPersona   INT IDENTITY    NOT NULL,
    Nombre      VARCHAR(50)     NOT NULL,
    Apellido1   VARCHAR(50)     NOT NULL,
    Apellido2   VARCHAR(50),
    Telefono    VARCHAR(50)     NOT NULL,

CONSTRAINT PK_PERSONAS PRIMARY KEY (idPersona)
)

GO

INSERT INTO PERSONAS(Nombre, Apellido1, Telefono)
VALUES  ('Alex', 'Pazos', 605224331),
        ('Ivan', 'Escobar', 611166625),
        ('Estel', 'Pascua', 608850802)