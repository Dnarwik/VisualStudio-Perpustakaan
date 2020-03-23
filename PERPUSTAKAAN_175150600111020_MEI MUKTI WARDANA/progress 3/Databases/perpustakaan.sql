-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 18, 2019 at 11:56 AM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `perpustakaan`
--

-- --------------------------------------------------------

--
-- Table structure for table `buku`
--

CREATE TABLE `buku` (
  `Kode_buku` varchar(5) NOT NULL,
  `ISBN` varchar(13) NOT NULL,
  `Judul` varchar(255) NOT NULL,
  `Penulis` varchar(255) NOT NULL,
  `Tahun_terbit` int(4) NOT NULL,
  `Penerbit` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `buku`
--

INSERT INTO `buku` (`Kode_buku`, `ISBN`, `Judul`, `Penulis`, `Tahun_terbit`, `Penerbit`) VALUES
('BK001', '1234567890123', 'Siapa Aku?', 'Mei Mukti Wardana', 2019, 'Cabzlu Studio'),
('BK002', '3210987654321', 'Aku Tidak Tahu', 'Mei Mukti Wardana', 2019, 'Cabzlu Studio'),
('BK003', '1122334455667', 'Apalagi Saya', 'Ivan Cahya Syahputra', 2019, 'Cabzlu Studio'),
('BK004', '1872638471687', 'Kita Semua Tidak Tahu Siapa Anda', 'Ivan Cahya Syahputra', 2019, 'Cabzlu Studio'),
('BK005', '1111111111111', 'Siapa Akuuu', 'Muhammad Idris', 2019, 'Cabzlu Studio');

-- --------------------------------------------------------

--
-- Table structure for table `daftarloginlogoutanggota`
--

CREATE TABLE `daftarloginlogoutanggota` (
  `id` int(10) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `username` varchar(35) NOT NULL,
  `password` varchar(35) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `daftarloginlogoutanggota`
--

INSERT INTO `daftarloginlogoutanggota` (`id`, `nama`, `username`, `password`) VALUES
(1111111111, 'Mei Mukti Wardana', 'admin', 'admin'),
(1111111112, 'Ivan Cahya Syahputra', 'user', 'user'),
(1111111113, 'Ricky Nourman', 'rick', 'rick'),
(1111111114, 'Idris', 'aksdjfkasdf', ''),
(1111111115, 'asdasdasd', '1231231231', ''),
(1111111116, 'zzxcvzxcvzxcv', 'baruzxcvzxcv', ''),
(1111111117, 'qwerqwerqwer', 'qwerqwer', '123123'),
(1111111118, 'sadfasdfasdf', 'asdfasdfa', '11'),
(1111111120, 'kjahksjfhakjsdhkfjhakjdhfkjh', 'lol', 'asdasd'),
(1111111121, 'aku sopo', 'gaeruh', '123321'),
(1111111122, 'asdfasdfasdffdsa', 'asdfa', 'asdfa'),
(1111111123, 'asdfasdf', 'asdf', 'asdf'),
(1111111124, '', 'dana', '123');

-- --------------------------------------------------------

--
-- Table structure for table `daftarloginlogoutpetugas`
--

CREATE TABLE `daftarloginlogoutpetugas` (
  `id` bigint(10) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `NIP` bigint(18) NOT NULL,
  `username` varchar(35) NOT NULL,
  `password` varchar(35) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `daftarloginlogoutpetugas`
--

INSERT INTO `daftarloginlogoutpetugas` (`id`, `nama`, `NIP`, `username`, `password`) VALUES
(8888888889, 'Mei Mukti Wardana', 394925394925394925, 'admin1', 'admin1'),
(8888888890, 'Ivan Cahya Syahputra', 9223372036854775807, 'user', 'user'),
(8888888891, 'Idris', 9223372036854775807, 'idris', 'idris'),
(8888888892, 'qrwerqwerqwerqwerqwer', 9223372036854775807, 'asdf', 'asdf');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `buku`
--
ALTER TABLE `buku`
  ADD PRIMARY KEY (`Kode_buku`);

--
-- Indexes for table `daftarloginlogoutanggota`
--
ALTER TABLE `daftarloginlogoutanggota`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `daftarloginlogoutpetugas`
--
ALTER TABLE `daftarloginlogoutpetugas`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `daftarloginlogoutanggota`
--
ALTER TABLE `daftarloginlogoutanggota`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1111111125;

--
-- AUTO_INCREMENT for table `daftarloginlogoutpetugas`
--
ALTER TABLE `daftarloginlogoutpetugas`
  MODIFY `id` bigint(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2147483647;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
