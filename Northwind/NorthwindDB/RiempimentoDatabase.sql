/* Aggiungo qualche categoria */
INSERT INTO Categorie
(NomeCategoria)
VALUES
('Frutta e verdura'),
('Giocattoli'),
('Carne e pesce'),
('Dolci')

/* Elimino la categoria con codice 2 */
DELETE FROM Categorie
WHERE CategoriaId = 2

/* Modifico la descrizione della categoria con codice 3 */
UPDATE Categorie
SET Descrizione = 'Adatti a bambini di età superiore a 12 anni'
WHERE CategoriaId = 3