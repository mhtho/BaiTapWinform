CREATE DATABASE QuanLyPhanMemThi
GO

USE QuanLyPhanMemThi
Go

-- HocSinh
-- TaiKhoanDangNhap_HocSinh
-- GiaoVien
-- TaiKhoanDangNhap_GiaoVien
-- DeThi
-- ChiTiet_DeThi
-- CauHoi_TracNghiem
-- CauHoi_TuLuan
-- KetQua

CREATE TABLE HocSinh (
	maHocSinh int IDENTITY PRIMARY KEY,
	hoTen nvarchar(100) NOT NULL,
	ngaySinh date,
	email varchar(100)
)
GO

CREATE TABLE TaiKhoanDangNhap_Hocsinh (
	tenDangNhap nvarchar(100) PRIMARY KEY,
	matKhau nvarchar(100) NOT NULL,
	maHocSinh int NOT NULL,
	FOREIGN KEY (maHocSinh) REFERENCES dbo.HocSinh(maHocSinh)
)
GO

CREATE TABLE GiaoVien (
	maGiaoVien int IDENTITY PRIMARY KEY,
	hoTen nvarchar(100) NOT NULL,
	email varchar(100),
	soDienThoai varchar(10)
)
GO

CREATE TABLE TaiKhoanDangNhap_GiaoVien (
	tenDangNhap nvarchar(100) PRIMARY KEY,
	matKhau nvarchar(100) NOT NULL,
	maGiaoVien int NOT NULL,
	FOREIGN KEY (maGiaoVien) REFERENCES dbo.GiaoVien(maGiaoVien)
)
GO

CREATE TABLE DeThi (
	maDeThi int IDENTITY PRIMARY KEY,
	maGiaoVien int NOT NULL,
	tenDeThi nvarchar(100) NOT NULL DEFAULT N'...',
	thoiGianLamBai int NOT NULL  DEFAULT 45, -- So phut lam bai
	monThi nvarchar(100) NOT NULL DEFAULT N'Văn',
	diemToiDa float NOT NULL DEFAULT 10,
	FOREIGN KEY (maGiaoVien) REFERENCES dbo.GiaoVien(maGiaoVien)
)
GO

CREATE TABLE CauHoiTracNghiem (
	maCauHoi int IDENTITY PRIMARY KEY,
	noiDung nvarchar(MAX) NOT NULL DEFAULT N'...',
	dapAn1 nvarchar(MAX) NOT NULL DEFAULT N'...',
	dapAn2 nvarchar(MAX) NOT NULL DEFAULT N'...',
	dapAn3 nvarchar(MAX) NOT NULL DEFAULT N'...',
	dapAn4 nvarchar(MAX) NOT NULL DEFAULT N'...',
	cauTraLoi int NOT NULL DEFAULT 1
)
GO

CREATE TABLE CauHoiTuLuan (
	maCauHoi int IDENTITY PRIMARY KEY,
	noiDung nvarchar(MAX) NOT NULL DEFAULT N'...',
	cauTraLoi nvarchar(MAX) NOT NULL DEFAULT N'...'
)
GO

CREATE TABLE ChiTiet_DeThi (
	maChiTietDeThi int IDENTITY PRIMARY KEY,
	maDeThi int NOT NULL,
	maCauHoiTN int,
	maCauHoiTL int,
	FOREIGN KEY (maDeThi) REFERENCES dbo.DeThi(maDeThi),
	FOREIGN KEY (maCauHoiTN) REFERENCES dbo.CauHoiTracNghiem(maCauHoi),
	FOREIGN KEY (maCauHoiTL) REFERENCES dbo.CauHoiTuLuan(maCauHoi)
)
GO

CREATE TABLE KetQua (
	maKetQua int IDENTITY PRIMARY KEY,
	maHocSinh int NOT NULL,
	maDeThi int NOT NULL,
	diem float NOT NULL,
	thoiGianNop datetime NOT NULL,
	FOREIGN KEY (maHocSinh) REFERENCES dbo.HocSinh(maHocSinh),
	FOREIGN KEY (maDeThi) REFERENCES dbo.DeThi(maDeThi)
)
GO

