﻿CREATE TABLE Utenti
(
	UserName NVARCHAR(50) NOT NULL,
	Nominativo VARCHAR(60) NOT NULL,
	Email NVARCHAR(256) NULL,
	PasswordHash NVARCHAR(256) NULL,
	NumeroDiTelefono NVARCHAR(50),
	ConfermaNumeroDiTelefono BIT NOT NULL DEFAULT 0,
	DataInserimento DATE DEFAULT(GETDATE()),
	CONSTRAINT PK_Utenti PRIMARY KEY(UserName),
)
