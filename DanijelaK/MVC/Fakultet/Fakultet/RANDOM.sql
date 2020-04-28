USE fakultet 
GO

INSERT INTO fakultet.dbo.pred_nastavnik(SifNastavnik,SifPred) 
VALUES (150, (SELECT TOP (1) pred.sifPred FROM [fakultet].[dbo].[pred] as pred ORDER BY NEWID()),
(SELECT TOP (1) nast.sifNastavnik FROM [fakultet].[dbo].[nastavnik] as nast ORDER BY NEWID()));



INSERT INTO [fakultet].[dbo].[pred_nastavnik](SifNastavnik,SifPred)
VALUES (150, (SELECT TOP (1) pred.sifPred, (SELECT TOP (1) nastavnik.sifNastavnik FROM [fakultet].[dbo].[nastavnik] as nastavnik ORDER BY NEWID())
FROM [fakultet].[dbo].[pred] as pred ORDER BY NEWID()));

