-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 24, 2023 at 02:44 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.1.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `project`
--

-- --------------------------------------------------------

--
-- Table structure for table `center`
--

CREATE TABLE `center` (
  `id` int(30) NOT NULL,
  `adrress` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `center`
--

INSERT INTO `center` (`id`, `adrress`) VALUES
(1, 'istanbul'),
(2, 'MILAN'),
(3, 'madrid');

-- --------------------------------------------------------

--
-- Table structure for table `item`
--

CREATE TABLE `item` (
  `id` int(20) NOT NULL,
  `iteamName` varchar(60) NOT NULL,
  `stock` int(20) NOT NULL,
  `adrress` text NOT NULL,
  `note` text NOT NULL,
  `dateAdd` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `item`
--

INSERT INTO `item` (`id`, `iteamName`, `stock`, `adrress`, `note`, `dateAdd`) VALUES
(1, 'lolo', 9, 'istanbul', 'know', '6/22/2023 9:06:39 PM'),
(5, 'ds,ds', 15, '', 'dlsdknsld', ''),
(9, 'book of moon', 90, 'madrid', 'a good loking book', '6/22/2023 9:07:50 PM'),
(15, 'bookss', 10, 'madrid', 'its okay', '6/22/2023 9:29:17 PM'),
(1550, 'mfh', 0, 'madrid', '0536787', ''),
(190706822, 'MIlk', 5, 'MILAN', '', '6/24/2023 1:10:24 PM');

-- --------------------------------------------------------

--
-- Table structure for table `kargo_order`
--

CREATE TABLE `kargo_order` (
  `id_order` int(15) NOT NULL,
  `date` varchar(200) NOT NULL,
  `quantities` int(15) NOT NULL,
  `id_customer` int(15) NOT NULL,
  `center_addres` varchar(200) NOT NULL,
  `id_item` int(15) NOT NULL,
  `kargo_volume` int(50) NOT NULL,
  `kargo_weight` int(50) NOT NULL,
  `estimated_departure` varchar(50) NOT NULL,
  `estimated_arrival` varchar(50) NOT NULL,
  `actual_departure` varchar(50) NOT NULL,
  `status` varchar(50) NOT NULL,
  `ship_to` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `kargo_order`
--

INSERT INTO `kargo_order` (`id_order`, `date`, `quantities`, `id_customer`, `center_addres`, `id_item`, `kargo_volume`, `kargo_weight`, `estimated_departure`, `estimated_arrival`, `actual_departure`, `status`, `ship_to`) VALUES
(12, '2023-06-22', 15, 19874, '', 5, 0, 0, '6/23/2023 12:42:24 AM', '6/23/2023 12:42:24 AM', '', 'declined', 'home'),
(14, '2023-06-22', 10, 190706, 'madrid', 15, 0, 0, '6/23/2023 1:53:06 AM', '6/23/2023 1:53:06 AM', '', 'approved', 'USA'),
(15, '2023-06-23', 9, 19874, 'istanbul', 1, 0, 0, '', '', '', 'waiting', 'urfa');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `center`
--
ALTER TABLE `center`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `item`
--
ALTER TABLE `item`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `kargo_order`
--
ALTER TABLE `kargo_order`
  ADD PRIMARY KEY (`id_order`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `center`
--
ALTER TABLE `center`
  MODIFY `id` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `kargo_order`
--
ALTER TABLE `kargo_order`
  MODIFY `id_order` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
