-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- 생성 시간: 17-10-26 18:58
-- 서버 버전: 5.6.35
-- PHP 버전: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 데이터베이스: `lpbot`
--

-- --------------------------------------------------------

--
-- 테이블 구조 `lpdata`
--

CREATE TABLE `lpdata` (
  `id` int(11) NOT NULL,
  `name` varchar(20) NOT NULL,
  `date` varchar(40) NOT NULL,
  `content` varchar(100) NOT NULL,
  `comments` varchar(200) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- 테이블 구조 `lplog`
--

CREATE TABLE `lplog` (
  `id` int(11) NOT NULL,
  `userid` varchar(30) NOT NULL,
  `sid` varchar(50) NOT NULL,
  `date` varchar(40) NOT NULL,
  `time` varchar(40) NOT NULL,
  `command` varchar(70) NOT NULL,
  `comments` varchar(300) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- 테이블 구조 `lpuserlog`
--

CREATE TABLE `lpuserlog` (
  `id` int(11) NOT NULL,
  `userid` varchar(30) NOT NULL,
  `register_count` int(11) NOT NULL,
  `view_count` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- 덤프된 테이블의 인덱스
--

--
-- 테이블의 인덱스 `lpdata`
--
ALTER TABLE `lpdata`
  ADD PRIMARY KEY (`id`);

--
-- 테이블의 인덱스 `lplog`
--
ALTER TABLE `lplog`
  ADD PRIMARY KEY (`id`);

--
-- 덤프된 테이블의 AUTO_INCREMENT
--

--
-- 테이블의 AUTO_INCREMENT `lpdata`
--
ALTER TABLE `lpdata`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;
--
-- 테이블의 AUTO_INCREMENT `lplog`
--
ALTER TABLE `lplog`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=494;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
