-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 07, 2018 at 02:37 PM
-- Server version: 10.1.24-MariaDB
-- PHP Version: 7.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `algdb(2.0)`
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
(2, 4, 'Vacuum', '100.00', NULL),
(3, 8, 'Gear Polish', '100.00', NULL);

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
(1, 1),
(2, 1),
(2, 2),
(3, 1),
(5, 1),
(6, 2),
(4, 1),
(8, 3),
(10, 3),
(11, 1),
(11, 2),
(13, 3),
(15, 3),
(18, 3),
(19, 3),
(20, 3),
(21, 3),
(23, 3);

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
(1, 'Petron', NULL),
(2, 'Shelly', NULL),
(3, 'Caltex', NULL),
(4, 'V-cool', NULL),
(5, 'Shell', NULL);

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
(1, 'Gasoline Engine Oil', NULL),
(3, 'Diesel Engine Oil', NULL),
(4, 'Automotive Lubricants', NULL),
(5, 'Visor', NULL),
(6, 'Transmission Oil', NULL);

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
(1, 1, 1),
(2, 1, 2),
(3, 2, 1),
(4, 2, 3),
(5, 3, 1),
(6, 3, 2),
(7, 4, 1),
(8, 4, 2),
(9, 5, 3),
(10, 5, 4),
(11, 6, 1);

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
(2, 'Mozart', 'Wolfgang', 'A', '777', 'vienna', '2018-04-11 04:55:01', NULL),
(3, 'Jones', 'Tom', 'A', '09678765434', 'NYC', '2018-04-27 05:44:03', NULL),
(4, 'Potter', 'Harry', 'E', '119', 'London', '2018-04-27 05:43:42', NULL),
(5, 'Snape', 'Raven', 'E', '8080', 'Hogwarts', '2018-04-27 05:43:25', NULL),
(6, 'loon', 'prince', '', '69', 'dfdf', '2018-04-27 10:20:52', NULL),
(7, 'Ron', 'Weasley', '', '911', 'Hogwarts', '2018-04-27 10:53:13', NULL);

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
('abc-123', 7, 'White', 3, 1, 'MU-X', NULL),
('abc-124', 7, 'red', 4, 2, 'mio', NULL),
('ANA-5070', 4, 'Blue', 3, 1, 'MUX', NULL),
('ASD-6576', 5, 'Black', 5, 2, 'AXD', NULL),
('asd123', 1, 'blue', 3, 2, '', NULL),
('boo-0001', 3, 'Pearl White', 4, 4, 'Aventador', NULL),
('QWS-956', 6, 'Green', 5, 1, 'Everest', NULL),
('XD239', 2, 'blue', 1, 2, 'vios', NULL),
('ZXC09123', 1, 'violet', 6, 2, '', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `descriptions`
--

CREATE TABLE `descriptions` (
  `description_ID` int(11) NOT NULL,
  `desc_name` varchar(250) NOT NULL,
  `desc_type` varchar(10) NOT NULL,
  `desc_unit` varchar(250) NOT NULL,
  `date_deleted` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `descriptions`
--

INSERT INTO `descriptions` (`description_ID`, `desc_name`, `desc_type`, `desc_unit`, `date_deleted`) VALUES
(1, 'Volume', 'Numeric', 'ml', NULL),
(2, 'Viscosity', 'Text', '', '2018-04-27 17:01:32'),
(3, 'Color', 'Text', '', NULL),
(4, 'Length', 'Numeric', 'cm', NULL);

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
(5, 'asdad', 'asd', 'asda', 'asd', 'assd', NULL),
(6, 'loon', 'prince', 'a', 'tester', 'ayala recodo bolong', NULL),
(7, 'Beethoven', 'Ludwig', '', 'Washer', 'Vienna', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `payments`
--

CREATE TABLE `payments` (
  `payment_ID` int(11) NOT NULL,
  `payment` decimal(10,2) NOT NULL,
  `date_paid` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `transac_ID` int(11) NOT NULL,
  `user_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `payments`
--

INSERT INTO `payments` (`payment_ID`, `payment`, `date_paid`, `transac_ID`, `user_ID`) VALUES
(1, '350.00', '2018-04-27 05:47:49', 10000001, 10),
(2, '350.00', '2018-04-27 05:48:56', 10000001, 10),
(3, '925.00', '2018-04-27 07:37:52', 10000002, 10),
(4, '1525.00', '2018-04-27 07:39:40', 10000002, 10),
(5, '4000.00', '2018-04-27 07:45:37', 10000003, 10),
(6, '425.00', '2018-04-27 07:47:25', 10000004, 10),
(7, '725.00', '2018-04-27 07:48:06', 10000004, 10),
(8, '150.00', '2018-04-27 08:06:18', 10000005, 10),
(9, '300.00', '2018-04-27 08:08:02', 10000006, 10),
(10, '162.50', '2018-04-27 08:50:46', 10000007, 10),
(11, '150.00', '2018-04-27 09:08:18', 10000008, 11),
(12, '362.50', '2018-04-27 09:10:50', 10000009, 11),
(13, '1037.50', '2018-04-27 09:13:20', 10000009, 11),
(14, '205.00', '2018-04-27 10:29:29', 10000010, 10),
(15, '162.50', '2018-04-27 10:35:11', 10000007, 10),
(16, '500.00', '2018-04-28 11:00:38', 10000011, 15),
(17, '3361.00', '2018-05-01 01:59:50', 10000012, 15),
(18, '100.00', '2018-05-01 02:04:25', 10000012, 15),
(19, '3465.00', '2018-05-01 05:57:16', 10000013, 10),
(20, '3372.00', '2018-05-01 06:11:22', 10000014, 10),
(21, '5000.00', '2018-05-01 06:13:14', 10000014, 10),
(22, '100.00', '2018-05-01 06:19:22', 10000015, 10),
(23, '100.00', '2018-05-09 16:20:36', 10000015, 10),
(24, '1534.50', '2018-05-01 06:21:45', 10000016, 10),
(25, '1600.50', '2018-05-01 06:22:26', 10000016, 10),
(26, '137.50', '2018-05-01 06:27:37', 10000017, 10),
(27, '1550.00', '2018-05-01 06:28:40', 10000018, 10),
(28, '200.00', '2018-05-01 06:28:56', 10000017, 10),
(29, '1600.00', '2018-05-01 06:29:39', 10000018, 10),
(30, '100.00', '2018-05-01 06:32:31', 10000019, 10),
(31, '0.00', '2018-05-01 06:33:01', 10000019, 10),
(32, '2500.00', '2018-05-01 06:55:05', 10000020, 10),
(33, '0.00', '2018-05-01 06:55:37', 10000020, 10),
(34, '1550.00', '2018-05-01 07:05:23', 10000021, 10),
(35, '1450.00', '2018-05-01 07:07:32', 10000021, 10),
(36, '1550.00', '2018-05-02 00:01:19', 10000022, 10),
(37, '550.00', '2018-05-02 00:02:01', 10000022, 10),
(38, '1550.00', '2018-05-02 00:06:38', 10000023, 10),
(39, '1447.00', '2018-05-02 00:13:36', 10000023, 10),
(40, '1550.00', '2018-05-02 00:39:11', 10000024, 10),
(41, '1450.00', '2018-05-02 00:41:01', 10000024, 10),
(42, '1000.00', '2018-05-02 03:13:48', 10000025, 10),
(43, '500.00', '2018-05-02 03:14:03', 10000025, 10),
(44, '1550.00', '2018-05-02 03:15:10', 10000026, 10),
(45, '-1650.00', '2018-05-02 03:16:54', 10000026, 10),
(46, '100.00', '2018-05-02 03:40:37', 10000027, 10),
(47, '100.00', '2018-05-02 03:42:53', 10000027, 10),
(48, '2475.00', '2018-05-02 03:43:58', 10000028, 10),
(49, '220.00', '2018-05-02 03:44:14', 10000028, 10),
(50, '2255.00', '2018-05-02 03:50:16', 10000028, 10),
(51, '1365.00', '2018-05-31 15:49:48', 10000001, 10),
(52, '910.00', '2018-05-31 16:04:16', 10000002, 10),
(53, '1365.00', '2018-05-31 16:13:58', 10000003, 10),
(54, '800.00', '2018-05-31 16:23:11', 10000004, 10),
(55, '1000.00', '2018-06-01 05:23:49', 10000005, 10),
(56, '900.00', '2018-06-01 05:36:38', 10000006, 10),
(57, '1000.00', '2018-06-03 13:49:22', 10000007, 10),
(58, '600.00', '2018-06-04 17:25:16', 10000001, 10);

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
('123', 'Ultron', 1, 1, '2018-04-26 08:01:00', NULL),
('1344134132', '2T Autolube', 1, 4, '2018-04-27 05:15:18', NULL),
('212', 'Ultron-X', 1, 4, '2018-04-27 07:43:07', NULL),
('23434545444454', 'Ultron Race ', 1, 4, '2018-04-27 05:19:42', NULL),
('456', 'Rev-X', 1, 3, '2018-04-26 08:35:58', NULL),
('54321', '4T', 1, 1, '2018-05-06 02:21:45', NULL),
('74569467978', '2T Premium', 1, 4, '2018-04-27 05:24:15', NULL),
('8989', '2T', 5, 6, '2018-04-27 10:49:39', NULL),
('987', 'Visor awesome', 4, 5, '2018-04-27 09:43:26', NULL);

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
('123', 1, '50'),
('123', 2, '15w-40'),
('456', 5, '500'),
('456', 6, '40-w'),
('23434545444454', 7, '1000'),
('23434545444454', 8, '5w-40'),
('1344134132', 7, '100'),
('1344134132', 8, '40w'),
('74569467978', 7, '50'),
('74569467978', 8, '15w'),
('212', 7, '100'),
('212', 8, '5w'),
('987', 9, 'Red'),
('987', 10, '20'),
('8989', 11, '50'),
('54321', 1, '500'),
('54321', 2, ' 40-wl');

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
(1, '456', '600.00', 0, '600.00'),
(2, '1344134132', '200.00', 0, '200.00'),
(3, '23434545444454', '300.00', 0, '300.00'),
(4, '74569467978', '100.00', 0, '100.00'),
(5, '123', '500.00', 9, '455.00'),
(6, '212', '200.00', 0, '200.00'),
(7, '987', '6000.00', 0, '6000.00'),
(8, '8989', '200.00', 0, '200.00');

-- --------------------------------------------------------

--
-- Stand-in structure for view `product_print`
-- (See below for the actual view)
--
CREATE TABLE `product_print` (
`product_ID` varchar(100)
,`product_name` varchar(250)
,`brand_name` varchar(250)
,`category_name` varchar(250)
,`prodDesc` text
,`productPrice` varchar(13)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `product_prints`
-- (See below for the actual view)
--
CREATE TABLE `product_prints` (
`product_ID` varchar(100)
,`product_name` varchar(250)
,`brand_name` varchar(250)
,`category_name` varchar(250)
,`prodDesc` text
,`productPrice` varchar(13)
);

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
(10000001, '1344134132', 3, '600.00', '2018-06-04 17:25:16');

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
(8, 'Change Oil', 'changing of oil that is unusable', NULL),
(9, 'Engine Wash', '', NULL);

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
(1, 1),
(2, 1),
(2, 2),
(2, 3),
(3, 2),
(3, 3),
(5, 1),
(5, 2),
(6, 2),
(4, 2),
(4, 3),
(7, 7),
(8, 3),
(9, 2),
(9, 5),
(10, 5),
(11, 3),
(11, 6),
(12, 6),
(13, 1),
(13, 7),
(14, 1),
(15, 3),
(16, 5),
(16, 7),
(17, 2),
(17, 5),
(18, 3),
(19, 6),
(20, 1),
(20, 2),
(21, 2),
(22, 3),
(22, 5),
(23, 3),
(24, 3),
(24, 5),
(25, 5);

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
(7, 4, 1, '300.00'),
(10, 4, 5, '275.00'),
(11, 7, 6, '2000.00'),
(12, 7, 4, '5000.00'),
(13, 8, 5, '3000.00'),
(18, 7, 5, '2000.00'),
(19, 4, 3, '275.00'),
(20, 4, 4, '300.00'),
(21, 4, 6, '300.00'),
(22, 8, 1, '3000.00'),
(23, 8, 6, '3000.00'),
(24, 8, 3, '2000.00'),
(25, 9, 1, '200.00'),
(26, 9, 3, '200.00'),
(27, 9, 4, '200.00'),
(28, 9, 5, '200.00'),
(29, 9, 6, '200.00');

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
(1, '2018-04-27 05:48:56', '2018-04-26 17:48:56', 'Finished', 10000001, 4, 'ANA-5070', '250.00'),
(2, '2018-04-27 07:39:39', '2018-04-26 19:39:39', 'Finished', 10000002, 4, 'ANA-5070', '350.00'),
(3, '2018-04-27 07:48:04', '2018-04-26 19:48:04', 'Finished', 10000004, 4, 'ANA-5070', '250.00'),
(4, '2018-04-27 10:35:10', '2018-04-26 22:35:10', 'Finished', 10000007, 4, 'XD239', '325.00'),
(5, '2018-04-27 09:13:19', '2018-04-26 21:13:19', 'Finished', 10000009, 4, 'ANA-5070', '325.00'),
(6, '2018-04-27 09:13:20', '2018-04-26 21:13:20', 'Finished', 10000009, 4, 'ANA-5070', '375.00'),
(7, '2018-04-27 11:00:37', '2018-04-26 23:00:37', 'Finished', 10000011, 9, 'abc-123', '200.00'),
(8, '2018-05-01 02:04:25', '2018-05-01 02:04:25', 'Finished', 10000012, 8, 'abc-123', '3100.00'),
(9, '2018-05-01 05:57:15', '2018-04-30 17:57:15', 'Finished', 10000013, 9, 'abc-123', '200.00'),
(10, '2018-05-01 05:57:16', '2018-04-30 17:57:16', 'Finished', 10000013, 8, 'abc-123', '3100.00'),
(11, '2018-05-01 06:13:13', '2018-04-30 18:13:13', 'Finished', 10000014, 4, 'abc-123', '425.00'),
(12, '2018-05-01 06:20:02', '2018-04-30 18:20:02', 'Finished', 10000015, 9, 'abc-123', '200.00'),
(13, '2018-05-01 06:22:26', '2018-04-30 18:22:26', 'Finished', 10000016, 8, 'abc-123', '3100.00'),
(14, '2018-05-01 06:28:56', '2018-04-30 18:28:56', 'Finished', 10000017, 4, 'abc-123', '275.00'),
(15, '2018-05-01 06:29:38', '2018-04-30 18:29:38', 'Finished', 10000018, 8, 'abc-123', '3100.00'),
(16, '2018-05-01 06:33:01', '2018-04-30 18:33:01', 'Finished', 10000019, 9, 'abc-123', '200.00'),
(17, '2018-05-01 06:55:36', '2018-04-30 18:55:36', 'Finished', 10000020, 7, 'abc-124', '5000.00'),
(18, '2018-05-01 07:06:42', '2018-04-30 19:06:42', 'Finished', 10000021, 8, 'ASD-6576', '3100.00'),
(19, '2018-05-02 00:01:36', '2018-05-02 00:01:36', 'Finished', 10000022, 8, 'ZXC09123', '3100.00'),
(20, '2018-05-02 00:11:24', '2018-05-02 00:11:24', 'Finished', 10000023, 8, 'XD239', '3100.00'),
(21, '2018-05-02 00:40:24', '2018-05-02 00:40:24', 'Finished', 10000024, 8, 'XD239', '3100.00'),
(22, '2018-05-02 03:14:02', '2018-05-02 03:14:02', 'Finished', 10000025, 7, 'QWS-956', '2000.00'),
(23, '2018-05-02 03:16:54', '2018-05-02 03:16:54', 'Finished', 10000026, 8, 'QWS-956', '3100.00'),
(24, '2018-05-02 03:42:53', '2018-05-02 03:42:53', 'Finished', 10000027, 9, 'boo-0001', '200.00'),
(25, '2018-05-02 03:50:16', '2018-05-02 03:50:16', 'Finished', 10000028, 7, 'boo-0001', '5000.00');

-- --------------------------------------------------------

--
-- Table structure for table `settings`
--

CREATE TABLE `settings` (
  `setting_ID` int(11) NOT NULL,
  `taxpayer_name` varchar(250) NOT NULL,
  `business_name` varchar(250) NOT NULL,
  `is_vat_registered` varchar(250) NOT NULL,
  `tax_identification_number` varchar(250) NOT NULL,
  `branch_code` varchar(250) NOT NULL,
  `machine_identification_number` varchar(250) NOT NULL,
  `business_address` varchar(250) NOT NULL,
  `vat_percent` double NOT NULL,
  `critical_stock_warning` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `settings`
--

INSERT INTO `settings` (`setting_ID`, `taxpayer_name`, `business_name`, `is_vat_registered`, `tax_identification_number`, `branch_code`, `machine_identification_number`, `business_address`, `vat_percent`, `critical_stock_warning`) VALUES
(0, 'Mr. Crab', 'ALG Auto Care', '', '00-199032-313', '212-214-42-4-44231', '21-21235-124', 'Tetuan Highway', 12, 10);

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
('STK-1000001', '456', 2, '2018-04-03 00:00:00', 16, 14, '500.00', NULL),
('STK-1000002', '1344134132', 2, '2018-04-27 00:00:00', 40, 0, '100.00', NULL),
('STK-1000003', '23434545444454', 2, '2018-04-27 00:00:00', 30, 24, '100.00', NULL),
('STK-1000004', '74569467978', 2, '2018-04-27 00:00:00', 20, 19, '100.00', NULL),
('STK-1000005', '123', 1, '2018-04-27 00:00:00', 20, 5, '100.00', NULL),
('STK-1000006', '212', 8, '2018-04-27 00:00:00', 40, 10, '50.00', NULL),
('STK-1000007', '987', 1, '2018-04-26 00:00:00', 10, 2, '5000.00', NULL),
('STK-1000008', '987', 2, '2018-04-27 00:00:00', 10, 10, '4500.00', NULL),
('STK-1000009', '123', 7, '2018-04-27 00:00:00', 5, 5, '150.00', NULL),
('STK-1000010', '8989', 8, '2018-04-27 00:00:00', 20, 18, '180.00', NULL),
('STK-1000011', '1344134132', 6, '2018-05-07 00:00:00', 20, 19, '10.00', NULL),
('STK-1000012', '456', 1, '2018-05-09 00:00:00', 10, 10, '600.00', NULL);

-- --------------------------------------------------------

--
-- Stand-in structure for view `stocks_print`
-- (See below for the actual view)
--
CREATE TABLE `stocks_print` (
`stock_ID` varchar(20)
,`product_ID` varchar(100)
,`product_name` varchar(250)
,`brand_name` varchar(250)
,`category_name` varchar(250)
,`prodDesc` text
,`productPrice` varchar(13)
,`sumTotStocks` decimal(32,0)
,`sumRemStocks` decimal(32,0)
);

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
(1, 'ABG Company', '09897351531', 'Putik, Zamboanga City', '2018-04-27 05:35:36', NULL),
(2, 'Supplier One', '0987654323', 'Zamboanga Sibugay', '2018-04-27 05:36:45', NULL),
(3, 'alg', '911', 'tetuan', '2018-04-22 01:28:18', '2018-03-31 16:38:29'),
(4, '232e', 'eeeee', '2323e', '2018-04-22 01:28:18', '2018-03-31 16:37:31'),
(5, 'we', 'wer', 'wer', '2018-04-22 01:28:18', '2018-03-31 16:38:33'),
(6, 'Toto', '0987654321', 'Marloquet', '2018-04-22 01:28:18', NULL),
(7, 'JRB Company', '0912345678', 'Pagadian City', '2018-04-27 05:36:16', NULL),
(8, 'JMO Company', '534153782', 'Philippines', '2018-04-27 05:35:52', NULL);

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
(10000001, '2018-06-04 17:25:15', 0, '600.00', '600.00', '600.00', '0.00', NULL, '600.00', '0.00', '535.71', '64.29', 12);

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
(1, 'Mozart', 'Wolfgang', 'A', '2', '2', '2018-03-11 01:43:12', 'cashier', 0, 'Austria', NULL),
(2, 'Beethoven', 'Ludwig', 'V', '3', '3', '2018-03-11 01:40:18', 'encoder', 0, 'Germany', NULL),
(3, 'Saint-Saens', 'Camille', '', '1', '1', '2018-05-15 16:41:39', 'admin', 0, '', NULL),
(5, 'Gregorio', 'Karen', 'A', 'kaye', 'kaye02', '2018-02-23 00:07:08', 'admin', 0, 'Tumaga, Zamboanga City', NULL),
(10, 'Doe', 'John', 'F', '123', '123', '2018-06-06 14:30:56', 'admin', 1, '', NULL),
(11, 'Jobs', 'Steve', '', '1234', '1234', '2018-04-27 02:01:33', 'cashier', 0, '', NULL),
(12, 'Gates', 'Bill', '', 'f', 'f', '2018-04-27 02:01:38', 'encoder', 0, '', NULL),
(13, 'Mouse', 'Minnie', 'M', 'mini', 'mini', '2018-04-27 02:45:44', 'cashier', 0, 'Disneyland', NULL),
(14, 'Duck', 'Daisy', 'D', 'duck', 'duck', '2018-04-30 22:31:36', 'encoder', 0, 'Disneyland', NULL),
(15, 'Poppins', 'Marry', '', 'mary', 'mary', '2018-04-30 18:05:29', 'cashier', 0, 'London', NULL),
(16, 'Snape', 'Severus', '', 'snape', 'snape', '2018-04-27 02:50:56', 'encoder', 0, 'Hogwarts', NULL);

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

-- --------------------------------------------------------

--
-- Structure for view `product_print`
--
DROP TABLE IF EXISTS `product_print`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `product_print`  AS  select `products`.`product_ID` AS `product_ID`,`products`.`product_name` AS `product_name`,`brands`.`brand_name` AS `brand_name`,`categories`.`category_name` AS `category_name`,if(isnull(group_concat(distinct `product_description`.`product_desc_value`,' ',`descriptions`.`desc_unit` separator ',')),'No description set',group_concat(distinct `product_description`.`product_desc_value`,' ',`descriptions`.`desc_unit` separator ',')) AS `prodDesc`,if(isnull(`product_prices`.`product_price`),'Price not set',`product_prices`.`product_price`) AS `productPrice` from ((((((`products` left join `product_prices` on((`products`.`product_ID` = `product_prices`.`product_ID`))) left join `product_description` on((`products`.`product_ID` = `product_description`.`product_ID`))) left join `category_description` on((`product_description`.`cat_desc_ID` = `category_description`.`cat_desc_ID`))) left join `descriptions` on((`category_description`.`description_ID` = `descriptions`.`description_ID`))) join `brands`) join `categories`) where ((`products`.`brand_ID` = `brands`.`brand_ID`) and (`categories`.`category_ID` = `products`.`category_ID`) and isnull(`products`.`date_deleted`)) group by `products`.`product_ID` ;

-- --------------------------------------------------------

--
-- Structure for view `product_prints`
--
DROP TABLE IF EXISTS `product_prints`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `product_prints`  AS  select `products`.`product_ID` AS `product_ID`,`products`.`product_name` AS `product_name`,`brands`.`brand_name` AS `brand_name`,`categories`.`category_name` AS `category_name`,if(isnull(group_concat(distinct `product_description`.`product_desc_value`,' ',`descriptions`.`desc_unit` separator ',')),'No description set',group_concat(distinct `product_description`.`product_desc_value`,' ',`descriptions`.`desc_unit` separator ',')) AS `prodDesc`,if(isnull(`product_prices`.`product_price`),'Price not set',`product_prices`.`product_price`) AS `productPrice` from ((((((`products` left join `product_prices` on((`products`.`product_ID` = `product_prices`.`product_ID`))) left join `product_description` on((`products`.`product_ID` = `product_description`.`product_ID`))) left join `category_description` on((`product_description`.`cat_desc_ID` = `category_description`.`cat_desc_ID`))) left join `descriptions` on((`category_description`.`description_ID` = `descriptions`.`description_ID`))) join `brands`) join `categories`) where ((`products`.`brand_ID` = `brands`.`brand_ID`) and (`categories`.`category_ID` = `products`.`category_ID`) and isnull(`products`.`date_deleted`)) group by `products`.`product_ID` ;

-- --------------------------------------------------------

--
-- Structure for view `stocks_print`
--
DROP TABLE IF EXISTS `stocks_print`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `stocks_print`  AS  select `stocks`.`stock_ID` AS `stock_ID`,`products`.`product_ID` AS `product_ID`,`products`.`product_name` AS `product_name`,`brands`.`brand_name` AS `brand_name`,`categories`.`category_name` AS `category_name`,if(isnull(group_concat(distinct `product_description`.`product_desc_value`,' ',`descriptions`.`desc_unit` separator ',')),'No description set',group_concat(distinct `product_description`.`product_desc_value`,' ',`descriptions`.`desc_unit` separator ',')) AS `prodDesc`,if(isnull(`product_prices`.`product_price`),'Price not set',`product_prices`.`product_price`) AS `productPrice`,sum(`stocks`.`total_stocks`) AS `sumTotStocks`,sum(`stocks`.`remaining_stocks`) AS `sumRemStocks` from (((((((`products` left join `product_prices` on((`products`.`product_ID` = `product_prices`.`product_ID`))) left join `product_description` on((`products`.`product_ID` = `product_description`.`product_ID`))) left join `category_description` on((`product_description`.`cat_desc_ID` = `category_description`.`cat_desc_ID`))) left join `descriptions` on((`category_description`.`description_ID` = `descriptions`.`description_ID`))) left join `stocks` on((`products`.`product_ID` = `stocks`.`product_ID`))) join `brands`) join `categories`) where ((`products`.`brand_ID` = `brands`.`brand_ID`) and (`categories`.`category_ID` = `products`.`category_ID`) and isnull(`products`.`date_deleted`) and isnull(`stocks`.`date_deleted`)) group by `stocks`.`stock_ID` ;

--
-- Indexes for dumped tables
--

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
-- AUTO_INCREMENT for table `vehicle_brands`
--
ALTER TABLE `vehicle_brands`
  MODIFY `vehicle_brand_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `vehicle_types`
--
ALTER TABLE `vehicle_types`
  MODIFY `vehicletype_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
