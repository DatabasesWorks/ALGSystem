-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 14, 2018 at 06:07 PM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `algdb2.0`
--

-- --------------------------------------------------------

--
-- Table structure for table `added_service_price`
--

CREATE TABLE `added_service_price` (
  `serv_added_ID` int(11) NOT NULL,
  `service_ID` int(11) NOT NULL,
  `serv_added_name` varchar(25) NOT NULL,
  `serv_added_price` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `added_service_price`
--

INSERT INTO `added_service_price` (`serv_added_ID`, `service_ID`, `serv_added_name`, `serv_added_price`) VALUES
(1, 4, 'Wax', 50),
(2, 4, 'Vacuum', 100);

-- --------------------------------------------------------

--
-- Table structure for table `add_service_trans`
--

CREATE TABLE `add_service_trans` (
  `servtransac_ID` int(11) NOT NULL,
  `serv_added_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `add_service_trans`
--

INSERT INTO `add_service_trans` (`servtransac_ID`, `serv_added_ID`) VALUES
(3, 1),
(3, 2),
(4, 1),
(4, 2),
(8, 1),
(8, 2);

-- --------------------------------------------------------

--
-- Table structure for table `brands`
--

CREATE TABLE `brands` (
  `brand_ID` int(11) NOT NULL,
  `brand_name` varchar(250) NOT NULL,
  `date_deleted` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `brands`
--

INSERT INTO `brands` (`brand_ID`, `brand_name`, `date_deleted`) VALUES
(1, 'Petron', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `category_ID` int(11) NOT NULL,
  `category_name` varchar(250) NOT NULL,
  `date_deleted` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`category_ID`, `category_name`, `date_deleted`) VALUES
(1, 'Engine Oil', NULL),
(2, 'volume', NULL),
(3, 'Lubricant', NULL),
(4, 'tire', NULL),
(5, 'wheels', NULL),
(6, 'tint', NULL),
(7, 'pie', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `category_description`
--

CREATE TABLE `category_description` (
  `cat_desc_ID` int(11) NOT NULL,
  `category_ID` int(11) NOT NULL,
  `description_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `category_description`
--

INSERT INTO `category_description` (`cat_desc_ID`, `category_ID`, `description_ID`) VALUES
(12, 1, 1),
(13, 1, 4),
(14, 4, 1),
(15, 4, 4),
(16, 7, 5),
(17, 5, 4),
(18, 5, 5);

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `cust_ID` int(10) NOT NULL,
  `fName` varchar(25) NOT NULL,
  `gName` varchar(25) NOT NULL,
  `mInitial` varchar(25) NOT NULL,
  `contact_num` varchar(25) NOT NULL,
  `address` varchar(40) NOT NULL,
  `date_registered` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `date_deleted` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`cust_ID`, `fName`, `gName`, `mInitial`, `contact_num`, `address`, `date_registered`, `date_deleted`) VALUES
(1, 'Bach', 'Johann', 'S', '911', 'Somewhere', '2018-03-09 05:34:41', NULL),
(2, 'Mozart', 'Wolfgang', 'A', '777', 'vienna', '2018-04-11 04:55:01', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `customer_vehicle`
--

CREATE TABLE `customer_vehicle` (
  `plate_no` varchar(10) NOT NULL,
  `cust_ID` int(11) NOT NULL,
  `color` text NOT NULL,
  `vehicletype_ID` int(11) NOT NULL,
  `vehicle_brand_ID` int(11) NOT NULL,
  `model` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer_vehicle`
--

INSERT INTO `customer_vehicle` (`plate_no`, `cust_ID`, `color`, `vehicletype_ID`, `vehicle_brand_ID`, `model`) VALUES
('123', 1, 'orange', 3, 1, ''),
('12332', 1, 'red', 3, 2, ''),
('asd123', 1, 'blue', 3, 2, ''),
('ZXC09123', 1, 'violet', 6, 2, '');

-- --------------------------------------------------------

--
-- Table structure for table `descriptions`
--

CREATE TABLE `descriptions` (
  `description_ID` int(11) NOT NULL,
  `desc_name` varchar(250) NOT NULL,
  `desc_type` varchar(10) NOT NULL,
  `date_deleted` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `descriptions`
--

INSERT INTO `descriptions` (`description_ID`, `desc_name`, `desc_type`, `date_deleted`) VALUES
(1, 'Color', 'Text', NULL),
(2, 'Volume', 'Numeric', '2018-04-05 02:28:16'),
(3, 'Colors', 'Text', '2018-04-05 05:28:24'),
(4, 'Quality', 'Text', NULL),
(5, 'Diameter', 'Numeric', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE `employees` (
  `emp_ID` int(11) NOT NULL,
  `emp_fName` varchar(25) NOT NULL,
  `emp_gName` varchar(25) NOT NULL,
  `emp_mInitial` varchar(10) NOT NULL,
  `emp_position` varchar(25) NOT NULL,
  `emp_address` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`emp_ID`, `emp_fName`, `emp_gName`, `emp_mInitial`, `emp_position`, `emp_address`) VALUES
(1, 'Paganini', 'Niccolo', 'G.', 'Violinist', 'Italya'),
(2, 'Vivaldi', 'Antonio', 'G', 'Violinist', 'Italya'),
(3, 'Bach', 'J.S', 'e', 'Musician', 'Italya'),
(5, 'asdad', 'asd', 'asda', 'asd', 'assd');

-- --------------------------------------------------------

--
-- Table structure for table `payments`
--

CREATE TABLE `payments` (
  `payment_ID` int(11) NOT NULL,
  `payment` decimal(10,2) NOT NULL,
  `date_paid` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `transac_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `payments`
--

INSERT INTO `payments` (`payment_ID`, `payment`, `date_paid`, `transac_ID`) VALUES
(1, '1000.00', '2018-04-10 06:43:10', 10000001),
(2, '6000.00', '2018-04-10 06:48:20', 10000002),
(3, '801.00', '2018-04-10 08:31:41', 10000003),
(4, '1335.00', '2018-04-13 06:20:30', 10000004),
(5, '3000.00', '2018-04-13 10:34:09', 10000005),
(6, '170.00', '2018-04-13 15:21:03', 10000011),
(7, '400.00', '2018-04-13 15:26:02', 10000012),
(8, '600.00', '2018-04-14 02:44:12', 10000013),
(9, '800.00', '2018-04-14 02:46:41', 10000014),
(10, '5050.00', '2018-04-14 14:28:21', 10000015);

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `product_ID` varchar(100) NOT NULL,
  `product_name` varchar(250) NOT NULL,
  `brand_ID` int(11) NOT NULL,
  `category_ID` int(11) NOT NULL,
  `date_profiled` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `date_deleted` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`product_ID`, `product_name`, `brand_ID`, `category_ID`, `date_profiled`, `date_deleted`) VALUES
('123', 'Good Year ', 1, 5, '2018-04-14 14:25:59', NULL),
('4800092553929', 'Rev-X', 1, 1, '2018-04-07 01:15:36', NULL),
('dsaas', 'asas', 1, 1, '2018-03-30 02:23:21', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `product_description`
--

CREATE TABLE `product_description` (
  `product_ID` varchar(100) NOT NULL,
  `cat_desc_ID` int(11) NOT NULL,
  `product_desc_value` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `product_description`
--

INSERT INTO `product_description` (`product_ID`, `cat_desc_ID`, `product_desc_value`) VALUES
('dsaas', 12, 'white'),
('dsaas', 13, 'great'),
('4800092553929', 12, 'black'),
('4800092553929', 13, 'good'),
('123', 17, 'awesome'),
('123', 18, '83');

-- --------------------------------------------------------

--
-- Table structure for table `product_prices`
--

CREATE TABLE `product_prices` (
  `product_price_ID` int(11) NOT NULL,
  `product_ID` varchar(50) NOT NULL,
  `product_price` decimal(10,2) NOT NULL,
  `discount` int(11) NOT NULL,
  `discounted_price` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `product_prices`
--

INSERT INTO `product_prices` (`product_price_ID`, `product_ID`, `product_price`, `discount`, `discounted_price`) VALUES
(1, '4800092553929', '5018.00', 50, '2509.00'),
(2, 'dsaas', '800.00', 0, '800.00'),
(3, '123', '600.00', 0, '600.00');

-- --------------------------------------------------------

--
-- Table structure for table `prod_trans_rela`
--

CREATE TABLE `prod_trans_rela` (
  `transac_ID` int(11) NOT NULL,
  `product_ID` varchar(50) DEFAULT NULL,
  `quantity` int(11) NOT NULL,
  `total` double NOT NULL,
  `date_bought` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `prod_trans_rela`
--

INSERT INTO `prod_trans_rela` (`transac_ID`, `product_ID`, `quantity`, `total`, `date_bought`) VALUES
(10000001, 'dsaas', 1, 800, '2018-04-10 06:43:10'),
(10000002, 'dsaas', 1, 800, '2018-04-10 06:48:20'),
(10000002, '4800092553929', 2, 5018, '2018-04-10 06:48:20'),
(10000003, 'dsaas', 1, 800, '2018-04-10 08:31:41'),
(10000004, 'dsaas', 1, 800, '2018-04-13 06:20:24'),
(10000005, '4800092553929', 1, 2509, '2018-04-13 10:33:24'),
(10000006, 'dsaas', 1, 800, '2018-04-13 14:26:54'),
(10000007, 'dsaas', 1, 800, '2018-04-13 14:36:20'),
(10000015, '123', 8, 4800, '2018-04-14 14:28:19'),
(10000015, '4800092553929', 1, 2509, '2018-04-14 14:28:19'),
(10000015, 'dsaas', 3, 2400, '2018-04-14 14:28:19');

-- --------------------------------------------------------

--
-- Table structure for table `services`
--

CREATE TABLE `services` (
  `service_ID` int(11) NOT NULL,
  `service_name` varchar(50) NOT NULL,
  `service_desc` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `services`
--

INSERT INTO `services` (`service_ID`, `service_name`, `service_desc`) VALUES
(4, 'Carwash', 'Washing of car because it is so dirty already'),
(5, 'Special Wax', 'waxing of paint specially'),
(6, 'Wax', 'waxing, but not specially'),
(7, 'Paint', 'changing of the color of the car'),
(8, 'Change Oil', 'changing of oil that is unusable');

-- --------------------------------------------------------

--
-- Table structure for table `service_emp_trans`
--

CREATE TABLE `service_emp_trans` (
  `servtransac_ID` int(11) NOT NULL,
  `emp_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `service_emp_trans`
--

INSERT INTO `service_emp_trans` (`servtransac_ID`, `emp_ID`) VALUES
(4, 1),
(4, 2),
(5, 3),
(6, 3),
(6, 5),
(7, 2),
(8, 2);

-- --------------------------------------------------------

--
-- Table structure for table `service_logs`
--

CREATE TABLE `service_logs` (
  `sr_log_id` int(11) NOT NULL,
  `user_ID` int(11) NOT NULL,
  `sr_date_time` varchar(20) NOT NULL,
  `service_ID` int(11) NOT NULL,
  `sr_action` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `service_prices`
--

CREATE TABLE `service_prices` (
  `service_price_ID` int(11) NOT NULL,
  `service_ID` int(11) NOT NULL,
  `vehicletype_ID` int(11) NOT NULL,
  `service_fee` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `service_prices`
--

INSERT INTO `service_prices` (`service_price_ID`, `service_ID`, `vehicletype_ID`, `service_fee`) VALUES
(6, 4, 6, 160),
(7, 4, 1, 170),
(8, 4, 3, 190),
(9, 4, 4, 180),
(10, 4, 5, 200),
(11, 7, 6, 1000),
(12, 7, 4, 5000),
(13, 8, 5, 3000);

-- --------------------------------------------------------

--
-- Table structure for table `service_transac`
--

CREATE TABLE `service_transac` (
  `servtransac_ID` int(11) NOT NULL,
  `date_received` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `date_released` timestamp NULL DEFAULT NULL,
  `service_status` varchar(10) NOT NULL,
  `transac_ID` int(11) NOT NULL,
  `service_ID` int(11) NOT NULL,
  `plate_no` varchar(10) NOT NULL,
  `total_amount` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `service_transac`
--

INSERT INTO `service_transac` (`servtransac_ID`, `date_received`, `date_released`, `service_status`, `transac_ID`, `service_ID`, `plate_no`, `total_amount`) VALUES
(1, '2018-04-13 15:10:27', '2018-04-13 03:09:21', 'Finished', 10000009, 4, 'ZXC09123', '210.00'),
(2, '2018-04-13 15:16:12', '2018-04-13 03:14:36', 'Finished', 10000010, 4, '123', '340.00'),
(3, '2018-04-13 15:19:26', '0000-00-00 00:00:00', 'Ongoing', 10000011, 4, '123', '340.00'),
(4, '2018-04-13 15:24:14', '2018-04-13 03:24:04', 'Finished', 10000012, 4, '123', '340.00'),
(5, '2018-04-14 02:44:03', '0000-00-00 00:00:00', 'Ongoing', 10000013, 7, 'ZXC09123', '1000.00'),
(6, '2018-04-14 02:58:08', '0000-00-00 00:00:00', 'Finished', 10000014, 4, '12332', '190.00'),
(7, '2018-04-14 02:46:40', '0000-00-00 00:00:00', 'Ongoing', 10000014, 7, 'ZXC09123', '1000.00'),
(8, '2018-04-14 14:28:20', '0000-00-00 00:00:00', 'Ongoing', 10000015, 4, '12332', '340.00');

-- --------------------------------------------------------

--
-- Table structure for table `settings`
--

CREATE TABLE `settings` (
  `setting_ID` int(11) NOT NULL,
  `setting_name` varchar(100) NOT NULL,
  `setting_value` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `settings`
--

INSERT INTO `settings` (`setting_ID`, `setting_name`, `setting_value`) VALUES
(1, 'Vat', '12');

-- --------------------------------------------------------

--
-- Table structure for table `stocks`
--

CREATE TABLE `stocks` (
  `stock_ID` varchar(20) NOT NULL,
  `product_ID` varchar(50) NOT NULL,
  `supplier_ID` int(11) NOT NULL,
  `received_date` datetime DEFAULT NULL,
  `total_stocks` int(11) NOT NULL,
  `remaining_stocks` int(11) NOT NULL,
  `supplier_price` decimal(10,2) NOT NULL,
  `date_deleted` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `stocks`
--

INSERT INTO `stocks` (`stock_ID`, `product_ID`, `supplier_ID`, `received_date`, `total_stocks`, `remaining_stocks`, `supplier_price`, `date_deleted`) VALUES
('STK-1000001', 'dsaas', 1, '2018-03-31 00:00:00', 5, 0, '160.00', NULL),
('STK-1000002', '4800092553929', 2, '2018-03-29 00:00:00', 6, 5, '20.00', NULL),
('STK-1000003', '4800092553929', 1, '2018-03-31 00:00:00', 20, 5, '8.00', '2018-03-31 06:49:19'),
('STK-1000004', 'dsaas', 2, '2018-03-31 00:00:00', 10, 10, '3.00', '2018-03-31 06:40:37'),
('STK-1000005', '123', 2, '2018-04-14 00:00:00', 100, 92, '500.00', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `suppliers`
--

CREATE TABLE `suppliers` (
  `supplier_ID` int(11) NOT NULL,
  `supplier_name` varchar(50) NOT NULL,
  `contact` varchar(50) NOT NULL,
  `address` varchar(50) NOT NULL,
  `date_deleted` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `suppliers`
--

INSERT INTO `suppliers` (`supplier_ID`, `supplier_name`, `contact`, `address`, `date_deleted`) VALUES
(1, 'looney', '69', 'ayala city', NULL),
(2, 'Supplier One', 'ttt', 'd', NULL),
(3, 'alg', '911', 'tetuan', '2018-03-31 08:38:29'),
(4, '232e', 'eeeee', '2323e', '2018-03-31 08:37:31'),
(5, 'we', 'wer', 'wer', '2018-03-31 08:38:33');

-- --------------------------------------------------------

--
-- Table structure for table `transactions`
--

CREATE TABLE `transactions` (
  `transac_ID` int(11) NOT NULL,
  `date_transact` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `discount` int(11) NOT NULL,
  `discounted_amount` decimal(10,2) NOT NULL,
  `total_amount` decimal(10,2) NOT NULL,
  `paid` decimal(10,2) NOT NULL,
  `balance` decimal(10,2) NOT NULL,
  `customer_ID` int(11) DEFAULT NULL,
  `items_total_amount` decimal(10,2) NOT NULL,
  `service_total_amount` decimal(10,2) NOT NULL,
  `vatable_sales` decimal(10,2) NOT NULL,
  `vat` decimal(10,2) NOT NULL,
  `vat_percent` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `transactions`
--

INSERT INTO `transactions` (`transac_ID`, `date_transact`, `discount`, `discounted_amount`, `total_amount`, `paid`, `balance`, `customer_ID`, `items_total_amount`, `service_total_amount`, `vatable_sales`, `vat`, `vat_percent`) VALUES
(10000001, '2018-04-11 04:58:07', 1, '0.00', '800.00', '1000.00', '0.00', 1, '0.00', '0.00', '0.00', '0.00', 0),
(10000002, '2018-04-11 04:58:10', 0, '0.00', '5818.00', '6000.00', '0.00', 1, '0.00', '0.00', '0.00', '0.00', 0),
(10000003, '2018-04-11 04:58:13', 0, '0.00', '800.00', '801.00', '0.00', 1, '0.00', '0.00', '0.00', '0.00', 0),
(10000004, '2018-04-13 06:47:33', 0, '1330.00', '1330.00', '1335.00', '0.00', 1, '800.00', '530.00', '1187.50', '142.50', 12),
(10000005, '2018-04-13 10:32:02', 0, '2849.00', '2849.00', '3000.00', '0.00', 1, '2509.00', '340.00', '2543.75', '305.25', 12),
(10000006, '2018-04-13 14:26:54', 0, '990.00', '990.00', '1000.00', '0.00', 1, '800.00', '190.00', '883.93', '106.07', 12),
(10000007, '2018-04-13 14:36:20', 0, '1040.00', '1040.00', '1055.00', '0.00', 1, '800.00', '240.00', '928.57', '111.43', 12),
(10000008, '2018-04-13 15:05:48', 0, '240.00', '240.00', '1000.00', '0.00', 1, '0.00', '240.00', '214.29', '25.71', 12),
(10000009, '2018-04-13 15:09:21', 0, '210.00', '210.00', '210.00', '0.00', 1, '0.00', '210.00', '187.50', '22.50', 12),
(10000010, '2018-04-13 15:14:35', 0, '340.00', '340.00', '500.00', '0.00', 1, '0.00', '340.00', '303.57', '36.43', 12),
(10000011, '2018-04-13 15:19:25', 0, '340.00', '340.00', '170.00', '170.00', 1, '0.00', '340.00', '303.57', '36.43', 12),
(10000012, '2018-04-13 15:24:04', 0, '340.00', '340.00', '400.00', '0.00', 1, '0.00', '340.00', '303.57', '36.43', 12),
(10000013, '2018-04-14 02:43:55', 0, '1000.00', '1000.00', '600.00', '400.00', 1, '0.00', '1000.00', '892.86', '107.14', 12),
(10000014, '2018-04-14 02:46:26', 0, '1190.00', '1190.00', '800.00', '390.00', 1, '0.00', '1190.00', '1062.50', '127.50', 12),
(10000015, '2018-04-14 14:28:19', 0, '10049.00', '10049.00', '5050.00', '4999.00', 1, '9709.00', '340.00', '0.00', '0.00', 0);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `userID` int(11) NOT NULL,
  `fName` varchar(20) NOT NULL,
  `gName` varchar(25) NOT NULL,
  `mInitial` varchar(5) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(250) NOT NULL,
  `dateRegistered` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `user_type` varchar(20) NOT NULL,
  `login_status` tinyint(1) NOT NULL,
  `user_address` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`userID`, `fName`, `gName`, `mInitial`, `username`, `password`, `dateRegistered`, `user_type`, `login_status`, `user_address`) VALUES
(1, 'Mozart', 'Wolfgang', 'A', '2', '2', '2018-03-11 09:43:12', 'cashier', 0, 'Austria'),
(2, 'Beethoven', 'Ludwig', 'V', '3', '3', '2018-03-11 09:40:18', 'encoder', 0, 'Germany'),
(3, 'Saint-Saens', 'Camille', '', '1', '1', '2018-03-27 02:01:39', 'admin', 0, ''),
(5, 'Gregorio', 'Karen', 'A', 'kaye', 'kaye02', '2018-02-23 08:07:08', 'admin', 0, 'Tumaga, Zamboanga City'),
(10, '', '', '', '123', '?e?Y B/?A~Hg??O??J???~??????z?', '2018-04-14 14:41:47', 'admin', 0, ''),
(11, '', '', '', '1234', '?gB??\\v??U?g?6#???E??x??F?', '2018-03-25 20:46:31', 'cashier', 0, ''),
(12, '', '', '', 'f', '%/?6??\Z???U??[??????$????', '2018-03-27 03:19:28', 'encoder', 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `vehicle_brands`
--

CREATE TABLE `vehicle_brands` (
  `vehicle_brand_ID` int(11) NOT NULL,
  `vehicle_brand_name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `vehicle_brands`
--

INSERT INTO `vehicle_brands` (`vehicle_brand_ID`, `vehicle_brand_name`) VALUES
(1, 'ISUZU'),
(2, 'TOYOTA');

-- --------------------------------------------------------

--
-- Table structure for table `vehicle_types`
--

CREATE TABLE `vehicle_types` (
  `vehicletype_ID` int(11) NOT NULL,
  `vehicle_type` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `vehicle_types`
--

INSERT INTO `vehicle_types` (`vehicletype_ID`, `vehicle_type`) VALUES
(1, 'SEDAN'),
(3, 'SUV'),
(4, 'MID SUV'),
(5, 'VAN'),
(6, 'COMPACT CAR');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `added_service_price`
--
ALTER TABLE `added_service_price`
  ADD PRIMARY KEY (`serv_added_ID`),
  ADD KEY `service_ID` (`service_ID`);

--
-- Indexes for table `add_service_trans`
--
ALTER TABLE `add_service_trans`
  ADD KEY `servtransac_ID` (`servtransac_ID`),
  ADD KEY `serv_added_ID` (`serv_added_ID`);

--
-- Indexes for table `brands`
--
ALTER TABLE `brands`
  ADD PRIMARY KEY (`brand_ID`);

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`category_ID`);

--
-- Indexes for table `category_description`
--
ALTER TABLE `category_description`
  ADD PRIMARY KEY (`cat_desc_ID`),
  ADD KEY `category_ID` (`category_ID`),
  ADD KEY `description_ID` (`description_ID`);

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`cust_ID`);

--
-- Indexes for table `customer_vehicle`
--
ALTER TABLE `customer_vehicle`
  ADD PRIMARY KEY (`plate_no`),
  ADD KEY `vehicletype_ID` (`vehicletype_ID`),
  ADD KEY `cust_ID` (`cust_ID`),
  ADD KEY `vehicle_brand_ID` (`vehicle_brand_ID`);

--
-- Indexes for table `descriptions`
--
ALTER TABLE `descriptions`
  ADD PRIMARY KEY (`description_ID`);

--
-- Indexes for table `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`emp_ID`);

--
-- Indexes for table `payments`
--
ALTER TABLE `payments`
  ADD PRIMARY KEY (`payment_ID`),
  ADD KEY `transac_ID` (`transac_ID`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`product_ID`),
  ADD KEY `brand_ID` (`brand_ID`),
  ADD KEY `category_ID` (`category_ID`);

--
-- Indexes for table `product_description`
--
ALTER TABLE `product_description`
  ADD KEY `cat_desc_ID` (`cat_desc_ID`),
  ADD KEY `product_ID` (`product_ID`);

--
-- Indexes for table `product_prices`
--
ALTER TABLE `product_prices`
  ADD PRIMARY KEY (`product_price_ID`),
  ADD KEY `product_ID` (`product_ID`);

--
-- Indexes for table `prod_trans_rela`
--
ALTER TABLE `prod_trans_rela`
  ADD KEY `product_ID` (`product_ID`),
  ADD KEY `transac_ID` (`transac_ID`);

--
-- Indexes for table `services`
--
ALTER TABLE `services`
  ADD PRIMARY KEY (`service_ID`);

--
-- Indexes for table `service_emp_trans`
--
ALTER TABLE `service_emp_trans`
  ADD KEY `emp_ID` (`emp_ID`),
  ADD KEY `service_emp_trans_ibfk_1` (`servtransac_ID`);

--
-- Indexes for table `service_logs`
--
ALTER TABLE `service_logs`
  ADD PRIMARY KEY (`sr_log_id`),
  ADD KEY `user_ID` (`user_ID`),
  ADD KEY `service_ID` (`service_ID`);

--
-- Indexes for table `service_prices`
--
ALTER TABLE `service_prices`
  ADD PRIMARY KEY (`service_price_ID`),
  ADD KEY `service_ID` (`service_ID`),
  ADD KEY `vehicletype_ID` (`vehicletype_ID`);

--
-- Indexes for table `service_transac`
--
ALTER TABLE `service_transac`
  ADD PRIMARY KEY (`servtransac_ID`),
  ADD KEY `transac_ID` (`transac_ID`),
  ADD KEY `service_ID` (`service_ID`),
  ADD KEY `plate_no` (`plate_no`);

--
-- Indexes for table `settings`
--
ALTER TABLE `settings`
  ADD PRIMARY KEY (`setting_ID`);

--
-- Indexes for table `stocks`
--
ALTER TABLE `stocks`
  ADD PRIMARY KEY (`stock_ID`),
  ADD KEY `product_ID` (`product_ID`),
  ADD KEY `supplier_ID` (`supplier_ID`);

--
-- Indexes for table `suppliers`
--
ALTER TABLE `suppliers`
  ADD PRIMARY KEY (`supplier_ID`);

--
-- Indexes for table `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`transac_ID`),
  ADD KEY `customer_ID` (`customer_ID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`userID`);

--
-- Indexes for table `vehicle_brands`
--
ALTER TABLE `vehicle_brands`
  ADD PRIMARY KEY (`vehicle_brand_ID`);

--
-- Indexes for table `vehicle_types`
--
ALTER TABLE `vehicle_types`
  ADD PRIMARY KEY (`vehicletype_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `added_service_price`
--
ALTER TABLE `added_service_price`
  MODIFY `serv_added_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `brands`
--
ALTER TABLE `brands`
  MODIFY `brand_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `category_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `category_description`
--
ALTER TABLE `category_description`
  MODIFY `cat_desc_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `cust_ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `descriptions`
--
ALTER TABLE `descriptions`
  MODIFY `description_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `employees`
--
ALTER TABLE `employees`
  MODIFY `emp_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `payments`
--
ALTER TABLE `payments`
  MODIFY `payment_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `product_prices`
--
ALTER TABLE `product_prices`
  MODIFY `product_price_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `services`
--
ALTER TABLE `services`
  MODIFY `service_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `service_logs`
--
ALTER TABLE `service_logs`
  MODIFY `sr_log_id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `service_prices`
--
ALTER TABLE `service_prices`
  MODIFY `service_price_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
--
-- AUTO_INCREMENT for table `settings`
--
ALTER TABLE `settings`
  MODIFY `setting_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `suppliers`
--
ALTER TABLE `suppliers`
  MODIFY `supplier_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `userID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `vehicle_brands`
--
ALTER TABLE `vehicle_brands`
  MODIFY `vehicle_brand_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `vehicle_types`
--
ALTER TABLE `vehicle_types`
  MODIFY `vehicletype_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `added_service_price`
--
ALTER TABLE `added_service_price`
  ADD CONSTRAINT `added_service_price_ibfk_1` FOREIGN KEY (`service_ID`) REFERENCES `services` (`service_ID`);

--
-- Constraints for table `add_service_trans`
--
ALTER TABLE `add_service_trans`
  ADD CONSTRAINT `add_service_trans_ibfk_1` FOREIGN KEY (`servtransac_ID`) REFERENCES `service_transac` (`servtransac_ID`),
  ADD CONSTRAINT `add_service_trans_ibfk_2` FOREIGN KEY (`serv_added_ID`) REFERENCES `added_service_price` (`serv_added_ID`);

--
-- Constraints for table `category_description`
--
ALTER TABLE `category_description`
  ADD CONSTRAINT `category_description_ibfk_1` FOREIGN KEY (`category_ID`) REFERENCES `categories` (`category_ID`),
  ADD CONSTRAINT `category_description_ibfk_2` FOREIGN KEY (`description_ID`) REFERENCES `descriptions` (`description_ID`);

--
-- Constraints for table `customer_vehicle`
--
ALTER TABLE `customer_vehicle`
  ADD CONSTRAINT `customer_vehicle_ibfk_2` FOREIGN KEY (`vehicletype_ID`) REFERENCES `vehicle_types` (`vehicletype_ID`),
  ADD CONSTRAINT `customer_vehicle_ibfk_3` FOREIGN KEY (`vehicle_brand_ID`) REFERENCES `vehicle_brands` (`vehicle_brand_ID`),
  ADD CONSTRAINT `customer_vehicle_ibfk_4` FOREIGN KEY (`cust_ID`) REFERENCES `customers` (`cust_ID`);

--
-- Constraints for table `payments`
--
ALTER TABLE `payments`
  ADD CONSTRAINT `payments_ibfk_1` FOREIGN KEY (`transac_ID`) REFERENCES `transactions` (`transac_ID`);

--
-- Constraints for table `products`
--
ALTER TABLE `products`
  ADD CONSTRAINT `products_ibfk_1` FOREIGN KEY (`brand_ID`) REFERENCES `brands` (`brand_ID`),
  ADD CONSTRAINT `products_ibfk_2` FOREIGN KEY (`category_ID`) REFERENCES `categories` (`category_ID`);

--
-- Constraints for table `product_description`
--
ALTER TABLE `product_description`
  ADD CONSTRAINT `product_description_ibfk_1` FOREIGN KEY (`cat_desc_ID`) REFERENCES `category_description` (`cat_desc_ID`),
  ADD CONSTRAINT `product_description_ibfk_2` FOREIGN KEY (`product_ID`) REFERENCES `products` (`product_ID`);

--
-- Constraints for table `product_prices`
--
ALTER TABLE `product_prices`
  ADD CONSTRAINT `product_prices_ibfk_1` FOREIGN KEY (`product_ID`) REFERENCES `products` (`product_ID`);

--
-- Constraints for table `prod_trans_rela`
--
ALTER TABLE `prod_trans_rela`
  ADD CONSTRAINT `prod_trans_rela_ibfk_1` FOREIGN KEY (`product_ID`) REFERENCES `products` (`product_ID`),
  ADD CONSTRAINT `prod_trans_rela_ibfk_2` FOREIGN KEY (`transac_ID`) REFERENCES `transactions` (`transac_ID`);

--
-- Constraints for table `service_emp_trans`
--
ALTER TABLE `service_emp_trans`
  ADD CONSTRAINT `service_emp_trans_ibfk_1` FOREIGN KEY (`servtransac_ID`) REFERENCES `service_transac` (`servtransac_ID`),
  ADD CONSTRAINT `service_emp_trans_ibfk_2` FOREIGN KEY (`emp_ID`) REFERENCES `employees` (`emp_ID`);

--
-- Constraints for table `service_prices`
--
ALTER TABLE `service_prices`
  ADD CONSTRAINT `service_prices_ibfk_1` FOREIGN KEY (`service_ID`) REFERENCES `services` (`service_ID`),
  ADD CONSTRAINT `service_prices_ibfk_2` FOREIGN KEY (`vehicletype_ID`) REFERENCES `vehicle_types` (`vehicletype_ID`);

--
-- Constraints for table `service_transac`
--
ALTER TABLE `service_transac`
  ADD CONSTRAINT `service_transac_ibfk_1` FOREIGN KEY (`transac_ID`) REFERENCES `transactions` (`transac_ID`),
  ADD CONSTRAINT `service_transac_ibfk_2` FOREIGN KEY (`service_ID`) REFERENCES `services` (`service_ID`),
  ADD CONSTRAINT `service_transac_ibfk_3` FOREIGN KEY (`plate_no`) REFERENCES `customer_vehicle` (`plate_no`);

--
-- Constraints for table `stocks`
--
ALTER TABLE `stocks`
  ADD CONSTRAINT `stocks_ibfk_1` FOREIGN KEY (`product_ID`) REFERENCES `products` (`product_ID`),
  ADD CONSTRAINT `stocks_ibfk_2` FOREIGN KEY (`supplier_ID`) REFERENCES `suppliers` (`supplier_ID`);

--
-- Constraints for table `transactions`
--
ALTER TABLE `transactions`
  ADD CONSTRAINT `transactions_ibfk_1` FOREIGN KEY (`customer_ID`) REFERENCES `customers` (`cust_ID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
