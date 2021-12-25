-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th12 21, 2021 lúc 01:57 PM
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

DELIMITER $$
--
-- Thủ tục
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpTrangThai` (IN `id_ttm` INT(10), IN `id_sach` INT(10), IN `trangthai` TEXT, IN `tien` DECIMAL(10,0))  MODIFIES SQL DATA
update thongtin_muon t set t.tien = tien , t.trangthai = trangthai where t.id_tt_muon = t.id_tt_muon = id_ttm and t.id_sach = id_sach$$

DELIMITER ;

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
(1, 'Nguyễn Chí Dũng Song Toàn', '01283595915', 'トキョ', 64, 9, 15, 'Bạn đọc thân thiện'),
(2, 'Lê Vĩ  Dark', '938261234', 'Vĩnh Biệt, Hậu Giang', 5, 0, 2, 'bt'),
(3, 'Quách Hoàng Luân', '0939225182', 'Vĩnh Long', 9, 2, 0, 'bt'),
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
(1, 'Nhân viên', 'Nhân viên của thư viện'),
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
-- Cấu trúc bảng cho bảng `phat`
--

CREATE TABLE `phat` (
  `id_phat` int(10) NOT NULL,
  `id_ttpm` int(10) NOT NULL,
  `id_sach` int(10) NOT NULL,
  `id_nglap` int(10) NOT NULL COMMENT 'Người lập phiếu phạt',
  `tienphat` decimal(10,0) NOT NULL,
  `lydo` text NOT NULL,
  `ngayphat` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `phat`
--

INSERT INTO `phat` (`id_phat`, `id_ttpm`, `id_sach`, `id_nglap`, `tienphat`, `lydo`, `ngayphat`) VALUES
(1, 2, 1, 21, '948000', 'Mất sách', '2021-12-04'),
(2, 1, 1, 3, '57500', 'Hư sách', '2021-12-08');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `phieu_muonsach`
--

CREATE TABLE `phieu_muonsach` (
  `id_muonsach` int(10) NOT NULL,
  `id_tt_muonsach` int(10) NOT NULL,
  `id_taikhoan_lap` int(10) NOT NULL,
  `id_ngmuon` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `phieu_muonsach`
--

INSERT INTO `phieu_muonsach` (`id_muonsach`, `id_tt_muonsach`, `id_taikhoan_lap`, `id_ngmuon`) VALUES
(1, 7, 21, 3),
(2, 8, 21, 1),
(3, 9, 1, 4),
(9, 1, 21, 1),
(10, 2, 21, 1),
(11, 5, 21, 5),
(12, 3, 21, 3),
(13, 4, 21, 1),
(14, 6, 21, 3);

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
(1, 21, 'Nhà trọ )) ccccl', 6, 'NVA', 'Cửu dương thần công', 'null', '2021-02-24', 1000000, 2, ''),
(2, 21, 'Kệ 1. Ngăng 2', 1, 'Cương Nhã Thành', 'Luyện ngữ pháp anh văn cơ bản', '', '2021-09-01', 90000, 45, 'Bình thường'),
(3, 21, 'Kệ 1. Ngăng 1', 1, 'Mr.Justin Nana', 'English for Job', '', '2021-09-01', 150000, 17, 'Ngừng cấp'),
(4, 21, 'Kệ Ngôn ngữ nhật', 5, 'アンさん', '日本語 Bài Mina Ngữ Pháp', 'null', '2021-10-26', 200000, 14, 'Nguyên Vẹn'),
(5, 21, 'Kệ ', 7, 'BuLu-An', 'Cuộc phiêu lưu của Đình Nguyên và 4 chú cừu', 'null', '2021-12-06', 20000, 5, 'null'),
(6, 21, 'Kệ Trinh Thám . Ngăng 2', 7, 'Arsen Lupin', 'Siêu trộm hào hoa – Bí mật 813 – Arsène Lupin', 'null', '2020-12-04', 210000, 3, 'null');

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
  `email` varchar(255) NOT NULL,
  `trangthai` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `taikhoan`
--

INSERT INTO `taikhoan` (`id_TaiKhoan`, `id_chucvu`, `ten_taikhoan`, `matkhau`, `hoten`, `diachi`, `sdt`, `email`, `trangthai`) VALUES
(1, 1, 'antlt1', '012210', 'Nguyễn Văn An', 'Vị Thanh', 763836005, 'qcgunnyvip2@gmail.com', 1),
(2, 1, 'NV2', 'null', 'null', 'null', 0, 'null', 1),
(3, 1, 'Hoangluan2k4', 'hoangluan2004', 'Luân út sky', 'null', 0, 'LuanFanSky@gmail.com', 0),
(16, 1, 'NgoThiMinhChau', 'C1234567', 'Ngô thị Minh Châu', '', 982527982, 'tranthuy.nute@gmail.com', 1),
(17, 1, 'DangNguyen1', 'DangNguyen1', 'Nguyễn Đăng', '', 973776072, 'manhhachkt08@gmail.com', 0),
(18, 1, 'TTK01', 'Trantrungkien', 'Trần Trung Kiên', '', 917749254, 'tienlapspktnd@gmail.com', 0),
(19, 1, 'TranTung1', 'TranTung', 'Trần Thanh Tùng', '', 904770053, 'tungtunfg@gmail.ocm', 0),
(20, 1, 'TTH01', 'NTTH', 'Nguyễn Thị Thu Hằng', '', 974880788, 'nvt.isst.nute@gmail.com', 0),
(21, 2, 'admin', 'admin', 'Nguyễn Văn Admin', '10 hai bà Đình Nguyên', 763836005, 'qcgunnyvip@gmail.com', 1);

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
(6, 0, 21, 'An Ninh Quốc Phòng'),
(7, 0, 21, 'Trinh Thám'),
(8, 0, 21, 'Ẩm thực'),
(9, 0, 1, 'Anh văn căn bản 1'),
(10, 0, 1, 'Triết học Mac-Lenin'),
(11, 0, 1, 'Tin học căn bản'),
(12, 0, 1, 'Toán cao cấp 1'),
(13, 0, 1, 'Toán rời rạc 1'),
(14, 0, 1, 'Chủ nghĩa xã hội khoa học'),
(15, 0, 1, 'Kinh tế chính trị'),
(16, 0, 1, 'Lý thuyết xác suất và thống kê toán'),
(17, 0, 1, 'Pháp luật đại cương'),
(18, 0, 1, 'Toán cao cấp 2'),
(19, 0, 1, 'Anh văn căn bản 3'),
(20, 0, 1, 'Cơ sở dữ liệu'),
(21, 0, 1, 'Lập trình căn bản'),
(22, 0, 1, 'Logic học đại cương'),
(23, 0, 1, 'Tư tưởng Hồ Chí Minh'),
(24, 0, 1, 'Kiến trúc máy tính'),
(25, 0, 1, 'Kỹ thuật đồ họa'),
(26, 0, 1, 'Lập trình hướng đối tượng'),
(27, 0, 1, 'Nguyên lý hệ điều hành'),
(28, 0, 1, 'Phân tích và thiết kế thuật toán'),
(29, 0, 1, 'Hệ quản trị cơ sở dữ liệu'),
(30, 0, 1, 'Lập trình web'),
(31, 0, 1, 'Mạng máy tính'),
(32, 0, 1, 'Điện toán đám mây'),
(33, 0, 1, 'Lập trình .net'),
(34, 0, 1, 'Quản trị mạng máy tính'),
(35, 0, 1, 'Trí tuệ nhân tạo'),
(36, 0, 1, 'Cơ sở dữ liệu phân tán'),
(37, 0, 1, 'null'),
(38, 0, 1, 'null');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `thongtin_muon`
--

CREATE TABLE `thongtin_muon` (
  `id_tt_muon` int(10) NOT NULL,
  `id_sach` int(10) NOT NULL,
  `ngaymuon` date NOT NULL,
  `ngaytra` date NOT NULL,
  `tien` decimal(10,0) NOT NULL,
  `trangthai` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `thongtin_muon`
--

INSERT INTO `thongtin_muon` (`id_tt_muon`, `id_sach`, `ngaymuon`, `ngaytra`, `tien`, `trangthai`) VALUES
(1, 1, '2021-10-23', '2021-12-18', '65000', 'Quá hạn'),
(1, 3, '2021-10-27', '2021-12-01', '78000', 'Quá hạn'),
(1, 4, '2021-12-01', '2021-12-05', '39000', 'Quá hạn'),
(2, 1, '2021-10-28', '2021-10-28', '65000', 'Quá hạn'),
(3, 2, '2021-12-04', '2021-12-09', '16000', 'Quá hạn'),
(3, 6, '2021-12-04', '2021-12-11', '0', 'Đã trả'),
(4, 6, '2021-12-04', '2021-12-13', '12000', 'Đã trả'),
(5, 3, '2021-11-08', '2021-12-05', '78000', 'Quá hạn'),
(6, 4, '2021-12-05', '2021-12-06', '39000', 'Quá hạn'),
(6, 6, '2021-12-05', '2021-12-05', '19000', 'Đã trả'),
(7, 2, '2021-12-06', '2021-12-07', '16000', 'Quá hạn'),
(7, 3, '2021-12-06', '2021-12-08', '78000', 'Quá hạn'),
(7, 6, '2021-12-06', '2021-12-11', '12000', 'Quá hạn'),
(8, 6, '2021-12-06', '2021-12-20', '8000', 'Đang mượn'),
(9, 3, '2021-12-20', '2021-12-25', '78000', 'Quá hạn'),
(9, 6, '2021-12-20', '2021-12-25', '0', 'Đang mượn');

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
-- Chỉ mục cho bảng `phat`
--
ALTER TABLE `phat`
  ADD PRIMARY KEY (`id_phat`),
  ADD KEY `fk_phat_ttpm` (`id_ttpm`,`id_sach`),
  ADD KEY `fk_nglap_id` (`id_nglap`);

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
-- AUTO_INCREMENT cho bảng `phat`
--
ALTER TABLE `phat`
  MODIFY `id_phat` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT cho bảng `phieu_muonsach`
--
ALTER TABLE `phieu_muonsach`
  MODIFY `id_muonsach` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT cho bảng `sach`
--
ALTER TABLE `sach`
  MODIFY `id_sach` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT cho bảng `taikhoan`
--
ALTER TABLE `taikhoan`
  MODIFY `id_TaiKhoan` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT cho bảng `theloai`
--
ALTER TABLE `theloai`
  MODIFY `id_theloai` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `phat`
--
ALTER TABLE `phat`
  ADD CONSTRAINT `fk_nglap` FOREIGN KEY (`id_nglap`) REFERENCES `taikhoan` (`id_TaiKhoan`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_phat_ttpm` FOREIGN KEY (`id_ttpm`,`id_sach`) REFERENCES `thongtin_muon` (`id_tt_muon`, `id_sach`) ON DELETE CASCADE ON UPDATE CASCADE;

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
