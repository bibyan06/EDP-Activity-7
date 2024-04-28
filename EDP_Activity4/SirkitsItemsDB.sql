-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: sirkitsitems
-- ------------------------------------------------------
-- Server version	8.0.36

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `admins`
--

DROP TABLE IF EXISTS `admins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `admins` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `password` varchar(255) NOT NULL,
  `email` varchar(255) DEFAULT NULL,
  `phonenumber` varchar(20) DEFAULT NULL,
  `position` varchar(255) DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `admins`
--

LOCK TABLES `admins` WRITE;
/*!40000 ALTER TABLE `admins` DISABLE KEYS */;
INSERT INTO `admins` VALUES (1,'admin1','Alyana Marie Co','pass1','alyanamarie@admin.com','09589436745','Marketing Manager','Active'),(2,'admin2','Kent Dela Pena','pass2','kentdelapena@admin.com','09346678943','Clerk','Inactive'),(3,'admin3','Sebiah Go','pass3','sebiah@admin.com','09874365743','Salesperson','Inactive'),(4,'admin4','Nerlin Guevarra','pass4','nerlinguevarra@admin.com','09874675375','Accountant','Inactive'),(5,'admin5','Maureen Benetiz','pass5','maureenbenitez@admin.com','09823546783','Salesperson','Inactive'),(6,'admin6','Diogene Smith','pass6','diogenes@admin.com','09678463271','Supervisor','Inactive'),(7,'admin7','Ar-Jay Forth','pass7','ar-jay@admin.com','09123785647','Assistant','Inactive'),(8,'admin8','Cristina Alianza','pass8','cristinaalianza@admin.com','09845787563','HR','Inactive'),(9,'admin9','Ganda Somuch','pass9','gandasomuch@admin.com','09347895748','Creatives','Inactive'),(10,'admin10','Rona May Brown','pass10','ronamay@admin.com','0946758392674','Sales Manager','Inactive');
/*!40000 ALTER TABLE `admins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `customerorderview`
--

