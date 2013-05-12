-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: May 12, 2013 at 06:10 PM
-- Server version: 5.5.24-log
-- PHP Version: 5.4.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `shree_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `add_subject`
--

CREATE TABLE IF NOT EXISTS `add_subject` (
  `Class_Name` varchar(10) NOT NULL,
  `Sub_Name` varchar(20) NOT NULL,
  `Sub_Id` varchar(15) NOT NULL,
  `Fees` int(11) NOT NULL,
  PRIMARY KEY (`Class_Name`,`Sub_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `add_subject`
--

INSERT INTO `add_subject` (`Class_Name`, `Sub_Name`, `Sub_Id`, `Fees`) VALUES
('09', 'Maths', 'M9', 300),
('09', 'Science', 'S9', 300),
('10', 'Maths', 'M10', 300),
('10', 'Science', 'S10', 300),
('11', 'Chemistry', 'C11', 300),
('11', 'Maths', 'M11', 300),
('11', 'Physics', 'P11', 300),
('12', 'Chemistry', 'C12', 300),
('12', 'Maths', 'M12', 300),
('12', 'Physics', 'P12', 300);

-- --------------------------------------------------------

--
-- Table structure for table `add_test`
--

CREATE TABLE IF NOT EXISTS `add_test` (
  `DOT` date NOT NULL,
  `Class` varchar(10) NOT NULL,
  `Sub_Id` varchar(10) NOT NULL,
  `Max_Marks` int(11) NOT NULL,
  `Test_Id` varchar(20) NOT NULL,
  PRIMARY KEY (`Test_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `add_test`
--

INSERT INTO `add_test` (`DOT`, `Class`, `Sub_Id`, `Max_Marks`, `Test_Id`) VALUES
('2013-03-16', '09', 'M9', 100, 't9');

-- --------------------------------------------------------

--
-- Table structure for table `assign_subject`
--

CREATE TABLE IF NOT EXISTS `assign_subject` (
  `Class_Detail` varchar(5) NOT NULL,
  `Student_Id` varchar(20) NOT NULL,
  `Sub_Id` varchar(20) NOT NULL,
  PRIMARY KEY (`Student_Id`,`Sub_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `assign_subject`
--

INSERT INTO `assign_subject` (`Class_Detail`, `Student_Id`, `Sub_Id`) VALUES
('09', 'a', 'M9'),
('09', 'a', 'S9'),
('10 ', 'b', 'M10'),
('10 ', 'b', 'S10'),
('11', 'c', 'C11'),
('11', 'c', 'M11'),
('11', 'c', 'P11'),
('12', 'd', 'C12'),
('12', 'd', 'M12'),
('12', 'd', 'P12');

-- --------------------------------------------------------

--
-- Table structure for table `fees_status`
--

CREATE TABLE IF NOT EXISTS `fees_status` (
  `Year` varchar(10) NOT NULL,
  `Class` varchar(10) NOT NULL,
  `Student_Id` varchar(30) NOT NULL,
  `Subject_Id` varchar(30) NOT NULL,
  `Month` varchar(20) NOT NULL,
  `Check_DD_No` varchar(30) NOT NULL,
  `Amount` double NOT NULL,
  PRIMARY KEY (`Year`,`Student_Id`,`Month`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `fees_status`
--

INSERT INTO `fees_status` (`Year`, `Class`, `Student_Id`, `Subject_Id`, `Month`, `Check_DD_No`, `Amount`) VALUES
('2013', '09', 'a', 'M9', 'February', 'Not Available', 300),
('2013', '09', 'a', 'S9', 'January', '', 300),
('2013', '09', 'a', 'M9', 'May', 'Not Available', 300);

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE IF NOT EXISTS `login` (
  `User_Id` varchar(30) NOT NULL,
  `Password` varchar(40) NOT NULL,
  PRIMARY KEY (`User_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`User_Id`, `Password`) VALUES
('n', 'n');

-- --------------------------------------------------------

--
-- Table structure for table `marks_status`
--

CREATE TABLE IF NOT EXISTS `marks_status` (
  `Student_Id` varchar(20) NOT NULL,
  `Class` int(11) NOT NULL,
  `Test_Id` varchar(20) NOT NULL,
  `DOT` date NOT NULL,
  `Marks_Obt` varchar(11) NOT NULL,
  PRIMARY KEY (`Student_Id`,`Test_Id`,`DOT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `marks_status`
--

INSERT INTO `marks_status` (`Student_Id`, `Class`, `Test_Id`, `DOT`, `Marks_Obt`) VALUES
('a', 9, '1', '2013-03-15', '15'),
('a', 9, 'n10', '2013-03-16', '54'),
('a', 9, 't9', '2013-04-11', '22'),
('b', 9, '1', '2013-03-15', 'Absent'),
('c', 9, '1', '2013-03-15', 'Absent'),
('d', 9, '1', '2013-03-15', '44');

-- --------------------------------------------------------

--
-- Table structure for table `student_info`
--

CREATE TABLE IF NOT EXISTS `student_info` (
  `Student_Id` varchar(20) NOT NULL,
  `Year` int(11) NOT NULL,
  `Class` int(11) NOT NULL,
  `DOJ` date NOT NULL,
  `Name` varchar(30) NOT NULL,
  `Fname` varchar(40) NOT NULL,
  `DOB` date NOT NULL,
  `Address` varchar(60) NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `School` varchar(40) NOT NULL,
  `Phone` int(11) NOT NULL,
  `Student_Email` varchar(40) NOT NULL,
  `Guardian_Email` varchar(40) NOT NULL,
  PRIMARY KEY (`Student_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student_info`
--

INSERT INTO `student_info` (`Student_Id`, `Year`, `Class`, `DOJ`, `Name`, `Fname`, `DOB`, `Address`, `Gender`, `School`, `Phone`, `Student_Email`, `Guardian_Email`) VALUES
('a', 2013, 9, '2013-03-12', 'Mr. Ajeet ', 'nhbhfgcg', '2013-03-12', 'oooooo', 'Female', 'oooooooo', 24242, '', 'akhan.iipsmca@gmail.com'),
('b', 2013, 9, '2013-03-12', 'Rahul Sagore', 'm', '2013-03-12', 'mmmmmmmm', 'Male', 'mmmmmmmm', 2424242, '', 'rahul.sagore@gmail.com'),
('c', 2013, 9, '2013-03-12', 'Nitesh Mishra', 'nnnnnnn', '2013-03-12', 'nnn', 'Male', 'nnnnn', 24242, '', 'nmmishra.iipsmca@gmail.com'),
('d', 2012, 12, '2013-03-10', 'Ankit KulKarni', 'fbbb', '2013-03-10', 'fbfb', 'Male', 'bdcbcdbd', 242424, '', '');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
