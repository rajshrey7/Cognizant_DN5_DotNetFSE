CREATE OR ALTER PROCEDURE sp_GetEmployeeByDynamicFilter
    @FilterColumn VARCHAR(50),
    @FilterValue VARCHAR(100)
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX);

    SET @SQL =
    'SELECT *
     FROM Employees
     WHERE ' + QUOTENAME(@FilterColumn) +
     ' = ''' + @FilterValue + '''';

    EXEC sp_executesql @SQL;
END;
GO