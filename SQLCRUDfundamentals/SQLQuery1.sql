/****** Script for SelectTopNRows command from SSMS  ******/
SELECT(1000) [EmployeeID]
      ,[FirstName]
      ,[LastName]
      ,[MiddleName]
      ,[JobTitle]
	  ,d.[Name] AS DepartmentName
      
  FROM [SoftUni].[dbo].[Employees] AS e
  JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
  WHERE e.ManagerID = 16
