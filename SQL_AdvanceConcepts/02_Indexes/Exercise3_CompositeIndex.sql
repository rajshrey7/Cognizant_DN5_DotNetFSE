USE CognizantDN;
GO
SELECT *
FROM Orders
WHERE CustomerID = 1
AND OrderDate = '2023-01-15';
CREATE NONCLUSTERED INDEX IX_Orders_CustomerID_OrderDate
ON Orders(CustomerID, OrderDate);
SELECT *
FROM Orders
WHERE CustomerID = 1
AND OrderDate = '2023-01-15';
EXEC sp_helpindex 'Orders';