CREATE TABLE Fornitori
(
	[FornitoreId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [NomeFornitore] NVARCHAR(50) NOT NULL, 
    [NomeContatto] NVARCHAR(30) NULL, 
    [TitoloContatto] NVARCHAR(30) NULL, 
    [Indirizzo] NVARCHAR(60) NULL, 
    [Città] NVARCHAR(30) NULL, 
    [CodicePostale] CHAR(5) NULL, 
    NazioneId CHAR(2) NULL DEFAULT ('IT'), 
    [Telefono] CHAR(20) NULL, 
    [Fax] CHAR(20) NULL,
	HomePage CHAR(50),
	CONSTRAINT FK_Nazioni_Fornitori FOREIGN KEY (NazioneId) REFERENCES Nazioni(NazioneId) 
)