DROP TABLE IF EXISTS `customerorderview`;
/*!50001 DROP VIEW IF EXISTS `customerorderview`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `customerorderview` AS SELECT 
 1 AS `CustomerID`,
 1 AS `CustomerName`,
 1 AS `OrderID`,
 1 AS `OrderDate`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customers` (
  `CustomerID` int NOT NULL,
  `CustomerName` varchar(50) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Contact` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`CustomerID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES (1,'Sam Smith','sam.smith@email.com','123-456-7890'),(2,'Joan Doe','joan.doe@email.com','987-654-3210'),(3,'Bob Valenzuela','bob.valenzuela@email.com','555-123-4567'),(4,'Alice Wonderland','alice.wonderland@email.com','444-567-8901'),(5,'Charlie Cruz','charlie.cruz@email.com','777-890-1234'),(6,'Emma Bio','emma.bio@email.com','111-222-3333'),(7,'David Noel','david.noel@email.com','666-789-0123'),(8,'Sophia Co','sophia.co@email.com','999-345-6789'),(9,'James Lee','james.lee@email.com','222-456-7890'),(10,'Olivia Davis','olivia.davis@email.com','888-567-1234'),(11,'Neck Binsent','neck.binsent@email.com','123-456-7890'),(12,'Erica Obias','erica.obias@email.com','987-654-3210'),(13,'Michael Johnson','michael.johnson@email.com','555-123-4567'),(14,'Emily Buendia','emily.buendia@email.com','444-567-8901'),(15,'Daniel Padilla','daniel.padilla@email.com','777-890-1234'),(16,'Sarah Lhabati','sarah.lhabati@email.com','111-222-3333'),(17,'Christopher Davis','christopher.davis@email.com','666-789-0123'),(18,'Jessica Soho','jessica.soho@email.com','999-345-6789'),(19,'Matthew Ford','matthew.ford@email.com','222-456-7890'),(20,'Lauren Naveza','lauren.naveza@email.com','888-567-1234'),(21,'Ryan Domingquez','ryan.domingquez@email.com','555-789-0123'),(22,'Ashley Garcia','ashley.garcia@email.com','333-123-4567'),(23,'Justin Thompson','justin.thompson@email.com','777-234-5678'),(24,'Hannah Martinez','hannah.martinez@email.com','111-345-6789'),(25,'Brandon Lee','brandon.lee@email.com','999-456-7890'),(26,'Amanda Mendez','amanda.mendez@email.com','444-567-8901'),(27,'Rachel Flores','rachel.flores@email.com','666-678-9012'),(28,'Kevin Torres','kevin.torres@email.com','888-789-0123'),(29,'Samantha Dela Cruz','samantha.dela cruz@email.com','222-890-1234'),(30,'Tyler Ramirez','tyler.ramirez@email.com','555-901-2345');
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `highvalueorders`
--

DROP TABLE IF EXISTS `highvalueorders`;
/*!50001 DROP VIEW IF EXISTS `highvalueorders`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `highvalueorders` AS SELECT 
 1 AS `OrderID`,
 1 AS `TotalValue`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `orderdetails`
--

DROP TABLE IF EXISTS `orderdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orderdetails` (
  `OrderDetailID` int NOT NULL,
  `OrderID` int DEFAULT NULL,
  `ProductID` int DEFAULT NULL,
  `Quantity` int DEFAULT NULL,
  PRIMARY KEY (`OrderDetailID`),
  KEY `OrderID` (`OrderID`),
  KEY `ProductID` (`ProductID`),
  CONSTRAINT `orderdetails_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `orders` (`OrderID`),
  CONSTRAINT `orderdetails_ibfk_2` FOREIGN KEY (`ProductID`) REFERENCES `products` (`ProductID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderdetails`
--

LOCK TABLES `orderdetails` WRITE;
/*!40000 ALTER TABLE `orderdetails` DISABLE KEYS */;
INSERT INTO `orderdetails` VALUES (14,12,1,1),(15,13,2,2),(17,14,9,4),(19,15,6,1),(21,16,10,2),(24,17,4,2),(26,18,3,3),(27,19,7,2),(30,20,10,2);
/*!40000 ALTER TABLE `orderdetails` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `AfterUpdateOrder` AFTER UPDATE ON `orderdetails` FOR EACH ROW BEGIN
    -- Update StockQuantity in Products when order quantity is changed
    IF OLD.Quantity <> NEW.Quantity THEN
        UPDATE Products SET StockQuantity = StockQuantity + OLD.Quantity - NEW.Quantity
        WHERE ProductID = NEW.ProductID;
    END IF;
    
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Temporary view structure for view `orderdetailsview`
--

DROP TABLE IF EXISTS `orderdetailsview`;
/*!50001 DROP VIEW IF EXISTS `orderdetailsview`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `orderdetailsview` AS SELECT 
 1 AS `OrderID`,
 1 AS `ProductName`,
 1 AS `StockQuantity`,
 1 AS `OrderDate`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `OrderID` int NOT NULL,
  `CustomerID` int DEFAULT NULL,
  `OrderDate` date DEFAULT NULL,
  PRIMARY KEY (`OrderID`),
  KEY `CustomerID` (`CustomerID`),
  CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`CustomerID`) REFERENCES `customers` (`CustomerID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,1,'2024-02-01'),(2,2,'2024-02-02'),(3,3,'2024-02-03'),(4,4,'2024-02-04'),(5,5,'2024-02-05'),(6,6,'2024-02-06'),(7,7,'2024-02-07'),(8,8,'2024-02-08'),(9,9,'2024-02-09'),(10,10,'2024-02-10'),(11,11,'2024-03-01'),(12,12,'2024-03-02'),(13,13,'2024-03-02'),(14,14,'2024-03-05'),(15,15,'2024-03-05'),(16,16,'2024-03-10'),(17,17,'2024-03-11'),(18,18,'2024-03-17'),(19,19,'2024-03-18'),(20,20,'2024-03-19'),(21,21,'2024-03-23'),(22,22,'2024-03-23'),(23,23,'2024-03-29'),(24,24,'2024-03-30'),(25,25,'2024-04-02'),(26,26,'2024-04-04'),(27,27,'2024-04-04'),(28,28,'2024-04-07'),(29,29,'2024-04-08'),(30,30,'2024-04-10');
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `AfterInsertOrder` AFTER INSERT ON `orders` FOR EACH ROW BEGIN
    DECLARE product_id INT;
    DECLARE quantity INT;

    -- Fetch product_id and quantity from OrderDetails for the new order
    SELECT ProductID, Quantity INTO product_id, quantity
    FROM OrderDetails
    WHERE OrderID = NEW.OrderID;

    -- Update StockQuantity in Products
    UPDATE Products SET StockQuantity = StockQuantity - quantity WHERE ProductID = product_id;
    
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `UpdateProductStockView` AFTER INSERT ON `orders` FOR EACH ROW BEGIN
    -- Update the ProductStockView based on the new orders
    UPDATE ProductStockView PS
    JOIN OrderDetails OD ON PS.ProductID = OD.ProductID
    SET PS.StockQuantity = PS.StockQuantity - OD.Quantity
    WHERE OD.OrderID = NEW.OrderID;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `AfterDeleteOrder` AFTER DELETE ON `orders` FOR EACH ROW BEGIN
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
    
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products` (
  `ProductID` int NOT NULL,
  `ProductName` varchar(50) DEFAULT NULL,
  `Price` decimal(10,2) DEFAULT NULL,
  `StockQuantity` int DEFAULT NULL,
  PRIMARY KEY (`ProductID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (1,'T-Shirt',250.00,100),(2,'Hoodie',600.00,50),(3,'Lanyard',165.00,75),(4,'Sneakers',720.00,30),(5,'Backpack',500.00,40),(6,'Watch',1000.00,20),(7,'Hat',150.00,60),(8,'Sunglasses',70.00,45),(9,'Phone Case',175.00,80),(10,'Laptop Bag',360.00,25);
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `productstockview`
--

DROP TABLE IF EXISTS `productstockview`;
/*!50001 DROP VIEW IF EXISTS `productstockview`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `productstockview` AS SELECT 
 1 AS `ProductID`,
 1 AS `ProductName`,
 1 AS `StockQuantity`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `totalsalestotal`
--

DROP TABLE IF EXISTS `totalsalestotal`;
/*!50001 DROP VIEW IF EXISTS `totalsalestotal`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `totalsalestotal` AS SELECT 
 1 AS `TotalSales`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `totalsalesview`
--

DROP TABLE IF EXISTS `totalsalesview`;
/*!50001 DROP VIEW IF EXISTS `totalsalesview`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `totalsalesview` AS SELECT 
 1 AS `CustomerID`,
 1 AS `CustomerName`,
 1 AS `OrderID`,
 1 AS `OrderDate`,
 1 AS `ProductID`,
 1 AS `ProductName`,
 1 AS `Quantity`,
 1 AS `StockQuantity`,
 1 AS `TotalSale`*/;
