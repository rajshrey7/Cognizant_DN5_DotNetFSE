CREATE OR ALTER PROCEDURE sp_UpdateSalaryWithTransaction
    @EmployeeID INT,
    @NewSalary DECIMAL(10,2)
AS
BEGIN
    BEGIN TRY

        BEGIN TRANSACTION;

        UPDATE Employees
        SET Salary = @NewSalary
        WHERE EmployeeID = @EmployeeID;

        COMMIT TRANSACTION;

        PRINT 'Salary Updated Successfully';

    END TRY

    BEGIN CATCH

        ROLLBACK TRANSACTION;

        PRINT 'Error Occurred';
        PRINT ERROR_MESSAGE();

    END CATCH
END;
GO