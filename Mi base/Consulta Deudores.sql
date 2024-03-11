
USE Deudas

GO

SELECT Nombre, FORMAT(Cantidad, '# €')
  FROM DEUDAS d INNER JOIN PERSONAS p
    ON p.idPersona = d.idPersona
 WHERE Pagado = 0