SET character_set_client = @saved_cs_client;

--
-- Dumping events for database 'sirkitsitems'
--

--
-- Dumping routines for database 'sirkitsitems'
--
/*!50003 DROP FUNCTION IF EXISTS `CalculateTotalOrderValue` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `CalculateTotalOrderValue`(p_OrderID INT) RETURNS decimal(10,2)
    DETERMINISTIC
BEGIN
    DECLARE total_value DECIMAL(10, 2);
    
    SELECT SUM(Price * Quantity)
    INTO total_value
    FROM OrderDetails
    JOIN Products ON OrderDetails.ProductID = Products.ProductID
    WHERE OrderID = p_OrderID;
    
    RETURN total_value;
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `CalculateTotalSales` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `CalculateTotalSales`() RETURNS decimal(10,2)
    DETERMINISTIC
BEGIN
    DECLARE total_sales DECIMAL(10, 2);
    
    SELECT SUM(TotalSale) INTO total_sales FROM TotalSalesView;
    
    RETURN total_sales;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `InsertNewOrder` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertNewOrder`(
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
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `UpdateProductStockView` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateProductStockView`()
BEGIN
    -- Refresh the ProductStockView
    DROP VIEW IF EXISTS ProductStockView;
    CREATE VIEW ProductStockView AS
    SELECT 
        p.ProductID,
        p.ProductName,
        (p.StockQuantity - COALESCE(SUM(od.Quantity), 0)) AS StockQuantity
    FROM Products p
    LEFT JOIN OrderDetails od ON p.ProductID = od.ProductID
    GROUP BY p.ProductID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `customerorderview`
--

/*!50001 DROP VIEW IF EXISTS `customerorderview`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `customerorderview` AS select `customers`.`CustomerID` AS `CustomerID`,`customers`.`CustomerName` AS `CustomerName`,`orders`.`OrderID` AS `OrderID`,`orders`.`OrderDate` AS `OrderDate` from (`customers` join `orders` on((`customers`.`CustomerID` = `orders`.`CustomerID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `highvalueorders`
--

/*!50001 DROP VIEW IF EXISTS `highvalueorders`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `highvalueorders` AS select `orderdetails`.`OrderID` AS `OrderID`,sum((`products`.`Price` * `orderdetails`.`Quantity`)) AS `TotalValue` from (`orderdetails` join `products` on((`orderdetails`.`ProductID` = `products`.`ProductID`))) group by `orderdetails`.`OrderID` having (`TotalValue` > 100) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `orderdetailsview`
--

/*!50001 DROP VIEW IF EXISTS `orderdetailsview`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `orderdetailsview` AS select `o`.`OrderID` AS `OrderID`,`p`.`ProductName` AS `ProductName`,`ps`.`StockQuantity` AS `StockQuantity`,`o`.`OrderDate` AS `OrderDate` from (((`orders` `o` join `orderdetails` `od` on((`o`.`OrderID` = `od`.`OrderID`))) join `productstockview` `ps` on((`od`.`ProductID` = `ps`.`ProductID`))) join `products` `p` on((`ps`.`ProductID` = `p`.`ProductID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `productstockview`
--

/*!50001 DROP VIEW IF EXISTS `productstockview`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `productstockview` AS select `p`.`ProductID` AS `ProductID`,`p`.`ProductName` AS `ProductName`,(`p`.`StockQuantity` - coalesce(sum(`od`.`Quantity`),0)) AS `StockQuantity` from (`products` `p` left join `orderdetails` `od` on((`p`.`ProductID` = `od`.`ProductID`))) group by `p`.`ProductID` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `totalsalestotal`
--

/*!50001 DROP VIEW IF EXISTS `totalsalestotal`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `totalsalestotal` AS select sum(`totalsalesview`.`TotalSale`) AS `TotalSales` from `totalsalesview` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `totalsalesview`
--

/*!50001 DROP VIEW IF EXISTS `totalsalesview`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `totalsalesview` AS select `co`.`CustomerID` AS `CustomerID`,`co`.`CustomerName` AS `CustomerName`,`co`.`OrderID` AS `OrderID`,`co`.`OrderDate` AS `OrderDate`,`ps`.`ProductID` AS `ProductID`,`ps`.`ProductName` AS `ProductName`,`od`.`Quantity` AS `Quantity`,`ps`.`StockQuantity` AS `StockQuantity`,(`od`.`Quantity` * `p`.`Price`) AS `TotalSale` from (((`customerorderview` `co` join `orderdetails` `od` on((`co`.`OrderID` = `od`.`OrderID`))) join `productstockview` `ps` on((`od`.`ProductID` = `ps`.`ProductID`))) join `products` `p` on((`ps`.`ProductID` = `p`.`ProductID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-04-29  1:16:33
