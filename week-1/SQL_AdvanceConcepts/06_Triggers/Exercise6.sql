ALTER TABLE Employees
ADD AnnualSalary DECIMAL(10,2);
GO


UPDATE Employees
SET AnnualSalary = Salary * 12;
GO

CREATE OR ALTER TRIGGER trg_UpdateAnnualSalary
ON Employees
AFTER UPDATE
AS
BEGIN

    UPDATE e
    SET e.AnnualSalary = e.Salary * 12
    FROM Employees e
    INNER JOIN inserted i
        ON e.EmployeeID = i.EmployeeID;

END;
GO


UPDATE Employees
SET Salary = 9000
WHERE EmployeeID = 1;
GO