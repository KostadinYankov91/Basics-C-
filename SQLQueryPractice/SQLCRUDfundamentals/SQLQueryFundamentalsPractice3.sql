USE [SoftUni]

SELECT * FROM Towns
--1------------------
SELECT [FirstName], [LastName] FROM [Employees]
WHERE LEFT([FirstName], 2) = 'Sa'

SELECT [FirstName], [LastName] FROM [Employees]
WHERE SUBSTRING([FirstName], 1, 2) = 'Sa'
--2------------------
SELECT [FirstName], [LastName] FROM [Employees]
WHERE [LastName] LIKE '%ei%'

SELECT [FirstName], [LastName] FROM [Employees]
WHERE CHARINDEX('ei', [LastName]) <> 0
--3------------------
SELECT [FirstName] FROM [Employees]
WHERE [DepartmentID] IN (3, 10) AND YEAR([HireDate]) BETWEEN 1995 AND 2006

SELECT [FirstName] FROM [Employees]
WHERE [DepartmentID] IN (3, 10) AND DATEPART(YEAR, [HireDate]) BETWEEN 1995 AND 2006

--5------------------
SELECT [Name] FROM [Towns]
WHERE LEN([Name]) IN (5, 6) 
ORDER BY [Name] ASC

--6------------------
SELECT [TownID], [Name] FROM [Towns]
WHERE LEFT([Name], 1) IN ('M', 'K', 'B', 'E')
ORDER BY [Name]

--7------------------
SELECT [TownID], [Name] FROM [Towns]
WHERE LEFT([Name], 1) NOT IN('R', 'B', 'D')
ORDER BY [Name]
--8------------------
CREATE VIEW [V_EmployeesHiredAfter2000] AS (SELECT [FirstName], [LastName] FROM [Employees]
WHERE YEAR([HireDate]) > 2000)

--9------------------
SELECT [FirstName], [LastName] FROM [Employees]
WHERE LEN([LastName]) = 5

--10-----------------
SELECT [EmployeeID], [FirstName], [LastName], [Salary],
DENSE_RANK() OVER(PARTITION BY [Salary] ORDER BY [EmployeeID]) AS [Rank]
FROM Employees
WHERE [Salary] BETWEEN 10000 AND 50000
ORDER BY [Salary] DESC

--11-----------------
SELECT * FROM 
(SELECT [EmployeeID], [FirstName], [LastName], [Salary],
DENSE_RANK() OVER(PARTITION BY [Salary] ORDER BY [EmployeeID]) AS [Rank]
FROM Employees
WHERE [Salary] BETWEEN 10000 AND 50000)
AS [RankingTable]
WHERE [Rank] = 2
ORDER BY [Salary] DESC

--12-----------------
USE [Georgaphy]