/*
CREACIÓN / MODIFICACIÓN DE TABLAS
Crea las siguientes tablas:
STREAMERS (codStreamer, nombre, apellidos, pais, edad)
PK: codStreamer (NO se incrementa automáticamente)

TEMATICAS (codTematica, nombre)
PK: codTematica (se incrementa automáticamente)

STREAMERS_TEMATICAS (codStreamer, codTematica, idioma, medio, milesSeguidores)
PK: codStreamer, codTematica
FK: codStreamer  STREAMERS
FK: codTematica  TEMATICAS
*/

CREATE DATABASE REPASO

USE REPASO

DROP TABLE STREAMERS_TEMATICAS
GO
DROP TABLE STREAMERS
GO
DROP TABLE TEMATICAS

GO

CREATE TABLE STREAMERS(
    codStreamer INT,
    nombre      VARCHAR(100),
    apellidos   VARCHAR(200),
    pais        VARCHAR(100),
    edad        INT

CONSTRAINT PK_STREAMERS PRIMARY KEY (codStreamer)
)
GO
CREATE TABLE TEMATICAS(
    codTematica INT,
    nombre      VARCHAR(100)

CONSTRAINT PK_TEMATICAS PRIMARY KEY (codTematica)
)
GO
CREATE TABLE STREAMERS_TEMATICAS(
    codStreamer     INT,
    codTematica     INT,
    idioma          VARCHAR(60),
    media           VARCHAR(60),
    milesSeguidores INT

CONSTRAINT PK_STREAMERS_TEMATICAS PRIMARY KEY (codStreamer, codTematica),
CONSTRAINT FK_ST_STREAMES FOREIGN KEY (codStreamer) REFERENCES STREAMERS(codStreamer),
CONSTRAINT FK_ST_TEMATICAS FOREIGN KEY (codTematica) REFERENCES TEMATICAS(codTematica)
)
GO

/*
GESTIÓN DE TABLAS
Inserta los siguientes STREAMERS:
-	Ibai Llanos de España
-	AuronPlay de España
-	Nate Gentile de España
-	Linus Tech Tips de Canadá
-	DYI Perks sin ningún país
-	Alexandre Chappel de Noruega
-	Tekendo de España
-	Caddac Tech de ningún país

*/

INSERT INTO STREAMERS(codStreamer, nombre, apellidos, pais, edad)
VALUES (1, 'Ibai', 'Llanos', 'España', 27),
       (2, 'Auron', 'Play', 'España', 34),
       (3, 'Nate', 'Gentile', 'España', 29),
       (4, 'Linus', 'Tech Tips', 'Canda', 22),
       (5, 'DYI', 'Perks', NULL, 32),
       (6, 'Alexandre', 'Chappel', 'Noruega', 42),
       (7, 'Tekendo', NULL, 'España', 26),
       (8, 'Caddac', 'Tech', NULL, 25)
GO

/*

Inserta los siguientes TEMAS:
-	Informática
-	Tecnología en general
-	Gaming
-	Variado
-	Bricolaje
-	Viajes
-	Humor

*/

INSERT INTO TEMATICAS(codTematica, nombre)
VALUES (1, 'Informatica'),
       (2, 'Tecnologia'),
       (3, 'Gaming'),
       (4, 'Variado'),
       (5, 'Bricolaje'),
       (6, 'Viajes'),
       (7, 'Humor')
GO

/*

Inserta las siguientes TEMATICAS de STREAMERS:
STREAMER	TEMATICA	idioma	medio	milesSeguidores
AuronPlay	Gaming	Español	YouTube	29200
Ibai Llanos	Variado	Español	Twitch	12800
AuronPlay	Variado	Español	Twitch	14900
Nate Gentile	Informática	Español	YouTube	2450
Linus Tech Tips	Informática	Inglés	YouTube	15200
DYI Perks	Bricolaje	Inglés	YouTube	4140
Alexandre Chappel	Bricolaje	Inglés	YouTube	370
Caddac Tech	Informática	Inglés	YouTube	3
*/

