use inventory
CREATE TABLE archivedproducts
(
	id INT PRIMARY KEY IDENTITY(1,1),
	prod_id VARCHAR (MAX) NULL,
	prod_name VARCHAR (MAX) NULL,
	brand VARCHAR (MAX) NULL,
	category VARCHAR (MAX) NULL,
	stock INT NULL,
	size INT NULL,
	description VARCHAR(MAX) NULL,
	date_insert DATE NULL
)
SELECT * FROM archivedproducts
