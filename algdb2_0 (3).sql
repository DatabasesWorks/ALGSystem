-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 10, 2018 at 04:09 AM
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
(6, 'tint', NULL);

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
(15, 4, 4);

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
(1, 'Bach', 'Johann', 'S', '911', 'Somewhere', '2018-03-09 05:34:41', NULL);

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
(4, 'Quality', 'Text', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `emp_ID` int(11) NOT NULL,
  `emp_fName` varchar(25) NOT NULL,
  `emp_gName` varchar(25) NOT NULL,
  `emp_mInitial` varchar(10) NOT NULL,
  `emp_position` varchar(25) NOT NULL,
  `emp_address` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`emp_ID`, `emp_fName`, `emp_gName`, `emp_mInitial`, `emp_position`, `emp_address`) VALUES
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
  `cash` int(11) NOT NULL,
  `date_paid` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `transac_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

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
('4800092553929', 13, 'good');

-- --------------------------------------------------------

--
-- Table structure for table `product_prices`
--

CREATE TABLE `product_prices` (
  `product_price_ID` int(11) NOT NULL,
  `product_ID` varchar(50) NOT NULL,
  `product_price` double NOT NULL,
  `discount` int(11) NOT NULL,
  `discounted_price` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `product_prices`
--

INSERT INTO `product_prices` (`product_price_ID`, `product_ID`, `product_price`, `discount`, `discounted_price`) VALUES
(1, '4800092553929', 5018, 50, 2509),
(2, 'dsaas', 800, 0, 800);

-- --------------------------------------------------------

--
-- Table structure for table `prod_trans_rela`
--

CREATE TABLE `prod_trans_rela` (
  `prod_transac_rela_ID` int(11) NOT NULL,
  `product_ID` varchar(50) NOT NULL,
  `quantity` int(11) NOT NULL,
  `total` int(11) NOT NULL,
  `date_bought` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `service`
--

CREATE TABLE `service` (
  `service_ID` int(11) NOT NULL,
  `service_name` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `service`
--

INSERT INTO `service` (`service_ID`, `service_name`) VALUES
(4, 'Carwash'),
(5, 'Special Wax'),
(6, 'Wax'),
(7, 'Paint'),
(8, 'Change Oil');

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
-- Table structure for table `service_price`
--

CREATE TABLE `service_price` (
  `service_price_ID` int(11) NOT NULL,
  `service_ID` int(11) NOT NULL,
  `vehicletype_ID` int(11) NOT NULL,
  `service_fee` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `service_price`
--

INSERT INTO `service_price` (`service_price_ID`, `service_ID`, `vehicletype_ID`, `service_fee`) VALUES
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
  `service_status` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- --------------------------------------------------------

--
-- Table structure for table `serv_added_charges`
--

CREATE TABLE `serv_added_charges` (
  `serv_added_ID` int(11) NOT NULL,
  `service_ID` int(11) NOT NULL,
  `serv_added_name` varchar(25) NOT NULL,
  `serv_added_price` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `serv_added_charges`
--

INSERT INTO `serv_added_charges` (`serv_added_ID`, `service_ID`, `serv_added_name`, `serv_added_price`) VALUES
(1, 4, 'Wax', 50),
(2, 4, 'Vacuum', 100);

-- --------------------------------------------------------

--
-- Table structure for table `serv_emp`
--

CREATE TABLE `serv_emp` (
  `service_trans_ID` int(11) NOT NULL,
  `emp_ID` int(11) NOT NULL,
  `servID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
  `supplier_price` double NOT NULL,
  `date_deleted` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `stocks`
--

INSERT INTO `stocks` (`stock_ID`, `product_ID`, `supplier_ID`, `received_date`, `total_stocks`, `remaining_stocks`, `supplier_price`, `date_deleted`) VALUES
('STK-1000001', 'dsaas', 1, '2018-03-31 00:00:00', 5, 5, 160, NULL),
('STK-1000002', '4800092553929', 2, '2018-03-29 00:00:00', 6, 6, 20, NULL),
('STK-1000003', '4800092553929', 1, '2018-03-31 00:00:00', 20, 0, 8, '2018-03-31 06:49:19'),
('STK-1000004', 'dsaas', 2, '2018-03-31 00:00:00', 1, 1, 3, '2018-03-31 06:40:37');

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
  `prod_transac_rela_ID` int(11) NOT NULL,
  `servtransac_ID` int(11) NOT NULL,
  `payment_ID` int(11) NOT NULL,
  `discount` int(11) NOT NULL,
  `discounted_amount` double NOT NULL,
  `total_amount` double NOT NULL,
  `paid` double NOT NULL,
  `balance` double NOT NULL,
  `customer_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

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
(10, '', '', '', '123', '?e?Y B/?A~Hg??O??J???~??????z?', '2018-04-08 05:06:27', 'admin', 0, ''),
(11, '', '', '', '1234', '?gB??\\v??U?g?6#???E??x??F?', '2018-03-25 20:46:31', 'cashier', 0, ''),
(12, '', '', '', 'f', '%/?6??\Z???U??[??????$????', '2018-03-27 03:19:28', 'encoder', 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `vehicle_type`
--

CREATE TABLE `vehicle_type` (
  `vehicletype_ID` int(11) NOT NULL,
  `vehicle_type` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `vehicle_type`
--

INSERT INTO `vehicle_type` (`vehicletype_ID`, `vehicle_type`) VALUES
(1, 'SEDAN'),
(3, 'SUV'),
(4, 'MID SUV'),
(5, 'VAN'),
(6, 'COMPACT CAR');

--
-- Indexes for dumped tables
--

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
-- Indexes for table `descriptions`
--
ALTER TABLE `descriptions`
  ADD PRIMARY KEY (`description_ID`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`emp_ID`);

--
-- Indexes for table `payments`
--
ALTER TABLE `payments`
  ADD PRIMARY KEY (`payment_ID`);

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
  ADD PRIMARY KEY (`prod_transac_rela_ID`),
  ADD KEY `product_ID` (`product_ID`);

--
-- Indexes for table `service`
--
ALTER TABLE `service`
  ADD PRIMARY KEY (`service_ID`);

--
-- Indexes for table `service_logs`
--
ALTER TABLE `service_logs`
  ADD PRIMARY KEY (`sr_log_id`),
  ADD KEY `user_ID` (`user_ID`),
  ADD KEY `service_ID` (`service_ID`);

--
-- Indexes for table `service_price`
--
ALTER TABLE `service_price`
  ADD PRIMARY KEY (`service_price_ID`),
  ADD KEY `service_ID` (`service_ID`),
  ADD KEY `vehicletype_ID` (`vehicletype_ID`);

--
-- Indexes for table `service_transac`
--
ALTER TABLE `service_transac`
  ADD PRIMARY KEY (`servtransac_ID`);

--
-- Indexes for table `serv_added_charges`
--
ALTER TABLE `serv_added_charges`
  ADD PRIMARY KEY (`serv_added_ID`),
  ADD KEY `service_ID` (`service_ID`);

--
-- Indexes for table `serv_emp`
--
ALTER TABLE `serv_emp`
  ADD PRIMARY KEY (`servID`),
  ADD KEY `emp_ID` (`emp_ID`),
  ADD KEY `service_trans_ID` (`service_trans_ID`);

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
  ADD KEY `prod_transac_rela_ID` (`prod_transac_rela_ID`),
  ADD KEY `servtransac_ID` (`servtransac_ID`),
  ADD KEY `payment_ID` (`payment_ID`),
  ADD KEY `customer_ID` (`customer_ID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`userID`);

