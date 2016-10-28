CREATE TABLE Categorie
(
	CategoriaId INT NOT NULL IDENTITY(1,1),
    NomeCategoria NVARCHAR(50) NOT NULL,
	Descrizione NTEXT DEFAULT ('Nessuna descrizione inserita.'),
	Immagine IMAGE NULL,
    CONSTRAINT PK_Categorie PRIMARY KEY(CategoriaId)
)
