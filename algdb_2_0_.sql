-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 30, 2018 at 03:28 PM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
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
(4, 1);

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
('abc-123', 7, 'White', 5, 1, 'MU-X', NULL),
('ANA-5070', 4, 'Blue', 3, 1, 'MUX', NULL),
('ASD-6576', 5, 'Black', 5, 2, 'AXD', NULL),
('asd123', 1, 'blue', 3, 2, '', NULL),
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
(16, '500.00', '2018-04-27 11:00:38', 10000011, 15);

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
('8989', 11, '50');

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
(5, '123', '150.00', 0, '150.00'),
(6, '212', '200.00', 0, '200.00'),
(7, '987', '6000.00', 0, '6000.00'),
(8, '8989', '200.00', 0, '200.00');

-- --------------------------------------------------------

--
-- Table structure for table `product_prints`
--

CREATE TABLE `product_prints` (
  `product_ID` varchar(100) DEFAULT NULL,
  `product_name` varchar(250) DEFAULT NULL,
  `brand_name` varchar(250) DEFAULT NULL,
  `category_name` varchar(250) DEFAULT NULL,
  `prodDesc` text,
  `productPrice` varchar(13) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
(10000001, '123', 3, '450.00', '2018-04-27 05:47:48'),
(10000002, '1344134132', 5, '1500.00', '2018-04-27 07:37:50'),
(10000002, '456', 1, '600.00', '2018-04-27 07:39:39'),
(10000003, '212', 20, '4000.00', '2018-04-27 07:45:37'),
(10000004, '212', 3, '600.00', '2018-04-27 07:47:24'),
(10000004, '1344134132', 1, '300.00', '2018-04-27 07:48:04'),
(10000005, '74569467978', 1, '150.00', '2018-04-27 08:06:18'),
(10000006, '23434545444454', 1, '300.00', '2018-04-27 08:08:01'),
(10000008, '123', 1, '150.00', '2018-04-27 09:08:17'),
(10000009, '212', 2, '400.00', '2018-04-27 09:10:49'),
(10000009, '23434545444454', 1, '300.00', '2018-04-27 09:11:52'),
(10000010, '1344134132', 1, '200.00', '2018-04-27 10:29:29'),
(10000011, '8989', 2, '400.00', '2018-04-27 11:00:37');

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
(7, 7);

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
(7, '2018-04-27 11:00:37', '2018-04-26 23:00:37', 'Finished', 10000011, 9, 'abc-123', '200.00');

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
(1, '', '', '', '', '', '', '', 12, 0);

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
('STK-1000001', '456', 2, '2018-04-03 00:00:00', 16, 15, '500.00', NULL),
('STK-1000002', '1344134132', 2, '2018-04-27 00:00:00', 40, 17, '100.00', NULL),
('STK-1000003', '23434545444454', 2, '2018-04-27 00:00:00', 30, 28, '100.00', NULL),
('STK-1000004', '74569467978', 2, '2018-04-27 00:00:00', 20, 19, '100.00', NULL),
('STK-1000005', '123', 1, '2018-04-27 00:00:00', 20, 16, '100.00', NULL),
('STK-1000006', '212', 8, '2018-04-27 00:00:00', 40, 15, '50.00', NULL),
('STK-1000007', '987', 1, '2018-04-27 00:00:00', 10, 10, '5000.00', NULL),
('STK-1000008', '987', 2, '2018-04-27 00:00:00', 10, 10, '4500.00', NULL),
('STK-1000009', '123', 7, '2018-04-27 00:00:00', 5, 5, '150.00', NULL),
('STK-1000010', '8989', 8, '2018-04-27 00:00:00', 20, 18, '180.00', NULL);

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
(10000001, '2018-04-27 05:48:31', 0, '700.00', '700.00', '700.00', '0.00', 4, '450.00', '250.00', '625.00', '75.00', 12),
(10000002, '2018-04-27 07:39:38', 0, '2450.00', '2450.00', '2450.00', '0.00', 4, '2100.00', '350.00', '2187.50', '262.50', 12),
(10000003, '2018-04-27 07:45:37', 0, '4000.00', '4000.00', '4000.00', '0.00', NULL, '4000.00', '0.00', '3571.43', '428.57', 12),
(10000004, '2018-04-27 07:48:04', 0, '1150.00', '1150.00', '1150.00', '0.00', 4, '900.00', '250.00', '1026.79', '123.21', 12),
(10000005, '2018-04-27 08:06:18', 0, '150.00', '150.00', '150.00', '0.00', NULL, '150.00', '0.00', '133.93', '16.07', 12),
(10000006, '2018-04-27 08:08:01', 0, '300.00', '300.00', '300.00', '0.00', NULL, '300.00', '0.00', '267.86', '32.14', 12),
(10000007, '2018-04-27 10:35:10', 0, '325.00', '325.00', '325.00', '0.00', 2, '0.00', '325.00', '290.18', '34.82', 12),
(10000008, '2018-04-27 09:08:17', 0, '150.00', '150.00', '150.00', '0.00', NULL, '150.00', '0.00', '133.93', '16.07', 12),
(10000009, '2018-04-27 09:13:19', 0, '1400.00', '1400.00', '1400.00', '0.00', 4, '700.00', '700.00', '1250.00', '150.00', 12),
(10000010, '2018-04-27 10:29:29', 0, '200.00', '200.00', '205.00', '0.00', NULL, '200.00', '0.00', '178.57', '21.43', 12),
(10000011, '2018-04-27 11:00:37', 20, '480.00', '600.00', '500.00', '0.00', 7, '400.00', '200.00', '535.71', '64.29', 12);

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
(10, 'Doe', 'John', '', '123', '123', '2018-04-27 11:04:14', 'admin', 0, '', NULL),
(11, 'Jobs', 'Steve', '', '1234', '1234', '2018-04-27 10:01:33', 'cashier', 0, '', NULL),
(12, 'Gates', 'Bill', '', 'f', 'f', '2018-04-27 10:01:38', 'encoder', 0, '', NULL),
(13, 'Mouse', 'Minnie', 'M', 'mini', 'mini', '2018-04-27 10:45:44', 'cashier', 0, 'Disneyland', NULL),
(14, 'Duck', 'Daisy', 'D', 'duck', 'duck', '2018-04-27 10:33:11', 'encoder', 0, 'Disneyland', NULL),
(15, 'Poppins', 'Marry', '', 'mary', 'mary', '2018-04-27 11:01:19', 'cashier', 0, 'London', NULL),
(16, 'Snape', 'Severus', '', 'snape', 'snape', '2018-04-27 10:50:56', 'encoder', 0, 'Hogwarts', NULL);

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
  ADD KEY `transac_ID` (`transac_ID`),
  ADD KEY `user_ID` (`user_ID`);

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
  MODIFY `serv_added_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `brands`
--
ALTER TABLE `brands`
  MODIFY `brand_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `category_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `category_description`
--
ALTER TABLE `category_description`
  MODIFY `cat_desc_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `cust_ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `descriptions`
--
ALTER TABLE `descriptions`
  MODIFY `description_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `employees`
--
ALTER TABLE `employees`
  MODIFY `emp_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `payments`
--
ALTER TABLE `payments`
  MODIFY `payment_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
--
-- AUTO_INCREMENT for table `product_prices`
--
ALTER TABLE `product_prices`
  MODIFY `product_price_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `services`
--
ALTER TABLE `services`
  MODIFY `service_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `service_logs`
--
ALTER TABLE `service_logs`
  MODIFY `sr_log_id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `service_prices`
--
ALTER TABLE `service_prices`
  MODIFY `service_price_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;
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
  MODIFY `userID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
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
  ADD CONSTRAINT `payments_ibfk_1` FOREIGN KEY (`transac_ID`) REFERENCES `transactions` (`transac_ID`),
  ADD CONSTRAINT `payments_ibfk_2` FOREIGN KEY (`user_ID`) REFERENCES `users` (`userID`);

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
