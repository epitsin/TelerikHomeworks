USE TelerikAcademy
GO

--1. Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company. 
--	Use a nested SELECT statement.

SELECT FirstName + ' ' + LastName AS FullName, Salary
FROM Employees
WHERE Salary =
	(SELECT MIN(Salary) FROM Employees)
GO

--2. Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher 
--	than the minimal salary for the company.

SELECT FirstName + ' ' + LastName AS FullName, Salary
FROM Employees
WHERE Salary <= 1.1 *
	(SELECT MIN(Salary) FROM Employees)
	ORDER BY Salary
GO
	
--3. Write a SQL query to find the full name, salary and department of the employees that take the minimal salary 
--	in their department. Use a nested SELECT statement.

SELECT FirstName + ' ' + LastName AS FullName, Salary, DepartmentID
FROM Employees e
WHERE Salary =
	(SELECT MIN(Salary) FROM Employees
		WHERE DepartmentID = e.DepartmentID)
GO
	
--4. Write a SQL query to find the average salary in the department #1.

SELECT AVG(Salary) AS AverageSalary
FROM Employees
WHERE DepartmentID = 1
GO

--5. Write a SQL query to find the average salary  in the "Sales" department.

SELECT AVG(Salary) AS AverageSalary
FROM Employees
WHERE DepartmentID = 
	(SELECT DepartmentID FROM Departments
		WHERE Name = 'Sales')
GO

--6. Write a SQL query to find the number of employees in the "Sales" department.

SELECT COUNT(EmployeeID) AS NumberOfEmployees
FROM Employees
WHERE DepartmentID = 
	(SELECT DepartmentID FROM Departments
		WHERE Name = 'Sales')
GO

--7. Write a SQL query to find the number of all employees that have manager.

SELECT COUNT(ManagerID)
FROM Employees
GO

--8. Write a SQL query to find the number of all employees that have no manager.

SELECT COUNT(EmployeeID)
FROM Employees
WHERE ManagerID IS NULL
GO

--9. Write a SQL query to find all departments and the average salary for each of them.

SELECT d.Name AS Department, AVG(e.Salary) AS AverageSalary 
FROM Employees e
	INNER JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name
GO

--10. Write a SQL query to find the count of all employees in each department and for each town.

SELECT d.Name AS Department, t.Name AS Town, COUNT(e.EmployeeID) AS NumberOfEmployees
FROM Employees e
	INNER JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
	INNER JOIN Addresses a
		ON e.AddressID = a.AddressID
	INNER JOIN Towns t
		ON a.TownID = t.TownID
GROUP BY d.Name, t.Name
GO

--11. Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.

SELECT e.FirstName + ' ' + e.LastName AS FullName, COUNT(e.EmployeeID) AS NumberOfEmployees
FROM Employees e
	INNER JOIN Employees m
		ON e.EmployeeID = m.ManagerID
GROUP BY e.EmployeeID, e.FirstName, e.LastName
HAVING COUNT(e.EmployeeID) = 5
GO

--12. Write a SQL query to find all employees along with their managers. 
--	For employees that do not have manager display the value "(no manager)".

SELECT e.FirstName + ' ' + e.LastName AS Employee, ISNULL(m.FirstName + ' ' + m.LastName, 'No manager') AS Manager
FROM Employees e
	LEFT JOIN Employees m
		ON e.ManagerID = m.EmployeeID
GO

--13. Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. 
--	Use the built-in LEN(str) function.

SELECT FirstName + ' ' + LastName AS FullName
FROM Employees
WHERE LEN(LastName) = 5
GO

--14. Write a SQL query to display the current date and time in the following format 
--	"day.month.year hour:minutes:seconds:milliseconds". 
--	Search in  Google to find how to format dates in SQL Server.

SELECT FORMAT(GETDATE(), 'dd.MM.yyyy HH:mm:ss:fff');
GO

--15. Write a SQL statement to create a table Users. Users should have username, password, 
--	full name and last login time. Choose appropriate data types for the table fields. 
--	Define a primary key column with a primary key constraint. Define the primary key column as 
--	identity to facilitate inserting records. Define unique constraint to avoid repeating usernames. 
--	Define a check constraint to ensure the password is at least 5 characters long.

