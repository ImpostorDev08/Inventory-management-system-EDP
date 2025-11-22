use inventory
CREATE TABLE admins
(
	id int PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL,
	role VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date DATE NULL
)
