BEGIN TRY

    BEGIN TRANSACTION;

    UPDATE Employees
    SET Salary = Salary + 1000
    WHERE EmployeeID = 1;

    -- Force an error
    DECLARE @A INT = 10;
    DECLARE @B INT = 0;

    SELECT @A / @B;

    COMMIT TRANSACTION;

END TRY

BEGIN CATCH

    ROLLBACK TRANSACTION;

    SELECT
        ERROR_NUMBER() AS ErrorNumber,
        ERROR_MESSAGE() AS ErrorMessage,
        'Transaction Rolled Back' AS Status;

END CATCH;
GO