DROP VIEW IF EXISTS vw_EmployeeFullName;
GO

CREATE VIEW vw_EmployeeFullName
AS
SELECT
    EmployeeID,
    FirstName,
    LastName,
    FirstName + ' ' + LastName AS FullName
FROM Employees;
GO

SELECT *
FROM vw_EmployeeFullName;