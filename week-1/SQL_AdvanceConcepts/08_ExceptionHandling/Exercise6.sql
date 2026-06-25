CREATE OR ALTER PROCEDURE AddEmployee
(
    @EmployeeID INT,
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Salary DECIMAL(10,2),
    @DepartmentID INT
)
AS
BEGIN

    IF @Salary < 0
    BEGIN
        RAISERROR
        (
            'Salary cannot be negative.',
            16,
            1
        );
        RETURN;
    END

    IF @Salary < 1000
    BEGIN
        RAISERROR
        (
            'Warning: Salary is below recommended level.',
            10,
            1
        );
    END

    INSERT INTO Employees
    (
        EmployeeID,
        FirstName,
        LastName,
        Salary,
        DepartmentID
    )
    VALUES
    (
        @EmployeeID,
        @FirstName,
        @LastName,
        @Salary,
        @DepartmentID
    );

END;
GO