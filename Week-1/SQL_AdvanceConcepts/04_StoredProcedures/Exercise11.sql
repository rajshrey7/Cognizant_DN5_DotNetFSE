CREATE OR ALTER PROCEDURE sp_UpdateEmployeeSalaryWithErrorHandling
    @EmployeeID INT,
    @NewSalary DECIMAL(10,2)
AS
BEGIN
    BEGIN TRY

        UPDATE Employees
        SET Salary = @NewSalary
        WHERE EmployeeID = @EmployeeID;

        PRINT 'Salary Updated Successfully';

    END TRY

    BEGIN CATCH

        PRINT 'Custom Error: Unable to update employee salary';

        PRINT ERROR_MESSAGE();

    END CATCH
END;
GO