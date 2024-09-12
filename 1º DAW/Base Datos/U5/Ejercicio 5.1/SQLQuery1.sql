---------------------------------------------------------------
-- Ejercicio 5.1. Obt�n las siguientes consultas con funciones
---------------------------------------------------------------

/* Obt�n el valor absoluto de un n�mero entero (-17) -> resultado 17 */

SELECT ABS(-17) AS RESULTADO

/* N�mero parte entera de un n�mero decimal (35.789) -> resultado 35 */

SELECT FLOOR(35.789) AS RESULTADO

/* Resto de una divisi�n entre dos n�meros enteros (15 y 4) */

SELECT 15%4 AS RESULTADO

/* Potencia de un n�mero y su exponente: 5 elevado a 3 -> resultado = 125 */

SELECT POWER(5,3) AS RESULTADO

/* Ra�z cuadrada de un n�mero (81) */

SELECT POWER(81,0.5) AS RESULTADO
SELECT SQRT(81)		 AS RESULTADO

/* N�mero aleatorio decimal entre 0 y 1 */

SELECT RAND() AS RESULTADO

/* N�mero aleatorio decimal entre 0 y 10 */

SELECT RIGHT(RAND(), 1) AS RESULTADO

/* N�mero aleatorio decimal entre 0 y 100 */

SELECT RIGHT(RAND(), 2) AS RESULTADO

/* Redondea el n�mero 45.267 a un decimal */

SELECT ROUND(45.267, 1) AS RESULTADO

/* Obt�n el signo del n�mero (-45.6) */

SELECT SIGN(-45.6) AS RESULTADO

/* Concatena estas cadenas en una sola: Jos� Garc�a L�pez */

SELECT CONCAT('JOSE ', 'GARCIA ', 'LOPEZ') AS RESULTADO

/* Convierte la cadena a may�sculas: Estudio FP en el IES Mare Nostrum */

SELECT UPPER('Estudio FP en el IES Mare Nostrum') AS RESULTADO

/* Convierte la cadena a min�sculas: Estudio FP en el IES Mare Nostrum */

SELECT LOWER('Estudio FP en el IES Mare Nostrum') AS RESULTADO

/* Obt�n el principio de una cadena (el nombre) de Jos� Garc�a L�pez -> Jos� */

SELECT LEFT('Jos� Garc�a L�pez', 4) AS NOMBRE

/* Obtener una parte final de la cadena anterior (apellido2) -> Garc�a */

SELECT RIGHT('Jos� Garc�a L�pez', 5) AS APELLIDO2

/* Obtener una parte central de la cadena anterior (apellido1) -> L�pez */

SELECT RIGHT(LEFT('Jos� Garc�a L�pez', 11), 6) AS APELLIDO1
SELECT SUBSTRING('Jos� Garc�a L�pez', 6, 6)

/* Obtener la longitud la cadena Jos� Garc�a L�pez -> 17 */

SELECT LEN('Jos� Garc�a L�pez') AS LONGITUD

/* Obt�n la letra del siguiente DNI 12345678M -> M */

SELECT RIGHT('12345678M', 1) AS LETRADNI

/* Eliminar de la cadena '   Juan L�pez Garc�a   ' los espacios al principio y al final*/

SELECT TRIM('   Juan L�pez Garc�a   ') AS NOMBRE

/* Obt�n la longitud de la cadena '   Juan L�pez Garc�a   ' */

SELECT LEN('   Juan L�pez Garc�a   ') AS LONGITUD

/* Obt�n la longitud de la cadena '   Juan L�pez Garc�a   ' sin los espacios (utiliza la funci�n del ejercicio anterior para quitarlos) */

SELECT LEN(TRIM('   Juan L�pez Garc�a   ')) AS LONGITUD

/* Reemplaza en la cadena 'SQL Tutorial', SQL por HTML */

SELECT REPLACE('SQL Tutorial', 'SQL', 'HTML') AS TITULO

/* Muestra 'SQL Tutorial' de forma inversa */

SELECT REVERSE('SQL Tutorial') AS INVERTIDO

/* Obtener la FECHA y HORA actual */

SELECT GETDATE() AS FECHA

/* A�adir 10 d�as a la FECHA �03/05/2023� */

SELECT DATEADD(DAY, 10, '03/05/2023') AS FECHA


/* A�adir 2 a�os a la FECHA �29/10/2022� */

SELECT DATEADD(YEAR, 2, '29/10/2022') AS FECHA

/* Diferencia de d�as entre las FECHAS: 10/02/2023 y 25/03/2023 */

SELECT DATEDIFF(DAY, '10/02/2023', '25/03/2023') AS DIFERENCIA

/* Obtener el valor del D�A de la FECHA ACTUAL */

SELECT DAY(GETDATE()) AS FECHA

/* Obtener el valor del MES de la FECHA ACTUAL */

SELECT MONTH(GETDATE()) AS FECHA

/* Obtener el valor del A�O de la FECHA ACTUAL */

SELECT YEAR(GETDATE()) AS FECHA

 /*Obtener nombre del mes con letras de la fecha 19/03/2023 */

SELECT DATENAME(MONTH,'19/03/2023') AS FECHA

/* Utilizando la funci�n CHARINDEX() obt�n la palabra 'news' de la frase 'No news is good news'
    Debes utilizar tambi�n la funci�n LEFT y/o RIGHT
    Nota: Su equivalente en Oracle es la funci�n INSTR()
*/
-- Soluci�n utilizando CHARINDEX y LEFT o RIGHT

DECLARE @WORD AS VARCHAR(10);
SET @WORD = ''
SELECT SUBSTRING('No news is good news', CHARINDEX(@WORD, 'No news is good news'), LEN(@WORD)) AS SELECCION

-- Soluci�n en la que NO se indican los 4 caracteres que queremos seleccionar con LEFT o RIGHT
-- Hay que obtenerlos de otro modo

SET @WORD = 'news'
SELECT SUBSTRING('No news is good news', CHARINDEX(@WORD, 'No news is good news'), LEN(@WORD)) AS SELECCION

/* Sup�n que tenemos una tabla llamada PIE_FIRMA que consta de dos campos (no se har� con la tabla, sino con strings)
    - fechaFirma DATE
    - lugarFirma VARCHAR(100)

    A partir de la siguiente SELECT, genera el siguiente pie de firma a este:
    'En Alicante, a 8 de junio de 2022'
 */
 
 DECLARE @DATE AS VARCHAR(10);
 DECLARE @CITY AS VARCHAR(100);
 SET @DATE = '08/06/2022';
 SET @CITY = 'Madrid';
 SELECT CONCAT('En ', @CITY, ', a ', DAY(@DATE), ' de ', DATENAME(MONTH, @DATE), ' de ', YEAR(@DATE)) AS FECHALUGAR

/* Utiliza la funci�n ASCII() para obtener el valor ASCII de un car�cter
    Para el car�cter A debe devolver 65
*/

SELECT ASCII('A') AS VASCII

/* Investiga el uso de la funci�n TRANSLATE() y haz un ejemplo de uso */

SELECT TRANSLATE('HOLA COMO ESTAS', 'O', '!') AS CAMBIOS

/* Investiga el uso de la funci�n REPLICATE() y haz un ejemplo de uso */

SELECT REPLICATE('HOLA COMO ESTAS ', 5) AS COPIAS

/* Investiga el uso de la funci�n SPACE() y haz un ejemplo de uso */

SELECT CONCAT('HOLA', SPACE(5), 'COMO ESTAS') AS ESPACIOS