INSERT INTO STREAMERS_TEMATICAS(codStreamer, codTematica, idioma, media, milesSeguidores)
VALUES (2, 3, 'Español', 'YouTube', 29200),
       (1, 4, 'Español', 'Twitch', 12800),
       (2, 4, 'Español', 'Twitch', 14900),
       (3, 1, 'Español', 'YouTube',	2450),
       (4, 1, 'Ingles',	'YouTube', 15200),
       (5, 5, 'Ingles',	'YouTube', 4140),
       (6, 5, 'Ingles',	'YouTube', 370),
       (8, 1, 'Ingles',	'YouTube', 3)

-----------------
--  CONSULTAS  --
-----------------
-- 01. Nombre de las temáticas que tenemos almacenadas, ordenadas alfabéticamente.

SELECT nombre
  FROM TEMATICAS
 ORDER BY nombre

-- 02. Cantidad de streamers cuyo país es "España".

SELECT COUNT(codStreamer)
  FROM STREAMERS
 WHERE pais = 'España'

-- 03, 04, 05. Nombres de streamers cuya segunda letra no sea una "B" (quizá en minúsculas), de 3 formas distintas.

SELECT nombre
  FROM STREAMERS
 WHERE SUBSTRING(nombre, 2, 1) NOT IN ('b', 'B')

SELECT nombre
  FROM STREAMERS
 WHERE SUBSTRING(nombre, 2, 1) <> 'b'
   AND SUBSTRING(nombre, 2, 1) <> 'B'

SELECT nombre
  FROM STREAMERS
EXCEPT
SELECT nombre
  FROM STREAMERS
 WHERE SUBSTRING(nombre, 2, 1) IN ('b', 'B')

-- 06. Media de suscriptores para los canales cuyo idioma es "Español".

SELECT DISTINCT milesSeguidores
  FROM STREAMERS_TEMATICAS
 WHERE idioma = 'Español'

-- 07. Media de seguidores para los canales cuyo streamer es del país "España".

SELECT DISTINCT s.nombre, SUM(st.milesSeguidores)
  FROM STREAMERS_TEMATICAS st INNER JOIN STREAMERS s
    ON st.codStreamer = s.codStreamer
 WHERE s.pais = 'España'
 GROUP BY s.nombre

-- 08. Nombre de cada streamer y medio en el que habla, para aquellos que tienen entre 5.000 y 15.000 miles de seguidores, usando BETWEEN.

SELECT s.nombre, st.media
  FROM STREAMERS_TEMATICAS st INNER JOIN STREAMERS s
    ON st.codStreamer = s.codStreamer
 WHERE st.milesSeguidores BETWEEN 5000 AND 15000

-- 09. Nombre de cada streamer y medio en el que habla, para aquellos que tienen entre 5.000 y 15.000 miles de seguidores, sin usar BETWEEN.

SELECT s.nombre, st.media
  FROM STREAMERS_TEMATICAS st INNER JOIN STREAMERS s
    ON st.codStreamer = s.codStreamer
 WHERE st.milesSeguidores >= 5000 
   AND st.milesSeguidores <= 15000

-- 10. Nombre de cada temática y nombre de los idiomas en que tenemos canales de esa temática 
--(quizá ninguno), sin duplicados.

SELECT DISTINCT t.nombre, st.idioma
  FROM TEMATICAS t LEFT JOIN STREAMERS_TEMATICAS st
    ON t.codTematica = st.codTematica

-- 11. Nombre de cada streamer, nombre de la temática de la que habla y del medio en el que habla de esa temática, usando INNER JOIN.

SELECT s.nombre, t.nombre, st.media
  FROM STREAMERS_TEMATICAS st
 INNER JOIN STREAMERS s ON st.codStreamer = s.codStreamer
 INNER JOIN TEMATICAS t ON st.codTematica = t.codTematica

-- 12. Nombre de cada streamer, nombre de la temática de la que habla y del medio en el que habla de esa temática, usando WHERE.

SELECT s.nombre, t.nombre, st.media
  FROM STREAMERS_TEMATICAS st,
       STREAMERS s,
       TEMATICAS t
 WHERE st.codStreamer = s.codStreamer
   AND st.codTematica = t.codTematica

-- 13. Nombre de cada streamer, del medio en el que habla y de la temática de la que habla en ese medio, incluso si de algún streamer no tenemos dato del medio o de la temática.

