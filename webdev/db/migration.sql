-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Окт 10 2026 г., 21:32
-- Версия сервера: 10.4.32-MariaDB
-- Версия PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `calc`
--

--
-- Дамп данных таблицы `operation`
--

INSERT INTO `operation` (`login`, `operation`, `operation_date`, `x`, `y`, `z`) VALUES
('AKud', 'plus', '2026-10-10 19:29:58', 2, 3, 5),
('AKud', 'minus', '2026-10-10 19:31:11', 28, 91, -63),
('AKud', 'mult', '2026-10-10 19:31:21', 3, 153, 459);

--
-- Дамп данных таблицы `user`
--

INSERT INTO `user` (`login`, `name`, `pwd_hash`) VALUES
('AKud', 'Кудимов Андрей Вадимович', '$2y$10$ARSP0RYMHm66ccDezSged.19PrQ8rAW6awpKkPWpz4w0BhuNArWy6');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
