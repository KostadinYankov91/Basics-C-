CREATE DATABASE CigarShop

USE CigarShop

CREATE TABLE Sizes
(
	Id INT PRIMARY KEY IDENTITY,
	[Length] INT NOT NULL,
	RingRange DECIMAL(2,2),
	CHECK ([Length] BETWEEN 10 AND 25),
	CHECK ([RingRange] BETWEEN 1.5 AND 7.5)
)

CREATE TABLE Tastes
(
	Id INT PRIMARY KEY IDENTITY,
	TasteType VARCHAR(20) NOT NULL,
	TasteStrength VARCHAR(15) NOT NULL,
	ImageURL NVARCHAR(100) NOT NULL
)

CREATE TABLE Brands
(
	Id INT PRIMARY KEY IDENTITY,
	BrandName VARCHAR(30) UNIQUE NOT NULL,
	BrandDescription VARCHAR(MAX)
)

CREATE TABLE Cigars
(
	Id INT PRIMARY KEY IDENTITY,
	CigarName VARCHAR(80) NOT NULL,
	BrandId INT FOREIGN KEY REFERENCES Brands(Id),
	TastId INT FOREIGN KEY REFERENCES Tastes(Id),
	SizeId INT FOREIGN KEY REFERENCES Sizes(Id),
	PriceForSingleCigar DECIMAL(4,2) NOT NULL,
	ImageURL NVARCHAR(100) NOT NULL,
)

CREATE TABLE Addresses
(
	Id INT PRIMARY KEY IDENTITY,
	Town VARCHAR(30) NOT NULL,
	Country NVARCHAR(30) NOT NULL,
	Streat NVARCHAR(100) NOT NULL,
	ZIP VARCHAR(20) NOT NULL
)

CREATE TABLE Clients
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(30) NOT NULL,
	LastName NVARCHAR(30) NOT NULL,
	Email NVARCHAR(50) NOT NULL,
	AddressId INT FOREIGN KEY REFERENCES Addresses(Id) NOT NULL
)

CREATE TABLE ClientsCigars 
(
	ClientId INT FOREIGN KEY REFERENCES Clients(Id),
	CigarId INT FOREIGN KEY REFERENCES Cigars(Id),
	PRIMARY KEY(ClientId, CigarId)
)

--2-----
INSERT INTO Cigars(CigarName, BrandId, TastId, SizeId, PriceForSingleCigar, ImageURL)
VALUES
('COHIBA ROBUSTO', 9, 1, 5, 15.50, 'cohiba-robusto-stick_18.jpg'),
('COHIBA SIGLO I', 9, 1, 10, 410.00, 'cohiba-siglo-i-stick_12.jpg'),
('HOYO DE MONTERREY LE HOYO DU MAIRE', 14, 5, 11, 7.50,'hoyo-du-maire-stick_17.jpg'),
('HOYO DE MONTERREY LE HOYO DE SAN JUAN', 14, 4, 15, 32.00, 'hoyo-de-san-juan-stick_20.jpg'),
('TRINIDAD COLONIALES', 2, 3, 8, 85.21, 'trinidad-coloniales-stick_30.jpg')

INSERT INTO Addresses(Town, Country, Streat, ZIP)
VALUES
('Sofia', 'Bulgaria', '18 Bul. Vasil levski', '1000'),
('Athens', 'Greece', '4342 McDonald Avenue', '10435'),
('Zagreb', 'Croatia', '4333 Lauren Drive', '10000')

--3--------
UPDATE Cigars
SET PriceForSingleCigar = PriceForSingleCigar * 1.20
WHERE TastId = 1

UPDATE Brands
SET BrandDescription = 'New description'
WHERE BrandDescription IS NULL

--4----------
SELECT Id FROM Addresses WHERE Country LIKE 'C%'
DELETE FROM Clients WHERE AddressId IN (7, 8, 10)
DELETE FROM Addresses WHERE Id IN (SELECT Id FROM Addresses WHERE Country LIKE 'C%')
DELETE FROM Addresses WHERE Country LIKE 'C%'

--5----------
SELECT CigarName,
	   PriceForSingleCigar,
	   ImageURL
	   FROM Cigars
