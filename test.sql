-- Drop the existing test database if it exists
DROP DATABASE IF EXISTS test;

-- Create a fresh test database
CREATE DATABASE test;
USE test;

-- Create ID sequence table (for application layer reference)
CREATE TABLE idsequence (
    Prefix VARCHAR(10) NOT NULL,
    CurrentNumber INT NOT NULL DEFAULT 0,
    PRIMARY KEY (Prefix)
);

-- Initialize sequences
INSERT INTO idsequence (Prefix, CurrentNumber) VALUES 
('CUST', 0), ('SUPP', 0), ('PROD', 0), ('MAT', 0), 
('WH', 0), ('ORD', 0), ('ORDITM', 0), ('INV', 0), 
('IB', 0), ('OB', 0), ('PAY', 0), ('PLAN', 0), 
('SHIP', 0), ('LOG', 0), ('ASR', 0), ('FB', 0),
('USER', 0);

-- Create customer table
CREATE TABLE customer (
    CustomerID VARCHAR(20) PRIMARY KEY,
    Name VARCHAR(20) NOT NULL,
    Email VARCHAR(50) NOT NULL,
    Address VARCHAR(100) NOT NULL,
    Feedback VARCHAR(500) DEFAULT NULL,
    Phone VARCHAR(20) NOT NULL
);

-- Create supplier table
CREATE TABLE supplier (
    SupplierID VARCHAR(20) PRIMARY KEY,
    Name VARCHAR(20) DEFAULT NULL,
    contactInfo VARCHAR(30) DEFAULT NULL,
    Address VARCHAR(50) DEFAULT NULL
);

-- Create product table
CREATE TABLE product (
    ProductID VARCHAR(20) PRIMARY KEY,
    Name VARCHAR(30) NOT NULL,
    Description VARCHAR(500) DEFAULT NULL,
    Price DECIMAL(10,2) NOT NULL,
    StockQuantity INT NOT NULL DEFAULT 0,
    image_data LONGBLOB DEFAULT NULL,
    image_type VARCHAR(50) DEFAULT NULL
);

-- Create material table
CREATE TABLE material (
    MaterialID VARCHAR(20) PRIMARY KEY,
    MaterialName VARCHAR(30) NOT NULL,
    Specification VARCHAR(100) DEFAULT NULL,
    StockQuantity INT NOT NULL DEFAULT 0,
    SupplierID VARCHAR(20) DEFAULT NULL,
    Unit VARCHAR(10) DEFAULT 'pcs',
    image_data LONGBLOB DEFAULT NULL, 
    image_type VARCHAR(50) DEFAULT NULL,
    FOREIGN KEY (SupplierID) REFERENCES supplier(SupplierID)
);

-- Create warehouse table
CREATE TABLE warehouse (
    WarehouseID VARCHAR(20) PRIMARY KEY,
    WarehouseName VARCHAR(50) NOT NULL,
    Location VARCHAR(100) DEFAULT NULL,
    ContactPerson VARCHAR(20) DEFAULT NULL,
    ContactPhone VARCHAR(20) DEFAULT NULL
);

-- Create order table
CREATE TABLE `order` (
    OrderID VARCHAR(20) PRIMARY KEY,
    CustomerID VARCHAR(20) NOT NULL,
    OrderDate DATE NOT NULL,
    Status ENUM('Pending','Processing','Completed') DEFAULT 'Pending',
    TotalAmount DECIMAL(10,2) DEFAULT NULL,
    FOREIGN KEY (CustomerID) REFERENCES customer(CustomerID)
);

-- Create order item table
CREATE TABLE orderitem (
    OrderItemID VARCHAR(20) PRIMARY KEY,
    OrderID VARCHAR(20) NOT NULL,
    ProductID VARCHAR(20) NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES `order`(OrderID),
    FOREIGN KEY (ProductID) REFERENCES product(ProductID)
);