SELECT s.nombre, t.nombre, st.media
  FROM STREAMERS_TEMATICAS st
 RIGHT JOIN STREAMERS s ON st.codStreamer = s.codStreamer
  LEFT JOIN TEMATICAS t ON st.codTematica = t.codTematica

-- 14. Nombre de cada medio y cantidad de canales que tenemos anotados en él, ordenado alfabéticamente por el nombre del medio.

SELECT st.media, COUNT(codStreamer)
  FROM STREAMERS_TEMATICAS st
 GROUP BY st.media
 ORDER BY st.media

-- 15, 16, 17, 18. Medio en el que se emite el canal de más seguidores, de 4 formas distintas.

-- 19. Categorías de las que tenemos 2 o más canales.

SELECT DISTINCT st.codTematica
  FROM STREAMERS_TEMATICAS st
 WHERE 2 < (SELECT COUNT(codStreamer)
              FROM STREAMERS_TEMATICAS st)


-- 20. Categorías de las que no tenemos anotado ningún canal, ordenadas alfabéticamente, empleando COUNT.

SELECT t.nombre
  FROM TEMATICAS t LEFT JOIN STREAMERS_TEMATICAS st
    ON t.codTematica = st.codTematica
 GROUP BY t.nombre
HAVING COUNT(st.codTematica) = 0
 ORDER BY t.nombre 


-- 21. Categorías de las que no tenemos anotado ningún canal, ordenadas alfabéticamente, empleando IN / NOT IN.

SELECT t.nombre
  FROM TEMATICAS t
 WHERE t.codTematica NOT IN (SELECT t.codTematica
                               FROM TEMATICAS t LEFT JOIN STREAMERS_TEMATICAS st
                                 ON t.codTematica = st.codTematica
                              WHERE st.codTematica IS NULL)
 ORDER BY t.nombre

-- 22. Categorías de las que no tenemos anotado ningún canal, ordenadas alfabéticamente, empleando ALL / ANY.

SELECT t.nombre
  FROM TEMATICAS t
 WHERE t.codTematica = ANY (SELECT t.codTematica
                              FROM TEMATICAS t LEFT JOIN STREAMERS_TEMATICAS st
                                ON t.codTematica = st.codTematica
                             WHERE st.codTematica IS NULL)
 ORDER BY t.nombre

-- 23. Categorías de las que no tenemos anotado ningún canal, ordenadas alfabéticamente, empleando EXISTS / NOT EXISTS.

SELECT t.codTematica
  FROM TEMATICAS t
 WHERE EXISTS (SELECT t.codTematica
                 FROM TEMATICAS t LEFT JOIN STREAMERS_TEMATICAS st ---Preguntar---
                   ON t.codTematica = st.codTematica
                WHERE st.codTematica IS NULL)
 ORDER BY t.nombre

-- 24. Tres primeras letras de cada país y tres primeras letras de cada idioma, en una misma lista.

SELECT DISTINCT SUBSTRING(s.pais, 1, 3)
  FROM STREAMERS s
 WHERE s.pais IS NOT NULL
UNION
SELECT DISTINCT SUBSTRING(st.idioma, 1, 3)
  FROM STREAMERS_TEMATICAS st

-- 25, 26, 27, 28. Tres primeras letras de países que coincidan con las tres primeras letras de un idioma, sin duplicados, de cuatro formas distintas.

SELECT DISTINCT SUBSTRING(s.pais, 1, 3)
  FROM STREAMERS s
 WHERE s.pais IS NOT NULL
INTERSECT
SELECT DISTINCT SUBSTRING(st.idioma, 1, 3)
  FROM STREAMERS_TEMATICAS st

SELECT DISTINCT SUBSTRING(s.pais, 1, 3)
  FROM STREAMERS s
 WHERE s.pais IS NOT NULL
   AND SUBSTRING(s.pais, 1, 3) = ANY (SELECT DISTINCT SUBSTRING(st.idioma, 1, 3)
                                                 FROM STREAMERS_TEMATICAS st)

