USE [SoftUni]

--1-----------------

SELECT TOP (50)
			e.FirstName,
			e.LastName,
			t.[Name] AS [Town],
			a.AddressText			
FROM Employees AS e
LEFT JOIN Addresses AS a
ON a.AddressID = e.AddressID
LEFT JOIN Towns as t
ON t.TownID = a.TownID
ORDER BY e.FirstName, LastName ASC

--2-----------------
SELECT TOP (5) e.EmployeeID,
	   e.JobTitle,
	   e.[AddressID],
	   a.[AddressText]
FROM [Employees] AS e
LEFT JOIN [Addresses] AS a
ON e.[AddressID] = a.[AddressID]
ORDER BY e.[AddressID]

--3-----------------

SELECT e.EmployeeID,
	   e.FirstName,
	   e.LastName,
	   d.[Name] AS [DepartmentName]
FROM Employees AS e
LEFT JOIN Departments AS d
ON d.DepartmentID = e.DepartmentID
WHERE d.[Name] = 'Sales'

--4-----------------

SELECT TOP (5) e.EmployeeID,
       e.FirstName,
	   e.Salary,
	   d.[Name] AS [DepartmentName]
FROM Employees AS e
JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
WHERE e.Salary > 15000
ORDER BY d.DepartmentID ASC


--5-----------------
SELECT TOP (3) e.[EmployeeID],
	   e.[FirstName]
FROM [Employees] AS e
LEFT JOIN [EmployeesProjects] AS ep
ON e.[EmployeeID] = ep.[EmployeeID]
WHERE ep.[ProjectID] IS NULL
ORDER BY e.[EmployeeID]

--6--------------------

SELECT e.FirstName,
       e.LastName,
	   e.HireDate,
	   d.[Name] AS [DeptName]
FROM Employees AS e
LEFT JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
WHERE d.[Name] IN ('Sales', 'Finance') AND e.HireDate > '1-1-1999'
ORDER BY e.HireDate ASC

--7--------------------

SELECT TOP (5) e.[EmployeeID],
			   e.[FirstName],
			   p.[Name] AS [ProjectName]
FROM [Employees] AS e
INNER JOIN [EmployeesProjects] AS ep
ON e.[EmployeeID] = ep.[EmployeeID]
INNER JOIN [Projects] AS p
ON ep.[ProjectID] = p.ProjectID
WHERE p.StartDate > '08-13-2002' AND p.[EndDate] IS NULL
ORDER BY e.[EmployeeID]

--8-------------------

SELECT e.EmployeeID,
	   e.FirstName,
	   CASE
			WHEN YEAR(p.StartDate) >= 2005 THEN NULL
			ELSE p.[Name]
			END AS ProjectName
FROM [Employees] AS e
LEFT JOIN EmployeesProjects AS ep
ON e.EmployeeID = ep.EmployeeID
INNER JOIN Projects AS p
ON ep.ProjectID = p.ProjectID
WHERE e.EmployeeID = 24



--9-------------------

USE [SoftUni]

SELECT  
	   e.EmployeeID,
	   e.FirstName,
	   e.ManagerID,	
	   m.FirstName AS [ManagerName]
	   FROM Employees AS e
	   INNER JOIN Employees AS m
	   ON e.ManagerID = m.EmployeeID
	   WHERE m.EmployeeID IN (3, 7)
	   ORDER BY e.EmployeeID

--10------------------

SELECT TOP (50) e.EmployeeID,
			    e.FirstName + ' ' + e.LastName AS [EmployeeName],
				m.FirstName + ' ' + m.LastName AS [ManagerName],
				d.[Name] AS [DepartmentName]
				FROM Employees AS e
				INNER JOIN Employees AS m
				ON e.ManagerID = m.EmployeeID
				
INNER JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
ORDER BY e.EmployeeID

--11------------------

SELECT MIN(e.Salary) 
FROM 
(SELECT d.DepartmentID, e.Salary
FROM Employees AS e
INNER JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.DepartmentID, e.Salary)

--11-------------------

 SELECT min([avg]) AS [MinAverageSalary]
