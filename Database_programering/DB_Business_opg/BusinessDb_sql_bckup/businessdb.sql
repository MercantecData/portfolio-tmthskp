-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Vært: 127.0.0.1
-- Genereringstid: 29. 11 2019 kl. 11:31:45
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

DELIMITER $$
--
-- Procedurer
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_id` (IN `delete_id` INT(11))  BEGIN 

     DELETE 
     FROM employee
     WHERE employee.PersonID = delete_id;

END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `department`
--

CREATE TABLE `department` (
  `DepartmentID` int(11) NOT NULL,
  `DepName` varchar(256) COLLATE utf8_danish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_danish_ci;

--
-- Data dump for tabellen `department`
--

INSERT INTO `department` (`DepartmentID`, `DepName`) VALUES
(1, 'Office_Department'),
(2, 'It_Department');

-- --------------------------------------------------------

--
-- Stand-in-struktur for visning `department_employes_email`
-- (Se nedenfor for det aktuelle view)
--
CREATE TABLE `department_employes_email` (
`PersonID` int(11)
,`FirstName` varchar(256)
,`LastName` varchar(256)
,`DepName` varchar(256)
,`Email` varchar(256)
);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `dep_employee`
--

CREATE TABLE `dep_employee` (
  `DepEmployeeID` int(11) NOT NULL,
  `IDperson` int(11) DEFAULT NULL,
  `department_id` int(11) DEFAULT NULL,
  `Title_ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_danish_ci;

--
-- Data dump for tabellen `dep_employee`
--

INSERT INTO `dep_employee` (`DepEmployeeID`, `IDperson`, `department_id`, `Title_ID`) VALUES
(1, 3, 2, 3),
(2, 4, 2, 4),
(3, 5, 2, 5),
(5, 6, 1, 6);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `dep_manager`
--

CREATE TABLE `dep_manager` (
  `DepManagerID` int(11) NOT NULL,
  `person_id` int(11) DEFAULT NULL,
  `Department_ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_danish_ci;

--
-- Data dump for tabellen `dep_manager`
--

INSERT INTO `dep_manager` (`DepManagerID`, `person_id`, `Department_ID`) VALUES
(1, 1, 1),
(2, 2, 2);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `employee`
--

CREATE TABLE `employee` (
  `PersonID` int(11) NOT NULL,
  `FirstName` varchar(256) COLLATE utf8_danish_ci DEFAULT NULL,
  `LastName` varchar(256) COLLATE utf8_danish_ci DEFAULT NULL,
  `Email` varchar(256) COLLATE utf8_danish_ci DEFAULT NULL,
  `UserName` varchar(256) COLLATE utf8_danish_ci DEFAULT NULL,
  `UserPassword` varchar(256) COLLATE utf8_danish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_danish_ci;

--
-- Data dump for tabellen `employee`
--

INSERT INTO `employee` (`PersonID`, `FirstName`, `LastName`, `Email`, `UserName`, `UserPassword`) VALUES
(1, 'Bob', 'The Rough', 'bob@email.mail', 'bob', 'bobbob'),
(2, 'Cub', 'The Cute', 'cub@email.mail', 'cub', 'cubcub'),
(3, 'Dan', 'The Drunk', 'dan@email.mail', 'dan', 'dandan'),
(4, 'Ben', 'The Brat', 'ben@email.mail', 'ben', 'benben'),
(5, 'Joe', 'The Jingle', 'joe@email.mail', 'joe', 'joejoe'),
(6, 'Alf', 'The ALIEN', 'alf@email.mail', 'alf', 'alfalf');

-- --------------------------------------------------------

--
-- Stand-in-struktur for visning `employee_overview`
-- (Se nedenfor for det aktuelle view)
--
CREATE TABLE `employee_overview` (
`PersonID` int(11)
,`FirstName` varchar(256)
,`LastName` varchar(256)
,`Email` varchar(256)
,`UserName` varchar(256)
,`UserPassword` varchar(256)
);

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_danish_ci;

--
-- Data dump for tabellen `salaries`
--

INSERT INTO `salaries` (`SalariID`, `OfficePayHour`, `ItPayHour`, `personid`, `departmentid`, `depmanagerid`, `titleid`) VALUES
(3, 400, 600, 2, 2, 1, 1),
(4, 300, 500, 3, 1, 2, 3);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `titles`
--

CREATE TABLE `titles` (
  `TitleID` int(11) NOT NULL,
  `TitleName` varchar(256) COLLATE utf8_danish_ci DEFAULT NULL,
  `idperson` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_danish_ci;

--
-- Data dump for tabellen `titles`
--

INSERT INTO `titles` (`TitleID`, `TitleName`, `idperson`) VALUES
(1, 'Rank1', 1),
(2, 'Rank2', 2),
(3, 'Rank3', 3),
(4, 'Rank4', 4),
(5, 'Rank5', 5),
(6, 'Rank6', 6);

-- --------------------------------------------------------

--
-- Struktur for visning `department_employes_email`
--
DROP TABLE IF EXISTS `department_employes_email`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `department_employes_email`  AS  select `employee`.`PersonID` AS `PersonID`,`employee`.`FirstName` AS `FirstName`,`employee`.`LastName` AS `LastName`,`department`.`DepName` AS `DepName`,`employee`.`Email` AS `Email` from (`employee` join `department` on(`employee`.`PersonID` = `department`.`DepartmentID`)) ;

-- --------------------------------------------------------

--
-- Struktur for visning `employee_overview`
--
DROP TABLE IF EXISTS `employee_overview`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `employee_overview`  AS  select `employee`.`PersonID` AS `PersonID`,`employee`.`FirstName` AS `FirstName`,`employee`.`LastName` AS `LastName`,`employee`.`Email` AS `Email`,`employee`.`UserName` AS `UserName`,`employee`.`UserPassword` AS `UserPassword` from `employee` ;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`DepartmentID`);

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
  ADD KEY `idperson` (`idperson`);

--
-- Brug ikke AUTO_INCREMENT for slettede tabeller
--

--
-- Tilføj AUTO_INCREMENT i tabel `department`
--
ALTER TABLE `department`
  MODIFY `DepartmentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Tilføj AUTO_INCREMENT i tabel `dep_employee`
--
ALTER TABLE `dep_employee`
  MODIFY `DepEmployeeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Tilføj AUTO_INCREMENT i tabel `dep_manager`
--
ALTER TABLE `dep_manager`
  MODIFY `DepManagerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Tilføj AUTO_INCREMENT i tabel `employee`
--
ALTER TABLE `employee`
  MODIFY `PersonID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Tilføj AUTO_INCREMENT i tabel `salaries`
--
ALTER TABLE `salaries`
  MODIFY `SalariID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Tilføj AUTO_INCREMENT i tabel `titles`
--
ALTER TABLE `titles`
  MODIFY `TitleID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Begrænsninger for dumpede tabeller
--

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
  ADD CONSTRAINT `titles_ibfk_1` FOREIGN KEY (`idperson`) REFERENCES `employee` (`PersonID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
