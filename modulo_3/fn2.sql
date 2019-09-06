-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 06-09-2019 a las 18:21:13
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
-- Base de datos: `fn2`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `alumnos`
--

CREATE TABLE `alumnos` (
  `matricula` bigint(20) UNSIGNED NOT NULL,
  `nombre_alumno` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `alumnos`
--

INSERT INTO `alumnos` (`matricula`, `nombre_alumno`) VALUES
(1, 'Chris Nuñez'),
(2, 'Went'),
(3, 'Ford'),
(4, 'Suarez');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `calficaciones`
--

CREATE TABLE `calficaciones` (
  `matricula` bigint(20) UNSIGNED DEFAULT NULL,
  `clave_materia` mediumint(8) UNSIGNED DEFAULT NULL,
  `clasificacio` mediumint(8) UNSIGNED DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `calficaciones`
--

INSERT INTO `calficaciones` (`matricula`, `clave_materia`, `clasificacio`) VALUES
(1, 50, 90),
(2, 10, 80),
(3, 30, 100),
(4, 20, 70),
(1, 49, 50),
(1, 30, 99),
(1, 10, 100);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `materias`
--

CREATE TABLE `materias` (
  `clave_materia` mediumint(8) UNSIGNED NOT NULL,
  `nombre_materia` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `materias`
--

INSERT INTO `materias` (`clave_materia`, `nombre_materia`) VALUES
(10, 'Sociales'),
(20, 'Electricidad'),
(30, 'Ingles'),
(49, 'Español'),
(50, 'Matematica');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `alumnos`
--
ALTER TABLE `alumnos`
  ADD PRIMARY KEY (`matricula`);

--
-- Indices de la tabla `calficaciones`
--
ALTER TABLE `calficaciones`
  ADD KEY `matricula` (`matricula`),
  ADD KEY `clave_materia` (`clave_materia`);

--
-- Indices de la tabla `materias`
--
ALTER TABLE `materias`
  ADD PRIMARY KEY (`clave_materia`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `calficaciones`
--
ALTER TABLE `calficaciones`
  ADD CONSTRAINT `calficaciones_ibfk_1` FOREIGN KEY (`matricula`) REFERENCES `alumnos` (`matricula`),
  ADD CONSTRAINT `calficaciones_ibfk_2` FOREIGN KEY (`clave_materia`) REFERENCES `materias` (`clave_materia`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
