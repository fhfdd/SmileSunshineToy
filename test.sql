-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 03, 2025 at 08:07 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `project`
--

-- --------------------------------------------------------

--
-- Table structure for table `aftersalerequest`
--

CREATE TABLE `aftersalerequest` (
  `RequestID` int(11) NOT NULL,
  `OrderID` int(11) DEFAULT NULL,
  `Status` varchar(10) DEFAULT NULL,
  `RequestDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `aftersalerequest`
--

INSERT INTO `aftersalerequest` (`RequestID`, `OrderID`, `Status`, `RequestDate`) VALUES
(1, 1, 'Approved', '2025-05-14'),
(2, 3, 'For Review', '2025-05-21'),
(3, 5, 'Refunded', '2025-06-01');

-- --------------------------------------------------------

--
-- Table structure for table `cschat`
--

CREATE TABLE `cschat` (
  `ChatID` int(11) NOT NULL,
  `CustomerID` int(11) NOT NULL,
  `Message` varchar(1000) DEFAULT NULL,
  `Response` varchar(100) DEFAULT NULL,
  `Timestamp` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cschat`
--

INSERT INTO `cschat` (`ChatID`, `CustomerID`, `Message`, `Response`, `Timestamp`) VALUES
(1, 1, 'I received my toy, but it was missing a piece. Can you help?', 'We apologize for the inconvenience! We’ll send the missing piece right away.', '2025-06-01 10:04:07'),
(2, 7, 'Do you have any updates on my order status?', 'Your order is currently being processed and will be shipped soon.', '2025-05-31 09:23:04'),
(3, 9, 'Is there a warranty on your products?', 'Yes, our toys come with a one-year warranty against defects.', '2025-06-03 11:45:26');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `CustomerID` int(11) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Address` varchar(100) NOT NULL,
  `Feedback` varchar(500) DEFAULT NULL,
  `Phone` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`CustomerID`, `Name`, `Email`, `Address`, `Feedback`, `Phone`) VALUES
(1, 'John Doe', 'john@example.com', 'London', NULL, 1234567890),
(4, 'Alice Chan', 'alice.chan@wiki.com', '123 Elm St, Springfield, IL 62701', NULL, 1234567),
(5, 'David Lee', 'david.lee@google.com', '123 Nathan Rd, Tsim Sha Tsui, Hong Kong', NULL, 2223344),
(6, 'Benny Wong', 'benny.wong@example.com', '321 Sukhumvit Rd, Bangkok, Thailand', NULL, 5551212),
(7, 'Michael Jackson', 'michael.jackson@smile.com', '654 Queen\'s Rd, Central, Hong Kong', NULL, 4445678),
(8, 'Cindy Lau', 'cindy.lau@hotmail.com', '135 Dong Khoi St, Ho Chi Minh City, Vietnam', NULL, 8889999),
(9, 'Beyonce Carter', 'beyonce.carter@smile.com', '357 Des Voeux Rd, Hong Kong', NULL, 1112222),
(10, 'Anna Martinez', 'anna.martinez@example.com', '135 Dong Khoi St, Ho Chi Minh City, Vietnam', NULL, 63409872);

-- --------------------------------------------------------

--
-- Table structure for table `feedback`
--

CREATE TABLE `feedback` (
  `FeedbackID` int(11) NOT NULL,
  `CustomerID` int(11) NOT NULL,
  `FeedbackText` varchar(500) DEFAULT NULL,
  `FeedbackDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `feedback`
--

INSERT INTO `feedback` (`FeedbackID`, `CustomerID`, `FeedbackText`, `FeedbackDate`) VALUES
(1, 10, 'Excellent value for money! Would definitely recommend to friends.', '2025-04-16'),
(2, 8, 'The assembly instructions were unclear, but once I figured it out, my daughter loved it!', '2025-04-08'),
(3, 5, 'The toy is well-made, but I wish there were more color options available.', '2025-05-30'),
(4, 4, 'My son loves the new action figures! Great quality and detail.', '2025-04-16');

-- --------------------------------------------------------

--
-- Table structure for table `idsequence`
--

CREATE TABLE `idsequence` (
  `Prefix` varchar(10) NOT NULL,
  `CurrentNumber` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `idsequence`
--

INSERT INTO `idsequence` (`Prefix`, `CurrentNumber`) VALUES
('01', 2);

-- --------------------------------------------------------

--
-- Table structure for table `inventory`
--

CREATE TABLE `inventory` (
  `InventoryID` int(11) NOT NULL,
  `ProductID` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL DEFAULT 0,
  `Location` varchar(50) DEFAULT NULL,
  `WarehouseID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `inventory`
--

INSERT INTO `inventory` (`InventoryID`, `ProductID`, `Quantity`, `Location`, `WarehouseID`) VALUES
(1, 1, 150, 'Aisle 3', 1),
(2, 1, 80, 'B201', 2),
(3, 2, 200, 'Aisle 5', 1);

-- --------------------------------------------------------

--
-- Table structure for table `invoice`
--

CREATE TABLE `invoice` (
  `InvoiceID` int(11) NOT NULL,
  `OrderID` int(11) NOT NULL,
  `InvoiceDate` date DEFAULT NULL,
  `TotalAmount` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `invoice`
--

INSERT INTO `invoice` (`InvoiceID`, `OrderID`, `InvoiceDate`, `TotalAmount`) VALUES
(1, 1, '2025-05-25', '150.00'),
(2, 1, '2025-03-25', '300.00'),
(3, 1, '2025-05-05', '564.50'),
(4, 1, '2025-05-18', '550.00'),
(5, 1, '2025-03-07', '803.50'),
(6, 1, '2025-05-10', '789.00');

-- --------------------------------------------------------

--
-- Table structure for table `logistics`
--

CREATE TABLE `logistics` (
  `logisticsID` int(11) NOT NULL,
  `ShipmentID` int(11) DEFAULT NULL,
  `status` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `logistics`
--

INSERT INTO `logistics` (`logisticsID`, `ShipmentID`, `status`) VALUES
(1, NULL, 'Pending'),
(2, NULL, 'Completed'),
(3, NULL, 'Late'),
(4, NULL, 'On Track'),
(5, NULL, 'Pending'),
(6, NULL, 'Completed');

-- --------------------------------------------------------

--
-- Table structure for table `material`
--

CREATE TABLE `material` (
  `MaterialID` int(11) NOT NULL,
  `MaterialName` varchar(30) NOT NULL,
  `Specification` varchar(100) DEFAULT NULL,
  `StockQuantity` int(11) NOT NULL DEFAULT 0,
  `SupplierID` int(11) DEFAULT NULL,
  `Unit` varchar(10) DEFAULT '件'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `material`
--

INSERT INTO `material` (`MaterialID`, `MaterialName`, `Specification`, `StockQuantity`, `SupplierID`, `Unit`) VALUES
(1, 'Leather', 'Black leather cover for toy seat', 11, NULL, '15'),
(2, 'Plywood Board', 'Light brown plywood board for general usage', 150, NULL, '150'),
(3, 'Sticker Paper', 'Sticker paper for printing stickers - various sizes', 300, NULL, '150'),
(4, 'Plastic', 'Various grades for molding action figures, dolls, and toy vehicles', 50, NULL, '100'),
(5, 'Paint', 'Non-toxic paints for finishing and decorating toys', 30, NULL, '50'),
(6, 'Rubber', 'For bouncy balls, grips, and soft toy components', 30, NULL, '40'),
(7, 'Fabric', 'For soft toys, plush dolls, and textile-based games', 30, NULL, '40');

-- --------------------------------------------------------

--
-- Table structure for table `order`
--

CREATE TABLE `order` (
  `OrderID` int(11) NOT NULL,
  `CustomerID` int(11) NOT NULL,
  `OrderDate` date NOT NULL,
  `Status` varchar(20) DEFAULT NULL,
  `TotalAmount` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `order`
--

INSERT INTO `order` (`OrderID`, `CustomerID`, `OrderDate`, `Status`, `TotalAmount`) VALUES
(1, 1, '2025-06-03', 'Confirmed', 1999.99),
(3, 4, '2025-05-25', 'Confirmed', 2500.00),
(4, 5, '2025-04-25', 'Pending', 800.00),
(5, 6, '2025-05-15', 'Confirmed', 550.00),
(8, 7, '2025-03-25', 'Pending', 649.50),
(9, 8, '2025-05-18', 'Confirmed', 1899.00),
(10, 9, '2025-05-07', 'Pending', 1300.00),
(11, 10, '2025-06-02', 'Confirmed', 999.00);

--
-- Triggers `order`
--
DELIMITER $$
CREATE TRIGGER `AutoGenerateOrderID` BEFORE INSERT ON `order` FOR EACH ROW BEGIN
    DECLARE order_date_str VARCHAR(8);
    DECLARE current_num INT;
    SET order_date_str = DATE_FORMAT(CURDATE(), '%Y%m%d');
    SELECT CurrentNumber INTO current_num FROM OrderSequence WHERE OrderDate = CURDATE() FOR UPDATE;
    IF current_num IS NULL THEN
        INSERT INTO OrderSequence (OrderDate, CurrentNumber) VALUES (CURDATE(), 1);
        SET NEW.OrderID = CONCAT('ORD-', order_date_str, '-001');
    ELSE
        SET NEW.OrderID = CONCAT('ORD-', order_date_str, '-', LPAD(current_num + 1, 3, '0'));
        UPDATE OrderSequence SET CurrentNumber = current_num + 1 WHERE OrderDate = CURDATE();
    END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `ordersequence`
--

CREATE TABLE `ordersequence` (
  `OrderDate` date NOT NULL,
  `CurrentNumber` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `ordersequence`
--

INSERT INTO `ordersequence` (`OrderDate`, `CurrentNumber`) VALUES
('0000-00-00', 11),
('2025-03-25', 14),
('2025-04-25', 13),
('2025-05-07', 15),
('2025-05-15', 10),
('2025-05-25', 9),
('2025-06-03', 8);

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE `payment` (
  `PaymentID` int(11) NOT NULL,
  `InvoiceID` int(11) NOT NULL,
  `PaymentDate` date DEFAULT NULL,
  `Amount` decimal(10,2) DEFAULT NULL,
  `PaymentMethod` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `payment`
--

INSERT INTO `payment` (`PaymentID`, `InvoiceID`, `PaymentDate`, `Amount`, `PaymentMethod`) VALUES
(1, 1, '2025-05-31', 150.00, 'Credit Car'),
(3, 2, '2025-03-25', 300.00, 'Credit Car'),
(4, 3, '2025-05-05', 564.50, 'AliPayHK'),
(5, 4, '2025-05-18', 550.00, 'Gift Vouch'),
(6, 5, '2025-03-07', 803.50, 'COD'),
(7, 6, '2025-05-10', 789.00, 'Credit Car');

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `ProductID` int(11) NOT NULL,
  `Name` varchar(30) NOT NULL,
  `Description` varchar(500) DEFAULT NULL,
  `Price` decimal(10,2) NOT NULL,
  `StockQuantity` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`ProductID`, `Name`, `Description`, `Price`, `StockQuantity`) VALUES
(1, 'Remote Control Car', '2.4GHz Model', 99.99, 200),
(2, 'Smart Building Blocks', 'STEM Learning Kit', 149.99, 300),
(3, 'Arts and Crafts Kits', 'Kits containing various supplies like paints, markers, and materials for DIY projects.', 299.00, 250),
(4, 'Puzzle Sets', 'Jigsaw puzzles with 50-1000 pieces', 110.00, 140),
(5, 'Board Games', 'Interactive games designed for 2-6 players', 99.99, 100);

-- --------------------------------------------------------

--
-- Table structure for table `productionplan`
--

CREATE TABLE `productionplan` (
  `planID` int(11) NOT NULL,
  `startDate` date DEFAULT NULL,
  `EndDate` date DEFAULT NULL,
  `Status` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `productionplan`
--

INSERT INTO `productionplan` (`planID`, `startDate`, `EndDate`, `Status`) VALUES
(1, '2025-03-01', '2025-03-10', 'In progres'),
(2, '2025-03-15', '2025-03-25', 'On Hold '),
(3, '2025-04-01', '2025-04-10', 'Completed'),
(4, '2025-04-11', '2025-04-20', 'Quality Ch'),
(5, '2025-04-15', '2025-04-20', 'Completed'),
(6, '2025-04-21', '2025-04-27', 'In progres');

-- --------------------------------------------------------

--
-- Table structure for table `returnrequest`
--

CREATE TABLE `returnrequest` (
  `ExchangeID` int(11) NOT NULL,
  `OrderID` int(11) NOT NULL,
  `ProductID` int(11) NOT NULL,
  `Status` varchar(10) DEFAULT NULL,
  `UpdatedDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `returnrequest`
--

INSERT INTO `returnrequest` (`ExchangeID`, `OrderID`, `ProductID`, `Status`, `UpdatedDate`) VALUES
(3, 4, 1, 'Exchange p', '2025-06-01'),
(4, 8, 4, 'Approved', '2025-05-29'),
(5, 10, 2, 'In process', '2025-05-31');

-- --------------------------------------------------------

--
-- Table structure for table `shipment`
--

CREATE TABLE `shipment` (
  `shipmentID` int(11) NOT NULL,
  `OrderID` int(11) DEFAULT NULL,
  `TrackingNumber` int(11) DEFAULT NULL,
  `Status` varchar(30) DEFAULT NULL,
  `EstimatedDeliveryDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `shipment`
--

INSERT INTO `shipment` (`shipmentID`, `OrderID`, `TrackingNumber`, `Status`, `EstimatedDeliveryDate`) VALUES
(1, 1, 1, 'In Transit', '2025-06-19'),
(2, 3, 2, 'Dispatched', '2025-06-18'),
(3, 5, 3, 'Completed', '2025-06-04'),
(4, 11, 4, 'In warehouse', '2025-06-24');

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `SuPPlierID` int(11) NOT NULL,
  `Name` varchar(20) DEFAULT NULL,
  `contactInfo` varchar(30) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`SuPPlierID`, `Name`, `contactInfo`, `Address`) VALUES
(1, 'Toyland Supplies', '9876543', '101 Playful St, Tsim Sha Tsui, Hong Kong'),
(2, 'Happy Tots Co.', '234-5678', '202 Joy Ave, Central, Hong Kong'),
(3, 'Kiddo Creations', '345-6789', '303 Imagination Rd, Wan Chai, Hong Kong'),
(4, 'Little Dreamers Inc.', '456-7890', '404 Adventure Blvd, Mong Kok, Hong Kong');

-- --------------------------------------------------------

--
-- Table structure for table `task`
--

CREATE TABLE `task` (
  `TaskID` int(11) NOT NULL,
  `TaskName` varchar(20) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  `Duedate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `task`
--

INSERT INTO `task` (`TaskID`, `TaskName`, `Status`, `Duedate`) VALUES
(1, 'Design Review', 'Waiting for feedback', '2025-06-07'),
(2, 'Assembly Line Setup', 'In progress', '2025-06-08'),
(3, 'Order Fulfillment', 'Completed', '2025-06-01'),
(4, 'Packaging Design', 'Approved', '2025-06-11');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `UserID` int(11) NOT NULL,
  `Role` varchar(10) DEFAULT NULL,
  `Name` varchar(20) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Password` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`UserID`, `Role`, `Name`, `Email`, `Password`) VALUES
(1, 'Sales', 'Tom Smith', 'sales@example.com', 'SalesPass123'),
(2, 'Purchasing', 'Alice Li', 'purchasing@example.com', 'PurPass456');

--
-- Triggers `user`
--
DELIMITER $$
CREATE TRIGGER `AutoGenerateUserID` BEFORE INSERT ON `user` FOR EACH ROW BEGIN
    DECLARE prefix VARCHAR(10);
    DECLARE current_num INT;
    CASE NEW.Role
        WHEN 'Sales' THEN SET prefix = '01';
        WHEN 'Purchasing' THEN SET prefix = '02';
        ELSE SET prefix = '99';
    END CASE;
    SELECT CurrentNumber INTO current_num FROM IDSequence WHERE Prefix = prefix FOR UPDATE;
    IF current_num IS NULL THEN
        INSERT INTO IDSequence (Prefix, CurrentNumber) VALUES (prefix, 1);
        SET NEW.UserID = CONCAT(prefix, '-001');
    ELSE
        SET NEW.UserID = CONCAT(prefix, '-', LPAD(current_num + 1, 3, '0'));
        UPDATE IDSequence SET CurrentNumber = current_num + 1 WHERE Prefix = prefix;
    END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `warehouse`
--

CREATE TABLE `warehouse` (
  `WarehouseID` int(11) NOT NULL,
  `WarehouseName` varchar(50) NOT NULL,
  `Location` varchar(100) DEFAULT NULL,
  `ContactPerson` varchar(20) DEFAULT NULL,
  `ContactPhone` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `warehouse`
--

INSERT INTO `warehouse` (`WarehouseID`, `WarehouseName`, `Location`, `ContactPerson`, `ContactPhone`) VALUES
(1, 'Main Warehouse', 'Shenzhen', 'John Smith', '+86-13800138001'),
(2, 'Branch Warehouse', 'Hong Kong', 'Alice Wong', '+852-98765432');

-- --------------------------------------------------------

--
-- Table structure for table `workorder`
--

CREATE TABLE `workorder` (
  `WorkOrderID` int(11) NOT NULL,
  `productionPlanID` int(11) DEFAULT NULL,
  `Status` varchar(5) DEFAULT NULL,
  `startDate` date DEFAULT NULL,
  `EndDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `workorder`
--

INSERT INTO `workorder` (`WorkOrderID`, `productionPlanID`, `Status`, `startDate`, `EndDate`) VALUES
(1, 1, 'INPRG', '2025-04-05', '2025-04-15'),
(2, 2, 'ONHLD', '2025-04-20', '2025-04-30'),
(3, 3, 'COMP', '2025-05-01', '2025-05-10');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `aftersalerequest`
--
ALTER TABLE `aftersalerequest`
  ADD PRIMARY KEY (`RequestID`),
  ADD KEY `OrderID` (`OrderID`);

--
-- Indexes for table `cschat`
--
ALTER TABLE `cschat`
  ADD PRIMARY KEY (`ChatID`),
  ADD KEY `CustomerID` (`CustomerID`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`CustomerID`);

--
-- Indexes for table `feedback`
--
ALTER TABLE `feedback`
  ADD PRIMARY KEY (`FeedbackID`),
  ADD KEY `CustomerID` (`CustomerID`);

--
-- Indexes for table `idsequence`
--
ALTER TABLE `idsequence`
  ADD PRIMARY KEY (`Prefix`);

--
-- Indexes for table `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`InventoryID`),
  ADD KEY `ProductID` (`ProductID`),
  ADD KEY `WarehouseID` (`WarehouseID`);

--
-- Indexes for table `invoice`
--
ALTER TABLE `invoice`
  ADD PRIMARY KEY (`InvoiceID`),
  ADD KEY `OrderID` (`OrderID`);

--
-- Indexes for table `logistics`
--
ALTER TABLE `logistics`
  ADD PRIMARY KEY (`logisticsID`),
  ADD KEY `ShipmentID` (`ShipmentID`);

--
-- Indexes for table `material`
--
ALTER TABLE `material`
  ADD PRIMARY KEY (`MaterialID`),
  ADD KEY `SupplierID` (`SupplierID`);

--
-- Indexes for table `order`
--
ALTER TABLE `order`
  ADD PRIMARY KEY (`OrderID`),
  ADD KEY `CustomerID` (`CustomerID`);

--
-- Indexes for table `ordersequence`
--
ALTER TABLE `ordersequence`
  ADD PRIMARY KEY (`OrderDate`);

--
-- Indexes for table `payment`
--
ALTER TABLE `payment`
  ADD PRIMARY KEY (`PaymentID`),
  ADD KEY `InvoiceID` (`InvoiceID`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`ProductID`);

--
-- Indexes for table `productionplan`
--
ALTER TABLE `productionplan`
  ADD PRIMARY KEY (`planID`);

--
-- Indexes for table `returnrequest`
--
ALTER TABLE `returnrequest`
  ADD PRIMARY KEY (`ExchangeID`),
  ADD KEY `OrderID` (`OrderID`),
  ADD KEY `ProductID` (`ProductID`);

--
-- Indexes for table `shipment`
--
ALTER TABLE `shipment`
  ADD PRIMARY KEY (`shipmentID`),
  ADD KEY `OrderID` (`OrderID`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`SuPPlierID`);

--
-- Indexes for table `task`
--
ALTER TABLE `task`
  ADD PRIMARY KEY (`TaskID`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`UserID`);

--
-- Indexes for table `warehouse`
--
ALTER TABLE `warehouse`
  ADD PRIMARY KEY (`WarehouseID`);

--
-- Indexes for table `workorder`
--
ALTER TABLE `workorder`
  ADD PRIMARY KEY (`WorkOrderID`),
  ADD KEY `productionPlanID` (`productionPlanID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `aftersalerequest`
--
ALTER TABLE `aftersalerequest`
  MODIFY `RequestID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `cschat`
--
ALTER TABLE `cschat`
  MODIFY `ChatID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `CustomerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `feedback`
--
ALTER TABLE `feedback`
  MODIFY `FeedbackID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `inventory`
--
ALTER TABLE `inventory`
  MODIFY `InventoryID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `invoice`
--
ALTER TABLE `invoice`
  MODIFY `InvoiceID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `logistics`
--
ALTER TABLE `logistics`
  MODIFY `logisticsID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `material`
--
ALTER TABLE `material`
  MODIFY `MaterialID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `order`
--
ALTER TABLE `order`
  MODIFY `OrderID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `payment`
--
ALTER TABLE `payment`
  MODIFY `PaymentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `ProductID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `productionplan`
--
ALTER TABLE `productionplan`
  MODIFY `planID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `returnrequest`
--
ALTER TABLE `returnrequest`
  MODIFY `ExchangeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `shipment`
--
ALTER TABLE `shipment`
  MODIFY `shipmentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `SuPPlierID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `task`
--
ALTER TABLE `task`
  MODIFY `TaskID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=100;

--
-- AUTO_INCREMENT for table `warehouse`
--
ALTER TABLE `warehouse`
  MODIFY `WarehouseID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `workorder`
--
ALTER TABLE `workorder`
  MODIFY `WorkOrderID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `aftersalerequest`
--
ALTER TABLE `aftersalerequest`
  ADD CONSTRAINT `aftersalerequest_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `order` (`OrderID`);

--
-- Constraints for table `cschat`
--
ALTER TABLE `cschat`
  ADD CONSTRAINT `cschat_ibfk_1` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`);

--
-- Constraints for table `feedback`
--
ALTER TABLE `feedback`
  ADD CONSTRAINT `feedback_ibfk_1` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`);

--
-- Constraints for table `inventory`
--
ALTER TABLE `inventory`
  ADD CONSTRAINT `inventory_ibfk_1` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ProductID`),
  ADD CONSTRAINT `inventory_ibfk_2` FOREIGN KEY (`WarehouseID`) REFERENCES `warehouse` (`WarehouseID`);

--
-- Constraints for table `invoice`
--
ALTER TABLE `invoice`
  ADD CONSTRAINT `invoice_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `order` (`OrderID`);

--
-- Constraints for table `logistics`
--
ALTER TABLE `logistics`
  ADD CONSTRAINT `logistics_ibfk_1` FOREIGN KEY (`ShipmentID`) REFERENCES `shipment` (`shipmentID`);

--
-- Constraints for table `material`
--
ALTER TABLE `material`
  ADD CONSTRAINT `material_ibfk_1` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`SuPPlierID`);

--
-- Constraints for table `order`
--
ALTER TABLE `order`
  ADD CONSTRAINT `order_ibfk_1` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`);

--
-- Constraints for table `payment`
--
ALTER TABLE `payment`
  ADD CONSTRAINT `payment_ibfk_1` FOREIGN KEY (`InvoiceID`) REFERENCES `invoice` (`InvoiceID`);

--
-- Constraints for table `returnrequest`
--
ALTER TABLE `returnrequest`
  ADD CONSTRAINT `returnrequest_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `order` (`OrderID`),
  ADD CONSTRAINT `returnrequest_ibfk_2` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ProductID`);

--
-- Constraints for table `shipment`
--
ALTER TABLE `shipment`
  ADD CONSTRAINT `shipment_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `order` (`OrderID`);

--
-- Constraints for table `workorder`
--
ALTER TABLE `workorder`
  ADD CONSTRAINT `workorder_ibfk_1` FOREIGN KEY (`productionPlanID`) REFERENCES `productionplan` (`planID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
