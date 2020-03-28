USE Fakultet
GO


-- Z 3.12
-- ime i prez stud koji su barem jednom pali iz predmeta 
-- sa siframa 220-240

SELECT
stud.imeStud
, stud.prezStud
FROM
ispit INNER JOIN stud ON ispit.mbrStud=stud.mbrStud
WHERE sifPred BETWEEN 220 AND 240 
AND ocjena=1
GO

-- Prirucnik strana 56
-- Z 3.8
-- ime, prez sstudfenta koji su dobili  3

SELECT
stud.imeStud
, stud.prezStud
, ispit.ocjena
FROM stud INNER JOIN ispit ON stud.mbrStud=ispit.mbrStud
WHERE ocjena=3
GO

-- Z3.9
-- nazive predmeta nakoji nijedan student nije izisao
SELECT
nazPred
FROM pred left join ispit on pred.sifPred=ispit.sifPred
WHERE datIspit IS NULL
GO

-- Z3.10
-- ispisi nazive predmeta na koji je izisao barem jedan student
SELECT
DISTINCT nazPred
FROM pred left join ispit on pred.sifPred=ispit.sifPred
WHERE datIspit IS NOT NULL
GO

-- Z 3.11 - 3.14 imamo rjeseno..

-- Z3.15  
-- Ime prezime studenta naziv i ocjenu za svaki ispit

SELECT
s.imeStud
,s.prezStud
,p.nazPred
,i.ocjena
FROM
stud s INNER JOIN ispit i ON s.mbrStud=i.mbrStud 
LEFT JOIN pred p ON p.sifPred=i.sifPred
GO


-- BONUS
-- Grupirati po predmetima koliko je studenata izišlo i koju su prosjecnu ocjenu dobili
SELECT
COUNT(s.imeStud) AS brojstudenata
,p.nazPred
,AVG(CAST (i.ocjena AS DECIMAL(4,2))) AS prosjecna
FROM
stud s INNER JOIN ispit i ON s.mbrStud=i.mbrStud 
LEFT JOIN pred p ON p.sifPred=i.sifPred
GROUP BY p.nazPred
GO

-- Z3.16
-- ime, prez, zupanija roð, mjesti zup stanovanja
SELECT
 s.imeStud
, s.prezStud
, m1.nazMjesto
, z1.nazZupanija
, m2.nazMjesto
,z2.nazZupanija
FROM
stud s LEFT JOIN mjesto m1 ON s.pbrRod = m1.pbr
LEFT JOIN zupanija z1 ON m1.sifZupanija=z1.sifZupanija
LEFT JOIN mjesto m2 ON m2.pbr=s.pbrStan 
LEFT JOIN zupanija z2 ON z2.sifZupanija=m2.sifZupanija
order by s.imeStud DESC
GO

-- Z3.17
-- naz pred i org jed. kojima pripadaju za kolegije sa više od
-- 20 upisanih studenata
SELECT 
p.nazPred
, o.nazOrgjed
,p.upisanoStud
FROM
pred p INNER JOIN  orgjed o ON p.sifOrgjed=o.sifOrgjed
WHERE p.upisanoStud >20

-- 3.18
-- 
SELECT * FROM [Fakultet].[dbo].[V_mjesta_sa_barem_jednim_studentom]
GO