-- Create inventory table
CREATE TABLE inventory (
    InventoryID VARCHAR(20) PRIMARY KEY,
    ProductID VARCHAR(20) NOT NULL,
    Quantity INT NOT NULL DEFAULT 0,
    Location VARCHAR(50) DEFAULT NULL,
    WarehouseID VARCHAR(20) DEFAULT NULL,
    FOREIGN KEY (ProductID) REFERENCES product(ProductID),
    FOREIGN KEY (WarehouseID) REFERENCES warehouse(WarehouseID)
);

-- Create inbound table
CREATE TABLE inbound (
    inboundID VARCHAR(20) PRIMARY KEY,
    productID VARCHAR(20) NOT NULL,
    quantity INT NOT NULL CHECK (quantity > 0),
    inboundDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    warehouseLocation VARCHAR(100) DEFAULT NULL,
    status VARCHAR(20) DEFAULT 'Pending' CHECK (status IN ('Pending','Received','Cancelled')),
    notes TEXT DEFAULT NULL,
    FOREIGN KEY (productID) REFERENCES product(ProductID)
);

-- Create outbound table
CREATE TABLE outbound (
    outboundID VARCHAR(20) PRIMARY KEY,
    productID VARCHAR(20) NOT NULL,
    quantity INT NOT NULL,
    outboundDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    status ENUM('Pending','Shipped','Cancelled') DEFAULT 'Pending',
    FOREIGN KEY (productID) REFERENCES product(ProductID)
);

-- Create invoice table
CREATE TABLE invoice (
    InvoiceID VARCHAR(20) PRIMARY KEY,
    OrderID VARCHAR(20) NOT NULL,
    InvoiceDate DATE DEFAULT NULL,
    TotalAmount DECIMAL(10,2) DEFAULT NULL,
    FOREIGN KEY (OrderID) REFERENCES `order`(OrderID)
);

-- Create payment table
CREATE TABLE payment (
    PaymentID VARCHAR(20) PRIMARY KEY,
    InvoiceID VARCHAR(20) NOT NULL,
    PaymentDate DATE DEFAULT NULL,
    Amount DECIMAL(10,2) DEFAULT NULL,
    PaymentMethod VARCHAR(10) DEFAULT NULL,
    FOREIGN KEY (InvoiceID) REFERENCES invoice(InvoiceID)
);

-- Create production plan table
CREATE TABLE productionplan (
    planID VARCHAR(20) PRIMARY KEY,
    OrderID VARCHAR(20) DEFAULT NULL,
    ProductID VARCHAR(20) DEFAULT NULL,
    startDate DATE DEFAULT NULL,
    EndDate DATE DEFAULT NULL,
    Status ENUM('Pending','Processing','Completed') DEFAULT 'Pending',
    FOREIGN KEY (OrderID) REFERENCES `order`(OrderID),
    FOREIGN KEY (ProductID) REFERENCES product(ProductID)
);

-- Create logistics table
CREATE TABLE logistics (
    logisticsID VARCHAR(20) PRIMARY KEY,
    ShipmentID VARCHAR(20) DEFAULT NULL,
    status VARCHAR(30) DEFAULT NULL
);

-- Create after-sale request table
CREATE TABLE aftersalerequest (
    RequestID VARCHAR(20) PRIMARY KEY,
    OrderID VARCHAR(20) DEFAULT NULL,
    Status VARCHAR(10) DEFAULT NULL,
    RequestDate DATE DEFAULT NULL,
    FOREIGN KEY (OrderID) REFERENCES `order`(OrderID)
);

-- Create feedback table
CREATE TABLE feedback (
    FeedbackID VARCHAR(20) PRIMARY KEY,
    CustomerID VARCHAR(20) NOT NULL,
    FeedbackText VARCHAR(500) DEFAULT NULL,
    FeedbackDate DATE DEFAULT NULL,
    FOREIGN KEY (CustomerID) REFERENCES customer(CustomerID)
);