SELECT DISTINCT SUBSTRING(s.pais, 1, 3)
  FROM STREAMERS s
 WHERE s.pais IS NOT NULL
   AND SUBSTRING(s.pais, 1, 3) IN (SELECT DISTINCT SUBSTRING(st.idioma, 1, 3)
                                              FROM STREAMERS_TEMATICAS st)

-- 29. Nombre de streamer, nombre de medio y nombre de temática, para los canales que están por encima de la media de suscriptores.

SELECT s.nombre, st.media, t.nombre
  FROM STREAMERS s,
       STREAMERS_TEMATICAS st,
       TEMATICAS t
 WHERE st.codStreamer = s.codStreamer
   AND st.codTematica = t.codTematica
   AND st.milesSeguidores > (SELECT AVG(st.milesSeguidores)
                               FROM STREAMERS_TEMATICAS st)

-- 30. Nombre de streamer y medio, para los canales que hablan de la temática "Bricolaje".

SELECT s.nombre, st.media
  FROM STREAMERS_TEMATICAS st
 INNER JOIN STREAMERS s ON st.codStreamer = s.codStreamer
 INNER JOIN TEMATICAS t ON st.codTematica = t.codTematica
 WHERE t.nombre = 'Bricolaje'
   
-- 31. Crea una tabla de "juegos". Para cada juego querremos un código (clave primaria), un nombre (hasta 20 letras, no nulo) y una referencia al streamer que más habla de él (clave ajena a la tabla "streamers").

CREATE TABLE JUEGOS(
    codJuego            INT IDENTITY(1000,1) NOT NULL,
    nombre              VARCHAR(20) NOT NULL,
    codStreamer_Juego   INT

CONSTRAINT PK_JUEGO PRIMARY KEY (codJuego), 
CONSTRAINT FK_STREAMES_JUEGOS FOREIGN KEY (codStreamer_Juego) REFERENCES STREAMERS(codStreamer)
)

-- 32. Añade a la tabla de juegos la restricción de que el código debe ser 1000 o superior.

ALTER TABLE JUEGOS
ADD CONSTRAINT CK_JUEGOS_CODJUEGO CHECK (codJuego >= 1000)

ALTER TABLE JUEGOS
ALTER COLUMN codJuego INT IDENTITY(1000, 1) NOT NULL
DROP TABLE JUEGOS

-- 33. Añade 3 datos de ejemplo en la tabla de juegos. Para uno indicarás todos los campos, para otro no indicarás el streamer, ayudándote de NULL, y para el tercero no indicarás el streamer porque no detallarás todos los nombres de los campos.

INSERT INTO JUEGOS(nombre, codStreamer_Juego)
VALUES ('God of War', 1)

INSERT INTO JUEGOS(nombre)
VALUES ('League of Legends')

INSERT INTO JUEGOS(nombre)
VALUES ('GTAV')

-- 34. Borra el segundo dato de ejemplo que has añadido en la tabla de juegos, a partir de su código.

--TONTERIA

-- 35. Muestra el nombre de cada juego junto al nombre del streamer que más habla de él, si existe. Los datos aparecerán ordenados por nombre de juego y, en caso de coincidir éste, por nombre de streamer.

SELECT j.nombre, s.codStreamer
  FROM JUEGOS j LEFT JOIN STREAMERS s
    ON j.codStreamer_Juego = s.codStreamer
 ORDER BY j.nombre ASC

-- BAITEADA MAYUSUCULA DEL PROFE  (NO SE PUEDE HACER)

-- 36. Modifica el último dato de ejemplo que has añadido en la tabla de juegos, para que sí tenga asociado un streamer que hable de él.

SELECT * FROM JUEGOS

UPDATE JUEGOS
   SET codStreamer_Juego = 2
 WHERE codJuego = 1002

-- 37. Crea una tabla "juegosStreamers", volcando en ella el nombre de cada juego (con el alias "juego") y el nombre del streamer que habla de él (con el alias "streamer").

SELECT j.nombre juego, s.nombre streamer
  INTO juegosStreamers
  FROM JUEGOS j INNER JOIN STREAMERS s ON j.codStreamer_Juego = s.codStreamer

SELECT * FROM juegosStreamers

-- 38. Añade a la tabla "juegosStreamers" un campo "fechaPrueba".

