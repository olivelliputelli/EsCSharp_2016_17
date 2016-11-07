/**************         TABELLA     C A T E G O R I E    ************/
/* Inserire nuove categorie */
INSERT INTO Categorie
(NomeCategoria)
VALUES
('Giocattoli'),
('Frutta'),
('cellulari'),
('Verdura'),
('Carne'),
('Pesce')

/* Modificare una descrizione */
UPDATE Categorie
SET Descrizione = 'Elettronica di consumo.'
WHERE CategoriaId = 3

/* Cancella una riga */
DELETE FROM Categorie
WHERE CategoriaId = 2

/* Lista delle categorie */
SELECT *
FROM Categorie

/**************         TABELLA     N A Z I O N I    ************/
/* importare da internet le nazioni */
CREATE TABLE Nazioni
(
	NazioneId CHAR(2) NOT NULL PRIMARY KEY,
	Denominazione VARCHAR(100)
)

INSERT INTO Nazioni
(NazioneId, Denominazione)
SELECT NazioneId, Denominazione 
FROM Nazioni_daExcel

/* Eliminare una tabella */
DROP TABLE Nazioni_daExcel

/**************         TABELLA     F O R N I T O R      ************/
/* Creazione tabella Fornitori */
CREATE TABLE Fornitori
(
	FornitoreId INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    NomeFornitore NVARCHAR(50) NOT NULL, 
    NomeContatto NVARCHAR(30) NULL, 
    TitoloContatto NVARCHAR(30) NULL, 
    Indirizzo NVARCHAR(60) NULL, 
    Città NVARCHAR(30) NULL, 
    CodicePostale CHAR(5) NULL, 
    NazioneId CHAR(2) NULL DEFAULT ('IT'), 
    Telefono CHAR(20) NULL, 
    Fax CHAR(20) NULL,
	HomePage CHAR(50),
	CONSTRAINT FK_Nazioni_Fornitori FOREIGN KEY (NazioneId) REFERENCES Nazioni(NazioneId) 
)

/**************         TABELLA     C O R R I E R I    ************/
INSERT INTO Corrieri
(Denominazione, CorriereId)
VALUES
('Pippo srl Spedizioni', 'PP1'),
('Minny srl Spedizioni', 'MM1'),
('Pippo & Co. srl Spedizioni', 'PP2')

INSERT INTO Corrieri
VALUES
('AA2', 'Pippo srl Spedizioni', '123', null, 'rr@rr', '12/12/2000')

SELECT *
FROM Corrieri

/* UPDATE */
UPDATE Corrieri
SET Denominazione = 'Minny SPA'
WHERE CorriereId = 'MM1'

UPDATE Corrieri
SET TelefonoCellulare = '123456789' /* FARE MOLTA ATTENZIONE AL WHERE */

/* DELETE */
DELETE FROM Corrieri
WHERE IndirizzoEMail is not null /* FARE MOLTA MOLTA ATTENZIONE AL WHERE */

/* Note: Be very careful when deleting or updating records. You cannot undo this statement! */

SELECT TOP 30 PERCENT *
FROM NazioniA
ORDER BY NazioneId