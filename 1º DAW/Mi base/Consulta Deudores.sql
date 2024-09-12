
USE Deudas

GO

SELECT Nombre, FORMAT(Cantidad, '# €'), Descripcion
  FROM DEUDAS d INNER JOIN PERSONAS p
    ON p.idPersona = d.idPersona
 WHERE Pagado = 0
