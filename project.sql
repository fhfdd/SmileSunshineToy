-- 1. 客户表
CREATE TABLE IF NOT EXISTS Customer (
    CustomerID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(20) NOT NULL,
    Email VARCHAR(50) NOT NULL,
    Address VARCHAR(100) NOT NULL,
    Feedback VARCHAR(500),
    Phone INT NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 2. 订单表
CREATE TABLE IF NOT EXISTS `Order` (
    OrderID INT AUTO_INCREMENT PRIMARY KEY,
    CustomerID INT NOT NULL,
    OrderDate DATE NOT NULL,
    Status VARCHAR(20),
    TotalAmount INT,
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 3. 产品表
CREATE TABLE IF NOT EXISTS Product (
    ProductID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(30) NOT NULL,
    Description VARCHAR(500),
    Price VARCHAR(10) NOT NULL,
    StockQuantity INT NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 4. 发票表
CREATE TABLE IF NOT EXISTS Invoice (
    InvoiceID INT AUTO_INCREMENT PRIMARY KEY,
    OrderID INT NOT NULL,
    InvoiceDate DATE,
    TotalAmount VARCHAR(10),
    FOREIGN KEY (OrderID) REFERENCES `Order`(OrderID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 5. 支付表
CREATE TABLE IF NOT EXISTS Payment (
    PaymentID INT AUTO_INCREMENT PRIMARY KEY,
    InvoiceID INT NOT NULL,
    PaymentDate DATE,
    Amount VARCHAR(10),
    PaymentMethod VARCHAR(10),
    FOREIGN KEY (InvoiceID) REFERENCES Invoice(InvoiceID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 6. 库存表
CREATE TABLE IF NOT EXISTS Inventory (
    InventoryID INT AUTO_INCREMENT PRIMARY KEY,
    ProductID INT NOT NULL,
    Quantity INT,
    Location VARCHAR(50),
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 7. 反馈表
CREATE TABLE IF NOT EXISTS Feedback (
    FeedbackID INT AUTO_INCREMENT PRIMARY KEY,
    CustomerID INT NOT NULL,
    FeedbackText VARCHAR(500),
    FeedbackDate DATE,
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 8. 用户表
CREATE TABLE IF NOT EXISTS `User` (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    Role VARCHAR(10),
    Name VARCHAR(20),
    Email VARCHAR(50),
    Password VARCHAR(30)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 9. 任务表
CREATE TABLE IF NOT EXISTS Task (
    TaskID INT AUTO_INCREMENT PRIMARY KEY,
    TaskName VARCHAR(20),
    Status VARCHAR(20),
    Duedate DATE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 10. 客服聊天表
CREATE TABLE IF NOT EXISTS CSCHAT (
    ChatID INT AUTO_INCREMENT PRIMARY KEY,
    CustomerID INT NOT NULL,
    Message VARCHAR(1000),
    Response VARCHAR(100),
    Timestamp VARCHAR(50),
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 11. 售后请求表
CREATE TABLE IF NOT EXISTS afterSaleRequest (
    RequestID INT AUTO_INCREMENT PRIMARY KEY,
    OrderID INT,
    Status VARCHAR(10),
    RequestDate DATE,
    FOREIGN KEY (OrderID) REFERENCES `Order`(OrderID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 12. 退货请求表
CREATE TABLE IF NOT EXISTS returnRequest (
    ExchangeID INT AUTO_INCREMENT PRIMARY KEY,
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Status VARCHAR(10),
    UpdatedDate DATE,
    FOREIGN KEY (OrderID) REFERENCES `Order`(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 13. 报价表
CREATE TABLE IF NOT EXISTS Quotation (
    QuotationID INT AUTO_INCREMENT PRIMARY KEY,
    CustomerID INT NOT NULL,
    ProductID INT NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 14. 运输表
CREATE TABLE IF NOT EXISTS shipment (
    shipmentID INT AUTO_INCREMENT PRIMARY KEY,
    OrderID INT,
    TrackingNumber INT,
    Status VARCHAR(30),
    EstimatedDeliveryDate DATE,
    FOREIGN KEY (OrderID) REFERENCES `Order`(OrderID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 15. 物流表
CREATE TABLE IF NOT EXISTS Logistics (
    logisticsID INT AUTO_INCREMENT PRIMARY KEY,
    ShipmentID INT,
    status VARCHAR(30),
    FOREIGN KEY (ShipmentID) REFERENCES shipment(shipmentID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 16. 供应商表
CREATE TABLE IF NOT EXISTS Supplier (
    SuPPlierID INT AUTO_INCREMENT PRIMARY KEY, -- 保留原拼写
    Name VARCHAR(20),
    contactInfo VARCHAR(30),
    Address VARCHAR(50)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 17. 生产计划表
CREATE TABLE IF NOT EXISTS productionPlan (
    planID INT AUTO_INCREMENT PRIMARY KEY,
    startDate DATE,
    EndDate DATE,
    Stutas VARCHAR(10) -- 保留原拼写
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 18. 工作订单表
CREATE TABLE IF NOT EXISTS WorkOrder (
    WorkOrderID INT AUTO_INCREMENT PRIMARY KEY,
    productionPlanID INT,
    Stutas VARCHAR(5), -- 保留原拼写
    startDate DATE,
    EndDate DATE,
    FOREIGN KEY (productionPlanID) REFERENCES productionPlan(planID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO Warehouse (WarehouseName, Location) VALUES
('Main Warehouse', 'Hong Kong'),
('Branch Warehouse', 'Shenzhen'),
('Distribution Center', 'Guangzhou');

INSERT INTO Product (ProductID, Name, Description, Price, StockQuantity, Category) VALUES
(1001, 'Smart Building Blocks', 'APP-connected educational toys', 299.99, 500, 'Educational'),
(1002, 'Remote Control Car', '2.4GHz high-speed racing car', 199.99, 300, 'Toys'),
(1003, 'Doll Set', 'Fashion doll with interchangeable outfits', 149.99, 400, 'Dolls');

INSERT INTO Material (MaterialID, MaterialName, Specification, ProductionID) VALUES
(2001, 'ABS Plastic', 'Food-grade, 2mm thickness', 1), -- Linked to production plan ID=1
(2002, 'Electronic Circuit Board', 'Bluetooth-enabled', 2), -- Linked to production plan ID=2
(2003, 'Cotton Fabric', '100% organic', 3); -- Linked to production plan ID=3
