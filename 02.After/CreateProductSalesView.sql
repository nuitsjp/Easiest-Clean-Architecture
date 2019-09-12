CREATE VIEW ProductSales
AS
SELECT
	Product.ProductID,
	Product.Name,
	SUM(LineTotal) AS Sales
FROM
	Production.Product
	INNER JOIN Sales.SalesOrderDetail
		ON	Product.ProductID = SalesOrderDetail.ProductID
GROUP BY
	Product.ProductID, Product.Name
