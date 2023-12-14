
SELECT	codCliente, nombre_cliente, FLOOR(limite_credito) AS limite_credito_anual, FLOOR(limite_credito/12) AS limite_credito_mensual,
		CONCAT('EL CLIENTE ', UPPER(nombre_cliente), ' TIENE UN LIMITE MENSUAL DE ', FLOOR(limite_credito/12))
  FROM CLIENTES
 WHERE codCliente%2 = 0

