--Write a SQL query to find all information about all departments (use "TelerikAcademy" database).

SELECT * 
FROM [TelerikAcademy].[dbo].[Departments]


--Write a SQL query to find all department names.

SELECT Name 
FROM [TelerikAcademy].[dbo].[Departments]


--Write a SQL query to find the salary of each employee.

SELECT FirstName, LastName, Salary 
FROM [TelerikAcademy].[dbo].[Employees]


--Write a SQL to find the full name of each employee.

SELECT FirstName + ' ' + LastName AS [Full Name] 
FROM [TelerikAcademy].[dbo].[Employees]


--Write a SQL query to find the email addresses of each employee (by his first and last name). Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". The produced column should be named "Full Email Addresses".

SELECT FirstName + '.'  + LastName + '@telerik.com' AS [Full Email Addresses] 
FROM [TelerikAcademy].[dbo].[Employees]


--Write a SQL query to find all different employee salaries.

SELECT DISTINCT FirstName, LastName, Salary 
FROM [TelerikAcademy].[dbo].[Employees]


--Write a SQL query to find all information about the employees whose job title is “Sales Representative“.

SELECT FirstName, LastName, JobTitle 
FROM [TelerikAcademy].[dbo].[Employees]
WHERE JobTitle = 'Sales Representative'


--Write a SQL query to find the names of all employees whose first name starts with "SA".

SELECT FirstName
FROM [TelerikAcademy].[dbo].[Employees]
WHERE FirstName LIKE 'SA%'


--Write a SQL query to find the names of all employees whose last name contains "ei".

SELECT FirstName, LastName, LastName
FROM [TelerikAcademy].[dbo].[Employees]
WHERE LastName LIKE '%ei%'
--WHERE CHARINDEX('ei', LastName) > 0 - this is a faster version of the solution above


--Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].

SELECT FirstName, LastName, Salary 
FROM [TelerikAcademy].[dbo].[Employees]
WHERE Salary BETWEEN 20000 AND 30000


--Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.

SELECT FirstName, LastName, Salary 
FROM [TelerikAcademy].[dbo].[Employees]
WHERE Salary IN(25000, 14000, 12500, 23600)


--Write a SQL query to find all employees that do not have manager.

SELECT FirstName, LastName, ManagerID 
FROM [TelerikAcademy].[dbo].[Employees]
WHERE ManagerID IS NULL


--Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.

SELECT FirstName, LastName, Salary 
FROM [TelerikAcademy].[dbo].[Employees]
WHERE Salary > 50000
ORDER BY Salary DESC


--Write a SQL query to find the top 5 best paid employees.

SELECT TOP 5 FirstName, LastName, Salary 
FROM [TelerikAcademy].[dbo].[Employees]


--Write a SQL query to find all employees along with their address. Use inner join with ON clause.

SELECT e.FirstName, e.LastName, a.AddressText
FROM [TelerikAcademy].[dbo].[Employees] e 
	INNER JOIN [TelerikAcademy].[dbo].[Addresses] a
		ON e.AddressID = a.AddressID


--Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause).

SELECT e.FirstName, e.LastName, a.AddressText
FROM [TelerikAcademy].[dbo].[Employees] e, [TelerikAcademy].[dbo].[Addresses] a
WHERE e.AddressID = a.AddressID


--Write a SQL query to find all employees along with their manager.

SELECT e.FirstName + ' ' + e.LastName, m.FirstName + ' ' + m.LastName
FROM [TelerikAcademy].[dbo].[Employees] e 
	INNER JOIN [TelerikAcademy].[dbo].[Employees] m
		ON e.ManagerID = m.EmployeeID


--Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: Employees e, Employees m and Addresses a.

SELECT e.FirstName + ' ' + e.LastName AS Employee, m.FirstName + ' ' + m.LastName AS Manager, a.AddressText as [Address]
FROM [TelerikAcademy].[dbo].[Employees] e 
	INNER JOIN [TelerikAcademy].[dbo].[Employees] m
		ON e.EmployeeID = m.ManagerID
	INNER JOIN [TelerikAcademy].[dbo].[Addresses] a
		ON e.AddressID = a.AddressID

		
--Write a SQL query to find all departments and all town names as a single list. Use UNION.

SELECT d.Name
FROM [TelerikAcademy].[dbo].[Departments] d
UNION
SELECT t.Name
FROM [TelerikAcademy].[dbo].[Towns] t


--Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.

SELECT e.FirstName +' ' + e.LastName AS Employee, m.EmployeeID AS ManagerID, m.FirstName + ' ' + m.LastName AS Manager
FROM [TelerikAcademy].[dbo].[Employees] e RIGHT OUTER JOIN [TelerikAcademy].[dbo].[Employees] m
ON e.ManagerID = m.EmployeeID

--
SELECT e.FirstName +' ' + e.LastName AS Employee, m.EmployeeID AS ManagerID, m.FirstName + ' ' + m.LastName AS Manager
FROM [TelerikAcademy].[dbo].[Employees] e LEFT OUTER JOIN [TelerikAcademy].[dbo].[Employees] m
ON e.ManagerID = m.EmployeeID


--Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.

SELECT e.FirstName, e.LastName
FROM [TelerikAcademy].[dbo].[Employees] e 
	INNER JOIN [TelerikAcademy].[dbo].[Departments] d
		ON e.DepartmentID = d.DepartmentID
	WHERE (d.Name = 'Sales' OR d.Name = 'Finance') AND DATEPART(YEAR, e.HireDate) BETWEEN 1995 AND 2005