ORDER BY PriceForSingleCigar ASC, CigarName DESC

--6---------=
SELECT c.Id,
	   c.CigarName,
	   c.PriceForSingleCigar,
	   t.TasteType,
	   t.TasteStrength
	   FROM Cigars AS c
JOIN Tastes AS t ON c.TastId = t.Id
WHERE t.TasteType IN ('Earthy', 'Woody')
ORDER BY c.PriceForSingleCigar DESC

--7---------
SELECT cl.Id,
	   cl.FirstName + ' ' + cl.LastName AS ClientName,
	   cl.Email
	   FROM Clients AS cl
FULL OUTER JOIN ClientsCigars AS cc ON cl.Id = cc.ClientId
WHERE cc.ClientId IS NULL
ORDER BY ClientName ASC
--8------------
	SELECT TOP(5) 
				c.CigarName,
				c.PriceForSingleCigar,
				c.ImageURL
	FROM Cigars AS c
	RIGHT JOIN Sizes AS s ON c.SizeId = s.Id
	WHERE (s.Length >= 12 AND c.CigarName LIKE '%ci%') OR
	(c.PriceForSingleCigar > 50 AND s.RingRange > 2.55)
	ORDER BY c.CigarName ASC, c.PriceForSingleCigar DESC

	--9-----
SELECT c.FirstName + ' ' + c.LastName AS FullName,
	   a.Country,
	   a.ZIP,
	   CigarPrices.CigarPrice
	   FROM Clients AS c
JOIN Addresses AS a ON c.AddressId = a.Id
FULL OUTER JOIN (SELECT cc.ClientId,
	   MAX(c.PriceForSingleCigar) AS CigarPrice 
FROM ClientsCigars AS cc
JOIN Cigars AS c ON cc.CigarId = c.Id
GROUP BY ClientId) AS CigarPrices ON c.Id = CigarPrices.ClientId
WHERE a.ZIP LIKE '%[^0-9]%'

--10------

SELECT cl.LastName,
	   CEILING(AVG(s.Length)) AS CiagrLength,
	   CEILING(AVG(s.RingRange)) AS CiagrRingRange
	   FROM Cigars AS c
JOIN Sizes AS s ON c.SizeId = s.Id
JOIN ClientsCigars AS cc ON c.Id = cc.CigarId
LEFT JOIN Clients AS cl ON cc.ClientId = cl.Id
GROUP BY cl.LastName
ORDER BY CiagrLength


SELECT
cl.[LastName],
AVG(s.[Length]) AS [CigarLength],
CEILING(AVG(s.[RingRange])) AS [CigarRingRange]
FROM [dbo].[Clients] AS cl
JOIN [dbo].[ClientsCigars] AS cc ON cc.[ClientId] = cl.[Id]
JOIN [dbo].[Cigars] AS cig ON cig.[Id] = cc.[CigarId]
JOIN [dbo].[Sizes] AS s ON s.[Id] = cig.[SizeId]
GROUP BY cl.[LastName]
ORDER BY AVG(s.[Length]) DESC

--11-----------

CREATE FUNCTION udf_ClientWithCigars(@name NVARCHAR(30))
RETURNS INT AS
BEGIN
	RETURN (SELECT COUNT(cc.CigarId) 
	FROM ClientsCigars AS cc
	JOIN Clients AS cl ON cc.ClientId = cl.Id
	WHERE cl.FirstName = @name)
END

SELECT dbo.udf_ClientWithCigars('Betty')

--12-----------

DROP PROCEDURE usp_SearchByTaste

CREATE PROCEDURE usp_SearchByTaste @taste VARCHAR(20)
AS 
BEGIN
	   SELECT c.CigarName,
	   '$' + c.PriceForSingleCigar AS Price,
	   t.TasteType,
	   b.BrandName,
	   s.Length + ' cm' AS CigarLength,
	   s.RingRange + ' cm' AS CigarRingRange
	   FROM Cigars AS c
JOIN Sizes AS s ON c.SizeId = s.Id
JOIN Brands AS b ON c.BrandId = b.Id
JOIN Tastes AS t ON c.TastId = t.Id 
WHERE t.TasteType = @taste
END

EXEC usp_SearchByTaste 'Woody'
	


