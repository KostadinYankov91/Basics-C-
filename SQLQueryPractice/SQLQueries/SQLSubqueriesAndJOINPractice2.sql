--INNIR JOIN----------------
SELECT * 
FROM Employees AS e
JOIN Departments AS d 
ON e.ManagerID = d.DepartmentID

--LEFT OUTER JOIN-----------
SELECT * 
FROM Employees AS e
LEFT JOIN Employees AS m 
	ON e.ManagerID = m.EmployeeID

--1-----------------
SELECT TOP(50)
e.FirstName,
e.LastName,
t.[Name] AS Town,
a.AddressText
FROM Employees AS e
JOIN Addresses AS a ON e.AddressID = a.AddressID
JOIN Towns AS t ON a.TownID = t.TownID
ORDER BY e.FirstName, e.LastName

--2------------------
SELECT 
e.EmployeeID,
e.FirstName,
e.LastName,
d.[Name] AS DepartmentName
FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID AND d.[Name] = 'Sales'
ORDER BY e.EmployeeID

--3-------------------
SELECT *
FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
WHERE e.HireDate > '1999-01-01' 
--AND (d.[Name] = 'Sales' OR d.[Name] = 'Finance')
AND d.[Name] IN ('Sales', 'Finance')
ORDER BY e.HireDate

--4-------------------
SELECT TOP (50)
e.EmployeeID,
CONCAT_WS(' ', e.FirstName, e.LastName) AS EmployeeName,
CONCAT_WS(' ', m.FirstName, m.LastName) AS ManagerName,
d.[Name] AS DepartmentName
FROM Employees AS e
JOIN Employees AS m ON e.ManagerID = m.EmployeeID
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
ORDER BY e.EmployeeID

--SUBQUERIES
--5------------------
SELECT MIN(s.AvgSalary)
FROM
(SELECT AVG(Salary) AS AvgSalary FROM Employees GROUP BY DepartmentID) AS s


