Para crear la base de datos y tabla utilizada en este programa se deben hacer los siguientes Queries de SQL. 

CREATE DATABASE 'testdb';

DROP TABLE IF EXISTS 'table_ferreteria';

CREATE TABLE 'table_ferreteria' (
  'codigo_producto' INT PRIMARY KEY,
  'nombre_producto' VARCHAR(20) UNIQUE NOT NULL,
  'stock_producto' INT NOT NULL,
  'color_producto' VARCHAR(3),
  'precio_producto' DOUBLE NOT NULL
  );
  
  
Info para el setup del Server:

server = localhost, 
user = root,
database = testdb,
port = 3306,
password = password.
  
  
  
