-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 22, 2018 at 03:43 AM
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
  `serv_added_price` decimal(10,2) NOT NULL,
  `date_deleted` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `added_service_price`
--

INSERT INTO `added_service_price` (`serv_added_ID`, `service_ID`, `serv_added_name`, `serv_added_price`, `date_deleted`) VALUES
(1, 4, 'Wax', '50.00', NULL),
(2, 4, 'Vacuum', '100.00', NULL);

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
(1, 2),
(3, 1),
(3, 2),
(4, 1),
(4, 2),
(5, 1),
(5, 2),
(9, 1),
(9, 2);

-- --------------------------------------------------------

--
-- Table structure for table `brands`
--

CREATE TABLE `brands` (
  `brand_ID` int(11) NOT NULL,
  `brand_name` varchar(250) NOT NULL,
  `date_deleted` datetime DEFAULT NULL
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
  `date_deleted` datetime DEFAULT NULL
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
(7, 'pie', NULL),
(8, 'lights', NULL);

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
(21, 1, 6),
(26, 8, 1),
(27, 8, 4),
(28, 8, 5);

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
  `date_deleted` datetime DEFAULT NULL
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
  `model` varchar(25) NOT NULL,
  `date_deleted` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer_vehicle`
--

INSERT INTO `customer_vehicle` (`plate_no`, `cust_ID`, `color`, `vehicletype_ID`, `vehicle_brand_ID`, `model`, `date_deleted`) VALUES
('123', 1, 'orange', 3, 1, '', NULL),
('12332', 1, 'red', 3, 2, '', NULL),
('asd123', 1, 'blue', 3, 2, '', NULL),
('ZXC09123', 1, 'violet', 6, 2, '', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `descriptions`
--

CREATE TABLE `descriptions` (
  `description_ID` int(11) NOT NULL,
  `desc_name` varchar(250) NOT NULL,
  `desc_type` varchar(10) NOT NULL,
  `desc_unit` varchar(25) NOT NULL,
  `date_deleted` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `descriptions`
--

INSERT INTO `descriptions` (`description_ID`, `desc_name`, `desc_type`, `desc_unit`, `date_deleted`) VALUES
(1, 'Color', 'Text', '', NULL),
(2, 'Volume', 'Numeric', '', '2018-04-05 10:28:16'),
(3, 'Colors', 'Text', '', '2018-04-05 13:28:24'),
(4, 'Quality', 'Text', '', NULL),
(5, 'Diameter', 'Numeric', 'inches', NULL),
(6, 'Thickness', 'Numeric', 'cm', NULL);

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
  `emp_address` varchar(25) NOT NULL,
  `date_deleted` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`emp_ID`, `emp_fName`, `emp_gName`, `emp_mInitial`, `emp_position`, `emp_address`, `date_deleted`) VALUES
(1, 'Paganini', 'Niccolo', 'G.', 'Violinist', 'Italya', NULL),
(2, 'Vivaldi', 'Antonio', 'G', 'Violinist', 'Italya', NULL),
(3, 'Bach', 'J.S', 'e', 'Musician', 'Italya', NULL),
(5, 'asdad', 'asd', 'asda', 'asd', 'assd', NULL);

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
(1, '1000.00', '2018-04-19 16:16:53', 10000001),
(2, '500.00', '2018-04-19 17:18:20', 10000001),
(3, '700.00', '2018-04-19 17:18:37', 10000001),
(4, '8327.00', '2018-04-20 01:13:31', 10000002),
(5, '6045.25', '2018-04-20 01:15:15', 10000002),
(6, '6050.50', '2018-04-20 01:15:57', 10000002),
(7, '6270.25', '2018-04-20 01:43:18', 10000003),
(8, '6271.25', '2018-04-20 01:48:32', 10000003),
(9, '2551.75', '2018-04-20 02:11:38', 10000004),
(10, '1961.75', '2018-04-20 02:16:51', 10000005),
(11, '3051.75', '2018-04-20 02:35:27', 10000004),
(12, '95.00', '2018-04-20 02:43:30', 10000006);

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
  `date_deleted` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`product_ID`, `product_name`, `brand_ID`, `category_ID`, `date_profiled`, `date_deleted`) VALUES
('1111', 'Flashlight', 1, 8, '2018-04-21 08:57:04', NULL),
('123', 'Good Year ', 1, 5, '2018-04-14 14:25:59', NULL),
('456', 'Tint', 1, 6, '2018-04-20 08:12:42', NULL),
('4800092553929', 'Rev-X', 1, 1, '2018-04-07 01:15:36', NULL),
('777', 'Ultron-X', 1, 1, '2018-04-21 01:35:40', NULL),
('98776', '9876', 1, 1, '2018-04-21 06:13:51', NULL),
('dsaas', 'asas', 1, 4, '2018-04-18 16:53:50', NULL);

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
('777', 21, '7'),
('98776', 21, '9876'),
('1111', 26, 'white'),
('1111', 27, 'awesome'),
('1111', 28, '11');

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
(1, '4800092553929', '5018.00', 25, '3763.50'),
(2, 'dsaas', '232.00', 15, '197.20'),
(3, '123', '600.00', 0, '600.00'),
(4, '456', '300.00', 0, '300.00'),
(5, '1111', '200.00', 0, '200.00');

-- --------------------------------------------------------

--
-- Table structure for table `prod_trans_rela`
--

CREATE TABLE `prod_trans_rela` (
  `transac_ID` int(11) NOT NULL,
  `product_ID` varchar(50) DEFAULT NULL,
  `quantity` int(11) NOT NULL,
  `total` decimal(10,2) NOT NULL,
  `date_bought` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `prod_trans_rela`
--

INSERT INTO `prod_trans_rela` (`transac_ID`, `product_ID`, `quantity`, `total`, `date_bought`) VALUES
(10000001, '123', 3, '1800.00', '2018-04-19 17:17:59'),
(10000002, '4800092553929', 5, '18817.50', '2018-04-20 01:13:59'),
(10000002, '123', 1, '600.00', '2018-04-20 01:13:29'),
(10000003, '4800092553929', 3, '11290.50', '2018-04-20 01:43:17'),
(10000003, '123', 1, '600.00', '2018-04-20 01:43:17'),
(10000004, '4800092553929', 1, '3763.50', '2018-04-20 02:11:37'),
(10000005, '4800092553929', 1, '3763.50', '2018-04-20 02:16:51');

-- --------------------------------------------------------

--
-- Table structure for table `services`
--

CREATE TABLE `services` (
  `service_ID` int(11) NOT NULL,
  `service_name` varchar(50) NOT NULL,
  `service_desc` varchar(150) NOT NULL,
  `date_deleted` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `services`
--

INSERT INTO `services` (`service_ID`, `service_name`, `service_desc`, `date_deleted`) VALUES
(4, 'Carwash', 'Washing of car because it is so dirty already', NULL),
(5, 'Special Wax', 'waxing of paint specially', NULL),
(6, 'Wax', 'waxing, but not specially', NULL),
(7, 'Paint', 'changing of the color of the car', NULL),
(8, 'Change Oil', 'changing of oil that is unusable', NULL);

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
(1, 2),
(1, 5),
(2, 1),
(2, 3),
(2, 5),
(3, 1),
(3, 2),
(4, 1),
(4, 5),
(7, 1),
(7, 5),
(5, 2),
(5, 5),
(6, 2),
(8, 5),
(9, 2),
(9, 5),
(10, 1);

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
  `service_fee` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `service_prices`
--

INSERT INTO `service_prices` (`service_price_ID`, `service_ID`, `vehicletype_ID`, `service_fee`) VALUES
(6, 4, 6, '160.00'),
(7, 4, 1, '170.00'),
(8, 4, 3, '190.00'),
(9, 4, 4, '180.00'),
(10, 4, 5, '200.00'),
(11, 7, 6, '1000.00'),
(12, 7, 4, '5000.00'),
(13, 8, 5, '3000.00');

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
(1, '2018-04-19 17:18:37', '2018-04-19 17:18:36', 'Ongoing', 10000001, 4, '12332', '290.00'),
(2, '2018-04-20 01:15:57', '2018-04-20 01:15:57', 'Finished', 10000002, 7, 'ZXC09123', '1000.00'),
(3, '2018-04-20 01:48:31', '2018-04-20 01:48:31', 'Ongoing', 10000003, 4, 'ZXC09123', '310.00'),
(4, '2018-04-20 01:48:31', '2018-04-20 01:48:31', 'Finished', 10000003, 4, '123', '340.00'),
(5, '2018-04-20 02:35:22', '2018-04-20 02:35:22', 'Finished', 10000004, 4, '123', '340.00'),
(6, '2018-04-20 02:35:24', '2018-04-20 02:35:24', 'Finished', 10000004, 7, 'ZXC09123', '1000.00'),
(7, '2018-04-20 02:16:51', '0000-00-00 00:00:00', 'Ongoing', 10000005, 4, 'ZXC09123', '160.00'),
(8, '2018-04-20 02:35:25', '2018-04-20 02:35:25', 'Finished', 10000004, 4, 'asd123', '190.00'),
(9, '2018-04-20 02:35:26', '2018-04-20 02:35:26', 'Finished', 10000004, 4, 'ZXC09123', '310.00'),
(10, '2018-04-20 02:43:30', '0000-00-00 00:00:00', 'Ongoing', 10000006, 4, '12332', '190.00');

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
('STK-1000001', 'dsaas', 1, '2018-03-31 00:00:00', 15, 0, '160.00', '2018-04-20 06:21:17'),
('STK-1000002', '4800092553929', 2, '2018-03-29 00:00:00', 10, 0, '20.00', '2018-04-20 06:21:17'),
('STK-1000003', '4800092553929', 1, '2018-03-31 00:00:00', 20, 5, '8.00', '2018-03-31 06:49:19'),
('STK-1000004', 'dsaas', 2, '2018-03-31 00:00:00', 10, 10, '3.00', '2018-03-31 06:40:37'),
('STK-1000005', '123', 2, '2018-04-14 00:00:00', 112, 0, '500.00', '2018-04-20 06:21:17'),
('STK-1000006', '123', 1, '2018-04-19 00:00:00', 150, 5, '600.50', NULL),
('STK-1000007', '4800092553929', 2, '2018-04-19 00:00:00', 50, 12, '421.00', NULL),
('STK-1000008', '4800092553929', 2, '2018-04-20 00:00:00', 1, 1, '7.00', NULL),
('STK-1000009', '456', 7, '2018-04-20 00:00:00', 10, 10, '240.00', NULL),
('STK-1000010', '456', 6, '2018-04-18 00:00:00', 20, 20, '300.00', NULL),
('STK-1000011', '1111', 6, '2018-04-21 00:00:00', 20, 20, '223.52', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `suppliers`
--

CREATE TABLE `suppliers` (
  `supplier_ID` int(11) NOT NULL,
  `supplier_name` varchar(50) NOT NULL,
  `contact` varchar(50) NOT NULL,
  `address` varchar(50) NOT NULL,
  `date_profiled` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `date_deleted` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `suppliers`
--

INSERT INTO `suppliers` (`supplier_ID`, `supplier_name`, `contact`, `address`, `date_profiled`, `date_deleted`) VALUES
(1, 'looney', '69', 'ayala city', '2018-04-22 01:28:18', NULL),
(2, 'Supplier One', '0987654323', 'guiwan', '2018-04-22 01:28:18', NULL),
(3, 'alg', '911', 'tetuan', '2018-04-22 01:28:18', '2018-03-31 16:38:29'),
(4, '232e', 'eeeee', '2323e', '2018-04-22 01:28:18', '2018-03-31 16:37:31'),
(5, 'we', 'wer', 'wer', '2018-04-22 01:28:18', '2018-03-31 16:38:33'),
(6, 'Toto', '0987654321', 'Marloquet', '2018-04-22 01:28:18', NULL),
(7, 'h3lL0w', '0912345678', 'ph03wsszcxczxzsz', '2018-04-22 01:28:18', NULL),
(8, '12345', '534153782', 'Philippines', '2018-04-22 01:28:18', NULL);

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
(10000001, '2018-04-19 17:18:36', 0, '2090.00', '2090.00', '2200.00', '0.00', 1, '1800.00', '290.00', '1866.07', '223.93', 12),
(10000002, '2018-04-20 01:15:57', 0, '20417.50', '20417.50', '20422.75', '0.00', 1, '19417.50', '1000.00', '18229.91', '2187.59', 12),
(10000003, '2018-04-20 01:48:31', 0, '12540.50', '12540.50', '12541.50', '0.00', 1, '11890.50', '650.00', '11196.88', '1343.63', 12),
(10000004, '2018-04-20 02:35:19', 0, '5603.50', '5603.50', '5603.50', '0.00', 1, '3763.50', '1840.00', '5003.13', '600.38', 12),
(10000005, '2018-04-20 02:16:51', 0, '3923.50', '3923.50', '1961.75', '1961.75', 1, '3763.50', '160.00', '0.00', '0.00', 0),
(10000006, '2018-04-20 02:43:19', 0, '190.00', '190.00', '95.00', '95.00', 1, '0.00', '190.00', '0.00', '0.00', 0);

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
  `user_address` varchar(25) NOT NULL,
  `date_deleted` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`userID`, `fName`, `gName`, `mInitial`, `username`, `password`, `dateRegistered`, `user_type`, `login_status`, `user_address`, `date_deleted`) VALUES
(1, 'Mozart', 'Wolfgang', 'A', '2', '2', '2018-03-11 09:43:12', 'cashier', 0, 'Austria', NULL),
(2, 'Beethoven', 'Ludwig', 'V', '3', '3', '2018-03-11 09:40:18', 'encoder', 0, 'Germany', NULL),
(3, 'Saint-Saens', 'Camille', '', '1', '1', '2018-03-27 02:01:39', 'admin', 0, '', NULL),
(5, 'Gregorio', 'Karen', 'A', 'kaye', 'kaye02', '2018-02-23 08:07:08', 'admin', 0, 'Tumaga, Zamboanga City', NULL),
(10, '', '', '', '123', '?e?Y B/?A~Hg??O??J???~??????z?', '2018-04-20 05:09:03', 'admin', 0, '', NULL),
(11, '', '', '', '1234', '?gB??\\v??U?g?6#???E??x??F?', '2018-03-25 20:46:31', 'cashier', 0, '', NULL),
(12, '', '', '', 'f', '%/?6??\Z???U??[??????$????', '2018-03-27 03:19:28', 'encoder', 0, '', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `vehicle_brands`
--

CREATE TABLE `vehicle_brands` (
  `vehicle_brand_ID` int(11) NOT NULL,
  `vehicle_brand_name` varchar(20) NOT NULL,
  `date_deleted` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `vehicle_brands`
--

INSERT INTO `vehicle_brands` (`vehicle_brand_ID`, `vehicle_brand_name`, `date_deleted`) VALUES
(1, 'ISUZU', NULL),
(2, 'TOYOTA', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `vehicle_types`
--

CREATE TABLE `vehicle_types` (
  `vehicletype_ID` int(11) NOT NULL,
  `vehicle_type` varchar(25) NOT NULL,
  `date_deleted` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `vehicle_types`
--

INSERT INTO `vehicle_types` (`vehicletype_ID`, `vehicle_type`, `date_deleted`) VALUES
(1, 'SEDAN', NULL),
(3, 'SUV', NULL),
(4, 'MID SUV', NULL),
(5, 'VAN', NULL),
(6, 'COMPACT CAR', NULL);

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
  ADD KEY `serv_added_ID` (`serv_added_ID`),
  ADD KEY `servtransac_ID` (`servtransac_ID`);

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
  ADD KEY `servtransac_ID` (`servtransac_ID`);

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
  ADD KEY `service_ID` (`service_ID`),
  ADD KEY `plate_no` (`plate_no`),
  ADD KEY `transac_ID` (`transac_ID`);

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
  MODIFY `category_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `category_description`
--
ALTER TABLE `category_description`
  MODIFY `cat_desc_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;
--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `cust_ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `descriptions`
--
ALTER TABLE `descriptions`
  MODIFY `description_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `employees`
--
ALTER TABLE `employees`
  MODIFY `emp_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `payments`
--
ALTER TABLE `payments`
  MODIFY `payment_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `product_prices`
--
ALTER TABLE `product_prices`
  MODIFY `product_price_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
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
  MODIFY `supplier_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
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
  ADD CONSTRAINT `add_service_trans_ibfk_2` FOREIGN KEY (`serv_added_ID`) REFERENCES `added_service_price` (`serv_added_ID`),
  ADD CONSTRAINT `add_service_trans_ibfk_3` FOREIGN KEY (`servtransac_ID`) REFERENCES `service_transac` (`servtransac_ID`);

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
  ADD CONSTRAINT `service_emp_trans_ibfk_2` FOREIGN KEY (`emp_ID`) REFERENCES `employees` (`emp_ID`),
  ADD CONSTRAINT `service_emp_trans_ibfk_3` FOREIGN KEY (`servtransac_ID`) REFERENCES `service_transac` (`servtransac_ID`);

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
  ADD CONSTRAINT `service_transac_ibfk_2` FOREIGN KEY (`service_ID`) REFERENCES `services` (`service_ID`),
  ADD CONSTRAINT `service_transac_ibfk_3` FOREIGN KEY (`plate_no`) REFERENCES `customer_vehicle` (`plate_no`),
  ADD CONSTRAINT `service_transac_ibfk_4` FOREIGN KEY (`transac_ID`) REFERENCES `transactions` (`transac_ID`);

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