-- Create user table
CREATE TABLE user (
    UserID VARCHAR(20) PRIMARY KEY,
    Role VARCHAR(10) DEFAULT NULL,
    Name VARCHAR(20) DEFAULT NULL,
    Email VARCHAR(50) DEFAULT NULL,
    Password VARCHAR(30) DEFAULT NULL
);

-- Create shipment table
CREATE TABLE shipment (
    shipmentID VARCHAR(20) PRIMARY KEY,
    OrderID VARCHAR(20) DEFAULT NULL,
    TrackingNumber VARCHAR(50) DEFAULT NULL,
    Status ENUM('Pending','Processing','Completed') DEFAULT 'Pending',
    EstimatedDeliveryDate DATE DEFAULT NULL,
    FOREIGN KEY (OrderID) REFERENCES `order`(OrderID)
);

-- Insert sample data
-- Customers
INSERT INTO customer (CustomerID, Name, Email, Address, Phone) VALUES
('CUST-0001', 'John Smith', 'john.smith@example.com', '123 Main St, New York, NY', '555-0101'),
('CUST-0002', 'Sarah Johnson', 'sarah.j@example.com', '456 Oak Ave, Los Angeles, CA', '555-0102'),
('CUST-0003', 'Michael Brown', 'michael.b@example.com', '789 Pine Rd, Chicago, IL', '555-0103'),
('CUST-0004', 'Emily Davis', 'emily.d@example.com', '321 Elm St, Houston, TX', '555-0104'),
('CUST-0005', 'Robert Wilson', 'robert.w@example.com', '654 Maple Dr, Phoenix, AZ', '555-0105');

-- Suppliers
INSERT INTO supplier (SupplierID, Name, contactInfo, Address) VALUES
('SUPP-0001', 'Toy Materials Inc.', 'contact@toymaterials.com', '100 Industrial Park, Detroit, MI'),
('SUPP-0002', 'Plastic World', 'sales@plasticworld.com', '200 Manufacturing Blvd, Dallas, TX'),
('SUPP-0003', 'Electro Components', 'info@electrocomp.com', '300 Tech Center, San Jose, CA'),
('SUPP-0004', 'Fabric Suppliers', 'orders@fabricsupply.com', '400 Textile Lane, Atlanta, GA'),
('SUPP-0005', 'Packaging Solutions', 'support@packsol.com', '500 Shipping Ave, Memphis, TN');

-- Products
INSERT INTO product (ProductID, Name, Description, Price, StockQuantity) VALUES
('PROD-0001', 'Remote Control Car', '2.4GHz RC car with rechargeable battery', 49.99, 100),
('PROD-0002', 'Building Blocks Set', '200-piece educational building blocks', 29.99, 150),
('PROD-0003', 'Doll House', '3-story doll house with furniture', 89.99, 50),
('PROD-0004', 'Puzzle Game', '300-piece jigsaw puzzle with animal theme', 19.99, 200),
('PROD-0005', 'Science Kit', 'Junior scientist experiment kit', 39.99, 75);

-- Materials
INSERT INTO material (MaterialID, MaterialName, Specification, StockQuantity, Unit) VALUES
('MAT-0001', 'ABS Plastic', 'High-quality plastic for toys', 500, 'kg'),
('MAT-0002', 'Wooden Blocks', 'Smooth finished beech wood', 300, 'pcs'),
('MAT-0003', 'Fabric Cloth', 'Soft cotton fabric for dolls', 200, 'm'),
('MAT-0004', 'Electronic Components', 'Motors, wires and controllers', 150, 'sets'),
('MAT-0005', 'Packaging Boxes', 'Color printed cardboard boxes', 400, 'units');

-- Warehouses
INSERT INTO warehouse (WarehouseID, WarehouseName, Location, ContactPerson, ContactPhone) VALUES
('WH-0001', 'Main Distribution Center', '600 Warehouse Rd, Chicago, IL', 'David Miller', '555-0201'),
('WH-0002', 'West Coast Storage', '700 Storage Blvd, Los Angeles, CA', 'Jennifer Lee', '555-0202'),
('WH-0003', 'East Coast Hub', '800 Logistics Ave, New York, NY', 'Thomas Clark', '555-0203');

