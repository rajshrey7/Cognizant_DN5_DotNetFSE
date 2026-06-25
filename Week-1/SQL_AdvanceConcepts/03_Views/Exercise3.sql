DROP VIEW IF EXISTS vw_EmployeeAnnualSalary;
GO
CREATE VIEW vw_EmployeeAnnualSalary
AS
SELECT
    EmployeeID,
    FirstName,
    LastName,
    Salary,
    Salary * 12 AS AnnualSalary
FROM Employees;
GO
SELECT *
FROM vw_EmployeeAnnualSalary;