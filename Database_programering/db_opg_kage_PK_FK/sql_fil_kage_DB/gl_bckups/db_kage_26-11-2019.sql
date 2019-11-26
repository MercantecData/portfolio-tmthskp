-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Vært: 127.0.0.1
-- Genereringstid: 26. 11 2019 kl. 09:59:26
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
-- Database: `kage`
--

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `addresses`
--

CREATE TABLE `addresses` (
  `addr_id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `address` varchar(256) DEFAULT NULL,
  `city` varchar(256) DEFAULT NULL,
  `zipcode` int(11) DEFAULT NULL,
  `country` varchar(256) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Data dump for tabellen `addresses`
--

INSERT INTO `addresses` (`addr_id`, `user_id`, `address`, `city`, `zipcode`, `country`) VALUES
(1, 1, 'Bumlerup', 'Bumleby', 1111, 'Bumleland'),
(2, 3, 'Bumlebum', 'Bumleby', 1111, 'Bumleland'),
(3, 2, 'Bumme', 'Bumleby', 1111, 'Bumleland'),
(4, 4, 'Burple', 'Bumleby', 1111, 'Bumleland'),
(5, 5, 'diba', 'dimbleby', 2222, 'dimbleland'),
(6, 6, 'dibadut', 'dimbleby', 2222, 'dimbleland'),
(7, 11, 'dibadip', 'dimbleby', 2222, 'dimbleland'),
(8, 10, 'dubilip', 'dimbleby', 2222, 'dimbleland'),
(9, 8, 'sibadim', 'simbaby', 3333, 'simbaland'),
(10, 9, 'simbababip', 'simbaby', 3333, 'simbaland');

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `orders`
--

CREATE TABLE `orders` (
  `order_id` int(11) NOT NULL,
  `prodid` int(11) DEFAULT NULL,
  `userid` int(11) DEFAULT NULL,
  `addrid` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Data dump for tabellen `orders`
--

INSERT INTO `orders` (`order_id`, `prodid`, `userid`, `addrid`) VALUES
(1, 3, 5, 2),
(2, 8, 4, 6),
(3, 3, 6, 9),
(4, 9, 6, 3),
(5, 1, 2, 4);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `products`
--

CREATE TABLE `products` (
  `prod_id` int(11) NOT NULL,
  `prod_name` varchar(256) DEFAULT NULL,
  `prod_description` varchar(256) DEFAULT NULL,
  `prod_stock` int(11) DEFAULT NULL,
  `prod_price` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Data dump for tabellen `products`
--

INSERT INTO `products` (`prod_id`, `prod_name`, `prod_description`, `prod_stock`, `prod_price`) VALUES
(1, 'Produkt 1', 'Lorem Ipsum bella dona...', 3, 50.75),
(2, 'Produkt 2', 'Lorem Ipsum bella dona...', 4, 80.75),
(3, 'Produkt 3', 'Lorem Ipsum bella dona...', 2, 90.75),
(4, 'Produkt 4', 'Lorem Ipsum bella dona...', 5, 60.75),
(5, 'Produkt 5', 'Lorem Ipsum bella dona...', 1, 105.75),
(6, 'Produkt 6', 'Lorem ipsum bella donna...', 3, 112.95),
(7, 'Produkt 7', 'Lorem ipsum bella donna...', 1, 125.95),
(8, 'Produkt 8', 'Lorem ipsum bella donna...', 3, 100.95),
(9, 'Produkt 9', 'Lorem ipsum bella donna...', 4, 150.95),
(10, 'Produkt 10', 'Lorem ipsum bella donna...', 2, 132.95);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(256) DEFAULT NULL,
  `first_name` varchar(256) DEFAULT NULL,
  `last_name` varchar(256) DEFAULT NULL,
  `email` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Data dump for tabellen `users`
--

INSERT INTO `users` (`id`, `username`, `first_name`, `last_name`, `email`) VALUES
(1, 'bob', 'Bob', 'Boba', 'bob@mail.com'),
(2, 'pop', 'Pop', 'Poba', 'pop@mail.com'),
(3, 'bum', 'Bum', 'Bumelum', 'bum@mail.com'),
(4, 'dib', 'Dib', 'Diba', 'dib@mail.com'),
(5, 'tina', 'Tina', 'Tinsen', 'tina@mail.com'),
(6, 'ham', 'Ham', 'Burger', 'ham@mail.com'),
(8, 'dang', 'Dang', 'Dingelov', 'dang@mail.com'),
(9, 'my', 'My', 'Yagi', 'my@mail.com'),
(10, 'dos', 'Dos', 'Dosan', 'dos@mail.com'),
(11, 'lol', 'Lol', 'Lolalot', 'lol@mail.com');

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `addresses`
--
ALTER TABLE `addresses`
  ADD PRIMARY KEY (`addr_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indeks for tabel `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`order_id`),
  ADD KEY `prodid` (`prodid`),
  ADD KEY `userid` (`userid`),
  ADD KEY `addrid` (`addrid`);

--
-- Indeks for tabel `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`prod_id`);

--
-- Indeks for tabel `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- Brug ikke AUTO_INCREMENT for slettede tabeller
--

--
-- Tilføj AUTO_INCREMENT i tabel `addresses`
--
ALTER TABLE `addresses`
  MODIFY `addr_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Tilføj AUTO_INCREMENT i tabel `orders`
--
ALTER TABLE `orders`
  MODIFY `order_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Tilføj AUTO_INCREMENT i tabel `products`
--
ALTER TABLE `products`
  MODIFY `prod_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Tilføj AUTO_INCREMENT i tabel `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Begrænsninger for tabel `addresses`
--
ALTER TABLE `addresses`
  ADD CONSTRAINT `addresses_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`);

--
-- Begrænsninger for tabel `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`prodid`) REFERENCES `products` (`prod_id`),
  ADD CONSTRAINT `orders_ibfk_2` FOREIGN KEY (`userid`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `orders_ibfk_3` FOREIGN KEY (`addrid`) REFERENCES `addresses` (`addr_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
