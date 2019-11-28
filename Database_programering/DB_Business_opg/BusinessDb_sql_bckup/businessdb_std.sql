-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Vært: 127.0.0.1
-- Genereringstid: 28. 11 2019 kl. 14:18:08
-- Serverversion: 10.4.6-MariaDB
-- PHP-version: 7.3.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `businessdb`
--

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `department`
--

CREATE TABLE `department` (
  `DepartmentID` int(11) NOT NULL,
  `DepName` varchar(256) DEFAULT NULL,
  `Person_ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `dep_employee`
--

CREATE TABLE `dep_employee` (
  `DepEmployeeID` int(11) NOT NULL,
  `IDperson` int(11) DEFAULT NULL,
  `department_id` int(11) DEFAULT NULL,
  `Title_ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `dep_manager`
--

CREATE TABLE `dep_manager` (
  `DepManagerID` int(11) NOT NULL,
  `person_id` int(11) DEFAULT NULL,
  `Department_ID` int(11) DEFAULT NULL,
  `DepManName` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `employee`
--

CREATE TABLE `employee` (
  `PersonID` int(11) NOT NULL,
  `FirstName` varchar(256) DEFAULT NULL,
  `LastName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `UserPassword` varchar(256) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `salaries`
--

CREATE TABLE `salaries` (
  `SalariID` int(11) NOT NULL,
  `OfficePayHour` int(11) DEFAULT NULL,
  `ItPayHour` int(11) DEFAULT NULL,
  `personid` int(11) DEFAULT NULL,
  `departmentid` int(11) DEFAULT NULL,
  `depmanagerid` int(11) DEFAULT NULL,
  `titleid` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `titles`
--

CREATE TABLE `titles` (
  `TitleID` int(11) NOT NULL,
  `TitleName` varchar(256) DEFAULT NULL,
  `idperson` int(11) DEFAULT NULL,
  `iddepartment` int(11) DEFAULT NULL,
  `iddepmanager` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`DepartmentID`),
  ADD KEY `Person_ID` (`Person_ID`);

--
-- Indeks for tabel `dep_employee`
--
ALTER TABLE `dep_employee`
  ADD PRIMARY KEY (`DepEmployeeID`),
  ADD KEY `IDperson` (`IDperson`),
  ADD KEY `department_id` (`department_id`),
  ADD KEY `Title_ID` (`Title_ID`);

--
-- Indeks for tabel `dep_manager`
--
ALTER TABLE `dep_manager`
  ADD PRIMARY KEY (`DepManagerID`),
  ADD KEY `person_id` (`person_id`),
  ADD KEY `Department_ID` (`Department_ID`);

--
-- Indeks for tabel `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`PersonID`);

--
-- Indeks for tabel `salaries`
--
ALTER TABLE `salaries`
  ADD PRIMARY KEY (`SalariID`),
  ADD KEY `personid` (`personid`),
  ADD KEY `departmentid` (`departmentid`),
  ADD KEY `depmanagerid` (`depmanagerid`),
  ADD KEY `titleid` (`titleid`);

--
-- Indeks for tabel `titles`
--
ALTER TABLE `titles`
  ADD PRIMARY KEY (`TitleID`),
  ADD KEY `idperson` (`idperson`),
  ADD KEY `iddepartment` (`iddepartment`),
  ADD KEY `iddepmanager` (`iddepmanager`);

--
-- Brug ikke AUTO_INCREMENT for slettede tabeller
--

--
-- Tilføj AUTO_INCREMENT i tabel `department`
--
ALTER TABLE `department`
  MODIFY `DepartmentID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tilføj AUTO_INCREMENT i tabel `dep_employee`
--
ALTER TABLE `dep_employee`
  MODIFY `DepEmployeeID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tilføj AUTO_INCREMENT i tabel `dep_manager`
--
ALTER TABLE `dep_manager`
  MODIFY `DepManagerID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tilføj AUTO_INCREMENT i tabel `employee`
--
ALTER TABLE `employee`
  MODIFY `PersonID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tilføj AUTO_INCREMENT i tabel `salaries`
--
ALTER TABLE `salaries`
  MODIFY `SalariID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tilføj AUTO_INCREMENT i tabel `titles`
--
ALTER TABLE `titles`
  MODIFY `TitleID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Begrænsninger for tabel `department`
--
ALTER TABLE `department`
  ADD CONSTRAINT `department_ibfk_1` FOREIGN KEY (`Person_ID`) REFERENCES `employee` (`PersonID`);

--
-- Begrænsninger for tabel `dep_employee`
--
ALTER TABLE `dep_employee`
  ADD CONSTRAINT `dep_employee_ibfk_1` FOREIGN KEY (`IDperson`) REFERENCES `employee` (`PersonID`),
  ADD CONSTRAINT `dep_employee_ibfk_2` FOREIGN KEY (`department_id`) REFERENCES `department` (`DepartmentID`),
  ADD CONSTRAINT `dep_employee_ibfk_3` FOREIGN KEY (`Title_ID`) REFERENCES `titles` (`TitleID`);

--
-- Begrænsninger for tabel `dep_manager`
--
ALTER TABLE `dep_manager`
  ADD CONSTRAINT `dep_manager_ibfk_1` FOREIGN KEY (`person_id`) REFERENCES `employee` (`PersonID`),
  ADD CONSTRAINT `dep_manager_ibfk_2` FOREIGN KEY (`Department_ID`) REFERENCES `department` (`DepartmentID`);

--
-- Begrænsninger for tabel `salaries`
--
ALTER TABLE `salaries`
  ADD CONSTRAINT `salaries_ibfk_1` FOREIGN KEY (`personid`) REFERENCES `employee` (`PersonID`),
  ADD CONSTRAINT `salaries_ibfk_2` FOREIGN KEY (`departmentid`) REFERENCES `department` (`DepartmentID`),
  ADD CONSTRAINT `salaries_ibfk_3` FOREIGN KEY (`depmanagerid`) REFERENCES `dep_manager` (`DepManagerID`),
  ADD CONSTRAINT `salaries_ibfk_4` FOREIGN KEY (`titleid`) REFERENCES `titles` (`TitleID`);

--
-- Begrænsninger for tabel `titles`
--
ALTER TABLE `titles`
  ADD CONSTRAINT `titles_ibfk_1` FOREIGN KEY (`idperson`) REFERENCES `employee` (`PersonID`),
  ADD CONSTRAINT `titles_ibfk_2` FOREIGN KEY (`iddepartment`) REFERENCES `department` (`DepartmentID`),
  ADD CONSTRAINT `titles_ibfk_3` FOREIGN KEY (`iddepmanager`) REFERENCES `dep_manager` (`DepManagerID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
