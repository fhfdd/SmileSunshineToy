-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- 主机： 127.0.0.1
-- 生成日期： 2025-06-25 16:33:37
-- 服务器版本： 10.4.32-MariaDB
-- PHP 版本： 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 数据库： `test`
--

-- --------------------------------------------------------

--
-- 表的结构 `aftersalerequest`
--

CREATE TABLE `aftersalerequest` (
  `RequestID` int(11) NOT NULL,
  `OrderID` int(11) DEFAULT NULL,
  `Status` varchar(10) DEFAULT NULL,
  `RequestDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `aftersalerequest`
--

INSERT INTO `aftersalerequest` (`RequestID`, `OrderID`, `Status`, `RequestDate`) VALUES
(1, 1, 'Approved', '2025-05-14'),
(2, 3, 'For Review', '2025-05-21'),
(3, 5, 'Refunded', '2025-06-01');

-- --------------------------------------------------------

--
-- 表的结构 `cschat`
--

CREATE TABLE `cschat` (
  `ChatID` int(11) NOT NULL,
  `CustomerID` int(11) NOT NULL,
  `Message` varchar(1000) DEFAULT NULL,
  `Response` varchar(100) DEFAULT NULL,
  `Timestamp` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `cschat`
--

INSERT INTO `cschat` (`ChatID`, `CustomerID`, `Message`, `Response`, `Timestamp`) VALUES
(1, 1, 'I received my toy, but it was missing a piece. Can you help?', 'We apologize for the inconvenience! We’ll send the missing piece right away.', '2025-06-01 10:04:07'),
(2, 7, 'Do you have any updates on my order status?', 'Your order is currently being processed and will be shipped soon.', '2025-05-31 09:23:04'),
(3, 9, 'Is there a warranty on your products?', 'Yes, our toys come with a one-year warranty against defects.', '2025-06-03 11:45:26');

-- --------------------------------------------------------

--
-- 表的结构 `customer`
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
-- 转存表中的数据 `customer`
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
-- 表的结构 `feedback`
--

CREATE TABLE `feedback` (
  `FeedbackID` int(11) NOT NULL,
  `CustomerID` int(11) NOT NULL,
  `FeedbackText` varchar(500) DEFAULT NULL,
  `FeedbackDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `feedback`
--

INSERT INTO `feedback` (`FeedbackID`, `CustomerID`, `FeedbackText`, `FeedbackDate`) VALUES
(1, 10, 'Excellent value for money! Would definitely recommend to friends.', '2025-04-16'),
(2, 8, 'The assembly instructions were unclear, but once I figured it out, my daughter loved it!', '2025-04-08'),
(3, 5, 'The toy is well-made, but I wish there were more color options available.', '2025-05-30'),
(4, 4, 'My son loves the new action figures! Great quality and detail.', '2025-04-16');

-- --------------------------------------------------------

--
-- 表的结构 `idsequence`
--

CREATE TABLE `idsequence` (
  `Prefix` varchar(10) NOT NULL,
  `CurrentNumber` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `idsequence`
--

INSERT INTO `idsequence` (`Prefix`, `CurrentNumber`) VALUES
('01', 2);

-- --------------------------------------------------------

--
-- 表的结构 `inventory`
--

CREATE TABLE `inventory` (
  `InventoryID` int(11) NOT NULL,
  `ProductID` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL DEFAULT 0,
  `Location` varchar(50) DEFAULT NULL,
  `WarehouseID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `inventory`
--

INSERT INTO `inventory` (`InventoryID`, `ProductID`, `Quantity`, `Location`, `WarehouseID`) VALUES
(1, 1, 150, 'Aisle 3', 1),
(2, 1, 80, 'B201', 2),
(3, 2, 200, 'Aisle 5', 1);

-- --------------------------------------------------------

--
-- 表的结构 `invoice`
--

CREATE TABLE `invoice` (
  `InvoiceID` int(11) NOT NULL,
  `OrderID` int(11) NOT NULL,
  `InvoiceDate` date DEFAULT NULL,
  `TotalAmount` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `invoice`
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
-- 表的结构 `logistics`
--

CREATE TABLE `logistics` (
  `logisticsID` int(11) NOT NULL,
  `ShipmentID` int(11) DEFAULT NULL,
  `status` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `logistics`
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
-- 表的结构 `material`
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
-- 转存表中的数据 `material`
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
-- 表的结构 `order`
--

CREATE TABLE `order` (
  `OrderID` int(11) NOT NULL,
  `CustomerID` int(11) NOT NULL,
  `OrderDate` date NOT NULL,
  `Status` enum('Pending','Processing','Completed') DEFAULT 'Pending',
  `TotalAmount` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `order`
--

INSERT INTO `order` (`OrderID`, `CustomerID`, `OrderDate`, `Status`, `TotalAmount`) VALUES
(1, 1, '2025-06-03', 'Completed', 1999.99),
(3, 4, '2025-05-25', 'Completed', 2500.00),
(4, 5, '2025-04-25', 'Pending', 800.00),
(5, 6, '2025-05-15', 'Completed', 550.00),
(8, 7, '2025-03-25', 'Pending', 649.50),
(9, 8, '2025-05-18', 'Completed', 1899.00),
(10, 9, '2025-05-07', 'Pending', 1300.00),
(11, 10, '2025-06-02', 'Completed', 999.00);

--
-- 触发器 `order`
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
-- 表的结构 `ordersequence`
--

CREATE TABLE `ordersequence` (
  `OrderDate` date NOT NULL,
  `CurrentNumber` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `ordersequence`
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
-- 表的结构 `payment`
--

CREATE TABLE `payment` (
  `PaymentID` int(11) NOT NULL,
  `InvoiceID` int(11) NOT NULL,
  `PaymentDate` date DEFAULT NULL,
  `Amount` decimal(10,2) DEFAULT NULL,
  `PaymentMethod` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `payment`
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
-- 表的结构 `product`
--

CREATE TABLE `product` (
  `ProductID` int(11) NOT NULL,
  `Name` varchar(30) NOT NULL,
  `Description` varchar(500) DEFAULT NULL,
  `Price` decimal(10,2) NOT NULL,
  `StockQuantity` int(11) NOT NULL DEFAULT 0,
  `image_data` longblob DEFAULT NULL,
  `image_type` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `product`
--

INSERT INTO `product` (`ProductID`, `Name`, `Description`, `Price`, `StockQuantity`, `image_data`, `image_type`) VALUES
(1, 'Remote Control Car', '2.4GHz Model', 99.99, 200, NULL, NULL),
(2, 'Smart Building Blocks', 'STEM Learning Kit', 149.99, 300, 0xffd8ffe000104a46494600010101006000600000ffe100c64578696600004d4d002a000000080007013200020000001400000062013e00050000000200000076013f000500000006000000860301000500000001000000b651100001000000010100000051110004000000010000000051120004000000010000000000000000323032343a30333a30372030313a35393a32350000007a26000186a000008084000186a00000fa00000186a0000080e8000186a000007530000186a00000ea60000186a000003a98000186a000001770000186a0000186a00000b18fffdb0043000302020302020303030304030304050805050404050a070706080c0a0c0c0b0a0b0b0d0e12100d0e110e0b0b1016101113141515150c0f171816141812141514ffdb00430103040405040509050509140d0b0d1414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414ffc00011080078007803012200021101031101ffc4001f0000010501010101010100000000000000000102030405060708090a0bffc400b5100002010303020403050504040000017d01020300041105122131410613516107227114328191a1082342b1c11552d1f02433627282090a161718191a25262728292a3435363738393a434445464748494a535455565758595a636465666768696a737475767778797a838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae1e2e3e4e5e6e7e8e9eaf1f2f3f4f5f6f7f8f9faffc4001f0100030101010101010101010000000000000102030405060708090a0bffc400b51100020102040403040705040400010277000102031104052131061241510761711322328108144291a1b1c109233352f0156272d10a162434e125f11718191a262728292a35363738393a434445464748494a535455565758595a636465666768696a737475767778797a82838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae2e3e4e5e6e7e8e9eaf2f3f4f5f6f7f8f9faffda000c03010002110311003f00fcaaa28a2800a28af4ef827fb3d78afe38eab126916ad6da225cadbde6b12ae62b73b4b901720c8db47dd5e85d37150c0d72e2b1543054655f1335184776ff00afb96ece8c3e1eae2aa2a3422e527d17f5f8f43cc6ba8f077c2df17fc41784786fc33aa6b31cb702d45c5adabb40b27cbf2bcb8d898dea4962000c0920735fa71f03ff00609f01f83b4b58f53d0e1f16eb3384f36fb578fce0bc2ee48a0ff56a8586e0595a41f777e0907eccf0e7c189dd5649e35b7079265fbc7f0afc9f13e20fd62abc3e4985957977d525dbe5ead7f97d5ff6052c2c79b30aca2fb2d5fdff00e499f8c9e16ff827d7c61f1109cdd699a7787fcb2a13fb4afd5bcdceec95f204b8db819dd8fbc319e71d2ffc3b33e2aedcff006af85fe9f6ab9ffe47afdafb0f859a6db20f365673feca802b47fe15e68fb71b24faee1fe1582cc78dabfbea9528795d7f9cbf3317fd8b0f754652f3bffc05f91f835e2aff00827dfc60f0dac0d6ba669de201217dff00d997caa62c6dc16f3c459dd938db9fba738e33e3be3ff841e34f85d79716fe29f0ddfe90219c5b9b9923df6cf21048549d331c990ac46d639da7d0d7f46f7df0b34cb953e5caf19ff694115c3f88fe0b4caad25b2a5c6391e5f0c3f0a4f89f8a32cd71f818d48aeb07afe0e5ff00a496b0793e29da9d49536fbeabf4fccfe7468afd5ef8dffb01f817c5f6f31b0d257c25ab4519486e34885618c101f6892000238dce09c05721540702bf3c7e377ecefe2cf819aa48babda9b9d0e4b96b7b3d66103cab8c286019724c6fb49f95ba947da5c296afb3c8f8bf2ccf5fb2a32e4a9fcb2d1fcba3f4dfc8e0c7e478ac0c3db2b4e9ff00347a7aadd7e5e6797d14515f6e7cf05145140051457a87ecf7f04aebe3878dc699e64b69a45a2acfa85d449960858288d091b448d938ddd151d806dbb4f262f17470342789c44ad08abb674e1b0f57175a3428abca4ec8ef7f654fd94eefe32ea106bfaf4725b783e19481182c926a2ea7944239110390ce0e720aae0ee64fd64f85df0a50db5a59d9db476961691ac31aa2058a08c744451c0007451c0ac8f857e00b78e3b5b3b4b68ecece045458a140b1c3181855551c00000001c0007a57d19a3c3069d6b1c10208e3418007f3afe61c7e635f8bf1bf58c53e4c3c348c53dffe0bfb4fe4acb6fd46aaa5c3f87faae135a8fe297f5d1745f37e77f40f0e58787a155b6881931ccae3e63fe15b426ae2fc7bf11b43f867e18bbf107886f92c74cb55dd24adfc80ea49f415a1e14f1658f8c7c39a76b9a64a66d3f50816e2de4231b918641c1e95f6982c551c25254e845460bb2d3fe1ff0013e0eac6a557ed2a36efd4ea1661eb4ef3bdc56689e9de7fbd7b71cd95b7395d22eb4def51b4d550cfef5cff008ebc6f61f0ff00c23aaf88f542e34ed3606b89cc6bb9b68eb81deb9ea66bcda265c68b6ec8d5d7741b0f105bb47771296c61645e197f1af9ebe2afc2081ade686f2ce0d42c26564226883c6eaca5595948239566041e082477af64f879f13343f8a5e14b3f10f87ef16ef4eba5dcac38653dd587623b8ad1d5522bdb7921990491b8c329ef5f0b9be0f0f9849d58fb9597da5a7ca5dff35f81f4995e3f119754e5de3d51f853fb557ec9b71f06e6bbf12682fe7f84a4b848fec8dbde7b067ddc33608308202abb36ecbaa9c9f99be6dafddcf8bbf0ea1b9b4beb1963596ceee1788ef8d640c8c082a558156e0e086041ee08e2bf1f7f698f82cdf057e21c9656cb23685a82b5d69eecad88d3790602c73b9938ee4ed642705b15fa3705713d5cc94b2dcc1fefe1b5f7925f9b5bdef76b5e8d939fe4f4a9538e63825fbb96ebf95bfd1fe0f4ea792d14515fab1f0c15faa1fb21fc239fe1afc36d334dbf8160d5e767bbd4238e5f317cf763b79e9b96211210bf2e50e3392cdf9ebfb3b7862ebc55f1abc2105ba131daea10dfdcc814b08e085c48e78ee42ed19c02cca0919cd7ebe7c39b450d133738f9893c935f87f895984d428e5b0d14bde7f8a5f2ddfaa5d8fd3b83b0d1842b63e5baf757e6fe7b7cbd4f69f09da2693a7c68000edf339f7ab3e30f89da07c39d166d4f5ed4a1b1b68d73fbc6f998fa01d49f615e6ff13478fef7c3d0c3f0f5f4b8f537936cd26a729411c78fbcbc609cf635e3165fb1ef88bc5faa0d6be2a78f92e923f9de0b2632151dc06601107b806bf3ac1aa11a51752aa84174de5f779f763c4c2352a39547a9ca78cfc5be29fdb7fe23d8f86f47b79ac7c276d28721c1db1c79c19e5ed9c676afbd7e82f86f47b4f0af87f4dd174f5d963a7db476b0affb28a00fe55f38783be2ef827c05652786fe17783f57f14476efb6e24d06cdae03c838cc939e19bf1ad19ff6c1d23c2dabc5a778dbc33aff00826497ee4bab59958c8f5dc32315ef6230b9ad7a51961b09354a3b68eefcedb9e157ad4a6d414924ba5d1f4889f1de97ed1ef5ce683e2ad3bc4ba641a86997915f59ccbba39a170cac3d88ad1fb58c75af92799ce0f965b997b17d8d133e7bd65f89b46b2f16787b53d13528c4b61a85bbdb4e9ea8c083fceaaeb1e23b1d0b4f9afb50b98ed2d2152f24d33055503b926bc6e4fda8edb5e99d7c1be10f1278d6dd58a9bcd2ac19adc91e923601fc2bd0c13c7e633b60e9ca6d7657b7abd912e11a7acdd8f99f47d5fc69fb0dfc43b9d2ee6de5d4fc21792975519f2ee23cf12c67a0703ef2ff00faebec9f87df1bbc2df157488ef742d52299881e65bb3012c47d194f20d792eb5fb4b780bc59349e10f895e18bff000eb4cc17ec9e24b3312827a32bff0009f4606b8fd6ff0062ad1e6be5d77e1ef8def3c38f27cf107065400f231221048fa835ed631b8c9473184a8557d5a7cb2febc8f569ce9621733d5f75a9f4c789eda3d5b4f92160338ca9f435f187ed59f0aee3e247c35d6b43b58a393505537762b305f96e23c3610b10159c298b76471277e87e8bf861e1af177837c3f3d978bfc536de28baf33fd1ee2da068ca478e8c4fde39f6ae6fe23db0def226558fcc08e0835f2353132c1e3a9e2e8493941ad56cedaaedfd687d9e574e35a8d4c254f8269afbf43f0e28af4bfda47c2b3f84be35f8aa0996411deddb6a503c91140c939f370b9fbc15999370ea50f03a02bfafb0b888e2f0f4f110da693fbd5cfc531342586ad3a13de2dafb9d8f5cfd81f4c897c57e2ad685dcd6d7b6d67158c4b1b10b224ecc6407033d210392060b039c8afd24f03b88a153ec2bf38bf60f70b73e30cff7ac7ff6e2bf447c1d30f25067b57f33f1eca4f3aa8df4e55ff92a7f9b67ecbc3f14b26a76ebcd7ffc09a3d42cee3815e37afdddd7ed17fb43d9fc19b0bf96cbc35a55a0d57c533db3ed9268f2365aab0e9b891b8fa1af56b27ca8afcf3d17f699bffd923f6f9f1df89355d3e7d5b44d4a56b5bfb68ce25fb338464923cf04a951c771915d3c0197d2c76692ab5d5d538f325e77493f97e763e6f886aca85051869ccedf23f67bc33e17d23c1ba25ae91a1e9d6fa56996a82386d6d63088807b0fe75f24ff00c1537c69a5f823f67fd3aeae16093579b58862b28a400bb8dac65c7b6debf8563f89ff00e0af7f04f4bd0fed5a35bf8835fd4993725825879186c74677381f519af873e36681fb48fedeb677bf169bc25243e08d2a199b4cb1499638e281725da25621a56f97e67c738c0e98afe993f36347f638fdacdbc05f1434fd0e799e1f0aebb3adbcb6923652d2e18e1644f4527008f7afd53177919cfeb5fced78463d4350f1468f6b681cdd4d7b0a44107cdbf78c63f1afe82ec99e3d2edd5c9320854313dced19afe72f12f2ea586c550c652569554d4bcdc6dafaeb67e88fabca26eac25097d93c47c33683f6bafda375ff000edfcecff0d7c00d10bfb146c2ea97ed92b1c98eb1a60923b915f7169fa75ae93650da595b45696b0a848e081022228e8001c015f8bffb327ed8e3f63ffda3fe2869fe31d3aeeffc35aeea923ddc96abba7b6955d8a4a14fde52ad823af422beb6f88fff000582f84ba0e8933f83f4dd6bc57ab98c986192d4da40ad8e37bb9ce3d7009afdd328cba8e5581a785a0aca295fcdf56fcdb3e72bd5956a8e72307fe0addf1074af05d8fc3f83cab7bad62ee5b9f320600b1b60abcb0f4dc78f7cd781fec31fb51baf8cd7e1fea37323e91a8866d2fce7dc6de50326204ff0919c0ec4578efed07f0abf68ff008efa0ea9fb4078dfc39347a03c0b34799163fb2d9e7e4f2e027708c673923273935e23fb3e1d4e7f8e1e034b0dc2e8eb36db0a8e701c6eff00c7735cf9fe5d4733cbab50acba369f66968d7f5b686d82af2c3d784e3df5f347ee1dddc641e6bcfbc6efe6dbb7b66bb4be60037a579f78c26fdc38cf6afe3abbd11fb8e0e3cb24d1f9c9fb7ae89636fe25f09eaf6f24e6f2ead2e2d2e23915446be54a1d766324e44e724e3d00e32c55afdbcdb75c7837fdebeffdb7a2bfadf846529649877277f8bf094923f26e258a8e6d592f2fc629997fb0c6ac8be27f1468e96935d5e5cd9c77b1b46a488d2066f318e0e785973c820286271806bf433c197a1a28f9afc94f80fe23baf0cfc5cf0bcf6cc425cdf4565711ee20490cae11c1c1e480db8672032a9c1c62bf50fc11aae15149c62bf26f10b03c98f55d7db8a7f35a7e49763ee785b10eae5ee93fb0daf93d7f36cf75d36e0328e6be5efdb2ff0064ebbf8b5710f8b7c2b02cde26b58b64965900df4439d8a7a798bc9507a8247a57d0fa45e8645e6ba5b5b80ea037cc3debe2b86b3b9e498d5884aead692ee9feab7474e6d97ac75174f67baf53f1827f0849a7de4d677b692d95e42c525b6b88cc7246c3a8653c835f52597edddf12b49f8096df0b34db5d2eceda2b0feca4d5608dbed5f67236ed0b9dbb8a9c6ec67f1afbe3c43e10f0a78e427fc24de19d275e9146d59afed55e503d37fdefd6a3f0e7c34f02f83ae45cf87fc1ba269574bcadc4166ad2afd19b247e15fd0d1e33c91d2f6aeb5bcaceff0097ea7e652c9b1b1972f27ceeac7c55fb187ec557f61e22d3fe2078cac1f4e82dc799a4e9772bb667623fe3e2453ca803ee83c9273dabf41c4807d2aab5c19199998b331c966e49a4f378eb5f8271567af88718aa4636a70568a7bf9b7e6ff248faecbf2ffa9d3b4b593dcf86bf6cefd8f350f18f8826f1a783ac8df6aaa9fe9ba6443f797708e92443f8a44e857a91823a57c48be19fb35c347242d05c44d868a54dae8c0f42a7907d8d7edec8cb201bbaa9dc08e0a9f507b560f89fc03e0df1bca26f12785346d6ee3183737768be71fab8c13f8d7eabc3bc6f839616187cca5c952292e6b36a56d9e97b3eff0079f3f8ec96b2a8e787574fa7547c09f173f6e7f895f197e1145f0dee2cb4eb0b1b9863b4bb974d89cdc5ea2e0040b92141c0c851cf4aee7f632fd8f2f7e1feab178ffc63666c7543111a5e9530fde5bab0e66947f0b11c2af50324f5afaefc3de04f06781e5f3bc37e13d1b45b81d2e2d6d17cd1f473923f0ab57b785cb316249ea49eb59712f1ae11e12785cba5cd29ab3959a493ded7dddbeedceacaf23aceb46ae21592d6ddca7a95c00a466bcd3c657a1627e6bb2d5af42a3735e4be36d50b06453b98f000ef5f80d18fb5aabb1fab5085ac8f83ff006dad6d6ebc51a069658bcb6f14d76088f6aac729440b9dc4b36e82424e146194738268af2ef8ff00e279fc53f177c493ca6411da5cb58431bc85c22427cbf973f74332b3ed1d0b9ebd495fd8b9261de172da1465ba8afc75e9ebbf5dcfc3b38c42c56615aaad9bfcb4fd0f3dafd12fd9b3e27cfe3cf0169fa95e4c936a70bbdadf3c71f96be6a9e0e3a64c66363b78cb1c63181f9db5e81f053e2c5c7c25f167db8c725d69974a21bdb68df04a6e043a8276975e719eccc32bbb70f2f89f2779c605c29afde4358f9f75f3fcd23bb20cc965d8afde3f727a3f2ecfe5f9367eb8786f5959635f9abb5b1bf0c0735e01e0ff001443736f04f6f709716f2a2bc7344c192452321948e0823041ef5ea5a3eb42445f9b9fad7f2ae230d2a73763f63944f4682ec1039cd5c8ee01e86b92b5d4320735a315ff004e6b18d6b6924724e85f63a259b1de9de7d7ceff00b4e7ed1b3fc0ed074ffb059addea9a933ac06524468140dcc7d7a8e2be4e6fdb1fe2f5c487518ee40b4073f258130ffdf5ff00d7afb0cbf87b179950588a4928bd9b7bfe678988c4d0c34f92a3d4fd3769bdea192703a9af997f65afda8afbe3549a8e91ac59c706ad63089ccd6f9f2e442719c7639ed5efd2dffbd7838fc3d4cb6bcb0f5e36923bf0f18d7829d3774684f74003ce2b1ef6fb683cd56bad43af35cdeafacac4adf35793795676e87a51a6a241e23d64451b7cd5f37fed0df10eebc07f0ef55d7a0c4770e1ad2c6497680f70d85f937021d915fcc2b83c2f380735e8de33f1543676973733ccb1410c6d24923b855550324924800003a9200afce3f8ff00f1513e2a78dbed366651a458c66dad03b10241b8969761fba5b8f7c2ae7a71fa5f08e412cc714a735fbb859cafd7b47e7f95fc8f233acc9659857caff793ba8f979fcbf33cce8a28afe983f120a28a2803dbbf67ff00da1e7f8672c1a26ae0cde1c92666f3c6e696cd9b1ca8c9063c824a819cb330c9f95bef8f0b78be1bdb5b6b882759ade78c4b14b1b064910f46523820f622bf266bb9f861f18b5ff8597e8da74e66d2de6135ce9b21fddcdf2953838251b07a8eeab90c140afce388f84a9e68de270b68d4eaba4bfc9fe0fadb73ee326e227838ac362d7343a3eb1ff35f8af3d8fd6ed33c401d47cd5bf6fab2b0ebfad7c5ff000d7f6b5f0b7892dd16f6f9742be54ccb06a2e234c80b9d9213b5865881d188524a815efba7f8d633c17c11c106bf05cc325c56067c988a6e2cfd330f5e8e2e1cf879a92f23d4356d3746f12c1143ace9363abc30bf99125f40b2846f5191c1ad58f52586d85b4691c76c06d10246a2303d36e318af36b7f1646c07ef063eb567fe1298c0fbe3f3af1dd2abcaa17765b2347460e4e4e2aefc8eaf4ed3745d066ba9b4bd234fd2e6ba20cf2595b244d291d3715033525c6acaa3ad71171e2c8d41f9c7e7587a878d63190afb89e001dead61ea559734aedf9970a4a0b962ac8ed352f100453f362bcf7c57e33b6d3eda59ae6ea3b7863567792570aaaa012492780000493e82bc4be257ed6be16f0d5b32d9df26bb7ac9ba2834e90489921b1be4076a8ca80704b0dc0ed22be40f8a1f193c41f152f98ea339874b8e632db69b191e5c3c6d049c02ed8cfccdd0b36d0a0e2bf46c93833198e929d65ece1ddeff0025ff000cbccf9ccc33ec1e023683f693ecb6f9bfe99dcfed07fb4537c4c49741d1e2687428ee03b5db332c979b7a65380b1e4ee0ac0925518ed2368f0ca28afe80c06030f96d0587c346d15f8beefccfc97198dad8facebd7776ff0005d90514515e81c2145145001451450015bde19f1e788bc1b2c6da2eb379a7ac72f9c218e526167c01968ce51b8007cc0e7028a2a2708545cb3575e65c272a6f9a0ecfc8f41d13f6aaf881a42c826beb5d57715dbf6cb600a633903cbd9d72339cfdd18c739d7ff86c9f1c631f62d1bfefc4dffc768a2bc59e4595d47cd2c3c7eeb7e47ad1ce73082e555e5f7dff0033235bfdaafe206acb1086f6d34ada58b1b3b607ccce300f99bfa60e318fbc739e31e79e21f1cf887c58a1358d6af751894ab08a79d9a30cabb4304ce37633ce327249e49a28aeec3e03098456a14a31f448e4af8ec5627f8d5652f56edf76c61d14515de7085145140051451401ffd9, 'image/jpeg'),
(3, 'Arts and Crafts Kits', 'Kits containing various supplies like paints, markers, and materials for DIY projects.', 299.00, 250, NULL, NULL),
(4, 'Puzzle Sets', 'Jigsaw puzzles with 50-1000 pieces', 110.00, 140, NULL, NULL),
(5, 'Board Games', 'Interactive games designed for 2-6 players', 99.99, 100, NULL, NULL),
(6, 'Chikawai Eight', 'Premium quality Chikawai product with eight special features', 49.99, 100, NULL, 'image/jpeg');

-- --------------------------------------------------------

--
-- 表的结构 `productionplan`
--

CREATE TABLE `productionplan` (
  `planID` int(11) NOT NULL,
  `OrderID` int(11) DEFAULT NULL,
  `ProductID` int(11) DEFAULT NULL,
  `startDate` date DEFAULT NULL,
  `EndDate` date DEFAULT NULL,
  `Status` enum('Pending','Processing','Completed') DEFAULT 'Pending'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `productionplan`
--

INSERT INTO `productionplan` (`planID`, `OrderID`, `ProductID`, `startDate`, `EndDate`, `Status`) VALUES
(1, 1, 1, '2025-03-01', '2025-03-10', 'Processing'),
(2, 3, 2, '2025-03-15', '2025-03-25', 'Pending'),
(3, 4, 3, '2025-04-01', '2025-04-10', 'Completed'),
(4, 5, 4, '2025-04-11', '2025-04-20', 'Processing'),
(5, 8, 5, '2025-04-15', '2025-04-20', 'Completed'),
(6, 9, 1, '2025-04-21', '2025-04-27', 'Processing'),
(7, 3, 1, '2025-06-25', '2025-07-02', 'Pending');

-- --------------------------------------------------------

--
-- 表的结构 `returnrequest`
--

CREATE TABLE `returnrequest` (
  `ExchangeID` int(11) NOT NULL,
  `OrderID` int(11) NOT NULL,
  `ProductID` int(11) NOT NULL,
  `Status` enum('Pending','Processing','Completed') DEFAULT 'Pending',
  `UpdatedDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `returnrequest`
--

INSERT INTO `returnrequest` (`ExchangeID`, `OrderID`, `ProductID`, `Status`, `UpdatedDate`) VALUES
(3, 4, 1, 'Processing', '2025-06-01'),
(4, 8, 4, 'Completed', '2025-05-29'),
(5, 10, 2, 'Processing', '2025-05-31');

-- --------------------------------------------------------

--
-- 表的结构 `shipment`
--

CREATE TABLE `shipment` (
  `shipmentID` int(11) NOT NULL,
  `OrderID` int(11) DEFAULT NULL,
  `TrackingNumber` int(11) DEFAULT NULL,
  `Status` enum('Pending','Processing','Completed') DEFAULT 'Pending',
  `EstimatedDeliveryDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `shipment`
--

INSERT INTO `shipment` (`shipmentID`, `OrderID`, `TrackingNumber`, `Status`, `EstimatedDeliveryDate`) VALUES
(1, 1, 1, 'Processing', '2025-06-19'),
(2, 3, 2, 'Processing', '2025-06-18'),
(3, 5, 3, 'Completed', '2025-06-04'),
(4, 11, 4, 'Pending', '2025-06-24');

-- --------------------------------------------------------

--
-- 表的结构 `supplier`
--

CREATE TABLE `supplier` (
  `SuPPlierID` int(11) NOT NULL,
  `Name` varchar(20) DEFAULT NULL,
  `contactInfo` varchar(30) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `supplier`
--

INSERT INTO `supplier` (`SuPPlierID`, `Name`, `contactInfo`, `Address`) VALUES
(1, 'Toyland Supplies', '9876543', '101 Playful St, Tsim Sha Tsui, Hong Kong'),
(2, 'Happy Tots Co.', '234-5678', '202 Joy Ave, Central, Hong Kong'),
(3, 'Kiddo Creations', '345-6789', '303 Imagination Rd, Wan Chai, Hong Kong'),
(4, 'Little Dreamers Inc.', '456-7890', '404 Adventure Blvd, Mong Kok, Hong Kong');

-- --------------------------------------------------------

--
-- 表的结构 `task`
--

CREATE TABLE `task` (
  `TaskID` int(11) NOT NULL,
  `TaskName` varchar(20) DEFAULT NULL,
  `Status` enum('Pending','Processing','Completed') DEFAULT 'Pending',
  `Duedate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `task`
--

INSERT INTO `task` (`TaskID`, `TaskName`, `Status`, `Duedate`) VALUES
(1, 'Design Review', 'Pending', '2025-06-07'),
(2, 'Assembly Line Setup', 'Processing', '2025-06-08'),
(3, 'Order Fulfillment', 'Completed', '2025-06-01'),
(4, 'Packaging Design', 'Completed', '2025-06-11');

-- --------------------------------------------------------

--
-- 表的结构 `user`
--

CREATE TABLE `user` (
  `UserID` int(11) NOT NULL,
  `Role` varchar(10) DEFAULT NULL,
  `Name` varchar(20) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Password` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `user`
--

INSERT INTO `user` (`UserID`, `Role`, `Name`, `Email`, `Password`) VALUES
(1, 'Admin', 'Admin User', 'admin@example.com', 'AdminPass123'),
(2, 'Sales', 'Sales Rep', 'salesrep@example.com', 'SalesPass456'),
(3, 'Inventory', 'Inventory Clerk', 'inventory@example.com', 'InvPass789'),
(4, 'Finance', 'Finance Officer', 'finance@example.com', 'FinPass012'),
(5, 'Production', 'Production Worker', 'production@example.com', 'ProdPass345'),
(6, 'Logistics', 'Logistics Staff', 'logistics@example.com', 'LogiPass678'),
(7, 'Procuremen', 'Procurement Speciali', 'procurement@example.com', 'ProcPass901'),
(8, 'Personnel', 'HR Personnel', 'hr@example.com', 'HrPass234'),
(9, 'RD', 'RD Engineer', 'rd@example.com', 'RdPass567'),
(10, 'None', 'Guest User', 'guest@example.com', 'GuestPass890');

--
-- 触发器 `user`
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
-- 表的结构 `warehouse`
--

CREATE TABLE `warehouse` (
  `WarehouseID` int(11) NOT NULL,
  `WarehouseName` varchar(50) NOT NULL,
  `Location` varchar(100) DEFAULT NULL,
  `ContactPerson` varchar(20) DEFAULT NULL,
  `ContactPhone` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `warehouse`
--

INSERT INTO `warehouse` (`WarehouseID`, `WarehouseName`, `Location`, `ContactPerson`, `ContactPhone`) VALUES
(1, 'Main Warehouse', 'Shenzhen', 'John Smith', '+86-13800138001'),
(2, 'Branch Warehouse', 'Hong Kong', 'Alice Wong', '+852-98765432');

-- --------------------------------------------------------

--
-- 表的结构 `workorder`
--

CREATE TABLE `workorder` (
  `WorkOrderID` int(11) NOT NULL,
  `productionPlanID` int(11) DEFAULT NULL,
  `Status` enum('Pending','Processing','Completed') DEFAULT 'Pending',
  `startDate` date DEFAULT NULL,
  `EndDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 转存表中的数据 `workorder`
--

INSERT INTO `workorder` (`WorkOrderID`, `productionPlanID`, `Status`, `startDate`, `EndDate`) VALUES
(1, 1, 'Processing', '2025-04-05', '2025-04-15'),
(2, 2, 'Pending', '2025-04-20', '2025-04-30'),
(3, 3, 'Completed', '2025-05-01', '2025-05-10');

--
-- 转储表的索引
--

--
-- 表的索引 `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`CustomerID`);

--
-- 表的索引 `feedback`
--
ALTER TABLE `feedback`
  ADD PRIMARY KEY (`FeedbackID`),
  ADD KEY `CustomerID` (`CustomerID`);

--
-- 表的索引 `idsequence`
--
ALTER TABLE `idsequence`
  ADD PRIMARY KEY (`Prefix`);

--
-- 表的索引 `order`
--
ALTER TABLE `order`
  ADD PRIMARY KEY (`OrderID`),
  ADD KEY `CustomerID` (`CustomerID`);

--
-- 表的索引 `ordersequence`
--
ALTER TABLE `ordersequence`
  ADD PRIMARY KEY (`OrderDate`);

--
-- 表的索引 `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`ProductID`);

--
-- 表的索引 `productionplan`
--
ALTER TABLE `productionplan`
  ADD PRIMARY KEY (`planID`),
  ADD KEY `idx_order_id` (`OrderID`),
  ADD KEY `idx_product_id` (`ProductID`);

--
-- 表的索引 `returnrequest`
--
ALTER TABLE `returnrequest`
  ADD PRIMARY KEY (`ExchangeID`),
  ADD KEY `OrderID` (`OrderID`),
  ADD KEY `ProductID` (`ProductID`);

--
-- 表的索引 `shipment`
--
ALTER TABLE `shipment`
  ADD PRIMARY KEY (`shipmentID`),
  ADD KEY `OrderID` (`OrderID`);

--
-- 表的索引 `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`SuPPlierID`);

--
-- 表的索引 `task`
--
ALTER TABLE `task`
  ADD PRIMARY KEY (`TaskID`);

--
-- 表的索引 `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`UserID`);

--
-- 表的索引 `warehouse`
--
ALTER TABLE `warehouse`
  ADD PRIMARY KEY (`WarehouseID`);

--
-- 表的索引 `workorder`
--
ALTER TABLE `workorder`
  ADD PRIMARY KEY (`WorkOrderID`),
  ADD KEY `productionPlanID` (`productionPlanID`);

--
-- 在导出的表使用AUTO_INCREMENT
--

--
-- 使用表AUTO_INCREMENT `customer`
--
ALTER TABLE `customer`
  MODIFY `CustomerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- 使用表AUTO_INCREMENT `feedback`
--
ALTER TABLE `feedback`
  MODIFY `FeedbackID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- 使用表AUTO_INCREMENT `order`
--
ALTER TABLE `order`
  MODIFY `OrderID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- 使用表AUTO_INCREMENT `product`
--
ALTER TABLE `product`
  MODIFY `ProductID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- 使用表AUTO_INCREMENT `productionplan`
--
ALTER TABLE `productionplan`
  MODIFY `planID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- 使用表AUTO_INCREMENT `returnrequest`
--
ALTER TABLE `returnrequest`
  MODIFY `ExchangeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- 使用表AUTO_INCREMENT `shipment`
--
ALTER TABLE `shipment`
  MODIFY `shipmentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- 使用表AUTO_INCREMENT `supplier`
--
ALTER TABLE `supplier`
  MODIFY `SuPPlierID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- 使用表AUTO_INCREMENT `task`
--
ALTER TABLE `task`
  MODIFY `TaskID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- 使用表AUTO_INCREMENT `user`
--
ALTER TABLE `user`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- 使用表AUTO_INCREMENT `warehouse`
--
ALTER TABLE `warehouse`
  MODIFY `WarehouseID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- 使用表AUTO_INCREMENT `workorder`
--
ALTER TABLE `workorder`
  MODIFY `WorkOrderID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- 限制导出的表
--

--
-- 限制表 `feedback`
--
ALTER TABLE `feedback`
  ADD CONSTRAINT `feedback_ibfk_1` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`);

--
-- 限制表 `order`
--
ALTER TABLE `order`
  ADD CONSTRAINT `order_ibfk_1` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`);

--
-- 限制表 `productionplan`
--
ALTER TABLE `productionplan`
  ADD CONSTRAINT `fk_productionplan_order` FOREIGN KEY (`OrderID`) REFERENCES `order` (`OrderID`),
  ADD CONSTRAINT `fk_productionplan_product` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ProductID`);

--
-- 限制表 `returnrequest`
--
ALTER TABLE `returnrequest`
  ADD CONSTRAINT `returnrequest_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `order` (`OrderID`),
  ADD CONSTRAINT `returnrequest_ibfk_2` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ProductID`);

--
-- 限制表 `shipment`
--
ALTER TABLE `shipment`
  ADD CONSTRAINT `shipment_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `order` (`OrderID`);

--
-- 限制表 `workorder`
--
ALTER TABLE `workorder`
  ADD CONSTRAINT `workorder_ibfk_1` FOREIGN KEY (`productionPlanID`) REFERENCES `productionplan` (`planID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