CREATE TABLE Users (
    UserId Int IDENTITY,
    Username nvarchar(50),
    [Password] nvarchar(256) CHECK (LEN(Password) >= 5),
    FullName nvarchar(50),
    LastLogin DATETIME,
    CONSTRAINT PK_Users PRIMARY KEY(UserId),
    CONSTRAINT UQ_Username UNIQUE(Username),
) 
GO

--16. Write a SQL statement to create a view that displays the users from the Users table 
--	that have been in the system today. Test if the view works correctly.

CREATE VIEW [Users logged in today] AS
SELECT * FROM Users
WHERE DATEDIFF(day, LastLogin, GETDATE()) = 0
GO

--17. Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint). 
--	Define primary key and identity column.

CREATE TABLE Groups(
	GroupID int IDENTITY,
	Name nvarchar(50) NOT NULL,
	CONSTRAINT PK_Groups PRIMARY KEY(GroupID),
	CONSTRAINT UQ_Name UNIQUE(Name)
)
GO

--18. Write a SQL statement to add a column GroupID to the table Users. 
--	Fill some data in this new column and as well in the Groups table. 
--	Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.

ALTER TABLE Users 
ADD GroupID int
	CONSTRAINT FK_Users_Groups
		FOREIGN KEY (GroupID)
		REFERENCES Groups(GroupID)
GO

--19. Write SQL statements to insert several records in the Users and Groups tables.

INSERT INTO Groups VALUES
 ('Group1'),
 ('Group2'),
 ('Group3')
GO

INSERT INTO Users VALUES
 ('peshko', 'secretPassword1234', 'Pesho Peshov', '2014-4-04 00:00:00', 1),
 ('goshko', 'secretPassword1234', 'Gosho Goshov', '2014-1-01 00:00:00', 2),
 ('toshko', 'secretPassword1234', 'Toshko Toshkov', '2014-2-02 00:00:00', 3)
GO

--20. Write SQL statements to update some of the records in the Users and Groups tables.

UPDATE Users
SET Username = REPLACE(Username, 'peshko', 'KRASAVECA')
GO

--21. Write SQL statements to delete some of the records from the Users and Groups tables.

DELETE FROM Users
WHERE GroupID = 3
GO

DELETE FROM Groups
WHERE GroupID = 3
GO

--22. Write SQL statements to insert in the Users table the names of all employees from the Employees table. 
--	Combine the first and last names as a full name. For username use the first letter of the 
--	first name + the last name (in lowercase). Use the same for the password, and NULL for last login time.

INSERT INTO Users (Username, [Password], FullName)
        (SELECT LOWER(CONCAT(LEFT(e.FirstName, 1), e.LastName)),
                LOWER(CONCAT(LEFT(e.FirstName, 1), e.LastName)),
                CONCAT(e.FirstName, ' ', e.LastName)
        FROM Employees e
  WHERE LEN(e.LastName) >= 4)
GO

--23. Write a SQL statement that changes the password to NULL for all users 
--	that have not been in the system since 10.03.2010.

UPDATE Users
SET Password = NULL
WHERE DATEDIFF(day, LastLogin, '2010-3-10') > 0
GO

--24. Write a SQL statement that deletes all users without passwords (NULL password).

DELETE FROM Users
WHERE [Password] IS NULL
GO

--25. Write a SQL query to display the average employee salary by department and job title.

SELECT d.Name AS Department, e.JobTitle, AVG(e.Salary) AS AverageSalary 
FROM Employees e
	INNER JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle
GO

--26. Write a SQL query to display the minimal employee salary by department and job title along 
--	with the name of some of the employees that take it.

SELECT d.Name AS Department, e.JobTitle, MIN(e.Salary) AS AverageSalary, e.FirstName + ' ' + e.LastName AS Employee
FROM Employees e
	INNER JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle, e.FirstName, e.LastName
GO

--27. Write a SQL query to display the town where maximal number of employees work.

SELECT TOP 1 t.Name, COUNT(e.EmployeeID) AS EmployeesCount
FROM Employees e
	INNER JOIN Addresses a
		ON e.AddressID = a.AddressID
	INNER JOIN Towns t
		ON t.TownID = a.TownID
