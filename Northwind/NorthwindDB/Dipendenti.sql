CREATE TABLE [dbo].[Dipendenti]
(
	[DipendenteId] INT IDENTITY(1,1) NOT NULL,
    [Nome] NVARCHAR(50) NOT NULL, 
    [Cognome] NVARCHAR(50) NOT NULL, 
    Titolo CHAR(5) NULL DEFAULT('MR'),
	DataDiNascita DATE NULL,
	Indirizzo NVARCHAR(60) NULL,
	Citta NVARCHAR(60) NULL,
	NazioneId CHAR(2) NULL DEFAULT('IT'),
	Fotografia IMAGE NULL,
	Note NTEXT NULL DEFAULT ('Nessuna nota.'),
	ResponsabileId INT NULL,
	DataUltimaModifica DATETIME NOT NULL DEFAULT(GETDATE()),
	CONSTRAINT PK_Dipendenti PRIMARY KEY(DipendenteId),
	CONSTRAINT CK_Titolo CHECK (Titolo IN ('MR', 'MS', 'Miss')),
	CONSTRAINT FK_Nazioni_Dipendenti FOREIGN KEY(NazioneId) 
		REFERENCES Nazioni(NazioneID)
)
