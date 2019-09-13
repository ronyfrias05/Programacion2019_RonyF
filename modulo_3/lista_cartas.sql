-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 12-09-2019 a las 18:33:12
-- Versión del servidor: 10.1.37-MariaDB
-- Versión de PHP: 7.2.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `lista_cartas`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cartas`
--

CREATE TABLE `cartas` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `name` varchar(100) NOT NULL,
  `link` varchar(200) NOT NULL,
  `price` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cartas`
--

INSERT INTO `cartas` (`id`, `name`, `link`, `price`) VALUES
(1, 'Virtuoso', 'https://www.google.com/', 25),
(2, 'Fontaine', 'https://www.google.com.do/imghp?hl=es&tab=wi&ogbl', 1000),
(3, 'Virtuoso Yellow', 'https://ae01.alicdn.com/kf/HTB1JOysXh2rK1RkSnhJq6ykdpXa5/Good-SS16-2016-Virtuoso-Spring-Summer-Playing-Cards-by-The-Virts-Limited-Rare-Magic-Deck-Magic.jpg_640x640.jpg', 50),
(4, 'Pack Virtuoso', 'https://www.picclickimg.com/00/s/OTAwWDE2MDA=/z/ipoAAOSwbbdbGPrv/$/The-Virts-Collection-All-5-Virtuoso-Playing-_57.jpg', 989999),
(5, 'Pack Virtuoso2', 'https://i0.wp.com/cursosmegaup.bid/wp-content/uploads/2018/01/titlePage.png', 1222);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cartas`
--
ALTER TABLE `cartas`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `name` (`name`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cartas`
--
ALTER TABLE `cartas`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