--
-- Indexes for table `vehicle_type`
--
ALTER TABLE `vehicle_type`
  ADD PRIMARY KEY (`vehicletype_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `brands`
--
ALTER TABLE `brands`
  MODIFY `brand_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `category_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `category_description`
--
ALTER TABLE `category_description`
  MODIFY `cat_desc_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
--
-- AUTO_INCREMENT for table `descriptions`
--
ALTER TABLE `descriptions`
  MODIFY `description_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `emp_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `payments`
--
ALTER TABLE `payments`
  MODIFY `payment_ID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `product_prices`
--
ALTER TABLE `product_prices`
  MODIFY `product_price_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `prod_trans_rela`
--
ALTER TABLE `prod_trans_rela`
  MODIFY `prod_transac_rela_ID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `service`
--
ALTER TABLE `service`
  MODIFY `service_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `service_logs`
--
ALTER TABLE `service_logs`
  MODIFY `sr_log_id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `service_price`
--
ALTER TABLE `service_price`
  MODIFY `service_price_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
--
-- AUTO_INCREMENT for table `serv_added_charges`
--
ALTER TABLE `serv_added_charges`
  MODIFY `serv_added_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `serv_emp`
--
ALTER TABLE `serv_emp`
  MODIFY `servID` int(11) NOT NULL AUTO_INCREMENT;
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
-- AUTO_INCREMENT for table `vehicle_type`
--
ALTER TABLE `vehicle_type`
  MODIFY `vehicletype_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `category_description`
--
ALTER TABLE `category_description`
  ADD CONSTRAINT `category_description_ibfk_1` FOREIGN KEY (`category_ID`) REFERENCES `categories` (`category_ID`),
  ADD CONSTRAINT `category_description_ibfk_2` FOREIGN KEY (`description_ID`) REFERENCES `descriptions` (`description_ID`);

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
  ADD CONSTRAINT `prod_trans_rela_ibfk_1` FOREIGN KEY (`product_ID`) REFERENCES `products` (`product_ID`);

--
-- Constraints for table `service_price`
--
ALTER TABLE `service_price`
  ADD CONSTRAINT `service_price_ibfk_1` FOREIGN KEY (`service_ID`) REFERENCES `service` (`service_ID`),
  ADD CONSTRAINT `service_price_ibfk_2` FOREIGN KEY (`vehicletype_ID`) REFERENCES `vehicle_type` (`vehicletype_ID`);

--
-- Constraints for table `serv_added_charges`
--
ALTER TABLE `serv_added_charges`
  ADD CONSTRAINT `serv_added_charges_ibfk_1` FOREIGN KEY (`service_ID`) REFERENCES `service` (`service_ID`);

--
-- Constraints for table `serv_emp`
--
ALTER TABLE `serv_emp`
  ADD CONSTRAINT `serv_emp_ibfk_1` FOREIGN KEY (`service_trans_ID`) REFERENCES `service_transac` (`servtransac_ID`),
  ADD CONSTRAINT `serv_emp_ibfk_2` FOREIGN KEY (`emp_ID`) REFERENCES `employee` (`emp_ID`);

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
  ADD CONSTRAINT `transactions_ibfk_1` FOREIGN KEY (`prod_transac_rela_ID`) REFERENCES `prod_trans_rela` (`prod_transac_rela_ID`),
  ADD CONSTRAINT `transactions_ibfk_2` FOREIGN KEY (`servtransac_ID`) REFERENCES `service_transac` (`servtransac_ID`),
  ADD CONSTRAINT `transactions_ibfk_3` FOREIGN KEY (`payment_ID`) REFERENCES `payments` (`payment_ID`),
  ADD CONSTRAINT `transactions_ibfk_4` FOREIGN KEY (`customer_ID`) REFERENCES `customers` (`cust_ID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
