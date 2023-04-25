create database QuanLyShipper

use QuanLyShipper
 create table Shipper(
 MaSP nvarchar(50) primary key,
 TenSP nvarchar(50),
 CCCD nvarchar(12),
 DiaChi nvarchar(80),
 SDTSP nvarchar(13),
 TaiKhoanNganHang nvarchar(20),
 TinhTrang nvarchar(30),
 TaiKhoanSP nvarchar(30),
 MatKhauSP nvarchar(30),
 )

 create table KhachHang(
 MaKH nvarchar(50) primary key,
 TenKH nvarchar(50),
 SDTKH nvarchar(13),
 TaiKhoanKH nvarchar(50),
 MatKhauKH nvarchar(50),
 )

 create table QuanLy(
 MaQL nvarchar(50) primary key,
 TenQL nvarchar(50),
 TaiKhoanQL nvarchar(50),
 MatKhauQL nvarchar(50),
 )

 create table DonHang(
 MaDon nvarchar(50) primary key,
 TenHang nvarchar(60),
 ThoiDiemNhan nvarchar(50),
 ThoiDiemNhanHang nvarchar(50),
 DiemNhan nvarchar(50),
 DiemDen nvarchar(50),
 GiaTri nvarchar(50),
 TinhTrangDon nvarchar(40),
 MaSP nvarchar(50),
 MaKH nvarchar(50),
 MaQL nvarchar(50),
 )

 alter table dbo.DonHang add Foreign key(MaSP) references dbo.Shipper(MaSP)
 alter table dbo.DonHang add Foreign key(MaKH) references dbo.KhachHang(MaKH)
 alter table dbo.DonHang add Foreign key(MaQL) references dbo.QuanLy(MaQL)

