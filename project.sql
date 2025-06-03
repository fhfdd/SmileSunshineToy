-- 1. 客户表
CREATE TABLE IF NOT EXISTS Customer (
    CustomerID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(20) NOT NULL,
    Email VARCHAR(50) NOT NULL,
    Address VARCHAR(100) NOT NULL,
    Feedback VARCHAR(500),
    Phone INT NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 2. 订单表（修正TotalAmount类型）
CREATE TABLE IF NOT EXISTS `Order` (
    OrderID INT AUTO_INCREMENT PRIMARY KEY,
    CustomerID INT NOT NULL,
    OrderDate DATE NOT NULL,
    Status VARCHAR(20),
    TotalAmount DECIMAL(10, 2), -- 修正为DECIMAL类型
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 3. 产品表（修正Price和StockQuantity）
CREATE TABLE IF NOT EXISTS Product (
    ProductID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(30) NOT NULL,
    Description VARCHAR(500),
    Price DECIMAL(10, 2) NOT NULL, -- 修正为DECIMAL类型
    StockQuantity INT NOT NULL DEFAULT 0 -- 增加默认值
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 4. 发票表
CREATE TABLE IF NOT EXISTS Invoice (
    InvoiceID INT AUTO_INCREMENT PRIMARY KEY,
    OrderID INT NOT NULL,
    InvoiceDate DATE,
    TotalAmount VARCHAR(10), -- 若需计算建议改为DECIMAL，此处保留原设计
    FOREIGN KEY (OrderID) REFERENCES `Order`(OrderID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 5. 支付表（修正Amount类型）
CREATE TABLE IF NOT EXISTS Payment (
    PaymentID INT AUTO_INCREMENT PRIMARY KEY,
    InvoiceID INT NOT NULL,
    PaymentDate DATE,
    Amount DECIMAL(10, 2), -- 修正为DECIMAL类型
    PaymentMethod VARCHAR(10),
    FOREIGN KEY (InvoiceID) REFERENCES Invoice(InvoiceID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 6. 仓库表（新增）
CREATE TABLE IF NOT EXISTS Warehouse (
    WarehouseID INT AUTO_INCREMENT PRIMARY KEY,
    WarehouseName VARCHAR(50) NOT NULL,
    Location VARCHAR(100),
    ContactPerson VARCHAR(20),
    ContactPhone VARCHAR(20)
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

-- 10. 客服聊天表（修正Timestamp类型）
CREATE TABLE IF NOT EXISTS CSCHAT (
    ChatID INT AUTO_INCREMENT PRIMARY KEY,
    CustomerID INT NOT NULL,
    Message VARCHAR(1000),
    Response VARCHAR(100),
    Timestamp DATETIME, -- 修正为DATETIME
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

-- 17. 生产计划表（修正Status字段）
CREATE TABLE IF NOT EXISTS productionPlan (
    planID INT AUTO_INCREMENT PRIMARY KEY,
    startDate DATE,
    EndDate DATE,
    Status VARCHAR(10) -- 修正为Status
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 18. 工作订单表
CREATE TABLE IF NOT EXISTS WorkOrder (
    WorkOrderID INT AUTO_INCREMENT PRIMARY KEY,
    productionPlanID INT,
    Status VARCHAR(5), -- 修正为Status
    startDate DATE,
    EndDate DATE,
    FOREIGN KEY (productionPlanID) REFERENCES productionPlan(planID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 19. 物料表（新增）
CREATE TABLE IF NOT EXISTS Material (
    MaterialID INT AUTO_INCREMENT PRIMARY KEY,
    MaterialName VARCHAR(30) NOT NULL,
    Specification VARCHAR(100),
    StockQuantity INT NOT NULL DEFAULT 0,
    SupplierID INT,
    Unit VARCHAR(10) DEFAULT '件',
    FOREIGN KEY (SupplierID) REFERENCES Supplier(SuPPlierID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 20. 库存表（修正Quantity并关联仓库）
CREATE TABLE IF NOT EXISTS Inventory (
    InventoryID INT AUTO_INCREMENT PRIMARY KEY,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL DEFAULT 0, -- 修正为非空
    Location VARCHAR(50),
    WarehouseID INT, -- 新增仓库ID
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID),
    FOREIGN KEY (WarehouseID) REFERENCES Warehouse(WarehouseID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 新增：流水号管理表（触发器依赖）
CREATE TABLE IF NOT EXISTS IDSequence (
    Prefix VARCHAR(10) PRIMARY KEY,
    CurrentNumber INT NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE IF NOT EXISTS OrderSequence (
    OrderDate DATE PRIMARY KEY,
    CurrentNumber INT NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 4. 创建触发器（自动生成带前缀的 ID）
DELIMITER $$
CREATE TRIGGER AutoGenerateUserID BEFORE INSERT ON `User`
FOR EACH ROW BEGIN
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
END$$
DELIMITER ;

DELIMITER $$
CREATE TRIGGER AutoGenerateOrderID BEFORE INSERT ON `Order`
FOR EACH ROW BEGIN
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
END$$
DELIMITER ;

-- 插入仓库数据（英文）
INSERT INTO Warehouse (WarehouseName, Location, ContactPerson, ContactPhone) VALUES
('Main Warehouse', 'Shenzhen', 'John Smith', '+86-13800138001'),
('Branch Warehouse', 'Hong Kong', 'Alice Wong', '+852-98765432');

-- 插入用户（自动生成 UserID）
INSERT INTO `User` (Role, Name, Email, Password) VALUES
('Sales', 'Tom Smith', 'sales@example.com', 'SalesPass123'),
('Purchasing', 'Alice Li', 'purchasing@example.com', 'PurPass456');

-- 插入客户
INSERT INTO Customer (Name, Email, Address, Phone) VALUES
('John Doe', 'john@example.com', 'London', 1234567890);

-- 插入订单（自动生成 OrderID）
INSERT INTO `Order` (CustomerID, OrderDate, Status, TotalAmount) VALUES
(1, CURDATE(), 'Confirmed', 1999.99);

-- 插入产品（含新增产品）
INSERT INTO Product (Name, Description, Price, StockQuantity) VALUES
('Remote Control Car', '2.4GHz Model', 99.99, 200),
('Smart Building Blocks', 'STEM Learning Kit', 149.99, 300);

-- 插入库存（关联两个仓库）
INSERT INTO Inventory (ProductID, Quantity, Location, WarehouseID) VALUES
(1, 150, 'Aisle 3', 1), -- 主仓库
(1, 80, 'B201', 2), -- 分支仓库
(2, 200, 'Aisle 5', 1); -- 主仓库新增产品
