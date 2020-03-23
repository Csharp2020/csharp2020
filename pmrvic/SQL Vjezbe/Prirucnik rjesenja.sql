USE [Fakultet]
GO

SELECT [pbr]*2 AS pbrputa2
      ,CONCAT(mjesto."nazMjesto", ' je mjesto u kojem živim') AS dodatak_mjestu
    --  ,[sifZupanija]
  FROM [dbo].[mjesto]
GO

USE Fakultet
GO

/* selekt nekih polja*/
SELECT
imeNastavnik, prezNastavnik
FROM Fakultet.dbo.nastavnik
GO

--  Operacije funkcija nad poljima
SELECT
imeNastavnik+' ' +prezNastavnik AS Imeiprezime
FROM Fakultet.dbo.nastavnik
GO

--  filtiriranje
SELECT *
FROM nastavnik
WHERE imeNastavnik LIKE 'ana%'
GO

--  dohvati svako ime samo jednom
SELECT 
DISTINCT imeNastavnik
FROM nastavnik
-- WHERE imeNastavnik LIKE 'ana%'
ORDER BY imeNastavnik ASC
GO

USE [Fakultet]
GO
-- Z3.4
-- prvi naèin jedinstvani zapis
SELECT 
 DISTINCT [imeStud]
  FROM [dbo].[stud]
ORDER BY imeStud
GO

-- Z3.4
-- drugi naèin jedinstvani zapis
SELECT 
     [imeStud] 
  FROM [dbo].[stud]
  GROUP BY imeStud
ORDER BY imeStud
GO

-- Z 3.5
-- ispisi maticne br studenata koji sun polozili uispit 146
SELECT 
mbrStud
FROM ispit
WHERE ispit.sifPred=146 AND ocjena > 1
GO

-- Z3.6
-- ime,. prez. nasta. sa placom formula (koef+0,4)*800
SELECT 
imeNastavnik
, prezNastavnik
, (koef+0.4)*800 AS placa
FROM
nastavnik
ORDER BY placa ASC
GO

-- Z3.7
-- ime,. prez. nasta. sa placom formula (koef+0,4)*800
-- placa manji od 3500 ili veæi od 8000
SELECT 
imeNastavnik
, prezNastavnik
, (koef+0.4)*800 AS placa
FROM
nastavnik
WHERE ((koef+0.4)*800 < 3500) OR ((koef+0.4)*800 >8000)  
ORDER BY placa ASC
GO

-- Z3.7  -- KORISTECI BETWEEN
-- ime,. prez. nasta. sa placom formula (koef+0,4)*800
-- placa manji od 3500 ili veæi od 8000
SELECT 
imeNastavnik
, prezNastavnik
, (koef+0.4)*800 AS placa
FROM
nastavnik
WHERE ((koef+0.4)*800) NOT BETWEEN 3500 AND 8000  
ORDER BY placa ASC
GO





