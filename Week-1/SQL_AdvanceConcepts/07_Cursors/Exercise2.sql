DECLARE EmployeeCursor CURSOR STATIC
FOR
SELECT EmployeeID, FirstName
FROM Employees;
OPEN EmployeeCursor;
PRINT 'STATIC CURSOR CREATED';
CLOSE EmployeeCursor;
DEALLOCATE EmployeeCursor;
GO



DECLARE EmployeeCursor CURSOR DYNAMIC
FOR
SELECT EmployeeID, FirstName
FROM Employees;
OPEN EmployeeCursor;
PRINT 'DYNAMIC CURSOR CREATED';
CLOSE EmployeeCursor;
DEALLOCATE EmployeeCursor;
GO




DECLARE EmployeeCursor CURSOR FORWARD_ONLY
FOR
SELECT EmployeeID, FirstName
FROM Employees;
OPEN EmployeeCursor;
PRINT 'FORWARD ONLY CURSOR CREATED';
CLOSE EmployeeCursor;
DEALLOCATE EmployeeCursor;
GO


DECLARE EmployeeCursor CURSOR KEYSET
FOR
SELECT EmployeeID, FirstName
FROM Employees;
OPEN EmployeeCursor;
PRINT 'KEYSET CURSOR CREATED';
CLOSE EmployeeCursor;
DEALLOCATE EmployeeCursor;
GO