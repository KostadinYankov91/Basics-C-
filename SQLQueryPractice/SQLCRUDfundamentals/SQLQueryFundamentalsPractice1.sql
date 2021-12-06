USE SoftUni

SELECT * FROM Employees


SELECT [FirstName], [LastName], [Salary] FROM Employees

SELECT [FirstName], [MiddleName], [LastName] FROM Employees

-- C# WAY -- SELECT [FirstName] + '.' + [LastName] + '@' + 'softuni.bg' FROM Employees
SELECT CONCAT ([FirstName], '.', [LastName], '@', 'softuni.bg') 
	AS [Full Email Address] 
	FROM Employees

	CREATE VIEW [V_EmailAddresses] AS (SELECT CONCAT ([FirstName], '.', [LastName], '@', 'softuni.bg') 
	AS [Full Email Address] 
	FROM Employees)

SELECT DISTINCT [Salary] FROM Employees AS [Salary] 

SELECT [FirstName], [LastName], [JobTitle] 
FROM Employees 
WHERE [Salary] BETWEEN 20000 AND 30000

SELECT CONCAT ([FirstName], ' ', [MiddleName], ' ', [LastName])
--CONCAT_WS(' ', [FirstName], [MiddleName], [LastName])
AS [Full Name]
FROM Employees
WHERE [Salary] IN (25000, 14000, 12500, 23600)

SELECT [FirstName], [LastName]
FROM Employees
WHERE [ManagerID] IS NUll

SELECT [FirstName], [LastName], [Salary]
FROM Employees
WHERE [Salary] > 50000
ORDER BY [Salary] DESC

SELECT TOP(5) [FirstName], [LastName] 
FROM Employees
ORDER BY [Salary] DESC

SELECT * FROM Employees
ORDER BY [Salary] DESC, [FirstName] ASC, [LastName] DESC, [MiddleName] ASC

GO

CREATE VIEW [V_EmployeeNameJobTitle] AS (SELECT CONCAT([FirstName], ' ',[MiddleName], ' ', [LastName]) AS [Full Name], 
[JobTitle] AS [Job Title]
FROM Employees)

GO

SELECT DISTINCT [JobTitle] FROM Employees
SELECT * FROM Departments

SELECT * FROM Employees
WHERE DepartmentID IN (1, 2, 4, 11)

UPDATE [Employees]
SET [Salary] += [Salary] * 0.12
WHERE [DepartmentID] IN (1, 2, 4, 11)

SELECT [Salary] FROM [Employees]