ALTER TABLE juegosStreamers
  ADD fechaPrueba SMALLDATETIME

-- 39. Pon la fecha de hoy (prefijada, sin usar GetDate) en el campo "fechaPrueba" de todos los registros de la tabla "juegosStreamers".

UPDATE juegosStreamers
   SET fechaPrueba = '2024-02-22'
SELECT * FROM juegosStreamers

-- 40. Muestra juego, streamer y fecha de ayer (día anterior al valor del campo "fechaPrueba") para todos los registros de la tabla "juegosStreamers".

SELECT juego, streamer, (fechaPrueba) - 1
  FROM juegosStreamers

-- 41. Muestra todos los datos de los registros de la tabla "juegosStreamers" que sean del año actual de 2 formas distintas (por ejemplo, usando comodines o funciones de cadenas).

SELECT CONCAT(juego, '-', streamer, '-', fechaPrueba)
  FROM juegosStreamers
 WHERE YEAR(fechaPrueba) = YEAR(GETDATE())

-- 42. Elimina la columna "streamer" de la tabla "juegosStreamers".

ALTER TABLE juegosStreamers
DROP COLUMN streamer

-- 43. Vacía la tabla de "juegosStreamers", conservando su estructura.

TRUNCATE TABLE juegosStreamers

-- 44. Elimina por completo la tabla de "juegosStreamers".

DROP TABLE juegosStreamers

-- 45. Borra los canales del streamer "Caddac Tech".

DELETE FROM STREAMERS_TEMATICAS
 WHERE codStreamer = 8
DELETE FROM STREAMERS
WHERE nombre = 'Caddac'
  AND apellidos = 'Tech'

SELECT * FROM STREAMERS

-- 46. Muestra la diferencia entre el canal con más seguidores y la media, mostrada en millones de seguidores. Usa el alias "diferenciaMillones".

SELECT DIFFERENCE((SELECT TOP 1 milesSeguidores
                     FROM STREAMERS_TEMATICAS
                    ORDER BY milesSeguidores DESC), (SELECT AVG(milesSeguidores)
                                                       FROM STREAMERS_TEMATICAS))

-- 47. Medios en los que tienen canales los creadores de código "ill", "ng" y "ltt", sin duplicados, usando IN (pero no en una subconsulta).



-- 48. Medios en los que tienen canales los creadores de código "ill", "ng" y "ltt", sin duplicados, sin usar IN.

-- 49. Nombre de streamer y nombre del medio en el que habla, para aquellos de los que no conocemos el país.

-- 50. Nombre del streamer y medio de los canales que sean del mismo medio que el canal de Ibai Llanos que tiene 12800 miles de seguidores (puede aparecer el propio Ibai Llanos).

-- 51. Nombre del streamer y medio de los canales que sean del mismo medio que el canal de Ibai Llanos que tiene 12800 miles de seguidores (sin incluir a Ibai Llanos).

-- 52. Nombre de cada streamer, medio y temática, incluso si para algún streamer no aparece ningún canal o para alguna temática no aparece ningún canal.

-- 53. Nombre de medio y nombre de cada temática, como parte de una única lista (quizá desordenada).

-- 54. Nombre de medio y nombre de cada temática, como parte de una única lista ordenada alfabéticamente.

-- 55. Nombre de medio y cantidad media de suscriptores en ese medio, para los que están por encima de la media de suscriptores de los canales.

-- 56. Nombre de los streamers que emiten en YouTube y que o bien hablan en español o bien sus miles de seguidores están por encima de 12.000.

-- 57. Añade información ficticia sobre ti: datos como streamer, temática sobre la que supuestamente y medio en el que hablas sobre ella, sin indicar cantidad de seguidores. Crea una consulta que muestre todos esos datos a partir de tu código.

-- 58. Muestra el nombre de cada streamer, medio en el que emite y cantidad de seguidores, en millones, redondeados a 1 decimal.

-- 59. Muestra el nombre de cada streamer y el país de origen. Si no se sabe este dato, deberá aparecer "(País desconocido)".

-- 60. Muestra, para cada streamer, su nombre, el medio en el que emite (precedido por "Emite en: ") y el idioma de su canal (precedido por "Idioma: ")
