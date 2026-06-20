DROP PROCEDURE IF EXISTS sp_GetEmployeesByDepartment;
GO
SELECT name
FROM sys.procedures
WHERE name = 'sp_GetEmployeesByDepartment';