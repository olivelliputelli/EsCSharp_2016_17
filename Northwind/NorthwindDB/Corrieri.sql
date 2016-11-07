CREATE TABLE Corrieri
(
   CorriereId CHAR(3) NOT NULL,
   Denominazione NVARCHAR(50) NOT NULL,
   Telefono CHAR(20) NULL,
   TelefonoCellulare CHAR(20) NULL,
   IndirizzoEMail VARCHAR(50) NULL,
   DataUltimaModifica DATETIME DEFAULT(GETDATE()) NOT NULL,
   CONSTRAINT PK_Corrieri PRIMARY KEY(CorriereId), 
   CONSTRAINT CK_IndirizzoEMail CHECK (IndirizzoEMail LIKE '%@%')
)
