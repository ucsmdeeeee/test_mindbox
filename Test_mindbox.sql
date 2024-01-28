CREATE DATABASE Test_Mindbox

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName NVARCHAR(50)
);

INSERT INTO Products (ProductID, ProductName)
VALUES 
    (1, 'Продукт 1'),
    (2, 'Продукт 2'),
    (3, 'Продукт 3'),
    (4, 'Продукт 4');

CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName NVARCHAR(50)
);

INSERT INTO Categories (CategoryID, CategoryName)
VALUES 
    (1, 'Категория 1'),
    (2, 'Категория 2'),
    (3, 'Категория 3'),
    (4, 'Категория 4');

CREATE TABLE ProductCategories (
    ProductID INT,
    CategoryID INT NULL,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

INSERT INTO ProductCategories (ProductID, CategoryID)
VALUES 
    (1, 1),
    (1, 2),
    (2, NULL),
    (3, 3),
    (4, 1),
	(4, NULL),
    (4, 3),
    (4, 4);

SELECT 
    p.ProductName,
    ISNULL(c.CategoryName, 'Без категории') AS CategoryName
FROM 
    Products p
LEFT JOIN 
    ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN 
    Categories c ON pc.CategoryID = c.CategoryID
