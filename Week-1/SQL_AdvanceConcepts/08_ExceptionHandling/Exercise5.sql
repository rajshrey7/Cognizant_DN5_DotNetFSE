BEGIN TRY

    BEGIN TRANSACTION;

    INSERT INTO Employees
    (
        EmployeeID,
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    )
    VALUES
    (10,'Test1','User',1,5000,'2025-01-01');

    -- Duplicate EmployeeID to force error
    INSERT INTO Employees
    (
        EmployeeID,
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    )
    VALUES
    (10,'Test2','User',1,5000,'2025-01-01');

    COMMIT TRANSACTION;

END TRY

BEGIN CATCH

    ROLLBACK TRANSACTION;

    INSERT INTO AuditLog
    (
        Action,
        ErrorMessage
    )
    VALUES
    (
        'Batch Insert',
        ERROR_MESSAGE()
    );

    SELECT
        ERROR_MESSAGE() AS ErrorMessage,
        'Transaction Rolled Back' AS Status;

END CATCH;
GO