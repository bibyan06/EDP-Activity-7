 -- Create Database
CREATE DATABASE SirKitsITems;
USE SirKitsITems;

-- Create Tables
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(50),
    Email VARCHAR(100),
    Contact VARCHAR(15)
);

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(50),
    Price DECIMAL(10, 2),
    StockQuantity INT
);

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

CREATE TABLE Admins (
    id INT PRIMARY KEY,
    username VARCHAR(50),
    name VARCHAR(50),
    password VARCHAR (50),
    email VARCHAR (50),
    phonenumber
);

-- Insert Sample Data
INSERT INTO Customers VALUES
(1, 'Sam Smith', 'sam.smith@email.com', '123-456-7890'),
(2, 'Joan Doe', 'joan.doe@email.com', '987-654-3210'),
(3, 'Bob Valenzuela', 'bob.valenzuela@email.com', '555-123-4567'),
(4, 'Alice Wonderland', 'alice.wonderland@email.com', '444-567-8901'),
(5, 'Charlie Cruz', 'charlie.cruz@email.com', '777-890-1234'),
(6, 'Emma Bio', 'emma.bio@email.com', '111-222-3333'),
(7, 'David Noel', 'david.noel@email.com', '666-789-0123'),
(8, 'Sophia Co', 'sophia.co@email.com', '999-345-6789'),
(9, 'James Lee', 'james.lee@email.com', '222-456-7890'),
(10, 'Olivia Davis', 'olivia.davis@email.com', '888-567-1234');

INSERT INTO Products VALUES
(1, 'T-Shirt', 250.00, 100),
(2, 'Hoodie', 600.00, 50),
(3, 'Lanyard', 165.00, 75),
(4, 'Sneakers', 720.00, 30),
(5, 'Backpack', 500.00, 40),
(6, 'Watch', 1000.00, 20),
(7, 'Hat', 150.00, 60),
(8, 'Sunglasses', 70.00, 45),
(9, 'Phone Case', 175.00, 80),
(10, 'Laptop Bag', 360.00, 25);

INSERT INTO Orders VALUES
(1, 1, '2024-02-01'),
(2, 2, '2024-02-02'),
(3, 3, '2024-02-03'),
(4, 4, '2024-02-04'),
(5, 5, '2024-02-05'),
(6, 6, '2024-02-06'),
(7, 7, '2024-02-07'),
(8, 8, '2024-02-08'),
(9, 9, '2024-02-09'),
(10, 10, '2024-02-10');

INSERT INTO OrderDetails VALUES
(1, 1, 1, 2),
(2, 1, 2, 1),
(3, 2, 3, 3),
(4, 2, 4, 1),
(5, 3, 5, 2),
(6, 3, 6, 1),
(7, 4, 7, 4),
(8, 4, 8, 2),
(9, 5, 9, 1),
(10, 5, 10, 3);

INSERT INTO Admins VALUES
(1, 'Alyana', 'Marketing Manager'),
(2, 'Kent', 'Clerk'),
(3, 'Sebiah', 'Salesperson'),
(4, 'Nerlin', 'Accountant'),
(5, 'Maureen', 'Salesperson'),
(6, 'Dio', 'Supervisor'),
(7, 'Ar-jay', 'Assistant'),
(8, 'Cristina', 'HR'),
(9, 'Ganda', 'Creatives'),
(10, 'Rona', 'Sales Manager');

-- Create Views
CREATE VIEW CustomerOrderView AS
SELECT Customers.CustomerID, Customers.CustomerName, Orders.OrderID, Orders.OrderDate
FROM Customers
JOIN Orders ON Customers.CustomerID = Orders.CustomerID;

CREATE VIEW ProductStockView AS
SELECT ProductID, ProductName, StockQuantity
FROM Products
WHERE StockQuantity > 0;

CREATE VIEW HighValueOrders AS
SELECT OrderID, SUM(Price * Quantity) AS TotalValue
FROM OrderDetails
JOIN Products ON OrderDetails.ProductID = Products.ProductID
GROUP BY OrderID
HAVING TotalValue > 100;

-- Create Stored Procedure
DELIMITER //

CREATE PROCEDURE InsertNewOrder(
    IN p_CustomerID INT,
    IN p_ProductID INT,
    IN p_Quantity INT
)
BEGIN
    DECLARE order_id INT;

    -- Insert into Orders
    INSERT INTO Orders (CustomerID, OrderDate) VALUES (p_CustomerID, CURDATE());
    SET order_id = LAST_INSERT_ID();

    -- Insert into OrderDetails
    INSERT INTO OrderDetails (OrderID, ProductID, Quantity) VALUES (order_id, p_ProductID, p_Quantity);
    
    -- Update StockQuantity in Products
    UPDATE Products SET StockQuantity = StockQuantity - p_Quantity WHERE ProductID = p_ProductID;
    
