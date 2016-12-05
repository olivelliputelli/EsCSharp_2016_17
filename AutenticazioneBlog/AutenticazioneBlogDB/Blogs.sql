﻿CREATE TABLE Blogs
(
	BlogId INT NOT NULL IDENTITY(1,1),
	UtenteId NVARCHAR(50) NOT NULL,
	IndirizzoUrl VARCHAR(256) NOT NULL,
	DataInserimento DATE DEFAULT(GETDATE()),
	CONSTRAINT PK_Blogs PRIMARY KEY (BlogId),
	CONSTRAINT FK_RuoliUtentiBlogs FOREIGN KEY (UtenteId) REFERENCES Utenti(UserName)
		ON UPDATE CASCADE
		ON DELETE CASCADE,
)