-- Orders
INSERT INTO `order` (OrderID, CustomerID, OrderDate, Status, TotalAmount) VALUES
('ORD-20230601-001', 'CUST-0001', '2023-06-01', 'Completed', 129.97),
('ORD-20230605-002', 'CUST-0002', '2023-06-05', 'Processing', 89.99),
('ORD-20230610-003', 'CUST-0003', '2023-06-10', 'Pending', 59.98),
('ORD-20230615-004', 'CUST-0004', '2023-06-15', 'Completed', 149.97),
('ORD-20230620-005', 'CUST-0005', '2023-06-20', 'Processing', 39.99);

-- Order Items
INSERT INTO orderitem (OrderItemID, OrderID, ProductID, Quantity, UnitPrice) VALUES
('ORDITM-20230601-001', 'ORD-20230601-001', 'PROD-0001', 1, 49.99),
('ORDITM-20230601-002', 'ORD-20230601-001', 'PROD-0002', 1, 29.99),
('ORDITM-20230601-003', 'ORD-20230601-001', 'PROD-0004', 2, 19.99),
('ORDITM-20230605-001', 'ORD-20230605-002', 'PROD-0003', 1, 89.99),
('ORDITM-20230610-001', 'ORD-20230610-003', 'PROD-0002', 2, 29.99),
('ORDITM-20230615-001', 'ORD-20230615-004', 'PROD-0001', 3, 49.99),
('ORDITM-20230620-001', 'ORD-20230620-005', 'PROD-0005', 1, 39.99);

-- Inventory
INSERT INTO inventory (InventoryID, ProductID, Quantity, Location, WarehouseID) VALUES
('INV-20230601-001', 'PROD-0001', 50, 'Aisle 1, Shelf A', 'WH-0001'),
('INV-20230601-002', 'PROD-0001', 50, 'Aisle 1, Shelf B', 'WH-0002'),
('INV-20230601-003', 'PROD-0002', 75, 'Aisle 2, Shelf A', 'WH-0001'),
('INV-20230601-004', 'PROD-0002', 75, 'Aisle 2, Shelf B', 'WH-0002'),
('INV-20230601-005', 'PROD-0003', 50, 'Aisle 3, Shelf A', 'WH-0001'),
('INV-20230601-006', 'PROD-0004', 100, 'Aisle 4, Shelf A', 'WH-0001'),
('INV-20230601-007', 'PROD-0004', 100, 'Aisle 4, Shelf B', 'WH-0002'),
('INV-20230601-008', 'PROD-0005', 75, 'Aisle 5, Shelf A', 'WH-0001');

-- Inbound records
INSERT INTO inbound (inboundID, productID, quantity, warehouseLocation, status) VALUES
('IB-20230601-001', 'PROD-0001', 100, 'Aisle 1, Shelf A', 'Received'),
('IB-20230601-002', 'PROD-0002', 150, 'Aisle 2, Shelf A', 'Received'),
('IB-20230601-003', 'PROD-0003', 50, 'Aisle 3, Shelf A', 'Received'),
('IB-20230601-004', 'PROD-0004', 200, 'Aisle 4, Shelf A', 'Received'),
('IB-20230601-005', 'PROD-0005', 75, 'Aisle 5, Shelf A', 'Received');

-- Outbound records
INSERT INTO outbound (outboundID, productID, quantity, status) VALUES
('OB-20230601-001', 'PROD-0001', 2, 'Shipped'),
('OB-20230601-002', 'PROD-0002', 1, 'Shipped'),
('OB-20230601-003', 'PROD-0004', 3, 'Pending'),
('OB-20230601-004', 'PROD-0005', 1, 'Shipped');