END //

DELIMITER ;

-- Create Stored Function
DELIMITER //

CREATE FUNCTION CalculateTotalOrderValue(p_OrderID INT)
RETURNS DECIMAL(10, 2)
DETERMINISTIC
BEGIN
    DECLARE total_value DECIMAL(10, 2);
    
    SELECT SUM(Price * Quantity)
    INTO total_value
    FROM OrderDetails
    JOIN Products ON OrderDetails.ProductID = Products.ProductID
    WHERE OrderID = p_OrderID;
    
    RETURN total_value;
    
END //

DELIMITER ;

-- Trigger on Insert Event
DELIMITER //
CREATE TRIGGER AfterInsertOrder
AFTER INSERT
ON Orders FOR EACH ROW
BEGIN
    DECLARE product_id INT;
    DECLARE quantity INT;

    -- Fetch product_id and quantity from OrderDetails for the new order
    SELECT ProductID, Quantity INTO product_id, quantity
    FROM OrderDetails
    WHERE OrderID = NEW.OrderID;

    -- Update StockQuantity in Products
    UPDATE Products SET StockQuantity = StockQuantity - quantity WHERE ProductID = product_id;
    
END //
DELIMITER ;

-- Trigger on Update Event
DELIMITER //
CREATE TRIGGER AfterUpdateOrder
AFTER UPDATE
ON OrderDetails FOR EACH ROW
BEGIN
    -- Update StockQuantity in Products when order quantity is changed
    IF OLD.Quantity <> NEW.Quantity THEN
        UPDATE Products SET StockQuantity = StockQuantity + OLD.Quantity - NEW.Quantity
        WHERE ProductID = NEW.ProductID;
    END IF;
    
END //
DELIMITER ;


-- Trigger on Delete Event
DELIMITER //
CREATE TRIGGER AfterDeleteOrder
AFTER DELETE
ON Orders FOR EACH ROW
BEGIN
    DECLARE product_id INT;
    DECLARE quantity INT;

    -- Fetch product_id and quantity from OrderDetails for the deleted order
    SELECT ProductID, Quantity INTO product_id, quantity
    FROM OrderDetails
    WHERE OrderID = OLD.OrderID;

    -- Update StockQuantity in Products
    UPDATE Products SET StockQuantity = StockQuantity + quantity WHERE ProductID = product_id;
    
    -- Delete corresponding records from OrderDetails
    DELETE FROM OrderDetails WHERE OrderID = OLD.OrderID;
    
END //
DELIMITER ;

USE sirkitsitems;
CREATE TABLE useraccounts (
    id INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(255) NOT NULL,
    password VARCHAR(255) NOT NULL
);

-- Insert 10 sample records into the table
INSERT INTO  admins (username, password) VALUES
    ('admin1', 'pass1'),
    ('admin2', 'pass2'),
    ('admin3', 'pass3'),
    ('admin4', 'pass4'),
    ('admin5', 'pass5'),
    ('admin6', 'pass6'),
    ('admin7', 'pass7'),
    ('admin8', 'pass8'),
    ('admin9', 'pass9'),
    ('admin10', 'pass10');
    
ALTER TABLE useraccounts
ADD COLUMN email VARCHAR(255),
ADD COLUMN status VARCHAR(50);

UPDATE useraccounts
SET email = 'alyanamarie@admin.com' WHERE username = 'admin1' LIMIT 1;
UPDATE useraccounts
SET email = 'kentdelapena@admin.com' WHERE username = 'admin2' LIMIT 1;
UPDATE useraccounts
SET email = 'sebiah@admin.com' WHERE username = 'admin3' LIMIT 1;
UPDATE useraccounts
SET email = 'nerlinguevarra@admin.com' WHERE username = 'admin4' LIMIT 1;
UPDATE useraccounts
SET email = 'maureenbenitez@admin.com' WHERE username = 'admin5' LIMIT 1;
UPDATE useraccounts
SET email = 'diogenes@admin.com' WHERE username = 'admin6' LIMIT 1;
UPDATE useraccounts
SET email = 'ar-jay@admin.com' WHERE username = 'admin7' LIMIT 1;
UPDATE useraccounts
SET email = 'cristinaalianza@admin.com' WHERE username = 'admin8' LIMIT 1;
UPDATE useraccounts
SET email = 'gandasomuch@admin.com' WHERE username = 'admin9' LIMIT 1;
UPDATE useraccounts
SET email = 'ronamay@admin.com' WHERE username = 'admin10' LIMIT 1;

ALTER TABLE useraccounts
ADD COLUMN name VARCHAR(255) AFTER username,
ADD COLUMN phonenumber VARCHAR(20) AFTER email;

