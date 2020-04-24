#NAGRADNA ZADACA za 28.04.2020
Unijeti randomno 150 zapisa nastavnik-predmet

USE fakultet
GO

INSERT INTO fakultet.dbo.pred_nastavnik(SifNastavnik,SifPred) 
VALUES (130, (SELECT TOP (1) pred.sifPred FROM [fakultet].[dbo].[pred] as pred ORDER BY NEWID()) )


# csharp2020

# git
git fetch --all

git reset --hard origin/master

git pull origin master


# za sinhronizaciju sa glavnim repo:
git pull algebra master

## Ako nemamo repo Algebra:
git remote add algebra https://github.com/Csharp2020/csharp2020

## Za pregled RR-a
git remote -v
