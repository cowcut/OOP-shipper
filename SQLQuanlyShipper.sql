CREATE DATABASE QuanLyShipper;
USE QuanLyShipper;

CREATE TABLE Shipper (
    MaSP nvarchar(50) PRIMARY KEY,
    emailSP nvarchar(50),
    tenShipper nvarchar(50),
    cccd nvarchar(12),
    sdtShipper nvarchar(13),
    TaiKhoanSP nvarchar(30),
    MatKhauSP nvarchar(30)
);

CREATE TABLE KhachHang (
    MaKH nvarchar(50) PRIMARY KEY,
    TenKH nvarchar(50),
    emailKH nvarchar(50),
    SDTKH nvarchar(13),
    TaiKhoanKH nvarchar(50),
    MatKhauKH nvarchar(50)
);

CREATE TABLE QuanLy (
    MaQL nvarchar(50) PRIMARY KEY,
    TenQL nvarchar(50),
    TaiKhoanQL nvarchar(50),
    MatKhauQL nvarchar(50)
);

CREATE TABLE DonHang (
    MaDon nvarchar(50) PRIMARY KEY,
    TenHang nvarchar(60),
    Diachinhanhang nvarchar(50),
    ThoiDiemNhanHang nvarchar(50),
    Tinhtrangdonhang nvarchar(40),
    GiaTri nvarchar(50),
    MaSP nvarchar(50),
    MaKH nvarchar(50),
    MaQL nvarchar(50),
    Loai_Hang nvarchar(50),
    FOREIGN KEY (MaSP) REFERENCES Shipper (MaSP),
    FOREIGN KEY (MaKH) REFERENCES KhachHang (MaKH),
    FOREIGN KEY (MaQL) REFERENCES QuanLy (MaQL)
);

INSERT INTO KhachHang VALUES ('KH01', 'Nguyen Van A', 'NVA@gmail.com', '0882345124', 'nguyena', '12345');
INSERT INTO KhachHang VALUES ('KH02', 'Tran Ngoc Han', 'TNH@gmail.com', '0908256478', 'tranhan', '23456');
INSERT INTO KhachHang VALUES ('KH03', 'Tran Ngoc Linh', 'TNL@gmail.com', '0938776266', 'tranlinh', '45678');
INSERT INTO KhachHang VALUES ('KH04', 'Tran Minh Long', 'TML@gmail.com', '0917325476', 'tranlong', '56789');
INSERT INTO KhachHang VALUES ('KH05', 'Le Nhat Minh', 'LNM@gmail.com', '0824610824', 'leminh', '67891');
INSERT INTO KhachHang VALUES ('KH06', 'Le Hoai Thuong', 'LHT@gmail.com', '0863173824', 'lethuong', '78912');
INSERT INTO KhachHang VALUES ('KH07', 'Nguyen Van Tam', 'NVT@gmail.com', '0916783565', 'nguyentam', '89123');
INSERT INTO KhachHang VALUES ('KH08', 'Phan Thi Thanh', 'PTT@gmail.com', '0938435756', 'phanthanh', '91234');
INSERT INTO KhachHang VALUES ('KH09', 'Le Ha Vinh', 'LHV@gmail.com', '0865476324', 'levinh', '21345');
INSERT INTO KhachHang VALUES ('KH10', 'Ha Duy Lap', 'HDL@gmail.com', '0876890424', 'halap', '32154');

INSERT INTO Shipper VALUES ('SP01', 'NNN@gmail.com', 'Nguyen Nhu Nhut', '001235678112', '0927345678', 'nguyennhut', '12346');
INSERT INTO Shipper VALUES ('SP02', 'LTPY@gmail.com', 'Le Thi Phi Yen', '001345789123', '0987567390', 'leyen', '13256');
INSERT INTO Shipper VALUES ('SP03', 'NVB@gmail.com', 'Nguyen Van B', '001356781012', '0997047382', 'nguyenb', '23145');
INSERT INTO Shipper VALUES ('SP04', 'NTT@gmail.com', 'Ngo Thanh Tuan', '001456789223', '0913758498', 'ngotuan', '32154');
INSERT INTO Shipper VALUES ('SP05', 'NTTT@gmail.com', 'Nguyen Thi Truc Thanh', '001562879213', '0918590387', 'nguyenthanh', '12458');

INSERT INTO QuanLy VALUES ('QL01', 'Pham Minh Hoang', 'PhamHoang', '12345');
INSERT INTO QuanLy VALUES ('QL02', 'Ngo Tri Dung', 'NgoDung', '23456');

INSERT INTO DonHang VALUES ('DH01', 'Áo thun', '123 Đường ABC', '2023-05-30', 'Chưa hoàn thành', '100000', 'SP01', 'KH01', 'QL01', 'Hàng tiêu dùng');
INSERT INTO DonHang VALUES ('DH02', 'Quần jeans', '456 Đường XYZ', '2023-05-29', N'Đang vận chuyển', '250000', 'SP03', 'KH02', 'QL02', 'Hàng tiêu dùng');
INSERT INTO DonHang VALUES ('DH03', 'Giày thể thao', '789 Đường DEF', '2023-05-28', 'Chưa hoàn thành', '350000', 'SP02', 'KH03', 'QL01', 'Hàng tiêu dùng');
INSERT INTO DonHang VALUES ('DH04', 'Túi xách', '111 Đường GHI', '2023-05-27', 'Đã hoàn thành', '200000', 'SP04', 'KH04', 'QL02', 'Hàng tiêu dùng');
INSERT INTO DonHang VALUES ('DH05', 'Điện thoại di động', '222 Đường JKL', '2023-05-26', 'Đã hoàn thành', '5000000', 'SP05', 'KH05', 'QL01', 'Điện tử');
INSERT INTO DonHang VALUES ('DH06', 'Bún chả', '123 Đường ABC', '2023-05-30', 'Chưa hoàn thành', '50000', 'SP01', 'KH06', 'QL01', N'Đồ ăn');
INSERT INTO DonHang VALUES ('DH07', 'Cơm rang', '456 Đường XYZ', '2023-05-29', N'Đang vận chuyển', '70000', 'SP02', 'KH07', 'QL02', N'Đồ ăn');
INSERT INTO DonHang VALUES ('DH08', 'Bánh mỳ', '789 Đường DEF', '2023-05-28', 'Chưa hoàn thành', '20000', 'SP03', 'KH08', 'QL01', N'Đồ ăn');
INSERT INTO DonHang VALUES ('DH09', 'Pizza', '111 Đường GHI', '2023-05-27', 'Đã hoàn thành', '100000', 'SP04', 'KH09', 'QL02', N'Đồ ăn');
INSERT INTO DonHang VALUES ('DH10', 'Sushi', '222 Đường JKL', '2023-05-26', 'Đã hoàn thành', '150000', 'SP05', 'KH10', 'QL01', N'Đồ ăn');

