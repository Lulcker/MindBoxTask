# Практическая часть вопросов MindBox
## Задание №2 в папках AreaLibrary и AreaLibrary.Tests

## Задание №3
```sql
CREATE TABLE Categories(
    Id INT PRIMARY KEY,
	Name NVARCHAR(40)
);

CREATE TABLE Products(
    Id INT PRIMARY KEY,
  Name NVARCHAR(40)
);

CREATE TABLE ProductsCategories(
  ProductId INT FOREIGN KEY REFERENCES Products(Id),
  CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO Categories
VALUES
	(1, 'meat'),
	(2, 'milk products');


INSERT INTO Products
VALUES
	(1, 'pork'),
	(2, 'kefir'),
	(3, 'cheese'),
	(4, 'chicken');

INSERT INTO ProductsCategories
VALUES
	(1, 1),
	(2, 2),
	(3, 2),
	(4, 1);

SELECT P.Name, C.Name
  FROM Products AS P
 INNER JOIN ProductsCategories AS PC
	  ON P.Id = PC.ProductId
 INNER JOIN Categories AS C
	  ON PC.CategoryId = C.Id;
```