FROM (
       SELECT avg(Salary) AS [avg]
       FROM Employees
       GROUP BY DepartmentID
     ) AS AverageSalary


USE [Geography]

--12------------------

SELECT 
c.CountryCode,
m.MountainRange,
p.PeakName,
p.Elevation
FROM [Peaks] AS p
LEFT JOIN [Mountains] AS m
ON p.MountainId = m.Id
LEFT JOIN MountainsCountries AS mc
ON m.Id = mc.MountainId
INNER JOIN Countries AS c
ON mc.CountryCode = c.CountryCode
WHERE c.CountryName = 'Bulgaria' AND p.Elevation > 2835
ORDER BY p.Elevation DESC

--13------------------

SELECT c.CountryCode,
COUNT(mc.MountainId) AS [MointainRanges]
FROM Countries AS c
LEFT JOIN MountainsCountries as mc
ON c.CountryCode = mc.CountryCode
WHERE c.CountryCode IN ('BG', 'RU', 'US')
GROUP BY c.CountryCode
--14------------------

SELECT TOP (5) c.CountryName,
			   r.RiverName
FROM Countries AS c
LEFT JOIN CountriesRivers AS cr
ON c.CountryCode = cr.CountryCode
LEFT JOIN Rivers AS r
ON cr.RiverId = r.Id
WHERE c.ContinentCode = 'AF'
ORDER BY CountryName ASC

--15------------------
SELECT ContinentCode,
	   CurrencyCode,
	   CurrencyCount AS CurrencyUsage
FROM (SELECT *,
DENSE_RANK() OVER(PARTITION BY ContinentCode 
				  ORDER BY CurrencyCount DESC) 
				  AS [CurrencyRank]
				  FROM (
SELECT ContinentCode, CurrencyCode,
COUNT(CurrencyCode) AS [CurrencyCount]
FROM Countries
GROUP BY ContinentCode, CurrencyCode
) AS [CurrencyCodeSubQuery]
WHERE CurrencyCount > 1) AS [CurrencyRankingSubQuery]
WHERE CurrencyRank = 1
ORDER BY ContinentCode

--15.5-----------------

SELECT COUNT(c.CountryCode) AS [Count]
FROM Countries AS c
LEFT JOIN MountainsCountries AS mc
ON c.CountryCode = mc.CountryCode
WHERE mc.MountainId IS NULL

--16-------------------
SELECT TOP (5) c.CountryName,
	   MAX(p.Elevation) AS [HighestPeakElevation],
	   MAX(r.[Length]) AS [LongestRiverLength]
FROM Countries AS c
LEFT JOIN MountainsCountries AS mc
ON c.CountryCode = mc.CountryCode
LEFT JOIN Mountains AS m
ON mc.MountainId = m.Id
LEFT JOIN Peaks AS p
ON m.Id = p.MountainId
LEFT JOIN CountriesRivers AS cr
ON c.CountryCode = cr.CountryCode
LEFT JOIN Rivers AS r
ON cr.RiverId = r.Id
GROUP BY c.CountryName
ORDER BY HighestPeakElevation DESC,
LongestRiverLength DESC, 
CountryName

--17----------------------
SELECT TOP (5) CountryName AS [Country],
       ISNULL(PeakName, '(no highest peak)') AS [Highest Peak Name],
	   ISNULL(Elevation, 0) AS [Highest Peak Elevation],
	   ISNULL(MountainRange, '(no mountain)') AS [Mountain]
FROM (SELECT c.CountryName,
	   p.PeakName,
	   p.Elevation,
	   m.MountainRange,
	   DENSE_RANK() OVER(PARTITION BY c.CountryName ORDER BY p.Elevation DESC) AS [PeakRank]
FROM Countries AS c
LEFT JOIN MountainsCountries AS mc
ON c.CountryCode = mc.CountryCode
LEFT JOIN Mountains AS m
ON mc.MountainId = m.Id
LEFT JOIN Peaks AS p
ON m.Id = p.MountainId
) AS [PeaksRankingSubQuery]
WHERE PeakRank = 1
ORDER BY Country, [Highest Peak Name]
