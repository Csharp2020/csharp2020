USE fakultet 
GO

INSERT INTO fakultet.dbo.pred_nastavnik(SifNastavnik,SifPred) 
VALUES ((SELECT TOP (1) [sifNastavnik] FROM [fakultet].[dbo].[nastavnik] ORDER BY NEWID()),
(SELECT TOP (1) [sifPred] FROM [fakultet].[dbo].[pred] ORDER BY NEWID()))
GO


