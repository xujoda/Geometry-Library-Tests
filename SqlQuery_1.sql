CREATE TABLE Products (
    productId INT PRIMARY KEY,
    productName VARCHAR(100)
);

CREATE TABLE Categories (
    categoryId INT PRIMARY KEY,
    categoryName VARCHAR(100)
);

CREATE TABLE ProductCategory (
    productId INT,
    categoryId INT,
    FOREIGN KEY (productId) REFERENCES Products(productId),
    FOREIGN KEY (categoryId) REFERENCES Categories(categoryId)
);

INSERT INTO Products (productId, productName) VALUES (1, 'product 1');
INSERT INTO Products (productId, productName) VALUES (2, 'product 2');
INSERT INTO Products (productId, productName) VALUES (3, 'product 3');

INSERT INTO Categories (categoryId, categoryName) VALUES (1, 'category 1');
INSERT INTO Categories (categoryId, categoryName) VALUES (2, 'category 2');
INSERT INTO Categories (categoryId, categoryName) VALUES (3, 'category 3');

INSERT INTO ProductCategory (productId, categoryId) VALUES (1, 1);
INSERT INTO ProductCategory (productId, categoryId) VALUES (1, 2);
INSERT INTO ProductCategory (productId, categoryId) VALUES (2, 2);

-- ********************************************************************************** --

SELECT ProductName, C.categoryName
FROM Products
LEFT JOIN ProductCategory PC ON Products.productId = PC.productId 
LEFT JOIN Categories C ON C.categoryId = PC.categoryId;