SET SQL_SAFE_UPDATES = 0;
UPDATE useraccounts
SET name = CASE
    WHEN username = 'admin1' THEN 'Alyana Marie Co'
    WHEN username = 'admin2' THEN 'Kent Dela Pena'
    WHEN username = 'admin3' THEN 'Sebiah Go'
    WHEN username = 'admin4' THEN 'Nerlin Guevarra'  
    WHEN username = 'admin5' THEN 'Maureen Benetiz'
    WHEN username = 'admin6' THEN 'Diogene Smith'
    WHEN username = 'admin7' THEN 'Ar-Jay Forth'
    WHEN username = 'admin8' THEN 'Cristina Alianza'
    WHEN username = 'admin9' THEN 'Ganda Somuch'
    WHEN username = 'admin10' THEN 'Rona May Brown'
    ELSE NULL -- Add default value if needed
END;

SET SQL_SAFE_UPDATES = 1;  -- Optionally, enable safe updates again after the operation

UPDATE useraccounts
SET phonenumber = '09589436745' WHERE username = 'admin1' LIMIT 1;
UPDATE useraccounts
SET phonenumber = '09346678943' WHERE username = 'admin2' LIMIT 1;
UPDATE useraccounts
SET phonenumber = '09874365743' WHERE username = 'admin3' LIMIT 1;
UPDATE useraccounts
SET phonenumber = '09874675375' WHERE username = 'admin4' LIMIT 1;
UPDATE useraccounts
SET phonenumber = '09823546783' WHERE username = 'admin5' LIMIT 1;
UPDATE useraccounts
SET phonenumber = '09678463271' WHERE username = 'admin6' LIMIT 1;
UPDATE useraccounts
SET phonenumber = '09123785647' WHERE username = 'admin7' LIMIT 1;
UPDATE useraccounts
SET phonenumber = '09845787563' WHERE username = 'admin8' LIMIT 1;
UPDATE useraccounts
SET phonenumber = '09347895748' WHERE username = 'admin9' LIMIT 1;
UPDATE useraccounts
SET phonenumber = '0946758392674' WHERE username = 'admin10' LIMIT 1;

ALTER TABLE useraccounts
ADD COLUMN position VARCHAR(255) AFTER phonenumber;

SET SQL_SAFE_UPDATES = 1;  -- Optionally, enable safe updates again after the operation
UPDATE useraccounts
SET position= 'Marketing Manager' WHERE username = 'admin1' LIMIT 1;
UPDATE useraccounts
SET position = 'Clerk' WHERE username = 'admin2' LIMIT 1;
UPDATE useraccounts
SET position = 'Salesperson' WHERE username = 'admin3' LIMIT 1;
UPDATE useraccounts
SET position = 'Accountant' WHERE username = 'admin4' LIMIT 1;
UPDATE useraccounts
SET position = 'Salesperson' WHERE username = 'admin5' LIMIT 1;
UPDATE useraccounts
SET position = 'Supervisor' WHERE username = 'admin6' LIMIT 1;
UPDATE useraccounts
SET position = 'Assistant' WHERE username = 'admin7' LIMIT 1;
UPDATE useraccounts
SET position = 'HR' WHERE username = 'admin8' LIMIT 1;
UPDATE useraccounts
SET position = 'Creatives' WHERE username = 'admin9' LIMIT 1;
UPDATE useraccounts
SET position = 'Sales Manager' WHERE username = 'admin10' LIMIT 1;

RENAME TABLE useraccounts TO admins;

SET SQL_SAFE_UPDATES = 1;  -- Optionally, enable safe updates again after the operation
UPDATE admins
SET status= 'Inactive' WHERE username = 'admin1' LIMIT 1;
UPDATE admins
SET status = 'Inactive' WHERE username = 'admin2' LIMIT 1;
UPDATE admins
SET status = 'Inactive' WHERE username = 'admin3' LIMIT 1;
UPDATE admins
SET status = 'Inactive' WHERE username = 'admin4' LIMIT 1;
UPDATE admins
SET status = 'Inactive' WHERE username = 'admin5' LIMIT 1;
UPDATE admins
SET status = 'Inactive' WHERE username = 'admin6' LIMIT 1;
UPDATE admins
SET status = 'Inactive' WHERE username = 'admin7' LIMIT 1;
UPDATE admins
SET status = 'Inactive' WHERE username = 'admin8' LIMIT 1;
UPDATE admins
SET status = 'Inactive' WHERE username = 'admin9' LIMIT 1;
UPDATE admins
SET status = 'Inactive' WHERE username = 'admin10' LIMIT 1;
UPDATE admins
SET status = 'Inactive' WHERE username = 'admin11' LIMIT 1;

