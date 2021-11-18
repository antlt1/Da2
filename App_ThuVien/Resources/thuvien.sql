-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th10 06, 2021 lúc 07:07 AM
-- Phiên bản máy phục vụ: 10.4.21-MariaDB
-- Phiên bản PHP: 8.0.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `thuvien`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `bandoc`
--

CREATE TABLE `bandoc` (
  `id_TaiKhoan` int(10) NOT NULL,
  `hoten` text NOT NULL,
  `sdt` varchar(11) NOT NULL,
  `diachi` text NOT NULL,
  `diem_thanthien` int(10) NOT NULL,
  `solanmuon` int(10) NOT NULL,
  `solandoc` int(10) NOT NULL,
  `trangthai` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `bandoc`
--

INSERT INTO `bandoc` (`id_TaiKhoan`, `hoten`, `sdt`, `diachi`, `diem_thanthien`, `solanmuon`, `solandoc`, `trangthai`) VALUES
(1, 'Nguyễn Văn An', '01283595915', 'トキョ', 0, 0, 1, 'bt'),
(2, 'Lê Vĩ  Dark', '938261234', 'Vĩnh Biệt, Hậu Giang', 0, 0, 2, 'bt'),
(3, 'Quách Hoàng Luân', '0939225182', 'Vĩnh Long', 0, 0, 0, 'bt'),
(4, 'Nguyễn Minh Hùng', '768680033', 'Long An ', 0, 0, 0, 'bt'),
(5, 'Lê Quốc Thống', '786803399', 'Hậu Giang , xã trường long tây', 0, 0, 0, 'bt');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `chucvu`
--

CREATE TABLE `chucvu` (
  `id_chucvu` int(10) NOT NULL,
  `ten_chucvu` text NOT NULL,
  `thongtin` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `chucvu`
--

INSERT INTO `chucvu` (`id_chucvu`, `ten_chucvu`, `thongtin`) VALUES
(1, 'Bạn Đọc', 'Bạn đọc của thư viện'),
(2, 'Admin', 'Quản lý Sever');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `kho`
--

CREATE TABLE `kho` (
  `id_kho` int(10) NOT NULL,
  `id_kho_cu` int(11) NOT NULL,
  `id_kesach` int(11) NOT NULL,
  `trangthai` text NOT NULL,
  `succhua` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `phieu_muonsach`
--

CREATE TABLE `phieu_muonsach` (
  `id_muonsach` int(10) NOT NULL,
  `id_tt_muonsach` int(10) NOT NULL,
  `id_taikhoan_lap` int(10) NOT NULL,
  `id_ngmuon` int(10) NOT NULL,
  `trangthai` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `phieu_muonsach`
--

INSERT INTO `phieu_muonsach` (`id_muonsach`, `id_tt_muonsach`, `id_taikhoan_lap`, `id_ngmuon`, `trangthai`) VALUES
(9, 1, 21, 1, 'Quá Hạn'),
(10, 2, 21, 1, 'Quá Hạn');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `sach`
--

CREATE TABLE `sach` (
  `id_sach` int(10) NOT NULL,
  `id_taikhoan` int(10) NOT NULL,
  `vitri` text NOT NULL,
  `id_theloai` int(10) NOT NULL,
  `tacgia` text NOT NULL,
  `ten_sach` text NOT NULL,
  `src_img` text NOT NULL,
  `ngaysx` date NOT NULL DEFAULT current_timestamp(),
  `gia` mediumint(10) NOT NULL,
  `soluong` int(10) NOT NULL,
  `trangthai` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `sach`
--

INSERT INTO `sach` (`id_sach`, `id_taikhoan`, `vitri`, `id_theloai`, `tacgia`, `ten_sach`, `src_img`, `ngaysx`, `gia`, `soluong`, `trangthai`) VALUES
(1, 21, 'Nhà trọ )) ccccl', 6, 'NVA', 'Cửu dương thần công', 'null', '2021-02-24', 1000000, 0, 'Hết Hàng'),
(2, 21, 'Kệ 1. Ngăng 2', 1, 'Cương Nhã Thành', 'Luyện ngữ pháp anh văn cơ bản', '', '2021-09-01', 90000, 50, 'Nguyên Vẹn'),
(3, 21, 'Kệ 1. Ngăng 1', 1, 'Mr.Justin Nana', 'English for Job', '', '2021-09-01', 150000, 20, 'Ngừng cấp'),
(4, 21, 'Kệ Ngôn ngữ nhật', 5, 'アンさん', '日本語 Bài Mina Ngữ Pháp', 'null', '2021-10-26', 200000, 15, 'Nguyên Vẹn');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `taikhoan`
--

CREATE TABLE `taikhoan` (
  `id_TaiKhoan` int(10) NOT NULL,
  `id_chucvu` int(10) NOT NULL,
  `ten_taikhoan` varchar(255) NOT NULL,
  `matkhau` varchar(255) NOT NULL,
  `hoten` varchar(255) NOT NULL,
  `diachi` text NOT NULL,
  `sdt` int(10) NOT NULL,
  `email` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `taikhoan`
--

INSERT INTO `taikhoan` (`id_TaiKhoan`, `id_chucvu`, `ten_taikhoan`, `matkhau`, `hoten`, `diachi`, `sdt`, `email`) VALUES
(16, 1, 'NgoThiMinhChau', 'C1234567', 'Ngô thị Minh Châu', '', 982527982, 'tranthuy.nute@gmail.com'),
(17, 1, 'DangNguyen1', 'DangNguyen1', 'Nguyễn Đăng', '', 973776072, 'manhhachkt08@gmail.com'),
(18, 1, 'TTK01', 'Trantrungkien', 'Trần Trung Kiên', '', 917749254, 'tienlapspktnd@gmail.com'),
(19, 1, 'TranTung1', 'TranTung', 'Trần Thanh Tùng', '', 904770053, 'tungtunfg@gmail.ocm'),
(20, 1, 'TTH01', 'NTTH', 'Nguyễn Thị Thu Hằng', '', 974880788, 'nvt.isst.nute@gmail.com'),
(21, 2, 'admin', 'admin', 'Nguyễn Văn An', '', 763836005, 'qcgunnyvip@gmail.com');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `theloai`
--

CREATE TABLE `theloai` (
  `id_theloai` int(10) NOT NULL,
  `id_theloaicha` int(10) NOT NULL,
  `id_taikhoan` int(10) NOT NULL,
  `ten_theloai` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `theloai`
--

INSERT INTO `theloai` (`id_theloai`, `id_theloaicha`, `id_taikhoan`, `ten_theloai`) VALUES
(1, 0, 21, 'Tiếng Anh'),
(2, 0, 21, 'Toán'),
(3, 0, 21, 'null'),
(4, 0, 21, 'Khoa Học'),
(5, 0, 21, 'Tiếng Nhật'),
(6, 0, 21, 'An Ninh Quốc Phòng');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `thongtin_muon`
--

CREATE TABLE `thongtin_muon` (
  `id_tt_muon` int(10) NOT NULL,
  `id_sach` int(10) NOT NULL,
  `ngaymuon` date NOT NULL,
  `ngaytra` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `thongtin_muon`
--

INSERT INTO `thongtin_muon` (`id_tt_muon`, `id_sach`, `ngaymuon`, `ngaytra`) VALUES
(1, 3, '2021-10-27', '2021-10-31'),
(1, 4, '2021-10-27', '2021-10-30'),
(2, 1, '2021-10-28', '2021-10-28');

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `bandoc`
--
ALTER TABLE `bandoc`
  ADD PRIMARY KEY (`id_TaiKhoan`);

--
-- Chỉ mục cho bảng `chucvu`
--
ALTER TABLE `chucvu`
  ADD PRIMARY KEY (`id_chucvu`);

--
-- Chỉ mục cho bảng `kho`
--
ALTER TABLE `kho`
  ADD PRIMARY KEY (`id_kho`);

--
-- Chỉ mục cho bảng `phieu_muonsach`
--
ALTER TABLE `phieu_muonsach`
  ADD PRIMARY KEY (`id_muonsach`),
  ADD KEY `fk_nguoilap` (`id_taikhoan_lap`),
  ADD KEY `fk_id_tt_muon` (`id_tt_muonsach`),
  ADD KEY `fk_ngmuon` (`id_ngmuon`);

--
-- Chỉ mục cho bảng `sach`
--
ALTER TABLE `sach`
  ADD PRIMARY KEY (`id_sach`),
  ADD KEY `fk_nguoilap_sach` (`id_taikhoan`),
  ADD KEY `fk_theloai_Sach` (`id_theloai`),
  ADD KEY `fk_tacgia` (`tacgia`(768));

--
-- Chỉ mục cho bảng `taikhoan`
--
ALTER TABLE `taikhoan`
  ADD PRIMARY KEY (`id_TaiKhoan`),
  ADD UNIQUE KEY `ten_taikhoan` (`ten_taikhoan`),
  ADD KEY `fk_chuc_vu` (`id_chucvu`);

--
-- Chỉ mục cho bảng `theloai`
--
ALTER TABLE `theloai`
  ADD PRIMARY KEY (`id_theloai`),
  ADD KEY `fk_nguoitao_tl` (`id_taikhoan`);

--
-- Chỉ mục cho bảng `thongtin_muon`
--
ALTER TABLE `thongtin_muon`
  ADD PRIMARY KEY (`id_tt_muon`,`id_sach`),
  ADD KEY `fk_sach_ttpm` (`id_sach`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `bandoc`
--
ALTER TABLE `bandoc`
  MODIFY `id_TaiKhoan` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT cho bảng `chucvu`
--
ALTER TABLE `chucvu`
  MODIFY `id_chucvu` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT cho bảng `kho`
--
ALTER TABLE `kho`
  MODIFY `id_kho` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT cho bảng `phieu_muonsach`
--
ALTER TABLE `phieu_muonsach`
  MODIFY `id_muonsach` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT cho bảng `sach`
--
ALTER TABLE `sach`
  MODIFY `id_sach` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT cho bảng `taikhoan`
--
ALTER TABLE `taikhoan`
  MODIFY `id_TaiKhoan` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT cho bảng `theloai`
--
ALTER TABLE `theloai`
  MODIFY `id_theloai` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `phieu_muonsach`
--
ALTER TABLE `phieu_muonsach`
  ADD CONSTRAINT `fk_id_tt_muon` FOREIGN KEY (`id_tt_muonsach`) REFERENCES `thongtin_muon` (`id_tt_muon`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_ngmuon` FOREIGN KEY (`id_ngmuon`) REFERENCES `bandoc` (`id_TaiKhoan`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_nguoilap` FOREIGN KEY (`id_taikhoan_lap`) REFERENCES `taikhoan` (`id_TaiKhoan`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Các ràng buộc cho bảng `sach`
--
ALTER TABLE `sach`
  ADD CONSTRAINT `fk_nguoilap_sach` FOREIGN KEY (`id_taikhoan`) REFERENCES `taikhoan` (`id_TaiKhoan`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_theloai_Sach` FOREIGN KEY (`id_theloai`) REFERENCES `theloai` (`id_theloai`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Các ràng buộc cho bảng `taikhoan`
--
ALTER TABLE `taikhoan`
  ADD CONSTRAINT `fk_chuc_vu` FOREIGN KEY (`id_chucvu`) REFERENCES `chucvu` (`id_chucvu`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Các ràng buộc cho bảng `theloai`
--
ALTER TABLE `theloai`
  ADD CONSTRAINT `fk_nguoitao_tl` FOREIGN KEY (`id_taikhoan`) REFERENCES `taikhoan` (`id_TaiKhoan`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Các ràng buộc cho bảng `thongtin_muon`
--
ALTER TABLE `thongtin_muon`
  ADD CONSTRAINT `fk_sach_ttpm` FOREIGN KEY (`id_sach`) REFERENCES `sach` (`id_sach`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
