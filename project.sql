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

INSERT INTO `User` (UserID, Role, Name, Email, Password) VALUES
(1, 'Admin', 'John Doe', 'admin@example.com', 'Aa123'), -- 管理员
(2, 'Sales', 'Alice Smith', 'sales@example.com', 'Bb123'); -- 普通用户

INSERT INTO Product (ProductID, Name, Description, Price, StockQuantity) VALUES
(1, 'Laptop', '15-inch MacBook Pro', '1999.99', 50), -- 修正Price为DECIMAL类型
(2, 'Monitor', '27-inch 4K Display', '499.99', 80);

ALTER TABLE Inventory 
CHANGE COLUMN Location WarehouseName VARCHAR(50),
ADD COLUMN MinStock INT DEFAULT 10;

ALTER TABLE `User` 
MODIFY COLUMN Role ENUM('Admin', 'Sales', 'Warehouse', 'CustomerService') NOT NULL;

INSERT INTO Product (ProductID, Name, Category, AgeRange, Brand, Description, Price, StockQuantity) VALUES
(1, 'Smart Blocks', 'Building Blocks', '6-12 Years', 'Little鲁班', 'APP-controlled building set', 299.99, 150),
(2, 'Princess Doll', 'Dolls', '3-8 Years', 'DreamLand', 'Dress-up Barbie doll', 199.99, 200),
(3, 'RC Racing Car', 'Remote Control', '8-15 Years', 'SpeedX', '2.4G wireless racing car', 399.99, 100);

INSERT INTO Inventory (InventoryID, ProductID, WarehouseName, Quantity, MinStock) VALUES
(1, 1, 'Hong Kong Warehouse', 80, 50),
(2, 1, 'Shenzhen Warehouse', 70, 50),
(3, 2, 'Hong Kong Warehouse', 120, 80);

INSERT INTO `Order` (OrderID, CustomerID, OrderDate, Status, TotalAmount, ShippingAddress, Discount) VALUES
(1001, 1, '2025-06-01', 'Confirmed', 299.99, '123 Kowloon Tong Road, Hong Kong', 0),
(1002, 2, '2025-06-02', 'Shipped', 379.98, 'Room 501, XX Building, Nanshan, Shenzhen', 0.1);

INSERT INTO `User` (UserID, Role, Name, Email, Password) VALUES
(1, 'Admin', 'Zhang Manager', 'manager@toycorp.com', '$2a$10$admin_hash'),
(2, 'Sales', 'Li Sales', 'sales_li@toycorp.com', '$2a$10$sales_hash'),
(3, 'Warehouse', 'Wang Warehouse', 'warehouse_wang@toycorp.com', '$2a$10$warehouse_hash');
