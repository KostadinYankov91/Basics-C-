SELECT AVG(dt.Salaries) FROM
(SELECT e.DepartmentID, SUM(Salary) AS Salaries
FROM Employees AS e
GROUP BY e.DepartmentID) AS dt

SELECT DepartmentID, SUM(Salary) AS Salaries,
STRING_AGG(CONCAT_WS(' ', FirstName, LastName), ', ') AS [Names]
FROM Employees
GROUP BY DepartmentID

SELECT DepartmentID, COUNT(EmployeeID) AS [Employees]
FROM Employees
--WHERE (EmployeeID) > 10
GROUP BY DepartmentID
HAVING COUNT(EmployeeID) >= 10