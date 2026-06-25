CREATE OR ALTER TRIGGER trg_PreventEmployeeDelete
ON Employees
INSTEAD OF DELETE
AS
BEGIN
    RAISERROR(
        'Deletion of employee records is not allowed.',
        16,
        1
    );
END;
GO