## Запрос задание 3.

```sql
CREATE TABLE Products (
	Id INT PRIMARY KEY,
	"Name" TEXT NOTNULL
);

INSERT INTO Products
VALUES
	(1, 'Comics'),
	(2, 'Pen'),
	(3, 'Chocolate'),
	(4, 'Flower'),
	(5, 'Apple');

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	"Name" TEXT NOTNULL
);

INSERT INTO Categories
VALUES
	(1, 'Food'),
	(2, 'Book'),
	(3, 'Gift');

CREATE TABLE ProductCategories (
	ProductId INT REFERENCES Products(Id),
	CategoryId INT REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
	(1, 2),
	(1, 3),
	(3, 1),
	(3, 3),
	(4, 3),
	(5, 1);

SELECT P."Name", C."Name"
FROM Products P
LEFT JOIN ProductCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;
```
