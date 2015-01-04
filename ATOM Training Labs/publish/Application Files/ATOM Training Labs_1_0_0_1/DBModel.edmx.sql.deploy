




-- -----------------------------------------------------------
-- Entity Designer DDL Script for MySQL Server 4.1 and higher
-- -----------------------------------------------------------
-- Date Created: 10/06/2014 20:44:01
-- Generated from EDMX file: F:\Projects\Visual Studio 2013\ATOM Final Product\ATOM Training Labs\DBModel.edmx
-- Target version: 3.0.0.0
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- NOTE: if the constraint does not exist, an ignorable error will be reported.
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------
SET foreign_key_checks = 0;
    DROP TABLE IF EXISTS `admissions`;
    DROP TABLE IF EXISTS `enquiries`;
    DROP TABLE IF EXISTS `internships`;
    DROP TABLE IF EXISTS `ipts`;
    DROP TABLE IF EXISTS `meetups`;
    DROP TABLE IF EXISTS `userdetails`;
SET foreign_key_checks = 1;

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

CREATE TABLE `admissions`(
	`SerialNo` int NOT NULL, 
	`DateOfJoining` datetime, 
	`Name` varchar (150) NOT NULL, 
	`MobileNo` varchar (20), 
	`Email_ID` varchar (45), 
	`Gender` varchar (10), 
	`Address` varchar (250), 
	`DOB` datetime, 
	`Notes` varchar (250), 
	`WhatProfession` varchar (45), 
	`CollegeName` varchar (45), 
	`StudentMajor` varchar (45), 
	`CompanyName` varchar (45), 
	`EmployeeDesignation` varchar (45), 
	`CourseTaken` varchar (45), 
	`CourseFee` varchar (45), 
	`CourseEnd` datetime, 
	`CertificateStatus` varchar (45), 
	`BreakOfStudy` varchar (250));

ALTER TABLE `admissions` ADD PRIMARY KEY (SerialNo);




CREATE TABLE `enquiries`(
	`SerialNo` int NOT NULL, 
	`DateOfEnquiry` datetime, 
	`Name` varchar (150), 
	`MobileNo` varchar (20), 
	`Email_ID` varchar (45), 
	`Gender` varchar (10), 
	`Address` varchar (45), 
	`Mode` varchar (10), 
	`Notes` varchar (250), 
	`Interested` varchar (100), 
	`TimePreferred` varchar (100), 
	`Referrals` varchar (100), 
	`Profession` varchar (15), 
	`CollegeName` varchar (45), 
	`StudentMajor` varchar (25), 
	`CompanyName` varchar (45), 
	`EmpDesignation` varchar (45), 
	`WhoTheyMet` varchar (45), 
	`Discussion` varchar (250), 
	`EnrollmentStatus` varchar (10), 
	`FollowUp` varchar (50));

ALTER TABLE `enquiries` ADD PRIMARY KEY (SerialNo);




CREATE TABLE `internships`(
	`SerialNo` int NOT NULL, 
	`Name` varchar (150) NOT NULL, 
	`Position` varchar (25) NOT NULL, 
	`Gender` varchar (15), 
	`MobileNo` varchar (20), 
	`Email_ID` varchar (45), 
	`Address` varchar (120), 
	`CollegeName` varchar (125), 
	`StudentMajor` varchar (50), 
	`YearOfPassing` int, 
	`JoinedDate` datetime, 
	`ConcludeDate` datetime, 
	`InternshipType` varchar (25), 
	`TimePreferred` varchar (25), 
	`Amount` varchar (50), 
	`Notes` varchar (250));

ALTER TABLE `internships` ADD PRIMARY KEY (SerialNo);




CREATE TABLE `ipts`(
	`SerialNo` int NOT NULL, 
	`Name` varchar (150) NOT NULL, 
	`Gender` varchar (15), 
	`MobileNo` varchar (25), 
	`Email_ID` varchar (120), 
	`Address` varchar (250), 
	`CollegeName` varchar (100), 
	`StudentMajor` varchar (50), 
	`YearOfPassing` int, 
	`JoinedDate` datetime, 
	`ConcludeDate` datetime, 
	`InternshipType` varchar (25), 
	`TimePreferred` varchar (25), 
	`Notes` varchar (250));

ALTER TABLE `ipts` ADD PRIMARY KEY (SerialNo);




CREATE TABLE `meetups`(
	`SerialNo` int NOT NULL, 
	`Name` varchar (150) NOT NULL, 
	`Gender` varchar (15), 
	`MobileNo` varchar (25), 
	`Email_ID` varchar (120), 
	`Address` varchar (250), 
	`CollegeName` varchar (120), 
	`StudentMajor` varchar (50), 
	`YearOfPassing` int, 
	`Interested` varchar (100), 
	`Event1Date` datetime, 
	`Event1Topic` varchar (50), 
	`Event1Notes` varchar (150), 
	`Event2Date` datetime, 
	`Event2Topic` varchar (50), 
	`Event2Notes` varchar (150), 
	`Event3Date` datetime, 
	`Event3Topic` varchar (50), 
	`Event3Notes` varchar (150));

ALTER TABLE `meetups` ADD PRIMARY KEY (SerialNo);




CREATE TABLE `userdetails`(
	`ID` int NOT NULL, 
	`username` varchar (25) NOT NULL, 
	`password` varchar (45), 
	`role` varchar (10));

ALTER TABLE `userdetails` ADD PRIMARY KEY (ID);






-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
