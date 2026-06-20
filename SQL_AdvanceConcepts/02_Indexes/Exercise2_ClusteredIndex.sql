USE CognizantDN;
GO
SELECT *
FROM Orders
WHERE OrderDate = '2023-01-15';
EXEC sp_helpindex 'Orders';
SELECT *
FROM Orders
WHERE OrderDate = '2023-01-15';