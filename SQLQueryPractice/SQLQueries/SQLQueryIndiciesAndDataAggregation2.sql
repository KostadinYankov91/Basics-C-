--3-----------------
SELECT DepositGroup, MAX(MagicWandSize) AS [LongestWand]
FROM WizzardDeposits
GROUP BY DepositGroup

--4-----------------
SELECT TOP (2) DepositGroup
FROM (SELECT DepositGroup, --MIN(MagicWandSize) AS [ShortestWand]
AVG(MagicWandSize) AS AverageMinWandSize
FROM WizzardDeposits
GROUP BY DepositGroup) AS [DepositGroup]
ORDER BY AverageMinWandSize

--5-----------------
SELECT DepositGroup, SUM(DepositAmount)
FROM WizzardDeposits
GROUP BY DepositGroup

--6-----------------
SELECT DepositGroup, SUM(DepositAmount)
FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup

--7-----------------
SELECT DepositGroup, TotalSum
FROM (SELECT DepositGroup, SUM(DepositAmount) AS TotalSum
FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup) AS DepositGroup
WHERE TotalSum < 150000 
ORDER BY TotalSum DESC

--8-----------------
SELECT DepositGroup, MagicWandCreator, MIN(DepositCharge) AS MinDepositCharge 
FROM WizzardDeposits 
GROUP BY DepositGroup, MagicWandCreator
ORDER BY MagicWandCreator, DepositGroup

--9-----------------
SELECT AgeGroup,
	   COUNT(Id) AS WizzardCount
FROM (SELECT *,  
      CASE
		WHEN Age BETWEEN 0 AND 10 THEN '[0-10]'
		WHEN Age BETWEEN 11 AND 20 THEN '[11-20]'
		WHEN Age BETWEEN 21 AND 30 THEN '[21-30]'
		WHEN Age BETWEEN 31 AND 40 THEN '[31-40]'
		WHEN Age BETWEEN 41 AND 50 THEN '[41-50]'
		WHEN Age BETWEEN 51 AND 60 THEN '[51-60]'
		ELSE '[61+]'
		END AS AgeGroup FROM WizzardDeposits) AS AgeGroup
GROUP BY AgeGroup

--9, Var 2-------------
SELECT  
      CASE
		WHEN Age BETWEEN 0 AND 10 THEN '[0-10]'
		WHEN Age BETWEEN 11 AND 20 THEN '[11-20]'
		WHEN Age BETWEEN 21 AND 30 THEN '[21-30]'
		WHEN Age BETWEEN 31 AND 40 THEN '[31-40]'
		WHEN Age BETWEEN 41 AND 50 THEN '[41-50]'
		WHEN Age BETWEEN 51 AND 60 THEN '[51-60]'
		ELSE '[61+]'
		END AS AgeGroup,
		COUNT(Id) AS WizzardCount
		FROM WizzardDeposits
GROUP BY (CASE
		WHEN Age BETWEEN 0 AND 10 THEN '[0-10]'
		WHEN Age BETWEEN 11 AND 20 THEN '[11-20]'
		WHEN Age BETWEEN 21 AND 30 THEN '[21-30]'
		WHEN Age BETWEEN 31 AND 40 THEN '[31-40]'
		WHEN Age BETWEEN 41 AND 50 THEN '[41-50]'
		WHEN Age BETWEEN 51 AND 60 THEN '[51-60]'
		ELSE '[61+]'
		END)

--10-----------------
 