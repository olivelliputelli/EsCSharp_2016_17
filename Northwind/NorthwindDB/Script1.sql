SELECT N.NazioneId + ' - ' + N.Denominazione AS [nuovo nome]
FROM Nazioni N

SELECT F.NomeFornitore AS Fornitore, F.NazioneId, N.NazioneId, N.Denominazione AS Nazione
FROM Fornitori F FULL OUTER JOIN Nazioni N ON N.NazioneId = F.NazioneId

SELECT *
FROM Fornitori F, Nazioni N
WHERE N.NazioneId = F.NazioneId

SELECT *
FROM Fornitori F INNER JOIN Nazioni N
ON N.NazioneId = F.NazioneId


SELECT NazioneId, COUNT(*) AS Numero
FROM Fornitori
GROUP BY NazioneId
ORDER BY COUNT(*) DESC












SELECT N.NazioneId, N.Denominazione
FROM Nazioni N

INSERT INTO Fornitori
(NomeFornitore, NomeContatto, NazioneId)
VALUES
('Fornitore 3','Rossi', 'GB'),
('Fornitore 4','Rossi Uno', 'GB'),
('Fornitore 5','Rossi 2', 'IT'),
('Fornitore 6','Rossi 3', 'CA'),
('Fornitore 7','Rossi 4', 'GB'),
('Fornitore 8','Rossi 5', 'GB'),
('Fornitore 9','Rossi 6', 'BZ')

UPDATE Fornitori
SET NazioneId = NULL
WHERE FornitoreId BETWEEN 3 AND 6

SELECT * FROM Fornitori

SELECT *
FROM Fornitori F, Nazioni N
WHERE F.NazioneId = N.NazioneId

SELECT F.NomeFornitore, UPPER(N.Denominazione), LEN(N.Denominazione)
FROM Fornitori F INNER JOIN Nazioni N
ON F.NazioneId = N.NazioneId

SELECT *
FROM Fornitori


SELECT COUNT(NazioneId)
FROM Fornitori

SELECT * FROM Fornitori

SELECT NazioneId, COUNT(*) AS [# Fornitori]
FROM Fornitori
GROUP BY NazioneId