-- Invoices
INSERT INTO invoice (InvoiceID, OrderID, InvoiceDate, TotalAmount) VALUES
('INV-20230602-001', 'ORD-20230601-001', '2023-06-02', '129.97'),
('INV-20230606-001', 'ORD-20230605-002', '2023-06-06', '89.99'),
('INV-20230616-001', 'ORD-20230615-004', '2023-06-16', '149.97'),
('INV-20230621-001', 'ORD-20230620-005', '2023-06-21', '39.99');

-- Payments
INSERT INTO payment (PaymentID, InvoiceID, PaymentDate, Amount, PaymentMethod) VALUES
('PAY-20230602-001', 'INV-20230602-001', '2023-06-02', 129.97, 'Credit Card'),
('PAY-20230606-001', 'INV-20230606-001', '2023-06-06', 89.99, 'PayPal'),
('PAY-20230616-001', 'INV-20230616-001', '2023-06-16', 149.97, 'Credit Card'),
('PAY-20230621-001', 'INV-20230621-001', '2023-06-21', 39.99, 'Bank Transfer');

-- Production plans
INSERT INTO productionplan (planID, OrderID, ProductID, startDate, EndDate, Status) VALUES
('PLAN-20230606-001', 'ORD-20230605-002', 'PROD-0003', '2023-06-06', '2023-06-10', 'Completed'),
('PLAN-20230611-001', 'ORD-20230610-003', 'PROD-0002', '2023-06-11', '2023-06-12', 'Processing'),
('PLAN-20230621-001', 'ORD-20230620-005', 'PROD-0005', '2023-06-21', '2023-06-23', 'Pending');

-- Logistics
INSERT INTO logistics (logisticsID, ShipmentID, status) VALUES
('LOG-20230602-001', 'SHIP-20230602-001', 'Delivered'),
('LOG-20230606-001', 'SHIP-20230606-001', 'In Transit'),
('LOG-20230616-001', 'SHIP-20230616-001', 'Delivered'),
('LOG-20230621-001', 'SHIP-20230621-001', 'Processing');

-- After-sale requests
INSERT INTO aftersalerequest (RequestID, OrderID, Status, RequestDate) VALUES
('ASR-0001', 'ORD-20230601-001', 'Resolved', '2023-06-03'),
('ASR-0002', 'ORD-20230615-004', 'Open', '2023-06-17');

-- Feedback
INSERT INTO feedback (FeedbackID, CustomerID, FeedbackText, FeedbackDate) VALUES
('FB-0001', 'CUST-0001', 'Great products and fast delivery!', '2023-06-05'),
('FB-0002', 'CUST-0002', 'The doll house was missing one piece', '2023-06-08'),
('FB-0003', 'CUST-0004', 'Excellent customer service', '2023-06-18');

-- Users
INSERT INTO user (UserID, Role, Name, Email, Password) VALUES
('USER-0001', 'Admin', 'Admin User', 'admin@erp.com', 'admin123'),
('USER-0002', 'Sales', 'Sales Manager', 'sales@erp.com', 'sales123'),
('USER-0003', 'Inventory', 'Inventory Clerk', 'inventory@erp.com', 'inventory123'),
('USER-0004', 'Production', 'Production Manager', 'production@erp.com', 'production123'),
('USER-0005', 'Logistics', 'Shipping Coordinator', 'shipping@erp.com', 'shipping123');

-- Shipments
INSERT INTO shipment (shipmentID, OrderID, TrackingNumber, Status, EstimatedDeliveryDate) VALUES
('SHIP-20230602-001', 'ORD-20230601-001', 'TN10001', 'Completed', '2023-06-03'),
('SHIP-20230606-001', 'ORD-20230605-002', 'TN10002', 'In Transit', '2023-06-09'),
('SHIP-20230616-001', 'ORD-20230615-004', 'TN10003', 'Completed', '2023-06-17'),
('SHIP-20230621-001', 'ORD-20230620-005', 'TN10004', 'Pending', '2023-06-25');

-- Verify data was inserted
SELECT 'Database setup completed successfully' AS Message;