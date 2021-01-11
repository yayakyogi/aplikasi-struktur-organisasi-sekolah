-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 20 Jun 2020 pada 06.23
-- Versi server: 10.4.11-MariaDB
-- Versi PHP: 7.2.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sekolah`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_struktur`
--

CREATE TABLE `tb_struktur` (
  `id` int(20) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `jabatan` varchar(255) NOT NULL,
  `alamat` varchar(255) NOT NULL,
  `tingkatan` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tb_struktur`
--

INSERT INTO `tb_struktur` (`id`, `nama`, `jabatan`, `alamat`, `tingkatan`) VALUES
(1, 'Drs. Mucikno,S.Pd,M.Pd', 'Kepala Sekolah', 'Jl. Apel', 'Pimpinan Tinggi'),
(2, 'Yayak', 'Komite Sekolah', 'Bolorejo', 'Pimpinan Tinggi'),
(3, 'Bens', 'Kepala Perpustakaan', 'Jl. Mangga', 'Staf Laboratorium'),
(6, 'Andri', 'Bendahara BOS', 'Jl. Apell', 'Staf Tata Usaha'),
(7, 'AAAA', 'Guru PAI', 'Jl. Manggis', 'Guru');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tb_struktur`
--
ALTER TABLE `tb_struktur`
  ADD PRIMARY KEY (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
