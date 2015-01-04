-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.6.20 - MySQL Community Server (GPL)
-- Server OS:                    Win64
-- HeidiSQL Version:             8.3.0.4694
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Dumping database structure for ATOM
CREATE DATABASE IF NOT EXISTS `ATOM` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `ATOM`;


-- Dumping structure for table ATOM.admission
CREATE TABLE IF NOT EXISTS `admission` (
  `SerialNo` int(11) NOT NULL,
  `DateOfJoining` date DEFAULT NULL,
  `Name` varchar(150) NOT NULL,
  `MobileNo` varchar(20) DEFAULT NULL,
  `Email_ID` varchar(45) DEFAULT NULL,
  `Gender` varchar(10) DEFAULT NULL,
  `DOB` date DEFAULT NULL,
  `Address` varchar(250) DEFAULT NULL,
  `Notes` varchar(250) DEFAULT NULL,
  `WhatProfession` varchar(45) DEFAULT NULL,
  `CollegeName` varchar(45) DEFAULT NULL,
  `StudentMajor` varchar(45) DEFAULT NULL,
  `CompanyName` varchar(45) DEFAULT NULL,
  `EmployeeDesignation` varchar(45) DEFAULT NULL,
  `CourseTaken` varchar(45) DEFAULT NULL,
  `CourseFee` varchar(45) DEFAULT NULL,
  `CertificateStatus` varchar(5) DEFAULT NULL,
  `BreakOfStudy` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`SerialNo`),
  UNIQUE KEY `id_UNIQUE` (`SerialNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table ATOM.admission: ~7 rows (approximately)
/*!40000 ALTER TABLE `admission` DISABLE KEYS */;
INSERT INTO `admission` (`SerialNo`, `DateOfJoining`, `Name`, `MobileNo`, `Email_ID`, `Gender`, `DOB`, `Address`, `Notes`, `WhatProfession`, `CollegeName`, `StudentMajor`, `CompanyName`, `EmployeeDesignation`, `CourseTaken`, `CourseFee`, `CertificateStatus`, `BreakOfStudy`) VALUES
	(11, '2014-08-26', 'Ashik Nesin', '123445678', 'mail@ashiknesin.com', 'Male', '1994-05-05', 'MIET', 'Notes here...', 'Student', 'MIET', 'IT', '', '', 'Web Development', 'Web Development', 'No', ':-)'),
	(789, '2014-08-24', 'Kumaresh', '8760003969', 'kumaresh@devfacts.com', 'Male', '2014-08-24', 'miet engg college\r\ntrichy -7', 'notes search...', 'Student', 'MIET', 'CSE', '', '', 'Web Development', '5000', 'Yes', 'mlmlmm;'),
	(1246, '1994-01-18', 'AsNe', '', '', 'Female', '2001-01-18', '', '', 'Employee', '', '', 'mjat', 'ceo', '', '', 'Yes', ''),
	(12345, '2014-08-24', 'Jaffer Sherif', '123456789', 'jafee@gmail.com', 'Male', '2014-08-24', 'GUNDUR', 'Testing Notes', 'Student', 'MIET', 'IT', '', '', 'Web Development', 'Web Development', 'No', 'Nope...'),
	(123456, '2014-08-24', 'Dilip', '9876543210', 'dilip@dn.com', 'Male', '2014-08-24', 'Gundur', 'Testing notes here...', 'Employee', 'MIET', 'CSE', '', '', 'Web Development', 'Web Development', 'No', 'Nope....'),
	(123457, '2014-08-26', 'rty', '', '', '', '2014-08-26', '', '', '', '', '', '', '', '', '', '', ''),
	(123458, '2014-08-26', 'Nesin', '', '', 'Female', '2014-08-26', '', '', 'Employee', '', '', 'hts', 'CEO', '', '', 'No', '');
/*!40000 ALTER TABLE `admission` ENABLE KEYS */;


-- Dumping structure for table ATOM.enquiry
CREATE TABLE IF NOT EXISTS `enquiry` (
  `SerialNo` int(11) NOT NULL,
  `DateOfEnquiry` date DEFAULT NULL,
  `Name` varchar(150) DEFAULT NULL,
  `MobileNo` varchar(20) DEFAULT NULL,
  `Email_ID` varchar(45) DEFAULT NULL,
  `Gender` varchar(10) DEFAULT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `Mode` varchar(10) DEFAULT NULL,
  `Notes` varchar(250) DEFAULT NULL,
  `Interested` varchar(100) DEFAULT NULL,
  `TimePreferred` varchar(100) DEFAULT NULL,
  `Referrals` varchar(100) DEFAULT NULL,
  `Profession` varchar(15) DEFAULT NULL,
  `CollegeName` varchar(45) DEFAULT NULL,
  `StudentMajor` varchar(25) DEFAULT NULL,
  `CompanyName` varchar(45) DEFAULT NULL,
  `EmpDesignation` varchar(45) DEFAULT NULL,
  `WhoTheyMet` varchar(45) DEFAULT NULL,
  `Discussion` varchar(250) DEFAULT NULL,
  `EnrollmentStatus` varchar(10) DEFAULT NULL,
  `FollowUp` int(11) DEFAULT NULL,
  PRIMARY KEY (`SerialNo`),
  UNIQUE KEY `enquiry_no_UNIQUE` (`SerialNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table ATOM.enquiry: ~3 rows (approximately)
/*!40000 ALTER TABLE `enquiry` DISABLE KEYS */;
INSERT INTO `enquiry` (`SerialNo`, `DateOfEnquiry`, `Name`, `MobileNo`, `Email_ID`, `Gender`, `Address`, `Mode`, `Notes`, `Interested`, `TimePreferred`, `Referrals`, `Profession`, `CollegeName`, `StudentMajor`, `CompanyName`, `EmpDesignation`, `WhoTheyMet`, `Discussion`, `EnrollmentStatus`, `FollowUp`) VALUES
	(11, '2014-08-26', 'Asdghj', 'asadcvbnm', 'sdfghj', 'Male', 'asdfghjk', 'Course', '', 'Multimedia', 'Morning', 'TV', 'Student', '', '', '', '', '', '', 'Yes', NULL),
	(123456, '2014-08-26', 'Ashik Nesin', '9698068064', 'ashiknesin@gmail.com', 'Male', 'MIET Engineering College,Trichy', 'Internship', '', 'Internship, Placements, Mobile Application, Multimedia', 'Full Time, Weekend Classes, Evening, Morning', 'Others, Website, Posters, Friends, Internet', 'Others', 'MIET', 'CSE', '', '', '', '', 'Yes', NULL),
	(123459, '2014-08-26', 'AsNe', '9698068064', 'ma@as.con', 'Male', 'MIE?T gundur', 'IPT', '', 'Internship', 'Morning', 'Internet', 'Student', '', '', '', '', '', '', 'Yes', NULL);
/*!40000 ALTER TABLE `enquiry` ENABLE KEYS */;


-- Dumping structure for table ATOM.internship
CREATE TABLE IF NOT EXISTS `internship` (
  `SerialNo` int(11) NOT NULL,
  `Name` varchar(150) NOT NULL,
  `Position` varchar(25) NOT NULL,
  `Gender` varchar(10) DEFAULT NULL,
  `MobileNo` varchar(15) DEFAULT NULL,
  `Email_ID` varchar(45) DEFAULT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `CollegeName` varchar(45) DEFAULT NULL,
  `StudentMajor` varchar(45) DEFAULT NULL,
  `YearOfPassing` int(11) DEFAULT NULL,
  `JoinedDate` date DEFAULT NULL,
  `ConcludeDate` date DEFAULT NULL,
  `InternshipType` varchar(10) DEFAULT NULL,
  `TimePreferred` varchar(10) DEFAULT NULL,
  `Amount` varchar(50) DEFAULT NULL,
  `Notes` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`SerialNo`),
  UNIQUE KEY `id_UNIQUE` (`SerialNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table ATOM.internship: ~3 rows (approximately)
/*!40000 ALTER TABLE `internship` DISABLE KEYS */;
INSERT INTO `internship` (`SerialNo`, `Name`, `Position`, `Gender`, `MobileNo`, `Email_ID`, `Address`, `CollegeName`, `StudentMajor`, `YearOfPassing`, `JoinedDate`, `ConcludeDate`, `InternshipType`, `TimePreferred`, `Amount`, `Notes`) VALUES
	(1, 'Ashik Nesin', '', 'Male', '965454654', 'gknfgklernn', 'MIETY', 'MIET Engg.', 'CSE', 2015, '2014-08-13', '2015-08-13', 'Free', 'Full Time', '', ''),
	(111, 'efgh', '', 'Male', 'qwertfghj', 'qweryghjk', 'qwertghjk', 'sdfghjkl', 'wergfhjkl', 2012, '2014-08-13', '2014-08-13', 'Paid', 'Full Time', '', ''),
	(12345, 'kfgjfkln', '', 'Male', 'kjrgjh', 'hfb', 'hljghlwgh', 'gfbfh', 'hfg', 2015, '2014-08-13', '2014-08-13', 'Free', 'Part Time', '', '');
/*!40000 ALTER TABLE `internship` ENABLE KEYS */;


-- Dumping structure for table ATOM.ipt
CREATE TABLE IF NOT EXISTS `ipt` (
  `SerialNo` int(11) NOT NULL,
  `Name` varchar(150) NOT NULL,
  `Position` varchar(25) NOT NULL,
  `Gender` varchar(10) DEFAULT NULL,
  `MobileNo` varchar(15) DEFAULT NULL,
  `Email_ID` varchar(45) DEFAULT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `CollegeName` varchar(45) DEFAULT NULL,
  `StudentMajor` varchar(45) DEFAULT NULL,
  `YearOfPassing` int(11) DEFAULT NULL,
  `JoinedDate` date DEFAULT NULL,
  `ConcludeDate` date DEFAULT NULL,
  `InternshipType` varchar(10) DEFAULT NULL,
  `TimePreferred` varchar(10) DEFAULT NULL,
  `Notes` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`SerialNo`),
  UNIQUE KEY `id_UNIQUE` (`SerialNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- Dumping data for table ATOM.ipt: ~3 rows (approximately)
/*!40000 ALTER TABLE `ipt` DISABLE KEYS */;
INSERT INTO `ipt` (`SerialNo`, `Name`, `Position`, `Gender`, `MobileNo`, `Email_ID`, `Address`, `CollegeName`, `StudentMajor`, `YearOfPassing`, `JoinedDate`, `ConcludeDate`, `InternshipType`, `TimePreferred`, `Notes`) VALUES
	(1, 'Ashik Nesin', '', 'Male', '965454654', 'gknfgklernn', 'MIETY', 'MIET Engg.', 'CSE', 2015, '2014-08-13', '2015-08-13', 'Free', 'Full Time', ''),
	(111, 'efgh', '', 'Male', 'qwertfghj', 'qweryghjk', 'qwertghjk', 'sdfghjkl', 'wergfhjkl', 2012, '2014-08-13', '2014-08-13', 'Paid', 'Full Time', ''),
	(12345, 'kfgjfkln', '', 'Male', 'kjrgjh', 'hfb', 'hljghlwgh', 'gfbfh', 'hfg', 2015, '2014-08-13', '2014-08-13', 'Free', 'Part Time', '');
/*!40000 ALTER TABLE `ipt` ENABLE KEYS */;


-- Dumping structure for table ATOM.meetup
CREATE TABLE IF NOT EXISTS `meetup` (
  `SerialNo` int(11) NOT NULL,
  `Name` varchar(150) NOT NULL,
  `Gender` varchar(10) DEFAULT NULL,
  `MobileNo` varchar(15) DEFAULT NULL,
  `Email_ID` varchar(45) DEFAULT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `CollegeName` varchar(45) DEFAULT NULL,
  `StudentMajor` varchar(45) DEFAULT NULL,
  `YearOfPassing` int(11) DEFAULT NULL,
  `JoinedDate` date DEFAULT NULL,
  `ConcludeDate` date DEFAULT NULL,
  `Interested` varchar(100) DEFAULT NULL,
  `Event1Date` date DEFAULT NULL,
  `Event1Topic` varchar(50) DEFAULT NULL,
  `Event1Notes` varchar(150) DEFAULT NULL,
  `Event2Date` date DEFAULT NULL,
  `Event2Topic` varchar(50) DEFAULT NULL,
  `Event2Notes` varchar(150) DEFAULT NULL,
  `Event3Date` date DEFAULT NULL,
  `Event3Topic` varchar(50) DEFAULT NULL,
  `Event3Notes` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`SerialNo`),
  UNIQUE KEY `id_UNIQUE` (`SerialNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- Dumping data for table ATOM.meetup: ~3 rows (approximately)
/*!40000 ALTER TABLE `meetup` DISABLE KEYS */;
INSERT INTO `meetup` (`SerialNo`, `Name`, `Gender`, `MobileNo`, `Email_ID`, `Address`, `CollegeName`, `StudentMajor`, `YearOfPassing`, `JoinedDate`, `ConcludeDate`, `Interested`, `Event1Date`, `Event1Topic`, `Event1Notes`, `Event2Date`, `Event2Topic`, `Event2Notes`, `Event3Date`, `Event3Topic`, `Event3Notes`) VALUES
	(1, 'Ashik Nesin', 'Male', '965454654', 'gknfgklernn', 'MIETY', 'MIET Engg.', 'CSE', 2015, '2014-08-13', '2015-08-13', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
	(111, 'efgh', 'Male', 'qwertfghj', 'qweryghjk', 'qwertghjk', 'sdfghjkl', 'wergfhjkl', 2012, '2014-08-13', '2014-08-13', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
	(12345, 'kfgjfkln', 'Male', 'kjrgjh', 'hfb', 'hljghlwgh', 'gfbfh', 'hfg', 2015, '2014-08-13', '2014-08-13', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
/*!40000 ALTER TABLE `meetup` ENABLE KEYS */;


-- Dumping structure for table ATOM.userdetails
CREATE TABLE IF NOT EXISTS `userdetails` (
  `ID` int(11) NOT NULL,
  `username` varchar(25) NOT NULL,
  `password` varchar(45) DEFAULT NULL,
  `role` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table ATOM.userdetails: ~1 rows (approximately)
/*!40000 ALTER TABLE `userdetails` DISABLE KEYS */;
INSERT INTO `userdetails` (`ID`, `username`, `password`, `role`) VALUES
	(1, 'ngng', NULL, NULL);
/*!40000 ALTER TABLE `userdetails` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