GROUP BY t.Name
ORDER BY EmployeesCount DESC
GO

--28. Write a SQL query to display the number of managers from each town.

SELECT t.Name, COUNT(e.ManagerID) AS ManagersCount
FROM Employees e
	INNER JOIN Addresses a
		ON e.AddressID = a.AddressID
	INNER JOIN Towns t
		ON t.TownID = a.TownID
GROUP BY t.Name
GO

--29. Write a SQL to create table WorkHours to store work reports for each employee 
--	(employee id, date, task, hours, comments). Don't forget to define  identity, 
--	primary key and appropriate foreign key. 
--	Issue few SQL statements to insert, update and delete of some data in the table.
--	Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers. 
--	For each change keep the old record data, the new record data and the command (insert / update / delete).


CREATE TABLE WorkHours (
    WorkHoursId int IDENTITY,
    EmployeeId Int NOT NULL,
    [Date] DATETIME NOT NULL,
    Task nvarchar(256) NOT NULL,
    [Hours] Int NOT NULL,
    Comments nvarchar(256),
    CONSTRAINT PK_Id PRIMARY KEY(WorkHoursId),
    CONSTRAINT FK_Employees_WorkHours 
        FOREIGN KEY (EmployeeId)
        REFERENCES Employees(EmployeeId)
) 
GO

INSERT INTO WorkHours(EmployeeId, [Date], Task, [Hours])
	VALUES (1, GETDATE(), 'Task1', 1)

UPDATE WorkHours
SET Comments = 'Shitty chickin'
WHERE [Hours] = 1

DELETE FROM WorkHours
WHERE EmployeeId = 1

CREATE TABLE WorkHoursLogs (
    WorkLogId int,
    EmployeeId Int NOT NULL,
    OnDate DATETIME NOT NULL,
    Task nvarchar(256) NOT NULL,
    Hours Int NOT NULL,
    Comments nvarchar(256),
    [Action] nvarchar(50) NOT NULL,
    CONSTRAINT FK_Employees_WorkHoursLogs
        FOREIGN KEY (EmployeeId)
        REFERENCES Employees(EmployeeId),
    CONSTRAINT [CC_WorkReportsLogs] CHECK ([Action] IN ('Insert', 'Delete', 'DeleteUpdate', 'InsertUpdate'))
) 
GO

CREATE TRIGGER tr_InsertWorkReports ON WorkHours FOR INSERT
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT WorkHoursId, EmployeeID, [Date], Task, [Hours], Comments, 'Insert'
    FROM inserted
GO

CREATE TRIGGER tr_DeleteWorkReports ON WorkHours FOR DELETE
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT WorkHoursId, EmployeeID, [Date], Task, [Hours], Comments, 'Delete'
    FROM deleted
GO

CREATE TRIGGER tr_UpdateWorkReports ON WorkHours FOR UPDATE
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT WorkHoursId, EmployeeID, [Date], Task, [Hours], Comments, 'InsertUpdate'
    FROM inserted

INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT WorkHoursId, EmployeeID, [Date], Task, [Hours], Comments, 'DeleteUpdate'
    FROM deleted
GO

--30. Start a database transaction, delete all employees from the 'Sales' department along with 
--	all dependent records from the pother tables. At the end rollback the transaction.

BEGIN TRAN

ALTER TABLE Departments
DROP CONSTRAINT FK_Departments_Employees
GO

DELETE e FROM Employees e
JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

--31. Start a database transaction and drop the table EmployeesProjects. 
--	Now how you could restore back the lost table data?

BEGIN TRANSACTION

DROP TABLE EmployeesProjects

--32. Find how to use temporary tables in SQL Server. 
--	Using temporary tables backup all records from EmployeesProjects and restore them back 
--	after dropping and re-creating the table.


BEGIN TRANSACTION

SELECT * 
INTO #TempEmployeesProjects
FROM EmployeesProjects

DROP TABLE EmployeesProjects

SELECT * 
INTO EmployeesProjects
FROM #TempEmployeesProjects;

DROP TABLE #TempEmployeesProjects