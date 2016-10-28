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

/* Lista delle caTEGORIE */
SELECT *
FROM Categorie

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

DROP TABLE Nazioni_daExcel